using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020021A6 RID: 8614
[NullableContext(1)]
[Nullable(0)]
public class LordGymFirstDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x06010C0D RID: 68621 RVA: 0x004123E5 File Offset: 0x004105E5
	public LordGymFirstDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C0E RID: 68622 RVA: 0x004123F0 File Offset: 0x004105F0
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymFirstDifficultySelectView.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C0F RID: 68623 RVA: 0x00412433 File Offset: 0x00410633
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x06010C10 RID: 68624 RVA: 0x0041243C File Offset: 0x0041063C
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymFirstDifficultySelectView.<OnHandlePostLoadSceneAsync>d__3 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnHandlePostLoadSceneAsync>d__3>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C11 RID: 68625 RVA: 0x00412480 File Offset: 0x00410680
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymFirstDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__4 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__4>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C12 RID: 68626 RVA: 0x004124C3 File Offset: 0x004106C3
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymFirstDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__5_0>d <<AddHomeBtnExitDungeonCallback>b__5_0>d;
			<<AddHomeBtnExitDungeonCallback>b__5_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__5_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__5_0>d.<>t__builder.Start<LordGymFirstDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__5_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__5_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__5_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010C13 RID: 68627 RVA: 0x004124F4 File Offset: 0x004106F4
	protected override LordGymDifficultyItem CreateItem()
	{
		return new LordGymFirstDifficultyItem
		{
			OnToggleClick = new Action<int>(base.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x06010C14 RID: 68628 RVA: 0x00412520 File Offset: 0x00410720
	protected override void OnStartChallenge()
	{
		if (!LordGymModel.Instance.LastChallengeEntryFromGuide)
		{
			base.OnStartChallenge();
			return;
		}
		if (!LordGymController.Instance.IsInEntranceEntity())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("LordGymOpen_ErrorTipText", Array.Empty<object>());
			return;
		}
		int selectedGridIndex = this.LordDifficultyScrollView.GetSelectedGridIndex();
		int entryChallengeId = this.LordList[selectedGridIndex];
		LordGymModel.Instance.EntryChallengeId = entryChallengeId;
		LordGymEntranceSet? config = ConfigLordGymEntranceSetById.GetConfig(this.LordEntranceSetId, true);
		if (config == null)
		{
			return;
		}
		InstanceDungeonEntranceModel.Instance.InstanceId = config.Value.DungeonId;
		if (LordGymController.Instance.IsInLordGymDungeon())
		{
			InstanceDungeonEntranceController.Instance.RestartEntranceFlow();
		}
		InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
	}

	// Token: 0x06010C15 RID: 68629 RVA: 0x004125D8 File Offset: 0x004107D8
	protected override void OnCloseBtnClick()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.LordGymFirstBossSelectView) || UiManager.Instance.IsViewHide(EUiViewName.LordGymFirstBossSelectView))
		{
			base.CloseMe(null);
			return;
		}
		LordGymLordEntranceSelectViewParam param = new LordGymLordEntranceSelectViewParam
		{
			EntranceSetId = this.LordEntranceSetId,
			IsPlaySpecialSequence = new bool?(false),
			NeedBlackScreenAnim = false
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymFirstBossSelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymFirstDifficultySelectView, null);
		});
	}
}
