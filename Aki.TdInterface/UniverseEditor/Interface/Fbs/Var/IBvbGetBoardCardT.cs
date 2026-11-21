using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E33 RID: 15923
	public class IBvbGetBoardCardT
	{
		// Token: 0x17006B94 RID: 27540
		// (get) Token: 0x060156EC RID: 87788 RVA: 0x00318077 File Offset: 0x00316277
		// (set) Token: 0x060156ED RID: 87789 RVA: 0x0031807F File Offset: 0x0031627F
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B95 RID: 27541
		// (get) Token: 0x060156EE RID: 87790 RVA: 0x00318088 File Offset: 0x00316288
		// (set) Token: 0x060156EF RID: 87791 RVA: 0x00318090 File Offset: 0x00316290
		public IBvbCardFilterGroupT Condition { get; set; }

		// Token: 0x060156F0 RID: 87792 RVA: 0x00318099 File Offset: 0x00316299
		public IBvbGetBoardCardT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Condition = null;
		}
	}
}
