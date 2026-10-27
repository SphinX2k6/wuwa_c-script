using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x020072A0 RID: 29344
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCapabilityHostComponent : EntityComponent, ICapabilityGameObject
	{
		// Token: 0x06047FD8 RID: 294872 RVA: 0x0127167C File Offset: 0x0126F87C
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

		// Token: 0x06047FD9 RID: 294873 RVA: 0x012716D5 File Offset: 0x0126F8D5
		protected override bool OnStart()
		{
			this.Host.Register();
			return true;
		}

		// Token: 0x06047FDA RID: 294874 RVA: 0x012716E3 File Offset: 0x0126F8E3
		protected override bool OnEnd()
		{
			this.Host.Unregister();
			return true;
		}

		// Token: 0x06047FDB RID: 294875 RVA: 0x012716F1 File Offset: 0x0126F8F1
		protected override void OnTick(float deltaMilliseconds)
		{
			this.Host.TickOutside(deltaMilliseconds);
		}

		// Token: 0x06047FDC RID: 294876 RVA: 0x012716FF File Offset: 0x0126F8FF
		public string GetId()
		{
			return this.Host.GetId();
		}

		// Token: 0x06047FDD RID: 294877 RVA: 0x0127170C File Offset: 0x0126F90C
		public bool IsValid()
		{
			return this.Host.IsValid();
		}

		// Token: 0x06047FDE RID: 294878 RVA: 0x01271719 File Offset: 0x0126F919
		[NullableContext(2)]
		public AActor GetBoundActor()
		{
			return this.Host.GetBoundActor();
		}

		// Token: 0x06047FDF RID: 294879 RVA: 0x01271726 File Offset: 0x0126F926
		public T AddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.AddCapabilityData<T>(ctor);
		}

		// Token: 0x06047FE0 RID: 294880 RVA: 0x01271734 File Offset: 0x0126F934
		[return: Nullable(2)]
		public T GetCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.GetCapabilityData<T>(ctor);
		}

		// Token: 0x06047FE1 RID: 294881 RVA: 0x01271742 File Offset: 0x0126F942
		public T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.GetOrAddCapabilityData<T>(ctor);
		}

		// Token: 0x06047FE2 RID: 294882 RVA: 0x01271750 File Offset: 0x0126F950
		public bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData
		{
			return this.Host.HasCapabilityData<T>(ctor);
		}

		// Token: 0x06047FE3 RID: 294883 RVA: 0x0127175E File Offset: 0x0126F95E
		public T AddCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.AddCapability<T>(ctor);
		}

		// Token: 0x06047FE4 RID: 294884 RVA: 0x0127176C File Offset: 0x0126F96C
		public bool RemoveCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.RemoveCapability<T>(ctor);
		}

		// Token: 0x06047FE5 RID: 294885 RVA: 0x0127177A File Offset: 0x0126F97A
		public IReadOnlyDictionary<Type, Capability> GetCapabilities()
		{
			return this.Host.GetCapabilities();
		}

		// Token: 0x06047FE6 RID: 294886 RVA: 0x01271787 File Offset: 0x0126F987
		[return: Nullable(2)]
		public T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability
		{
			return this.Host.GetCapability<T>(ctor);
		}

		// Token: 0x06047FE7 RID: 294887 RVA: 0x01271795 File Offset: 0x0126F995
		public void BlockCapabilities(int tag, object instigator)
		{
			this.Host.BlockCapabilities(tag, instigator);
		}

		// Token: 0x06047FE8 RID: 294888 RVA: 0x012717A4 File Offset: 0x0126F9A4
		public void UnblockCapabilities(int tag, object instigator)
		{
			this.Host.UnblockCapabilities(tag, instigator);
		}

		// Token: 0x06047FE9 RID: 294889 RVA: 0x012717B3 File Offset: 0x0126F9B3
		public bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state)
		{
			return this.Host.IsCapabilityState(cap, state);
		}

		// Token: 0x06047FEA RID: 294890 RVA: 0x012717C4 File Offset: 0x0126F9C4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			EntityCapabilityHostComponent entityCapabilityHostComponent = (EntityCapabilityHostComponent)componentTemplate;
			return !base.CanResetComponentProperty("Host") || entityCapabilityHostComponent.Host == null || base.CheckClearObject(EntityComponentSystem.ClearObject<CapabilityHostImpl>(this.Host), "Host");
		}

		// Token: 0x04025EFD RID: 155389
		private readonly CapabilityHostImpl Host;
	}
}
