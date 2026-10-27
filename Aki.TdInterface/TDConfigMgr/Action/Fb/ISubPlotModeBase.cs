using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D3 RID: 9683
	public class ISubPlotModeBase
	{
		// Token: 0x0600D9B2 RID: 55730 RVA: 0x0020771A File Offset: 0x0020591A
		[NullableContext(1)]
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

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0600D9B3 RID: 55731 RVA: 0x00207739 File Offset: 0x00205939
		public virtual ESubPlotModeType Type
		{
			get
			{
				return (ESubPlotModeType)this.Instance.Type;
			}
		}

		// Token: 0x040078E7 RID: 30951
		private ISubPlotModeBase Instance;
	}
}
