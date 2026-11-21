using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Prop.Shipin.Common;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x020021CF RID: 8655
[NullableContext(1)]
[Nullable(0)]
public class UiDecorationLoadComponent : UiModelComponentBase
{
	// Token: 0x060154C2 RID: 87234 RVA: 0x00631531 File Offset: 0x0062F731
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x060154C3 RID: 87235 RVA: 0x00631555 File Offset: 0x0062F755
	protected override void OnEnd()
	{
		this.CancelLoad();
		this.DestroyLoadMesh();
		this.AttachSkinId = 0;
	}

	// Token: 0x060154C4 RID: 87236 RVA: 0x0063156A File Offset: 0x0062F76A
	protected SDecorationConfig GetDecorationConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x060154C5 RID: 87237 RVA: 0x0063157A File Offset: 0x0062F77A
	protected string GetMainMeshPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SkeletalMesh.ToAssetPathName();
	}

	// Token: 0x060154C6 RID: 87238 RVA: 0x00631597 File Offset: 0x0062F797
	protected string GetAnimClassPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AnimBlueprint.ToAssetPathName();
	}

	// Token: 0x060154C7 RID: 87239 RVA: 0x006315B4 File Offset: 0x0062F7B4
	protected string GetUiAnimClassPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).UIAnimBlueprint.ToAssetPathName();
	}

	// Token: 0x060154C8 RID: 87240 RVA: 0x006315D1 File Offset: 0x0062F7D1
	public bool IsSetMasterFollow()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SetMasterFollow;
	}

	// Token: 0x060154C9 RID: 87241 RVA: 0x006315E9 File Offset: 0x0062F7E9
	public FName GetAttachSocketName(int? index = null)
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AttachSocket.Get(index.GetValueOrDefault());
	}

	// Token: 0x060154CA RID: 87242 RVA: 0x0063160D File Offset: 0x0062F80D
	public FTransform GetAttachTransform(int? index = null)
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AttachTrans.Get(index.GetValueOrDefault());
	}

	// Token: 0x060154CB RID: 87243 RVA: 0x00631631 File Offset: 0x0062F831
	public void SetAttachSkinId(int skinId)
	{
		this.AttachSkinId = skinId;
	}

	// Token: 0x060154CC RID: 87244 RVA: 0x0063163C File Offset: 0x0062F83C
	private int GetAttachTransformIndex(SDecorationConfig config)
	{
		int result = this.PartIndex;
		int num;
		if (this.AttachSkinId > 0 && config.SkinAttachTrans != null && config.SkinAttachTrans.TryGetValue(this.AttachSkinId, out num) && num >= 0 && num < config.AttachTrans.Num())
		{
			result = num;
		}
		return result;
	}

	// Token: 0x060154CD RID: 87245 RVA: 0x0063168B File Offset: 0x0062F88B
	public string GetSubMeshName()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SubMeshName;
	}

	// Token: 0x060154CE RID: 87246 RVA: 0x006316A3 File Offset: 0x0062F8A3
	[NullableContext(2)]
	public UiModelActorComponent GetAttachActorComponent()
	{
		return this.UiAttachActorComponent;
	}

	// Token: 0x060154CF RID: 87247 RVA: 0x006316AB File Offset: 0x0062F8AB
	public void SetAttachActorComponent(UiModelActorComponent actorComponent)
	{
		this.UiAttachActorComponent = actorComponent;
	}

	// Token: 0x060154D0 RID: 87248 RVA: 0x006316B4 File Offset: 0x0062F8B4
	[NullableContext(2)]
	public void LoadModelByModelId(int modelId, int partIndex, bool waitMeshStreaming = false, Action loadFinishCallBack = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> extraResourceList = null, bool skipAttachOnLoadComplete = false)
	{
		int modelConfigId = this.UiModelDataComponent.ModelConfigId;
		this.SkipAttachOnLoadComplete = skipAttachOnLoadComplete;
		this.UiModelDataComponent.ModelConfigId = modelId;
		this.PartIndex = partIndex;
		this.LoadFinishCallBack = loadFinishCallBack;
		this.LoadModel(waitMeshStreaming, extraResourceList, 0);
	}

	// Token: 0x060154D1 RID: 87249 RVA: 0x006316F4 File Offset: 0x0062F8F4
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
		UiModelDataComponent uiModelDataComponent4 = this.UiModelDataComponent;
		if (uiModelDataComponent4 != null)
		{
			uiModelDataComponent4.SetModelLoadState(EUiModelLoadState.IsLoading);
		}
		string animInstanceClassPath = this.GetUiAnimClassPath();
		if (StringUtils.IsEmpty(animInstanceClassPath))
		{
			animInstanceClassPath = this.GetAnimClassPath();
		}
		if (!StringUtils.IsEmpty(animInstanceClassPath))
		{
			this.LoadAnimClassHandle = ResourceSystem.Instance.LoadAsync<UClass>(animInstanceClassPath, delegate([Nullable(2)] UClass asset, string _)
			{
				this.LoadAnimClassHandle = -1;
				this.OnPostLoadAnimClass(asset, animInstanceClassPath, waitMeshStreaming, extraResourceList, levelOfDetail);
			}, 100, "Ui.UiSceneModel");
			return;
		}
		this.OnPostLoadAnimClass(null, animInstanceClassPath, waitMeshStreaming, extraResourceList, levelOfDetail);
	}

	// Token: 0x060154D2 RID: 87250 RVA: 0x00631818 File Offset: 0x0062FA18
	protected void OnPostLoadAnimClass([Nullable(2)] UClass asset, string path, bool waitMeshStreaming, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> extraResourceList = null, int levelOfDetail = 0)
	{
		string mainMeshPath = this.GetMainMeshPath();
		List<string> list = new List<string>();
		if (mainMeshPath != null && !StringUtils.IsEmpty(mainMeshPath))
		{
			list.Add(mainMeshPath);
		}
		UiModelUtil.Instance.CheckPathListAndAdd(list, extraResourceList);
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
			UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
			if (uiModelActorComponent != null)
			{
				uiModelActorComponent.ChangeMesh(uskeletalMesh, asset, null, null, levelOfDetail);
			}
			if (!waitMeshStreaming)
			{
				this.FinishLoad();
				this.MeshArray.Empty(true);
				return;
			}
			MeshStreamTaskContext meshStreamTaskContext = new MeshStreamTaskContext();
			meshStreamTaskContext.SkeletalMeshes = tarray;
			MeshStreamTaskContext meshStreamTaskContext2 = meshStreamTaskContext;
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
			meshStreamTaskContext2.OnTaskFinish = onTaskFinish;
			this.MeshStreamTaskId = MeshStreamController.Instance.AddMeshStreamTask(meshStreamTaskContext);
		});
	}

	// Token: 0x060154D3 RID: 87251 RVA: 0x006318A8 File Offset: 0x0062FAA8
	private void TrySetExtraFollowOwner(USkeletalMeshComponent ownerMesh)
	{
		UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
		object obj;
		if (uiModelActorComponent == null)
		{
			obj = null;
		}
		else
		{
			USkeletalMeshComponent mainMeshComponent = uiModelActorComponent.MainMeshComponent;
			obj = ((mainMeshComponent != null) ? mainMeshComponent.GetAnimInstance() : null);
		}
		object obj2 = obj;
		ABP_BaseDecoration_C abp_BaseDecoration_C = ((obj2 != null) ? obj2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE) : null) as ABP_BaseDecoration_C;
		if (abp_BaseDecoration_C == null)
		{
			return;
		}
		UAnimInstance animInstance = ownerMesh.GetAnimInstance();
		if (animInstance == null)
		{
			return;
		}
		abp_BaseDecoration_C.SetExtraFollowOwner(animInstance);
	}

	// Token: 0x060154D4 RID: 87252 RVA: 0x00631908 File Offset: 0x0062FB08
	protected void FinishLoad()
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (uiModelDataComponent != null)
		{
			int modelConfigId = uiModelDataComponent.ModelConfigId;
		}
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		if (uiModelDataComponent2 != null)
		{
			uiModelDataComponent2.SetModelLoadState(EUiModelLoadState.LoadComplete);
		}
		UiModelDataComponent uiModelDataComponent3 = this.UiModelDataComponent;
		float ditherEffect = (uiModelDataComponent3 != null) ? uiModelDataComponent3.GetDitherEffectValue() : 1f;
		UiModelDataComponent uiModelDataComponent4 = this.UiModelDataComponent;
		if (uiModelDataComponent4 != null)
		{
			uiModelDataComponent4.SetDitherEffect(ditherEffect);
		}
		UiModelDataComponent uiModelDataComponent5 = this.UiModelDataComponent;
		bool? flag = (uiModelDataComponent5 != null) ? uiModelDataComponent5.GetPlanarReflectionRenderOffsetEnabled() : null;
		if (uiModelDataComponent5 != null && flag != null)
		{
			uiModelDataComponent5.SetPlanarReflectionRenderOffset(flag.Value, uiModelDataComponent5.GetPlanarReflectionRenderOffset());
		}
		if (!this.SkipAttachOnLoadComplete)
		{
			this.AttachToTarget();
		}
		Action loadFinishCallBack = this.LoadFinishCallBack;
		if (loadFinishCallBack == null)
		{
			return;
		}
		loadFinishCallBack();
	}

	// Token: 0x060154D5 RID: 87253 RVA: 0x006319BC File Offset: 0x0062FBBC
	public void AttachToTarget()
	{
		int modelConfigId = this.UiModelDataComponent.ModelConfigId;
		UiModelActorComponent uiAttachActorComponent = this.UiAttachActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (uiAttachActorComponent != null) ? uiAttachActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		this.TrySetExtraFollowOwner(uskeletalMeshComponent);
		UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent2 = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (this.IsSetMasterFollow())
		{
			uskeletalMeshComponent.IsValid();
			USkeletalMesh skeletalMesh = uskeletalMeshComponent.SkeletalMesh;
			if (uskeletalMeshComponent2 != null)
			{
				uskeletalMeshComponent2.IsValid();
			}
			if (uskeletalMeshComponent2 != null)
			{
				USkeletalMesh skeletalMesh2 = uskeletalMeshComponent2.SkeletalMesh;
			}
			if (uskeletalMeshComponent2 != null)
			{
				uskeletalMeshComponent2.SetMasterPoseComponent(uskeletalMeshComponent, true);
			}
			this.UiModelActorComponent.Actor.K2_AttachToComponent(uskeletalMeshComponent, FName.NAME_None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			return;
		}
		FName attachSocketName = this.GetAttachSocketName(new int?(this.PartIndex));
		this.UiModelActorComponent.Actor.K2_AttachToComponent(uskeletalMeshComponent, attachSocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		FHitResult fhitResult = new FHitResult();
		SDecorationConfig decorationConfig = this.GetDecorationConfig(modelConfigId);
		int attachTransformIndex = this.GetAttachTransformIndex(decorationConfig);
		AActor actor = this.UiModelActorComponent.Actor;
		FTransform ftransform = decorationConfig.AttachTrans.Get(attachTransformIndex);
		actor.K2_SetActorRelativeTransform(ftransform, false, ref fhitResult, false);
	}

	// Token: 0x060154D6 RID: 87254 RVA: 0x00631AC0 File Offset: 0x0062FCC0
	private USkeletalMeshComponent GetSubMeshComponent(USkeletalMeshComponent parentMesh, string mesh)
	{
		if (parentMesh.GetOwner() == null || string.IsNullOrEmpty(mesh))
		{
			return parentMesh;
		}
		TArray<USceneComponent> tarray = new TArray<USceneComponent>();
		parentMesh.GetChildrenComponents(true, ref tarray);
		for (int i = 0; i < tarray.Count; i++)
		{
			USceneComponent usceneComponent = tarray[i];
			USkeletalMeshComponent uskeletalMeshComponent = usceneComponent as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null && usceneComponent.GetName() == mesh)
			{
				return uskeletalMeshComponent;
			}
		}
		return parentMesh;
	}

	// Token: 0x060154D7 RID: 87255 RVA: 0x00631B24 File Offset: 0x0062FD24
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
		this.SkipAttachOnLoadComplete = false;
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		if (uiModelDataComponent2 == null)
		{
			return;
		}
		uiModelDataComponent2.SetModelLoadState(EUiModelLoadState.None);
	}

	// Token: 0x060154D8 RID: 87256 RVA: 0x00631BAD File Offset: 0x0062FDAD
	[return: Nullable(2)]
	public UObject GetLoadedResource(string path)
	{
		if (this.ResourceLoadCache != null)
		{
			return this.ResourceLoadCache.GetValueOrDefault(path);
		}
		return null;
	}

	// Token: 0x060154D9 RID: 87257 RVA: 0x00631BC5 File Offset: 0x0062FDC5
	protected void DestroyLoadMesh()
	{
		if (this.MeshStreamTaskId != -1)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.MeshStreamTaskId);
			this.MeshStreamTaskId = -1;
		}
	}

	// Token: 0x0400B48F RID: 46223
	[Nullable(2)]
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B490 RID: 46224
	[Nullable(2)]
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B491 RID: 46225
	[Nullable(2)]
	protected UiModelActorComponent UiAttachActorComponent;

	// Token: 0x0400B492 RID: 46226
	private int LoadAnimClassHandle = -1;

	// Token: 0x0400B493 RID: 46227
	protected int LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B494 RID: 46228
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UObject> ResourceLoadCache;

	// Token: 0x0400B495 RID: 46229
	protected TArray<USkeletalMesh> MeshArray = new TArray<USkeletalMesh>();

	// Token: 0x0400B496 RID: 46230
	protected int MeshStreamTaskId = -1;

	// Token: 0x0400B497 RID: 46231
	protected int PartIndex;

	// Token: 0x0400B498 RID: 46232
	private int AttachSkinId;

	// Token: 0x0400B499 RID: 46233
	[Nullable(2)]
	protected Action LoadFinishCallBack;

	// Token: 0x0400B49A RID: 46234
	protected bool SkipAttachOnLoadComplete;
}
