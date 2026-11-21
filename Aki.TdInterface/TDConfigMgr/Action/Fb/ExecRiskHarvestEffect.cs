using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9B RID: 11419
	public class ExecRiskHarvestEffect : ActionParams
	{
		// Token: 0x0600FAA8 RID: 64168 RVA: 0x002457B8 File Offset: 0x002439B8
		public static ExecRiskHarvestEffect Create(IExecRiskHarvestEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecRiskHarvestEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x0600FAA9 RID: 64169 RVA: 0x002457D7 File Offset: 0x002439D7
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040088F1 RID: 35057
		private IExecRiskHarvestEffect Instance;
	}
}
