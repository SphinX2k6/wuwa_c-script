using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline
{
	// Token: 0x02004B71 RID: 19313
	public class ComboTimelineDefine : IStaticVariableResetter
	{
		// Token: 0x06030422 RID: 197666 RVA: 0x00D7234C File Offset: 0x00D7054C
		static ComboTimelineDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComboTimelineDefine.CreateStaticDefaultValue), new Action(ComboTimelineDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06030423 RID: 197667 RVA: 0x00D7236C File Offset: 0x00D7056C
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

		// Token: 0x06030424 RID: 197668 RVA: 0x00D724AB File Offset: 0x00D706AB
		public static void ResetStaticDefaultValue()
		{
			ComboTimelineDefine.recordedInputActions = null;
			ComboTimelineDefine.replayBlockedInputActions = null;
		}

		// Token: 0x0401993B RID: 104763
		public const int SHOW_TIMELINE_FPS = 60;

		// Token: 0x0401993C RID: 104764
		public const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x0401993D RID: 104765
		public const int REPLAY_COUNTDOWN_SECONDS = 3;

		// Token: 0x0401993E RID: 104766
		public const int REPLAY_DRAIN_TIMEOUT_MS = 3000;

		// Token: 0x0401993F RID: 104767
		public const double MS_PER_FRAME = 16.666666666666668;

		// Token: 0x04019940 RID: 104768
		public const int RECORDER_INPUT_PRIORITY = 100000;

		// Token: 0x04019941 RID: 104769
		[Nullable(2)]
		public static IReadOnlyList<EInputAction> recordedInputActions;

		// Token: 0x04019942 RID: 104770
		[Nullable(2)]
		public static IReadOnlyList<EInputAction> replayBlockedInputActions;
	}
}
