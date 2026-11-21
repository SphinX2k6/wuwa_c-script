using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200169B RID: 5787
public class LordGymThirdDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x0600E155 RID: 57685 RVA: 0x004210DA File Offset: 0x0041F2DA
	[NullableContext(1)]
	public LordGymThirdDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E156 RID: 57686 RVA: 0x004210E3 File Offset: 0x0041F2E3
	[NullableContext(1)]
	protected override LordGymDifficultyItem CreateItem()
	{
		return new LordGymThirdLevelItem
		{
			OnToggleClick = new Action<int>(base.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x0600E157 RID: 57687 RVA: 0x00421110 File Offset: 0x0041F310
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetHomeBtnShowState(true);
		}
		base.GetButton(14).OnClickCallBack.Unbind();
		base.GetButton(14).OnClickCallBack.Bind(new Action(this.OnClickClose));
		this.AddHomeBtnExitDungeonCallback();
		ILordGymDifficultySelectViewParam lordGymDifficultySelectViewParam = this.OpenParam as ILordGymDifficultySelectViewParam;
		if (lordGymDifficultySelectViewParam != null && lordGymDifficultySelectViewParam.IsPlaySpecialSequence)
		{
			this.UiViewSequence.StartSequenceName = "StartZ";
			AudioSystem.Instance.PostEvent("play_ui_daoguan_3_1_efx_boss");
			return;
		}
		this.UiViewSequence.StartSequenceName = "Start01";
	}

	// Token: 0x0600E158 RID: 57688 RVA: 0x004211C0 File Offset: 0x0041F3C0
	protected override void OnStartChallenge()
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (this.NextCanClickButtonTime > serverTimeStamp)
		{
			return;
		}
		this.NextCanClickButtonTime = serverTimeStamp + 500.0;
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

	// Token: 0x0600E159 RID: 57689 RVA: 0x00421268 File Offset: 0x0041F468
	public override void RefreshDetail()
	{
		base.RefreshDetail();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) == "Switch")
		{
			this.LevelSequencePlayer.ReplaySequenceByKey("Switch");
			return;
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
	}

	// Token: 0x0600E15A RID: 57690 RVA: 0x004212CC File Offset: 0x0041F4CC
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThirdDifficultySelectView.<OnHandlePostLoadSceneAsync>d__11 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThirdDifficultySelectView.<OnHandlePostLoadSceneAsync>d__11>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E15B RID: 57691 RVA: 0x00421310 File Offset: 0x0041F510
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThirdDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThirdDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E15C RID: 57692 RVA: 0x00421353 File Offset: 0x0041F553
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.LordEntranceId, true, true);
	}

	// Token: 0x0600E15D RID: 57693 RVA: 0x0042137C File Offset: 0x0041F57C
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymThirdDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__14_0>d <<AddHomeBtnExitDungeonCallback>b__14_0>d;
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder.Start<LordGymThirdDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__14_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__14_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0600E15E RID: 57694 RVA: 0x004213B0 File Offset: 0x0041F5B0
	private void OnClickClose()
	{
		LordGymLordEntranceSelectViewParam param = new LordGymLordEntranceSelectViewParam
		{
			EntranceSetId = this.LordEntranceSetId,
			IsPlaySpecialSequence = new bool?(false),
			NeedBlackScreenAnim = true
		};
		ALevelSequenceActor lordGymThirdBossSequenceActor = LordGymModel.Instance.GetLordGymThirdBossSequenceActor();
		if (lordGymThirdBossSequenceActor != null)
		{
			ULevelSequencePlayer sequencePlayer = lordGymThirdBossSequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayReverse();
			}
		}
		UiManager.Instance.OpenView(EUiViewName.LordGymThirdBossSelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymThirdDifficultySelectView, null);
		});
	}

	// Token: 0x040080EF RID: 33007
	private const int CLICK_CHALLENGE_BUTTON_CD = 500;

	// Token: 0x040080F0 RID: 33008
	[Nullable(2)]
	protected InstanceDungeonEntranceFlowLordGym Flow;

	// Token: 0x040080F1 RID: 33009
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040080F2 RID: 33010
	private double NextCanClickButtonTime;

	// Token: 0x040080F3 RID: 33011
	protected int LastHideLandscapeValue;

	// Token: 0x02007889 RID: 30857
	private class EComponent
	{
		// Token: 0x040271B6 RID: 160182
		public const int BackBtn = 14;
	}
}
