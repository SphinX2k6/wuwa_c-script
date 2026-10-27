using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CBB RID: 27835
	public class LevelConditionCheckKurotatoLevelWave : LevelConditionBase
	{
		// Token: 0x0604460E RID: 280078 RVA: 0x010DCE20 File Offset: 0x010DB020
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
