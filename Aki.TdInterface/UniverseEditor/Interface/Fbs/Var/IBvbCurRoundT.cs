using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E24 RID: 15908
	public class IBvbCurRoundT
	{
		// Token: 0x17006B7A RID: 27514
		// (get) Token: 0x06015674 RID: 87668 RVA: 0x0031744E File Offset: 0x0031564E
		// (set) Token: 0x06015675 RID: 87669 RVA: 0x00317456 File Offset: 0x00315656
		public ESystemVarName Type { get; set; }

		// Token: 0x06015676 RID: 87670 RVA: 0x0031745F File Offset: 0x0031565F
		public IBvbCurRoundT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
