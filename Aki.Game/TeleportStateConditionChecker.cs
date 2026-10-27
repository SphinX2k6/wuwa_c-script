using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;

// Token: 0x02002A73 RID: 10867
public class TeleportStateConditionChecker : ISkipConditionChecker
{
	// Token: 0x06016A1E RID: 92702 RVA: 0x005BC22B File Offset: 0x005BA42B
	[NullableContext(1)]
	public ISkipCondition<ESkipConditionType> Parse(int[] @params)
	{
		return new TeleportStateConditionImpl
		{
			ConditionType = ESkipConditionType.TeleportState,
			MarkId = @params[0],
			CheckTeleportState = (ETeleportState)@params[1]
		};
	}

	// Token: 0x06016A1F RID: 92703 RVA: 0x005BC24C File Offset: 0x005BA44C
	[NullableContext(1)]
	public bool Check(int[] @params)
	{
		TeleportStateConditionImpl teleportStateConditionImpl = this.Parse(@params) as TeleportStateConditionImpl;
		if (teleportStateConditionImpl == null)
		{
			return false;
		}
		int markId = teleportStateConditionImpl.MarkId;
		bool checkTeleportState = teleportStateConditionImpl.CheckTeleportState != ETeleportState.Inactive;
		bool flag = MapModel.Instance.CheckTeleportUnlocked(markId);
		if (!checkTeleportState)
		{
			return !flag;
		}
		return flag;
	}
}
