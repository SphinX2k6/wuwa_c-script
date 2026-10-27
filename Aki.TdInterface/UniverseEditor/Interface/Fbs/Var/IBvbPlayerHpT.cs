using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7C RID: 14972
	public class IBvbPlayerHpT
	{
		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x060144CB RID: 83147 RVA: 0x002F69AE File Offset: 0x002F4BAE
		// (set) Token: 0x060144CC RID: 83148 RVA: 0x002F69B6 File Offset: 0x002F4BB6
		public ESystemVarName Type { get; set; }

		// Token: 0x060144CD RID: 83149 RVA: 0x002F69BF File Offset: 0x002F4BBF
		public IBvbPlayerHpT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
