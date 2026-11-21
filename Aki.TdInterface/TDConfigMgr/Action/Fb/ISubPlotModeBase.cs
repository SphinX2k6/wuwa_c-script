using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002892 RID: 10386
	public class ISubPlotModeBase
	{
		// Token: 0x0600E77A RID: 59258 RVA: 0x00223DCE File Offset: 0x00221FCE
		public static ISubPlotModeBase Create(ISubPlotModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubPlotModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x0600E77B RID: 59259 RVA: 0x00223DED File Offset: 0x00221FED
		public virtual ESubPlotModeType Type
		{
			get
			{
				return (ESubPlotModeType)this.Instance.Type;
			}
		}

		// Token: 0x04007F7E RID: 32638
		private ISubPlotModeBase Instance;
	}
}
