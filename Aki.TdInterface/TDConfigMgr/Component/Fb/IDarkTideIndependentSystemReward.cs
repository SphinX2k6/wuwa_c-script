using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB2 RID: 2738
	[NullableContext(2)]
	[Nullable(0)]
	public class IDarkTideIndependentSystemReward : IIndependentSystemRewardType
	{
		// Token: 0x06003F20 RID: 16160 RVA: 0x000A1722 File Offset: 0x0009F922
		[NullableContext(1)]
		public static IDarkTideIndependentSystemReward Create(IDarkTideIndependentSystemReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideIndependentSystemReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x000A1741 File Offset: 0x0009F941
		public override EIndependentSystemRewardType Type
		{
			get
			{
				return (EIndependentSystemRewardType)this.Instance.Type;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x000A174E File Offset: 0x0009F94E
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x000A175C File Offset: 0x0009F95C
		public virtual List<int> RewardIdList
		{
			get
			{
				if (this._RewardIdListInited)
				{
					return this._RewardIdListCache;
				}
				this._RewardIdListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
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

		// Token: 0x04002311 RID: 8977
		private IDarkTideIndependentSystemReward Instance;

		// Token: 0x04002312 RID: 8978
		private List<int> _RewardIdListCache;

		// Token: 0x04002313 RID: 8979
		private bool _RewardIdListInited;
	}
}
