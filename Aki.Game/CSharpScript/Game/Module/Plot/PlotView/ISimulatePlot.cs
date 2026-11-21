using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200401F RID: 16415
	[NullableContext(2)]
	public interface ISimulatePlot
	{
		// Token: 0x060298BB RID: 170171
		void SimulateClickSubtitle();

		// Token: 0x060298BC RID: 170172
		void SimulateClickOption();

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x060298BD RID: 170173
		ITalkItem CurrentSubtitle { get; }
	}
}
