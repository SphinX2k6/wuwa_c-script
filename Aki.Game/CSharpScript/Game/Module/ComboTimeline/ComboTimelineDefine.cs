using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline
{
	// Token: 0x02005B91 RID: 23441
	public class ComboTimelineDefine : IStaticVariableResetter
	{
		// Token: 0x0603B4D5 RID: 242901 RVA: 0x00E21DFC File Offset: 0x00E1FFFC
		static ComboTimelineDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComboTimelineDefine.CreateStaticDefaultValue), new Action(ComboTimelineDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603B4D6 RID: 242902 RVA: 0x00E21E1C File Offset: 0x00E2001C
		public static void CreateStaticDefaultValue()
		{
			ComboTimelineDefine.recordedInputActions = new List<EInputAction>
			{
				EInputAction.攻击,
				EInputAction.闪避,
				EInputAction.技能1,
				EInputAction.幻象1,
				EInputAction.大招,
				EInputAction.幻象2,
				EInputAction.切换角色1,
				EInputAction.切换角色2,
				EInputAction.切换角色3,
				EInputAction.下降
			};
			ComboTimelineDefine.replayBlockedInputActions = new List<EInputAction>
			{
				EInputAction.跳跃,
				EInputAction.攀爬,
				EInputAction.走跑切换,
				EInputAction.攻击,
				EInputAction.闪避,
				EInputAction.技能1,
				EInputAction.幻象1,
				EInputAction.大招,
				EInputAction.幻象2,
				EInputAction.切换角色1,
				EInputAction.切换角色2,
				EInputAction.切换角色3,
				EInputAction.锁定目标,
				EInputAction.瞄准,
				EInputAction.通用交互,
				EInputAction.下降
			};
		}

		// Token: 0x0603B4D7 RID: 242903 RVA: 0x00E21F5B File Offset: 0x00E2015B
		public static void ResetStaticDefaultValue()
		{
			ComboTimelineDefine.recordedInputActions = null;
			ComboTimelineDefine.replayBlockedInputActions = null;
		}

		// Token: 0x0401EE8A RID: 126602
		public const int SHOW_TIMELINE_FPS = 60;

		// Token: 0x0401EE8B RID: 126603
		public const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x0401EE8C RID: 126604
		public const int REPLAY_COUNTDOWN_SECONDS = 3;

		// Token: 0x0401EE8D RID: 126605
		public const int REPLAY_DRAIN_TIMEOUT_MS = 3000;

		// Token: 0x0401EE8E RID: 126606
		public const double MS_PER_FRAME = 16.666666666666668;

		// Token: 0x0401EE8F RID: 126607
		public const int RECORDER_INPUT_PRIORITY = 100000;

		// Token: 0x0401EE90 RID: 126608
		[Nullable(2)]
		public static IReadOnlyList<EInputAction> recordedInputActions;

		// Token: 0x0401EE91 RID: 126609
		[Nullable(2)]
		public static IReadOnlyList<EInputAction> replayBlockedInputActions;
	}
}
