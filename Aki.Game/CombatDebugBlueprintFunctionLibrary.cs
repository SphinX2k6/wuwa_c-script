using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Common;
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

// Token: 0x020034AA RID: 13482
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C")]
public class CombatDebugBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D59E RID: 120222 RVA: 0x0082E814 File Offset: 0x0082CA14
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

	// Token: 0x0601D59F RID: 120223 RVA: 0x0082E85C File Offset: 0x0082CA5C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemovePassiveSkillForDebug(int entityId, long passiveSkillId)
	{
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ForgetPassiveSkill(passiveSkillId, false);
		}
	}

	// Token: 0x0601D5A0 RID: 120224 RVA: 0x0082E888 File Offset: 0x0082CA88
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetDebugMonsterMovePath()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.DebugMonsterMovePath;
	}

	// Token: 0x0601D5A1 RID: 120225 RVA: 0x0082E89A File Offset: 0x0082CA9A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetDebugMonsterMovePath(bool value)
	{
		CombatDebugDrawController.Instance.DebugMonsterMovePath = value;
	}

	// Token: 0x0601D5A2 RID: 120226 RVA: 0x0082E8A7 File Offset: 0x0082CAA7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetDebugMonsterControl()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.DebugMonsterControl;
	}

	// Token: 0x0601D5A3 RID: 120227 RVA: 0x0082E8B9 File Offset: 0x0082CAB9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetDebugMonsterControl(bool value)
	{
		CombatDebugDrawController.Instance.DebugMonsterControl = value;
	}

	// Token: 0x0601D5A4 RID: 120228 RVA: 0x0082E8C8 File Offset: 0x0082CAC8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenMonsterServerLogic(bool value)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CloseMonsterServerLogic#");
		defaultInterpolatedStringHandler.AppendFormatted<int>((!value) ? 1 : 0);
		string p = defaultInterpolatedStringHandler.ToStringAndClear();
		EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
	}

	// Token: 0x0601D5A5 RID: 120229 RVA: 0x0082E90F File Offset: 0x0082CB0F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDrawEntityBoxEnabled()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.IsDrawEntityBoxEnabled;
	}

	// Token: 0x0601D5A6 RID: 120230 RVA: 0x0082E921 File Offset: 0x0082CB21
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDrawEntityBoxEnabled(bool isEnable)
	{
		CombatDebugDrawController.Instance.IsDrawEntityBoxEnabled = isEnable;
	}

	// Token: 0x0601D5A7 RID: 120231 RVA: 0x0082E92E File Offset: 0x0082CB2E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDrawEntityBoxInfoEnabled()
	{
		CombatDebugDrawController instance = CombatDebugDrawController.Instance;
		return instance != null && instance.IsDrawEntityBoxInfoEnabled;
	}

	// Token: 0x0601D5A8 RID: 120232 RVA: 0x0082E940 File Offset: 0x0082CB40
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDrawEntityBoxInfoEnabled(bool isEnable)
	{
		CombatDebugDrawController.Instance.IsDrawEntityBoxInfoEnabled = isEnable;
	}

	// Token: 0x0601D5A9 RID: 120233 RVA: 0x0082E94D File Offset: 0x0082CB4D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetCombatScriptIndexes()
	{
		return CombatDebugController.Instance.ScriptHelper.CombatScriptIndexes;
	}

	// Token: 0x0601D5AA RID: 120234 RVA: 0x0082E95E File Offset: 0x0082CB5E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string FilterScript(string cmd)
	{
		return CombatDebugController.Instance.FilterCmd(cmd);
	}

	// Token: 0x0601D5AB RID: 120235 RVA: 0x0082E96C File Offset: 0x0082CB6C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsDebugPrintOpened(string moduleName)
	{
		CombatLog.EDebugModule item;
		return Enum.TryParse<CombatLog.EDebugModule>(moduleName, out item) && CombatLog.Instance.DebugCombatInfo.Contains(item);
	}

	// Token: 0x0601D5AC RID: 120236 RVA: 0x0082E998 File Offset: 0x0082CB98
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

	// Token: 0x0601D5AD RID: 120237 RVA: 0x0082E9D6 File Offset: 0x0082CBD6
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

	// Token: 0x0601D5AE RID: 120238 RVA: 0x0082E9E8 File Offset: 0x0082CBE8
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

	// Token: 0x0601D5AF RID: 120239 RVA: 0x0082EA48 File Offset: 0x0082CC48
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

	// Token: 0x0601D5B0 RID: 120240 RVA: 0x0082EA72 File Offset: 0x0082CC72
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

	// Token: 0x0601D5B1 RID: 120241 RVA: 0x0082EA9C File Offset: 0x0082CC9C
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

	// Token: 0x0601D5B2 RID: 120242 RVA: 0x0082EAF9 File Offset: 0x0082CCF9
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

	// Token: 0x0601D5B3 RID: 120243 RVA: 0x0082EB11 File Offset: 0x0082CD11
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

	// Token: 0x0601D5B4 RID: 120244 RVA: 0x0082EB2C File Offset: 0x0082CD2C
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

	// Token: 0x0601D5B5 RID: 120245 RVA: 0x0082EBC0 File Offset: 0x0082CDC0
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

	// Token: 0x0601D5B6 RID: 120246 RVA: 0x0082EEE4 File Offset: 0x0082D0E4
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

	// Token: 0x0601D5B7 RID: 120247 RVA: 0x0082F2F0 File Offset: 0x0082D4F0
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

	// Token: 0x0601D5B8 RID: 120248 RVA: 0x0082F608 File Offset: 0x0082D808
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

	// Token: 0x0601D5B9 RID: 120249 RVA: 0x0082F854 File Offset: 0x0082DA54
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

	// Token: 0x0601D5BA RID: 120250 RVA: 0x0082FA64 File Offset: 0x0082DC64
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

	// Token: 0x0601D5BB RID: 120251 RVA: 0x0082FAFC File Offset: 0x0082DCFC
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

	// Token: 0x0601D5BC RID: 120252 RVA: 0x0082FB80 File Offset: 0x0082DD80
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

	// Token: 0x0601D5BD RID: 120253 RVA: 0x0082FC58 File Offset: 0x0082DE58
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

	// Token: 0x0601D5BE RID: 120254 RVA: 0x0082FD10 File Offset: 0x0082DF10
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
			PassiveSkillData[] allPassiveSkills = component.GetAllPassiveSkills();
			for (int j = 0; j < allPassiveSkills.Length; j++)
			{
				PassiveSkillData skill = allPassiveSkills[j];
				if (list.Count <= 0 || list.Any((string key) => skill.SkillId.ToString().StartsWith(key)))
				{
					Trigger trigger = (component2 != null) ? component2.GetTrigger(skill.TriggerHandle) : null;
					PassiveSkill? config = ConfigPassiveSkillById.GetConfig(skill.SkillId, true);
					PassiveSkillCdInfo passiveSkillCdInfo = (component3 != null) ? component3.GetPassiveSkillCdInfo(skill.SkillId) : null;
					string value = (passiveSkillCdInfo != null) ? CombatDebugBlueprintFunctionLibrary.GetPassiveCdString(passiveSkillCdInfo) : "【无CD组件】";
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("技能: ");
					appendInterpolatedStringHandler.AppendFormatted<long>(skill.SkillId);
					appendInterpolatedStringHandler.AppendLiteral(" handle: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(skill.TriggerHandle);
					stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
					stringBuilder.Append(value);
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
					foreach (SkillActionData act2 in skill.Actions)
					{
						SkillActionData act = act2;
						switch (act.Action)
						{
						case ESkillAction.AddBullet:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder9 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    添加子弹 ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join('、', act.BulletRowNames));
							stringBuilder9.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.RemoveBullet:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder10 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    移除子弹 ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', act.BulletRowNames.Select((string v, int index) => v + ((act.SummonChild != null && act.SummonChild.Length > index && act.SummonChild[index]) ? "创建子子弹" : "不创建子子弹"))));
							stringBuilder10.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.AddBuff:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder11 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    添加Buff ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<long>('、', act.BuffId));
							stringBuilder11.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.RemoveBuff:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder12 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    移除Buff ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', act.BuffId.Select(delegate(long v, int i)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
								defaultInterpolatedStringHandler.AppendFormatted<long>(v);
								string value3;
								if (act.StackCount == null || act.StackCount.Length <= i || act.StackCount[i] <= 0)
								{
									value3 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(移除");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(act.StackCount[i]);
									defaultInterpolatedStringHandler2.AppendLiteral("层)");
									value3 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value3);
								return defaultInterpolatedStringHandler.ToStringAndClear();
							})));
							stringBuilder12.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.StartSkill:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder13 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    触发主动技能 ");
							appendInterpolatedStringHandler.AppendFormatted<int>(act.SkillId);
							stringBuilder13.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.LockOn:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder14 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 5, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    锁定目标 ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(act.IsHardLock);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<int>(act.LockOnConfigId);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<ESkillTargetPriority>(act.SkillTargetPriority);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(act.ShowTarget);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							appendInterpolatedStringHandler.AppendFormatted<bool>(act.GlobalTarget);
							stringBuilder14.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.Customize:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder15 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    自定义行为 ");
							Formula formula = act.Formula;
							appendInterpolatedStringHandler.AppendFormatted((formula != null) ? formula.FormulaStr : null);
							appendInterpolatedStringHandler.AppendLiteral(" ");
							stringBuilder15.AppendLine(ref appendInterpolatedStringHandler);
							break;
						}
						case ESkillAction.ReduceSkillCd:
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder16 = stringBuilder2;
							appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
							appendInterpolatedStringHandler.AppendLiteral("    减少技能CD ");
							appendInterpolatedStringHandler.AppendFormatted(string.Join<string>('、', act.ReduceSkillId.Select(delegate(long v, int i)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 4);
								defaultInterpolatedStringHandler.AppendFormatted<long>(v);
								defaultInterpolatedStringHandler.AppendFormatted((act.CdResetType != null && act.CdResetType.Length > i) ? act.CdResetType[i].ToString() : "");
								string value3;
								if (act.DecreaseRatio == null || act.DecreaseRatio.Length <= i)
								{
									value3 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(");
									defaultInterpolatedStringHandler2.AppendFormatted<float>(act.DecreaseRatio[i]);
									defaultInterpolatedStringHandler2.AppendLiteral(")");
									value3 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value3);
								string value4;
								if (act.DecreaseMagnitude == null || act.DecreaseMagnitude.Length <= i)
								{
									value4 = "";
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 1);
									defaultInterpolatedStringHandler2.AppendLiteral("(");
									defaultInterpolatedStringHandler2.AppendFormatted<float>(act.DecreaseMagnitude[i]);
									defaultInterpolatedStringHandler2.AppendLiteral(")");
									value4 = defaultInterpolatedStringHandler2.ToStringAndClear();
								}
								defaultInterpolatedStringHandler.AppendFormatted(value4);
								return defaultInterpolatedStringHandler.ToStringAndClear();
							})));
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
						stringBuilder.AppendLine(string.Join("\n", from s in text.Trim().Split('\n', StringSplitOptions.None)
						select "    " + s));
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
					string skillId = keyValuePair.Key;
					string value2 = keyValuePair.Value;
					if (list.Any((string key) => skillId.StartsWith(key)))
					{
						stringBuilder.Append(value2);
					}
				}
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0601D5BF RID: 120255 RVA: 0x00830590 File Offset: 0x0082E790
	[NullableContext(1)]
	protected static bool IsRegexFuzzyMatch(string str, string pattern)
	{
		string pattern2 = string.Join<char>(".*", pattern.ToCharArray());
		return Regex.IsMatch(str, pattern2);
	}

	// Token: 0x0601D5C0 RID: 120256 RVA: 0x008305B8 File Offset: 0x0082E7B8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetTagsDebugString(int entityId, string filterStr = "")
	{
		List<string> list = (from name in filterStr.Split(new char[]
		{
			',',
			'，'
		}, StringSplitOptions.RemoveEmptyEntries)
		select name.Trim()).ToList<string>();
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
					int tagId = entityBattleTagInfo.TagId;
					dictionary4[tagId] += entityBattleTagInfo.Count;
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
					int tagId = entityBattleTagInfo2.TagId;
					dictionary4[tagId] += entityBattleTagInfo2.Count;
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
		foreach (int tagId2 in tagContainer.GetAllExactTags())
		{
			string tagName = GameplayTagUtils.GetNameByTagId(tagId2);
			if (string.IsNullOrEmpty(tagName) || list.Count <= 0 || list.Any((string key) => CombatDebugBlueprintFunctionLibrary.IsRegexFuzzyMatch(tagName, key)))
			{
				int exactTagCount = tagContainer.GetExactTagCount(tagId2);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(tagId2));
				defaultInterpolatedStringHandler.AppendLiteral(" x ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(exactTagCount);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				StringBuilder stringBuilder2 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (ETagChannel etagChannel in tagContainer.GetAllChannels())
				{
					int rawTagCount = tagContainer.GetRawTagCount(etagChannel, tagId2);
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
			int key3 = keyValuePair.Key;
			int value = keyValuePair.Value;
			string tagName = GameplayTagUtils.GetNameByTagId(key3);
			if (string.IsNullOrEmpty(tagName) || list.Count <= 0 || list.Any((string key) => CombatDebugBlueprintFunctionLibrary.IsRegexFuzzyMatch(tagName, key)))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(key3));
				defaultInterpolatedStringHandler.AppendLiteral(" x ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				StringBuilder stringBuilder5 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (KeyValuePair<string, Dictionary<int, int>> keyValuePair2 in dictionary2)
				{
					string key2 = keyValuePair2.Key;
					int num;
					if (keyValuePair2.Value.TryGetValue(key3, out num) && num > 0)
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

	// Token: 0x0601D5C1 RID: 120257 RVA: 0x00830BA0 File Offset: 0x0082EDA0
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
		using (IEnumerator<GameplayCueBase> enumerator2 = component.GetAllCurrentCueRef().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GameplayCueBase cue = enumerator2.Current;
				if (list.Count <= 0 || list.Any((string key) => cue.CueConfig.Id.ToString().Contains(key)))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(42, 4, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("CueId: ");
					appendInterpolatedStringHandler.AppendFormatted<long>(cue.CueConfig.Id);
					appendInterpolatedStringHandler.AppendLiteral(" CueHandleId: [");
					appendInterpolatedStringHandler.AppendFormatted(string.Join<long>(", ", cue.CueHandleIds));
					appendInterpolatedStringHandler.AppendLiteral("] CueType: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(cue.CueConfig.CueType);
					appendInterpolatedStringHandler.AppendLiteral(" BuffId: ");
					appendInterpolatedStringHandler.AppendFormatted<long?>(cue.BuffId);
					stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
				}
			}
		}
		if (!SceneTeamModel.Instance.GetTeamEntities(false).Any((EntityHandle handle) => handle.Id == entityId))
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
		using (IEnumerator<GameplayCueBase> enumerator2 = playerGameplayCueComponent.GetAllCurrentCueRef().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GameplayCueBase cue = enumerator2.Current;
				if (list.Count <= 0 || list.Any((string key) => cue.CueConfig.Id.ToString().Contains(key)))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(42, 4, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("CueId: ");
					appendInterpolatedStringHandler.AppendFormatted<long>(cue.CueConfig.Id);
					appendInterpolatedStringHandler.AppendLiteral(" CueHandleId: [");
					appendInterpolatedStringHandler.AppendFormatted(string.Join<long>(", ", cue.CueHandleIds));
					appendInterpolatedStringHandler.AppendLiteral("] CueType: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(cue.CueConfig.CueType);
					appendInterpolatedStringHandler.AppendLiteral(" BuffId: ");
					appendInterpolatedStringHandler.AppendFormatted<long?>(cue.BuffId);
					stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601D5C2 RID: 120258 RVA: 0x00830EDC File Offset: 0x0082F0DC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UDataTable LoadDataTable(string assetPath)
	{
		if (!Info.Instance.IsPlayInEditor)
		{
			return null;
		}
		return ResourceSystem.Instance.Load<UDataTable>(assetPath, "Debug");
	}

	// Token: 0x0601D5C3 RID: 120259 RVA: 0x00830EFC File Offset: 0x0082F0FC
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

	// Token: 0x0601D5C4 RID: 120260 RVA: 0x00830F7C File Offset: 0x0082F17C
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

	// Token: 0x0601D5C5 RID: 120261 RVA: 0x00831314 File Offset: 0x0082F514
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

	// Token: 0x0601D5C6 RID: 120262 RVA: 0x00831340 File Offset: 0x0082F540
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearSkillLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ClearSkillLogString();
		}
	}

	// Token: 0x0601D5C7 RID: 120263 RVA: 0x00831364 File Offset: 0x0082F564
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

	// Token: 0x0601D5C8 RID: 120264 RVA: 0x00831390 File Offset: 0x0082F590
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearSkillBehaviorLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ClearSkillBehaviorLogString();
		}
	}

	// Token: 0x0601D5C9 RID: 120265 RVA: 0x008313B4 File Offset: 0x0082F5B4
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

	// Token: 0x0601D5CA RID: 120266 RVA: 0x008314AC File Offset: 0x0082F6AC
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

	// Token: 0x0601D5CB RID: 120267 RVA: 0x008314E0 File Offset: 0x0082F6E0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearBulletLogString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ClearBulletLogString();
		}
	}

	// Token: 0x0601D5CC RID: 120268 RVA: 0x0083150C File Offset: 0x0082F70C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEntityDebugMove(int entityId, bool enable)
	{
		ActorDebugMovementComponent component = EntitySystem.Instance.GetComponent<ActorDebugMovementComponent>(entityId);
		if (component != null)
		{
			component.SetDebug(enable);
		}
	}

	// Token: 0x0601D5CD RID: 120269 RVA: 0x0083152F File Offset: 0x0082F72F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CombatDebugBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C");
		}
		return CombatDebugBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601D5CE RID: 120270 RVA: 0x00831554 File Offset: 0x0082F754
	public CombatDebugBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D5CF RID: 120271 RVA: 0x0083157C File Offset: 0x0082F77C
	[NullableContext(1)]
	public CombatDebugBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D5D0 RID: 120272 RVA: 0x008315AF File Offset: 0x0082F7AF
	protected CombatDebugBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D5D1 RID: 120273 RVA: 0x008315B8 File Offset: 0x0082F7B8
	protected unsafe static void __CPPCALL_AddPassiveSkillForDebug_Implementation(CombatDebugBlueprintFunctionLibrary.__AddPassiveSkillForDebug_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.AddPassiveSkillForDebug(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x0601D5D2 RID: 120274 RVA: 0x008315CB File Offset: 0x0082F7CB
	protected unsafe static void __CPPCALL_RemovePassiveSkillForDebug_Implementation(CombatDebugBlueprintFunctionLibrary.__RemovePassiveSkillForDebug_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.RemovePassiveSkillForDebug(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x0601D5D3 RID: 120275 RVA: 0x008315DE File Offset: 0x0082F7DE
	protected unsafe static void __CPPCALL_GetDebugMonsterMovePath_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugMonsterMovePath_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetDebugMonsterMovePath();
	}

	// Token: 0x0601D5D4 RID: 120276 RVA: 0x008315EB File Offset: 0x0082F7EB
	protected unsafe static void __CPPCALL_SetDebugMonsterMovePath_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugMonsterMovePath_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugMonsterMovePath(__Params->value);
	}

	// Token: 0x0601D5D5 RID: 120277 RVA: 0x008315F8 File Offset: 0x0082F7F8
	protected unsafe static void __CPPCALL_GetDebugMonsterControl_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugMonsterControl_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetDebugMonsterControl();
	}

	// Token: 0x0601D5D6 RID: 120278 RVA: 0x00831605 File Offset: 0x0082F805
	protected unsafe static void __CPPCALL_SetDebugMonsterControl_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugMonsterControl_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugMonsterControl(__Params->value);
	}

	// Token: 0x0601D5D7 RID: 120279 RVA: 0x00831612 File Offset: 0x0082F812
	protected unsafe static void __CPPCALL_OpenMonsterServerLogic_Implementation(CombatDebugBlueprintFunctionLibrary.__OpenMonsterServerLogic_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.OpenMonsterServerLogic(__Params->value);
	}

	// Token: 0x0601D5D8 RID: 120280 RVA: 0x0083161F File Offset: 0x0082F81F
	protected unsafe static void __CPPCALL_IsDrawEntityBoxEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDrawEntityBoxEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDrawEntityBoxEnabled();
	}

	// Token: 0x0601D5D9 RID: 120281 RVA: 0x0083162C File Offset: 0x0082F82C
	protected unsafe static void __CPPCALL_SetDrawEntityBoxEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDrawEntityBoxEnabled_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDrawEntityBoxEnabled(__Params->isEnable);
	}

	// Token: 0x0601D5DA RID: 120282 RVA: 0x00831639 File Offset: 0x0082F839
	protected unsafe static void __CPPCALL_IsDrawEntityBoxInfoEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDrawEntityBoxInfoEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDrawEntityBoxInfoEnabled();
	}

	// Token: 0x0601D5DB RID: 120283 RVA: 0x00831646 File Offset: 0x0082F846
	protected unsafe static void __CPPCALL_SetDrawEntityBoxInfoEnabled_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDrawEntityBoxInfoEnabled_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDrawEntityBoxInfoEnabled(__Params->isEnable);
	}

	// Token: 0x0601D5DC RID: 120284 RVA: 0x00831654 File Offset: 0x0082F854
	protected unsafe static void __CPPCALL_GetCombatScriptIndexes_Implementation(CombatDebugBlueprintFunctionLibrary.__GetCombatScriptIndexes_FunctionParams* __Params)
	{
		TArray<string> combatScriptIndexes = CombatDebugBlueprintFunctionLibrary.GetCombatScriptIndexes();
		if (combatScriptIndexes == null)
		{
			return;
		}
		combatScriptIndexes.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601D5DD RID: 120285 RVA: 0x00831680 File Offset: 0x0082F880
	protected unsafe static void __CPPCALL_FilterScript_Implementation(CombatDebugBlueprintFunctionLibrary.__FilterScript_FunctionParams* __Params)
	{
		string cmd = FString.ToString((void*)(&__Params->cmd));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.FilterScript(cmd));
	}

	// Token: 0x0601D5DE RID: 120286 RVA: 0x008316AC File Offset: 0x0082F8AC
	protected unsafe static void __CPPCALL_IsDebugPrintOpened_Implementation(CombatDebugBlueprintFunctionLibrary.__IsDebugPrintOpened_FunctionParams* __Params)
	{
		string moduleName = FString.ToString((void*)(&__Params->moduleName));
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.IsDebugPrintOpened(moduleName);
	}

	// Token: 0x0601D5DF RID: 120287 RVA: 0x008316D2 File Offset: 0x0082F8D2
	protected unsafe static void __CPPCALL_SetDebugPrintOpened_Implementation(CombatDebugBlueprintFunctionLibrary.__SetDebugPrintOpened_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetDebugPrintOpened(FString.ToString((void*)(&__Params->moduleName)), __Params->isOpen);
	}

	// Token: 0x0601D5E0 RID: 120288 RVA: 0x008316EB File Offset: 0x0082F8EB
	protected unsafe static void __CPPCALL_TryRefreshServerDebugInfo_Implementation(CombatDebugBlueprintFunctionLibrary.__TryRefreshServerDebugInfo_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.TryRefreshServerDebugInfo();
	}

	// Token: 0x0601D5E1 RID: 120289 RVA: 0x008316F2 File Offset: 0x0082F8F2
	protected unsafe static void __CPPCALL_GetServerBuffRemainDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetServerBuffRemainDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetServerBuffRemainDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601D5E2 RID: 120290 RVA: 0x0083170B File Offset: 0x0082F90B
	protected unsafe static void __CPPCALL_GetServerBuffTotalDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetServerBuffTotalDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetServerBuffTotalDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601D5E3 RID: 120291 RVA: 0x00831724 File Offset: 0x0082F924
	protected unsafe static void __CPPCALL_GetBuffRemainDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBuffRemainDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetBuffRemainDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601D5E4 RID: 120292 RVA: 0x0083173D File Offset: 0x0082F93D
	protected unsafe static void __CPPCALL_GetBuffTotalDuration_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBuffTotalDuration_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.GetBuffTotalDuration(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601D5E5 RID: 120293 RVA: 0x00831756 File Offset: 0x0082F956
	protected unsafe static void __CPPCALL_HasServerBuff_Implementation(CombatDebugBlueprintFunctionLibrary.__HasServerBuff_FunctionParams* __Params)
	{
		__Params->__Result = CombatDebugBlueprintFunctionLibrary.HasServerBuff(__Params->entityId, __Params->handle);
	}

	// Token: 0x0601D5E6 RID: 120294 RVA: 0x00831770 File Offset: 0x0082F970
	protected unsafe static void __CPPCALL_GetAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5E7 RID: 120295 RVA: 0x008317A4 File Offset: 0x0082F9A4
	protected unsafe static void __CPPCALL_GetStateAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetStateAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetStateAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5E8 RID: 120296 RVA: 0x008317D8 File Offset: 0x0082F9D8
	protected unsafe static void __CPPCALL_GetFormationAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetFormationAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetFormationAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5E9 RID: 120297 RVA: 0x0083180C File Offset: 0x0082FA0C
	protected unsafe static void __CPPCALL_GetSquadAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSquadAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSquadAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5EA RID: 120298 RVA: 0x00831840 File Offset: 0x0082FA40
	protected unsafe static void __CPPCALL_GetStateSquadAttributeDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetStateSquadAttributeDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetStateSquadAttributeDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5EB RID: 120299 RVA: 0x00831874 File Offset: 0x0082FA74
	protected unsafe static void __CPPCALL_ExtractInt64ArrayFromString_Implementation(CombatDebugBlueprintFunctionLibrary.__ExtractInt64ArrayFromString_FunctionParams* __Params)
	{
		TArray<long> tarray = CombatDebugBlueprintFunctionLibrary.ExtractInt64ArrayFromString(FString.ToString((void*)(&__Params->content)));
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601D5EC RID: 120300 RVA: 0x008318AC File Offset: 0x0082FAAC
	protected unsafe static void __CPPCALL_ExtractTagNameArrayFromString_Implementation(CombatDebugBlueprintFunctionLibrary.__ExtractTagNameArrayFromString_FunctionParams* __Params)
	{
		TArray<string> tarray = CombatDebugBlueprintFunctionLibrary.ExtractTagNameArrayFromString(FString.ToString((void*)(&__Params->content)));
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601D5ED RID: 120301 RVA: 0x008318E4 File Offset: 0x0082FAE4
	protected unsafe static void __CPPCALL_GetPassiveDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetPassiveDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetPassiveDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5EE RID: 120302 RVA: 0x00831918 File Offset: 0x0082FB18
	protected unsafe static void __CPPCALL_GetTagsDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetTagsDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetTagsDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5EF RID: 120303 RVA: 0x0083194C File Offset: 0x0082FB4C
	protected unsafe static void __CPPCALL_GetCueDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetCueDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetCueDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5F0 RID: 120304 RVA: 0x00831980 File Offset: 0x0082FB80
	protected unsafe static void __CPPCALL_LoadDataTable_Implementation(CombatDebugBlueprintFunctionLibrary.__LoadDataTable_FunctionParams* __Params)
	{
		string assetPath = FString.ToString((void*)(&__Params->assetPath));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UDataTable udataTable = CombatDebugBlueprintFunctionLibrary.LoadDataTable(assetPath);
		ptr = ((udataTable != null) ? udataTable.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D5F1 RID: 120305 RVA: 0x008319B8 File Offset: 0x0082FBB8
	protected unsafe static void __CPPCALL_GetDebugStateMachine_Implementation(CombatDebugBlueprintFunctionLibrary.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		CombatDebugBlueprintFunctionLibrary.GetDebugStateMachine(__Params->entityId, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601D5F2 RID: 120306 RVA: 0x008319FA File Offset: 0x0082FBFA
	protected unsafe static void __CPPCALL_GetSkillDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillDebugString(__Params->entityId));
	}

	// Token: 0x0601D5F3 RID: 120307 RVA: 0x00831A14 File Offset: 0x0082FC14
	protected unsafe static void __CPPCALL_GetSkillLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5F4 RID: 120308 RVA: 0x00831A46 File Offset: 0x0082FC46
	protected unsafe static void __CPPCALL_ClearSkillLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearSkillLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearSkillLogString(__Params->entityId);
	}

	// Token: 0x0601D5F5 RID: 120309 RVA: 0x00831A54 File Offset: 0x0082FC54
	protected unsafe static void __CPPCALL_GetSkillBehaviorLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetSkillBehaviorLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetSkillBehaviorLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5F6 RID: 120310 RVA: 0x00831A86 File Offset: 0x0082FC86
	protected unsafe static void __CPPCALL_ClearSkillBehaviorLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearSkillBehaviorLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearSkillBehaviorLogString(__Params->entityId);
	}

	// Token: 0x0601D5F7 RID: 120311 RVA: 0x00831A93 File Offset: 0x0082FC93
	protected unsafe static void __CPPCALL_GetBulletDebugString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBulletDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetBulletDebugString(__Params->entityId));
	}

	// Token: 0x0601D5F8 RID: 120312 RVA: 0x00831AAC File Offset: 0x0082FCAC
	protected unsafe static void __CPPCALL_GetBulletLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__GetBulletLogString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), CombatDebugBlueprintFunctionLibrary.GetBulletLogString(__Params->entityId, filterStr));
	}

	// Token: 0x0601D5F9 RID: 120313 RVA: 0x00831ADE File Offset: 0x0082FCDE
	protected unsafe static void __CPPCALL_ClearBulletLogString_Implementation(CombatDebugBlueprintFunctionLibrary.__ClearBulletLogString_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.ClearBulletLogString(__Params->entityId);
	}

	// Token: 0x0601D5FA RID: 120314 RVA: 0x00831AEB File Offset: 0x0082FCEB
	protected unsafe static void __CPPCALL_SetEntityDebugMove_Implementation(CombatDebugBlueprintFunctionLibrary.__SetEntityDebugMove_FunctionParams* __Params)
	{
		CombatDebugBlueprintFunctionLibrary.SetEntityDebugMove(__Params->entityId, __Params->enable);
	}

	// Token: 0x0400E74E RID: 59214
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/CombatDebugBlueprintFunctionLibrary.CombatDebugBlueprintFunctionLibrary_C";

	// Token: 0x0400E74F RID: 59215
	private static IntPtr _ClassPtr;

	// Token: 0x0400E750 RID: 59216
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009833 RID: 38963
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddPassiveSkillForDebug_FunctionParams
	{
		// Token: 0x04030871 RID: 198769
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030872 RID: 198770
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x04030873 RID: 198771
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009834 RID: 38964
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemovePassiveSkillForDebug_FunctionParams
	{
		// Token: 0x04030874 RID: 198772
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030875 RID: 198773
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x04030876 RID: 198774
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009835 RID: 38965
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugMonsterMovePath_FunctionParams
	{
		// Token: 0x04030877 RID: 198775
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04030878 RID: 198776
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02009836 RID: 38966
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugMonsterMovePath_FunctionParams
	{
		// Token: 0x04030879 RID: 198777
		[FieldOffset(0)]
		public bool value;

		// Token: 0x0403087A RID: 198778
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009837 RID: 38967
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugMonsterControl_FunctionParams
	{
		// Token: 0x0403087B RID: 198779
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0403087C RID: 198780
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02009838 RID: 38968
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugMonsterControl_FunctionParams
	{
		// Token: 0x0403087D RID: 198781
		[FieldOffset(0)]
		public bool value;

		// Token: 0x0403087E RID: 198782
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009839 RID: 38969
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenMonsterServerLogic_FunctionParams
	{
		// Token: 0x0403087F RID: 198783
		[FieldOffset(0)]
		public bool value;

		// Token: 0x04030880 RID: 198784
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200983A RID: 38970
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsDrawEntityBoxEnabled_FunctionParams
	{
		// Token: 0x04030881 RID: 198785
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04030882 RID: 198786
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200983B RID: 38971
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDrawEntityBoxEnabled_FunctionParams
	{
		// Token: 0x04030883 RID: 198787
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04030884 RID: 198788
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200983C RID: 38972
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsDrawEntityBoxInfoEnabled_FunctionParams
	{
		// Token: 0x04030885 RID: 198789
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04030886 RID: 198790
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200983D RID: 38973
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDrawEntityBoxInfoEnabled_FunctionParams
	{
		// Token: 0x04030887 RID: 198791
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04030888 RID: 198792
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200983E RID: 38974
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCombatScriptIndexes_FunctionParams
	{
		// Token: 0x04030889 RID: 198793
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0403088A RID: 198794
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200983F RID: 38975
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FilterScript_FunctionParams
	{
		// Token: 0x0403088B RID: 198795
		[FieldOffset(0)]
		public FString cmd;

		// Token: 0x0403088C RID: 198796
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0403088D RID: 198797
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02009840 RID: 38976
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __IsDebugPrintOpened_FunctionParams
	{
		// Token: 0x0403088E RID: 198798
		[FieldOffset(0)]
		public FString moduleName;

		// Token: 0x0403088F RID: 198799
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04030890 RID: 198800
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x02009841 RID: 38977
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetDebugPrintOpened_FunctionParams
	{
		// Token: 0x04030891 RID: 198801
		[FieldOffset(0)]
		public FString moduleName;

		// Token: 0x04030892 RID: 198802
		[FieldOffset(16)]
		public bool isOpen;

		// Token: 0x04030893 RID: 198803
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009842 RID: 38978
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TryRefreshServerDebugInfo_FunctionParams
	{
		// Token: 0x04030894 RID: 198804
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009843 RID: 38979
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerBuffRemainDuration_FunctionParams
	{
		// Token: 0x04030895 RID: 198805
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030896 RID: 198806
		[FieldOffset(4)]
		public int handle;

		// Token: 0x04030897 RID: 198807
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030898 RID: 198808
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009844 RID: 38980
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerBuffTotalDuration_FunctionParams
	{
		// Token: 0x04030899 RID: 198809
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403089A RID: 198810
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0403089B RID: 198811
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0403089C RID: 198812
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009845 RID: 38981
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffRemainDuration_FunctionParams
	{
		// Token: 0x0403089D RID: 198813
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403089E RID: 198814
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0403089F RID: 198815
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040308A0 RID: 198816
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009846 RID: 38982
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffTotalDuration_FunctionParams
	{
		// Token: 0x040308A1 RID: 198817
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308A2 RID: 198818
		[FieldOffset(4)]
		public int handle;

		// Token: 0x040308A3 RID: 198819
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040308A4 RID: 198820
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009847 RID: 38983
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasServerBuff_FunctionParams
	{
		// Token: 0x040308A5 RID: 198821
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308A6 RID: 198822
		[FieldOffset(4)]
		public int handle;

		// Token: 0x040308A7 RID: 198823
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040308A8 RID: 198824
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009848 RID: 38984
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetAttributeDebugString_FunctionParams
	{
		// Token: 0x040308A9 RID: 198825
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308AA RID: 198826
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308AB RID: 198827
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308AC RID: 198828
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009849 RID: 38985
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetStateAttributeDebugString_FunctionParams
	{
		// Token: 0x040308AD RID: 198829
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308AE RID: 198830
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308AF RID: 198831
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308B0 RID: 198832
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x0200984A RID: 38986
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetFormationAttributeDebugString_FunctionParams
	{
		// Token: 0x040308B1 RID: 198833
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308B2 RID: 198834
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308B3 RID: 198835
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308B4 RID: 198836
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x0200984B RID: 38987
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSquadAttributeDebugString_FunctionParams
	{
		// Token: 0x040308B5 RID: 198837
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308B6 RID: 198838
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308B7 RID: 198839
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308B8 RID: 198840
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x0200984C RID: 38988
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetStateSquadAttributeDebugString_FunctionParams
	{
		// Token: 0x040308B9 RID: 198841
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308BA RID: 198842
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308BB RID: 198843
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308BC RID: 198844
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x0200984D RID: 38989
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __ExtractInt64ArrayFromString_FunctionParams
	{
		// Token: 0x040308BD RID: 198845
		[FieldOffset(0)]
		public FString content;

		// Token: 0x040308BE RID: 198846
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x040308BF RID: 198847
		[FieldOffset(24)]
		public byte __Result;
	}

	// Token: 0x0200984E RID: 38990
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __ExtractTagNameArrayFromString_FunctionParams
	{
		// Token: 0x040308C0 RID: 198848
		[FieldOffset(0)]
		public FString content;

		// Token: 0x040308C1 RID: 198849
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x040308C2 RID: 198850
		[FieldOffset(24)]
		public byte __Result;
	}

	// Token: 0x0200984F RID: 38991
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetPassiveDebugString_FunctionParams
	{
		// Token: 0x040308C3 RID: 198851
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308C4 RID: 198852
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308C5 RID: 198853
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308C6 RID: 198854
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009850 RID: 38992
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetTagsDebugString_FunctionParams
	{
		// Token: 0x040308C7 RID: 198855
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308C8 RID: 198856
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308C9 RID: 198857
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308CA RID: 198858
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009851 RID: 38993
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetCueDebugString_FunctionParams
	{
		// Token: 0x040308CB RID: 198859
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308CC RID: 198860
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308CD RID: 198861
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308CE RID: 198862
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009852 RID: 38994
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __LoadDataTable_FunctionParams
	{
		// Token: 0x040308CF RID: 198863
		[FieldOffset(0)]
		public FString assetPath;

		// Token: 0x040308D0 RID: 198864
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x040308D1 RID: 198865
		[FieldOffset(24)]
		public IntPtr __Result;
	}

	// Token: 0x02009853 RID: 38995
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetDebugStateMachine_FunctionParams
	{
		// Token: 0x040308D2 RID: 198866
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308D3 RID: 198867
		[FieldOffset(8)]
		public byte output;

		// Token: 0x040308D4 RID: 198868
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009854 RID: 38996
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSkillDebugString_FunctionParams
	{
		// Token: 0x040308D5 RID: 198869
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308D6 RID: 198870
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040308D7 RID: 198871
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009855 RID: 38997
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillLogString_FunctionParams
	{
		// Token: 0x040308D8 RID: 198872
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308D9 RID: 198873
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308DA RID: 198874
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308DB RID: 198875
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009856 RID: 38998
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearSkillLogString_FunctionParams
	{
		// Token: 0x040308DC RID: 198876
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308DD RID: 198877
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009857 RID: 38999
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillBehaviorLogString_FunctionParams
	{
		// Token: 0x040308DE RID: 198878
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308DF RID: 198879
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308E0 RID: 198880
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308E1 RID: 198881
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02009858 RID: 39000
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearSkillBehaviorLogString_FunctionParams
	{
		// Token: 0x040308E2 RID: 198882
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308E3 RID: 198883
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009859 RID: 39001
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBulletDebugString_FunctionParams
	{
		// Token: 0x040308E4 RID: 198884
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308E5 RID: 198885
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040308E6 RID: 198886
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200985A RID: 39002
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetBulletLogString_FunctionParams
	{
		// Token: 0x040308E7 RID: 198887
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308E8 RID: 198888
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x040308E9 RID: 198889
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x040308EA RID: 198890
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x0200985B RID: 39003
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearBulletLogString_FunctionParams
	{
		// Token: 0x040308EB RID: 198891
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308EC RID: 198892
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200985C RID: 39004
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEntityDebugMove_FunctionParams
	{
		// Token: 0x040308ED RID: 198893
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040308EE RID: 198894
		[FieldOffset(4)]
		public bool enable;

		// Token: 0x040308EF RID: 198895
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
