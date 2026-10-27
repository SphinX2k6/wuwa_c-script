using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729E RID: 29342
	[NullableContext(1)]
	[Nullable(0)]
	public class CapabilityHostImpl : ICapabilityGameObject, IClear
	{
		// Token: 0x06047FB8 RID: 294840 RVA: 0x012710E1 File Offset: 0x0126F2E1
		public CapabilityHostImpl(ICapabilityHostInitParam Init)
		{
			this.Init = Init;
		}

		// Token: 0x06047FB9 RID: 294841 RVA: 0x01271108 File Offset: 0x0126F308
		public string GetId()
		{
			Func<string> func = this.Init.Id as Func<string>;
			if (func == null)
			{
				return (string)this.Init.Id;
			}
			return func();
		}

		// Token: 0x06047FBA RID: 294842 RVA: 0x01271140 File Offset: 0x0126F340
		public bool IsValid()
		{
			Func<bool> isValid = this.Init.IsValid;
			return isValid == null || isValid();
		}

		// Token: 0x06047FBB RID: 294843 RVA: 0x01271158 File Offset: 0x0126F358
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

		// Token: 0x06047FBC RID: 294844 RVA: 0x01271170 File Offset: 0x0126F370
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

		// Token: 0x06047FBD RID: 294845 RVA: 0x012711D8 File Offset: 0x0126F3D8
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

		// Token: 0x06047FBE RID: 294846 RVA: 0x0127120A File Offset: 0x0126F40A
		public T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			T result;
			if ((result = this.GetCapabilityData<T>(ctor)) == null)
			{
				result = this.AddCapabilityData<T>(ctor);
			}
			return result;
		}

		// Token: 0x06047FBF RID: 294847 RVA: 0x01271223 File Offset: 0x0126F423
		public bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.DataComponents.ContainsKey(ctor);
		}

		// Token: 0x06047FC0 RID: 294848 RVA: 0x01271234 File Offset: 0x0126F434
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

		// Token: 0x06047FC1 RID: 294849 RVA: 0x012712AC File Offset: 0x0126F4AC
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

		// Token: 0x06047FC2 RID: 294850 RVA: 0x012712F8 File Offset: 0x0126F4F8
		public IReadOnlyDictionary<Type, Capability> GetCapabilities()
		{
			return this.Capabilities;
		}

		// Token: 0x06047FC3 RID: 294851 RVA: 0x01271300 File Offset: 0x0126F500
		[return: Nullable(2)]
		public T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Capabilities.GetValueOrDefault(ctor) as T;
		}

		// Token: 0x06047FC4 RID: 294852 RVA: 0x01271318 File Offset: 0x0126F518
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

		// Token: 0x06047FC5 RID: 294853 RVA: 0x012713B8 File Offset: 0x0126F5B8
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

		// Token: 0x06047FC6 RID: 294854 RVA: 0x01271438 File Offset: 0x0126F638
		public bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state)
		{
			return cap.GetState() == state;
		}

		// Token: 0x06047FC7 RID: 294855 RVA: 0x01271443 File Offset: 0x0126F643
		public void Register()
		{
			CapabilityController.Instance.RegisterGameObject(this);
		}

		// Token: 0x06047FC8 RID: 294856 RVA: 0x01271450 File Offset: 0x0126F650
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

		// Token: 0x06047FC9 RID: 294857 RVA: 0x01271528 File Offset: 0x0126F728
		public void TickOutside(float deltaMilliseconds)
		{
			CapabilityController.Instance.TickHostDefaultGroup(this, deltaMilliseconds);
		}

		// Token: 0x06047FCA RID: 294858 RVA: 0x01271536 File Offset: 0x0126F736
		public bool ClearObject()
		{
			this.Unregister();
			return true;
		}

		// Token: 0x04025EF1 RID: 155377
		private readonly Dictionary<Type, CapabilityData> DataComponents = new Dictionary<Type, CapabilityData>();

		// Token: 0x04025EF2 RID: 155378
		private readonly Dictionary<Type, Capability> Capabilities = new Dictionary<Type, Capability>();

		// Token: 0x04025EF3 RID: 155379
		private readonly ICapabilityHostInitParam Init;
	}
}
