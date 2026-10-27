using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D1 RID: 29649
	public class ITextStyleT
	{
		// Token: 0x1700E135 RID: 57653
		// (get) Token: 0x06035DB3 RID: 220595 RVA: 0x00754BB5 File Offset: 0x00752DB5
		// (set) Token: 0x06035DB4 RID: 220596 RVA: 0x00754BBD File Offset: 0x00752DBD
		public TCenterTextShowAnimUnion ShowAnim { get; set; }

		// Token: 0x1700E136 RID: 57654
		// (get) Token: 0x06035DB5 RID: 220597 RVA: 0x00754BC6 File Offset: 0x00752DC6
		// (set) Token: 0x06035DB6 RID: 220598 RVA: 0x00754BCE File Offset: 0x00752DCE
		public EFontSize FontSize { get; set; }

		// Token: 0x1700E137 RID: 57655
		// (get) Token: 0x06035DB7 RID: 220599 RVA: 0x00754BD7 File Offset: 0x00752DD7
		// (set) Token: 0x06035DB8 RID: 220600 RVA: 0x00754BDF File Offset: 0x00752DDF
		public ETextAlign TextAlign { get; set; }

		// Token: 0x1700E138 RID: 57656
		// (get) Token: 0x06035DB9 RID: 220601 RVA: 0x00754BE8 File Offset: 0x00752DE8
		// (set) Token: 0x06035DBA RID: 220602 RVA: 0x00754BF0 File Offset: 0x00752DF0
		public ETextHorizontal TextHorizontal { get; set; }

		// Token: 0x1700E139 RID: 57657
		// (get) Token: 0x06035DBB RID: 220603 RVA: 0x00754BF9 File Offset: 0x00752DF9
		// (set) Token: 0x06035DBC RID: 220604 RVA: 0x00754C01 File Offset: 0x00752E01
		public byte NullMask { get; set; }

		// Token: 0x06035DBD RID: 220605 RVA: 0x00754C0A File Offset: 0x00752E0A
		public ITextStyleT()
		{
			this.ShowAnim = null;
			this.FontSize = EFontSize.Small;
			this.TextAlign = ETextAlign.Top;
			this.TextHorizontal = ETextHorizontal.Left;
			this.NullMask = 0;
		}
	}
}
