using System;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006197 RID: 24983
	public interface ITouchUiEditData
	{
		// Token: 0x170070E4 RID: 28900
		// (get) Token: 0x0603BF05 RID: 245509
		// (set) Token: 0x0603BF06 RID: 245510
		int StorageId { get; set; }

		// Token: 0x170070E5 RID: 28901
		// (get) Token: 0x0603BF07 RID: 245511
		// (set) Token: 0x0603BF08 RID: 245512
		float OffsetX { get; set; }

		// Token: 0x170070E6 RID: 28902
		// (get) Token: 0x0603BF09 RID: 245513
		// (set) Token: 0x0603BF0A RID: 245514
		float OffsetY { get; set; }

		// Token: 0x170070E7 RID: 28903
		// (get) Token: 0x0603BF0B RID: 245515
		// (set) Token: 0x0603BF0C RID: 245516
		float Scale { get; set; }

		// Token: 0x170070E8 RID: 28904
		// (get) Token: 0x0603BF0D RID: 245517
		// (set) Token: 0x0603BF0E RID: 245518
		float Alpha { get; set; }

		// Token: 0x170070E9 RID: 28905
		// (get) Token: 0x0603BF0F RID: 245519
		// (set) Token: 0x0603BF10 RID: 245520
		int HierarchyIndex { get; set; }

		// Token: 0x170070EA RID: 28906
		// (get) Token: 0x0603BF11 RID: 245521
		// (set) Token: 0x0603BF12 RID: 245522
		bool Editable { get; set; }

		// Token: 0x170070EB RID: 28907
		// (get) Token: 0x0603BF13 RID: 245523
		// (set) Token: 0x0603BF14 RID: 245524
		bool DefaultSelect { get; set; }

		// Token: 0x170070EC RID: 28908
		// (get) Token: 0x0603BF15 RID: 245525
		// (set) Token: 0x0603BF16 RID: 245526
		bool ShouldCheckOverlap { get; set; }
	}
}
