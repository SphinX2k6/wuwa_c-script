using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020034E7 RID: 13543
[NullableContext(1)]
[Nullable(0)]
public class SubLevel
{
	// Token: 0x170028EB RID: 10475
	// (get) Token: 0x0601DAD2 RID: 121554 RVA: 0x00850056 File Offset: 0x0084E256
	public bool LoadVisibleParam
	{
		get
		{
			return !this.DependOnBeginPlayLogic || this.VisibleAfterLoad;
		}
	}

	// Token: 0x170028EC RID: 10476
	// (get) Token: 0x0601DAD3 RID: 121555 RVA: 0x00850068 File Offset: 0x0084E268
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

	// Token: 0x0601DAD4 RID: 121556 RVA: 0x0085008C File Offset: 0x0084E28C
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

	// Token: 0x0601DAD5 RID: 121557 RVA: 0x008500F4 File Offset: 0x0084E2F4
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

	// Token: 0x0601DAD6 RID: 121558 RVA: 0x0085015C File Offset: 0x0084E35C
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

	// Token: 0x0601DAD7 RID: 121559 RVA: 0x008501A8 File Offset: 0x0084E3A8
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

	// Token: 0x0601DAD8 RID: 121560 RVA: 0x00850204 File Offset: 0x0084E404
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

	// Token: 0x0601DAD9 RID: 121561 RVA: 0x00850258 File Offset: 0x0084E458
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

	// Token: 0x0601DADA RID: 121562 RVA: 0x008502AB File Offset: 0x0084E4AB
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

	// Token: 0x0400E8D0 RID: 59600
	public ELoadLevelType LoadState;

	// Token: 0x0400E8D1 RID: 59601
	[Nullable(2)]
	public ULevelStreaming Level;

	// Token: 0x0400E8D2 RID: 59602
	public int LinkId;

	// Token: 0x0400E8D3 RID: 59603
	public int UnLoadLinkId;

	// Token: 0x0400E8D4 RID: 59604
	public readonly bool DependOnBeginPlayLogic;

	// Token: 0x0400E8D5 RID: 59605
	public readonly GameModePromise LoadPromise = new GameModePromise();

	// Token: 0x0400E8D6 RID: 59606
	public readonly GameModePromise UnLoadPromise = new GameModePromise();

	// Token: 0x0400E8D7 RID: 59607
	private bool InnerVisible;

	// Token: 0x0400E8D8 RID: 59608
	public readonly string Path;

	// Token: 0x0400E8D9 RID: 59609
	public readonly bool VisibleAfterLoad;

	// Token: 0x0400E8DA RID: 59610
	[Nullable(2)]
	private CustomPromise<bool> SetLevelVisiblePromise;

	// Token: 0x0400E8DB RID: 59611
	private FSetVisibleFinishDelegate FinishDelegate;
}
