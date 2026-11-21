using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641F RID: 25631
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCapabilityHostComponent : EntityComponent, ICapabilityGameObject
	{
		// Token: 0x0603E39E RID: 254878 RVA: 0x01212624 File Offset: 0x01210824
		public EntityCapabilityHostComponent()
		{
			this.Host = new CapabilityHostImpl(new CapabilityHostInitParam
			{
				Id = new Func<string>(delegate
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Entity#");
					Entity entity = base.Entity;
					defaultInterpolatedStringHandler.AppendFormatted<int?>((entity != null) ? new int?(entity.Id) : null);
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}),
				IsValid = (() => base.Active),
				GetBoundActor = delegate
				{
					Entity entity = base.Entity;
					if (entity == null)
					{
						return null;
					}
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					if (component == null)
					{
						return null;
					}
					return component.Owner;
				}
			});
		}

		// Token: 0x0603E39F RID: 254879 RVA: 0x0121267D File Offset: 0x0121087D
		protected override bool OnStart()
		{
			this.Host.Register();
			return true;
		}

		// Token: 0x0603E3A0 RID: 254880 RVA: 0x0121268B File Offset: 0x0121088B
		protected override bool OnEnd()
		{
			this.Host.Unregister();
			return true;
		}

		// Token: 0x0603E3A1 RID: 254881 RVA: 0x01212699 File Offset: 0x01210899
		protected override void OnTick(float deltaMilliseconds)
		{
			this.Host.TickOutside(deltaMilliseconds);
		}

		// Token: 0x0603E3A2 RID: 254882 RVA: 0x012126A7 File Offset: 0x012108A7
		public string GetId()
		{
			return this.Host.GetId();
		}

		// Token: 0x0603E3A3 RID: 254883 RVA: 0x012126B4 File Offset: 0x012108B4
		public bool IsValid()
		{
			return this.Host.IsValid();
		}

		// Token: 0x0603E3A4 RID: 254884 RVA: 0x012126C1 File Offset: 0x012108C1
		[NullableContext(2)]
		public AActor GetBoundActor()
		{
			return this.Host.GetBoundActor();
		}

		// Token: 0x0603E3A5 RID: 254885 RVA: 0x012126CE File Offset: 0x012108CE
		public T AddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.AddCapabilityData<T>(ctor);
		}

		// Token: 0x0603E3A6 RID: 254886 RVA: 0x012126DC File Offset: 0x012108DC
		[return: Nullable(2)]
		public T GetCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.GetCapabilityData<T>(ctor);
		}

		// Token: 0x0603E3A7 RID: 254887 RVA: 0x012126EA File Offset: 0x012108EA
		public T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.GetOrAddCapabilityData<T>(ctor);
		}

		// Token: 0x0603E3A8 RID: 254888 RVA: 0x012126F8 File Offset: 0x012108F8
		public bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.HasCapabilityData<T>(ctor);
		}

		// Token: 0x0603E3A9 RID: 254889 RVA: 0x01212706 File Offset: 0x01210906
		public T AddCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.AddCapability<T>(ctor);
		}

		// Token: 0x0603E3AA RID: 254890 RVA: 0x01212714 File Offset: 0x01210914
		public bool RemoveCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.RemoveCapability<T>(ctor);
		}

		// Token: 0x0603E3AB RID: 254891 RVA: 0x01212722 File Offset: 0x01210922
		public IReadOnlyDictionary<Type, Capability> GetCapabilities()
		{
			return this.Host.GetCapabilities();
		}

		// Token: 0x0603E3AC RID: 254892 RVA: 0x0121272F File Offset: 0x0121092F
		[return: Nullable(2)]
		public T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.GetCapability<T>(ctor);
		}

		// Token: 0x0603E3AD RID: 254893 RVA: 0x0121273D File Offset: 0x0121093D
		public void BlockCapabilities(int tag, object instigator)
		{
			this.Host.BlockCapabilities(tag, instigator);
		}

		// Token: 0x0603E3AE RID: 254894 RVA: 0x0121274C File Offset: 0x0121094C
		public void UnblockCapabilities(int tag, object instigator)
		{
			this.Host.UnblockCapabilities(tag, instigator);
		}

		// Token: 0x0603E3AF RID: 254895 RVA: 0x0121275B File Offset: 0x0121095B
		public bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state)
		{
			return this.Host.IsCapabilityState(cap, state);
		}

		// Token: 0x0603E3B0 RID: 254896 RVA: 0x0121276A File Offset: 0x0121096A
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			return base.ClearComponent(componentTemplate) && (((EntityCapabilityHostComponent)componentTemplate).Host == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Host), "Host"));
		}

		// Token: 0x17007667 RID: 30311
		// (get) Token: 0x0603E3B1 RID: 254897 RVA: 0x0121279F File Offset: 0x0121099F
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007668 RID: 30312
		// (get) Token: 0x0603E3B2 RID: 254898 RVA: 0x012127A2 File Offset: 0x012109A2
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007669 RID: 30313
		// (get) Token: 0x0603E3B3 RID: 254899 RVA: 0x012127A5 File Offset: 0x012109A5
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040211D0 RID: 135632
		private readonly CapabilityHostImpl Host;
	}
}
