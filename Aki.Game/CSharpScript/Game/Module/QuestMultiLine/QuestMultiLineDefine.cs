using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004FA7 RID: 20391
	public static class QuestMultiLineDefine
	{
		// Token: 0x0603432D RID: 213805 RVA: 0x00C40B5C File Offset: 0x00C3ED5C
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

		// Token: 0x0401BC12 RID: 113682
		public const int HELP_ID = 617;

		// Token: 0x0401BC13 RID: 113683
		public const float TIME_POINT_ALPHA = 0.5f;

		// Token: 0x0401BC14 RID: 113684
		public const int FIGHT_AREA_MAX = 6;

		// Token: 0x0401BC15 RID: 113685
		public const int PATH_POINT_COUNT = 100;

		// Token: 0x0401BC16 RID: 113686
		public const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x0401BC17 RID: 113687
		public const int MAP_TEXTURE_SCALE = 1;

		// Token: 0x0401BC18 RID: 113688
		public const int MAP_DRAG_REBOUND_X = 100;

		// Token: 0x0401BC19 RID: 113689
		public const int MAP_DRAG_REBOUND_Y = 100;

		// Token: 0x0401BC1A RID: 113690
		public const float MAP_DRAG_BOUNCE_DURATION = 0.3f;

		// Token: 0x0401BC1B RID: 113691
		public const int MAP_DRAG_INERTIA_MULTIPLIER = 8;

		// Token: 0x0401BC1C RID: 113692
		public const float MAP_DRAG_INERTIA_DURATION = 0.6f;

		// Token: 0x0401BC1D RID: 113693
		public const float MAP_CENTER_ON_COMPONENT_DURATION = 0.35f;

		// Token: 0x0401BC1E RID: 113694
		public const int MIN_TIME = 20;

		// Token: 0x0401BC1F RID: 113695
		public const int TIPS_TIMER_DURATION_MS = 1000;

		// Token: 0x0401BC20 RID: 113696
		public const float TIME_LINE_SCROLL_TOLERANCE = 0.1f;
	}
}
