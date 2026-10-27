using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DE RID: 30174
	public class IVisualNovelRoleIntroductionSolarSchoolT
	{
		// Token: 0x1700E53D RID: 58685
		// (get) Token: 0x06036F74 RID: 225140 RVA: 0x00775958 File Offset: 0x00773B58
		// (set) Token: 0x06036F75 RID: 225141 RVA: 0x00775960 File Offset: 0x00773B60
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700E53E RID: 58686
		// (get) Token: 0x06036F76 RID: 225142 RVA: 0x00775969 File Offset: 0x00773B69
		// (set) Token: 0x06036F77 RID: 225143 RVA: 0x00775971 File Offset: 0x00773B71
		public int IntroductionId { get; set; }

		// Token: 0x1700E53F RID: 58687
		// (get) Token: 0x06036F78 RID: 225144 RVA: 0x0077597A File Offset: 0x00773B7A
		// (set) Token: 0x06036F79 RID: 225145 RVA: 0x00775982 File Offset: 0x00773B82
		public float Duration { get; set; }

		// Token: 0x1700E540 RID: 58688
		// (get) Token: 0x06036F7A RID: 225146 RVA: 0x0077598B File Offset: 0x00773B8B
		// (set) Token: 0x06036F7B RID: 225147 RVA: 0x00775993 File Offset: 0x00773B93
		public byte NullMask { get; set; }

		// Token: 0x06036F7C RID: 225148 RVA: 0x0077599C File Offset: 0x00773B9C
		public IVisualNovelRoleIntroductionSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.IntroductionId = 0;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
