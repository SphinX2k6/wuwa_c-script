using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2A RID: 27946
	public class IPlayMontageT
	{
		// Token: 0x1700D027 RID: 53287
		// (get) Token: 0x060314B8 RID: 201912 RVA: 0x006AF870 File Offset: 0x006ADA70
		// (set) Token: 0x060314B9 RID: 201913 RVA: 0x006AF878 File Offset: 0x006ADA78
		public int EntityId { get; set; }

		// Token: 0x1700D028 RID: 53288
		// (get) Token: 0x060314BA RID: 201914 RVA: 0x006AF881 File Offset: 0x006ADA81
		// (set) Token: 0x060314BB RID: 201915 RVA: 0x006AF889 File Offset: 0x006ADA89
		public IActionMontageT ActionMontage { get; set; }

		// Token: 0x1700D029 RID: 53289
		// (get) Token: 0x060314BC RID: 201916 RVA: 0x006AF892 File Offset: 0x006ADA92
		// (set) Token: 0x060314BD RID: 201917 RVA: 0x006AF89A File Offset: 0x006ADA9A
		public string ExpressionMontage { get; set; }

		// Token: 0x1700D02A RID: 53290
		// (get) Token: 0x060314BE RID: 201918 RVA: 0x006AF8A3 File Offset: 0x006ADAA3
		// (set) Token: 0x060314BF RID: 201919 RVA: 0x006AF8AB File Offset: 0x006ADAAB
		public string MouthSequence { get; set; }

		// Token: 0x1700D02B RID: 53291
		// (get) Token: 0x060314C0 RID: 201920 RVA: 0x006AF8B4 File Offset: 0x006ADAB4
		// (set) Token: 0x060314C1 RID: 201921 RVA: 0x006AF8BC File Offset: 0x006ADABC
		public int Duration { get; set; }

		// Token: 0x1700D02C RID: 53292
		// (get) Token: 0x060314C2 RID: 201922 RVA: 0x006AF8C5 File Offset: 0x006ADAC5
		// (set) Token: 0x060314C3 RID: 201923 RVA: 0x006AF8CD File Offset: 0x006ADACD
		public byte NullMask { get; set; }

		// Token: 0x060314C4 RID: 201924 RVA: 0x006AF8D6 File Offset: 0x006ADAD6
		public IPlayMontageT()
		{
			this.EntityId = 0;
			this.ActionMontage = null;
			this.ExpressionMontage = null;
			this.MouthSequence = null;
			this.Duration = 0;
			this.NullMask = 0;
		}
	}
}
