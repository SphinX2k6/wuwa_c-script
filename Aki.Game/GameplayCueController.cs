using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

// Token: 0x02002502 RID: 9474
public class GameplayCueController : IStaticVariableResetter
{
	// Token: 0x06017721 RID: 96033 RVA: 0x006EA6F5 File Offset: 0x006E88F5
	static GameplayCueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayCueController.CreateStaticDefaultValue), new Action(GameplayCueController.ResetStaticDefaultValue));
	}

	// Token: 0x06017722 RID: 96034 RVA: 0x006EA714 File Offset: 0x006E8914
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

	// Token: 0x06017723 RID: 96035 RVA: 0x006EA769 File Offset: 0x006E8969
	public static int GenerateHandle()
	{
		return ++GameplayCueController.LastHandle;
	}

	// Token: 0x06017724 RID: 96036 RVA: 0x006EA778 File Offset: 0x006E8978
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

	// Token: 0x06017725 RID: 96037 RVA: 0x006EA78F File Offset: 0x006E898F
	public static ETargetSourceType GetTargetSourceType(GameplayCue cueConfig)
	{
		if (!((((cueConfig.ParametersLength > 0) ? cueConfig.Parameters(0) : null) ?? "0") == "1"))
		{
			return ETargetSourceType.LockOn;
		}
		return ETargetSourceType.Skill;
	}

	// Token: 0x06017726 RID: 96038 RVA: 0x006EA7BE File Offset: 0x006E89BE
	public static void CreateStaticDefaultValue()
	{
		GameplayCueController.LastHandle = 0;
	}

	// Token: 0x06017727 RID: 96039 RVA: 0x006EA7C6 File Offset: 0x006E89C6
	public static void ResetStaticDefaultValue()
	{
		GameplayCueController.LastHandle = 0;
	}

	// Token: 0x0400C762 RID: 51042
	public const int INVALID_CUE_HANDLE = 0;

	// Token: 0x0400C763 RID: 51043
	public const int INSTANT_CUE_HANDLE = -1;

	// Token: 0x0400C764 RID: 51044
	private static int LastHandle;
}
