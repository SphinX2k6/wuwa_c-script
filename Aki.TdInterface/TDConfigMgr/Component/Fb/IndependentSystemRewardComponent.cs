using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB3 RID: 2739
	[NullableContext(1)]
	[Nullable(0)]
	public class IndependentSystemRewardComponent : IComponentBase
	{
		// Token: 0x06003F25 RID: 16165 RVA: 0x000A17D9 File Offset: 0x0009F9D9
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x000A17F8 File Offset: 0x0009F9F8
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

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x000A1830 File Offset: 0x0009FA30
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x000A1846 File Offset: 0x0009FA46
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

		// Token: 0x04002314 RID: 8980
		private IIndependentSystemRewardComponent Instance;

		// Token: 0x04002315 RID: 8981
		[Nullable(2)]
		private IDarkTideIndependentSystemReward _RewardTypeCache;

		// Token: 0x04002316 RID: 8982
		private bool _RewardTypeInited;
	}
}
