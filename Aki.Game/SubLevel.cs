using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A5B RID: 10843
[NullableContext(1)]
[Nullable(0)]
public class SubLevel
{
	// Token: 0x17002C83 RID: 11395
	// (get) Token: 0x0601B7E0 RID: 112608 RVA: 0x008783CE File Offset: 0x008765CE
	public bool LoadVisibleParam
	{
		get
		{
			return !this.DependOnBeginPlayLogic || this.VisibleAfterLoad;
		}
	}

	// Token: 0x17002C84 RID: 11396
	// (get) Token: 0x0601B7E1 RID: 112609 RVA: 0x008783E0 File Offset: 0x008765E0
	public bool IsVisible
	{
		get
		{
			if (this.DependOnBeginPlayLogic)
			{
				ULevelStreaming level = this.Level;
				return level != null && level.IsLevelVisible();
			}
			return this.InnerVisible;
		}
	}

	// Token: 0x0601B7E2 RID: 112610 RVA: 0x00878404 File Offset: 0x00876604
	public SubLevel(string path, bool visibleAfterLoad)
	{
		this.Path = path;
		this.VisibleAfterLoad = visibleAfterLoad;
		this.FinishDelegate = DelegateUtils.ToManualReleaseDelegate<FSetVisibleFinishDelegate>(new Action<int>(this.SetLevelVisibleFinished));
		if (this.Path.Contains("_Audio"))
		{
			this.DependOnBeginPlayLogic = true;
		}
	}

	// Token: 0x0601B7E3 RID: 112611 RVA: 0x0087846C File Offset: 0x0087666C
	public void Dispose()
	{
		if (this.SetLevelVisiblePromise != null && this.SetLevelVisiblePromise.IsPending)
		{
			this.SetLevelVisiblePromise.SetResult(false);
		}
		this.SetLevelVisiblePromise = null;
		UKuroSubLevelVisibleSubsystem subSystem = UKuroSubLevelVisibleSubsystem.GetSubSystem(GlobalData.GameInstance);
		if (subSystem != null)
		{
			subSystem.RemoveLevel(this.LinkId);
		}
		this.Level = null;
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.SetLevelVisibleFinished));
	}

	// Token: 0x0601B7E4 RID: 112612 RVA: 0x008784D4 File Offset: 0x008766D4
	[NullableContext(2)]
	public UniTask OnLevelLoad(ULevelStreaming level)
	{
		SubLevel.<OnLevelLoad>d__13 <OnLevelLoad>d__;
		<OnLevelLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnLevelLoad>d__.<>4__this = this;
		<OnLevelLoad>d__.level = level;
		<OnLevelLoad>d__.<>1__state = -1;
		<OnLevelLoad>d__.<>t__builder.Start<SubLevel.<OnLevelLoad>d__13>(ref <OnLevelLoad>d__);
		return <OnLevelLoad>d__.<>t__builder.Task;
	}

	// Token: 0x0601B7E5 RID: 112613 RVA: 0x00878520 File Offset: 0x00876720
	public UniTask SetLevelVisible(bool bVisible, string reason, bool bWaitingLoading = true)
	{
		SubLevel.<SetLevelVisible>d__14 <SetLevelVisible>d__;
		<SetLevelVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetLevelVisible>d__.<>4__this = this;
		<SetLevelVisible>d__.bVisible = bVisible;
		<SetLevelVisible>d__.reason = reason;
		<SetLevelVisible>d__.bWaitingLoading = bWaitingLoading;
		<SetLevelVisible>d__.<>1__state = -1;
		<SetLevelVisible>d__.<>t__builder.Start<SubLevel.<SetLevelVisible>d__14>(ref <SetLevelVisible>d__);
		return <SetLevelVisible>d__.<>t__builder.Task;
	}

	// Token: 0x0601B7E6 RID: 112614 RVA: 0x0087857C File Offset: 0x0087677C
	private UniTask SetLevelVisibleWithBeginPlay(ULevelStreaming level, bool bVisible, string reason)
	{
		SubLevel.<SetLevelVisibleWithBeginPlay>d__20 <SetLevelVisibleWithBeginPlay>d__;
		<SetLevelVisibleWithBeginPlay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetLevelVisibleWithBeginPlay>d__.<>4__this = this;
		<SetLevelVisibleWithBeginPlay>d__.level = level;
		<SetLevelVisibleWithBeginPlay>d__.bVisible = bVisible;
		<SetLevelVisibleWithBeginPlay>d__.<>1__state = -1;
		<SetLevelVisibleWithBeginPlay>d__.<>t__builder.Start<SubLevel.<SetLevelVisibleWithBeginPlay>d__20>(ref <SetLevelVisibleWithBeginPlay>d__);
		return <SetLevelVisibleWithBeginPlay>d__.<>t__builder.Task;
	}

	// Token: 0x0601B7E7 RID: 112615 RVA: 0x008785D0 File Offset: 0x008767D0
	private UniTask SetLevelVisibleNoBeginPlay(bool bVisible, string reason)
	{
		SubLevel.<SetLevelVisibleNoBeginPlay>d__21 <SetLevelVisibleNoBeginPlay>d__;
		<SetLevelVisibleNoBeginPlay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetLevelVisibleNoBeginPlay>d__.<>4__this = this;
		<SetLevelVisibleNoBeginPlay>d__.bVisible = bVisible;
		<SetLevelVisibleNoBeginPlay>d__.reason = reason;
		<SetLevelVisibleNoBeginPlay>d__.<>1__state = -1;
		<SetLevelVisibleNoBeginPlay>d__.<>t__builder.Start<SubLevel.<SetLevelVisibleNoBeginPlay>d__21>(ref <SetLevelVisibleNoBeginPlay>d__);
		return <SetLevelVisibleNoBeginPlay>d__.<>t__builder.Task;
	}

	// Token: 0x0601B7E8 RID: 112616 RVA: 0x00878623 File Offset: 0x00876823
	private void SetLevelVisibleFinished(int linkId)
	{
		if (linkId != this.LinkId)
		{
			return;
		}
		CustomPromise<bool> setLevelVisiblePromise = this.SetLevelVisiblePromise;
		if (setLevelVisiblePromise == null)
		{
			return;
		}
		setLevelVisiblePromise.SetResult(true);
	}

	// Token: 0x0400ED87 RID: 60807
	public ELoadLevelType LoadState;

	// Token: 0x0400ED88 RID: 60808
	[Nullable(2)]
	public ULevelStreaming Level;

	// Token: 0x0400ED89 RID: 60809
	public int LinkId;

	// Token: 0x0400ED8A RID: 60810
	public int UnLoadLinkId;

	// Token: 0x0400ED8B RID: 60811
	public readonly bool DependOnBeginPlayLogic;

	// Token: 0x0400ED8C RID: 60812
	public readonly GameModePromise LoadPromise = new GameModePromise();

	// Token: 0x0400ED8D RID: 60813
	public readonly GameModePromise UnLoadPromise = new GameModePromise();

	// Token: 0x0400ED8E RID: 60814
	private bool InnerVisible;

	// Token: 0x0400ED8F RID: 60815
	public readonly string Path;

	// Token: 0x0400ED90 RID: 60816
	public readonly bool VisibleAfterLoad;

	// Token: 0x0400ED91 RID: 60817
	[Nullable(2)]
	private CustomPromise<bool> SetLevelVisiblePromise;

	// Token: 0x0400ED92 RID: 60818
	private FSetVisibleFinishDelegate FinishDelegate;
}
