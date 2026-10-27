using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D2 RID: 30162
	public class IVisualNovelPortraitTransformT
	{
		// Token: 0x1700E524 RID: 58660
		// (get) Token: 0x06036F16 RID: 225046 RVA: 0x00775010 File Offset: 0x00773210
		// (set) Token: 0x06036F17 RID: 225047 RVA: 0x00775018 File Offset: 0x00773218
		public int PosX { get; set; }

		// Token: 0x1700E525 RID: 58661
		// (get) Token: 0x06036F18 RID: 225048 RVA: 0x00775021 File Offset: 0x00773221
		// (set) Token: 0x06036F19 RID: 225049 RVA: 0x00775029 File Offset: 0x00773229
		public int PosY { get; set; }

		// Token: 0x1700E526 RID: 58662
		// (get) Token: 0x06036F1A RID: 225050 RVA: 0x00775032 File Offset: 0x00773232
		// (set) Token: 0x06036F1B RID: 225051 RVA: 0x0077503A File Offset: 0x0077323A
		public float Scale { get; set; }

		// Token: 0x1700E527 RID: 58663
		// (get) Token: 0x06036F1C RID: 225052 RVA: 0x00775043 File Offset: 0x00773243
		// (set) Token: 0x06036F1D RID: 225053 RVA: 0x0077504B File Offset: 0x0077324B
		public byte NullMask { get; set; }

		// Token: 0x06036F1E RID: 225054 RVA: 0x00775054 File Offset: 0x00773254
		public IVisualNovelPortraitTransformT()
		{
			this.PosX = 0;
			this.PosY = 0;
			this.Scale = 0f;
			this.NullMask = 0;
		}
	}
}
