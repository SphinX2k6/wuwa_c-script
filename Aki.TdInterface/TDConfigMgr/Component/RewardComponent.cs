using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091A RID: 2330
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent : IComponentBase
	{
		// Token: 0x06003359 RID: 13145 RVA: 0x0008334C File Offset: 0x0008154C
		[NullableContext(0)]
		private RewardComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RewardComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RewardComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RewardComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00083384 File Offset: 0x00081584
		[NullableContext(0)]
		public static RewardComponent Create([Nullable(2)] RewardComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RewardComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00083397 File Offset: 0x00081597
		[NullableContext(0)]
		public static RewardComponent CreateFromSetValue([Nullable(2)] RewardComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RewardComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000833AC File Offset: 0x000815AC
		[NullableContext(0)]
		public new RewardComponent_SetValue ToSetValue()
		{
			return new RewardComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RewardId = this.RewardId,
				RewardType = this.RewardType,
				DropOnEvent = this.DropOnEvent,
				RefreshConfig = this.RefreshConfig,
				RewardIdList = this.RewardIdList
			};
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x00083414 File Offset: 0x00081614
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x0008344E File Offset: 0x0008164E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RewardComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x0008345C File Offset: 0x0008165C
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x00083486 File Offset: 0x00081686
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

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x00083494 File Offset: 0x00081694
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x000834BF File Offset: 0x000816BF
		public virtual int RewardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardId;
			}
			set
			{
				this.GetOrCreatePoco().RewardId = value;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x000834CD File Offset: 0x000816CD
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x000834F8 File Offset: 0x000816F8
		public virtual ERewardType RewardType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardType;
				}
				if (this.PocoInterface == null)
				{
					return ERewardType.Nearby;
				}
				return this.PocoInterface.RewardType;
			}
			set
			{
				this.GetOrCreatePoco().RewardType = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x00083508 File Offset: 0x00081708
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x00083542 File Offset: 0x00081742
		public virtual EDropEvent? DropOnEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DropOnEvent;
				}
				RewardComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DropOnEvent;
			}
			set
			{
				this.GetOrCreatePoco().DropOnEvent = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x00083550 File Offset: 0x00081750
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x000835B1 File Offset: 0x000817B1
		public virtual IRewardRefreshConfig RefreshConfig
		{
			get
			{
				if (this._RefreshConfigInited)
				{
					return this._RefreshConfigCache;
				}
				this._RefreshConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RefreshConfigCache = IRewardRefreshConfig.Create(this.FbInstance.RefreshConfig);
				}
				else
				{
					RewardComponent_SetValue pocoInterface = this.PocoInterface;
					this._RefreshConfigCache = ((pocoInterface != null) ? pocoInterface.RefreshConfig : null);
				}
				return this._RefreshConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RefreshConfig = value;
				this._RefreshConfigInited = false;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000835C6 File Offset: 0x000817C6
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x000835ED File Offset: 0x000817ED
		public virtual List<int> RewardIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardIdList;
				}
				RewardComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RewardIdList;
			}
			set
			{
				this.GetOrCreatePoco().RewardIdList = value;
			}
		}

		// Token: 0x040021BD RID: 8637
		protected new RewardComponent FbInstance;

		// Token: 0x040021BE RID: 8638
		protected new RewardComponent_SetValue PocoInterface;

		// Token: 0x040021BF RID: 8639
		[Nullable(0)]
		private IRewardRefreshConfig _RefreshConfigCache;

		// Token: 0x040021C0 RID: 8640
		private bool _RefreshConfigInited;
	}
}
