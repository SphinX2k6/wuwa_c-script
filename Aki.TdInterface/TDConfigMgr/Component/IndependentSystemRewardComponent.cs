using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A9 RID: 1449
	public class IndependentSystemRewardComponent : IComponentBase
	{
		// Token: 0x06001D80 RID: 7552 RVA: 0x0005461C File Offset: 0x0005281C
		private IndependentSystemRewardComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IndependentSystemRewardComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IndependentSystemRewardComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IndependentSystemRewardComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00054654 File Offset: 0x00052854
		public static IndependentSystemRewardComponent Create([Nullable(2)] IndependentSystemRewardComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IndependentSystemRewardComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00054667 File Offset: 0x00052867
		public static IndependentSystemRewardComponent CreateFromSetValue([Nullable(2)] IndependentSystemRewardComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IndependentSystemRewardComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0005467A File Offset: 0x0005287A
		public new IndependentSystemRewardComponent_SetValue ToSetValue()
		{
			return new IndependentSystemRewardComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RewardType = this.RewardType
			};
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000546A8 File Offset: 0x000528A8
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x000546E2 File Offset: 0x000528E2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IndependentSystemRewardComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000546F0 File Offset: 0x000528F0
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0005471A File Offset: 0x0005291A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00054728 File Offset: 0x00052928
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00054789 File Offset: 0x00052989
		public virtual IDarkTideIndependentSystemReward RewardType
		{
			get
			{
				if (this._RewardTypeInited)
				{
					return this._RewardTypeCache;
				}
				this._RewardTypeInited = true;
				if (this.FbInstance != null)
				{
					this._RewardTypeCache = IDarkTideIndependentSystemReward.Create(this.FbInstance.RewardType);
				}
				else
				{
					IndependentSystemRewardComponent_SetValue pocoInterface = this.PocoInterface;
					this._RewardTypeCache = ((pocoInterface != null) ? pocoInterface.RewardType : null);
				}
				return this._RewardTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().RewardType = value;
				this._RewardTypeInited = false;
			}
		}

		// Token: 0x04001538 RID: 5432
		[Nullable(2)]
		protected new IndependentSystemRewardComponent FbInstance;

		// Token: 0x04001539 RID: 5433
		[Nullable(2)]
		protected new IndependentSystemRewardComponent_SetValue PocoInterface;

		// Token: 0x0400153A RID: 5434
		private IDarkTideIndependentSystemReward _RewardTypeCache;

		// Token: 0x0400153B RID: 5435
		private bool _RewardTypeInited;
	}
}
