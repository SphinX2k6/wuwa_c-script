using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A82 RID: 14978
	public class IBvbPlayerScoreT
	{
		// Token: 0x17006695 RID: 26261
		// (get) Token: 0x060144EF RID: 83183 RVA: 0x002F6C9E File Offset: 0x002F4E9E
		// (set) Token: 0x060144F0 RID: 83184 RVA: 0x002F6CA6 File Offset: 0x002F4EA6
		public ESystemVarName Type { get; set; }

		// Token: 0x060144F1 RID: 83185 RVA: 0x002F6CAF File Offset: 0x002F4EAF
		public IBvbPlayerScoreT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
