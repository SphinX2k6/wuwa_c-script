using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD7 RID: 28119
	public class IFaceExpressionTextureMultiSlotConfigT
	{
		// Token: 0x1700CE1C RID: 52764
		// (get) Token: 0x0603089F RID: 198815 RVA: 0x006977E2 File Offset: 0x006959E2
		// (set) Token: 0x060308A0 RID: 198816 RVA: 0x006977EA File Offset: 0x006959EA
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700CE1D RID: 52765
		// (get) Token: 0x060308A1 RID: 198817 RVA: 0x006977F3 File Offset: 0x006959F3
		// (set) Token: 0x060308A2 RID: 198818 RVA: 0x006977FB File Offset: 0x006959FB
		public int SlotIndex { get; set; }

		// Token: 0x1700CE1E RID: 52766
		// (get) Token: 0x060308A3 RID: 198819 RVA: 0x00697804 File Offset: 0x00695A04
		// (set) Token: 0x060308A4 RID: 198820 RVA: 0x0069780C File Offset: 0x00695A0C
		public int FaceIndex { get; set; }

		// Token: 0x060308A5 RID: 198821 RVA: 0x00697815 File Offset: 0x00695A15
		public IFaceExpressionTextureMultiSlotConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.SlotIndex = 0;
			this.FaceIndex = 0;
		}
	}
}
