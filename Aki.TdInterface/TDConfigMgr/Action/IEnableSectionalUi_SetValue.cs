using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019EF RID: 6639
	public class IEnableSectionalUi_SetValue
	{
		// Token: 0x0400582B RID: 22571
		public EUiOperationType Type;

		// Token: 0x0400582C RID: 22572
		public bool? ShowMiniMap;

		// Token: 0x0400582D RID: 22573
		public bool? ShowQuestTrack;

		// Token: 0x0400582E RID: 22574
		public bool? ShowEsc;

		// Token: 0x0400582F RID: 22575
		public bool? ShowSystem;

		// Token: 0x04005830 RID: 22576
		public bool? ShowScreenEffect;

		// Token: 0x04005831 RID: 22577
		public bool? ShowRoleFormation;

		// Token: 0x04005832 RID: 22578
		public bool? ShowRoleStatus;

		// Token: 0x04005833 RID: 22579
		public bool? ShowBossStatus;

		// Token: 0x04005834 RID: 22580
		public bool? ShowGuideLayer;

		// Token: 0x04005835 RID: 22581
		public bool? ShowMonsterHpBar;

		// Token: 0x04005836 RID: 22582
		public bool? ShowDamageText;

		// Token: 0x04005837 RID: 22583
		public bool? ShowPing;

		// Token: 0x04005838 RID: 22584
		public bool? ShowOther;

		// Token: 0x04005839 RID: 22585
		[Nullable(2)]
		public List<EUiElement> AlwaysShowUiSections;

		// Token: 0x0400583A RID: 22586
		public bool? ShowPositionOfficial;
	}
}
