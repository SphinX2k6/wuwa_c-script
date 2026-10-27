using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007593 RID: 30099
	public class IVisualNovelOptionGroupSolarSchoolExamT
	{
		// Token: 0x1700E438 RID: 58424
		// (get) Token: 0x06036C08 RID: 224264 RVA: 0x0076EB18 File Offset: 0x0076CD18
		// (set) Token: 0x06036C09 RID: 224265 RVA: 0x0076EB20 File Offset: 0x0076CD20
		public EVisualNovelOptionGroupType Type { get; set; }

		// Token: 0x1700E439 RID: 58425
		// (get) Token: 0x06036C0A RID: 224266 RVA: 0x0076EB29 File Offset: 0x0076CD29
		// (set) Token: 0x06036C0B RID: 224267 RVA: 0x0076EB31 File Offset: 0x0076CD31
		public int ExamImageId { get; set; }

		// Token: 0x1700E43A RID: 58426
		// (get) Token: 0x06036C0C RID: 224268 RVA: 0x0076EB3A File Offset: 0x0076CD3A
		// (set) Token: 0x06036C0D RID: 224269 RVA: 0x0076EB42 File Offset: 0x0076CD42
		public int TrueAnswerOptionIndex { get; set; }

		// Token: 0x1700E43B RID: 58427
		// (get) Token: 0x06036C0E RID: 224270 RVA: 0x0076EB4B File Offset: 0x0076CD4B
		// (set) Token: 0x06036C0F RID: 224271 RVA: 0x0076EB53 File Offset: 0x0076CD53
		public byte NullMask { get; set; }

		// Token: 0x06036C10 RID: 224272 RVA: 0x0076EB5C File Offset: 0x0076CD5C
		public IVisualNovelOptionGroupSolarSchoolExamT()
		{
			this.Type = EVisualNovelOptionGroupType.SolarSchoolExam;
			this.ExamImageId = 0;
			this.TrueAnswerOptionIndex = 0;
			this.NullMask = 0;
		}
	}
}
