using System;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006198 RID: 24984
	public class TouchUiEditDataImpl : ITouchUiEditData
	{
		// Token: 0x170070ED RID: 28909
		// (get) Token: 0x0603BF17 RID: 245527 RVA: 0x011081F9 File Offset: 0x011063F9
		// (set) Token: 0x0603BF18 RID: 245528 RVA: 0x01108201 File Offset: 0x01106401
		public int StorageId { get; set; }

		// Token: 0x170070EE RID: 28910
		// (get) Token: 0x0603BF19 RID: 245529 RVA: 0x0110820A File Offset: 0x0110640A
		// (set) Token: 0x0603BF1A RID: 245530 RVA: 0x01108212 File Offset: 0x01106412
		public float OffsetX { get; set; }

		// Token: 0x170070EF RID: 28911
		// (get) Token: 0x0603BF1B RID: 245531 RVA: 0x0110821B File Offset: 0x0110641B
		// (set) Token: 0x0603BF1C RID: 245532 RVA: 0x01108223 File Offset: 0x01106423
		public float OffsetY { get; set; }

		// Token: 0x170070F0 RID: 28912
		// (get) Token: 0x0603BF1D RID: 245533 RVA: 0x0110822C File Offset: 0x0110642C
		// (set) Token: 0x0603BF1E RID: 245534 RVA: 0x01108234 File Offset: 0x01106434
		public float Scale { get; set; }

		// Token: 0x170070F1 RID: 28913
		// (get) Token: 0x0603BF1F RID: 245535 RVA: 0x0110823D File Offset: 0x0110643D
		// (set) Token: 0x0603BF20 RID: 245536 RVA: 0x01108245 File Offset: 0x01106445
		public float Alpha { get; set; }

		// Token: 0x170070F2 RID: 28914
		// (get) Token: 0x0603BF21 RID: 245537 RVA: 0x0110824E File Offset: 0x0110644E
		// (set) Token: 0x0603BF22 RID: 245538 RVA: 0x01108256 File Offset: 0x01106456
		public int HierarchyIndex { get; set; }

		// Token: 0x170070F3 RID: 28915
		// (get) Token: 0x0603BF23 RID: 245539 RVA: 0x0110825F File Offset: 0x0110645F
		// (set) Token: 0x0603BF24 RID: 245540 RVA: 0x01108267 File Offset: 0x01106467
		public bool Editable { get; set; }

		// Token: 0x170070F4 RID: 28916
		// (get) Token: 0x0603BF25 RID: 245541 RVA: 0x01108270 File Offset: 0x01106470
		// (set) Token: 0x0603BF26 RID: 245542 RVA: 0x01108278 File Offset: 0x01106478
		public bool DefaultSelect { get; set; }

		// Token: 0x170070F5 RID: 28917
		// (get) Token: 0x0603BF27 RID: 245543 RVA: 0x01108281 File Offset: 0x01106481
		// (set) Token: 0x0603BF28 RID: 245544 RVA: 0x01108289 File Offset: 0x01106489
		public bool ShouldCheckOverlap { get; set; }
	}
}
