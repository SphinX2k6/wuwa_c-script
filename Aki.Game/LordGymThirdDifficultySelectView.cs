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

// Token: 0x020021B7 RID: 8631
public class LordGymThirdDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x06010CC4 RID: 68804 RVA: 0x004147FA File Offset: 0x004129FA
	[NullableContext(1)]
	public LordGymThirdDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010CC5 RID: 68805 RVA: 0x00414803 File Offset: 0x00412A03
	[NullableContext(1)]
	protected override LordGymDifficultyItem CreateItem()
	{
		return new LordGymThirdLevelItem
		{
			OnToggleClick = new Action<int>(base.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x06010CC6 RID: 68806 RVA: 0x00414830 File Offset: 0x00412A30
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

	// Token: 0x06010CC7 RID: 68807 RVA: 0x004148E0 File Offset: 0x00412AE0
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

	// Token: 0x06010CC8 RID: 68808 RVA: 0x00414988 File Offset: 0x00412B88
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

	// Token: 0x06010CC9 RID: 68809 RVA: 0x004149EC File Offset: 0x00412BEC
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThirdDifficultySelectView.<OnHandlePostLoadSceneAsync>d__11 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThirdDifficultySelectView.<OnHandlePostLoadSceneAsync>d__11>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CCA RID: 68810 RVA: 0x00414A30 File Offset: 0x00412C30
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThirdDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThirdDifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CCB RID: 68811 RVA: 0x00414A73 File Offset: 0x00412C73
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.LordEntranceId, true, true);
	}

	// Token: 0x06010CCC RID: 68812 RVA: 0x00414A9C File Offset: 0x00412C9C
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

	// Token: 0x06010CCD RID: 68813 RVA: 0x00414AD0 File Offset: 0x00412CD0
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

	// Token: 0x04007FA8 RID: 32680
	private const int CLICK_CHALLENGE_BUTTON_CD = 500;

	// Token: 0x04007FA9 RID: 32681
	[Nullable(2)]
	protected InstanceDungeonEntranceFlowLordGym Flow;

	// Token: 0x04007FAA RID: 32682
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007FAB RID: 32683
	private double NextCanClickButtonTime;

	// Token: 0x04007FAC RID: 32684
	protected int LastHideLandscapeValue;

	// Token: 0x020086FE RID: 34558
	private class EComponent
	{
		// Token: 0x0402BE95 RID: 179861
		public const int BackBtn = 14;
	}
}
