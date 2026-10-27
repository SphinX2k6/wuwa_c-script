using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A52 RID: 19026
	public class TrapDefenseDevelopBranchSelectInfo : ITrapDefenseDevelopBranchSelectInfo
	{
		// Token: 0x17007A67 RID: 31335
		// (get) Token: 0x060315C9 RID: 202185 RVA: 0x00B7241D File Offset: 0x00B7061D
		// (set) Token: 0x060315CA RID: 202186 RVA: 0x00B72425 File Offset: 0x00B70625
		public int Id { get; set; }

		// Token: 0x17007A68 RID: 31336
		// (get) Token: 0x060315CB RID: 202187 RVA: 0x00B7242E File Offset: 0x00B7062E
		// (set) Token: 0x060315CC RID: 202188 RVA: 0x00B72436 File Offset: 0x00B70636
		public bool IsCurLevel { get; set; }

		// Token: 0x17007A69 RID: 31337
		// (get) Token: 0x060315CD RID: 202189 RVA: 0x00B7243F File Offset: 0x00B7063F
		// (set) Token: 0x060315CE RID: 202190 RVA: 0x00B72447 File Offset: 0x00B70647
		public bool IsSelected { get; set; }
	}
}
