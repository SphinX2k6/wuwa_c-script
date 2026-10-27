using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025CB RID: 9675
	public class IPlotModeUiStyleBase
	{
		// Token: 0x0600D97E RID: 55678 RVA: 0x00206FDF File Offset: 0x002051DF
		[NullableContext(1)]
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

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x0600D97F RID: 55679 RVA: 0x00206FFE File Offset: 0x002051FE
		public virtual EPlotModeUiStyleType Type
		{
			get
			{
				return (EPlotModeUiStyleType)this.Instance.Type;
			}
		}

		// Token: 0x040078C5 RID: 30917
		private IPlotModeUiStyleBase Instance;
	}
}
