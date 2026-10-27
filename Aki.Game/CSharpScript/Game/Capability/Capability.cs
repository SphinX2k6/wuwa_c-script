using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x02007299 RID: 29337
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Capability : IGameCapability
	{
		// Token: 0x06047F74 RID: 294772 RVA: 0x0126FCC0 File Offset: 0x0126DEC0
		[NullableContext(2)]
		protected Capability(ICapabilityGameObject ownerGameObject = null)
		{
		}

		// Token: 0x06047F75 RID: 294773 RVA: 0x0126FCDC File Offset: 0x0126DEDC
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

		// Token: 0x06047F76 RID: 294774 RVA: 0x0126FD1B File Offset: 0x0126DF1B
		public ICapabilityConfig GetConfig()
		{
			if (this.CachedConfig == null)
			{
				this.CachedConfig = this.GetDefaultConfig();
			}
			return this.CachedConfig;
		}

		// Token: 0x06047F77 RID: 294775
		public abstract void Setup();

		// Token: 0x06047F78 RID: 294776
		public abstract void PreTick(float deltaMilliseconds);

		// Token: 0x06047F79 RID: 294777
		public abstract bool ShouldActivate();

		// Token: 0x06047F7A RID: 294778
		public abstract bool ShouldDeactivate();

		// Token: 0x06047F7B RID: 294779
		public abstract void OnActivated();

		// Token: 0x06047F7C RID: 294780 RVA: 0x0126FD37 File Offset: 0x0126DF37
		public virtual void Activate()
		{
		}

		// Token: 0x06047F7D RID: 294781 RVA: 0x0126FD39 File Offset: 0x0126DF39
		public virtual void Deactivate()
		{
		}

		// Token: 0x06047F7E RID: 294782
		public abstract void OnDeactivated();

		// Token: 0x06047F7F RID: 294783
		public abstract void TickActive(float deltaMilliseconds);

		// Token: 0x06047F80 RID: 294784 RVA: 0x0126FD3B File Offset: 0x0126DF3B
		public bool IsActive()
		{
			return this.State == CapabilityCommonDefine.ECapabilityState.Active;
		}

		// Token: 0x06047F81 RID: 294785 RVA: 0x0126FD46 File Offset: 0x0126DF46
		public bool IsBlocked()
		{
			return this.BlockedBy.Count > 0;
		}

		// Token: 0x06047F82 RID: 294786 RVA: 0x0126FD56 File Offset: 0x0126DF56
		public CapabilityCommonDefine.ECapabilityState GetState()
		{
			return this.State;
		}

		// Token: 0x06047F83 RID: 294787 RVA: 0x0126FD5E File Offset: 0x0126DF5E
		public string GetCapabilityId()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			return ((ownerGameObject != null) ? ownerGameObject.GetId() : null) + ":" + base.GetType().Name;
		}

		// Token: 0x06047F84 RID: 294788 RVA: 0x0126FD87 File Offset: 0x0126DF87
		public void InternalMarkSetupDone()
		{
			if (this.State == CapabilityCommonDefine.ECapabilityState.Inactive)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Deactivated;
			}
		}

		// Token: 0x06047F85 RID: 294789 RVA: 0x0126FD98 File Offset: 0x0126DF98
		public void InternalSetActive()
		{
			if (this.State != CapabilityCommonDefine.ECapabilityState.Active)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Active;
			}
		}

		// Token: 0x06047F86 RID: 294790 RVA: 0x0126FDAA File Offset: 0x0126DFAA
		public void InternalSetDeactivated()
		{
			if (this.State == CapabilityCommonDefine.ECapabilityState.Active)
			{
				this.State = CapabilityCommonDefine.ECapabilityState.Deactivated;
			}
		}

		// Token: 0x06047F87 RID: 294791 RVA: 0x0126FDBC File Offset: 0x0126DFBC
		public void InternalAddBlock(ICapabilityBlockEntry entry)
		{
			this.BlockedBy.Add(entry);
		}

		// Token: 0x06047F88 RID: 294792 RVA: 0x0126FDCC File Offset: 0x0126DFCC
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

		// Token: 0x04025EDB RID: 155355
		private CapabilityCommonDefine.ECapabilityState State;

		// Token: 0x04025EDC RID: 155356
		private readonly List<ICapabilityBlockEntry> BlockedBy = new List<ICapabilityBlockEntry>();

		// Token: 0x04025EDD RID: 155357
		[Nullable(2)]
		private ICapabilityConfig CachedConfig;

		// Token: 0x04025EDE RID: 155358
		[Nullable(2)]
		public ICapabilityGameObject OwnerGameObject = ownerGameObject;
	}
}
