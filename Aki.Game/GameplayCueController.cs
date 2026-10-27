using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

// Token: 0x02002FAE RID: 12206
public class GameplayCueController : IStaticVariableResetter
{
	// Token: 0x06019E0F RID: 105999 RVA: 0x006C3E59 File Offset: 0x006C2059
	static GameplayCueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayCueController.CreateStaticDefaultValue), new Action(GameplayCueController.ResetStaticDefaultValue));
	}

	// Token: 0x06019E10 RID: 106000 RVA: 0x006C3E78 File Offset: 0x006C2078
	public static GameplayCue? GetConfigById(long cueId)
	{
		GameplayCue? config = ConfigGameplayCueById.GetConfig(cueId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "无法找到Cue配置！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cueId", cueId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06019E11 RID: 106001 RVA: 0x006C3ECD File Offset: 0x006C20CD
	public static int GenerateHandle()
	{
		return ++GameplayCueController.LastHandle;
	}

	// Token: 0x06019E12 RID: 106002 RVA: 0x006C3EDC File Offset: 0x006C20DC
	[NullableContext(2)]
	public static EMaterial GetMaterialType(UObject materielObject)
	{
		if (materielObject is PD_CharacterControllerData_C)
		{
			return EMaterial.Data;
		}
		if (materielObject is PD_CharacterControllerDataGroup_C)
		{
			return EMaterial.DataGroup;
		}
		return EMaterial.Other;
	}

	// Token: 0x06019E13 RID: 106003 RVA: 0x006C3EF3 File Offset: 0x006C20F3
	public static ETargetSourceType GetTargetSourceType(GameplayCue cueConfig)
	{
		if (!((((cueConfig.ParametersLength > 0) ? cueConfig.Parameters(0) : null) ?? "0") == "1"))
		{
			return ETargetSourceType.LockOn;
		}
		return ETargetSourceType.Skill;
	}

	// Token: 0x06019E14 RID: 106004 RVA: 0x006C3F22 File Offset: 0x006C2122
	public static void CreateStaticDefaultValue()
	{
		GameplayCueController.LastHandle = 0;
	}

	// Token: 0x06019E15 RID: 106005 RVA: 0x006C3F2A File Offset: 0x006C212A
	public static void ResetStaticDefaultValue()
	{
		GameplayCueController.LastHandle = 0;
	}

	// Token: 0x0400C3B9 RID: 50105
	public const int INVALID_CUE_HANDLE = 0;

	// Token: 0x0400C3BA RID: 50106
	public const int INSTANT_CUE_HANDLE = -1;

	// Token: 0x0400C3BB RID: 50107
	private static int LastHandle;
}
