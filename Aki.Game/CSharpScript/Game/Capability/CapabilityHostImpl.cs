using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641D RID: 25629
	[NullableContext(1)]
	[Nullable(0)]
	public class CapabilityHostImpl : ICapabilityGameObject, IClear
	{
		// Token: 0x0603E37E RID: 254846 RVA: 0x012120DD File Offset: 0x012102DD
		public CapabilityHostImpl(ICapabilityHostInitParam Init)
		{
			this.Init = Init;
		}

		// Token: 0x0603E37F RID: 254847 RVA: 0x01212104 File Offset: 0x01210304
		public string GetId()
		{
			Func<string> func = this.Init.Id as Func<string>;
			if (func == null)
			{
				return (string)this.Init.Id;
			}
			return func();
		}

		// Token: 0x0603E380 RID: 254848 RVA: 0x0121213C File Offset: 0x0121033C
		public bool IsValid()
		{
			Func<bool> isValid = this.Init.IsValid;
			return isValid == null || isValid();
		}

		// Token: 0x0603E381 RID: 254849 RVA: 0x01212154 File Offset: 0x01210354
		[NullableContext(2)]
		public AActor GetBoundActor()
		{
			Func<AActor> getBoundActor = this.Init.GetBoundActor;
			if (getBoundActor == null)
			{
				return null;
			}
			return getBoundActor();
		}

		// Token: 0x0603E382 RID: 254850 RVA: 0x0121216C File Offset: 0x0121036C
		public T AddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			if (this.DataComponents.ContainsKey(ctor))
			{
				return this.DataComponents[ctor] as T;
			}
			T t = (T)((object)Activator.CreateInstance(ctor, new object[]
			{
				this
			}));
			this.DataComponents[ctor] = t;
			t.OnAdded();
			return t;
		}

		// Token: 0x0603E383 RID: 254851 RVA: 0x012121D4 File Offset: 0x012103D4
		[return: Nullable(2)]
		public T GetCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			CapabilityData valueOrDefault = this.DataComponents.GetValueOrDefault(ctor);
			if (valueOrDefault != null)
			{
				return valueOrDefault as T;
			}
			return default(T);
		}

		// Token: 0x0603E384 RID: 254852 RVA: 0x01212206 File Offset: 0x01210406
		public T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			T result;
			if ((result = this.GetCapabilityData<T>(ctor)) == null)
			{
				result = this.AddCapabilityData<T>(ctor);
			}
			return result;
		}

		// Token: 0x0603E385 RID: 254853 RVA: 0x0121221F File Offset: 0x0121041F
		public bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.DataComponents.ContainsKey(ctor);
		}

		// Token: 0x0603E386 RID: 254854 RVA: 0x01212230 File Offset: 0x01210430
		public T AddCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			Capability valueOrDefault = this.Capabilities.GetValueOrDefault(ctor);
			if (valueOrDefault != null)
			{
				return valueOrDefault as T;
			}
			T t = (T)((object)Activator.CreateInstance(ctor, new object[]
			{
				this
			}));
			this.Capabilities[ctor] = t;
			t.Setup();
			t.InternalMarkSetupDone();
			CapabilityController.Instance.OnCapabilityAdded(t);
			return t;
		}

		// Token: 0x0603E387 RID: 254855 RVA: 0x012122A8 File Offset: 0x012104A8
		public bool RemoveCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			Capability valueOrDefault = this.Capabilities.GetValueOrDefault(ctor);
			if (valueOrDefault == null)
			{
				return false;
			}
			this.Capabilities.Remove(ctor);
			CapabilityController.Instance.OnCapabilityRemoved(valueOrDefault);
			if (valueOrDefault.IsActive())
			{
				valueOrDefault.OnDeactivated();
				valueOrDefault.InternalSetDeactivated();
			}
			return true;
		}

		// Token: 0x0603E388 RID: 254856 RVA: 0x012122F4 File Offset: 0x012104F4
		public IReadOnlyDictionary<Type, Capability> GetCapabilities()
		{
			return this.Capabilities;
		}

		// Token: 0x0603E389 RID: 254857 RVA: 0x012122FC File Offset: 0x012104FC
		[return: Nullable(2)]
		public T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Capabilities.GetValueOrDefault(ctor) as T;
		}

		// Token: 0x0603E38A RID: 254858 RVA: 0x01212314 File Offset: 0x01210514
		public void BlockCapabilities(int tag, object instigator)
		{
			foreach (Capability capability in this.Capabilities.Values)
			{
				if (capability.GetConfig().Tags.Contains(tag))
				{
					capability.InternalAddBlock(new ICapabilityBlockEntry
					{
						Tag = tag,
						Instigator = instigator
					});
					CapabilityController.Instance.OnCapabilityBlocked(capability, tag);
					if (capability.IsActive())
					{
						capability.OnDeactivated();
						capability.InternalSetDeactivated();
					}
				}
			}
		}

		// Token: 0x0603E38B RID: 254859 RVA: 0x012123B4 File Offset: 0x012105B4
		public void UnblockCapabilities(int tag, object instigator)
		{
			foreach (Capability capability in this.Capabilities.Values)
			{
				if (capability.GetConfig().Tags.Contains(tag))
				{
					capability.InternalRemoveBlock(tag, instigator);
					if (!capability.IsBlocked())
					{
						CapabilityController.Instance.OnCapabilityUnblocked(capability, tag);
					}
				}
			}
		}

		// Token: 0x0603E38C RID: 254860 RVA: 0x01212434 File Offset: 0x01210634
		public bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state)
		{
			return cap.GetState() == state;
		}

		// Token: 0x0603E38D RID: 254861 RVA: 0x0121243F File Offset: 0x0121063F
		public void Register()
		{
			CapabilityController.Instance.RegisterGameObject(this);
		}

		// Token: 0x0603E38E RID: 254862 RVA: 0x0121244C File Offset: 0x0121064C
		public void Unregister()
		{
			foreach (Capability capability in this.Capabilities.Values)
			{
				CapabilityController.Instance.OnCapabilityRemoved(capability);
				if (capability.IsActive())
				{
					capability.OnDeactivated();
					capability.InternalSetDeactivated();
				}
			}
			this.Capabilities.Clear();
			foreach (CapabilityData capabilityData in this.DataComponents.Values)
			{
				capabilityData.OnRemoved();
			}
			this.DataComponents.Clear();
			CapabilityController.Instance.UnregisterGameObject(this);
		}

		// Token: 0x0603E38F RID: 254863 RVA: 0x01212524 File Offset: 0x01210724
		public void TickOutside(float deltaMilliseconds)
		{
			CapabilityController.Instance.TickHostDefaultGroup(this, deltaMilliseconds);
		}

		// Token: 0x0603E390 RID: 254864 RVA: 0x01212532 File Offset: 0x01210732
		public bool ClearObject()
		{
			this.Unregister();
			return true;
		}

		// Token: 0x040211C4 RID: 135620
		private readonly Dictionary<Type, CapabilityData> DataComponents = new Dictionary<Type, CapabilityData>();

		// Token: 0x040211C5 RID: 135621
		private readonly Dictionary<Type, Capability> Capabilities = new Dictionary<Type, Capability>();

		// Token: 0x040211C6 RID: 135622
		private readonly ICapabilityHostInitParam Init;
	}
}
