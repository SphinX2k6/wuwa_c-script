using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x02002C8B RID: 11403
[NullableContext(1)]
[Nullable(0)]
public class UiModelLoadComponent : UiModelComponentBase
{
	// Token: 0x06017D2F RID: 97583 RVA: 0x0060F938 File Offset: 0x0060DB38
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelMorphComponent = base.Owner.GetComponentByCtor<UiModelMorphComponent>();
	}

	// Token: 0x06017D30 RID: 97584 RVA: 0x0060F96D File Offset: 0x0060DB6D
	protected override void OnEnd()
	{
		this.CancelLoad();
		this.DestroyLoadMesh();
		this.ReplaceEffectMap = null;
	}

	// Token: 0x06017D31 RID: 97585 RVA: 0x0060F982 File Offset: 0x0060DB82
	protected string GetMainMeshPath()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).网格体.ToAssetPathName();
	}

	// Token: 0x06017D32 RID: 97586 RVA: 0x0060F9A0 File Offset: 0x0060DBA0
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

	// Token: 0x06017D33 RID: 97587 RVA: 0x0060F9DA File Offset: 0x0060DBDA
	protected virtual string GetAnimClassPath()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).动画蓝图.ToAssetPathName();
	}

	// Token: 0x06017D34 RID: 97588 RVA: 0x0060F9F8 File Offset: 0x0060DBF8
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

	// Token: 0x06017D35 RID: 97589 RVA: 0x0060FA56 File Offset: 0x0060DC56
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

	// Token: 0x06017D36 RID: 97590 RVA: 0x0060FA69 File Offset: 0x0060DC69
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

	// Token: 0x06017D37 RID: 97591 RVA: 0x0060FA7C File Offset: 0x0060DC7C
	protected TArray<SModelDecorationConfig> GetModelDecorationArray()
	{
		return ModelUtil.GetModelConfig(this.UiModelDataComponent.ModelConfigId).UiModelDecorationArray;
	}

	// Token: 0x06017D38 RID: 97592 RVA: 0x0060FA94 File Offset: 0x0060DC94
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

	// Token: 0x06017D39 RID: 97593 RVA: 0x0060FAE5 File Offset: 0x0060DCE5
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

	// Token: 0x06017D3A RID: 97594 RVA: 0x0060FB14 File Offset: 0x0060DD14
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

	// Token: 0x06017D3B RID: 97595 RVA: 0x0060FC20 File Offset: 0x0060DE20
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

	// Token: 0x06017D3C RID: 97596 RVA: 0x0060FD24 File Offset: 0x0060DF24
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
								string text = animNotifyStateEffect.EffectDataAssetRef.ToAssetPathName();
								if (!string.IsNullOrEmpty(text) && !(text == "None"))
								{
									string text3;
									string text2 = (this.ReplaceEffectMap != null && this.ReplaceEffectMap.TryGetValue(text, out text3)) ? text3 : text;
									text2 != text;
									list.Add(text2);
								}
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06017D3D RID: 97597 RVA: 0x0060FE84 File Offset: 0x0060E084
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

	// Token: 0x06017D3E RID: 97598 RVA: 0x0060FF28 File Offset: 0x0060E128
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

	// Token: 0x06017D3F RID: 97599 RVA: 0x0060FFBC File Offset: 0x0060E1BC
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

	// Token: 0x06017D40 RID: 97600 RVA: 0x0060FFE4 File Offset: 0x0060E1E4
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

	// Token: 0x06017D41 RID: 97601 RVA: 0x00610064 File Offset: 0x0060E264
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

	// Token: 0x06017D42 RID: 97602 RVA: 0x0061010C File Offset: 0x0060E30C
	protected void DestroyLoadMesh()
	{
		if (this.StreamingHandleId != 0)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.StreamingHandleId);
			this.StreamingHandleId = 0;
		}
	}

	// Token: 0x06017D43 RID: 97603 RVA: 0x0061012D File Offset: 0x0060E32D
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

	// Token: 0x06017D44 RID: 97604 RVA: 0x00610138 File Offset: 0x0060E338
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

	// Token: 0x06017D45 RID: 97605 RVA: 0x00610194 File Offset: 0x0060E394
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

	// Token: 0x0400B1AD RID: 45485
	[Nullable(2)]
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B1AE RID: 45486
	[Nullable(2)]
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B1AF RID: 45487
	[Nullable(2)]
	protected UiModelMorphComponent UiModelMorphComponent;

	// Token: 0x0400B1B0 RID: 45488
	protected int LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B1B1 RID: 45489
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> ReplaceEffectMap;

	// Token: 0x0400B1B2 RID: 45490
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UObject> ResourceLoadCache;

	// Token: 0x0400B1B3 RID: 45491
	protected TArray<USkeletalMesh> MeshArray = new TArray<USkeletalMesh>();

	// Token: 0x0400B1B4 RID: 45492
	protected int StreamingHandleId;

	// Token: 0x0400B1B5 RID: 45493
	[Nullable(2)]
	protected Action LoadFinishCallBack;

	// Token: 0x0400B1B6 RID: 45494
	private int LoadAnimClassHandle = -1;

	// Token: 0x0400B1B7 RID: 45495
	private TSet<UAnimationAsset> AnimationAssetSet = new TSet<UAnimationAsset>();

	// Token: 0x0400B1B8 RID: 45496
	private TArray<FAnimNotifyEvent> AnimNotifyEvents = new TArray<FAnimNotifyEvent>();
}
