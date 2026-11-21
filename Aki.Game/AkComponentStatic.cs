using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200259B RID: 9627
internal class AkComponentStatic : IStaticVariableResetter
{
	// Token: 0x06017D46 RID: 97606 RVA: 0x007123DE File Offset: 0x007105DE
	static AkComponentStatic()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AkComponentStatic.CreateStaticDefaultValue), new Action(AkComponentStatic.ResetStaticDefaultValue));
	}

	// Token: 0x06017D47 RID: 97607 RVA: 0x007123FD File Offset: 0x007105FD
	public static bool Load()
	{
		if (AkComponentStatic.Init)
		{
			return true;
		}
		AudioSystem.Instance.SetState("role_move", "Normal", true);
		AkComponentStatic.Init = true;
		return true;
	}

	// Token: 0x06017D48 RID: 97608 RVA: 0x00712424 File Offset: 0x00710624
	public static void CreateStaticDefaultValue()
	{
		AkComponentStatic.Init = false;
		AkComponentStatic.AkMoveState = EAkMoveState.Normal;
		Dictionary<EAkMoveState, int> dictionary = new Dictionary<EAkMoveState, int>();
		dictionary[EAkMoveState.Fall] = GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.下落"];
		dictionary[EAkMoveState.Fly] = GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.滑翔"];
		dictionary[EAkMoveState.HighSpeed] = GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.高速移动"];
		dictionary[EAkMoveState.Sit] = GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下"];
		dictionary[EAkMoveState.Slide] = GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.滑坡"];
		AkComponentStatic.AkMoveStateMap = dictionary;
	}

	// Token: 0x06017D49 RID: 97609 RVA: 0x007124B5 File Offset: 0x007106B5
	public static void ResetStaticDefaultValue()
	{
		AkComponentStatic.Init = false;
		AkComponentStatic.AkMoveState = EAkMoveState.Normal;
		AkComponentStatic.AkMoveStateMap = null;
	}

	// Token: 0x0400CB79 RID: 52089
	public static bool Init;

	// Token: 0x0400CB7A RID: 52090
	public static EAkMoveState AkMoveState;

	// Token: 0x0400CB7B RID: 52091
	[Nullable(1)]
	public static Dictionary<EAkMoveState, int> AkMoveStateMap;
}
