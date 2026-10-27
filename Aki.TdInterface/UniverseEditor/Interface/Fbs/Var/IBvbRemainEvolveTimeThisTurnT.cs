using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A85 RID: 14981
	public class IBvbRemainEvolveTimeThisTurnT
	{
		// Token: 0x17006698 RID: 26264
		// (get) Token: 0x06014501 RID: 83201 RVA: 0x002F6E16 File Offset: 0x002F5016
		// (set) Token: 0x06014502 RID: 83202 RVA: 0x002F6E1E File Offset: 0x002F501E
		public ESystemVarName Type { get; set; }

		// Token: 0x06014503 RID: 83203 RVA: 0x002F6E27 File Offset: 0x002F5027
		public IBvbRemainEvolveTimeThisTurnT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
