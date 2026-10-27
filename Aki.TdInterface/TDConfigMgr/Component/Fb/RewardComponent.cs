using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAD RID: 2733
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent : IComponentBase
	{
		// Token: 0x06003F06 RID: 16134 RVA: 0x000A1366 File Offset: 0x0009F566
		[NullableContext(1)]
		public static RewardComponent Create(IRewardComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RewardComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000A1388 File Offset: 0x0009F588
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x000A13C0 File Offset: 0x0009F5C0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x000A13D6 File Offset: 0x0009F5D6
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x000A13E3 File Offset: 0x0009F5E3
		public virtual ERewardType RewardType
		{
			get
			{
				return (ERewardType)this.Instance.RewardType;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x000A13F0 File Offset: 0x0009F5F0
		public virtual EDropEvent? DropOnEvent
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EDropEvent?((EDropEvent)this.Instance.DropOnEvent);
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x000A1426 File Offset: 0x0009F626
		public virtual IRewardRefreshConfig RefreshConfig
		{
			get
			{
				if (this._RefreshConfigInited)
				{
					return this._RefreshConfigCache;
				}
				this._RefreshConfigInited = true;
				this._RefreshConfigCache = IRewardRefreshConfig.Create(this.Instance.RefreshConfig);
				return this._RefreshConfigCache;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x000A145C File Offset: 0x0009F65C
		public virtual List<int> RewardIdList
		{
			get
			{
				if (this._RewardIdListInited)
				{
					return this._RewardIdListCache;
				}
				this._RewardIdListInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int rewardIdListLength = this.Instance.RewardIdListLength;
				this._RewardIdListCache = new List<int>(rewardIdListLength);
				for (int i = 0; i < rewardIdListLength; i++)
				{
					this._RewardIdListCache.Add(this.Instance.RewardIdList(i));
				}
				return this._RewardIdListCache;
			}
		}

		// Token: 0x04002302 RID: 8962
		private IRewardComponent Instance;

		// Token: 0x04002303 RID: 8963
		private IRewardRefreshConfig _RefreshConfigCache;

		// Token: 0x04002304 RID: 8964
		private bool _RefreshConfigInited;

		// Token: 0x04002305 RID: 8965
		private List<int> _RewardIdListCache;

		// Token: 0x04002306 RID: 8966
		private bool _RewardIdListInited;
	}
}
