using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA7 RID: 27559
	public class INightmareLordTipT
	{
		// Token: 0x1700CCD3 RID: 52435
		// (get) Token: 0x0603067D RID: 198269 RVA: 0x006930A8 File Offset: 0x006912A8
		// (set) Token: 0x0603067E RID: 198270 RVA: 0x006930B0 File Offset: 0x006912B0
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CCD4 RID: 52436
		// (get) Token: 0x0603067F RID: 198271 RVA: 0x006930B9 File Offset: 0x006912B9
		// (set) Token: 0x06030680 RID: 198272 RVA: 0x006930C1 File Offset: 0x006912C1
		public string TidMainText { get; set; }

		// Token: 0x1700CCD5 RID: 52437
		// (get) Token: 0x06030681 RID: 198273 RVA: 0x006930CA File Offset: 0x006912CA
		// (set) Token: 0x06030682 RID: 198274 RVA: 0x006930D2 File Offset: 0x006912D2
		public string TidSubText { get; set; }

		// Token: 0x06030683 RID: 198275 RVA: 0x006930DB File Offset: 0x006912DB
		public INightmareLordTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
