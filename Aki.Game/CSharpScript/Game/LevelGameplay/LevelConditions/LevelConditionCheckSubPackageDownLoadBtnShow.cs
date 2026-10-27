using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CEC RID: 27884
	public class LevelConditionCheckSubPackageDownLoadBtnShow : LevelConditionBase
	{
		// Token: 0x06044674 RID: 280180 RVA: 0x010DF02B File Offset: 0x010DD22B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			SubPackageDownLoadModel instance = SubPackageDownLoadModel.Instance;
			return instance != null && instance.NeedShowBattleViewButton();
		}
	}
}
