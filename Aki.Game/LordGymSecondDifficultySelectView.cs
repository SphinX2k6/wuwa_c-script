using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020021B0 RID: 8624
public class LordGymSecondDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x06010C6D RID: 68717 RVA: 0x00413272 File Offset: 0x00411472
	[NullableContext(1)]
	public LordGymSecondDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C6E RID: 68718 RVA: 0x0041327B File Offset: 0x0041147B
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x06010C6F RID: 68719 RVA: 0x00413283 File Offset: 0x00411483
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymSecondDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__2_0>d <<AddHomeBtnExitDungeonCallback>b__2_0>d;
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder.Start<LordGymSecondDifficultySelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__2_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__2_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010C70 RID: 68720 RVA: 0x004132B4 File Offset: 0x004114B4
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

	// Token: 0x06010C71 RID: 68721 RVA: 0x0041336C File Offset: 0x0041156C
	protected override void OnCloseBtnClick()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.LordGymSecondBossSelectView) || UiManager.Instance.IsViewHide(EUiViewName.LordGymSecondBossSelectView))
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
		UiManager.Instance.OpenView(EUiViewName.LordGymSecondBossSelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymSecondDifficultySelectView, null);
		});
	}
}
