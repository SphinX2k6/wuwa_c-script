using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006757 RID: 26455
	public class IFaceExpressionTextureMultiSlotConfigT
	{
		// Token: 0x1700C466 RID: 50278
		// (get) Token: 0x0602E059 RID: 188505 RVA: 0x0064A09E File Offset: 0x0064829E
		// (set) Token: 0x0602E05A RID: 188506 RVA: 0x0064A0A6 File Offset: 0x006482A6
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700C467 RID: 50279
		// (get) Token: 0x0602E05B RID: 188507 RVA: 0x0064A0AF File Offset: 0x006482AF
		// (set) Token: 0x0602E05C RID: 188508 RVA: 0x0064A0B7 File Offset: 0x006482B7
		public int SlotIndex { get; set; }

		// Token: 0x1700C468 RID: 50280
		// (get) Token: 0x0602E05D RID: 188509 RVA: 0x0064A0C0 File Offset: 0x006482C0
		// (set) Token: 0x0602E05E RID: 188510 RVA: 0x0064A0C8 File Offset: 0x006482C8
		public int FaceIndex { get; set; }

		// Token: 0x0602E05F RID: 188511 RVA: 0x0064A0D1 File Offset: 0x006482D1
		public IFaceExpressionTextureMultiSlotConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.SlotIndex = 0;
			this.FaceIndex = 0;
		}
	}
}
