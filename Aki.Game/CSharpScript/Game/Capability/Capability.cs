using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x02006418 RID: 25624
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Capability : IGameCapability
	{
		// Token: 0x0603E33A RID: 254778 RVA: 0x01210D0E File Offset: 0x0120EF0E
		[NullableContext(2)]
		protected Capability(ICapabilityGameObject ownerGameObject = null)
		{
		}

		// Token: 0x0603E33B RID: 254779 RVA: 0x01210D28 File Offset: 0x0120EF28
		protected virtual ICapabilityConfig GetDefaultConfig()
		{
			return new CapabilityConfig
			{
				Tags = new List<int>(),
				TickGroup = null,
				TickGroupOrder = 100,
				InterruptsTags = new List<int>()
			};
		}

		// Token: 0x0603E33C RID: 254780 RVA: 0x01210D67 File Offset: 0x0120EF67
		public ICapabilityConfig GetConfig()
		{
			if (this.CachedConfig == null)
			{
				this.CachedConfig = this.GetDefaultConfig();
			}
			return this.CachedConfig;
		}

		// Token: 0x0603E33D RID: 254781
		public abstract void Setup();

		// Token: 0x0603E33E RID: 254782
		public abstract void PreTick(float deltaMilliseconds);

		// Token: 0x0603E33F RID: 254783
		public abstract bool ShouldActivate();

		// Token: 0x0603E340 RID: 254784
		public abstract bool ShouldDeactivate();

		// Token: 0x0603E341 RID: 254785
		public abstract void OnActivated();

		// Token: 0x0603E342 RID: 254786 RVA: 0x01210D83 File Offset: 0x0120EF83
		public virtual void Activate()
		{
		}

		// Token: 0x0603E343 RID: 254787 RVA: 0x01210D85 File Offset: 0x0120EF85
		public virtual void Deactivate()
		{
		}

		// Token: 0x0603E344 RID: 254788
		public abstract void OnDeactivated();

		// Token: 0x0603E345 RID: 254789
		public abstract void TickActive(float deltaMilliseconds);

		// Token: 0x0603E346 RID: 254790 RVA: 0x01210D87 File Offset: 0x0120EF87
		public bool IsActive()
		{
			return this.State == CapabilityCommonDefine.ECapabilityState.Active;
		}

		// Token: 0x0603E347 RID: 254791 RVA: 0x01210D92 File Offset: 0x0120EF92
		public bool IsBlocked()
		{
			return this.BlockedBy.Count > 0;
		}

		// Token: 0x0603E348 RID: 254792 RVA: 0x01210DA2 File Offset: 0x0120EFA2
		public CapabilityCommonDefine.ECapabilityState GetState()
		{
			return this.State;
		}

		// Token: 0x0603E349 RID: 254793 RVA: 0x01210DAA File Offset: 0x0120EFAA
		public string GetCapabilityId()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			return ((ownerGameObject != null) ? ownerGameObject.GetId() : null) + ":" + base.GetType().Name;
		}

		// Token: 0x0603E34A RID: 254794 RVA: 0x01210DD3 File Offset: 0x0120EFD3
		public void InternalMarkSetupDone()
		{
			if (this.State == CapabilityCommonDefine.ECapabilityState.Inactive)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Deactivated;
			}
		}

		// Token: 0x0603E34B RID: 254795 RVA: 0x01210DE4 File Offset: 0x0120EFE4
		public void InternalSetActive()
		{
			if (this.State != CapabilityCommonDefine.ECapabilityState.Active)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Active;
			}
		}

		// Token: 0x0603E34C RID: 254796 RVA: 0x01210DF6 File Offset: 0x0120EFF6
		public void InternalSetDeactivated()
		{
			if (this.State == CapabilityCommonDefine.ECapabilityState.Active)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Deactivated;
			}
		}

		// Token: 0x0603E34D RID: 254797 RVA: 0x01210E08 File Offset: 0x0120F008
		public void InternalAddBlock(ICapabilityBlockEntry entry)
		{
			this.BlockedBy.Add(entry);
		}

		// Token: 0x0603E34E RID: 254798 RVA: 0x01210E18 File Offset: 0x0120F018
		public void InternalRemoveBlock(int tag, object instigator)
		{
			for (int i = this.BlockedBy.Count - 1; i >= 0; i--)
			{
				ICapabilityBlockEntry capabilityBlockEntry = this.BlockedBy[i];
				if (capabilityBlockEntry.Tag == tag && capabilityBlockEntry.Instigator == instigator)
				{
					this.BlockedBy.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x040211AE RID: 135598
		private CapabilityCommonDefine.ECapabilityState State;

		// Token: 0x040211AF RID: 135599
		private readonly List<ICapabilityBlockEntry> BlockedBy = new List<ICapabilityBlockEntry>();

		// Token: 0x040211B0 RID: 135600
		[Nullable(2)]
		private ICapabilityConfig CachedConfig;

		// Token: 0x040211B1 RID: 135601
		[Nullable(2)]
		public ICapabilityGameObject OwnerGameObject = ownerGameObject;
	}
}
