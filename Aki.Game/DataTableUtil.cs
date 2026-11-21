using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x02002A29 RID: 10793
[NullableContext(1)]
[Nullable(0)]
public class DataTableUtil : IStaticVariableResetter
{
	// Token: 0x0601B32E RID: 111406 RVA: 0x00859DFC File Offset: 0x00857FFC
	static DataTableUtil()
	{
		Dictionary<EDataTable, string> dictionary = new Dictionary<EDataTable, string>();
		dictionary[EDataTable.ModelConfig] = "/Game/Aki/Data/Entity/CDT_ModelConfig.CDT_ModelConfig";
		dictionary[EDataTable.EntityProperty] = "/Game/Aki/Data/Fight/DT_EntityProperty.DT_EntityProperty";
		dictionary[EDataTable.AiWeaponSocket] = "/Game/Aki/Character/Monster/Common/Data/DT_AiWeaponSocket.DT_AiWeaponSocket";
		dictionary[EDataTable.RoleQualityInfo] = "/Game/Aki/Data/Role/DT_RoleQualityInfo.DT_RoleQualityInfo";
		dictionary[EDataTable.CipherGameplay] = "/Game/Aki/GamePlay/Cipher/DT_SCipherGameplay.DT_SCipherGameplay";
		dictionary[EDataTable.ConditionGroup] = "/Game/Aki/Data/Condition/DT_ConditionGroup.DT_ConditionGroup";
		dictionary[EDataTable.HitMapping] = "/Game/Aki/Data/Fight/DT_HitMapping.DT_HitMapping";
		dictionary[EDataTable.InteractionConfigs] = "/Game/Aki/Data/Interaction/CDT_InteractionConfigs.CDT_InteractionConfigs";
		dictionary[EDataTable.ManipulateItem] = "/Game/Aki/Data/Manipulate/Item/DT_Manipulate_Item.DT_Manipulate_Item";
		dictionary[EDataTable.ManipulatePrecast] = "/Game/Aki/Data/Manipulate/Precast/DT_Manipulate_Precast.DT_Manipulate_Precast";
		dictionary[EDataTable.Parkour] = "/Game/Aki/Data/Parkour/DT_Parkour.DT_Parkour";
		dictionary[EDataTable.SceneDecorativeUi] = "/Game/Aki/Data/Scene3DUI/DT_SceneDecorativeUI.DT_SceneDecorativeUI";
		dictionary[EDataTable.SceneUiTag] = "/Game/Aki/Data/Scene3DUI/DT_SceneUITag.DT_SceneUITag";
		dictionary[EDataTable.ServerInfo] = "/Game/Aki/Data/Server/DT_ServerInfo.DT_ServerInfo";
		dictionary[EDataTable.UiCameraAnimationBlendSettings] = "/Game/Aki/Data/UiCameraAnimation/DT_UiCameraAnimationBlendSettings.DT_UiCameraAnimationBlendSettings";
		dictionary[EDataTable.UiCameraAnimationSettings] = "/Game/Aki/Data/UiCameraAnimation/DT_UiCameraSetting.DT_UiCameraSetting";
		dictionary[EDataTable.Vision] = "/Game/Aki/Character/Vision/DT_Vision.DT_Vision";
		dictionary[EDataTable.UiRoleCameraSettings] = "/Game/Aki/Data/UiRoleCamera/DT_UiRoleCameraSettings.DT_UiRoleCameraSettings";
		dictionary[EDataTable.UiRoleCameraOffsetSettings] = "/Game/Aki/Data/UiRoleCamera/DT_UiRoleCameraOffsetSettings.DT_UiRoleCameraOffsetSettings";
		dictionary[EDataTable.Footprint] = "/Game/Aki/Character/Role/Common/Data/DT/DT_Footprint.DT_Footprint";
		dictionary[EDataTable.SCharacterFootPrint] = "/Game/Aki/Character/Role/Common/Data/DT/DT_CharacterFootprint.DT_CharacterFootprint";
		dictionary[EDataTable.SequenceMember] = "/Game/Aki/Sequence/Manager/DT_SequenceMember.DT_SequenceMember";
		dictionary[EDataTable.GachaWeaponTransform] = "/Game/Aki/Data/GaCha/GachaWeaponTransform.GachaWeaponTransform";
		dictionary[EDataTable.FightSettlementCamera] = "/Game/Aki/Data/Camera/DT_FightSettlementCamera.DT_FightSettlementCamera";
		dictionary[EDataTable.InputCommandTransform] = "/Game/Aki/Data/Fight/DT_InputCommandTransform.DT_InputCommandTransform";
		dictionary[EDataTable.FreeCameraConfig] = "/Game/Aki/Data/Camera/DT_FreeCameraConfigList.DT_FreeCameraConfigList";
		dictionary[EDataTable.FightPhotographCameraConfig] = "/Game/Aki/Data/UiCameraAnimation/DT_UiCameraFightPhotographSetting.DT_UiCameraFightPhotographSetting";
		dictionary[EDataTable.DestructibleTable] = "/Game/Aki/Data/Level/Destructible/DestructibleTable.DestructibleTable";
		dictionary[EDataTable.GameplayABP] = "/Game/Aki/Data/Character/DT_GameplayABPConfig.DT_GameplayABPConfig";
		dictionary[EDataTable.DecorationConfig] = "/Game/Aki/Data/Entity/CDT_DecorationConfig.CDT_DecorationConfig";
		dictionary[EDataTable.UiModelRotateSettings] = "/Game/Aki/Data/UiModel/DT_UiModelRotateSetting.DT_UiModelRotateSetting";
		DataTableUtil.dataTablePaths = dictionary;
		StaticVariableRegister.RegisterAndExecute(new Action(DataTableUtil.CreateStaticDefaultValue), new Action(DataTableUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0601B32F RID: 111407 RVA: 0x00859FBC File Offset: 0x008581BC
	[NullableContext(0)]
	public unsafe static bool TryGetDataTableRowStruct<[IsUnmanaged] T>([Nullable(2)] UDataTable table, [Nullable(1)] string rowName, out T? value) where T : struct, ValueType, IUnrealScriptStruct
	{
		if (table == null || string.IsNullOrEmpty(rowName))
		{
			value = null;
			return false;
		}
		IntPtr dataTableRowFromName = FKuroDataTableFunctionLibrary.GetDataTableRowFromName(table, rowName);
		if (dataTableRowFromName == IntPtr.Zero)
		{
			value = null;
			return false;
		}
		T* ptr = (T*)dataTableRowFromName.ToPointer();
		value = new T?(*ptr);
		return true;
	}

	// Token: 0x0601B330 RID: 111408 RVA: 0x0085A010 File Offset: 0x00858210
	[NullableContext(0)]
	public static bool TryGetDataTableRowStruct<[IsUnmanaged] T>(EDataTable dtEnum, [Nullable(1)] string rowName, out T? value) where T : struct, ValueType, IUnrealScriptStruct
	{
		return DataTableUtil.TryGetDataTableRowStruct<T>(DataTableUtil.GetDataTable(dtEnum), rowName, out value);
	}

	// Token: 0x0601B331 RID: 111409 RVA: 0x0085A020 File Offset: 0x00858220
	[return: Nullable(2)]
	public static T GetDataTableRow<[Nullable(0)] T>([Nullable(2)] UDataTable table, string rowName) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		if (table == null || string.IsNullOrEmpty(rowName))
		{
			return default(T);
		}
		return DataTableCacheData.Instance.GetOrCreate<T>(table, rowName, delegate
		{
			IntPtr dataTableRowFromName = FKuroDataTableFunctionLibrary.GetDataTableRowFromName(table, rowName);
			if (dataTableRowFromName == IntPtr.Zero)
			{
				return default(T);
			}
			return DataTableUtil.CreateDataTableRowReference<T>(dataTableRowFromName, table);
		});
	}

	// Token: 0x0601B332 RID: 111410 RVA: 0x0085A084 File Offset: 0x00858284
	[return: Nullable(2)]
	public static T GetDataTableRowFromName<[Nullable(0)] T>(EDataTable dtEnum, string rowName) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		UDataTable dataTable = DataTableUtil.GetDataTable(dtEnum);
		T dataTableRow = DataTableUtil.GetDataTableRow<T>(dataTable, rowName);
		if (dataTableRow == null && dataTable != null && !string.IsNullOrEmpty(rowName))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DataTableUtil;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "获取预加载DT行配置失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RowName", rowName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return dataTableRow;
	}

	// Token: 0x17002C56 RID: 11350
	// (get) Token: 0x0601B333 RID: 111411 RVA: 0x0085A0E2 File Offset: 0x008582E2
	private static Dictionary<EDataTable, UDataTable> DataTableCacheMap
	{
		get
		{
			return DataTableUtil._dataTableCacheMap;
		}
	}

	// Token: 0x0601B334 RID: 111412 RVA: 0x0085A0E9 File Offset: 0x008582E9
	private static T CreateDataTableRowReference<[Nullable(0)] T>(IntPtr rowPtr, UDataTable table) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		return (T)((object)IUnrealScriptStructProxy.CreateReferenceFromPointer(rowPtr, table));
	}

