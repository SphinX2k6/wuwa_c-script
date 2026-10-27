using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;

// Token: 0x02003420 RID: 13344
public class RedDotRoleChange : RedDotBase
{
	// Token: 0x0601CD81 RID: 118145 RVA: 0x0080C5F8 File Offset: 0x0080A7F8
	protected override bool OnCheck(int uId = 0)
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.DirectTrainMakeRoleChange, false);
		return ActivityDirectTrainHelper.IsProOpen && !player;
	}
}
