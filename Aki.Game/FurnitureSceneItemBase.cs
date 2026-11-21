using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000467 RID: 1127
public abstract class FurnitureSceneItemBase
{
	// Token: 0x06003A7A RID: 14970 RVA: 0x0014E464 File Offset: 0x0014C664
	public FurnitureSceneItemBase(int furnitureConfigId)
	{
		this.FurnitureConfigId = furnitureConfigId;
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x0014E474 File Offset: 0x0014C674
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

	// Token: 0x06003A7C RID: 14972 RVA: 0x0014E4C0 File Offset: 0x0014C6C0
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

	// Token: 0x06003A7D RID: 14973
	protected abstract UniTask<bool> LoadAsyncImplement([Nullable(1)] Transform transform);

	// Token: 0x06003A7E RID: 14974 RVA: 0x0014E50B File Offset: 0x0014C70B
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

	// Token: 0x06003A7F RID: 14975
	protected abstract void ShowImplement();

	// Token: 0x06003A80 RID: 14976 RVA: 0x0014E52F File Offset: 0x0014C72F
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

	// Token: 0x06003A81 RID: 14977
	protected abstract void HideImplement();

	// Token: 0x06003A82 RID: 14978 RVA: 0x0014E54C File Offset: 0x0014C74C
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

	// Token: 0x06003A83 RID: 14979 RVA: 0x0014E598 File Offset: 0x0014C798
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

	// Token: 0x06003A84 RID: 14980 RVA: 0x0014E5DF File Offset: 0x0014C7DF
	[NullableContext(1)]
	protected void ShowLevelInstance(FurnitureLevelContext context)
	{
		if (context.LevelStreamingDynamic != null)
		{
			context.LevelStreamingDynamic.SetShouldBeVisible(true);
		}
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x0014E5F5 File Offset: 0x0014C7F5
	[NullableContext(1)]
	protected void HideLevelInstance(FurnitureLevelContext context)
	{
		if (context.LevelStreamingDynamic != null)
		{
			context.LevelStreamingDynamic.SetShouldBeVisible(false);
		}
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x0014E60B File Offset: 0x0014C80B
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

	// Token: 0x06003A87 RID: 14983
	protected abstract void UnloadImplement();

	// Token: 0x06003A88 RID: 14984 RVA: 0x0014E647 File Offset: 0x0014C847
	public void MarkAsNeedUnload()
	{
		this.NeedUnload = true;
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x0014E650 File Offset: 0x0014C850
	public bool IsNeedUnload()
	{
		return this.NeedUnload;
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x0014E658 File Offset: 0x0014C858
	public bool IsLoaded()
	{
		return this.State == EFurnitureSceneItemState.Loaded;
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x0014E663 File Offset: 0x0014C863
	public bool IsUnloaded()
	{
		return this.State == EFurnitureSceneItemState.Unloaded;
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x0014E66E File Offset: 0x0014C86E
	public bool IsLoading()
	{
		return this.State == EFurnitureSceneItemState.Loading;
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x0014E679 File Offset: 0x0014C879
	public EFurnitureSceneItemType GetSceneItemType()
	{
		return this.SceneItemType;
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x0014E681 File Offset: 0x0014C881
	public bool IsEntityType()
	{
		return this.SceneItemType == EFurnitureSceneItemType.SingleEntity || this.SceneItemType == EFurnitureSceneItemType.GroupEntity;
	}

	// Token: 0x04002F41 RID: 12097
	public readonly int FurnitureConfigId;

	// Token: 0x04002F42 RID: 12098
	protected EFurnitureSceneItemType SceneItemType;

	// Token: 0x04002F43 RID: 12099
	[Nullable(2)]
	private CustomPromise<bool> LoadingPromise;

	// Token: 0x04002F44 RID: 12100
	private EFurnitureSceneItemState State;

	// Token: 0x04002F45 RID: 12101
	[Nullable(2)]
	protected Transform RootTransform;

	// Token: 0x04002F46 RID: 12102
	private bool NeedUnload;
}
