using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.Utils;
using CSharpScript.Utils;
using Google.Protobuf.Collections;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A1E RID: 10782
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C")]
public class CombatDebugBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B29B RID: 111259 RVA: 0x00855A1C File Offset: 0x00853C1C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddPassiveSkillForDebug(int entityId, long passiveSkillId)
	{
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.LearnPassiveSkill(passiveSkillId, new AddPassiveSkillParam
			{
				CombatMessageId = -1L,
				PreMessageId = new long?(-1L)
			});
		}
	}

	// Token: 0x0601B29C RID: 111260 RVA: 0x00855A64 File Offset: 0x00853C64
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemovePassiveSkillForDebug(int entityId, long passiveSkillId)
	{
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ForgetPassiveSkill(passiveSkillId, false);
		}
	}

	// Token: 0x0601B29D RID: 111261 RVA: 0x00855A90 File Offset: 0x00853C90
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetDebugMonsterMovePath()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.DebugMonsterMovePath;
	}

	// Token: 0x0601B29E RID: 111262 RVA: 0x00855AA2 File Offset: 0x00853CA2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetDebugMonsterMovePath(bool value)
	{
		CombatDebugDrawController.Instance.DebugMonsterMovePath = value;
	}

	// Token: 0x0601B29F RID: 111263 RVA: 0x00855AAF File Offset: 0x00853CAF
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetDebugMonsterControl()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.DebugMonsterControl;
	}

	// Token: 0x0601B2A0 RID: 111264 RVA: 0x00855AC1 File Offset: 0x00853CC1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetDebugMonsterControl(bool value)
	{
		CombatDebugDrawController.Instance.DebugMonsterControl = value;
	}

	// Token: 0x0601B2A1 RID: 111265 RVA: 0x00855AD0 File Offset: 0x00853CD0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenMonsterServerLogic(bool value)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CloseMonsterServerLogic#");
		defaultInterpolatedStringHandler.AppendFormatted<int>((!value) ? 1 : 0);
		string p = defaultInterpolatedStringHandler.ToStringAndClear();
		EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
	}

	// Token: 0x0601B2A2 RID: 111266 RVA: 0x00855B17 File Offset: 0x00853D17
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDrawEntityBoxEnabled()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.IsDrawEntityBoxEnabled;
	}

	// Token: 0x0601B2A3 RID: 111267 RVA: 0x00855B29 File Offset: 0x00853D29
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDrawEntityBoxEnabled(bool isEnable)
	{
		CombatDebugDrawController.Instance.IsDrawEntityBoxEnabled = isEnable;
	}

	// Token: 0x0601B2A4 RID: 111268 RVA: 0x00855B36 File Offset: 0x00853D36
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDrawEntityBoxInfoEnabled()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.IsDrawEntityBoxInfoEnabled;
	}

	// Token: 0x0601B2A5 RID: 111269 RVA: 0x00855B48 File Offset: 0x00853D48
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDrawEntityBoxInfoEnabled(bool isEnable)
	{
		CombatDebugDrawController.Instance.IsDrawEntityBoxInfoEnabled = isEnable;
	}

	// Token: 0x0601B2A6 RID: 111270 RVA: 0x00855B55 File Offset: 0x00853D55
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetCombatScriptIndexes()
	{
		return CombatDebugController.Instance.ScriptHelper.CombatScriptIndexes;
	}

	// Token: 0x0601B2A7 RID: 111271 RVA: 0x00855B66 File Offset: 0x00853D66
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string FilterScript(string cmd)
	{
		return CombatDebugController.Instance.FilterCmd(cmd);
	}

	// Token: 0x0601B2A8 RID: 111272 RVA: 0x00855B74 File Offset: 0x00853D74
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsDebugPrintOpened(string moduleName)
	{
		CombatLog.EDebugModule item;
		return Enum.TryParse<CombatLog.EDebugModule>(moduleName, out item) && CombatLog.Instance.DebugCombatInfo.Contains(item);
	}

	// Token: 0x0601B2A9 RID: 111273 RVA: 0x00855BA0 File Offset: 0x00853DA0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetDebugPrintOpened(string moduleName, bool isOpen)
	{
		CombatLog.EDebugModule item;
		if (!Enum.TryParse<CombatLog.EDebugModule>(moduleName, out item))
		{
			return;
		}
		if (isOpen)
		{
			CombatLog.Instance.DebugCombatInfo.Add(item);
			return;
		}
		CombatLog.Instance.DebugCombatInfo.Remove(item);
	}

	// Token: 0x0601B2AA RID: 111274 RVA: 0x00855BDE File Offset: 0x00853DDE
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TryRefreshServerDebugInfo()
	{
		CombatDebugController instance = CombatDebugController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RefreshServerDebugInfo();
	}

	// Token: 0x0601B2AB RID: 111275 RVA: 0x00855BF0 File Offset: 0x00853DF0
	[NullableContext(1)]
	protected static BaseBuffComponent GetBuffComponent(int entityId, int handle)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (((baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handle) : null) != null)
		{
			return baseBuffComponent;
		}
		if (baseBuffComponent != null)
		{
			RoleBuffComponent roleBuffComponent = baseBuffComponent as RoleBuffComponent;
			if (roleBuffComponent != null)
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (((formationBuffComp != null) ? formationBuffComp.GetBuffByHandle(handle) : null) != null)
				{
					return roleBuffComponent.GetFormationBuffComp();
				}
			}
		}
		return null;
	}

	// Token: 0x0601B2AC RID: 111276 RVA: 0x00855C50 File Offset: 0x00853E50
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetServerBuffRemainDuration(int entityId, int handle)
	{
		BaseBuffComponent buffComponent = CombatDebugBlueprintFunctionLibrary.GetBuffComponent(entityId, handle);
		CharacterGasDebugComponent characterGasDebugComponent = (buffComponent != null) ? buffComponent.Entity.GetComponent<CharacterGasDebugComponent>() : null;
		if (characterGasDebugComponent == null)
		{
			return -1f;
		}
		return characterGasDebugComponent.GetServerBuffRemainDuration(handle);
	}

	// Token: 0x0601B2AD RID: 111277 RVA: 0x00855C7A File Offset: 0x00853E7A
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetServerBuffTotalDuration(int entityId, int handle)
	{
		BaseBuffComponent buffComponent = CombatDebugBlueprintFunctionLibrary.GetBuffComponent(entityId, handle);
		CharacterGasDebugComponent characterGasDebugComponent = (buffComponent != null) ? buffComponent.Entity.GetComponent<CharacterGasDebugComponent>() : null;
		if (characterGasDebugComponent == null)
		{
			return -1f;
		}
		return characterGasDebugComponent.GetServerBuffTotalDuration(handle);
	}

	// Token: 0x0601B2AE RID: 111278 RVA: 0x00855CA4 File Offset: 0x00853EA4
	[NullableContext(1)]
	private static ActiveBuffInternal GetDebugBuff(int entityId, int handle)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		IActiveBuff activeBuff = (baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handle) : null;
		if (activeBuff != null)
		{
			return activeBuff as ActiveBuffInternal;
		}
		if (activeBuff == null)
		{
			RoleBuffComponent roleBuffComponent = baseBuffComponent as RoleBuffComponent;
			if (roleBuffComponent != null)
			{
				return roleBuffComponent.GetFormationBuffComp().GetBuffByHandle(handle) as ActiveBuffInternal;
			}
		}
		return null;
	}

	// Token: 0x0601B2AF RID: 111279 RVA: 0x00855D01 File Offset: 0x00853F01
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetBuffRemainDuration(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = CombatDebugBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null)
		{
			return -1f;
		}
		return debugBuff.GetRemainDuration();
	}

	// Token: 0x0601B2B0 RID: 111280 RVA: 0x00855D19 File Offset: 0x00853F19
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetBuffTotalDuration(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = CombatDebugBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null)
		{
			return -1f;
		}
		return debugBuff.Duration;
	}

	// Token: 0x0601B2B1 RID: 111281 RVA: 0x00855D34 File Offset: 0x00853F34
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasServerBuff(int entityId, int handle)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		CharacterGasDebugComponent characterGasDebugComponent = (entity != null) ? entity.GetComponent<CharacterGasDebugComponent>() : null;
		if (characterGasDebugComponent == null)
		{
			return false;
		}
		Entity entity2 = EntitySystem.Instance.Get(entityId);
		RoleBuffComponent roleBuffComponent = (entity2 != null) ? entity2.GetComponent<RoleBuffComponent>() : null;
		CharacterGasDebugComponent characterGasDebugComponent2;
		if (roleBuffComponent == null)
		{
			characterGasDebugComponent2 = null;
		}
		else
		{
			PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
			characterGasDebugComponent2 = ((formationBuffComp != null) ? formationBuffComp.Entity.GetComponent<CharacterGasDebugComponent>() : null);
		}
		CharacterGasDebugComponent characterGasDebugComponent3 = characterGasDebugComponent2;
		return characterGasDebugComponent.HasServerBuff(handle) || (characterGasDebugComponent3 != null && characterGasDebugComponent3.HasServerBuff(handle)) || (!characterGasDebugComponent.HasBuffRequest(handle) && (characterGasDebugComponent3 == null || !characterGasDebugComponent3.HasBuffRequest(handle)));
	}

	// Token: 0x0601B2B2 RID: 111282 RVA: 0x00855DC8 File Offset: 0x00853FC8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAttributeDebugString(int entityId, string filterStr = "")
	{
		HashSet<int> hashSet = new HashSet<int>();
		using (IEnumerator enumerator = Regex.Matches(filterStr, "[0-9]+").GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item;
				if (int.TryParse(enumerator.Current.ToString(), out item))
				{
					hashSet.Add(item);
				}
			}
		}
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		BaseAttributeComponent component2 = EntitySystem.Instance.GetComponent<BaseAttributeComponent>(entityId);
		if (component == null || component2 == null)
		{
			return "";
		}
		HashSet<EAttributeType> hashSet2 = new HashSet<EAttributeType>(CharacterAttributeTypes.attributeIdsWithMax.Values);
		HashSet<EAttributeType> hashSet3 = new HashSet<EAttributeType>(CharacterAttributeTypes.attrsAutoRecoverSpeedMap.Values);
		HashSet<EAttributeType> hashSet4 = new HashSet<EAttributeType>(CharacterAttributeTypes.attrsAutoRecoverMaxMap.Values);
		StringBuilder stringBuilder = new StringBuilder();
		EntityBattleInfoResponse serverDebugInfo = component.ServerDebugInfo;
		RepeatedField<GameplayAttributeData> repeatedField = (serverDebugInfo != null) ? serverDebugInfo.Attributes : null;
		GameplayAttributeData[] array = new GameplayAttributeData[143];
		if (repeatedField != null)
		{
			foreach (GameplayAttributeData gameplayAttributeData in repeatedField)
			{
				array[gameplayAttributeData.AttributeType] = gameplayAttributeData;
			}
		}
		for (int i = 1; i < 143; i++)
		{
			EAttributeType eattributeType = (EAttributeType)i;
			if (!CharacterAttributeTypes.attributeIdsWithMax.ContainsKey(eattributeType) && !hashSet2.Contains(eattributeType) && !CharacterAttributeTypes.attrsAutoRecoverSpeedMap.ContainsKey(eattributeType) && !hashSet3.Contains(eattributeType) && !hashSet4.Contains(eattributeType) && (hashSet.Count <= 0 || hashSet.Contains(i)))
			{
				string value = eattributeType.ToString();
				float baseValue = component2.GetBaseValue(eattributeType);
				float currentValue = component2.GetCurrentValue(eattributeType);
				string value2 = currentValue.ToString("0");
				string value3 = (currentValue == baseValue) ? "" : (((currentValue > baseValue) ? "(+" : "(") + (currentValue - baseValue).ToString("0") + ")");
				GameplayAttributeData gameplayAttributeData2 = array[i];
				int num = (gameplayAttributeData2 != null) ? gameplayAttributeData2.BaseValue : 0;
				int num2 = (gameplayAttributeData2 != null) ? gameplayAttributeData2.CurrentValue : 0;
				string value4 = num2.ToString("0");
				string value5 = (num2 == num) ? "" : (((num2 > num) ? "(+" : "(") + (num2 - num).ToString("0") + ")");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 6, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("#");
				appendInterpolatedStringHandler.AppendFormatted<int>((int)eattributeType);
				appendInterpolatedStringHandler.AppendLiteral(" ");
				appendInterpolatedStringHandler.AppendFormatted(value);
				appendInterpolatedStringHandler.AppendLiteral(" C:");
				appendInterpolatedStringHandler.AppendFormatted(value2);
				appendInterpolatedStringHandler.AppendFormatted(value3);
				appendInterpolatedStringHandler.AppendLiteral(" | S:");
				appendInterpolatedStringHandler.AppendFormatted(value4);
				appendInterpolatedStringHandler.AppendFormatted(value5);
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2B3 RID: 111283 RVA: 0x008560EC File Offset: 0x008542EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetStateAttributeDebugString(int entityId, string filterStr = "")
	{
		HashSet<int> hashSet = new HashSet<int>();
		using (IEnumerator enumerator = Regex.Matches(filterStr, "[0-9]+").GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item;
				if (int.TryParse(enumerator.Current.ToString(), out item))
				{
					hashSet.Add(item);
				}
			}
		}
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		BaseAttributeComponent component2 = EntitySystem.Instance.GetComponent<BaseAttributeComponent>(entityId);
		if (component == null || component2 == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		EntityBattleInfoResponse serverDebugInfo = component.ServerDebugInfo;
		RepeatedField<GameplayAttributeData> repeatedField = (serverDebugInfo != null) ? serverDebugInfo.Attributes : null;
		GameplayAttributeData[] array = new GameplayAttributeData[143];
		if (repeatedField != null)
		{
			foreach (GameplayAttributeData gameplayAttributeData in repeatedField)
			{
				array[gameplayAttributeData.AttributeType] = gameplayAttributeData;
			}
		}
		for (int i = 1; i < 143; i++)
		{
			EAttributeType eattributeType = (EAttributeType)i;
			if ((CharacterAttributeTypes.attributeIdsWithMax.ContainsKey(eattributeType) || CharacterAttributeTypes.attrsAutoRecoverSpeedMap.ContainsKey(eattributeType)) && (hashSet.Count <= 0 || hashSet.Contains(i)))
			{
				string value = eattributeType.ToString();
				string value2 = component2.GetBaseValue(eattributeType).ToString("0");
				GameplayAttributeData gameplayAttributeData2 = array[i];
				string value3 = ((gameplayAttributeData2 != null) ? gameplayAttributeData2.BaseValue : 0).ToString("0");
				if (CharacterAttributeTypes.attrsAutoRecoverSpeedMap.ContainsKey(eattributeType))
				{
					EAttributeType eattributeType2 = CharacterAttributeTypes.attrsAutoRecoverSpeedMap[eattributeType];
					EAttributeType eattributeType3 = CharacterAttributeTypes.attrsAutoRecoverMaxMap[eattributeType];
					string value4 = component2.GetCurrentValue(eattributeType3).ToString("0");
					GameplayAttributeData gameplayAttributeData3 = array[(int)eattributeType3];
					string value5 = ((gameplayAttributeData3 != null) ? gameplayAttributeData3.CurrentValue : 0).ToString("0");
					string value6 = component2.GetCurrentValue(eattributeType2).ToString("0");
					GameplayAttributeData gameplayAttributeData4 = array[(int)eattributeType2];
					string value7 = ((gameplayAttributeData4 != null) ? gameplayAttributeData4.CurrentValue : 0).ToString("0");
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(22, 8, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("#");
					appendInterpolatedStringHandler.AppendFormatted<int>((int)eattributeType);
					appendInterpolatedStringHandler.AppendLiteral(" ");
					appendInterpolatedStringHandler.AppendFormatted(value);
					appendInterpolatedStringHandler.AppendLiteral(" C:");
					appendInterpolatedStringHandler.AppendFormatted(value2);
					appendInterpolatedStringHandler.AppendLiteral("/");
					appendInterpolatedStringHandler.AppendFormatted(value4);
					appendInterpolatedStringHandler.AppendLiteral(" (");
					appendInterpolatedStringHandler.AppendFormatted(value6);
					appendInterpolatedStringHandler.AppendLiteral("/s) | S:");
					appendInterpolatedStringHandler.AppendFormatted(value3);
					appendInterpolatedStringHandler.AppendLiteral("/");
					appendInterpolatedStringHandler.AppendFormatted(value5);
					appendInterpolatedStringHandler.AppendLiteral(" (");
					appendInterpolatedStringHandler.AppendFormatted(value7);
					appendInterpolatedStringHandler.AppendLiteral("/s)");
					stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
				}
				else if (CharacterAttributeTypes.attributeIdsWithMax.ContainsKey(eattributeType))
				{
					EAttributeType eattributeType4 = CharacterAttributeTypes.attributeIdsWithMax[eattributeType];
					string value8 = component2.GetCurrentValue(eattributeType4).ToString("0");
					GameplayAttributeData gameplayAttributeData5 = array[(int)eattributeType4];
					string value9 = ((gameplayAttributeData5 != null) ? gameplayAttributeData5.CurrentValue : 0).ToString("0");
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(12, 6, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("#");
					appendInterpolatedStringHandler.AppendFormatted<int>((int)eattributeType);
					appendInterpolatedStringHandler.AppendLiteral(" ");
					appendInterpolatedStringHandler.AppendFormatted(value);
					appendInterpolatedStringHandler.AppendLiteral(" C:");
					appendInterpolatedStringHandler.AppendFormatted(value2);
					appendInterpolatedStringHandler.AppendLiteral("/");
					appendInterpolatedStringHandler.AppendFormatted(value8);
					appendInterpolatedStringHandler.AppendLiteral(" | S:");
					appendInterpolatedStringHandler.AppendFormatted(value3);
					appendInterpolatedStringHandler.AppendLiteral("/");
					appendInterpolatedStringHandler.AppendFormatted(value9);
					stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
				}
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2B4 RID: 111284 RVA: 0x008564F8 File Offset: 0x008546F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetFormationAttributeDebugString(int entityId, string filterStr = "")
	{
		HashSet<int> hashSet = new HashSet<int>();
		using (IEnumerator enumerator = Regex.Matches(filterStr, "[0-9]+").GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item;
				if (int.TryParse(enumerator.Current.ToString(), out item))
				{
					hashSet.Add(item);
				}
			}
		}
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		EntityBattleInfoResponse serverDebugInfo = component.ServerDebugInfo;
		RepeatedField<FormationAttr> repeatedField = (serverDebugInfo != null) ? serverDebugInfo.FormationAttrs : null;
		Dictionary<int, FormationAttr> dictionary = new Dictionary<int, FormationAttr>();
		if (repeatedField != null)
		{
			foreach (FormationAttr formationAttr in repeatedField)
			{
				dictionary[formationAttr.AttrId] = formationAttr;
			}
		}
		foreach (FormationProperty formationProperty in ConfigFormationPropertyAll.GetConfigList(true))
		{
			if (hashSet.Count <= 0 || hashSet.Contains(formationProperty.Id))
			{
				int id = formationProperty.Id;
				EFormationAttributeId eformationAttributeId = (EFormationAttributeId)id;
				float value = FormationAttributeController.Instance.GetValue(eformationAttributeId);
				float max = FormationAttributeController.Instance.GetMax(eformationAttributeId);
				float speed = FormationAttributeController.Instance.GetSpeed(eformationAttributeId);
				FormationAttr formationAttr2;
				dictionary.TryGetValue((int)eformationAttributeId, out formationAttr2);
				string value2 = ((formationAttr2 != null) ? formationAttr2.CurrentValue.ToString("0") : null) ?? "???";
				string value3 = ((formationAttr2 != null) ? formationAttr2.MaxValue.ToString("0") : null) ?? "???";
				string value4 = ((formationAttr2 != null) ? formationAttr2.Ratio.ToString("0") : null) ?? "???";
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(21, 7, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("#");
				appendInterpolatedStringHandler.AppendFormatted<int>(id);
				appendInterpolatedStringHandler.AppendLiteral(" C:");
				appendInterpolatedStringHandler.AppendFormatted(value.ToString("0"));
				appendInterpolatedStringHandler.AppendLiteral("/");
				appendInterpolatedStringHandler.AppendFormatted(max.ToString("0"));
				appendInterpolatedStringHandler.AppendLiteral(" (");
				appendInterpolatedStringHandler.AppendFormatted(speed.ToString("0"));
				appendInterpolatedStringHandler.AppendLiteral("/s)");
				appendInterpolatedStringHandler.AppendLiteral(" | S:");
				appendInterpolatedStringHandler.AppendFormatted(value2);
				appendInterpolatedStringHandler.AppendLiteral("/");
				appendInterpolatedStringHandler.AppendFormatted(value3);
				appendInterpolatedStringHandler.AppendLiteral(" (");
				appendInterpolatedStringHandler.AppendFormatted(value4);
				appendInterpolatedStringHandler.AppendLiteral("/s)");
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2B5 RID: 111285 RVA: 0x00856810 File Offset: 0x00854A10
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetSquadAttributeDebugString(int entityId, string filterStr = "")
	{
		HashSet<int> hashSet = new HashSet<int>();
		using (IEnumerator enumerator = Regex.Matches(filterStr, "[0-9]+").GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item;
				if (int.TryParse(enumerator.Current.ToString(), out item))
				{
					hashSet.Add(item);
				}
			}
		}
		CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		int playerId = (component != null) ? component.GetPlayerId() : 0;
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		SquadPropComponent squadPropComponent = (playerEntity != null) ? playerEntity.GetComponent<SquadPropComponent>() : null;
		if (squadPropComponent == null)
		{
			return "";
		}
		HashSet<ESquadAttributeType> hashSet2 = new HashSet<ESquadAttributeType>(SquadAttributeTypes.squadAttrIdsWithMax.Values);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < 3; i++)
		{
			ESquadAttributeType esquadAttributeType = (ESquadAttributeType)i;
			if (!SquadAttributeTypes.squadStateAttributeIds.Contains(esquadAttributeType) && !hashSet2.Contains(esquadAttributeType) && !SquadAttributeTypes.squadAttrIdsWithMax.ContainsKey(esquadAttributeType) && (hashSet.Count <= 0 || hashSet.Contains(i)))
			{
				string text;
				if (!Enum.IsDefined(typeof(ESquadAttributeType), esquadAttributeType))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text = esquadAttributeType.ToString();
				}
				string value = text;
				float baseValue = squadPropComponent.GetBaseValue(esquadAttributeType);
				float currentValue = squadPropComponent.GetCurrentValue(esquadAttributeType);
				string value2 = currentValue.ToString("0");
				string value3 = (currentValue == baseValue) ? "" : (((currentValue > baseValue) ? "(+" : "(") + (currentValue - baseValue).ToString("0") + ")");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 4, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("#");
				appendInterpolatedStringHandler.AppendFormatted<int>((int)esquadAttributeType);
				appendInterpolatedStringHandler.AppendLiteral(" ");
				appendInterpolatedStringHandler.AppendFormatted(value);
				appendInterpolatedStringHandler.AppendLiteral(" C:");
				appendInterpolatedStringHandler.AppendFormatted(value2);
				appendInterpolatedStringHandler.AppendFormatted(value3);
				appendInterpolatedStringHandler.AppendLiteral(" | S:");
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2B6 RID: 111286 RVA: 0x00856A5C File Offset: 0x00854C5C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetStateSquadAttributeDebugString(int entityId, string filterStr = "")
	{
		HashSet<int> hashSet = new HashSet<int>();
		using (IEnumerator enumerator = Regex.Matches(filterStr, "[0-9]+").GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item;
				if (int.TryParse(enumerator.Current.ToString(), out item))
				{
					hashSet.Add(item);
				}
			}
		}
		CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		int playerId = (component != null) ? component.GetPlayerId() : 0;
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		SquadPropComponent squadPropComponent = (playerEntity != null) ? playerEntity.GetComponent<SquadPropComponent>() : null;
		if (squadPropComponent == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < 3; i++)
		{
			ESquadAttributeType esquadAttributeType = (ESquadAttributeType)i;
			if (SquadAttributeTypes.squadStateAttributeIds.Contains(esquadAttributeType) && (hashSet.Count <= 0 || hashSet.Contains(i)))
			{
				string text;
				if (!Enum.IsDefined(typeof(ESquadAttributeType), esquadAttributeType))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text = esquadAttributeType.ToString();
				}
				string value = text;
				string value2 = squadPropComponent.GetCurrentValue(esquadAttributeType).ToString("0");
				ESquadAttributeType attrId;
				string value3 = SquadAttributeTypes.squadAttrIdsWithMax.TryGetValue(esquadAttributeType, out attrId) ? squadPropComponent.GetCurrentValue(attrId).ToString("0") : "???";
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 4, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("#");
				appendInterpolatedStringHandler.AppendFormatted<int>((int)esquadAttributeType);
				appendInterpolatedStringHandler.AppendLiteral(" ");
				appendInterpolatedStringHandler.AppendFormatted(value);
				appendInterpolatedStringHandler.AppendLiteral(" C:");
				appendInterpolatedStringHandler.AppendFormatted(value2);
				appendInterpolatedStringHandler.AppendLiteral("/");
				appendInterpolatedStringHandler.AppendFormatted(value3);
				appendInterpolatedStringHandler.AppendLiteral(" | S:");
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2B7 RID: 111287 RVA: 0x00856C6C File Offset: 0x00854E6C
	[NullableContext(1)]
	protected static Dictionary<string, string> ServerSkillMap(string serverPassiveSkillInfo)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (string text in serverPassiveSkillInfo.Split(new string[]
		{
			"技能:"
		}, StringSplitOptions.None))
		{
			if (!string.IsNullOrEmpty(text))
			{
				Match match = Regex.Match(text, "(?<skillId>\\d+)");
				if (match.Success && match.Groups["skillId"] != null)
				{
					string value = match.Groups["skillId"].Value;
					dictionary[value] = "技能:" + text;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0601B2B8 RID: 111288 RVA: 0x00856D04 File Offset: 0x00854F04
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<long> ExtractInt64ArrayFromString(string content)
	{
		TArray<long> tarray = new TArray<long>();
		if (string.IsNullOrEmpty(content))
		{
			return tarray;
		}
		foreach (object obj in Regex.Matches(content, "[-+]?\\d+"))
		{
			string value = ((Match)obj).Value;
			if (!string.IsNullOrEmpty(value))
			{
				tarray.Add(long.Parse(value));
			}
		}
		return tarray;
	}

	// Token: 0x0601B2B9 RID: 111289 RVA: 0x00856D88 File Offset: 0x00854F88
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<string> ExtractTagNameArrayFromString(string content)
	{
		TArray<string> tarray = new TArray<string>();
		if (string.IsNullOrEmpty(content))
		{
			return tarray;
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (object obj in new Regex("[A-Za-z_\\u3400-\\u9fff][A-Za-z0-9_\\u3400-\\u9fff]*(?:\\.[A-Za-z0-9_\\u3400-\\u9fff]+)+").Matches(content))
		{
			string value = ((Match)obj).Value;
			string text = (value != null) ? value.Trim() : null;
			if (!string.IsNullOrEmpty(text))
			{
				hashSet.Add(text);
			}
		}
		foreach (string value2 in hashSet)
		{
			tarray.Add(value2);
		}
		return tarray;
	}

	// Token: 0x0601B2BA RID: 111290 RVA: 0x00856E60 File Offset: 0x00855060
	[NullableContext(1)]
	protected static string GetPassiveCdString(PassiveSkillCdInfo cdInfo)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<int, double> keyValuePair in cdInfo.SkillCdFinishStampMap)
		{
			int key = keyValuePair.Key;
			double curRemainingCd = cdInfo.GetCurRemainingCd(key);
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("entityId: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(key);
			appendInterpolatedStringHandler.AppendLiteral(" CD:");
			appendInterpolatedStringHandler.AppendFormatted(curRemainingCd.ToString("0.00"));
			stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601B2BB RID: 111291 RVA: 0x00856F18 File Offset: 0x00855118
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetPassiveDebugString(int entityId, string filterStr = "")
	{
		List<string> list = new List<string>();
		foreach (object obj in Regex.Matches(filterStr, "[0-9]+"))
		{
			list.Add(obj.ToString());
		}
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		CharacterTriggerComponent component2 = EntitySystem.Instance.GetComponent<CharacterTriggerComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (component.GetAllPassiveSkills().Length != 0)
		{
			BaseSkillCdComponent component3 = EntitySystem.Instance.GetComponent<BaseSkillCdComponent>(entityId);
			stringBuilder.AppendLine("----- 客户端被动技能 -----");
			foreach (PassiveSkillData passiveSkillData in component.GetAllPassiveSkills())
			{
				bool flag = false;
				foreach (string value in list)
				{
					if (passiveSkillData.SkillId.ToString().StartsWith(value))
					{
						flag = true;
						break;
					}
				}
				if (list.Count <= 0 || flag)
				{
					Trigger trigger = (component2 != null) ? component2.GetTrigger(passiveSkillData.TriggerHandle) : null;
					PassiveSkill? config = ConfigPassiveSkillById.GetConfig(passiveSkillData.SkillId, true);
					PassiveSkillCdInfo passiveSkillCdInfo = (component3 != null) ? component3.GetPassiveSkillCdInfo(passiveSkillData.SkillId) : null;
					string value2 = (passiveSkillCdInfo != null) ? CombatDebugBlueprintFunctionLibrary.GetPassiveCdString(passiveSkillCdInfo) : "【无CD组件】";
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("技能: ");
					appendInterpolatedStringHandler.AppendFormatted<long>(passiveSkillData.SkillId);
					appendInterpolatedStringHandler.AppendLiteral(" handle: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(passiveSkillData.TriggerHandle);
					stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder.Append(value2);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("说明: ");
					appendInterpolatedStringHandler.AppendFormatted((config != null) ? config.GetValueOrDefault().SkillDesc : null);
					stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(7, 2, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("触发器类型: ");
					appendInterpolatedStringHandler.AppendFormatted((config != null) ? config.GetValueOrDefault().TriggerType : null);
					appendInterpolatedStringHandler.AppendFormatted(Enum.IsDefined(typeof(ETriggerEvent), (config != null) ? config.GetValueOrDefault().TriggerType : null) ? "" : "(非法类型)");
					stringBuilder5.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("触发时机: ");
					appendInterpolatedStringHandler.AppendFormatted((trigger != null) ? trigger.GetDebugTriggerType() : null);
					stringBuilder6.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("条件公式: ");
					appendInterpolatedStringHandler.AppendFormatted((trigger != null) ? trigger.GetDebugFormulaString() : null);
					stringBuilder7.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("执行类型: ");
					appendInterpolatedStringHandler.AppendFormatted(((EExecuteType)((config != null) ? new int?(config.GetValueOrDefault().ExecuteType) : null).Value).ToString());
					stringBuilder8.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder.AppendLine("触发行为:");
					foreach (SkillActionData skillActionData in passiveSkillData.Actions)
					{
						switch (skillActionData.Action)
						{
						case ESkillAction.AddBullet:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder9 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    添加子弹 ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join('、', skillActionData.BulletRowNames));
							stringBuilder9.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.RemoveBullet:
						{
							List<string> list2 = new List<string>();
							int num = 0;
							foreach (string str in skillActionData.BulletRowNames)
							{
								list2.Add(str + ((skillActionData.SummonChild != null && skillActionData.SummonChild.Length > num && skillActionData.SummonChild[num]) ? "创建子子弹" : "不创建子子弹"));
								num++;
							}
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder10 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    移除子弹 ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', list2));
							stringBuilder10.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.AddBuff:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder11 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    添加Buff ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<long>('、', skillActionData.BuffId));
							stringBuilder11.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.RemoveBuff:
						{
							List<string> list3 = new List<string>();
							int num2 = 0;
							foreach (long value3 in skillActionData.BuffId)
							{
								List<string> list4 = list3;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
								defaultInterpolatedStringHandler.AppendFormatted<long>(value3);
								string value4;
								if (skillActionData.StackCount == null || skillActionData.StackCount.Length <= num2 || skillActionData.StackCount[num2] <= 0)
								{
									value4 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(移除");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(skillActionData.StackCount[num2]);
									defaultInterpolatedStringHandler2.AppendLiteral("层)");
									value4 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value4);
								list4.Add(defaultInterpolatedStringHandler.ToStringAndClear());
								num2++;
							}
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder12 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    移除Buff ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', list3));
							stringBuilder12.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.StartSkill:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder13 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    触发主动技能 ");
							appendInterpolatedStringHandler.AppendFormatted<int>(skillActionData.SkillId);
							stringBuilder13.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.LockOn:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder14 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 5, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    锁定目标 ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(skillActionData.IsHardLock);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<int>(skillActionData.LockOnConfigId);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<ESkillTargetPriority>(skillActionData.SkillTargetPriority);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(skillActionData.ShowTarget);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(skillActionData.GlobalTarget);
							stringBuilder14.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.Customize:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder15 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    自定义行为 ");
							Formula formula = skillActionData.Formula;
							appendInterpolatedStringHandler.AppendFormatted((formula != null) ? formula.FormulaStr : null);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							stringBuilder15.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.ReduceSkillCd:
						{
							List<string> list5 = new List<string>();
							int num3 = 0;
							foreach (long value5 in skillActionData.ReduceSkillId)
							{
								List<string> list6 = list5;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 4);
								defaultInterpolatedStringHandler.AppendFormatted<long>(value5);
								defaultInterpolatedStringHandler.AppendFormatted((skillActionData.CdResetType != null && skillActionData.CdResetType.Length > num3) ? skillActionData.CdResetType[num3].ToString() : "");
								string value6;
								if (skillActionData.DecreaseRatio == null || skillActionData.DecreaseRatio.Length <= num3)
								{
									value6 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(");
									defaultInterpolatedStringHandler2.AppendFormatted<float>(skillActionData.DecreaseRatio[num3]);
									defaultInterpolatedStringHandler2.AppendLiteral(")");
									value6 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value6);
								string value7;
								if (skillActionData.DecreaseMagnitude == null || skillActionData.DecreaseMagnitude.Length <= num3)
								{
									value7 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(");
									defaultInterpolatedStringHandler2.AppendFormatted<float>(skillActionData.DecreaseMagnitude[num3]);
									defaultInterpolatedStringHandler2.AppendLiteral(")");
									value7 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value7);
								list6.Add(defaultInterpolatedStringHandler.ToStringAndClear());
								num3++;
							}
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder16 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    减少技能CD ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', list5));
							stringBuilder16.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						default:
							stringBuilder.AppendLine("    未知行为");
							break;
						}
					}
					string text = ((trigger != null) ? trigger.GetLastFormulaResult() : null) ?? "";
					if (!string.IsNullOrEmpty(text))
					{
						stringBuilder.AppendLine("最后触发结果:");
						string[] array2 = text.Trim().Split('\n', StringSplitOptions.None);
						for (int k = 0; k < array2.Length; k++)
						{
							array2[k] = "    " + array2[k];
						}
						stringBuilder.AppendLine(string.Join("\n", array2));
					}
					stringBuilder.AppendLine();
					stringBuilder.AppendLine();
				}
			}
		}
		CharacterGasDebugComponent component4 = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		string text2;
		if (component4 == null)
		{
			text2 = null;
		}
		else
		{
			EntityBattleInfoResponse serverDebugInfo = component4.ServerDebugInfo;
			text2 = ((serverDebugInfo != null) ? serverDebugInfo.EntityPassiveSkillInfo : null);
		}
		string text3 = text2;
		if (!string.IsNullOrEmpty(text3))
		{
			if (list.Count == 0)
			{
				stringBuilder.AppendLine("----- 服务端被动技能 -----");
				stringBuilder.Append(text3);
			}
			else
			{
				foreach (KeyValuePair<string, string> keyValuePair in CombatDebugBlueprintFunctionLibrary.ServerSkillMap(text3))
				{
					string key = keyValuePair.Key;
					string value8 = keyValuePair.Value;
					bool flag2 = false;
					for (int l = 0; l < list.Count; l++)
					{
						if (key.StartsWith(list[l]))
						{
							flag2 = true;
							break;
						}
					}
					if (flag2)
					{
						stringBuilder.Append(value8);
					}
				}
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2BC RID: 111292 RVA: 0x008579C4 File Offset: 0x00855BC4
	[NullableContext(1)]
	protected static bool IsRegexFuzzyMatch(string str, string pattern)
	{
		string pattern2 = string.Join<char>(".*", pattern.ToCharArray());
		return Regex.IsMatch(str, pattern2);
	}

	// Token: 0x0601B2BD RID: 111293 RVA: 0x008579EC File Offset: 0x00855BEC
	[NullableContext(1)]
	private static bool IsCueFilterMatched(long cueId, List<string> filters)
	{
		if (filters.Count == 0)
		{
			return true;
		}
		string text = cueId.ToString();
		for (int i = 0; i < filters.Count; i++)
		{
			if (text.Contains(filters[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601B2BE RID: 111294 RVA: 0x00857A30 File Offset: 0x00855C30
	[NullableContext(1)]
	private static bool IsTagFilterMatched(string tagName, List<string> filters)
	{
		if (filters.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < filters.Count; i++)
		{
			if (CombatDebugBlueprintFunctionLibrary.IsRegexFuzzyMatch(tagName, filters[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601B2BF RID: 111295 RVA: 0x00857A6C File Offset: 0x00855C6C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetTagsDebugString(int entityId, string filterStr = "")
	{
		string[] array = filterStr.Split(new char[]
		{
			',',
			'，'
		}, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>(array.Length);
		foreach (string text in array)
		{
			list.Add(text.Trim());
		}
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		TagContainer tagContainer = (component != null) ? component.TagContainer : null;
		CharacterGasDebugComponent component2 = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component2 == null || tagContainer == null)
		{
			return "";
		}
		RepeatedField<EntityBattleTagInfo> repeatedField;
		if (component2 == null)
		{
			repeatedField = null;
		}
		else
		{
			EntityBattleInfoResponse serverDebugInfo = component2.ServerDebugInfo;
			repeatedField = ((serverDebugInfo != null) ? serverDebugInfo.EntityBattleTagInfo : null);
		}
		RepeatedField<EntityBattleTagInfo> repeatedField2 = repeatedField;
		RepeatedField<EntityBattleTagInfo> repeatedField3;
		if (component2 == null)
		{
			repeatedField3 = null;
		}
		else
		{
			EntityBattleInfoResponse serverDebugInfo2 = component2.ServerDebugInfo;
			repeatedField3 = ((serverDebugInfo2 != null) ? serverDebugInfo2.PlayerTagInfos : null);
		}
		RepeatedField<EntityBattleTagInfo> repeatedField4 = repeatedField3;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<string, Dictionary<int, int>> dictionary2 = new Dictionary<string, Dictionary<int, int>>
		{
			{
				"实体",
				new Dictionary<int, int>()
			},
			{
				"编队",
				new Dictionary<int, int>()
			}
		};
		if (repeatedField2 != null)
		{
			Dictionary<int, int> dictionary3 = dictionary2["实体"];
			foreach (EntityBattleTagInfo entityBattleTagInfo in repeatedField2)
			{
				if (dictionary.ContainsKey(entityBattleTagInfo.TagId))
				{
					Dictionary<int, int> dictionary4 = dictionary;
					int i = entityBattleTagInfo.TagId;
					dictionary4[i] += entityBattleTagInfo.Count;
				}
				else
				{
					dictionary[entityBattleTagInfo.TagId] = entityBattleTagInfo.Count;
				}
				dictionary3[entityBattleTagInfo.TagId] = entityBattleTagInfo.Count;
			}
		}
		if (repeatedField4 != null)
		{
			Dictionary<int, int> dictionary5 = dictionary2["编队"];
			foreach (EntityBattleTagInfo entityBattleTagInfo2 in repeatedField4)
			{
				if (dictionary.ContainsKey(entityBattleTagInfo2.TagId))
				{
					Dictionary<int, int> dictionary4 = dictionary;
					int i = entityBattleTagInfo2.TagId;
					dictionary4[i] += entityBattleTagInfo2.Count;
				}
				else
				{
					dictionary[entityBattleTagInfo2.TagId] = entityBattleTagInfo2.Count;
				}
				dictionary5[entityBattleTagInfo2.TagId] = entityBattleTagInfo2.Count;
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("【客户端】");
		foreach (int tagId in tagContainer.GetAllExactTags())
		{
			string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
			if (string.IsNullOrEmpty(nameByTagId) || CombatDebugBlueprintFunctionLibrary.IsTagFilterMatched(nameByTagId, list))
			{
				int exactTagCount = tagContainer.GetExactTagCount(tagId);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(tagId));
				defaultInterpolatedStringHandler.AppendLiteral(" x ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(exactTagCount);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				StringBuilder stringBuilder2 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (ETagChannel etagChannel in tagContainer.GetAllChannels())
				{
					int rawTagCount = tagContainer.GetRawTagCount(etagChannel, tagId);
					if (rawTagCount > 0)
					{
						StringBuilder stringBuilder3 = stringBuilder2;
						StringBuilder stringBuilder4 = stringBuilder3;
						StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder3);
						appendInterpolatedStringHandler.AppendFormatted(TagContainer.channelDebugName[etagChannel]);
						appendInterpolatedStringHandler.AppendLiteral(" x ");
						appendInterpolatedStringHandler.AppendFormatted<int>(rawTagCount);
						appendInterpolatedStringHandler.AppendLiteral(" ");
						stringBuilder4.Append(ref appendInterpolatedStringHandler);
					}
				}
				stringBuilder.AppendLine(stringBuilder2.ToString().TrimEnd() + ")");
			}
		}
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("【服务端】");
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			string nameByTagId2 = GameplayTagUtils.GetNameByTagId(key);
			if (string.IsNullOrEmpty(nameByTagId2) || CombatDebugBlueprintFunctionLibrary.IsTagFilterMatched(nameByTagId2, list))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(key));
				defaultInterpolatedStringHandler.AppendLiteral(" x ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				StringBuilder stringBuilder5 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (KeyValuePair<string, Dictionary<int, int>> keyValuePair2 in dictionary2)
				{
					string key2 = keyValuePair2.Key;
					int num;
					if (keyValuePair2.Value.TryGetValue(key, out num) && num > 0)
					{
						StringBuilder stringBuilder3 = stringBuilder5;
						StringBuilder stringBuilder6 = stringBuilder3;
						StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder3);
						appendInterpolatedStringHandler.AppendFormatted(key2);
						appendInterpolatedStringHandler.AppendLiteral(" x ");
						appendInterpolatedStringHandler.AppendFormatted<int>(num);
						appendInterpolatedStringHandler.AppendLiteral(" ");
						stringBuilder6.Append(ref appendInterpolatedStringHandler);
					}
				}
				stringBuilder.AppendLine(stringBuilder5.ToString().TrimEnd() + ")");
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601B2C0 RID: 111296 RVA: 0x00858010 File Offset: 0x00856210
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetCueDebugString(int entityId, string filterStr = "")
	{
		BaseGameplayCueComponent component = EntitySystem.Instance.GetComponent<BaseGameplayCueComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("实体Cue:");
		List<string> list = new List<string>();
		foreach (object obj in Regex.Matches(filterStr, "[0-9]+"))
		{
			list.Add(obj.ToString());
		}
		foreach (GameplayCueBase gameplayCueBase in component.GetAllCurrentCueRef())
		{
			if (CombatDebugBlueprintFunctionLibrary.IsCueFilterMatched(gameplayCueBase.CueConfig.Id, list))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(42, 4, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("CueId: ");
				appendInterpolatedStringHandler.AppendFormatted<long>(gameplayCueBase.CueConfig.Id);
				appendInterpolatedStringHandler.AppendLiteral(" CueHandleId: [");
				appendInterpolatedStringHandler.AppendFormatted(string.Join<long>(", ", gameplayCueBase.CueHandleIds));
				appendInterpolatedStringHandler.AppendLiteral("] CueType: ");
				appendInterpolatedStringHandler.AppendFormatted<int>(gameplayCueBase.CueConfig.CueType);
				appendInterpolatedStringHandler.AppendLiteral(" BuffId: ");
				appendInterpolatedStringHandler.AppendFormatted<long?>(gameplayCueBase.BuffId);
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		bool flag = false;
		using (List<EntityHandle>.Enumerator enumerator3 = SceneTeamModel.Instance.GetTeamEntities(false).GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				if (enumerator3.Current.Id == entityId)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			return stringBuilder.ToString();
		}
		stringBuilder.AppendLine("\n编队Cue:");
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		PlayerGameplayCueComponent playerGameplayCueComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerGameplayCueComponent>() : null;
		if (playerGameplayCueComponent == null)
		{
			return stringBuilder.ToString();
		}
		foreach (GameplayCueBase gameplayCueBase2 in playerGameplayCueComponent.GetAllCurrentCueRef())
		{
			if (CombatDebugBlueprintFunctionLibrary.IsCueFilterMatched(gameplayCueBase2.CueConfig.Id, list))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(42, 4, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("CueId: ");
				appendInterpolatedStringHandler.AppendFormatted<long>(gameplayCueBase2.CueConfig.Id);
				appendInterpolatedStringHandler.AppendLiteral(" CueHandleId: [");
				appendInterpolatedStringHandler.AppendFormatted(string.Join<long>(", ", gameplayCueBase2.CueHandleIds));
				appendInterpolatedStringHandler.AppendLiteral("] CueType: ");
				appendInterpolatedStringHandler.AppendFormatted<int>(gameplayCueBase2.CueConfig.CueType);
				appendInterpolatedStringHandler.AppendLiteral(" BuffId: ");
				appendInterpolatedStringHandler.AppendFormatted<long?>(gameplayCueBase2.BuffId);
				stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601B2C1 RID: 111297 RVA: 0x00858318 File Offset: 0x00856518
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UDataTable LoadDataTable(string assetPath)
	{
		return null;
	}

	// Token: 0x0601B2C2 RID: 111298 RVA: 0x0085831C File Offset: 0x0085651C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void GetDebugStateMachine(int entityId, ref TArray<FText> output)
	{
		CharacterStateMachineNewComponent component = EntitySystem.Instance.GetComponent<CharacterStateMachineNewComponent>(entityId);
		AiStateMachineGroup aiStateMachineGroup = (component != null) ? component.StateMachineGroup : null;
		if (aiStateMachineGroup == null)
		{
			output.Add("无角色状态机组件");
			output.Add("");
			return;
		}
		aiStateMachineGroup.RequestServerDebugInfo();
		string[] array = aiStateMachineGroup.ToString(false, false);
		if (array != null)
		{
			foreach (string @string in array)
			{
				output.Add(@string);
			}
		}
	}

	// Token: 0x0601B2C3 RID: 111299 RVA: 0x0085839C File Offset: 0x0085659C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetSkillDebugString(int entityId)
	{
		StringBuilder stringBuilder = new StringBuilder();
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component == null)
		{
			return stringBuilder.ToString();
		}
		CreatureDataComponent component2 = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		bool flag = component2 != null && component2.IsVehicle();
		CharacterSkillCdComponent characterSkillCdComponent = flag ? null : EntitySystem.Instance.GetComponent<CharacterSkillCdComponent>(entityId);
		bool flag2 = false;
		foreach (global::Skill skill in component.GetAllActivatedSkill())
		{
			flag2 = true;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(27, 5, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("#");
			appendInterpolatedStringHandler.AppendFormatted<int>(skill.SkillId);
			appendInterpolatedStringHandler.AppendLiteral(" ");
			appendInterpolatedStringHandler.AppendFormatted(skill.SkillName);
			appendInterpolatedStringHandler.AppendLiteral(" | 技能组: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(skill.SkillInfo.GroupId);
			appendInterpolatedStringHandler.AppendLiteral(" | 打断等级: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(skill.InterruptLevel);
			appendInterpolatedStringHandler.AppendLiteral(" | CD: ");
			string text;
			if (characterSkillCdComponent == null)
			{
				text = null;
			}
			else
			{
				GroupSkillCdInfo groupSkillCdInfo = characterSkillCdComponent.GetGroupSkillCdInfo(skill.SkillId);
				text = ((groupSkillCdInfo != null) ? groupSkillCdInfo.CurRemainingCd.ToString("0.00") : null);
			}
			appendInterpolatedStringHandler.AppendFormatted(text ?? "0");
			appendInterpolatedStringHandler.AppendLiteral("s");
			stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
		}
		if (flag2)
		{
			stringBuilder.AppendLine();
		}
		CharacterAnimationComponent characterAnimationComponent = flag ? null : EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		VehicleAnimationComponent vehicleAnimationComponent = flag ? EntitySystem.Instance.GetComponent<VehicleAnimationComponent>(entityId) : null;
		UAnimInstance uanimInstance = ((characterAnimationComponent != null) ? characterAnimationComponent.MainAnimInstance : null) ?? ((vehicleAnimationComponent != null) ? vehicleAnimationComponent.MainAnimInstance : null);
		UAnimMontage uanimMontage = (uanimInstance != null) ? uanimInstance.GetCurrentActiveMontage() : null;
		if (uanimInstance != null && uanimInstance.IsAnyMontagePlaying() && uanimMontage != null)
		{
			string name = uanimMontage.GetName();
			string value = uanimInstance.Montage_GetCurrentSection(uanimMontage).ToString();
			float value2 = uanimInstance.Montage_GetPosition(uanimMontage);
			float playLength = uanimMontage.GetPlayLength();
			float value3 = uanimInstance.Montage_GetPlayRate(uanimMontage);
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(40, 5, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Montage: ");
			appendInterpolatedStringHandler.AppendFormatted(name);
			appendInterpolatedStringHandler.AppendLiteral(" | Section: ");
			appendInterpolatedStringHandler.AppendFormatted(value);
			appendInterpolatedStringHandler.AppendLiteral(" | Time: ");
			appendInterpolatedStringHandler.AppendFormatted<float>(value2, "0.00");
			appendInterpolatedStringHandler.AppendLiteral("/");
			appendInterpolatedStringHandler.AppendFormatted<float>(playLength, "0.00");
			appendInterpolatedStringHandler.AppendLiteral(" | Rate: ");
			appendInterpolatedStringHandler.AppendFormatted<float>(value3, "0.00");
			stringBuilder4.Append(ref appendInterpolatedStringHandler);
		}
		else
		{
			string value4 = (uanimInstance != null) ? uanimInstance.GetMainAnimsDebugText() : null;
			stringBuilder.Append(value4);
		}
		TArray<FAnimNotifyEvent> tarray = (uanimInstance != null) ? uanimInstance.ActiveAnimNotifyState : null;
		if (tarray != null && tarray.Num() > 0)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			for (int i = 0; i < tarray.Num(); i++)
			{
				UKuroAnimNotifyState ukuroAnimNotifyState = tarray.Get(i).NotifyStateClass as UKuroAnimNotifyState;
				if (ukuroAnimNotifyState != null)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("exportIndex:");
					appendInterpolatedStringHandler.AppendFormatted<int>(ukuroAnimNotifyState.exportIndex);
					appendInterpolatedStringHandler.AppendLiteral("--");
					appendInterpolatedStringHandler.AppendFormatted(ukuroAnimNotifyState.GetNotifyName());
					stringBuilder5.AppendLine(ref appendInterpolatedStringHandler);
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601B2C4 RID: 111300 RVA: 0x00858734 File Offset: 0x00856934
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetSkillLogString(int entityId, string filterStr = "")
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		return component.GetSkillLogString(filterStr);
	}

	// Token: 0x0601B2C5 RID: 111301 RVA: 0x00858760 File Offset: 0x00856960
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearSkillLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ClearSkillLogString();
		}
	}

	// Token: 0x0601B2C6 RID: 111302 RVA: 0x00858784 File Offset: 0x00856984
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetSkillBehaviorLogString(int entityId, string filterStr = "")
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		return component.GetSkillBehaviorLogString(filterStr);
	}

	// Token: 0x0601B2C7 RID: 111303 RVA: 0x008587B0 File Offset: 0x008569B0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearSkillBehaviorLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ClearSkillBehaviorLogString();
		}
	}

	// Token: 0x0601B2C8 RID: 111304 RVA: 0x008587D4 File Offset: 0x008569D4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetBulletDebugString(int entityId)
	{
		BulletModel instance = BulletModel.Instance;
		IReadOnlyCollection<BulletEntity> readOnlyCollection = (instance != null) ? instance.GetBulletSetByAttacker(entityId) : null;
		if (readOnlyCollection == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (BulletEntity bulletEntity in readOnlyCollection)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(32, 4, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("#RowName:");
			appendInterpolatedStringHandler.AppendFormatted(bulletInfo.BulletRowName);
			appendInterpolatedStringHandler.AppendLiteral(", EntityId:");
			appendInterpolatedStringHandler.AppendFormatted<int>(bulletEntity.Id);
			appendInterpolatedStringHandler.AppendLiteral(", LiveTime:");
			appendInterpolatedStringHandler.AppendFormatted<float>(bulletInfo.LiveTime);
			appendInterpolatedStringHandler.AppendLiteral("/");
			appendInterpolatedStringHandler.AppendFormatted<float>(bulletInfo.Duration);
			stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601B2C9 RID: 111305 RVA: 0x008588CC File Offset: 0x00856ACC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetBulletLogString(int entityId, string filterStr = "")
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return "";
		}
		return component.GetBulletLogString(filterStr);
	}

	// Token: 0x0601B2CA RID: 111306 RVA: 0x00858900 File Offset: 0x00856B00
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearBulletLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ClearBulletLogString();
		}
	}

	// Token: 0x0601B2CB RID: 111307 RVA: 0x0085892C File Offset: 0x00856B2C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEntityDebugMove(int entityId, bool enable)
	{
		ActorDebugMovementComponent component = EntitySystem.Instance.GetComponent<ActorDebugMovementComponent>(entityId);
		if (component != null)
		{
			component.SetDebug(enable);
		}
	}

	// Token: 0x0601B2CC RID: 111308 RVA: 0x0085894F File Offset: 0x00856B4F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CombatDebugBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C");
		}
		return CombatDebugBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601B2CD RID: 111309 RVA: 0x00858974 File Offset: 0x00856B74
	public CombatDebugBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B2CE RID: 111310 RVA: 0x0085899C File Offset: 0x00856B9C
	[NullableContext(1)]
	public CombatDebugBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B2CF RID: 111311 RVA: 0x008589CF File Offset: 0x00856BCF
	protected CombatDebugBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B2D0 RID: 111312 RVA: 0x008589D8 File Offset: 0x00856BD8
	protected unsafe static void __CPPCALL_AddPassiveSkillForDebug_Implementation(CombatDebugBlueprintFunctionLibrary.__AddPassiveSkillForDebug_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.AddPassiveSkillForDebug(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x0601B2D1 RID: 111313 RVA: 0x008589EB File Offset: 0x00856BEB
	protected unsafe static void __CPPCALL_RemovePassiveSkillForDebug_Implementation(CombatDebugBlueprintFunctionLibrary.__RemovePassiveSkillForDebug_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.RemovePassiveSkillForDebug(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x0601B2D2 RID: 111314 RVA: 0x008589FE File Offset: 0x00856BFE
	protected unsafe static void __CPPCALL_GetDebugMonsterMovePath_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugMonsterMovePath_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetDebugMonsterMovePath();
	}

	// Token: 0x0601B2D3 RID: 111315 RVA: 0x00858A0B File Offset: 0x00856C0B
	protected unsafe static void __CPPCALL_SetDebugMonsterMovePath_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugMonsterMovePath_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugMonsterMovePath(__Params->value);
	}

	// Token: 0x0601B2D4 RID: 111316 RVA: 0x00858A18 File Offset: 0x00856C18
	protected unsafe static void __CPPCALL_GetDebugMonsterControl_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugMonsterControl_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetDebugMonsterControl();
	}

	// Token: 0x0601B2D5 RID: 111317 RVA: 0x00858A25 File Offset: 0x00856C25
	protected unsafe static void __CPPCALL_SetDebugMonsterControl_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugMonsterControl_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugMonsterControl(__Params->value);
	}

	// Token: 0x0601B2D6 RID: 111318 RVA: 0x00858A32 File Offset: 0x00856C32
	protected unsafe static void __CPPCALL_OpenMonsterServerLogic_Implementation(CombatDebugBlueprintFunctionLibrary.__OpenMonsterServerLogic_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.OpenMonsterServerLogic(__Params->value);
	}

	// Token: 0x0601B2D7 RID: 111319 RVA: 0x00858A3F File Offset: 0x00856C3F
	protected unsafe static void __CPPCALL_IsDrawEntityBoxEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDrawEntityBoxEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDrawEntityBoxEnabled();
	}

	// Token: 0x0601B2D8 RID: 111320 RVA: 0x00858A4C File Offset: 0x00856C4C
	protected unsafe static void __CPPCALL_SetDrawEntityBoxEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDrawEntityBoxEnabled_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDrawEntityBoxEnabled(__Params->isEnable);
	}

	// Token: 0x0601B2D9 RID: 111321 RVA: 0x00858A59 File Offset: 0x00856C59
	protected unsafe static void __CPPCALL_IsDrawEntityBoxInfoEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDrawEntityBoxInfoEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDrawEntityBoxInfoEnabled();
	}

	// Token: 0x0601B2DA RID: 111322 RVA: 0x00858A66 File Offset: 0x00856C66
	protected unsafe static void __CPPCALL_SetDrawEntityBoxInfoEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDrawEntityBoxInfoEnabled_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDrawEntityBoxInfoEnabled(__Params->isEnable);
	}

	// Token: 0x0601B2DB RID: 111323 RVA: 0x00858A74 File Offset: 0x00856C74
	protected unsafe static void __CPPCALL_GetCombatScriptIndexes_Implementation(CombatDebugBlueprintFunctionLibrary.__GetCombatScriptIndexes_FunctionParams* __Params)
	{
		TArray<string> combatScriptIndexes = CombatDebugBlueprintFunctionLibrary.GetCombatScriptIndexes();
		if (combatScriptIndexes == null)
		{
			return;
		}
		combatScriptIndexes.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601B2DC RID: 111324 RVA: 0x00858AA0 File Offset: 0x00856CA0
	protected unsafe static void __CPPCALL_FilterScript_Implementation(CombatDebugBlueprintFunctionLibrary.__FilterScript_FunctionParams* __Params)
	{
		string cmd = FString.ToString((void*)(&__Params->cmd));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.FilterScript(cmd));
	}

	// Token: 0x0601B2DD RID: 111325 RVA: 0x00858ACC File Offset: 0x00856CCC
	protected unsafe static void __CPPCALL_IsDebugPrintOpened_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDebugPrintOpened_FunctionParams* __Params)
	{
		string moduleName = FString.ToString((void*)(&__Params->moduleName));
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDebugPrintOpened(moduleName);
	}

	// Token: 0x0601B2DE RID: 111326 RVA: 0x00858AF2 File Offset: 0x00856CF2
	protected unsafe static void __CPPCALL_SetDebugPrintOpened_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugPrintOpened_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugPrintOpened(FString.ToString((void*)(&__Params->moduleName)), __Params->isOpen);
	}

	// Token: 0x0601B2DF RID: 111327 RVA: 0x00858B0B File Offset: 0x00856D0B
	protected unsafe static void __CPPCALL_TryRefreshServerDebugInfo_Implementation(CombatDebugBlueprintFunctionLibrary.__TryRefreshServerDebugInfo_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.TryRefreshServerDebugInfo();
	}

	// Token: 0x0601B2E0 RID: 111328 RVA: 0x00858B12 File Offset: 0x00856D12
	protected unsafe static void __CPPCALL_GetServerBuffRemainDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetServerBuffRemainDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetServerBuffRemainDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601B2E1 RID: 111329 RVA: 0x00858B2B File Offset: 0x00856D2B
	protected unsafe static void __CPPCALL_GetServerBuffTotalDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetServerBuffTotalDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetServerBuffTotalDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601B2E2 RID: 111330 RVA: 0x00858B44 File Offset: 0x00856D44
	protected unsafe static void __CPPCALL_GetBuffRemainDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBuffRemainDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetBuffRemainDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601B2E3 RID: 111331 RVA: 0x00858B5D File Offset: 0x00856D5D
	protected unsafe static void __CPPCALL_GetBuffTotalDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBuffTotalDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetBuffTotalDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601B2E4 RID: 111332 RVA: 0x00858B76 File Offset: 0x00856D76
	protected unsafe static void __CPPCALL_HasServerBuff_Implementation(CombatDebugBlueprintFunctionLibrary.__HasServerBuff_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.HasServerBuff(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601B2E5 RID: 111333 RVA: 0x00858B90 File Offset: 0x00856D90
	protected unsafe static void __CPPCALL_GetAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2E6 RID: 111334 RVA: 0x00858BC4 File Offset: 0x00856DC4
	protected unsafe static void __CPPCALL_GetStateAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetStateAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetStateAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2E7 RID: 111335 RVA: 0x00858BF8 File Offset: 0x00856DF8
	protected unsafe static void __CPPCALL_GetFormationAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetFormationAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetFormationAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2E8 RID: 111336 RVA: 0x00858C2C File Offset: 0x00856E2C
	protected unsafe static void __CPPCALL_GetSquadAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSquadAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSquadAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2E9 RID: 111337 RVA: 0x00858C60 File Offset: 0x00856E60
	protected unsafe static void __CPPCALL_GetStateSquadAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetStateSquadAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetStateSquadAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2EA RID: 111338 RVA: 0x00858C94 File Offset: 0x00856E94
	protected unsafe static void __CPPCALL_ExtractInt64ArrayFromString_Implementation(CombatDebugBlueprintFunctionLibrary.__ExtractInt64ArrayFromString_FunctionParams* __Params)
	{
		TArray<long> tarray = CombatDebugBlueprintFunctionLibrary.ExtractInt64ArrayFromString(FString.ToString((void*)(&__Params->content)));
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601B2EB RID: 111339 RVA: 0x00858CCC File Offset: 0x00856ECC
	protected unsafe static void __CPPCALL_ExtractTagNameArrayFromString_Implementation(CombatDebugBlueprintFunctionLibrary.__ExtractTagNameArrayFromString_FunctionParams* __Params)
	{
		TArray<string> tarray = CombatDebugBlueprintFunctionLibrary.ExtractTagNameArrayFromString(FString.ToString((void*)(&__Params->content)));
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601B2EC RID: 111340 RVA: 0x00858D04 File Offset: 0x00856F04
	protected unsafe static void __CPPCALL_GetPassiveDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetPassiveDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetPassiveDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2ED RID: 111341 RVA: 0x00858D38 File Offset: 0x00856F38
	protected unsafe static void __CPPCALL_GetTagsDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetTagsDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetTagsDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2EE RID: 111342 RVA: 0x00858D6C File Offset: 0x00856F6C
	protected unsafe static void __CPPCALL_GetCueDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetCueDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetCueDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2EF RID: 111343 RVA: 0x00858DA0 File Offset: 0x00856FA0
	protected unsafe static void __CPPCALL_LoadDataTable_Implementation(CombatDebugBlueprintFunctionLibrary.__LoadDataTable_FunctionParams* __Params)
	{
		string assetPath = FString.ToString((void*)(&__Params->assetPath));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UDataTable udataTable = CombatDebugBlueprintFunctionLibrary.LoadDataTable(assetPath);
		ptr = ((udataTable != null) ? udataTable.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B2F0 RID: 111344 RVA: 0x00858DD8 File Offset: 0x00856FD8
	protected unsafe static void __CPPCALL_GetDebugStateMachine_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		CombatDebugBlueprintFunctionLibrary.GetDebugStateMachine(__Params->entityId, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601B2F1 RID: 111345 RVA: 0x00858E1A File Offset: 0x0085701A
	protected unsafe static void __CPPCALL_GetSkillDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillDebugString(__Params->entityId));
	}

	// Token: 0x0601B2F2 RID: 111346 RVA: 0x00858E34 File Offset: 0x00857034
	protected unsafe static void __CPPCALL_GetSkillLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2F3 RID: 111347 RVA: 0x00858E66 File Offset: 0x00857066
	protected unsafe static void __CPPCALL_ClearSkillLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearSkillLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearSkillLogString(__Params->entityId);
	}

	// Token: 0x0601B2F4 RID: 111348 RVA: 0x00858E74 File Offset: 0x00857074
	protected unsafe static void __CPPCALL_GetSkillBehaviorLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillBehaviorLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillBehaviorLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2F5 RID: 111349 RVA: 0x00858EA6 File Offset: 0x008570A6
	protected unsafe static void __CPPCALL_ClearSkillBehaviorLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearSkillBehaviorLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearSkillBehaviorLogString(__Params->entityId);
	}

	// Token: 0x0601B2F6 RID: 111350 RVA: 0x00858EB3 File Offset: 0x008570B3
	protected unsafe static void __CPPCALL_GetBulletDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBulletDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetBulletDebugString(__Params->entityId));
	}

	// Token: 0x0601B2F7 RID: 111351 RVA: 0x00858ECC File Offset: 0x008570CC
	protected unsafe static void __CPPCALL_GetBulletLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBulletLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetBulletLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601B2F8 RID: 111352 RVA: 0x00858EFE File Offset: 0x008570FE
	protected unsafe static void __CPPCALL_ClearBulletLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearBulletLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearBulletLogString(__Params->entityId);
	}

	// Token: 0x0601B2F9 RID: 111353 RVA: 0x00858F0B File Offset: 0x0085710B
	protected unsafe static void __CPPCALL_SetEntityDebugMove_Implementation(CombatDebugBlueprintFunctionLibrary.__SetEntityDebugMove_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetEntityDebugMove(__Params->entityId, __Params->enable);
	}

	// Token: 0x0400EC02 RID: 60418
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C";

	// Token: 0x0400EC03 RID: 60419
	private static IntPtr _ClassPtr;

	// Token: 0x0400EC04 RID: 60420
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008A57 RID: 35415
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddPassiveSkillForDebug_FunctionParams
	{
		// Token: 0x0402BF01 RID: 179969
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF02 RID: 179970
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402BF03 RID: 179971
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A58 RID: 35416
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemovePassiveSkillForDebug_FunctionParams
	{
		// Token: 0x0402BF04 RID: 179972
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF05 RID: 179973
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402BF06 RID: 179974
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A59 RID: 35417
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugMonsterMovePath_FunctionParams
	{
		// Token: 0x0402BF07 RID: 179975
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF08 RID: 179976
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008A5A RID: 35418
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugMonsterMovePath_FunctionParams
	{
		// Token: 0x0402BF09 RID: 179977
		[FieldOffset(0)]
		public bool value;

		// Token: 0x0402BF0A RID: 179978
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A5B RID: 35419
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugMonsterControl_FunctionParams
	{
		// Token: 0x0402BF0B RID: 179979
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF0C RID: 179980
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008A5C RID: 35420
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugMonsterControl_FunctionParams
	{
		// Token: 0x0402BF0D RID: 179981
		[FieldOffset(0)]
		public bool value;

		// Token: 0x0402BF0E RID: 179982
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A5D RID: 35421
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenMonsterServerLogic_FunctionParams
	{
		// Token: 0x0402BF0F RID: 179983
		[FieldOffset(0)]
		public bool value;

		// Token: 0x0402BF10 RID: 179984
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A5E RID: 35422
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsDrawEntityBoxEnabled_FunctionParams
	{
		// Token: 0x0402BF11 RID: 179985
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF12 RID: 179986
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008A5F RID: 35423
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDrawEntityBoxEnabled_FunctionParams
	{
		// Token: 0x0402BF13 RID: 179987
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x0402BF14 RID: 179988
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A60 RID: 35424
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsDrawEntityBoxInfoEnabled_FunctionParams
	{
		// Token: 0x0402BF15 RID: 179989
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF16 RID: 179990
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008A61 RID: 35425
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDrawEntityBoxInfoEnabled_FunctionParams
	{
		// Token: 0x0402BF17 RID: 179991
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x0402BF18 RID: 179992
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A62 RID: 35426
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCombatScriptIndexes_FunctionParams
	{
		// Token: 0x0402BF19 RID: 179993
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF1A RID: 179994
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02008A63 RID: 35427
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FilterScript_FunctionParams
	{
		// Token: 0x0402BF1B RID: 179995
		[FieldOffset(0)]
		public FString cmd;

		// Token: 0x0402BF1C RID: 179996
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF1D RID: 179997
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02008A64 RID: 35428
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __IsDebugPrintOpened_FunctionParams
	{
		// Token: 0x0402BF1E RID: 179998
		[FieldOffset(0)]
		public FString moduleName;

		// Token: 0x0402BF1F RID: 179999
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF20 RID: 180000
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x02008A65 RID: 35429
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetDebugPrintOpened_FunctionParams
	{
		// Token: 0x0402BF21 RID: 180001
		[FieldOffset(0)]
		public FString moduleName;

		// Token: 0x0402BF22 RID: 180002
		[FieldOffset(16)]
		public bool isOpen;

		// Token: 0x0402BF23 RID: 180003
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A66 RID: 35430
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TryRefreshServerDebugInfo_FunctionParams
	{
		// Token: 0x0402BF24 RID: 180004
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A67 RID: 35431
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerBuffRemainDuration_FunctionParams
	{
		// Token: 0x0402BF25 RID: 180005
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF26 RID: 180006
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402BF27 RID: 180007
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF28 RID: 180008
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008A68 RID: 35432
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerBuffTotalDuration_FunctionParams
	{
		// Token: 0x0402BF29 RID: 180009
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF2A RID: 180010
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402BF2B RID: 180011
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF2C RID: 180012
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008A69 RID: 35433
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffRemainDuration_FunctionParams
	{
		// Token: 0x0402BF2D RID: 180013
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF2E RID: 180014
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402BF2F RID: 180015
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF30 RID: 180016
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008A6A RID: 35434
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffTotalDuration_FunctionParams
	{
		// Token: 0x0402BF31 RID: 180017
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF32 RID: 180018
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402BF33 RID: 180019
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF34 RID: 180020
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008A6B RID: 35435
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasServerBuff_FunctionParams
	{
		// Token: 0x0402BF35 RID: 180021
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF36 RID: 180022
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402BF37 RID: 180023
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF38 RID: 180024
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008A6C RID: 35436
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetAttributeDebugString_FunctionParams
	{
		// Token: 0x0402BF39 RID: 180025
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF3A RID: 180026
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF3B RID: 180027
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF3C RID: 180028
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A6D RID: 35437
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetStateAttributeDebugString_FunctionParams
	{
		// Token: 0x0402BF3D RID: 180029
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF3E RID: 180030
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF3F RID: 180031
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF40 RID: 180032
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A6E RID: 35438
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetFormationAttributeDebugString_FunctionParams
	{
		// Token: 0x0402BF41 RID: 180033
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF42 RID: 180034
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF43 RID: 180035
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF44 RID: 180036
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A6F RID: 35439
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSquadAttributeDebugString_FunctionParams
	{
		// Token: 0x0402BF45 RID: 180037
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF46 RID: 180038
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF47 RID: 180039
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF48 RID: 180040
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A70 RID: 35440
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetStateSquadAttributeDebugString_FunctionParams
	{
		// Token: 0x0402BF49 RID: 180041
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF4A RID: 180042
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF4B RID: 180043
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF4C RID: 180044
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A71 RID: 35441
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __ExtractInt64ArrayFromString_FunctionParams
	{
		// Token: 0x0402BF4D RID: 180045
		[FieldOffset(0)]
		public FString content;

		// Token: 0x0402BF4E RID: 180046
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF4F RID: 180047
		[FieldOffset(24)]
		public byte __Result;
	}

	// Token: 0x02008A72 RID: 35442
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __ExtractTagNameArrayFromString_FunctionParams
	{
		// Token: 0x0402BF50 RID: 180048
		[FieldOffset(0)]
		public FString content;

		// Token: 0x0402BF51 RID: 180049
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF52 RID: 180050
		[FieldOffset(24)]
		public byte __Result;
	}

	// Token: 0x02008A73 RID: 35443
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetPassiveDebugString_FunctionParams
	{
		// Token: 0x0402BF53 RID: 180051
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF54 RID: 180052
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF55 RID: 180053
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF56 RID: 180054
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A74 RID: 35444
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetTagsDebugString_FunctionParams
	{
		// Token: 0x0402BF57 RID: 180055
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF58 RID: 180056
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF59 RID: 180057
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF5A RID: 180058
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A75 RID: 35445
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetCueDebugString_FunctionParams
	{
		// Token: 0x0402BF5B RID: 180059
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF5C RID: 180060
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF5D RID: 180061
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF5E RID: 180062
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A76 RID: 35446
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __LoadDataTable_FunctionParams
	{
		// Token: 0x0402BF5F RID: 180063
		[FieldOffset(0)]
		public FString assetPath;

		// Token: 0x0402BF60 RID: 180064
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF61 RID: 180065
		[FieldOffset(24)]
		public IntPtr __Result;
	}

	// Token: 0x02008A77 RID: 35447
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetDebugStateMachine_FunctionParams
	{
		// Token: 0x0402BF62 RID: 180066
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF63 RID: 180067
		[FieldOffset(8)]
		public byte output;

		// Token: 0x0402BF64 RID: 180068
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A78 RID: 35448
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSkillDebugString_FunctionParams
	{
		// Token: 0x0402BF65 RID: 180069
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF66 RID: 180070
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF67 RID: 180071
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008A79 RID: 35449
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillLogString_FunctionParams
	{
		// Token: 0x0402BF68 RID: 180072
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF69 RID: 180073
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF6A RID: 180074
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF6B RID: 180075
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A7A RID: 35450
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearSkillLogString_FunctionParams
	{
		// Token: 0x0402BF6C RID: 180076
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF6D RID: 180077
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A7B RID: 35451
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillBehaviorLogString_FunctionParams
	{
		// Token: 0x0402BF6E RID: 180078
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF6F RID: 180079
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF70 RID: 180080
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF71 RID: 180081
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A7C RID: 35452
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearSkillBehaviorLogString_FunctionParams
	{
		// Token: 0x0402BF72 RID: 180082
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF73 RID: 180083
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A7D RID: 35453
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBulletDebugString_FunctionParams
	{
		// Token: 0x0402BF74 RID: 180084
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF75 RID: 180085
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF76 RID: 180086
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008A7E RID: 35454
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetBulletLogString_FunctionParams
	{
		// Token: 0x0402BF77 RID: 180087
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF78 RID: 180088
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402BF79 RID: 180089
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402BF7A RID: 180090
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008A7F RID: 35455
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearBulletLogString_FunctionParams
	{
		// Token: 0x0402BF7B RID: 180091
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF7C RID: 180092
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A80 RID: 35456
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEntityDebugMove_FunctionParams
	{
		// Token: 0x0402BF7D RID: 180093
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BF7E RID: 180094
		[FieldOffset(4)]
		public bool enable;

		// Token: 0x0402BF7F RID: 180095
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
