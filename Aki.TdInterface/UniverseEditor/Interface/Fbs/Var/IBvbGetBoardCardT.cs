using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A58 RID: 14936
	public class IBvbGetBoardCardT
	{
		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x060143D0 RID: 82896 RVA: 0x002F4E8B File Offset: 0x002F308B
		// (set) Token: 0x060143D1 RID: 82897 RVA: 0x002F4E93 File Offset: 0x002F3093
		public ESystemVarName Type { get; set; }

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x060143D2 RID: 82898 RVA: 0x002F4E9C File Offset: 0x002F309C
		// (set) Token: 0x060143D3 RID: 82899 RVA: 0x002F4EA4 File Offset: 0x002F30A4
		public IBvbCardFilterGroupT Condition { get; set; }

		// Token: 0x060143D4 RID: 82900 RVA: 0x002F4EAD File Offset: 0x002F30AD
		public IBvbGetBoardCardT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Condition = null;
		}
	}
}
