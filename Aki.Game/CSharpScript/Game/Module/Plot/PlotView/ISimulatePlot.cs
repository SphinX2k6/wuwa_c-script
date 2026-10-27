using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005050 RID: 20560
	[NullableContext(2)]
	public interface ISimulatePlot
	{
		// Token: 0x060349D9 RID: 215513
		void SimulateClickSubtitle();

		// Token: 0x060349DA RID: 215514
		void SimulateClickOption();

		// Token: 0x1700802C RID: 32812
		// (get) Token: 0x060349DB RID: 215515
		ITalkItem CurrentSubtitle { get; }
	}
}
