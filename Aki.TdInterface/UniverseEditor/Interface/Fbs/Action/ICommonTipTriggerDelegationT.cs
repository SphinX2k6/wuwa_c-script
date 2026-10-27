using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064AE RID: 25774
	public class ICommonTipTriggerDelegationT
	{
		// Token: 0x1700BFCC RID: 49100
		// (get) Token: 0x0602CAD6 RID: 182998 RVA: 0x00621E40 File Offset: 0x00620040
		// (set) Token: 0x0602CAD7 RID: 182999 RVA: 0x00621E48 File Offset: 0x00620048
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFCD RID: 49101
		// (get) Token: 0x0602CAD8 RID: 183000 RVA: 0x00621E51 File Offset: 0x00620051
		// (set) Token: 0x0602CAD9 RID: 183001 RVA: 0x00621E59 File Offset: 0x00620059
		public string TidMainText { get; set; }

		// Token: 0x1700BFCE RID: 49102
		// (get) Token: 0x0602CADA RID: 183002 RVA: 0x00621E62 File Offset: 0x00620062
		// (set) Token: 0x0602CADB RID: 183003 RVA: 0x00621E6A File Offset: 0x0062006A
		public string TidSubText { get; set; }

		// Token: 0x0602CADC RID: 183004 RVA: 0x00621E73 File Offset: 0x00620073
		public ICommonTipTriggerDelegationT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
