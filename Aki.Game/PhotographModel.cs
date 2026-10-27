using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200259B RID: 9627
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhotographModel : ModelBase
{
	// Token: 0x060137E8 RID: 79848 RVA: 0x004DE8F1 File Offset: 0x004DCAF1
	protected override bool OnInit()
	{
		this.SavePath = ConfigCommonParamById.GetStringConfig("ScreenShotSavePath");
		return true;
	}

	// Token: 0x060137E9 RID: 79849 RVA: 0x004DE904 File Offset: 0x004DCB04
	protected override bool OnClear()
	{
		this.DestroyUiCamera();
		return true;
	}

	// Token: 0x060137EA RID: 79850 RVA: 0x004DE90D File Offset: 0x004DCB0D
	protected override bool OnLeaveLevel()
	{
		this.DestroyUiCamera();
		return true;
	}

	// Token: 0x060137EB RID: 79851 RVA: 0x004DE918 File Offset: 0x004DCB18
	public UiCameraPhotographerStructure SpawnPhotographerStructure(FVectorDouble playerLocation, FQuat rotation, FVectorDouble scale, FVectorDouble cameraLocation)
	{
		this.SpawnTransformCache.SetLocation(playerLocation);
		this.SpawnTransformCache.SetRotation(rotation);
		this.SpawnTransformCache.SetScale3D(scale);
		UiCamera uiCamera = UiCameraManager.Get();
		this.UiCameraPhotographerStructure = uiCamera.PushStructure<UiCameraPhotographerStructure>();
		this.UiCameraPhotographerStructure.SetActorTransform(this.SpawnTransformCache);
		if (PhotographController.Instance.CheckIfInFightPhotographCamera())
		{
			this.UiCameraPhotographerStructure.SetCameraArmTargetOffset(cameraLocation, true);
		}
		uiCamera.GetUiCameraComponent<UiCameraPostEffectComponent>().SetCameraFocalDistance(300f);
		return this.UiCameraPhotographerStructure;
	}

	// Token: 0x060137EC RID: 79852 RVA: 0x004DE99F File Offset: 0x004DCB9F
	public void DestroyUiCamera()
	{
		UiCameraManager.Destroy(0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		this.UiCameraPhotographerStructure = null;
	}

	// Token: 0x060137ED RID: 79853 RVA: 0x004DE9B8 File Offset: 0x004DCBB8
	[NullableContext(2)]
	public UiCameraPhotographerStructure GetPhotographerStructure()
	{
		return this.UiCameraPhotographerStructure;
	}

	// Token: 0x060137EE RID: 79854 RVA: 0x004DE9C0 File Offset: 0x004DCBC0
	public void SetPhotographOption(EPhotoSetupValueType valueType, float value)
	{
		if (this.PhotographOptionMap.ContainsKey(valueType))
		{
			this.PhotographOptionMap[valueType] = value;
			return;
		}
		this.PhotographOptionMap.Add(valueType, value);
	}

	// Token: 0x060137EF RID: 79855 RVA: 0x004DE9EB File Offset: 0x004DCBEB
	public void ClearPhotographOption()
	{
		this.PhotographOptionMap.Clear();
	}

	// Token: 0x060137F0 RID: 79856 RVA: 0x004DE9F8 File Offset: 0x004DCBF8
	public float? GetPhotographOption(EPhotoSetupValueType valueType)
	{
		float value;
		if (this.PhotographOptionMap.TryGetValue(valueType, out value))
		{
			return new float?(value);
		}
		return null;
	}

	// Token: 0x060137F1 RID: 79857 RVA: 0x004DEA25 File Offset: 0x004DCC25
	public IReadOnlyDictionary<EPhotoSetupValueType, float> GetAllPhotographOption()
	{
		return this.PhotographOptionMap;
	}

	// Token: 0x060137F2 RID: 79858 RVA: 0x004DEA30 File Offset: 0x004DCC30
	public void SetEntityEnable(EntityHandle handle, bool bEnable)
	{
		if (handle == null || !handle.Valid || handle.Entity == null || !handle.Entity.Valid)
		{
			return;
		}
		if (handle.Entity.Active == bEnable)
		{
			return;
		}
		if (!bEnable)
		{
			if (this.SetDisableEntity != null)
			{
				this.ResetEntityEnable();
			}
			this.MontageId = 0;
			this.SetDisableEntity = handle;
			this.EntityDisableId = new int?(handle.Entity.Disable("[PhotographModel.SetEntityEnable] bEnable为false"));
			return;
		}
		if (this.SetDisableEntity != null && handle.Id == this.SetDisableEntity.Id)
		{
			handle.Entity.Enable(this.EntityDisableId.Value, "PhotographModel.SetEntityEnable");
			this.EntityDisableId = null;
			this.SetDisableEntity = null;
			return;
		}
		this.ResetEntityEnable();
	}

	// Token: 0x060137F3 RID: 79859 RVA: 0x004DEAFC File Offset: 0x004DCCFC
	public void ResetEntityEnable()
	{
		if (this.SetDisableEntity != null)
		{
			WorldEntity entity = this.SetDisableEntity.Entity;
			if (entity != null)
			{
				entity.Enable(this.EntityDisableId.Value, "PhotographModel.ResetEntityEnable");
			}
		}
		this.EntityDisableId = null;
		this.SetDisableEntity = null;
	}

	// Token: 0x060137F4 RID: 79860 RVA: 0x004DEB4B File Offset: 0x004DCD4B
	public void SetPhotographFilter(int filterId)
	{
		this.FilterId = filterId;
	}

	// Token: 0x060137F5 RID: 79861 RVA: 0x004DEB54 File Offset: 0x004DCD54
	public void ClearPhotographFilter()
	{
		this.ClearSelectedPhotographFilter();
		this.FilterStrengthMap.Clear();
		this.IsFilterToggleOpen = true;
	}

	// Token: 0x060137F6 RID: 79862 RVA: 0x004DEB6E File Offset: 0x004DCD6E
	public void ClearSelectedPhotographFilter()
	{
		this.FilterId = 0;
		PhotographController.Instance.InitPostProcessVolBlendWeight(1);
	}

	// Token: 0x060137F7 RID: 79863 RVA: 0x004DEB82 File Offset: 0x004DCD82
	public int GetPhotographFilter()
	{
		return this.FilterId;
	}

	// Token: 0x060137F8 RID: 79864 RVA: 0x004DEB8C File Offset: 0x004DCD8C
	public void InitFilterPostProcessVolume()
	{
		string key = "Filter";
		TArray<AActor> tarray = new TArray<AActor>();
		UGameplayStatics.GetAllActorsOfClassWithTag(GlobalData.World, APostProcessVolume.StaticClass(), FNameUtil.GetDynamicFName(key).Value, ref tarray);
		if (tarray == null || tarray.Num() <= 0)
		{
			return;
		}
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			APostProcessVolume apostProcessVolume = tarray.Get(i) as APostProcessVolume;
			if (apostProcessVolume != null)
			{
				apostProcessVolume.BlendWeight = 0f;
				if (apostProcessVolume.Tags.Num() >= 2)
				{
					string key2 = apostProcessVolume.Tags.Get(1).ToString();
					if (this.PostProcessVolumeMap.ContainsKey(key2))
					{
						this.PostProcessVolumeMap[key2] = apostProcessVolume;
					}
					else
					{
						this.PostProcessVolumeMap.Add(key2, apostProcessVolume);
					}
				}
			}
		}
	}

	// Token: 0x060137F9 RID: 79865 RVA: 0x004DEC6E File Offset: 0x004DCE6E
	public Dictionary<string, APostProcessVolume> GetFilterPostProcessVolumeMap()
	{
		return this.PostProcessVolumeMap;
	}

	// Token: 0x060137FA RID: 79866 RVA: 0x004DEC78 File Offset: 0x004DCE78
	public float GetFilterStrengthByFilterId(int filterId)
	{
		float result;
		if (!this.FilterStrengthMap.TryGetValue(filterId, out result))
		{
			return 1f;
		}
		return result;
	}

	// Token: 0x060137FB RID: 79867 RVA: 0x004DEC9C File Offset: 0x004DCE9C
	public void SetFilterStrength(int filterId, float filterStrength)
	{
		if (this.FilterStrengthMap.ContainsKey(filterId))
		{
			this.FilterStrengthMap[filterId] = filterStrength;
			return;
		}
		this.FilterStrengthMap.Add(filterId, filterStrength);
	}

	// Token: 0x060137FC RID: 79868 RVA: 0x004DECC7 File Offset: 0x004DCEC7
	public void SetFilterToggleState(bool isOpen)
	{
		this.IsFilterToggleOpen = isOpen;
	}

	// Token: 0x060137FD RID: 79869 RVA: 0x004DECD0 File Offset: 0x004DCED0
	public bool GetFilterToggleState()
	{
		return this.IsFilterToggleOpen;
	}

	// Token: 0x060137FE RID: 79870 RVA: 0x004DECD8 File Offset: 0x004DCED8
	public void SetPhotographTimeDilation(float timeDilation)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Photograph;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "SetPhotographTimeDilation";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("timeDilation", timeDilation);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (timeDilation != 1f)
		{
			AudioSystem.Instance.SetState("game_sys_fightphoto", "slow", true);
			AudioSystem.Instance.PostEvent("play_ui_battlephoto_timestop");
		}
		GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Photograph);
	}

	// Token: 0x1700190D RID: 6413
	// (get) Token: 0x060137FF RID: 79871 RVA: 0x004DED4D File Offset: 0x004DCF4D
	public static PhotographModel Instance
	{
		get
		{
			return PhotographModel._Instance;
		}
	}

	// Token: 0x06013800 RID: 79872 RVA: 0x004DED54 File Offset: 0x004DCF54
	public static PhotographModel GetOrCreateInstance()
	{
		if (PhotographModel._Instance == null)
		{
			PhotographModel.CreateInstance();
		}
		return PhotographModel._Instance;
	}

	// Token: 0x06013801 RID: 79873 RVA: 0x004DED68 File Offset: 0x004DCF68
	public static bool CreateInstance()
	{
		if (PhotographModel._Instance != null)
		{
			return true;
		}
		PhotographModel._Instance = new PhotographModel();
		return true;
	}

	// Token: 0x06013802 RID: 79874 RVA: 0x004DED7E File Offset: 0x004DCF7E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013803 RID: 79875 RVA: 0x004DED80 File Offset: 0x004DCF80
	public static void ResetStaticDefaultValue()
	{
		PhotographModel._Instance = null;
	}

	// Token: 0x06013804 RID: 79876 RVA: 0x004DED88 File Offset: 0x004DCF88
	static PhotographModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographModel.CreateStaticDefaultValue), new Action(PhotographModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009322 RID: 37666
	[Nullable(2)]
	private UiCameraPhotographerStructure UiCameraPhotographerStructure;

	// Token: 0x04009323 RID: 37667
	[Nullable(2)]
	public EntityHandle PlayMontageEntity;

	// Token: 0x04009324 RID: 37668
	public int MontageId;

	// Token: 0x04009325 RID: 37669
	public int FilterId;

	// Token: 0x04009326 RID: 37670
	private readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x04009327 RID: 37671
	private readonly Dictionary<string, APostProcessVolume> PostProcessVolumeMap = new Dictionary<string, APostProcessVolume>();

	// Token: 0x04009328 RID: 37672
	private readonly Dictionary<int, float> FilterStrengthMap = new Dictionary<int, float>();

	// Token: 0x04009329 RID: 37673
	private FTransformDouble SpawnTransformCache = new FTransformDouble();

	// Token: 0x0400932A RID: 37674
	public float RightValue;

	// Token: 0x0400932B RID: 37675
	public float UpValue;

	// Token: 0x0400932C RID: 37676
	public float ForwardValue;

	// Token: 0x0400932D RID: 37677
	private int? EntityDisableId = new int?(0);

	// Token: 0x0400932E RID: 37678
	[Nullable(2)]
	private EntityHandle SetDisableEntity;

	// Token: 0x0400932F RID: 37679
	public bool IsOpenPhotograph;

	// Token: 0x04009330 RID: 37680
	public string SavePath = "";

	// Token: 0x04009331 RID: 37681
	public bool IsSaveButtonVisible;

	// Token: 0x04009332 RID: 37682
	public bool IsFilterToggleOpen = true;

	// Token: 0x04009333 RID: 37683
	public int? PlayerActionSortId;

	// Token: 0x04009334 RID: 37684
	public Transform CameraTransformProxy = Transform.Create();

	// Token: 0x04009335 RID: 37685
	public HashSet<string> SequenceInValidSectionSet = new HashSet<string>();

	// Token: 0x04009336 RID: 37686
	public Dictionary<int, HashSet<string>> MontageTagSet = new Dictionary<int, HashSet<string>>();

	// Token: 0x04009337 RID: 37687
	public HashSet<int> NpcFaceSet = new HashSet<int>();

	// Token: 0x04009338 RID: 37688
	public double ChangeNpcFaceRangeSquared = 9000000.0;

	// Token: 0x04009339 RID: 37689
	[Nullable(2)]
	private static PhotographModel _Instance;
}
