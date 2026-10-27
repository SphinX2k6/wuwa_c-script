using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002862 RID: 10338
	public class ILifePointMaxStepRewardRuleItem
	{
		// Token: 0x0600E51E RID: 58654 RVA: 0x0021B41D File Offset: 0x0021961D
		[NullableContext(1)]
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

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x0600E51F RID: 58655 RVA: 0x0021B43C File Offset: 0x0021963C
		public virtual int PaintCount
		{
			get
			{
				return this.Instance.PaintCount;
			}
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x0600E520 RID: 58656 RVA: 0x0021B449 File Offset: 0x00219649
		public virtual int AddStep
		{
			get
			{
				return this.Instance.AddStep;
			}
		}

		// Token: 0x04007EC0 RID: 32448
		private ILifePointMaxStepRewardRuleItem Instance;
	}
}
