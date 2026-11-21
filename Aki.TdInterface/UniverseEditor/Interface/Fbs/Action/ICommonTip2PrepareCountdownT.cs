using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEF RID: 27375
	public class ICommonTip2PrepareCountdownT
	{
		// Token: 0x1700C90F RID: 51471
		// (get) Token: 0x0602F0FE RID: 192766 RVA: 0x0066BAE3 File Offset: 0x00669CE3
		// (set) Token: 0x0602F0FF RID: 192767 RVA: 0x0066BAEB File Offset: 0x00669CEB
		public ECommonTip2Type Type { get; set; }

		// Token: 0x1700C910 RID: 51472
		// (get) Token: 0x0602F100 RID: 192768 RVA: 0x0066BAF4 File Offset: 0x00669CF4
		// (set) Token: 0x0602F101 RID: 192769 RVA: 0x0066BAFC File Offset: 0x00669CFC
		public int CountDownNum { get; set; }

		// Token: 0x1700C911 RID: 51473
		// (get) Token: 0x0602F102 RID: 192770 RVA: 0x0066BB05 File Offset: 0x00669D05
		// (set) Token: 0x0602F103 RID: 192771 RVA: 0x0066BB0D File Offset: 0x00669D0D
		public string TidCountDownTxt { get; set; }

		// Token: 0x1700C912 RID: 51474
		// (get) Token: 0x0602F104 RID: 192772 RVA: 0x0066BB16 File Offset: 0x00669D16
		// (set) Token: 0x0602F105 RID: 192773 RVA: 0x0066BB1E File Offset: 0x00669D1E
		public ECountDownUiStyle UiStyle { get; set; }

		// Token: 0x1700C913 RID: 51475
		// (get) Token: 0x0602F106 RID: 192774 RVA: 0x0066BB27 File Offset: 0x00669D27
		// (set) Token: 0x0602F107 RID: 192775 RVA: 0x0066BB2F File Offset: 0x00669D2F
		public bool IsBlockPlayer { get; set; }

		// Token: 0x1700C914 RID: 51476
		// (get) Token: 0x0602F108 RID: 192776 RVA: 0x0066BB38 File Offset: 0x00669D38
		// (set) Token: 0x0602F109 RID: 192777 RVA: 0x0066BB40 File Offset: 0x00669D40
		public byte NullMask { get; set; }

		// Token: 0x0602F10A RID: 192778 RVA: 0x0066BB49 File Offset: 0x00669D49
		public ICommonTip2PrepareCountdownT()
		{
			this.Type = ECommonTip2Type.PrepareCountdown;
			this.CountDownNum = 0;
			this.TidCountDownTxt = null;
			this.UiStyle = ECountDownUiStyle.Common;
			this.IsBlockPlayer = false;
			this.NullMask = 0;
		}
	}
}
