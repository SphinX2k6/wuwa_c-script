using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A79 RID: 14969
	public class IBvbNpcScoreT
	{
		// Token: 0x1700668C RID: 26252
		// (get) Token: 0x060144B9 RID: 83129 RVA: 0x002F6836 File Offset: 0x002F4A36
		// (set) Token: 0x060144BA RID: 83130 RVA: 0x002F683E File Offset: 0x002F4A3E
		public ESystemVarName Type { get; set; }

		// Token: 0x060144BB RID: 83131 RVA: 0x002F6847 File Offset: 0x002F4A47
		public IBvbNpcScoreT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
