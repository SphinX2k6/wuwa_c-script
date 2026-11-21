using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E69 RID: 24169
	public class LevelConditionCheckSubPackageDownLoadBtnShow : LevelConditionBase
	{
		// Token: 0x0603A7D4 RID: 239572 RVA: 0x0108920B File Offset: 0x0108740B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			SubPackageDownLoadModel instance = SubPackageDownLoadModel.Instance;
			return instance != null && instance.NeedShowBattleViewButton();
		}
	}
}
