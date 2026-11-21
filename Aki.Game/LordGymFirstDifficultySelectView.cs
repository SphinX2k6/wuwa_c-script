using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200168A RID: 5770
[NullableContext(1)]
[Nullable(0)]
public class LordGymFirstDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x0600E09E RID: 57502 RVA: 0x0041ECCD File Offset: 0x0041CECD
	public LordGymFirstDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E09F RID: 57503 RVA: 0x0041ECD8 File Offset: 0x0041CED8
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymFirstDifficultySelectView.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0A0 RID: 57504 RVA: 0x0041ED1B File Offset: 0x0041CF1B
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x0600E0A1 RID: 57505 RVA: 0x0041ED24 File Offset: 0x0041CF24
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymFirstDifficultySelectView.<OnHandlePostLoadSceneAsync>d__3 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnHandlePostLoadSceneAsync>d__3>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0A2 RID: 57506 RVA: 0x0041ED68 File Offset: 0x0041CF68
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymFirstDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__4 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymFirstDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__4>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0A3 RID: 57507 RVA: 0x0041EDAB File Offset: 0x0041CFAB
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

	// Token: 0x0600E0A4 RID: 57508 RVA: 0x0041EDDC File Offset: 0x0041CFDC
	protected override LordGymDifficultyItem CreateItem()
	{
		return new LordGymFirstDifficultyItem
		{
			OnToggleClick = new Action<int>(base.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x0600E0A5 RID: 57509 RVA: 0x0041EE08 File Offset: 0x0041D008
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

	// Token: 0x0600E0A6 RID: 57510 RVA: 0x0041EEC0 File Offset: 0x0041D0C0
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
