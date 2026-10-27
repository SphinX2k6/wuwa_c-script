using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x020034B5 RID: 13493
[NullableContext(1)]
[Nullable(0)]
public class DataTableUtil : IStaticVariableResetter
{
	// Token: 0x0601D62F RID: 120367 RVA: 0x008329DC File Offset: 0x00830BDC
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

	// Token: 0x0601D630 RID: 120368 RVA: 0x00832B9C File Offset: 0x00830D9C
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

	// Token: 0x0601D631 RID: 120369 RVA: 0x00832BF0 File Offset: 0x00830DF0
	[NullableContext(0)]
	public static bool TryGetDataTableRowStruct<[IsUnmanaged] T>(EDataTable dtEnum, [Nullable(1)] string rowName, out T? value) where T : struct, ValueType, IUnrealScriptStruct
	{
		return DataTableUtil.TryGetDataTableRowStruct<T>(DataTableUtil.GetDataTable(dtEnum), rowName, out value);
	}

	// Token: 0x0601D632 RID: 120370 RVA: 0x00832C00 File Offset: 0x00830E00
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

	// Token: 0x0601D633 RID: 120371 RVA: 0x00832C64 File Offset: 0x00830E64
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

	// Token: 0x170028BE RID: 10430
	// (get) Token: 0x0601D634 RID: 120372 RVA: 0x00832CC2 File Offset: 0x00830EC2
	private static Dictionary<EDataTable, UDataTable> DataTableCacheMap
	{
		get
		{
			return DataTableUtil._dataTableCacheMap;
		}
	}

	// Token: 0x0601D635 RID: 120373 RVA: 0x00832CC9 File Offset: 0x00830EC9
	private static T CreateDataTableRowReference<[Nullable(0)] T>(IntPtr rowPtr, UDataTable table) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		return (T)((object)IUnrealScriptStructProxy.CreateReferenceFromPointer(rowPtr, table));
	}

	// Token: 0x0601D636 RID: 120374 RVA: 0x00832CE0 File Offset: 0x00830EE0
	private static bool TryGetDataTableAllRowsWithKeys(UDataTable table, out TArray<FName> rowNames, out IntPtr[] rows)
	{
		rowNames = new TArray<FName>();
		IntPtr nativePtr = rowNames.NativePtr;
		rows = Array.Empty<IntPtr>();
		FKuroDataTableFunctionLibrary.GetDataTableAllRowWithKeys(table, ref nativePtr, ref rows);
		return nativePtr != IntPtr.Zero && rows.Length != 0 && rowNames.Num() == rows.Length;
	}

	// Token: 0x0601D637 RID: 120375 RVA: 0x00832D28 File Offset: 0x00830F28
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

	// Token: 0x0601D638 RID: 120376 RVA: 0x00832DD0 File Offset: 0x00830FD0
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

	// Token: 0x0601D639 RID: 120377 RVA: 0x00832E04 File Offset: 0x00831004
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

	// Token: 0x0601D63A RID: 120378 RVA: 0x00832E78 File Offset: 0x00831078
	public static List<T> GetDataTableAllRow<[Nullable(0)] T>(EDataTable dtEnum) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		return DataTableUtil.GetDataTableAllRowFromTable<T>(DataTableUtil.GetDataTable(dtEnum));
	}

	// Token: 0x0601D63B RID: 120379 RVA: 0x00832E88 File Offset: 0x00831088
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

	// Token: 0x0601D63C RID: 120380 RVA: 0x00832F70 File Offset: 0x00831170
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

	// Token: 0x0601D63D RID: 120381 RVA: 0x0083305C File Offset: 0x0083125C
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

	// Token: 0x0601D63E RID: 120382 RVA: 0x008330D4 File Offset: 0x008312D4
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

	// Token: 0x0601D63F RID: 120383 RVA: 0x0083310C File Offset: 0x0083130C
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

	// Token: 0x0601D640 RID: 120384 RVA: 0x00833198 File Offset: 0x00831398
	public static void CreateStaticDefaultValue()
	{
		DataTableUtil._dataTableCacheMap = new Dictionary<EDataTable, UDataTable>();
	}

	// Token: 0x0601D641 RID: 120385 RVA: 0x008331A4 File Offset: 0x008313A4
	public static void ResetStaticDefaultValue()
	{
		DataTableUtil._dataTableCacheMap = null;
	}

	// Token: 0x0400E79A RID: 59290
	public static readonly IReadOnlyDictionary<EDataTable, string> dataTablePaths;

	// Token: 0x0400E79B RID: 59291
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EDataTable, UDataTable> _dataTableCacheMap;
}