	// Token: 0x0601B335 RID: 111413 RVA: 0x0085A100 File Offset: 0x00858300
	private static bool TryGetDataTableAllRowsWithKeys(UDataTable table, out TArray<FName> rowNames, out IntPtr[] rows)
	{
		rowNames = new TArray<FName>();
		IntPtr nativePtr = rowNames.NativePtr;
		rows = Array.Empty<IntPtr>();
		FKuroDataTableFunctionLibrary.GetDataTableAllRowWithKeys(table, ref nativePtr, ref rows);
		return nativePtr != IntPtr.Zero && rows.Length != 0 && rowNames.Num() == rows.Length;
	}

	// Token: 0x0601B336 RID: 111414 RVA: 0x0085A148 File Offset: 0x00858348
	[NullableContext(2)]
	private static UDataTable GetDataTable(EDataTable dtEnum)
	{
		UDataTable loadedAsset;
		if (DataTableUtil.DataTableCacheMap.TryGetValue(dtEnum, out loadedAsset))
		{
			return loadedAsset;
		}
		string text;
		if (!DataTableUtil.dataTablePaths.TryGetValue(dtEnum, out text))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DataTableUtil;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "所获取的DT不在DataTableUtil管理中";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DTEnum", dtEnum);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UDataTable>(text);
		if (loadedAsset == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.DataTableUtil;
			ELogAuthor author2 = ELogAuthor.WLJ;
			string message2 = "获取预加载DT失败,请检查是否在预加载前访问该接口";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DTPath", text);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		else
		{
			DataTableUtil.DataTableCacheMap[dtEnum] = loadedAsset;
		}
		return loadedAsset;
	}

	// Token: 0x0601B337 RID: 111415 RVA: 0x0085A1F0 File Offset: 0x008583F0
	[NullableContext(2)]
	public static TArray<FName> GetDataTableAllRowNames(EDataTable dtEnum)
	{
		UDataTable dataTable = DataTableUtil.GetDataTable(dtEnum);
		if (dataTable == null)
		{
			return null;
		}
		IntPtr dataTableAllRowNames = FKuroDataTableFunctionLibrary.GetDataTableAllRowNames(dataTable);
		if (dataTableAllRowNames == IntPtr.Zero)
		{
			return null;
		}
		return new TArray<FName>(dataTableAllRowNames, null);
	}

	// Token: 0x0601B338 RID: 111416 RVA: 0x0085A224 File Offset: 0x00858424
	public static void GetDataTableAllRowNamesFromTable([Nullable(2)] UDataTable table, List<string> result)
	{
		result.Clear();
		if (table == null)
		{
			return;
		}
		IntPtr dataTableAllRowNames = FKuroDataTableFunctionLibrary.GetDataTableAllRowNames(table);
		if (dataTableAllRowNames == IntPtr.Zero)
		{
			return;
		}
		TArray<FName> tarray = new TArray<FName>(dataTableAllRowNames, null);
		int num = tarray.Num();
		result.EnsureCapacity(num);
		for (int i = 0; i < num; i++)
		{
			FName? fname = new FName?(tarray[i]);
			if (fname != null)
			{
				result.Add(fname.ToString());
			}
		}
	}

	// Token: 0x0601B339 RID: 111417 RVA: 0x0085A298 File Offset: 0x00858498
	public static List<T> GetDataTableAllRow<[Nullable(0)] T>(EDataTable dtEnum) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		return DataTableUtil.GetDataTableAllRowFromTable<T>(DataTableUtil.GetDataTable(dtEnum));
	}

