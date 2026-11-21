using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B82 RID: 7042
	public class IEnableSectionalUi_SetValue
	{
		// Token: 0x04005C8D RID: 23693
		public EUiOperationType Type;

		// Token: 0x04005C8E RID: 23694
		public bool? ShowMiniMap;

		// Token: 0x04005C8F RID: 23695
		public bool? ShowQuestTrack;

		// Token: 0x04005C90 RID: 23696
		public bool? ShowEsc;

		// Token: 0x04005C91 RID: 23697
		public bool? ShowSystem;

		// Token: 0x04005C92 RID: 23698
		public bool? ShowScreenEffect;

		// Token: 0x04005C93 RID: 23699
		public bool? ShowRoleFormation;

		// Token: 0x04005C94 RID: 23700
		public bool? ShowRoleStatus;

		// Token: 0x04005C95 RID: 23701
		public bool? ShowBossStatus;

		// Token: 0x04005C96 RID: 23702
		public bool? ShowGuideLayer;

		// Token: 0x04005C97 RID: 23703
		public bool? ShowMonsterHpBar;

		// Token: 0x04005C98 RID: 23704
		public bool? ShowDamageText;

		// Token: 0x04005C99 RID: 23705
		public bool? ShowPing;

		// Token: 0x04005C9A RID: 23706
		public bool? ShowOther;

		// Token: 0x04005C9B RID: 23707
		[Nullable(2)]
		public List<EUiElement> AlwaysShowUiSections;

		// Token: 0x04005C9C RID: 23708
		public bool? ShowPositionOfficial;
	}
}
