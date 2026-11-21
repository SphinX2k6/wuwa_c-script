using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7D RID: 2941
	public class IndependentSystemRewardComponent : IComponentBase
	{
		// Token: 0x0600434F RID: 17231 RVA: 0x000AADCD File Offset: 0x000A8FCD
		public static IndependentSystemRewardComponent Create(IIndependentSystemRewardComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IndependentSystemRewardComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x000AADEC File Offset: 0x000A8FEC
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

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x000AAE24 File Offset: 0x000A9024
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x000AAE3A File Offset: 0x000A903A
		public virtual IDarkTideIndependentSystemReward RewardType
		{
			get
			{
				if (this._RewardTypeInited)
				{
					return this._RewardTypeCache;
				}
				this._RewardTypeInited = true;
				this._RewardTypeCache = IDarkTideIndependentSystemReward.Create(this.Instance.RewardType);
				return this._RewardTypeCache;
			}
		}

		// Token: 0x04002530 RID: 9520
		private IIndependentSystemRewardComponent Instance;

		// Token: 0x04002531 RID: 9521
		[Nullable(2)]
		private IDarkTideIndependentSystemReward _RewardTypeCache;

		// Token: 0x04002532 RID: 9522
		private bool _RewardTypeInited;
	}
}
