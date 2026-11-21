using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000B3F RID: 2879
[NullableContext(1)]
[Nullable(0)]
public abstract class ActivitySubViewBase : UiPanelBase
{
	// Token: 0x06007741 RID: 30529 RVA: 0x0024C8F4 File Offset: 0x0024AAF4
	protected sealed override void OnBeforeShowImplement()
	{
		this.ClearTimer();
		ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStartPrivate));
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClosePrivate), false);
		}
		this.OnTimerRefresh((float)TimeUtil.Instance.InverseMillisecond);
		this.OnAddEventListener();
	}

	// Token: 0x06007742 RID: 30530 RVA: 0x0024C97C File Offset: 0x0024AB7C
	private void OnSequenceStartPrivate(string sequenceName)
	{
		this.OnSequenceStart(sequenceName);
	}

	// Token: 0x06007743 RID: 30531 RVA: 0x0024C985 File Offset: 0x0024AB85
	protected virtual void OnSequenceStart(string sequenceName)
	{
	}

	// Token: 0x06007744 RID: 30532 RVA: 0x0024C987 File Offset: 0x0024AB87
	private void OnSequenceClosePrivate(string sequenceName)
	{
		this.OnSequenceClose(sequenceName);
	}

	// Token: 0x06007745 RID: 30533 RVA: 0x0024C990 File Offset: 0x0024AB90
	protected virtual void OnSequenceClose(string sequenceName)
	{
	}

	// Token: 0x06007746 RID: 30534 RVA: 0x0024C992 File Offset: 0x0024AB92
	protected override void OnAfterHideImplement()
	{
		this.ClearTimer();
		this.OnRemoveEventListener();
	}

	// Token: 0x06007747 RID: 30535 RVA: 0x0024C9A0 File Offset: 0x0024ABA0
	private void OnTimerRefresh(float delta)
	{
		this.OnTimer((float)TimeUtil.Instance.InverseMillisecond);
	}

	// Token: 0x06007748 RID: 30536 RVA: 0x0024C9B3 File Offset: 0x0024ABB3
	private void ClearTimer()
	{
		ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
	}

	// Token: 0x06007749 RID: 30537 RVA: 0x0024C9CB File Offset: 0x0024ABCB
	public void SetData(ActivityBaseData data)
	{
		this.ActivityBaseData = data;
		this.OnSetData();
	}

	// Token: 0x0600774A RID: 30538 RVA: 0x0024C9DA File Offset: 0x0024ABDA
	public void SetOpenParam(object param)
	{
		this.OpenParam = param;
	}

	// Token: 0x0600774B RID: 30539 RVA: 0x0024C9E3 File Offset: 0x0024ABE3
	protected virtual void OnSetData()
	{
	}

	// Token: 0x0600774C RID: 30540 RVA: 0x0024C9E5 File Offset: 0x0024ABE5
	public void RefreshView()
	{
		if (this.ActivityBaseData != null)
		{
			ActivityModel.Instance.SendActivityTabViewOpenLogData(this.ActivityBaseData);
		}
		this.OnRefreshView();
	}

	// Token: 0x0600774D RID: 30541 RVA: 0x0024CA08 File Offset: 0x0024AC08
	public UniTask BeforeShowSelfAsync()
	{
		ActivitySubViewBase.<BeforeShowSelfAsync>d__16 <BeforeShowSelfAsync>d__;
		<BeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeShowSelfAsync>d__.<>4__this = this;
		<BeforeShowSelfAsync>d__.<>1__state = -1;
		<BeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewBase.<BeforeShowSelfAsync>d__16>(ref <BeforeShowSelfAsync>d__);
		return <BeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600774E RID: 30542 RVA: 0x0024CA4C File Offset: 0x0024AC4C
	public UniTask BeforeHideSelfAsync()
	{
		ActivitySubViewBase.<BeforeHideSelfAsync>d__17 <BeforeHideSelfAsync>d__;
		<BeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeHideSelfAsync>d__.<>4__this = this;
		<BeforeHideSelfAsync>d__.<>1__state = -1;
		<BeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewBase.<BeforeHideSelfAsync>d__17>(ref <BeforeHideSelfAsync>d__);
		return <BeforeHideSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600774F RID: 30543 RVA: 0x0024CA8F File Offset: 0x0024AC8F
	public virtual void OnCommonViewStateChange(bool show)
	{
	}

	// Token: 0x06007750 RID: 30544 RVA: 0x0024CA91 File Offset: 0x0024AC91
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06007751 RID: 30545 RVA: 0x0024CA93 File Offset: 0x0024AC93
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06007752 RID: 30546 RVA: 0x0024CA95 File Offset: 0x0024AC95
	protected virtual void OnRefreshView()
	{
	}

	// Token: 0x06007753 RID: 30547 RVA: 0x0024CA97 File Offset: 0x0024AC97
	protected virtual UniTask OnBeforeShowSelfAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06007754 RID: 30548 RVA: 0x0024CA9E File Offset: 0x0024AC9E
	protected virtual UniTask OnBeforeHideSelfAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06007755 RID: 30549 RVA: 0x0024CAA5 File Offset: 0x0024ACA5
	[NullableContext(2)]
	public virtual string GetBgm()
	{
		return null;
	}

	// Token: 0x06007756 RID: 30550 RVA: 0x0024CAA8 File Offset: 0x0024ACA8
	public virtual void PlaySubViewSequence(string name, bool blockClick = false)
	{
		if (this.LevelSequencePlayer.CheckSeqActorIsSeqPlaying(name))
		{
			this.LevelSequencePlayer.ReplaySequenceByKey(name);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName(name, blockClick, null, false);
	}

	// Token: 0x06007757 RID: 30551 RVA: 0x0024CAE7 File Offset: 0x0024ACE7
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected virtual ValueTuple<bool, string, long> GetTimeVisibleAndRemainTime()
	{
		return ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
	}

	// Token: 0x06007758 RID: 30552 RVA: 0x0024CAFA File Offset: 0x0024ACFA
	protected virtual string GetCurrentLockConditionText()
	{
		if (this.ActivityBaseData.IsUnLock())
		{
			return "";
		}
		return LevelGeneralCommons.GetConditionGroupHintText(this.ActivityBaseData.ConditionGroupId) ?? "";
	}

	// Token: 0x06007759 RID: 30553 RVA: 0x0024CB28 File Offset: 0x0024AD28
	protected virtual void OnTimer(float gap)
	{
	}

	// Token: 0x0600775A RID: 30554 RVA: 0x0024CB2A File Offset: 0x0024AD2A
	protected sealed override void OnBeforeDestroyImplement()
	{
		this.ClearTimer();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x04004AE6 RID: 19174
	protected string ActivityRemainTimeText = "";

	// Token: 0x04004AE7 RID: 19175
	[Nullable(2)]
	protected ActivityBaseData ActivityBaseData;

	// Token: 0x04004AE8 RID: 19176
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004AE9 RID: 19177
	[Nullable(2)]
	protected object SubViewOpenParam;
}
