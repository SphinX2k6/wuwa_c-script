using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006099 RID: 24729
	public static class LevelGamePlayPrepareCountDownDefine
	{
		// Token: 0x0603B524 RID: 242980 RVA: 0x010CA248 File Offset: 0x010C8448
		// Note: this type is marked as 'beforefieldinit'.
		static LevelGamePlayPrepareCountDownDefine()
		{
			Dictionary<ECountDownUiStyle, string> dictionary = new Dictionary<ECountDownUiStyle, string>();
			dictionary[ECountDownUiStyle.MotorFight] = "MotorFightCountDown";
			LevelGamePlayPrepareCountDownDefine.countDownUiStyleToResourceId = dictionary;
		}

		// Token: 0x0401F405 RID: 128005
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ECountDownUiStyle, string> countDownUiStyleToResourceId;
	}
}
