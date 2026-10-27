using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Avg;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x0200631C RID: 25372
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballAvgUtils
	{
		// Token: 0x0603FD59 RID: 261465 RVA: 0x00F7193C File Offset: 0x00F6FB3C
		public static string GetSpineAnimation(EPlotAvgCharacterSpineDirection direction, EAvgRoleAnimationType animationType)
		{
			if (direction != EPlotAvgCharacterSpineDirection.Left)
			{
				if (direction != EPlotAvgCharacterSpineDirection.Right)
				{
					return "Idle_Fight_B";
				}
				switch (animationType)
				{
				case EAvgRoleAnimationType.Idle:
					return "Idle_Fight";
				case EAvgRoleAnimationType.Victory:
					return "victor";
				case EAvgRoleAnimationType.TouchFeedback:
					return "touch";
				case EAvgRoleAnimationType.Skill:
					return "Burst01";
				case EAvgRoleAnimationType.HumanToBall:
					return "dead";
				case EAvgRoleAnimationType.BallToHuman:
					return "revive";
				case EAvgRoleAnimationType.AvgPlaySkill:
					return "Burst02";
				default:
					return "Idle_Fight";
				}
			}
			else
			{
				switch (animationType)
				{
				case EAvgRoleAnimationType.Idle:
					return "Idle_Fight_B";
				case EAvgRoleAnimationType.Victory:
					return "victor_B";
				case EAvgRoleAnimationType.TouchFeedback:
					return "touch_B";
				default:
					return "Idle_Fight_B";
				}
			}
		}

		// Token: 0x0603FD5A RID: 261466 RVA: 0x00F719DC File Offset: 0x00F6FBDC
		public static string GetSpineAnimationAkEvent(string animation)
		{
			if (animation == "victor_B" || animation == "victor")
			{
				return "play_ui_catapultstory_avg_role_win";
			}
			if (animation == "touch_B" || animation == "touch")
			{
				return "play_ui_catapultstory_avg_role_touch";
			}
			if (animation == "dead")
			{
				return "play_ui_catapultstory_avg_role_marble";
			}
			if (animation == "revive")
			{
				return "play_ui_catapultstory_avg_role_people";
			}
			if (animation == "Burst01" || animation == "Burst02")
			{
				return "play_ui_catapultstory_avg_role_skill";
			}
			return "";
		}

		// Token: 0x0603FD5B RID: 261467 RVA: 0x00F71A74 File Offset: 0x00F6FC74
		public static string GetMoveAkEvent(float moveSpeed)
		{
			if (moveSpeed < 313f)
			{
				return "play_ui_catapultstory_avg_role_move_slow";
			}
			return "play_ui_catapultstory_avg_role_move_fast";
		}
	}
}
