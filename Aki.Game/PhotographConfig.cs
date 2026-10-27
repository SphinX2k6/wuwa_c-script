using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;

// Token: 0x02002580 RID: 9600
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PhotographConfig : ConfigBase
{
	// Token: 0x060136C6 RID: 79558 RVA: 0x004D69BE File Offset: 0x004D4BBE
	public PhotoMontage? GetPhotoMontageConfig(int montageId)
	{
		return ConfigPhotoMontageById.GetConfig(montageId, true);
	}

	// Token: 0x060136C7 RID: 79559 RVA: 0x004D69C7 File Offset: 0x004D4BC7
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigListBySkinIdAndMainAnim(int skinId, ERoleMainAnimInstanceType mainAnimInstanceType)
	{
		return ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.GetConfigList(skinId, (int)mainAnimInstanceType, true);
	}

	// Token: 0x060136C8 RID: 79560 RVA: 0x004D69D1 File Offset: 0x004D4BD1
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigListBySkinIdAndMorph(int skinId, EMorphType morphType)
	{
		return ConfigPhotoMontageBySkinIdAndMorph.GetConfigList(skinId, (int)morphType, true);
	}

	// Token: 0x060136C9 RID: 79561 RVA: 0x004D69DB File Offset: 0x004D4BDB
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigByRoleId(int roleId, int sort)
	{
		return ConfigPhotoMontageByRoleIdAndSort.GetConfigList(roleId, sort, true);
	}

	// Token: 0x060136CA RID: 79562 RVA: 0x004D69E5 File Offset: 0x004D4BE5
	public PhotoSetup? GetPhotoSetupConfig(EPhotoSetupValueType valueType)
	{
		return ConfigPhotoSetupByValueType.GetConfig((int)valueType, true);
	}

	// Token: 0x060136CB RID: 79563 RVA: 0x004D69EE File Offset: 0x004D4BEE
	public PhotoSetup? GetPhotoSetupConfigById(int id)
	{
		return ConfigPhotoSetupById.GetConfig(id, true);
	}

	// Token: 0x060136CC RID: 79564 RVA: 0x004D69F7 File Offset: 0x004D4BF7
	public IReadOnlyList<PhotoSetup> GetAllPhotoSetupConfig()
	{
		return ConfigPhotoSetupAll.GetConfigList(true);
	}

	// Token: 0x060136CD RID: 79565 RVA: 0x004D6A00 File Offset: 0x004D4C00
	[NullableContext(1)]
	public List<PhotoSetup> GetOldPhotoSetupConfigList()
	{
		List<PhotoSetup> list = new List<PhotoSetup>();
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("OldPhotoSetupList");
		if (intArrayConfig == null)
		{
			return list;
		}
		foreach (int id in intArrayConfig)
		{
			PhotoSetup? photoSetupConfigById = this.GetPhotoSetupConfigById(id);
			if (photoSetupConfigById != null)
			{
				list.Add(photoSetupConfigById.Value);
			}
		}
		return list;
	}

	// Token: 0x060136CE RID: 79566 RVA: 0x004D6A78 File Offset: 0x004D4C78
	public float GetDepthDistanceDefaultValue()
	{
		PhotoSetup? photoSetupConfig = this.GetPhotoSetupConfig(EPhotoSetupValueType.DepthOfFieldDistance);
		if (photoSetupConfig == null)
		{
			return 35f;
		}
		return photoSetupConfig.Value.ValueRange(2);
	}

	// Token: 0x060136CF RID: 79567 RVA: 0x004D6AAC File Offset: 0x004D4CAC
	public float GetDepthOfFieldRadiusDefaultValue()
	{
		PhotoSetup? photoSetupConfig = this.GetPhotoSetupConfig(EPhotoSetupValueType.DepthOfFieldRadius);
		if (photoSetupConfig == null)
		{
			return 0f;
		}
		return photoSetupConfig.Value.ValueRange(2);
	}

	// Token: 0x060136D0 RID: 79568 RVA: 0x004D6AE0 File Offset: 0x004D4CE0
	public IReadOnlyList<PhotoFilter> GetAllPhotoFilterConfig()
	{
		return ConfigPhotoFilterAll.GetConfigList(true);
	}

	// Token: 0x060136D1 RID: 79569 RVA: 0x004D6AE8 File Offset: 0x004D4CE8
	public PhotoFilter? GetPhotoFilterConfigById(int filterId)
	{
		return ConfigPhotoFilterById.GetConfig(filterId, true);
	}

	// Token: 0x060136D2 RID: 79570 RVA: 0x004D6AF1 File Offset: 0x004D4CF1
	public IReadOnlyList<FightPhotoOption> GetAllFightPhotoOptionConfig()
	{
		return ConfigFightPhotoOptionAll.GetConfigList(true);
	}

	// Token: 0x060136D3 RID: 79571 RVA: 0x004D6AFC File Offset: 0x004D4CFC
	[NullableContext(1)]
	[return: Nullable(2)]
	public SUiCameraFightPhotographSettings GetUiCameraFightPhotographConfig(string handleName)
	{
		SUiCameraFightPhotographSettings dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SUiCameraFightPhotographSettings>(EDataTable.FightPhotographCameraConfig, handleName);
		if (dataTableRowFromName == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FightPhotograph;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "在UiCameraFightPhotographSettings表里未找到对应数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handleName", handleName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return dataTableRowFromName;
	}

	// Token: 0x060136D4 RID: 79572 RVA: 0x004D6B48 File Offset: 0x004D4D48
	public IReadOnlyList<PhotoDropDown> GetPhotoDropDownDataList(EPhotoSetupValueType setupType)
	{
		return ConfigPhotoDropDownBySetupType.GetConfigList((int)setupType, true);
	}

	// Token: 0x060136D5 RID: 79573 RVA: 0x004D6B51 File Offset: 0x004D4D51
	public IReadOnlyList<PhotoTab> GetAllPhotoTabConfig()
	{
		return ConfigPhotoTabAll.GetConfigList(true);
	}

	// Token: 0x060136D6 RID: 79574 RVA: 0x004D6B59 File Offset: 0x004D4D59
	public PhotoTab? GetPhotoTabConfigById(int id)
	{
		return ConfigPhotoTabById.GetConfig(id, true);
	}

	// Token: 0x060136D7 RID: 79575 RVA: 0x004D6B62 File Offset: 0x004D4D62
	public PhotoTab? GetPhotoTabConfigByType(int type)
	{
		return ConfigPhotoTabByType.GetConfig(type, true);
	}

	// Token: 0x060136D8 RID: 79576 RVA: 0x004D6B6B File Offset: 0x004D4D6B
	public PhotoMode? GetPhotoModeConfigByType(int type)
	{
		return ConfigPhotoModeByType.GetConfig(type, true);
	}

	// Token: 0x060136D9 RID: 79577 RVA: 0x004D6B74 File Offset: 0x004D4D74
	public PhotoMode? GetPhotoModeConfigById(int id)
	{
		return ConfigPhotoModeById.GetConfig(id, true);
	}

	// Token: 0x060136DA RID: 79578 RVA: 0x004D6B80 File Offset: 0x004D4D80
	public int GetPhotoModeIdByType(PhotoCameraType type)
	{
		PhotoMode? photoModeConfigByType = this.GetPhotoModeConfigByType((int)type);
		if (photoModeConfigByType == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "PhotoMode表里找不到该相机模式类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type.ToString());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		return photoModeConfigByType.Value.Id;
	}

	// Token: 0x060136DB RID: 79579 RVA: 0x004D6BE8 File Offset: 0x004D4DE8
	public unsafe PhotoCameraType? GetPhotoModeTypeById(int id)
	{
		PhotoMode? photoModeConfigById = this.GetPhotoModeConfigById(id);
		if (photoModeConfigById == null)
		{
			return null;
		}
		int type = photoModeConfigById.Value.Type;
		if (type < 0 || type > 255 || !Enum.IsDefined(typeof(PhotoCameraType), (byte)type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "PhotoMode表配的模式类型不在枚举内";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", type);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new PhotoCameraType?((PhotoCameraType)type);
	}

	// Token: 0x060136DC RID: 79580 RVA: 0x004D6CB8 File Offset: 0x004D4EB8
	public bool IsTabBanned(PhotoCameraType mode, int tabId)
	{
		if (tabId <= 0)
		{
			return false;
		}
		PhotoMode? photoModeConfigByType = this.GetPhotoModeConfigByType((int)mode);
		if (photoModeConfigByType == null)
		{
			return false;
		}
		int banTabListLength = photoModeConfigByType.Value.BanTabListLength;
		for (int i = 0; i < banTabListLength; i++)
		{
			if (photoModeConfigByType.Value.BanTabList(i) == tabId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060136DD RID: 79581 RVA: 0x004D6D10 File Offset: 0x004D4F10
	public bool IsSubTabBanned(PhotoCameraType mode, int subTabId)
	{
		if (subTabId <= 0)
		{
			return false;
		}
		PhotoMode? photoModeConfigByType = this.GetPhotoModeConfigByType((int)mode);
		if (photoModeConfigByType == null)
		{
			return false;
		}
		int banSubTabListLength = photoModeConfigByType.Value.BanSubTabListLength;
		for (int i = 0; i < banSubTabListLength; i++)
		{
			if (photoModeConfigByType.Value.BanSubTabList(i) == subTabId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060136DE RID: 79582 RVA: 0x004D6D68 File Offset: 0x004D4F68
	public float GetModeCollisionRadius(PhotoCameraType mode, float baseRadius)
	{
		PhotoMode? photoModeConfigByType = this.GetPhotoModeConfigByType((int)mode);
		if (photoModeConfigByType == null)
		{
			return baseRadius;
		}
		if (photoModeConfigByType.Value.CollisionRadius > 0f)
		{
			return photoModeConfigByType.Value.CollisionRadius;
		}
		return baseRadius + photoModeConfigByType.Value.CollisionRadiusOffset;
	}

	// Token: 0x060136DF RID: 79583 RVA: 0x004D6DBF File Offset: 0x004D4FBF
	public IReadOnlyList<PhotoTemplate> GetPhotoTemplateListByGroupId(int groupId)
	{
		return ConfigPhotoTemplateByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x060136E0 RID: 79584 RVA: 0x004D6DC8 File Offset: 0x004D4FC8
	public IReadOnlyList<PhotoSubTab> GetAllPhotoSubTabConfig()
	{
		return ConfigPhotoSubTabAll.GetConfigList(true);
	}

	// Token: 0x060136E1 RID: 79585 RVA: 0x004D6DD0 File Offset: 0x004D4FD0
	public PhotoSubTab? GetPhotoSubTabConfigById(int id)
	{
		return ConfigPhotoSubTabById.GetConfig(id, true);
	}

	// Token: 0x060136E2 RID: 79586 RVA: 0x004D6DD9 File Offset: 0x004D4FD9
	public IReadOnlyList<FightPhotoTab> GetAllFightPhotoTabConfig()
	{
		return ConfigFightPhotoTabAll.GetConfigList(true);
	}

	// Token: 0x060136E3 RID: 79587 RVA: 0x004D6DE1 File Offset: 0x004D4FE1
	public FightPhotoTab? GetFightPhotoTabConfigById(int id)
	{
		return ConfigFightPhotoTabById.GetConfig(id, true);
	}

	// Token: 0x060136E4 RID: 79588 RVA: 0x004D6DEA File Offset: 0x004D4FEA
	public IReadOnlyList<FightPhotoSetup> GetAllFightPhotoSetupConfig()
	{
		return ConfigFightPhotoSetupAll.GetConfigList(true);
	}

	// Token: 0x060136E5 RID: 79589 RVA: 0x004D6DF2 File Offset: 0x004D4FF2
	public FightPhotoSetup? GetFightPhotoSetupConfigById(int id)
	{
		return ConfigFightPhotoSetupById.GetConfig(id, true);
	}

	// Token: 0x060136E6 RID: 79590 RVA: 0x004D6DFC File Offset: 0x004D4FFC
	public IReadOnlyList<FightPhotoFrameStyle> GetAllFightPhotoFrameStyleConfig()
	{
		IReadOnlyList<FightPhotoFrameStyle> configList = ConfigFightPhotoFrameStyleAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		List<FightPhotoFrameStyle> list = new List<FightPhotoFrameStyle>(configList);
		list.Sort(delegate(FightPhotoFrameStyle a, FightPhotoFrameStyle b)
		{
			if (a.SortId != b.SortId)
			{
				return a.SortId - b.SortId;
			}
			return a.Id - b.Id;
		});
		return list;
	}

	// Token: 0x060136E7 RID: 79591 RVA: 0x004D6E40 File Offset: 0x004D5040
	public FightPhotoFrameStyle? GetFightPhotoFrameStyleConfigById(int id)
	{
		return ConfigFightPhotoFrameStyleById.GetConfig(id, true);
	}

	// Token: 0x060136E8 RID: 79592 RVA: 0x004D6E4C File Offset: 0x004D504C
	[NullableContext(1)]
	public List<PhotoSelfieMontage> GetPhotoSelfieMontageListByGender(int gender)
	{
		IReadOnlyList<PhotoSelfieMontage> configList = ConfigPhotoSelfieMontageByGender.GetConfigList(gender, true);
		if (configList == null)
		{
			return new List<PhotoSelfieMontage>();
		}
		return new List<PhotoSelfieMontage>(configList);
	}

	// Token: 0x060136E9 RID: 79593 RVA: 0x004D6E70 File Offset: 0x004D5070
	[NullableContext(1)]
	public List<PhotoExpression> GetPhotoExpressionListByGender(int gender)
	{
		IReadOnlyList<PhotoExpression> configList = ConfigPhotoExpressionByGender.GetConfigList(gender, true);
		if (configList == null)
		{
			return new List<PhotoExpression>();
		}
		return new List<PhotoExpression>(configList);
	}

	// Token: 0x060136EA RID: 79594 RVA: 0x004D6E94 File Offset: 0x004D5094
	public PhotoLight? GetDefaultPhotoLight()
	{
		return ConfigPhotoLightById.GetConfig(1, true);
	}

	// Token: 0x1700190B RID: 6411
	// (get) Token: 0x060136EB RID: 79595 RVA: 0x004D6E9D File Offset: 0x004D509D
	[Nullable(1)]
	public static PhotographConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PhotographConfig._Instance;
		}
	}

	// Token: 0x060136EC RID: 79596 RVA: 0x004D6EA4 File Offset: 0x004D50A4
	[NullableContext(1)]
	public static PhotographConfig GetOrCreateInstance()
	{
		if (PhotographConfig._Instance == null)
		{
			PhotographConfig.CreateInstance();
		}
		return PhotographConfig._Instance;
	}

	// Token: 0x060136ED RID: 79597 RVA: 0x004D6EB8 File Offset: 0x004D50B8
	public static bool CreateInstance()
	{
		if (PhotographConfig._Instance != null)
		{
			return true;
		}
		PhotographConfig._Instance = new PhotographConfig();
		return true;
	}

	// Token: 0x060136EE RID: 79598 RVA: 0x004D6ECE File Offset: 0x004D50CE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060136EF RID: 79599 RVA: 0x004D6ED0 File Offset: 0x004D50D0
	public static void ResetStaticDefaultValue()
	{
		PhotographConfig._Instance = null;
	}

	// Token: 0x060136F0 RID: 79600 RVA: 0x004D6ED8 File Offset: 0x004D50D8
	static PhotographConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographConfig.CreateStaticDefaultValue), new Action(PhotographConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400924A RID: 37450
	private static PhotographConfig _Instance;
}
