using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Prop.Shipin.Common;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x02002C76 RID: 11382
[NullableContext(1)]
[Nullable(0)]
public class UiDecorationLoadComponent : UiModelComponentBase
{
	// Token: 0x06017C50 RID: 97360 RVA: 0x0060BA89 File Offset: 0x00609C89
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017C51 RID: 97361 RVA: 0x0060BAAD File Offset: 0x00609CAD
	protected override void OnEnd()
	{
		this.CancelLoad();
		this.DestroyLoadMesh();
		this.AttachSkinId = 0;
	}

	// Token: 0x06017C52 RID: 97362 RVA: 0x0060BAC2 File Offset: 0x00609CC2
	protected SDecorationConfig GetDecorationConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x06017C53 RID: 97363 RVA: 0x0060BAD2 File Offset: 0x00609CD2
	protected string GetMainMeshPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SkeletalMesh.ToAssetPathName();
	}

	// Token: 0x06017C54 RID: 97364 RVA: 0x0060BAEF File Offset: 0x00609CEF
	protected string GetAnimClassPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AnimBlueprint.ToAssetPathName();
	}

	// Token: 0x06017C55 RID: 97365 RVA: 0x0060BB0C File Offset: 0x00609D0C
	protected string GetUiAnimClassPath()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).UIAnimBlueprint.ToAssetPathName();
	}

	// Token: 0x06017C56 RID: 97366 RVA: 0x0060BB29 File Offset: 0x00609D29
	public bool IsSetMasterFollow()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SetMasterFollow;
	}

	// Token: 0x06017C57 RID: 97367 RVA: 0x0060BB41 File Offset: 0x00609D41
	public FName GetAttachSocketName(int? index = null)
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AttachSocket.Get(index.GetValueOrDefault());
	}

	// Token: 0x06017C58 RID: 97368 RVA: 0x0060BB65 File Offset: 0x00609D65
	public FTransform GetAttachTransform(int? index = null)
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).AttachTrans.Get(index.GetValueOrDefault());
	}

	// Token: 0x06017C59 RID: 97369 RVA: 0x0060BB89 File Offset: 0x00609D89
	public void SetAttachSkinId(int skinId)
	{
		this.AttachSkinId = skinId;
	}

	// Token: 0x06017C5A RID: 97370 RVA: 0x0060BB94 File Offset: 0x00609D94
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

	// Token: 0x06017C5B RID: 97371 RVA: 0x0060BBE3 File Offset: 0x00609DE3
	public string GetSubMeshName()
	{
		return this.GetDecorationConfig(this.UiModelDataComponent.ModelConfigId).SubMeshName;
	}

	// Token: 0x06017C5C RID: 97372 RVA: 0x0060BBFB File Offset: 0x00609DFB
	[NullableContext(2)]
	public UiModelActorComponent GetAttachActorComponent()
	{
		return this.UiAttachActorComponent;
	}

	// Token: 0x06017C5D RID: 97373 RVA: 0x0060BC03 File Offset: 0x00609E03
	public void SetAttachActorComponent(UiModelActorComponent actorComponent)
	{
		this.UiAttachActorComponent = actorComponent;
	}

	// Token: 0x06017C5E RID: 97374 RVA: 0x0060BC0C File Offset: 0x00609E0C
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

	// Token: 0x06017C5F RID: 97375 RVA: 0x0060BC4C File Offset: 0x00609E4C
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

	// Token: 0x06017C60 RID: 97376 RVA: 0x0060BD70 File Offset: 0x00609F70
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

	// Token: 0x06017C61 RID: 97377 RVA: 0x0060BE00 File Offset: 0x0060A000
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

	// Token: 0x06017C62 RID: 97378 RVA: 0x0060BE60 File Offset: 0x0060A060
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

	// Token: 0x06017C63 RID: 97379 RVA: 0x0060BF14 File Offset: 0x0060A114
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

	// Token: 0x06017C64 RID: 97380 RVA: 0x0060C018 File Offset: 0x0060A218
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

	// Token: 0x06017C65 RID: 97381 RVA: 0x0060C07C File Offset: 0x0060A27C
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

	// Token: 0x06017C66 RID: 97382 RVA: 0x0060C105 File Offset: 0x0060A305
	[return: Nullable(2)]
	public UObject GetLoadedResource(string path)
	{
		if (this.ResourceLoadCache != null)
		{
			return this.ResourceLoadCache.GetValueOrDefault(path);
		}
		return null;
	}

	// Token: 0x06017C67 RID: 97383 RVA: 0x0060C11D File Offset: 0x0060A31D
	protected void DestroyLoadMesh()
	{
		if (this.MeshStreamTaskId != -1)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.MeshStreamTaskId);
			this.MeshStreamTaskId = -1;
		}
	}

	// Token: 0x0400B124 RID: 45348
	[Nullable(2)]
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B125 RID: 45349
	[Nullable(2)]
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B126 RID: 45350
	[Nullable(2)]
	protected UiModelActorComponent UiAttachActorComponent;

	// Token: 0x0400B127 RID: 45351
	private int LoadAnimClassHandle = -1;

	// Token: 0x0400B128 RID: 45352
	protected int LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B129 RID: 45353
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UObject> ResourceLoadCache;

	// Token: 0x0400B12A RID: 45354
	protected TArray<USkeletalMesh> MeshArray = new TArray<USkeletalMesh>();

	// Token: 0x0400B12B RID: 45355
	protected int MeshStreamTaskId = -1;

	// Token: 0x0400B12C RID: 45356
	protected int PartIndex;

	// Token: 0x0400B12D RID: 45357
	private int AttachSkinId;

	// Token: 0x0400B12E RID: 45358
	[Nullable(2)]
	protected Action LoadFinishCallBack;

	// Token: 0x0400B12F RID: 45359
	protected bool SkipAttachOnLoadComplete;
}
