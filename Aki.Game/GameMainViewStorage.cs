using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02001174 RID: 4468
[NullableContext(1)]
[Nullable(0)]
public class GameMainViewStorage : IStaticVariableResetter
{
	// Token: 0x0600B218 RID: 45592 RVA: 0x00349D4B File Offset: 0x00347F4B
	static GameMainViewStorage()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameMainViewStorage.CreateStaticDefaultValue), new Action(GameMainViewStorage.ResetStaticDefaultValue));
	}

	// Token: 0x0600B219 RID: 45593 RVA: 0x00349D6A File Offset: 0x00347F6A
	public static void CreateStaticDefaultValue()
	{
		GameMainViewStorage.MainViewInfoMap = new Dictionary<EDungeonSubType, Type>();
		GameMainViewStorage.MainViewInfoMapWorldInstance = new Dictionary<EWorldDungeonSubType, Type>();
		GameMainViewStorage.OtherMainViewInfoMap = new Dictionary<EDungeonSubType, EUiViewName>();
	}

	// Token: 0x0600B21A RID: 45594 RVA: 0x00349D8A File Offset: 0x00347F8A
	public static void ResetStaticDefaultValue()
	{
		GameMainViewStorage.MainViewInfoMap = null;
		GameMainViewStorage.MainViewInfoMapWorldInstance = null;
		GameMainViewStorage.OtherMainViewInfoMap = null;
	}

	// Token: 0x0600B21B RID: 45595 RVA: 0x00349D9E File Offset: 0x00347F9E
	public static void RegisterMainViewInfo(EDungeonSubType dungeonSubType, Type viewProxy)
	{
		GameMainViewStorage.MainViewInfoMap[dungeonSubType] = viewProxy;
	}

	// Token: 0x0600B21C RID: 45596 RVA: 0x00349DAC File Offset: 0x00347FAC
	public static void RegisterMainViewInfoWorldInstance(EWorldDungeonSubType worldDungeonType, Type viewProxy)
	{
		GameMainViewStorage.MainViewInfoMapWorldInstance[worldDungeonType] = viewProxy;
	}

	// Token: 0x0600B21D RID: 45597 RVA: 0x00349DBA File Offset: 0x00347FBA
	public static void RegisterOtherMainViewInfo(EDungeonSubType dungeonSubType, EUiViewName viewName)
	{
		GameMainViewStorage.OtherMainViewInfoMap[dungeonSubType] = viewName;
	}

	// Token: 0x0600B21E RID: 45598 RVA: 0x00349DC8 File Offset: 0x00347FC8
	[NullableContext(2)]
	public static Type GetMainViewInfo(EDungeonSubType dungeonSubType, EWorldDungeonSubType worldDungeonType)
	{
		if (dungeonSubType == EDungeonSubType.WorldInstance)
		{
			Type result;
			if (!GameMainViewStorage.MainViewInfoMapWorldInstance.TryGetValue(worldDungeonType, out result))
			{
				return null;
			}
			return result;
		}
		else
		{
			Type result2;
			if (!GameMainViewStorage.MainViewInfoMap.TryGetValue(dungeonSubType, out result2))
			{
				return null;
			}
			return result2;
		}
	}

	// Token: 0x0600B21F RID: 45599 RVA: 0x00349E00 File Offset: 0x00348000
	public static EUiViewName GetMainViewName(EDungeonSubType dungeonSubType, EWorldDungeonSubType worldDungeonType)
	{
		if (dungeonSubType == EDungeonSubType.WorldInstance && GameMainViewStorage.MainViewInfoMapWorldInstance.ContainsKey(worldDungeonType))
		{
			return EUiViewName.CommonGameMainView;
		}
		EUiViewName? valueOrNull = GameMainViewStorage.OtherMainViewInfoMap.GetValueOrNull(dungeonSubType);
		if (valueOrNull != null)
		{
			return valueOrNull.Value;
		}
		if (GameMainViewStorage.MainViewInfoMap.ContainsKey(dungeonSubType))
		{
			return EUiViewName.CommonGameMainView;
		}
		return EUiViewName.BattleView;
	}

	// Token: 0x040066AB RID: 26283
	private static Dictionary<EDungeonSubType, Type> MainViewInfoMap;

	// Token: 0x040066AC RID: 26284
	private static Dictionary<EWorldDungeonSubType, Type> MainViewInfoMapWorldInstance;

	// Token: 0x040066AD RID: 26285
	private static Dictionary<EDungeonSubType, EUiViewName> OtherMainViewInfoMap;
}
