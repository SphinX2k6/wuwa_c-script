using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;

// Token: 0x02001A86 RID: 6790
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhotographModel : ModelBase
{
	// Token: 0x06010CCA RID: 68810 RVA: 0x004ED415 File Offset: 0x004EB615
	protected override bool OnInit()
	{
		this.SavePath = ConfigCommonParamById.GetStringConfig("ScreenShotSavePath");
		return true;
	}

	// Token: 0x06010CCB RID: 68811 RVA: 0x004ED428 File Offset: 0x004EB628
	protected override bool OnClear()
	{
		this.DestroyUiCamera();
		return true;
	}

	// Token: 0x06010CCC RID: 68812 RVA: 0x004ED431 File Offset: 0x004EB631
	protected override bool OnLeaveLevel()
	{
		this.DestroyUiCamera();
		return true;
	}

	// Token: 0x06010CCD RID: 68813 RVA: 0x004ED43C File Offset: 0x004EB63C
	public UiCameraPhotographerComponent SpawnPhotographerComponent(FVectorDouble playerLocation, FQuat rotation, FVectorDouble scale, FVectorDouble cameraLocation)
	{
		this.SpawnTransformCache.SetLocation(playerLocation);
		this.SpawnTransformCache.SetRotation(rotation);
		this.SpawnTransformCache.SetScale3D(scale);
		UiCameraModel instance = UiCameraModel.Instance;
		instance.SwitchMode(EUiCameraMode.Photographer);
		this.PhotographerComponent = instance.GetOrCreateCamera().GetMode<UiCameraPhotographerMode>().GetComponent<UiCameraPhotographerComponent>();
		this.PhotographerComponent.SetActorTransform(this.SpawnTransformCache);
		if (PhotographController.Instance.CheckIfInFightPhotographCamera())
		{
			this.PhotographerComponent.SetCameraArmTargetOffset(cameraLocation, true);
		}
		instance.GetOrCreateCamera().GetUiCameraComponent<UiCameraDisplayComponent>().SetCameraFocalDistance(300f);
		return this.PhotographerComponent;
	}

	// Token: 0x06010CCE RID: 68814 RVA: 0x004ED4D9 File Offset: 0x004EB6D9
	public void DestroyUiCamera()
	{
		UiCameraModel.Instance.ClearDisplay();
		this.PhotographerComponent = null;
	}

	// Token: 0x06010CCF RID: 68815 RVA: 0x004ED4EC File Offset: 0x004EB6EC
	[NullableContext(2)]
	public UiCameraPhotographerComponent GetPhotographerComponent()
	{
		return this.PhotographerComponent;
	}

	// Token: 0x06010CD0 RID: 68816 RVA: 0x004ED4F4 File Offset: 0x004EB6F4
	public void SetPhotographOption(EPhotoSetupValueType valueType, float value)
	{
		if (this.PhotographOptionMap.ContainsKey(valueType))
		{
			this.PhotographOptionMap[valueType] = value;
			return;
		}
		this.PhotographOptionMap.Add(valueType, value);
	}

	// Token: 0x06010CD1 RID: 68817 RVA: 0x004ED51F File Offset: 0x004EB71F
	public void ClearPhotographOption()
	{
		this.PhotographOptionMap.Clear();
	}

	// Token: 0x06010CD2 RID: 68818 RVA: 0x004ED52C File Offset: 0x004EB72C
	public float? GetPhotographOption(EPhotoSetupValueType valueType)
	{
		float value;
		if (this.PhotographOptionMap.TryGetValue(valueType, out value))
		{
			return new float?(value);
		}
		return null;
	}

	// Token: 0x06010CD3 RID: 68819 RVA: 0x004ED559 File Offset: 0x004EB759
	public IReadOnlyDictionary<EPhotoSetupValueType, float> GetAllPhotographOption()
	{
		return this.PhotographOptionMap;
	}

	// Token: 0x06010CD4 RID: 68820 RVA: 0x004ED564 File Offset: 0x004EB764
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

	// Token: 0x06010CD5 RID: 68821 RVA: 0x004ED630 File Offset: 0x004EB830
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

	// Token: 0x06010CD6 RID: 68822 RVA: 0x004ED67F File Offset: 0x004EB87F
	public void SetPhotographFilter(int filterId)
	{
		this.FilterId = filterId;
	}

	// Token: 0x06010CD7 RID: 68823 RVA: 0x004ED688 File Offset: 0x004EB888
	public void ClearPhotographFilter()
	{
		this.ClearSelectedPhotographFilter();
		this.FilterStrengthMap.Clear();
		this.IsFilterToggleOpen = true;
	}

	// Token: 0x06010CD8 RID: 68824 RVA: 0x004ED6A2 File Offset: 0x004EB8A2
	public void ClearSelectedPhotographFilter()
	{
		this.FilterId = 0;
		PhotographController.Instance.InitPostProcessVolBlendWeight(1);
	}

	// Token: 0x06010CD9 RID: 68825 RVA: 0x004ED6B6 File Offset: 0x004EB8B6
	public int GetPhotographFilter()
	{
		return this.FilterId;
	}

	// Token: 0x06010CDA RID: 68826 RVA: 0x004ED6C0 File Offset: 0x004EB8C0
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

	// Token: 0x06010CDB RID: 68827 RVA: 0x004ED7A2 File Offset: 0x004EB9A2
	public Dictionary<string, APostProcessVolume> GetFilterPostProcessVolumeMap()
	{
		return this.PostProcessVolumeMap;
	}

	// Token: 0x06010CDC RID: 68828 RVA: 0x004ED7AC File Offset: 0x004EB9AC
	public float GetFilterStrengthByFilterId(int filterId)
	{
		float result;
		if (!this.FilterStrengthMap.TryGetValue(filterId, out result))
		{
			return 1f;
		}
		return result;
	}

	// Token: 0x06010CDD RID: 68829 RVA: 0x004ED7D0 File Offset: 0x004EB9D0
	public void SetFilterStrength(int filterId, float filterStrength)
	{
		if (this.FilterStrengthMap.ContainsKey(filterId))
		{
			this.FilterStrengthMap[filterId] = filterStrength;
			return;
		}
		this.FilterStrengthMap.Add(filterId, filterStrength);
	}

	// Token: 0x06010CDE RID: 68830 RVA: 0x004ED7FB File Offset: 0x004EB9FB
	public void SetFilterToggleState(bool isOpen)
	{
		this.IsFilterToggleOpen = isOpen;
	}

	// Token: 0x06010CDF RID: 68831 RVA: 0x004ED804 File Offset: 0x004EBA04
	public bool GetFilterToggleState()
	{
		return this.IsFilterToggleOpen;
	}

	// Token: 0x06010CE0 RID: 68832 RVA: 0x004ED80C File Offset: 0x004EBA0C
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

	// Token: 0x17001947 RID: 6471
	// (get) Token: 0x06010CE1 RID: 68833 RVA: 0x004ED881 File Offset: 0x004EBA81
	public static PhotographModel Instance
	{
		get
		{
			return PhotographModel._Instance;
		}
	}

	// Token: 0x06010CE2 RID: 68834 RVA: 0x004ED888 File Offset: 0x004EBA88
	public static PhotographModel GetOrCreateInstance()
	{
		if (PhotographModel._Instance == null)
		{
			PhotographModel.CreateInstance();
		}
		return PhotographModel._Instance;
	}

	// Token: 0x06010CE3 RID: 68835 RVA: 0x004ED89C File Offset: 0x004EBA9C
	public static bool CreateInstance()
	{
		if (PhotographModel._Instance != null)
		{
			return true;
		}
		PhotographModel._Instance = new PhotographModel();
		return true;
	}

	// Token: 0x06010CE4 RID: 68836 RVA: 0x004ED8B2 File Offset: 0x004EBAB2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010CE5 RID: 68837 RVA: 0x004ED8B4 File Offset: 0x004EBAB4
	public static void ResetStaticDefaultValue()
	{
		PhotographModel._Instance = null;
	}

	// Token: 0x06010CE6 RID: 68838 RVA: 0x004ED8BC File Offset: 0x004EBABC
	static PhotographModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographModel.CreateStaticDefaultValue), new Action(PhotographModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400947A RID: 38010
	[Nullable(2)]
	private UiCameraPhotographerComponent PhotographerComponent;

	// Token: 0x0400947B RID: 38011
	[Nullable(2)]
	public EntityHandle PlayMontageEntity;

	// Token: 0x0400947C RID: 38012
	public int MontageId;

	// Token: 0x0400947D RID: 38013
	public int FilterId;

	// Token: 0x0400947E RID: 38014
	private readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x0400947F RID: 38015
	private readonly Dictionary<string, APostProcessVolume> PostProcessVolumeMap = new Dictionary<string, APostProcessVolume>();

	// Token: 0x04009480 RID: 38016
	private readonly Dictionary<int, float> FilterStrengthMap = new Dictionary<int, float>();

	// Token: 0x04009481 RID: 38017
	private FTransformDouble SpawnTransformCache = new FTransformDouble();

	// Token: 0x04009482 RID: 38018
	public float RightValue;

	// Token: 0x04009483 RID: 38019
	public float UpValue;

	// Token: 0x04009484 RID: 38020
	public float ForwardValue;

	// Token: 0x04009485 RID: 38021
	private int? EntityDisableId = new int?(0);

	// Token: 0x04009486 RID: 38022
	[Nullable(2)]
	private EntityHandle SetDisableEntity;

	// Token: 0x04009487 RID: 38023
	public bool IsOpenPhotograph;

	// Token: 0x04009488 RID: 38024
	public string SavePath = "";

	// Token: 0x04009489 RID: 38025
	public bool IsSaveButtonVisible;

	// Token: 0x0400948A RID: 38026
	public bool IsFilterToggleOpen = true;

	// Token: 0x0400948B RID: 38027
	public int? PlayerActionSortId;

	// Token: 0x0400948C RID: 38028
	public Transform CameraTransformProxy = Transform.Create();

	// Token: 0x0400948D RID: 38029
	public HashSet<string> SequenceInValidSectionSet = new HashSet<string>();

	// Token: 0x0400948E RID: 38030
	public Dictionary<int, HashSet<string>> MontageTagSet = new Dictionary<int, HashSet<string>>();

	// Token: 0x0400948F RID: 38031
	public HashSet<int> NpcFaceSet = new HashSet<int>();

	// Token: 0x04009490 RID: 38032
	public double ChangeNpcFaceRangeSquared = 9000000.0;

	// Token: 0x04009491 RID: 38033
	[Nullable(2)]
	private static PhotographModel _Instance;
}
