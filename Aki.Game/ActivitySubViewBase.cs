using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001687 RID: 5767
[NullableContext(1)]
[Nullable(0)]
public abstract class ActivitySubViewBase : UiPanelBase
{
	// Token: 0x0600A364 RID: 41828 RVA: 0x0024288C File Offset: 0x00240A8C
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

	// Token: 0x0600A365 RID: 41829 RVA: 0x00242914 File Offset: 0x00240B14
	private void OnSequenceStartPrivate(string sequenceName)
	{
		this.OnSequenceStart(sequenceName);
	}

	// Token: 0x0600A366 RID: 41830 RVA: 0x0024291D File Offset: 0x00240B1D
	protected virtual void OnSequenceStart(string sequenceName)
	{
	}

	// Token: 0x0600A367 RID: 41831 RVA: 0x0024291F File Offset: 0x00240B1F
	private void OnSequenceClosePrivate(string sequenceName)
	{
		this.OnSequenceClose(sequenceName);
	}

	// Token: 0x0600A368 RID: 41832 RVA: 0x00242928 File Offset: 0x00240B28
	protected virtual void OnSequenceClose(string sequenceName)
	{
	}

	// Token: 0x0600A369 RID: 41833 RVA: 0x0024292A File Offset: 0x00240B2A
	protected override void OnAfterHideImplement()
	{
		this.ClearTimer();
		this.OnRemoveEventListener();
	}

	// Token: 0x0600A36A RID: 41834 RVA: 0x00242938 File Offset: 0x00240B38
	private void OnTimerRefresh(float delta)
	{
		this.OnTimer((float)TimeUtil.Instance.InverseMillisecond);
	}

	// Token: 0x0600A36B RID: 41835 RVA: 0x0024294B File Offset: 0x00240B4B
	private void ClearTimer()
	{
		ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
	}

	// Token: 0x0600A36C RID: 41836 RVA: 0x00242963 File Offset: 0x00240B63
	public void SetData(ActivityBaseData data)
	{
		this.ActivityBaseData = data;
		this.OnSetData();
	}

	// Token: 0x0600A36D RID: 41837 RVA: 0x00242972 File Offset: 0x00240B72
	public void SetOpenParam(object param)
	{
		this.OpenParam = param;
	}

	// Token: 0x0600A36E RID: 41838 RVA: 0x0024297B File Offset: 0x00240B7B
	protected virtual void OnSetData()
	{
	}

	// Token: 0x0600A36F RID: 41839 RVA: 0x0024297D File Offset: 0x00240B7D
	public void RefreshView()
	{
		if (this.ActivityBaseData != null)
		{
			ActivityModel.Instance.SendActivityTabViewOpenLogData(this.ActivityBaseData);
		}
		this.OnRefreshView();
	}

	// Token: 0x0600A370 RID: 41840 RVA: 0x002429A0 File Offset: 0x00240BA0
	public UniTask BeforeShowSelfAsync()
	{
		ActivitySubViewBase.<BeforeShowSelfAsync>d__16 <BeforeShowSelfAsync>d__;
		<BeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeShowSelfAsync>d__.<>4__this = this;
		<BeforeShowSelfAsync>d__.<>1__state = -1;
		<BeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewBase.<BeforeShowSelfAsync>d__16>(ref <BeforeShowSelfAsync>d__);
		return <BeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A371 RID: 41841 RVA: 0x002429E4 File Offset: 0x00240BE4
	public UniTask BeforeHideSelfAsync()
	{
		ActivitySubViewBase.<BeforeHideSelfAsync>d__17 <BeforeHideSelfAsync>d__;
		<BeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeHideSelfAsync>d__.<>4__this = this;
		<BeforeHideSelfAsync>d__.<>1__state = -1;
		<BeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewBase.<BeforeHideSelfAsync>d__17>(ref <BeforeHideSelfAsync>d__);
		return <BeforeHideSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A372 RID: 41842 RVA: 0x00242A27 File Offset: 0x00240C27
	public virtual void OnCommonViewStateChange(bool show)
	{
	}

	// Token: 0x0600A373 RID: 41843 RVA: 0x00242A29 File Offset: 0x00240C29
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600A374 RID: 41844 RVA: 0x00242A2B File Offset: 0x00240C2B
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600A375 RID: 41845 RVA: 0x00242A2D File Offset: 0x00240C2D
	protected virtual void OnRefreshView()
	{
	}

	// Token: 0x0600A376 RID: 41846 RVA: 0x00242A2F File Offset: 0x00240C2F
	protected virtual UniTask OnBeforeShowSelfAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A377 RID: 41847 RVA: 0x00242A36 File Offset: 0x00240C36
	protected virtual UniTask OnBeforeHideSelfAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A378 RID: 41848 RVA: 0x00242A40 File Offset: 0x00240C40
	public virtual void PlaySubViewSequence(string name, bool blockClick = false)
	{
		if (this.LevelSequencePlayer.CheckSeqActorIsSeqPlaying(name))
		{
			this.LevelSequencePlayer.ReplaySequenceByKey(name);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName(name, blockClick, null, false);
	}

	// Token: 0x0600A379 RID: 41849 RVA: 0x00242A7F File Offset: 0x00240C7F
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected virtual ValueTuple<bool, string, long> GetTimeVisibleAndRemainTime()
	{
		return ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
	}

	// Token: 0x0600A37A RID: 41850 RVA: 0x00242A92 File Offset: 0x00240C92
	protected virtual string GetCurrentLockConditionText()
	{
		if (this.ActivityBaseData.IsUnLock())
		{
			return "";
		}
		return LevelGeneralCommons.GetConditionGroupHintText(this.ActivityBaseData.ConditionGroupId) ?? "";
	}

	// Token: 0x0600A37B RID: 41851 RVA: 0x00242AC0 File Offset: 0x00240CC0
	protected virtual void OnTimer(float gap)
	{
	}

	// Token: 0x0600A37C RID: 41852 RVA: 0x00242AC2 File Offset: 0x00240CC2
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

	// Token: 0x04004A3F RID: 19007
	protected string ActivityRemainTimeText = "";

	// Token: 0x04004A40 RID: 19008
	[Nullable(2)]
	protected ActivityBaseData ActivityBaseData;

	// Token: 0x04004A41 RID: 19009
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004A42 RID: 19010
	[Nullable(2)]
	protected object SubViewOpenParam;
}
