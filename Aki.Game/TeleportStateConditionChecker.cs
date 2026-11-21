using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;

// Token: 0x02001FEE RID: 8174
public class TeleportStateConditionChecker : ISkipConditionChecker
{
	// Token: 0x0601443F RID: 83007 RVA: 0x005E83B3 File Offset: 0x005E65B3
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

	// Token: 0x06014440 RID: 83008 RVA: 0x005E83D4 File Offset: 0x005E65D4
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
