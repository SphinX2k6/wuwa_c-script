using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003045 RID: 12357
internal class AkComponentStatic : IStaticVariableResetter
{
	// Token: 0x0601A3CA RID: 107466 RVA: 0x006EAC26 File Offset: 0x006E8E26
	static AkComponentStatic()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AkComponentStatic.CreateStaticDefaultValue), new Action(AkComponentStatic.ResetStaticDefaultValue));
	}

	// Token: 0x0601A3CB RID: 107467 RVA: 0x006EAC45 File Offset: 0x006E8E45
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

	// Token: 0x0601A3CC RID: 107468 RVA: 0x006EAC6C File Offset: 0x006E8E6C
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

	// Token: 0x0601A3CD RID: 107469 RVA: 0x006EACFD File Offset: 0x006E8EFD
	public static void ResetStaticDefaultValue()
	{
		AkComponentStatic.Init = false;
		AkComponentStatic.AkMoveState = EAkMoveState.Normal;
		AkComponentStatic.AkMoveStateMap = null;
	}

	// Token: 0x0400C79F RID: 51103
	public static bool Init;

	// Token: 0x0400C7A0 RID: 51104
	public static EAkMoveState AkMoveState;

	// Token: 0x0400C7A1 RID: 51105
	[Nullable(1)]
	public static Dictionary<EAkMoveState, int> AkMoveStateMap;
}
