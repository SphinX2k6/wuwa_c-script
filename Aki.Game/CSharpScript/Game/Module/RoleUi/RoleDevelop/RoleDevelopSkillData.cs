using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D25 RID: 19749
	public class RoleDevelopSkillData : IRoleDevelopSkillData
	{
		// Token: 0x17007E3A RID: 32314
		// (get) Token: 0x0603307E RID: 209022 RVA: 0x00BE1D9E File Offset: 0x00BDFF9E
		// (set) Token: 0x0603307F RID: 209023 RVA: 0x00BE1DA6 File Offset: 0x00BDFFA6
		public int RoleId { get; set; }

		// Token: 0x17007E3B RID: 32315
		// (get) Token: 0x06033080 RID: 209024 RVA: 0x00BE1DAF File Offset: 0x00BDFFAF
		// (set) Token: 0x06033081 RID: 209025 RVA: 0x00BE1DB7 File Offset: 0x00BDFFB7
		public int SkillNodeId { get; set; }

		// Token: 0x17007E3C RID: 32316
		// (get) Token: 0x06033082 RID: 209026 RVA: 0x00BE1DC0 File Offset: 0x00BDFFC0
		// (set) Token: 0x06033083 RID: 209027 RVA: 0x00BE1DC8 File Offset: 0x00BDFFC8
		public int CurrentLevel { get; set; }

		// Token: 0x17007E3D RID: 32317
		// (get) Token: 0x06033084 RID: 209028 RVA: 0x00BE1DD1 File Offset: 0x00BDFFD1
		// (set) Token: 0x06033085 RID: 209029 RVA: 0x00BE1DD9 File Offset: 0x00BDFFD9
		public int TargetLevel { get; set; }

		// Token: 0x17007E3E RID: 32318
		// (get) Token: 0x06033086 RID: 209030 RVA: 0x00BE1DE2 File Offset: 0x00BDFFE2
		// (set) Token: 0x06033087 RID: 209031 RVA: 0x00BE1DEA File Offset: 0x00BDFFEA
		public int Index { get; set; }
	}
}
