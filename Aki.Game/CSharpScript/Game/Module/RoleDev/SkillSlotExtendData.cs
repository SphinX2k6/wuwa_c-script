using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CCD RID: 19661
	public class SkillSlotExtendData : ISkillSlotExtendData
	{
		// Token: 0x17007D6B RID: 32107
		// (get) Token: 0x06032C20 RID: 207904 RVA: 0x00BD537C File Offset: 0x00BD357C
		// (set) Token: 0x06032C21 RID: 207905 RVA: 0x00BD5384 File Offset: 0x00BD3584
		public int RoleId { get; set; }

		// Token: 0x17007D6C RID: 32108
		// (get) Token: 0x06032C22 RID: 207906 RVA: 0x00BD538D File Offset: 0x00BD358D
		// (set) Token: 0x06032C23 RID: 207907 RVA: 0x00BD5395 File Offset: 0x00BD3595
		public int SkillNodeId { get; set; }

		// Token: 0x17007D6D RID: 32109
		// (get) Token: 0x06032C24 RID: 207908 RVA: 0x00BD539E File Offset: 0x00BD359E
		// (set) Token: 0x06032C25 RID: 207909 RVA: 0x00BD53A6 File Offset: 0x00BD35A6
		public int IconId { get; set; }

		// Token: 0x17007D6E RID: 32110
		// (get) Token: 0x06032C26 RID: 207910 RVA: 0x00BD53AF File Offset: 0x00BD35AF
		// (set) Token: 0x06032C27 RID: 207911 RVA: 0x00BD53B7 File Offset: 0x00BD35B7
		public int CurrentLevel { get; set; }

		// Token: 0x17007D6F RID: 32111
		// (get) Token: 0x06032C28 RID: 207912 RVA: 0x00BD53C0 File Offset: 0x00BD35C0
		// (set) Token: 0x06032C29 RID: 207913 RVA: 0x00BD53C8 File Offset: 0x00BD35C8
		public int NormalTargetLevel { get; set; }

		// Token: 0x17007D70 RID: 32112
		// (get) Token: 0x06032C2A RID: 207914 RVA: 0x00BD53D1 File Offset: 0x00BD35D1
		// (set) Token: 0x06032C2B RID: 207915 RVA: 0x00BD53D9 File Offset: 0x00BD35D9
		public int PerfectTargetLevel { get; set; }

		// Token: 0x17007D71 RID: 32113
		// (get) Token: 0x06032C2C RID: 207916 RVA: 0x00BD53E2 File Offset: 0x00BD35E2
		// (set) Token: 0x06032C2D RID: 207917 RVA: 0x00BD53EA File Offset: 0x00BD35EA
		public ESkillType SkillType { get; set; }

		// Token: 0x17007D72 RID: 32114
		// (get) Token: 0x06032C2E RID: 207918 RVA: 0x00BD53F3 File Offset: 0x00BD35F3
		// (set) Token: 0x06032C2F RID: 207919 RVA: 0x00BD53FB File Offset: 0x00BD35FB
		public int NodeIndex { get; set; }
	}
}
