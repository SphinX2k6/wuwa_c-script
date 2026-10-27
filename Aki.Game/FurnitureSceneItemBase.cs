using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FB2 RID: 4018
public abstract class FurnitureSceneItemBase
{
	// Token: 0x060066E2 RID: 26338 RVA: 0x00145BA0 File Offset: 0x00143DA0
	public FurnitureSceneItemBase(int furnitureConfigId)
	{
		this.FurnitureConfigId = furnitureConfigId;
	}

	// Token: 0x060066E3 RID: 26339 RVA: 0x00145BB0 File Offset: 0x00143DB0
	public UniTask<bool> LoadAndShowAsync([Nullable(1)] Transform rootTransform)
	{
		FurnitureSceneItemBase.<LoadAndShowAsync>d__7 <LoadAndShowAsync>d__;
		<LoadAndShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAndShowAsync>d__.<>4__this = this;
		<LoadAndShowAsync>d__.rootTransform = rootTransform;
		<LoadAndShowAsync>d__.<>1__state = -1;
		<LoadAndShowAsync>d__.<>t__builder.Start<FurnitureSceneItemBase.<LoadAndShowAsync>d__7>(ref <LoadAndShowAsync>d__);
		return <LoadAndShowAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060066E4 RID: 26340 RVA: 0x00145BFC File Offset: 0x00143DFC
	public UniTask<bool> LoadAsync([Nullable(1)] Transform rootTransform)
	{
		FurnitureSceneItemBase.<LoadAsync>d__8 <LoadAsync>d__;
		<LoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAsync>d__.<>4__this = this;
		<LoadAsync>d__.rootTransform = rootTransform;
		<LoadAsync>d__.<>1__state = -1;
		<LoadAsync>d__.<>t__builder.Start<FurnitureSceneItemBase.<LoadAsync>d__8>(ref <LoadAsync>d__);
		return <LoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060066E5 RID: 26341
	protected abstract UniTask<bool> LoadAsyncImplement([Nullable(1)] Transform transform);

	// Token: 0x060066E6 RID: 26342 RVA: 0x00145C47 File Offset: 0x00143E47
	public bool Show()
	{
		if (this.State != EFurnitureSceneItemState.Loaded && this.State != EFurnitureSceneItemState.Hide)
		{
			return false;
		}
		this.ShowImplement();
		this.State = EFurnitureSceneItemState.Show;
		return true;
	}

	// Token: 0x060066E7 RID: 26343
	protected abstract void ShowImplement();

	// Token: 0x060066E8 RID: 26344 RVA: 0x00145C6B File Offset: 0x00143E6B
	public bool Hide()
	{
		if (this.State != EFurnitureSceneItemState.Show)
		{
			return false;
		}
		this.HideImplement();
		this.State = EFurnitureSceneItemState.Hide;
		return true;
	}

	// Token: 0x060066E9 RID: 26345
	protected abstract void HideImplement();

	// Token: 0x060066EA RID: 26346 RVA: 0x00145C88 File Offset: 0x00143E88
	protected UniTask<bool> LoadLevelInstanceAsync([Nullable(1)] FurnitureLevelContext context)
	{
		FurnitureSceneItemBase.<LoadLevelInstanceAsync>d__14 <LoadLevelInstanceAsync>d__;
		<LoadLevelInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadLevelInstanceAsync>d__.<>4__this = this;
		<LoadLevelInstanceAsync>d__.context = context;
		<LoadLevelInstanceAsync>d__.<>1__state = -1;
		<LoadLevelInstanceAsync>d__.<>t__builder.Start<FurnitureSceneItemBase.<LoadLevelInstanceAsync>d__14>(ref <LoadLevelInstanceAsync>d__);
		return <LoadLevelInstanceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060066EB RID: 26347 RVA: 0x00145CD4 File Offset: 0x00143ED4
	[NullableContext(1)]
	protected void UnloadLevelInstance(FurnitureLevelContext context)
	{
		ULevelStreamingDynamic levelStreamingDynamic = context.LevelStreamingDynamic;
		if (levelStreamingDynamic == null || !levelStreamingDynamic.IsValid())
		{
			return;
		}
		levelStreamingDynamic.OnLevelLoaded.Clear();
		levelStreamingDynamic.SetShouldBeLoaded(false);
		levelStreamingDynamic.SetShouldBeVisible(false);
		levelStreamingDynamic.SetIsRequestingUnloadAndRemoval(true);
		context.LevelStreamingDynamic = null;
	}

	// Token: 0x060066EC RID: 26348 RVA: 0x00145D1B File Offset: 0x00143F1B
	[NullableContext(1)]
	protected void ShowLevelInstance(FurnitureLevelContext context)
	{
		if (context.LevelStreamingDynamic != null)
		{
			context.LevelStreamingDynamic.SetShouldBeVisible(true);
		}
	}

	// Token: 0x060066ED RID: 26349 RVA: 0x00145D31 File Offset: 0x00143F31
	[NullableContext(1)]
	protected void HideLevelInstance(FurnitureLevelContext context)
	{
		if (context.LevelStreamingDynamic != null)
		{
			context.LevelStreamingDynamic.SetShouldBeVisible(false);
		}
	}

	// Token: 0x060066EE RID: 26350 RVA: 0x00145D47 File Offset: 0x00143F47
	public void Unload()
	{
		if (this.State == EFurnitureSceneItemState.None || this.State == EFurnitureSceneItemState.Unloaded)
		{
			return;
		}
		this.UnloadImplement();
		if (this.State == EFurnitureSceneItemState.Loading)
		{
			CustomPromise<bool> loadingPromise = this.LoadingPromise;
			if (loadingPromise != null)
			{
				loadingPromise.SetResult(false);
			}
		}
		this.State = EFurnitureSceneItemState.Unloaded;
	}

	// Token: 0x060066EF RID: 26351
	protected abstract void UnloadImplement();

	// Token: 0x060066F0 RID: 26352 RVA: 0x00145D83 File Offset: 0x00143F83
	public void MarkAsNeedUnload()
	{
		this.NeedUnload = true;
	}

	// Token: 0x060066F1 RID: 26353 RVA: 0x00145D8C File Offset: 0x00143F8C
	public bool IsNeedUnload()
	{
		return this.NeedUnload;
	}

	// Token: 0x060066F2 RID: 26354 RVA: 0x00145D94 File Offset: 0x00143F94
	public bool IsLoaded()
	{
		return this.State == EFurnitureSceneItemState.Loaded;
	}

	// Token: 0x060066F3 RID: 26355 RVA: 0x00145D9F File Offset: 0x00143F9F
	public bool IsUnloaded()
	{
		return this.State == EFurnitureSceneItemState.Unloaded;
	}

	// Token: 0x060066F4 RID: 26356 RVA: 0x00145DAA File Offset: 0x00143FAA
	public bool IsLoading()
	{
		return this.State == EFurnitureSceneItemState.Loading;
	}

	// Token: 0x060066F5 RID: 26357 RVA: 0x00145DB5 File Offset: 0x00143FB5
	public EFurnitureSceneItemType GetSceneItemType()
	{
		return this.SceneItemType;
	}

	// Token: 0x060066F6 RID: 26358 RVA: 0x00145DBD File Offset: 0x00143FBD
	public bool IsEntityType()
	{
		return this.SceneItemType == EFurnitureSceneItemType.SingleEntity || this.SceneItemType == EFurnitureSceneItemType.GroupEntity;
	}

	// Token: 0x04002EA8 RID: 11944
	public readonly int FurnitureConfigId;

	// Token: 0x04002EA9 RID: 11945
	protected EFurnitureSceneItemType SceneItemType;

	// Token: 0x04002EAA RID: 11946
	[Nullable(2)]
	private CustomPromise<bool> LoadingPromise;

	// Token: 0x04002EAB RID: 11947
	private EFurnitureSceneItemState State;

	// Token: 0x04002EAC RID: 11948
	[Nullable(2)]
	protected Transform RootTransform;

	// Token: 0x04002EAD RID: 11949
	private bool NeedUnload;
}
