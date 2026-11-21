using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E35 RID: 24117
	public class LevelConditionCheckKurotatoLevelWave : LevelConditionBase
	{
		// Token: 0x0603A768 RID: 239464 RVA: 0x01086E74 File Offset: 0x01085074
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			string limitParams2 = inConditionInfo.GetLimitParams("Wave");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			KurotatoModel instance = KurotatoModel.Instance;
			return instance.GetCurLevelId() == int.Parse(limitParams) && instance.CurWaveNum == int.Parse(limitParams2);
		}
	}
}
