using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007685 RID: 30341
	public class IRoleTowerStrongEnemyWarningT
	{
		// Token: 0x1700DEAF RID: 57007
		// (get) Token: 0x060353A4 RID: 218020 RVA: 0x007249B7 File Offset: 0x00722BB7
		// (set) Token: 0x060353A5 RID: 218021 RVA: 0x007249BF File Offset: 0x00722BBF
		public ECommonTipType Type { get; set; }

		// Token: 0x1700DEB0 RID: 57008
		// (get) Token: 0x060353A6 RID: 218022 RVA: 0x007249C8 File Offset: 0x00722BC8
		// (set) Token: 0x060353A7 RID: 218023 RVA: 0x007249D0 File Offset: 0x00722BD0
		public string TidMainText { get; set; }

		// Token: 0x060353A8 RID: 218024 RVA: 0x007249D9 File Offset: 0x00722BD9
		public IRoleTowerStrongEnemyWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
