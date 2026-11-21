using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;

// Token: 0x02002992 RID: 10642
public class RedDotRoleChange : RedDotBase
{
	// Token: 0x0601AA79 RID: 109177 RVA: 0x00832BBC File Offset: 0x00830DBC
	protected override bool OnCheck(int uId = 0)
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.DirectTrainMakeRoleChange, false);
		return ActivityDirectTrainHelper.IsProOpen && !player;
	}
}