	// Token: 0x0601B33A RID: 111418 RVA: 0x0085A2A8 File Offset: 0x008584A8
	public static List<T> GetDataTableAllRowFromTable<[Nullable(0)] T>([Nullable(2)] UDataTable table) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		if (table == null)
		{
			return new List<T>();
		}
		TArray<FName> tarray;
		IntPtr[] array;
		if (!DataTableUtil.TryGetDataTableAllRowsWithKeys(table, out tarray, out array))
		{
			return new List<T>();
		}
		int num = array.Length;
		List<T> list = new List<T>(num);
		for (int i = 0; i < num; i++)
		{
			FName? fname = new FName?(tarray[i]);
			IntPtr rowPtr = array[i];
			if (fname != null && rowPtr != IntPtr.Zero)
			{
				string rowName = fname.Value.ToString();
				list.Add(DataTableCacheData.Instance.GetOrCreate<T>(table, rowName, () => DataTableUtil.CreateDataTableRowReference<T>(rowPtr, table)));
			}
		}
		return list;
	}

	// Token: 0x0601B33B RID: 111419 RVA: 0x0085A390 File Offset: 0x00858590
	public static void GetDataTableAllRowWithKeysFromTable<[Nullable(0)] T>([Nullable(2)] UDataTable table, List<DataTableKeyRow<T>> result) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		result.Clear();
		if (table == null)
		{
			return;
		}
		TArray<FName> tarray;
		IntPtr[] array;
		if (!DataTableUtil.TryGetDataTableAllRowsWithKeys(table, out tarray, out array))
		{
			return;
		}
		int num = array.Length;
		result.EnsureCapacity(num);
		for (int i = 0; i < num; i++)
		{
			FName? fname = new FName?(tarray[i]);
			IntPtr rowPtr = array[i];
			if (fname != null && rowPtr != IntPtr.Zero)
			{
				string text = fname.Value.ToString();
				T orCreate = DataTableCacheData.Instance.GetOrCreate<T>(table, text, () => DataTableUtil.CreateDataTableRowReference<T>(rowPtr, table));
				result.Add(new DataTableKeyRow<T>(text, orCreate));
			}
		}
	}

	// Token: 0x0601B33C RID: 111420 RVA: 0x0085A47C File Offset: 0x0085867C
	public static List<Tuple<string, T>> GetAllDataTableRowFromTableWithRowName<[Nullable(0)] T>([Nullable(2)] UDataTable table) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		List<DataTableKeyRow<T>> list = new List<DataTableKeyRow<T>>();
		DataTableUtil.GetDataTableAllRowWithKeysFromTable<T>(table, list);
		List<Tuple<string, T>> list2 = new List<Tuple<string, T>>(list.Count);
		foreach (DataTableKeyRow<T> dataTableKeyRow in list)
		{
			list2.Add(Tuple.Create<string, T>(dataTableKeyRow.Key, dataTableKeyRow.Value));
		}
		return list2;
	}

	// Token: 0x0601B33D RID: 111421 RVA: 0x0085A4F4 File Offset: 0x008586F4
	[return: Nullable(2)]
	public static SWeaponSocketItem LoadAiWeaponSocketConfigs(string rowName, int key)
	{
		SAiWeaponSocket dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SAiWeaponSocket>(EDataTable.AiWeaponSocket, rowName);
		if (dataTableRowFromName == null)
		{
			return null;
		}
		SWeaponSocket valueOrDefault = dataTableRowFromName.AiModelConfig.GetValueOrDefault(key);
		if (valueOrDefault == null)
		{
			return null;
		}
		return valueOrDefault.Weapon;
	}

	// Token: 0x0601B33E RID: 111422 RVA: 0x0085A52C File Offset: 0x0085872C
	public static Dictionary<int, SAiWeaponSocket> LoadAllAiWeaponSockets()
	{
		UDataTable dataTable = DataTableUtil.GetDataTable(EDataTable.AiWeaponSocket);
		if (dataTable == null)
		{
			return new Dictionary<int, SAiWeaponSocket>();
		}
		List<DataTableKeyRow<SAiWeaponSocket>> list = new List<DataTableKeyRow<SAiWeaponSocket>>();
		DataTableUtil.GetDataTableAllRowWithKeysFromTable<SAiWeaponSocket>(dataTable, list);
		Dictionary<int, SAiWeaponSocket> dictionary = new Dictionary<int, SAiWeaponSocket>(list.Count);
		foreach (DataTableKeyRow<SAiWeaponSocket> dataTableKeyRow in list)
		{
			dictionary[int.Parse(dataTableKeyRow.Key)] = dataTableKeyRow.Value;
		}
		return dictionary;
	}

	// Token: 0x0601B33F RID: 111423 RVA: 0x0085A5B8 File Offset: 0x008587B8
	public static void CreateStaticDefaultValue()
	{
		DataTableUtil._dataTableCacheMap = new Dictionary<EDataTable, UDataTable>();
	}

	// Token: 0x0601B340 RID: 111424 RVA: 0x0085A5C4 File Offset: 0x008587C4
	public static void ResetStaticDefaultValue()
	{
		DataTableUtil._dataTableCacheMap = null;
	}

	// Token: 0x0400EC4E RID: 60494
	public static readonly IReadOnlyDictionary<EDataTable, string> dataTablePaths;

	// Token: 0x0400EC4F RID: 60495
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EDataTable, UDataTable> _dataTableCacheMap;
}
