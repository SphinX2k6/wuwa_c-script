using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007353 RID: 29523
	public class ITalkOptionSystemConditionT
	{
		// Token: 0x1700E02E RID: 57390
		// (get) Token: 0x06035940 RID: 219456 RVA: 0x0074BEEF File Offset: 0x0074A0EF
		// (set) Token: 0x06035941 RID: 219457 RVA: 0x0074BEF7 File Offset: 0x0074A0F7
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700E02F RID: 57391
		// (get) Token: 0x06035942 RID: 219458 RVA: 0x0074BF00 File Offset: 0x0074A100
		// (set) Token: 0x06035943 RID: 219459 RVA: 0x0074BF08 File Offset: 0x0074A108
		public ITalkOptionConditionSolarSchoolT System { get; set; }

		// Token: 0x1700E030 RID: 57392
		// (get) Token: 0x06035944 RID: 219460 RVA: 0x0074BF11 File Offset: 0x0074A111
		// (set) Token: 0x06035945 RID: 219461 RVA: 0x0074BF19 File Offset: 0x0074A119
		public bool HideWhenUnmet { get; set; }

		// Token: 0x1700E031 RID: 57393
		// (get) Token: 0x06035946 RID: 219462 RVA: 0x0074BF22 File Offset: 0x0074A122
		// (set) Token: 0x06035947 RID: 219463 RVA: 0x0074BF2A File Offset: 0x0074A12A
		public bool HideConditionTextWhenUnmet { get; set; }

		// Token: 0x1700E032 RID: 57394
		// (get) Token: 0x06035948 RID: 219464 RVA: 0x0074BF33 File Offset: 0x0074A133
		// (set) Token: 0x06035949 RID: 219465 RVA: 0x0074BF3B File Offset: 0x0074A13B
		public string TidReplaceTextWhenUnmet { get; set; }

		// Token: 0x1700E033 RID: 57395
		// (get) Token: 0x0603594A RID: 219466 RVA: 0x0074BF44 File Offset: 0x0074A144
		// (set) Token: 0x0603594B RID: 219467 RVA: 0x0074BF4C File Offset: 0x0074A14C
		public byte NullMask { get; set; }

		// Token: 0x0603594C RID: 219468 RVA: 0x0074BF55 File Offset: 0x0074A155
		public ITalkOptionSystemConditionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.System = null;
			this.HideWhenUnmet = false;
			this.HideConditionTextWhenUnmet = false;
			this.TidReplaceTextWhenUnmet = null;
			this.NullMask = 0;
		}
	}
}
