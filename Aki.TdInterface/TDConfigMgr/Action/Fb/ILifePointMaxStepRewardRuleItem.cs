using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B35 RID: 11061
	public class ILifePointMaxStepRewardRuleItem
	{
		// Token: 0x0600F343 RID: 62275 RVA: 0x00238281 File Offset: 0x00236481
		public static ILifePointMaxStepRewardRuleItem Create(ILifePointMaxStepRewardRuleItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePointMaxStepRewardRuleItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x0600F344 RID: 62276 RVA: 0x002382A0 File Offset: 0x002364A0
		public virtual int PaintCount
		{
			get
			{
				return this.Instance.PaintCount;
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x0600F345 RID: 62277 RVA: 0x002382AD File Offset: 0x002364AD
		public virtual int AddStep
		{
			get
			{
				return this.Instance.AddStep;
			}
		}

		// Token: 0x0400857D RID: 34173
		private ILifePointMaxStepRewardRuleItem Instance;
	}
}
