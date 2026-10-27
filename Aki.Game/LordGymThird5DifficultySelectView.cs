using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020021B2 RID: 8626
public class LordGymThird5DifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x06010C8B RID: 68747 RVA: 0x0041390A File Offset: 0x00411B0A
	[NullableContext(1)]
	public LordGymThird5DifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C8C RID: 68748 RVA: 0x00413913 File Offset: 0x00411B13
	[NullableContext(1)]
	protected override LordGymDifficultyItem CreateItem()
	{
		return new LordGymThirdLevelItem
		{
			OnToggleClick = new Action<int>(base.OnLordDifficultyToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordDifficultyToggleChange)
		};
	}

	// Token: 0x06010C8D RID: 68749 RVA: 0x00413940 File Offset: 0x00411B40
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
			return;
		}
		this.UiViewSequence.StartSequenceName = "Start01";
	}

	// Token: 0x06010C8E RID: 68750 RVA: 0x004139E0 File Offset: 0x00411BE0
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

	// Token: 0x06010C8F RID: 68751 RVA: 0x00413A88 File Offset: 0x00411C88
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

	// Token: 0x06010C90 RID: 68752 RVA: 0x00413AEC File Offset: 0x00411CEC
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThird5DifficultySelectView.<OnHandlePostLoadSceneAsync>d__11 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThird5DifficultySelectView.<OnHandlePostLoadSceneAsync>d__11>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C91 RID: 68753 RVA: 0x00413B30 File Offset: 0x00411D30
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThird5DifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThird5DifficultySelectView.<OnHandlePreReleaseSceneAsync>d__12>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C92 RID: 68754 RVA: 0x00413B73 File Offset: 0x00411D73
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceIdThird5(this.LordEntranceId, true, true);
	}

	// Token: 0x06010C93 RID: 68755 RVA: 0x00413B9C File Offset: 0x00411D9C
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymThird5DifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__14_0>d <<AddHomeBtnExitDungeonCallback>b__14_0>d;
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder.Start<LordGymThird5DifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__14_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__14_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__14_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010C94 RID: 68756 RVA: 0x00413BD0 File Offset: 0x00411DD0
	private void OnClickClose()
	{
		LordGymLordEntranceSelectViewParam param = new LordGymLordEntranceSelectViewParam
		{
			EntranceSetId = this.LordEntranceSetId,
			IsPlaySpecialSequence = new bool?(false),
			NeedBlackScreenAnim = true
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymThird5BossSelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymThird5DifficultySelectView, null);
		});
	}

	// Token: 0x04007F9D RID: 32669
	private const int CLICK_CHALLENGE_BUTTON_CD = 500;

	// Token: 0x04007F9E RID: 32670
	[Nullable(2)]
	protected InstanceDungeonEntranceFlowLordGym Flow;

	// Token: 0x04007F9F RID: 32671
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007FA0 RID: 32672
	private double NextCanClickButtonTime;

	// Token: 0x04007FA1 RID: 32673
	protected int LastHideLandscapeValue;

	// Token: 0x020086EE RID: 34542
	private class EComponent
	{
		// Token: 0x0402BE5E RID: 179806
		public const int BackBtn = 14;
	}
}
