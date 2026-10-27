using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006F18 RID: 28440
	public static class LevelGamePlayPrepareCountDownDefine
	{
		// Token: 0x06045376 RID: 283510 RVA: 0x011202A8 File Offset: 0x0111E4A8
		// Note: this type is marked as 'beforefieldinit'.
		static LevelGamePlayPrepareCountDownDefine()
		{
			Dictionary<ECountDownUiStyle, string> dictionary = new Dictionary<ECountDownUiStyle, string>();
			dictionary[ECountDownUiStyle.MotorFight] = "MotorFightCountDown";
			LevelGamePlayPrepareCountDownDefine.countDownUiStyleToResourceId = dictionary;
		}

		// Token: 0x04024150 RID: 147792
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ECountDownUiStyle, string> countDownUiStyleToResourceId;
	}
}
