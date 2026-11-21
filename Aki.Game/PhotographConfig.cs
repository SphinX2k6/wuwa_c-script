using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;

// Token: 0x02001A6B RID: 6763
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PhotographConfig : ConfigBase
{
	// Token: 0x06010BA7 RID: 68519 RVA: 0x004E53EA File Offset: 0x004E35EA
	public PhotoMontage? GetPhotoMontageConfig(int montageId)
	{
		return ConfigPhotoMontageById.GetConfig(montageId, true);
	}

	// Token: 0x06010BA8 RID: 68520 RVA: 0x004E53F3 File Offset: 0x004E35F3
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigListBySkinIdAndMainAnim(int skinId, ERoleMainAnimInstanceType mainAnimInstanceType)
	{
		return ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.GetConfigList(skinId, (int)mainAnimInstanceType, true);
	}

	// Token: 0x06010BA9 RID: 68521 RVA: 0x004E53FD File Offset: 0x004E35FD
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigListBySkinIdAndMorph(int skinId, EMorphType morphType)
	{
		return ConfigPhotoMontageBySkinIdAndMorph.GetConfigList(skinId, (int)morphType, true);
	}

	// Token: 0x06010BAA RID: 68522 RVA: 0x004E5407 File Offset: 0x004E3607
	public IReadOnlyList<PhotoMontage> GetPhotoMontageConfigByRoleId(int roleId, int sort)
	{
		return ConfigPhotoMontageByRoleIdAndSort.GetConfigList(roleId, sort, true);
	}

	// Token: 0x06010BAB RID: 68523 RVA: 0x004E5411 File Offset: 0x004E3611
	public PhotoSetup? GetPhotoSetupConfig(EPhotoSetupValueType valueType)
	{
		return ConfigPhotoSetupByValueType.GetConfig((int)valueType, true);
	}

	// Token: 0x06010BAC RID: 68524 RVA: 0x004E541A File Offset: 0x004E361A
	public PhotoSetup? GetPhotoSetupConfigById(int id)
	{
		return ConfigPhotoSetupById.GetConfig(id, true);
	}

	// Token: 0x06010BAD RID: 68525 RVA: 0x004E5423 File Offset: 0x004E3623
	public IReadOnlyList<PhotoSetup> GetAllPhotoSetupConfig()
	{
		return ConfigPhotoSetupAll.GetConfigList(true);
	}

	// Token: 0x06010BAE RID: 68526 RVA: 0x004E542C File Offset: 0x004E362C
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

	// Token: 0x06010BAF RID: 68527 RVA: 0x004E54A4 File Offset: 0x004E36A4
	public float GetDepthDistanceDefaultValue()
	{
		PhotoSetup? photoSetupConfig = this.GetPhotoSetupConfig(EPhotoSetupValueType.DepthOfFieldDistance);
		if (photoSetupConfig == null)
		{
			return 35f;
		}
		return photoSetupConfig.Value.ValueRange(2);
	}

	// Token: 0x06010BB0 RID: 68528 RVA: 0x004E54D8 File Offset: 0x004E36D8
	public float GetDepthOfFieldRadiusDefaultValue()
	{
		PhotoSetup? photoSetupConfig = this.GetPhotoSetupConfig(EPhotoSetupValueType.DepthOfFieldRadius);
		if (photoSetupConfig == null)
		{
			return 0f;
		}
		return photoSetupConfig.Value.ValueRange(2);
	}

	// Token: 0x06010BB1 RID: 68529 RVA: 0x004E550C File Offset: 0x004E370C
	public IReadOnlyList<PhotoFilter> GetAllPhotoFilterConfig()
	{
		return ConfigPhotoFilterAll.GetConfigList(true);
	}

	// Token: 0x06010BB2 RID: 68530 RVA: 0x004E5514 File Offset: 0x004E3714
	public PhotoFilter? GetPhotoFilterConfigById(int filterId)
	{
		return ConfigPhotoFilterById.GetConfig(filterId, true);
	}

	// Token: 0x06010BB3 RID: 68531 RVA: 0x004E551D File Offset: 0x004E371D
	public IReadOnlyList<FightPhotoOption> GetAllFightPhotoOptionConfig()
	{
		return ConfigFightPhotoOptionAll.GetConfigList(true);
	}

	// Token: 0x06010BB4 RID: 68532 RVA: 0x004E5528 File Offset: 0x004E3728
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

	// Token: 0x06010BB5 RID: 68533 RVA: 0x004E5574 File Offset: 0x004E3774
	public IReadOnlyList<PhotoDropDown> GetPhotoDropDownDataList(EPhotoSetupValueType setupType)
	{
		return ConfigPhotoDropDownBySetupType.GetConfigList((int)setupType, true);
	}

	// Token: 0x06010BB6 RID: 68534 RVA: 0x004E557D File Offset: 0x004E377D
	public IReadOnlyList<PhotoTab> GetAllPhotoTabConfig()
	{
		return ConfigPhotoTabAll.GetConfigList(true);
	}

	// Token: 0x06010BB7 RID: 68535 RVA: 0x004E5585 File Offset: 0x004E3785
	public PhotoTab? GetPhotoTabConfigById(int id)
	{
		return ConfigPhotoTabById.GetConfig(id, true);
	}

	// Token: 0x06010BB8 RID: 68536 RVA: 0x004E558E File Offset: 0x004E378E
	public PhotoTab? GetPhotoTabConfigByType(int type)
	{
		return ConfigPhotoTabByType.GetConfig(type, true);
	}

	// Token: 0x06010BB9 RID: 68537 RVA: 0x004E5597 File Offset: 0x004E3797
	public PhotoMode? GetPhotoModeConfigByType(int type)
	{
		return ConfigPhotoModeByType.GetConfig(type, true);
	}

	// Token: 0x06010BBA RID: 68538 RVA: 0x004E55A0 File Offset: 0x004E37A0
	public PhotoMode? GetPhotoModeConfigById(int id)
	{
		return ConfigPhotoModeById.GetConfig(id, true);
	}

	// Token: 0x06010BBB RID: 68539 RVA: 0x004E55AC File Offset: 0x004E37AC
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

	// Token: 0x06010BBC RID: 68540 RVA: 0x004E5614 File Offset: 0x004E3814
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

	// Token: 0x06010BBD RID: 68541 RVA: 0x004E56E4 File Offset: 0x004E38E4
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

	// Token: 0x06010BBE RID: 68542 RVA: 0x004E573C File Offset: 0x004E393C
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

	// Token: 0x06010BBF RID: 68543 RVA: 0x004E5794 File Offset: 0x004E3994
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

	// Token: 0x06010BC0 RID: 68544 RVA: 0x004E57EB File Offset: 0x004E39EB
	public IReadOnlyList<PhotoTemplate> GetPhotoTemplateListByGroupId(int groupId)
	{
		return ConfigPhotoTemplateByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06010BC1 RID: 68545 RVA: 0x004E57F4 File Offset: 0x004E39F4
	public IReadOnlyList<PhotoSubTab> GetAllPhotoSubTabConfig()
	{
		return ConfigPhotoSubTabAll.GetConfigList(true);
	}

	// Token: 0x06010BC2 RID: 68546 RVA: 0x004E57FC File Offset: 0x004E39FC
	public PhotoSubTab? GetPhotoSubTabConfigById(int id)
	{
		return ConfigPhotoSubTabById.GetConfig(id, true);
	}

	// Token: 0x06010BC3 RID: 68547 RVA: 0x004E5805 File Offset: 0x004E3A05
	public IReadOnlyList<FightPhotoTab> GetAllFightPhotoTabConfig()
	{
		return ConfigFightPhotoTabAll.GetConfigList(true);
	}

	// Token: 0x06010BC4 RID: 68548 RVA: 0x004E580D File Offset: 0x004E3A0D
	public FightPhotoTab? GetFightPhotoTabConfigById(int id)
	{
		return ConfigFightPhotoTabById.GetConfig(id, true);
	}

	// Token: 0x06010BC5 RID: 68549 RVA: 0x004E5816 File Offset: 0x004E3A16
	public IReadOnlyList<FightPhotoSetup> GetAllFightPhotoSetupConfig()
	{
		return ConfigFightPhotoSetupAll.GetConfigList(true);
	}

	// Token: 0x06010BC6 RID: 68550 RVA: 0x004E581E File Offset: 0x004E3A1E
	public FightPhotoSetup? GetFightPhotoSetupConfigById(int id)
	{
		return ConfigFightPhotoSetupById.GetConfig(id, true);
	}

	// Token: 0x06010BC7 RID: 68551 RVA: 0x004E5828 File Offset: 0x004E3A28
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

	// Token: 0x06010BC8 RID: 68552 RVA: 0x004E586C File Offset: 0x004E3A6C
	public FightPhotoFrameStyle? GetFightPhotoFrameStyleConfigById(int id)
	{
		return ConfigFightPhotoFrameStyleById.GetConfig(id, true);
	}

	// Token: 0x06010BC9 RID: 68553 RVA: 0x004E5878 File Offset: 0x004E3A78
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

	// Token: 0x06010BCA RID: 68554 RVA: 0x004E589C File Offset: 0x004E3A9C
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

	// Token: 0x06010BCB RID: 68555 RVA: 0x004E58C0 File Offset: 0x004E3AC0
	public PhotoLight? GetDefaultPhotoLight()
	{
		return ConfigPhotoLightById.GetConfig(1, true);
	}

	// Token: 0x17001945 RID: 6469
	// (get) Token: 0x06010BCC RID: 68556 RVA: 0x004E58C9 File Offset: 0x004E3AC9
	[Nullable(1)]
	public static PhotographConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PhotographConfig._Instance;
		}
	}

	// Token: 0x06010BCD RID: 68557 RVA: 0x004E58D0 File Offset: 0x004E3AD0
	[NullableContext(1)]
	public static PhotographConfig GetOrCreateInstance()
	{
		if (PhotographConfig._Instance == null)
		{
			PhotographConfig.CreateInstance();
		}
		return PhotographConfig._Instance;
	}

	// Token: 0x06010BCE RID: 68558 RVA: 0x004E58E4 File Offset: 0x004E3AE4
	public static bool CreateInstance()
	{
		if (PhotographConfig._Instance != null)
		{
			return true;
		}
		PhotographConfig._Instance = new PhotographConfig();
		return true;
	}

	// Token: 0x06010BCF RID: 68559 RVA: 0x004E58FA File Offset: 0x004E3AFA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010BD0 RID: 68560 RVA: 0x004E58FC File Offset: 0x004E3AFC
	public static void ResetStaticDefaultValue()
	{
		PhotographConfig._Instance = null;
	}

	// Token: 0x06010BD1 RID: 68561 RVA: 0x004E5904 File Offset: 0x004E3B04
	static PhotographConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographConfig.CreateStaticDefaultValue), new Action(PhotographConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040093A2 RID: 37794
	private static PhotographConfig _Instance;
}
