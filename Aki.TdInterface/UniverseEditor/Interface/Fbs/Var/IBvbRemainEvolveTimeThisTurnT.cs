using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E60 RID: 15968
	public class IBvbRemainEvolveTimeThisTurnT
	{
		// Token: 0x17006BC8 RID: 27592
		// (get) Token: 0x0601581D RID: 88093 RVA: 0x0031A002 File Offset: 0x00318202
		// (set) Token: 0x0601581E RID: 88094 RVA: 0x0031A00A File Offset: 0x0031820A
		public ESystemVarName Type { get; set; }

		// Token: 0x0601581F RID: 88095 RVA: 0x0031A013 File Offset: 0x00318213
		public IBvbRemainEvolveTimeThisTurnT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
