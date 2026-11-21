using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B77 RID: 2935
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent : IComponentBase
	{
		// Token: 0x06004330 RID: 17200 RVA: 0x000AA95A File Offset: 0x000A8B5A
		[NullableContext(0)]
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

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x000AA97C File Offset: 0x000A8B7C
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

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x000AA9CA File Offset: 0x000A8BCA
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x000AA9D7 File Offset: 0x000A8BD7
		public virtual ERewardType RewardType
		{
			get
			{
				return (ERewardType)this.Instance.RewardType;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x000AA9E4 File Offset: 0x000A8BE4
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

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x000AAA1A File Offset: 0x000A8C1A
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

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x000AAA50 File Offset: 0x000A8C50
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

		// Token: 0x0400251E RID: 9502
		private IRewardComponent Instance;

		// Token: 0x0400251F RID: 9503
		private IRewardRefreshConfig _RefreshConfigCache;

		// Token: 0x04002520 RID: 9504
		private bool _RefreshConfigInited;

		// Token: 0x04002521 RID: 9505
		private List<int> _RewardIdListCache;

		// Token: 0x04002522 RID: 9506
		private bool _RewardIdListInited;
	}
}
