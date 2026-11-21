using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005C RID: 92
	public class DynamicEntityRewardComponent : IComponentBase
	{
		// Token: 0x0600030A RID: 778 RVA: 0x0001B824 File Offset: 0x00019A24
		private DynamicEntityRewardComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicEntityRewardComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicEntityRewardComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicEntityRewardComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001B85C File Offset: 0x00019A5C
		public static DynamicEntityRewardComponent Create([Nullable(2)] DynamicEntityRewardComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicEntityRewardComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0001B86F File Offset: 0x00019A6F
		public static DynamicEntityRewardComponent CreateFromSetValue([Nullable(2)] DynamicEntityRewardComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicEntityRewardComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0001B884 File Offset: 0x00019A84
		public new DynamicEntityRewardComponent_SetValue ToSetValue()
		{
			return new DynamicEntityRewardComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RewardType = this.RewardType,
				ClaimTypes = this.ClaimTypes,
				RewardActions = this.RewardActions
			};
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001B8D4 File Offset: 0x00019AD4
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0001B90E File Offset: 0x00019B0E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicEntityRewardComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001B91C File Offset: 0x00019B1C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0001B946 File Offset: 0x00019B46
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001B954 File Offset: 0x00019B54
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0001B9B5 File Offset: 0x00019BB5
		public virtual IDynamicTrafficReward RewardType
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
					this._RewardTypeCache = IDynamicTrafficReward.Create(this.FbInstance.RewardType);
				}
				else
				{
					DynamicEntityRewardComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001B9CA File Offset: 0x00019BCA
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0001B9F1 File Offset: 0x00019BF1
		[Nullable(2)]
		public virtual List<EClaimDynamicEntityRewardType> ClaimTypes
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClaimTypes;
				}
				DynamicEntityRewardComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ClaimTypes;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ClaimTypes = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001BA00 File Offset: 0x00019C00
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0001BA93 File Offset: 0x00019C93
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RewardActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._RewardActionsInited)
				{
					return this._RewardActionsCache;
				}
				this._RewardActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> rewardActions = this.FbInstance.RewardActions;
					if (rewardActions != null)
					{
						this._RewardActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(rewardActions.Count);
						for (int i = 0; i < rewardActions.Count; i++)
						{
							this._RewardActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(rewardActions[i]));
						}
					}
				}
				else
				{
					DynamicEntityRewardComponent_SetValue pocoInterface = this.PocoInterface;
					this._RewardActionsCache = ((pocoInterface != null) ? pocoInterface.RewardActions : null);
				}
				return this._RewardActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().RewardActions = value;
				this._RewardActionsInited = false;
			}
		}

		// Token: 0x040001F1 RID: 497
		[Nullable(2)]
		protected new DynamicEntityRewardComponent FbInstance;

		// Token: 0x040001F2 RID: 498
		[Nullable(2)]
		protected new DynamicEntityRewardComponent_SetValue PocoInterface;

		// Token: 0x040001F3 RID: 499
		private IDynamicTrafficReward _RewardTypeCache;

		// Token: 0x040001F4 RID: 500
		private bool _RewardTypeInited;

		// Token: 0x040001F5 RID: 501
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RewardActionsCache;

		// Token: 0x040001F6 RID: 502
		private bool _RewardActionsInited;
	}
}
