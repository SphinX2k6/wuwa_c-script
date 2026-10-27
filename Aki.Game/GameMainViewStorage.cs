using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02001CB2 RID: 7346
[NullableContext(1)]
[Nullable(0)]
public class GameMainViewStorage : IStaticVariableResetter
{
	// Token: 0x0600DDFB RID: 56827 RVA: 0x0033E30F File Offset: 0x0033C50F
	static GameMainViewStorage()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameMainViewStorage.CreateStaticDefaultValue), new Action(GameMainViewStorage.ResetStaticDefaultValue));
	}

	// Token: 0x0600DDFC RID: 56828 RVA: 0x0033E32E File Offset: 0x0033C52E
	public static void CreateStaticDefaultValue()
	{
		GameMainViewStorage.MainViewInfoMap = new Dictionary<EDungeonSubType, Type>();
		GameMainViewStorage.MainViewInfoMapWorldInstance = new Dictionary<EWorldDungeonSubType, Type>();
		GameMainViewStorage.OtherMainViewInfoMap = new Dictionary<EDungeonSubType, EUiViewName>();
	}

	// Token: 0x0600DDFD RID: 56829 RVA: 0x0033E34E File Offset: 0x0033C54E
	public static void ResetStaticDefaultValue()
	{
		GameMainViewStorage.MainViewInfoMap = null;
		GameMainViewStorage.MainViewInfoMapWorldInstance = null;
		GameMainViewStorage.OtherMainViewInfoMap = null;
	}

	// Token: 0x0600DDFE RID: 56830 RVA: 0x0033E362 File Offset: 0x0033C562
	public static void RegisterMainViewInfo(EDungeonSubType dungeonSubType, Type viewProxy)
	{
		GameMainViewStorage.MainViewInfoMap[dungeonSubType] = viewProxy;
	}

	// Token: 0x0600DDFF RID: 56831 RVA: 0x0033E370 File Offset: 0x0033C570
	public static void RegisterMainViewInfoWorldInstance(EWorldDungeonSubType worldDungeonType, Type viewProxy)
	{
		GameMainViewStorage.MainViewInfoMapWorldInstance[worldDungeonType] = viewProxy;
	}

	// Token: 0x0600DE00 RID: 56832 RVA: 0x0033E37E File Offset: 0x0033C57E
	public static void RegisterOtherMainViewInfo(EDungeonSubType dungeonSubType, EUiViewName viewName)
	{
		GameMainViewStorage.OtherMainViewInfoMap[dungeonSubType] = viewName;
	}

	// Token: 0x0600DE01 RID: 56833 RVA: 0x0033E38C File Offset: 0x0033C58C
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

	// Token: 0x0600DE02 RID: 56834 RVA: 0x0033E3C4 File Offset: 0x0033C5C4
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

	// Token: 0x040065CC RID: 26060
	private static Dictionary<EDungeonSubType, Type> MainViewInfoMap;

	// Token: 0x040065CD RID: 26061
	private static Dictionary<EWorldDungeonSubType, Type> MainViewInfoMapWorldInstance;

	// Token: 0x040065CE RID: 26062
	private static Dictionary<EDungeonSubType, EUiViewName> OtherMainViewInfoMap;
}
