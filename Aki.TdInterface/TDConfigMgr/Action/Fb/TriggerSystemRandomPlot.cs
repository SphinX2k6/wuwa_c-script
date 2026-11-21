using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB1 RID: 11697
	public class TriggerSystemRandomPlot : ActionParams
	{
		// Token: 0x0600FED7 RID: 65239 RVA: 0x0024BE74 File Offset: 0x0024A074
		public static TriggerSystemRandomPlot Create(ITriggerSystemRandomPlot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerSystemRandomPlot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x0600FED8 RID: 65240 RVA: 0x0024BE93 File Offset: 0x0024A093
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008B1B RID: 35611
		private ITriggerSystemRandomPlot Instance;
	}
}
