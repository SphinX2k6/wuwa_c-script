using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287A RID: 10362
	public class IPlotModeUiStyleBase
	{
		// Token: 0x0600E6FA RID: 59130 RVA: 0x00222D8F File Offset: 0x00220F8F
		public static IPlotModeUiStyleBase Create(IPlotModeUiStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotModeUiStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x00222DAE File Offset: 0x00220FAE
		public virtual EPlotModeUiStyleType Type
		{
			get
			{
				return (EPlotModeUiStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04007F2E RID: 32558
		private IPlotModeUiStyleBase Instance;
	}
}
