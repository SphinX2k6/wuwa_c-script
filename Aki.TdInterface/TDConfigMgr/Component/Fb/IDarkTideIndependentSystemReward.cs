using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7C RID: 2940
	[NullableContext(2)]
	[Nullable(0)]
	public class IDarkTideIndependentSystemReward : IIndependentSystemRewardType
	{
		// Token: 0x0600434A RID: 17226 RVA: 0x000AAD16 File Offset: 0x000A8F16
		[NullableContext(0)]
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

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x000AAD35 File Offset: 0x000A8F35
		public override EIndependentSystemRewardType Type
		{
			get
			{
				return (EIndependentSystemRewardType)this.Instance.Type;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000AAD42 File Offset: 0x000A8F42
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x000AAD50 File Offset: 0x000A8F50
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

		// Token: 0x0400252D RID: 9517
		private IDarkTideIndependentSystemReward Instance;

		// Token: 0x0400252E RID: 9518
		private List<int> _RewardIdListCache;

		// Token: 0x0400252F RID: 9519
		private bool _RewardIdListInited;
	}
}
