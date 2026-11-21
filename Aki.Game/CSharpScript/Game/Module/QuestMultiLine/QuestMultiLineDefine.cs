using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F70 RID: 16240
	public static class QuestMultiLineDefine
	{
		// Token: 0x0602919B RID: 168347 RVA: 0x00B8A308 File Offset: 0x00B88508
		[NullableContext(1)]
		public static string GetUiPrefab(EUiPrefab prefab)
		{
			string result;
			switch (prefab)
			{
			case EUiPrefab.ComponentId:
				result = "PnlMissionMapRoleItem";
				break;
			case EUiPrefab.DialogueLeft:
				result = "PnlDialogueL";
				break;
			case EUiPrefab.DialogueRight:
				result = "PnlDialogueR";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x040165E7 RID: 91623
		public const int HELP_ID = 617;

		// Token: 0x040165E8 RID: 91624
		public const float TIME_POINT_ALPHA = 0.5f;

		// Token: 0x040165E9 RID: 91625
		public const int FIGHT_AREA_MAX = 6;

		// Token: 0x040165EA RID: 91626
		public const int PATH_POINT_COUNT = 100;

		// Token: 0x040165EB RID: 91627
		public const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x040165EC RID: 91628
		public const int MAP_TEXTURE_SCALE = 1;

		// Token: 0x040165ED RID: 91629
		public const int MAP_DRAG_REBOUND_X = 100;

		// Token: 0x040165EE RID: 91630
		public const int MAP_DRAG_REBOUND_Y = 100;

		// Token: 0x040165EF RID: 91631
		public const float MAP_DRAG_BOUNCE_DURATION = 0.3f;

		// Token: 0x040165F0 RID: 91632
		public const int MAP_DRAG_INERTIA_MULTIPLIER = 8;

		// Token: 0x040165F1 RID: 91633
		public const float MAP_DRAG_INERTIA_DURATION = 0.6f;

		// Token: 0x040165F2 RID: 91634
		public const float MAP_CENTER_ON_COMPONENT_DURATION = 0.35f;

		// Token: 0x040165F3 RID: 91635
		public const int MIN_TIME = 20;

		// Token: 0x040165F4 RID: 91636
		public const int TIPS_TIMER_DURATION_MS = 1000;

		// Token: 0x040165F5 RID: 91637
		public const float TIME_LINE_SCROLL_TOLERANCE = 0.1f;
	}
}
