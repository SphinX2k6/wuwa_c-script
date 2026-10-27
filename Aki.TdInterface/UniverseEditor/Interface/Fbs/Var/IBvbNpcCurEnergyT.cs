using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A70 RID: 14960
	public class IBvbNpcCurEnergyT
	{
		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x06014483 RID: 83075 RVA: 0x002F63CE File Offset: 0x002F45CE
		// (set) Token: 0x06014484 RID: 83076 RVA: 0x002F63D6 File Offset: 0x002F45D6
		public ESystemVarName Type { get; set; }

		// Token: 0x06014485 RID: 83077 RVA: 0x002F63DF File Offset: 0x002F45DF
		public IBvbNpcCurEnergyT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
