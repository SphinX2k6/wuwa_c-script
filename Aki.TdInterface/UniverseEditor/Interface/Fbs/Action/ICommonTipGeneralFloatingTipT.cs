using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B07 RID: 27399
	public class ICommonTipGeneralFloatingTipT
	{
		// Token: 0x1700C938 RID: 51512
		// (get) Token: 0x0602F1BA RID: 192954 RVA: 0x0066CBF3 File Offset: 0x0066ADF3
		// (set) Token: 0x0602F1BB RID: 192955 RVA: 0x0066CBFB File Offset: 0x0066ADFB
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C939 RID: 51513
		// (get) Token: 0x0602F1BC RID: 192956 RVA: 0x0066CC04 File Offset: 0x0066AE04
		// (set) Token: 0x0602F1BD RID: 192957 RVA: 0x0066CC0C File Offset: 0x0066AE0C
		public string TidMainText { get; set; }

		// Token: 0x0602F1BE RID: 192958 RVA: 0x0066CC15 File Offset: 0x0066AE15
		public ICommonTipGeneralFloatingTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
