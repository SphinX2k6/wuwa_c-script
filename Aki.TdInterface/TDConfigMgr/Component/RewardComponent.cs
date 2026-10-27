using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000877 RID: 2167
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent : IComponentBase
	{
		// Token: 0x0600301D RID: 12317 RVA: 0x0007BE64 File Offset: 0x0007A064
		[NullableContext(1)]
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

		// Token: 0x0600301E RID: 12318 RVA: 0x0007BE9C File Offset: 0x0007A09C
		[NullableContext(1)]
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

		// Token: 0x0600301F RID: 12319 RVA: 0x0007BEAF File Offset: 0x0007A0AF
		[NullableContext(1)]
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

		// Token: 0x06003020 RID: 12320 RVA: 0x0007BEC4 File Offset: 0x0007A0C4
		[NullableContext(1)]
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

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x0007BF2C File Offset: 0x0007A12C
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x0007BF66 File Offset: 0x0007A166
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x0007BF74 File Offset: 0x0007A174
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x0007BF9E File Offset: 0x0007A19E
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x0007BFAC File Offset: 0x0007A1AC
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x0007BFD7 File Offset: 0x0007A1D7
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x0007BFE5 File Offset: 0x0007A1E5
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x0007C010 File Offset: 0x0007A210
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

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x0007C020 File Offset: 0x0007A220
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x0007C05A File Offset: 0x0007A25A
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x0007C068 File Offset: 0x0007A268
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x0007C0C9 File Offset: 0x0007A2C9
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x0007C0DE File Offset: 0x0007A2DE
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x0007C105 File Offset: 0x0007A305
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

		// Token: 0x04001FAB RID: 8107
		protected new RewardComponent FbInstance;

		// Token: 0x04001FAC RID: 8108
		protected new RewardComponent_SetValue PocoInterface;

		// Token: 0x04001FAD RID: 8109
		[Nullable(1)]
		private IRewardRefreshConfig _RefreshConfigCache;

		// Token: 0x04001FAE RID: 8110
		private bool _RefreshConfigInited;
	}
}
