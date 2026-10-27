using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006484 RID: 25732
	public class ICommonTip2PrepareCountdownT
	{
		// Token: 0x1700BF82 RID: 49026
		// (get) Token: 0x0602C984 RID: 182660 RVA: 0x0061FF0F File Offset: 0x0061E10F
		// (set) Token: 0x0602C985 RID: 182661 RVA: 0x0061FF17 File Offset: 0x0061E117
		public ECommonTip2Type Type { get; set; }

		// Token: 0x1700BF83 RID: 49027
		// (get) Token: 0x0602C986 RID: 182662 RVA: 0x0061FF20 File Offset: 0x0061E120
		// (set) Token: 0x0602C987 RID: 182663 RVA: 0x0061FF28 File Offset: 0x0061E128
		public int CountDownNum { get; set; }

		// Token: 0x1700BF84 RID: 49028
		// (get) Token: 0x0602C988 RID: 182664 RVA: 0x0061FF31 File Offset: 0x0061E131
		// (set) Token: 0x0602C989 RID: 182665 RVA: 0x0061FF39 File Offset: 0x0061E139
		public string TidCountDownTxt { get; set; }

		// Token: 0x1700BF85 RID: 49029
		// (get) Token: 0x0602C98A RID: 182666 RVA: 0x0061FF42 File Offset: 0x0061E142
		// (set) Token: 0x0602C98B RID: 182667 RVA: 0x0061FF4A File Offset: 0x0061E14A
		public ECountDownUiStyle UiStyle { get; set; }

		// Token: 0x1700BF86 RID: 49030
		// (get) Token: 0x0602C98C RID: 182668 RVA: 0x0061FF53 File Offset: 0x0061E153
		// (set) Token: 0x0602C98D RID: 182669 RVA: 0x0061FF5B File Offset: 0x0061E15B
		public bool IsBlockPlayer { get; set; }

		// Token: 0x1700BF87 RID: 49031
		// (get) Token: 0x0602C98E RID: 182670 RVA: 0x0061FF64 File Offset: 0x0061E164
		// (set) Token: 0x0602C98F RID: 182671 RVA: 0x0061FF6C File Offset: 0x0061E16C
		public byte NullMask { get; set; }

		// Token: 0x0602C990 RID: 182672 RVA: 0x0061FF75 File Offset: 0x0061E175
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
