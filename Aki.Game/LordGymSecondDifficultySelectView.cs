using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001694 RID: 5780
public class LordGymSecondDifficultySelectView : LordGymDifficultySelectView
{
	// Token: 0x0600E0FE RID: 57598 RVA: 0x0041FB5A File Offset: 0x0041DD5A
	[NullableContext(1)]
	public LordGymSecondDifficultySelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0FF RID: 57599 RVA: 0x0041FB63 File Offset: 0x0041DD63
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x0600E100 RID: 57600 RVA: 0x0041FB6B File Offset: 0x0041DD6B
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

	// Token: 0x0600E101 RID: 57601 RVA: 0x0041FB9C File Offset: 0x0041DD9C
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

	// Token: 0x0600E102 RID: 57602 RVA: 0x0041FC54 File Offset: 0x0041DE54
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
