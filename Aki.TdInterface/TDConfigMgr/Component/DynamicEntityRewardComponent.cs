using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005C RID: 92
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicEntityRewardComponent : IComponentBase
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0001AEB0 File Offset: 0x000190B0
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

		// Token: 0x06000307 RID: 775 RVA: 0x0001AEE8 File Offset: 0x000190E8
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

		// Token: 0x06000308 RID: 776 RVA: 0x0001AEFB File Offset: 0x000190FB
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

		// Token: 0x06000309 RID: 777 RVA: 0x0001AF10 File Offset: 0x00019110
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001AF60 File Offset: 0x00019160
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0001AF9A File Offset: 0x0001919A
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001AFA8 File Offset: 0x000191A8
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0001AFD2 File Offset: 0x000191D2
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001AFE0 File Offset: 0x000191E0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0001B041 File Offset: 0x00019241
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001B056 File Offset: 0x00019256
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0001B07D File Offset: 0x0001927D
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001B08C File Offset: 0x0001928C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0001B11F File Offset: 0x0001931F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RewardActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().RewardActions = value;
				this._RewardActionsInited = false;
			}
		}

		// Token: 0x040001EC RID: 492
		[Nullable(2)]
		protected new DynamicEntityRewardComponent FbInstance;

		// Token: 0x040001ED RID: 493
		[Nullable(2)]
		protected new DynamicEntityRewardComponent_SetValue PocoInterface;

		// Token: 0x040001EE RID: 494
		private IDynamicTrafficReward _RewardTypeCache;

		// Token: 0x040001EF RID: 495
		private bool _RewardTypeInited;

		// Token: 0x040001F0 RID: 496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RewardActionsCache;

		// Token: 0x040001F1 RID: 497
		private bool _RewardActionsInited;
	}
}
