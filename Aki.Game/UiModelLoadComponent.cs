using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x020021E4 RID: 8676
[NullableContext(1)]
[Nullable(0)]
public class UiModelLoadComponent : UiModelComponentBase
{
	// Token: 0x060155A2 RID: 87458 RVA: 0x00635408 File Offset: 0x00633608
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelMorphComponent = base.Owner.GetComponentByCtor<UiModelMorphComponent>();
	}

	// Token: 0x060155A3 RID: 87459 RVA: 0x0063543D File Offset: 0x0063363D
	protected override void OnEnd()
	{
		this.CancelLoad();
		this.DestroyLoadMesh();
		this.ReplaceEffectMap = null;
	}

	// Token: 0x060155A4 RID: 87460 RVA: 0x00635452 File Offset: 0x00633652
	protected string GetMainMeshPath()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).网格体.ToAssetPathName();
	}

	// Token: 0x060155A5 RID: 87461 RVA: 0x00635470 File Offset: 0x00633670
	[NullableContext(2)]
	protected string GetLevelMaterialDaPath()
	{
		FSoftObjectPath da = ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).DA;
		string text = (da != null) ? da.GetAssetPathString() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060155A6 RID: 87462 RVA: 0x006354AA File Offset: 0x006336AA
	protected virtual string GetAnimClassPath()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).动画蓝图.ToAssetPathName();
	}

	// Token: 0x060155A7 RID: 87463 RVA: 0x006354C8 File Offset: 0x006336C8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<string> GetChildMeshPathList()
	{
		TArray<SModelChildMeshConfig> ui用子网格体 = ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).UI用子网格体;
		if (ui用子网格体 != null)
		{
			int num = ui用子网格体.Num();
			if (num > 0)
			{
				List<string> list = new List<string>(num);
				for (int i = 0; i < num; i++)
				{
					list.Add(ui用子网格体.Get(i).SkeletalMesh.ToAssetPathName());
				}
				return list;
			}
		}
		return null;
	}

	// Token: 0x060155A8 RID: 87464 RVA: 0x00635526 File Offset: 0x00633726
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected virtual List<string> GetAllMorphPathList()
	{
		UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
		if (uiModelMorphComponent == null)
		{
			return null;
		}
		return uiModelMorphComponent.GetAllMorphPathList();
	}

	// Token: 0x060155A9 RID: 87465 RVA: 0x00635539 File Offset: 0x00633739
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<IUiMorphId> GetSpecialMorphIdList()
	{
		UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
		if (uiModelMorphComponent == null)
		{
			return null;
		}
		return uiModelMorphComponent.GetSpecialMorphIdList();
	}

	// Token: 0x060155AA RID: 87466 RVA: 0x0063554C File Offset: 0x0063374C
	protected TArray<SModelDecorationConfig> GetModelDecorationArray()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).UiModelDecorationArray;
	}

	// Token: 0x060155AB RID: 87467 RVA: 0x00635564 File Offset: 0x00633764
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<string> GetDecorationMeshPathList()
	{
		TArray<SModelDecorationConfig> modelDecorationArray = this.GetModelDecorationArray();
		if (modelDecorationArray == null)
		{
			return null;
		}
		int num = modelDecorationArray.Num();
		if (num <= 0)
		{
			return null;
		}
		List<string> list = new List<string>(num);
		for (int i = 0; i < num; i++)
		{
			list.Add(modelDecorationArray.Get(i).SkeletalMesh.ToAssetPathName());
		}
		return list;
	}

	// Token: 0x060155AC RID: 87468 RVA: 0x006355B5 File Offset: 0x006337B5
	[NullableContext(2)]
	public void LoadModelByModelId(int modelId, bool waitMeshStreaming = false, Action loadFinishCallBack = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> extraResourceList = null)
	{
		int modelConfigId = this.UiModelDataComponent.ModelConfigId;
		this.UiModelDataComponent.ModelConfigId = modelId;
		this.LoadFinishCallBack = loadFinishCallBack;
		this.LoadModel(waitMeshStreaming, extraResourceList, 0);
	}

	// Token: 0x060155AD RID: 87469 RVA: 0x006355E4 File Offset: 0x006337E4
	protected void LoadModel(bool waitMeshStreaming, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> extraResourceList = null, int levelOfDetail = 0)
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (uiModelDataComponent != null && uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.IsLoading)
		{
			this.CancelLoad();
			Log.Instance.Warn(ELogModule.Character, ELogAuthor.LZK, "取消上一个模型加载", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		if (uiModelDataComponent2 != null)
		{
			uiModelDataComponent2.ClearLoadingVisible();
		}
		if (waitMeshStreaming)
		{
			UiModelDataComponent uiModelDataComponent3 = this.UiModelDataComponent;
			if (uiModelDataComponent3 != null)
			{
				uiModelDataComponent3.SetVisible(false);
			}
		}
		UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
		if (uiModelMorphComponent != null)
		{
			uiModelMorphComponent.ClearData();
		}
		this.SetupReplaceEffectFromModelConfig();
		UiModelDataComponent uiModelDataComponent4 = this.UiModelDataComponent;
		if (uiModelDataComponent4 != null)
		{
			uiModelDataComponent4.SetModelLoadState(EUiModelLoadState.IsLoading);
		}
		string animClassPath = this.GetAnimClassPath();
		if (!StringUtils.IsEmpty(animClassPath))
		{
			this.LoadAnimClassHandle = ResourceSystem.Instance.LoadAsync<UClass>(animClassPath, delegate([Nullable(2)] UClass asset, string path)
			{
				this.LoadAnimClassHandle = -1;
				this.OnPostLoadAnimClass(asset, path, waitMeshStreaming, extraResourceList, levelOfDetail);
			}, 100, "js_undefined");
			return;
		}
		this.OnPostLoadAnimClass(null, animClassPath, waitMeshStreaming, extraResourceList, levelOfDetail);
	}

	// Token: 0x060155AE RID: 87470 RVA: 0x006356F0 File Offset: 0x006338F0
	protected void OnPostLoadAnimClass([Nullable(2)] UClass asset, string path, bool waitMeshStreaming, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> extraResourceList = null, int levelOfDetail = 0)
	{
		string mainMeshPath = this.GetMainMeshPath();
		string levelMaterialDaPath = this.GetLevelMaterialDaPath();
		List<string> childMeshPathList = this.GetChildMeshPathList();
		List<string> allMorphPathList = this.GetAllMorphPathList();
		List<string> effectAssetByAssetClass = this.GetEffectAssetByAssetClass(asset);
		List<string> decorationMeshPathList = this.GetDecorationMeshPathList();
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(mainMeshPath))
		{
			list.Add(mainMeshPath);
		}
		UiModelUtil.Instance.CheckPathListAndAdd(list, childMeshPathList);
		UiModelUtil.Instance.CheckPathListAndAdd(list, allMorphPathList);
		UiModelUtil.Instance.CheckPathListAndAdd(list, extraResourceList);
		UiModelUtil.Instance.CheckPathListAndAdd(list, effectAssetByAssetClass);
		UiModelUtil.Instance.CheckPathListAndAdd(list, decorationMeshPathList);
		if (!string.IsNullOrEmpty(levelMaterialDaPath))
		{
			list.Add(levelMaterialDaPath);
		}
		Action <>9__1;
		this.LoadHandleId = UiModelResourcesManager.Instance.LoadUiModelResources(list, delegate(EUiRoleLoadResult result, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, UObject> resultMap)
		{
			this.DestroyLoadMesh();
			this.ResourceLoadCache = resultMap;
			TArray<USkeletalMesh> tarray = new TArray<USkeletalMesh>();
			USkeletalMesh uskeletalMesh = this.GetLoadedResource(mainMeshPath) as USkeletalMesh;
			tarray.Add(uskeletalMesh);
			List<USkeletalMesh> list2 = null;
			if (childMeshPathList != null)
			{
				list2 = new List<USkeletalMesh>();
				foreach (string path2 in childMeshPathList)
				{
					USkeletalMesh uskeletalMesh2 = this.GetLoadedResource(path2) as USkeletalMesh;
					list2.Add(uskeletalMesh2);
					tarray.Add(uskeletalMesh2);
				}
			}
			TArray<SModelDecorationConfig> modelDecorationArray = this.GetModelDecorationArray();
			List<UiModelDecorationParam> modelMeshDecorationList = this.GetModelMeshDecorationList(modelDecorationArray);
			foreach (UiModelDecorationParam uiModelDecorationParam in modelMeshDecorationList)
			{
				tarray.Add(uiModelDecorationParam.SkeletalMesh);
			}
			USkeletalMesh uskeletalMesh3 = null;
			UClass uclass = null;
			List<USkeletalMesh> list3 = new List<USkeletalMesh>();
			List<IUiMorphId> specialMorphIdList = this.GetSpecialMorphIdList();
			List<UiModelDecorationParam> list4 = new List<UiModelDecorationParam>();
			if (specialMorphIdList != null)
			{
				foreach (IUiMorphId uiMorphId in specialMorphIdList)
				{
					if (!string.IsNullOrEmpty(uiMorphId.MainMeshPath))
					{
						USkeletalMesh uskeletalMesh4 = this.GetLoadedResource(uiMorphId.MainMeshPath) as USkeletalMesh;
						tarray.Add(uskeletalMesh4);
						uskeletalMesh3 = uskeletalMesh4;
					}
					if (!string.IsNullOrEmpty(uiMorphId.AnimPath))
					{
						uclass = (this.GetLoadedResource(uiMorphId.AnimPath) as UClass);
					}
					if (uiMorphId.ChildMeshPathList != null)
					{
						foreach (string path3 in uiMorphId.ChildMeshPathList)
						{
							USkeletalMesh uskeletalMesh5 = this.GetLoadedResource(path3) as USkeletalMesh;
							tarray.Add(uskeletalMesh5);
							list3.Add(uskeletalMesh5);
						}
					}
					if (uiMorphId.DecorationMeshConfigArray != null)
					{
						foreach (UiModelDecorationParam uiModelDecorationParam2 in this.GetModelMeshDecorationList(uiMorphId.DecorationMeshConfigArray))
						{
							tarray.Add(uiModelDecorationParam2.SkeletalMesh);
							list4.Add(uiModelDecorationParam2);
						}
					}
				}
			}
			UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
			if (uiModelMorphComponent != null && uiModelMorphComponent.GetMorphType() != EUiModelMorphType.默认形态)
			{
				if (uskeletalMesh3 == null)
				{
					Log.Instance.Error(ELogModule.Character, ELogAuthor.LRC, "形态mainMesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				if (uclass == null)
				{
					Log.Instance.Error(ELogModule.Character, ELogAuthor.LRC, "形态animClass为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
				if (uiModelActorComponent != null)
				{
					uiModelActorComponent.ChangeMesh(uskeletalMesh3, uclass, list3, list4, levelOfDetail);
				}
			}
			else
			{
				UiModelActorComponent uiModelActorComponent2 = this.UiModelActorComponent;
				if (uiModelActorComponent2 != null)
				{
					uiModelActorComponent2.ChangeMesh(uskeletalMesh, asset, list2, modelMeshDecorationList, levelOfDetail);
				}
			}
			if (!waitMeshStreaming)
			{
				this.FinishLoad();
				this.MeshArray.Empty(true);
				return;
			}
			MeshStreamTaskContext meshStreamTaskContext = new MeshStreamTaskContext();
			meshStreamTaskContext.SkeletalMeshes = tarray;
			Action onTaskFinish;
			if ((onTaskFinish = <>9__1) == null)
			{
				onTaskFinish = (<>9__1 = delegate()
				{
					this.FinishLoad();
					UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
					bool valueOrDefault = ((uiModelDataComponent != null) ? uiModelDataComponent.GetLoadingVisible() : null).GetValueOrDefault(true);
					UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
					if (uiModelDataComponent2 != null)
					{
						uiModelDataComponent2.SetVisible(valueOrDefault);
					}
					UiModelDataComponent uiModelDataComponent3 = this.UiModelDataComponent;
					if (uiModelDataComponent3 == null)
					{
						return;
					}
					uiModelDataComponent3.ClearLoadingVisible();
				});
			}
			meshStreamTaskContext.OnTaskFinish = onTaskFinish;
			MeshStreamTaskContext context = meshStreamTaskContext;
			this.StreamingHandleId = MeshStreamController.Instance.AddMeshStreamTask(context);
		});
	}

	// Token: 0x060155AF RID: 87471 RVA: 0x006357F4 File Offset: 0x006339F4
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<string> GetEffectAssetByAssetClass(UClass asset)
	{
		if (asset == null)
		{
			return null;
		}
		this.AnimationAssetSet.Empty(0);
		TSubclassOf<UAnimInstance> tsubclassOf = asset;
		UKuroStaticLibrary.GetAnimAssetsByAnimBlueprintClass(tsubclassOf, ref this.AnimationAssetSet);
		if (this.AnimationAssetSet.Num() == 0)
		{
			return null;
		}
		List<string> list = new List<string>();
		int num = this.AnimationAssetSet.Num();
		for (int i = 0; i < num; i++)
		{
			UAnimSequence uanimSequence = this.AnimationAssetSet.GetElement(i) as UAnimSequence;
			if (uanimSequence != null)
			{
				this.AnimNotifyEvents.Empty(true);
				UKuroStaticLibrary.GetAnimSequenceNotifies(uanimSequence, ref this.AnimNotifyEvents);
				int num2 = this.AnimNotifyEvents.Num();
				if (num2 != 0)
				{
					for (int j = 0; j < num2; j++)
					{
						FAnimNotifyEvent fanimNotifyEvent = this.AnimNotifyEvents.Get(j);
						UAnimNotifyState notifyStateClass = fanimNotifyEvent.NotifyStateClass;
						if (notifyStateClass != null && notifyStateClass.IsValid())
						{
							AnimNotifyStateEffect animNotifyStateEffect = fanimNotifyEvent.NotifyStateClass as AnimNotifyStateEffect;
							if (animNotifyStateEffect != null && !FNameUtil.IsNothing(animNotifyStateEffect.EffectSlotName))
							{
								AnimNotifyStateEffect ans = animNotifyStateEffect;
								UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
								string animationNotifyEffectPath = UiModelLoadComponent.GetAnimationNotifyEffectPath(ans, (uiModelActorComponent != null) ? uiModelActorComponent.Actor : null);
								if (!string.IsNullOrEmpty(animationNotifyEffectPath) && !(animationNotifyEffectPath == "None"))
								{
									string text2;
									string text = (this.ReplaceEffectMap != null && this.ReplaceEffectMap.TryGetValue(animationNotifyEffectPath, out text2)) ? text2 : animationNotifyEffectPath;
									text != animationNotifyEffectPath;
									list.Add(text);
								}
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060155B0 RID: 87472 RVA: 0x00635964 File Offset: 0x00633B64
	protected virtual void FinishLoad()
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (uiModelDataComponent != null)
		{
			uiModelDataComponent.SetModelLoadState(EUiModelLoadState.LoadComplete);
		}
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		float ditherEffect = (uiModelDataComponent2 != null) ? uiModelDataComponent2.GetDitherEffectValue() : 1f;
		UiModelDataComponent uiModelDataComponent3 = this.UiModelDataComponent;
		if (uiModelDataComponent3 != null)
		{
			uiModelDataComponent3.SetDitherEffect(ditherEffect);
		}
		UiModelDataComponent uiModelDataComponent4 = this.UiModelDataComponent;
		bool? flag = (uiModelDataComponent4 != null) ? uiModelDataComponent4.GetPlanarReflectionRenderOffsetEnabled() : null;
		if (uiModelDataComponent4 != null && flag != null)
		{
			uiModelDataComponent4.SetPlanarReflectionRenderOffset(flag.Value, uiModelDataComponent4.GetPlanarReflectionRenderOffset());
		}
		UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
		if (uiModelMorphComponent != null)
		{
			uiModelMorphComponent.PreloadMorphData();
		}
		Action loadFinishCallBack = this.LoadFinishCallBack;
		if (loadFinishCallBack == null)
		{
			return;
		}
		loadFinishCallBack();
	}

	// Token: 0x060155B1 RID: 87473 RVA: 0x00635A08 File Offset: 0x00633C08
	public void CancelLoad()
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (uiModelDataComponent != null && uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.IsLoading)
		{
			UiModelResourcesManager.Instance.CancelUiModelResourceLoad(this.LoadHandleId);
			this.LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;
			this.DestroyLoadMesh();
			if (this.LoadAnimClassHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadAnimClassHandle);
				this.LoadAnimClassHandle = -1;
			}
		}
		this.ResourceLoadCache = null;
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		if (uiModelDataComponent2 != null)
		{
			uiModelDataComponent2.SetModelLoadState(EUiModelLoadState.None);
		}
		UiModelMorphComponent uiModelMorphComponent = this.UiModelMorphComponent;
		if (uiModelMorphComponent == null)
		{
			return;
		}
		uiModelMorphComponent.ClearData();
	}

	// Token: 0x060155B2 RID: 87474 RVA: 0x00635A9C File Offset: 0x00633C9C
	[return: Nullable(2)]
	public UObject GetLoadedResource(string path)
	{
		UObject result;
		if (this.ResourceLoadCache != null && this.ResourceLoadCache.TryGetValue(path, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060155B3 RID: 87475 RVA: 0x00635AC4 File Offset: 0x00633CC4
	public List<UiModelDecorationParam> GetModelMeshDecorationList(TArray<SModelDecorationConfig> configArray)
	{
		int num = configArray.Num();
		List<UiModelDecorationParam> list = new List<UiModelDecorationParam>();
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				SModelDecorationConfig smodelDecorationConfig = configArray.Get(i);
				string path = smodelDecorationConfig.SkeletalMesh.ToAssetPathName();
				USkeletalMesh skeletalMesh = this.GetLoadedResource(path) as USkeletalMesh;
				UiModelDecorationParam item = new UiModelDecorationParam
				{
					SocketName = smodelDecorationConfig.SocketName,
					Transform = smodelDecorationConfig.Transform,
					SkeletalMesh = skeletalMesh
				};
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x060155B4 RID: 87476 RVA: 0x00635B44 File Offset: 0x00633D44
	public TArray<USkeletalMesh> GetModelAllMesh()
	{
		TArray<USkeletalMesh> tarray = new TArray<USkeletalMesh>();
		string mainMeshPath = this.GetMainMeshPath();
		if (!string.IsNullOrEmpty(mainMeshPath))
		{
			USkeletalMesh value = this.GetLoadedResource(mainMeshPath) as USkeletalMesh;
			tarray.Add(value);
		}
		List<string> childMeshPathList = this.GetChildMeshPathList();
		if (childMeshPathList != null && childMeshPathList.Count > 0)
		{
			foreach (string text in childMeshPathList)
			{
				if (!string.IsNullOrEmpty(text))
				{
					USkeletalMesh value2 = this.GetLoadedResource(text) as USkeletalMesh;
					tarray.Add(value2);
				}
			}
		}
		return tarray;
	}

	// Token: 0x060155B5 RID: 87477 RVA: 0x00635BEC File Offset: 0x00633DEC
	protected void DestroyLoadMesh()
	{
		if (this.StreamingHandleId != 0)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.StreamingHandleId);
			this.StreamingHandleId = 0;
		}
	}

	// Token: 0x060155B6 RID: 87478 RVA: 0x00635C0D File Offset: 0x00633E0D
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, string> GetReplaceEffectMap()
	{
		return this.ReplaceEffectMap;
	}

	// Token: 0x060155B7 RID: 87479 RVA: 0x00635C18 File Offset: 0x00633E18
	protected void SetupReplaceEffectFromModelConfig()
	{
		this.ReplaceEffectMap = null;
		SModelConfig modelConfig = ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId);
		string text;
		if (modelConfig == null)
		{
			text = null;
		}
		else
		{
			TSoftObjectPtr<UDataTable> 特效替换表 = modelConfig.特效替换表;
			text = ((特效替换表 != null) ? 特效替换表.ToAssetPathName() : null);
		}
		string text2 = text;
		if (!string.IsNullOrEmpty(text2) && text2 != "None")
		{
			this.SetupReplaceEffect(text2);
		}
	}

	// Token: 0x060155B8 RID: 87480 RVA: 0x00635C74 File Offset: 0x00633E74
	protected void SetupReplaceEffect(string replaceTablePath)
	{
		UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(replaceTablePath, "js_undefined");
		if (udataTable == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiModel;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "特效替换表加载失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tablePath", replaceTablePath);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		List<SReplaceEffect> dataTableAllRowFromTable = DataTableUtil.GetDataTableAllRowFromTable<SReplaceEffect>(udataTable);
		if (dataTableAllRowFromTable.Count == 0)
		{
			return;
		}
		this.ReplaceEffectMap = new Dictionary<string, string>();
		foreach (SReplaceEffect sreplaceEffect in dataTableAllRowFromTable)
		{
			string text = sreplaceEffect.NewEffect.ToAssetPathName();
			if (!string.IsNullOrEmpty(text) && !(text == "None"))
			{
				string text2 = sreplaceEffect.OldEffect.ToAssetPathName();
				if (text.Contains("GA_"))
				{
					text += "_C";
					text2 += "_C";
				}
				this.ReplaceEffectMap[text2] = text;
			}
		}
	}

	// Token: 0x060155B9 RID: 87481 RVA: 0x00635D80 File Offset: 0x00633F80
	private static string GetAnimationNotifyEffectPath(AnimNotifyStateEffect ans, [Nullable(2)] UObject worldContext)
	{
		TSoftObjectPtr<UEffectModelBase> effectDataAssetRef = ans.EffectDataAssetRef;
		string result = effectDataAssetRef.ToAssetPathName();
		UObject uobject = (worldContext != null && worldContext.IsValid()) ? worldContext : GlobalData.World;
		if (uobject == null || !uobject.IsValid() || UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(uobject) != KuroFeatureLevel.ES3_1)
		{
			return result;
		}
		TSoftObjectPtr<UEffectModelBase> mobileEffectDataAssetRef = ans.MobileEffectDataAssetRef;
		string text = (mobileEffectDataAssetRef != null) ? mobileEffectDataAssetRef.ToAssetPathName() : null;
		if (!string.IsNullOrEmpty(text) && text != "None")
		{
			return text;
		}
		TMap<TSoftObjectPtr<UEffectModelBase>, TSoftObjectPtr<UEffectModelBase>> mobileEffectDataAssetOverrides = ans.MobileEffectDataAssetOverrides;
		TSoftObjectPtr<UEffectModelBase> tsoftObjectPtr;
		string text2 = (effectDataAssetRef != null && mobileEffectDataAssetOverrides != null && mobileEffectDataAssetOverrides.TryGetValue(effectDataAssetRef, out tsoftObjectPtr)) ? ((tsoftObjectPtr != null) ? tsoftObjectPtr.ToAssetPathName() : null) : null;
		if (string.IsNullOrEmpty(text2) || !(text2 != "None"))
		{
			return result;
		}
		return text2;
	}

	// Token: 0x0400B518 RID: 46360
	[Nullable(2)]
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B519 RID: 46361
	[Nullable(2)]
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B51A RID: 46362
	[Nullable(2)]
	protected UiModelMorphComponent UiModelMorphComponent;

	// Token: 0x0400B51B RID: 46363
	protected int LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B51C RID: 46364
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> ReplaceEffectMap;

	// Token: 0x0400B51D RID: 46365
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UObject> ResourceLoadCache;

	// Token: 0x0400B51E RID: 46366
	protected TArray<USkeletalMesh> MeshArray = new TArray<USkeletalMesh>();

	// Token: 0x0400B51F RID: 46367
	protected int StreamingHandleId;

	// Token: 0x0400B520 RID: 46368
	[Nullable(2)]
	protected Action LoadFinishCallBack;

	// Token: 0x0400B521 RID: 46369
	private int LoadAnimClassHandle = -1;

	// Token: 0x0400B522 RID: 46370
	private TSet<UAnimationAsset> AnimationAssetSet = new TSet<UAnimationAsset>();

	// Token: 0x0400B523 RID: 46371
	private TArray<FAnimNotifyEvent> AnimNotifyEvents = new TArray<FAnimNotifyEvent>();
}
