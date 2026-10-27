using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006496 RID: 25750
	public class ICommonTipEnterInRangeT
	{
		// Token: 0x1700BFA1 RID: 49057
		// (get) Token: 0x0602CA10 RID: 182800 RVA: 0x00620BB7 File Offset: 0x0061EDB7
		// (set) Token: 0x0602CA11 RID: 182801 RVA: 0x00620BBF File Offset: 0x0061EDBF
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFA2 RID: 49058
		// (get) Token: 0x0602CA12 RID: 182802 RVA: 0x00620BC8 File Offset: 0x0061EDC8
		// (set) Token: 0x0602CA13 RID: 182803 RVA: 0x00620BD0 File Offset: 0x0061EDD0
		public string TidText { get; set; }

		// Token: 0x0602CA14 RID: 182804 RVA: 0x00620BD9 File Offset: 0x0061EDD9
		public ICommonTipEnterInRangeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidText = null;
		}
	}
}
