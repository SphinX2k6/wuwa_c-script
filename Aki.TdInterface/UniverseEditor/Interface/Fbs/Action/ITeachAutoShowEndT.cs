using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B46 RID: 31558
	public class ITeachAutoShowEndT
	{
		// Token: 0x1700EC58 RID: 60504
		// (get) Token: 0x06038D5B RID: 232795 RVA: 0x007AF6AB File Offset: 0x007AD8AB
		// (set) Token: 0x06038D5C RID: 232796 RVA: 0x007AF6B3 File Offset: 0x007AD8B3
		public ECommonTipType Type { get; set; }

		// Token: 0x1700EC59 RID: 60505
		// (get) Token: 0x06038D5D RID: 232797 RVA: 0x007AF6BC File Offset: 0x007AD8BC
		// (set) Token: 0x06038D5E RID: 232798 RVA: 0x007AF6C4 File Offset: 0x007AD8C4
		public string TidMainText { get; set; }

		// Token: 0x06038D5F RID: 232799 RVA: 0x007AF6CD File Offset: 0x007AD8CD
		public ITeachAutoShowEndT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
