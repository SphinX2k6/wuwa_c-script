using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200154B RID: 5451
	public class IRoleTowerConditionStepSettle : IRoleTowerConditionStepBase
	{
		// Token: 0x06007B08 RID: 31496 RVA: 0x00124EAE File Offset: 0x001230AE
		public static IRoleTowerConditionStepSettle Create(IRoleTowerConditionStepSettle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepSettle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x06007B09 RID: 31497 RVA: 0x00124ECD File Offset: 0x001230CD
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046D9 RID: 18137
		private IRoleTowerConditionStepSettle Instance;
	}
}
