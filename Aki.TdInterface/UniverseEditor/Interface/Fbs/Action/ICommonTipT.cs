using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE9 RID: 27369
	public class ICommonTipT
	{
		// Token: 0x1700C901 RID: 51457
		// (get) Token: 0x0602F0C8 RID: 192712 RVA: 0x0066B49B File Offset: 0x0066969B
		// (set) Token: 0x0602F0C9 RID: 192713 RVA: 0x0066B4A3 File Offset: 0x006696A3
		public TCommonTipOptionUnion TipOption { get; set; }

		// Token: 0x1700C902 RID: 51458
		// (get) Token: 0x0602F0CA RID: 192714 RVA: 0x0066B4AC File Offset: 0x006696AC
		// (set) Token: 0x0602F0CB RID: 192715 RVA: 0x0066B4B4 File Offset: 0x006696B4
		public int Duration { get; set; }

		// Token: 0x1700C903 RID: 51459
		// (get) Token: 0x0602F0CC RID: 192716 RVA: 0x0066B4BD File Offset: 0x006696BD
		// (set) Token: 0x0602F0CD RID: 192717 RVA: 0x0066B4C5 File Offset: 0x006696C5
		public string Token { get; set; }

		// Token: 0x1700C904 RID: 51460
		// (get) Token: 0x0602F0CE RID: 192718 RVA: 0x0066B4CE File Offset: 0x006696CE
		// (set) Token: 0x0602F0CF RID: 192719 RVA: 0x0066B4D6 File Offset: 0x006696D6
		public byte NullMask { get; set; }

		// Token: 0x0602F0D0 RID: 192720 RVA: 0x0066B4DF File Offset: 0x006696DF
		public ICommonTipT()
		{
			this.TipOption = null;
			this.Duration = 0;
			this.Token = null;
			this.NullMask = 0;
		}
	}
}
