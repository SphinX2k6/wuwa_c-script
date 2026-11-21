using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E4B RID: 15947
	public class IBvbNpcCurEnergyT
	{
		// Token: 0x17006BB3 RID: 27571
		// (get) Token: 0x0601579F RID: 87967 RVA: 0x003195BA File Offset: 0x003177BA
		// (set) Token: 0x060157A0 RID: 87968 RVA: 0x003195C2 File Offset: 0x003177C2
		public ESystemVarName Type { get; set; }

		// Token: 0x060157A1 RID: 87969 RVA: 0x003195CB File Offset: 0x003177CB
		public IBvbNpcCurEnergyT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
