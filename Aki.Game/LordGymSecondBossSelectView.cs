using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001693 RID: 5779
public class LordGymSecondBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x0600E0F6 RID: 57590 RVA: 0x0041F9A4 File Offset: 0x0041DBA4
	[NullableContext(1)]
	public LordGymSecondBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0F7 RID: 57591 RVA: 0x0041F9AD File Offset: 0x0041DBAD
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x0600E0F8 RID: 57592 RVA: 0x0041F9B5 File Offset: 0x0041DBB5
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymSecondBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__2_0>d <<AddHomeBtnExitDungeonCallback>b__2_0>d;
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder.Start<LordGymSecondBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__2_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__2_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__2_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0600E0F9 RID: 57593 RVA: 0x0041F9E8 File Offset: 0x0041DBE8
	protected override void OpenSelectView()
	{
		LordGymModel.Instance.EntranceEntityId = this.SelectedEntranceId;
		LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
		{
			LordEntranceSetId = this.EntranceSetId,
			LordEntranceId = this.SelectedEntranceId,
			IsPlaySpecialSequence = false
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymSecondDifficultySelectView, param, null);
	}

	// Token: 0x0600E0FA RID: 57594 RVA: 0x0041FA3C File Offset: 0x0041DC3C
	protected override void InitSelect()
	{
		int index = 0;
		int entranceEntityId = LordGymModel.Instance.EntranceEntityId;
		if (entranceEntityId > 0 && this.LordEntranceList != null)
		{
			int num = this.LordEntranceList.IndexOf(entranceEntityId);
			if (num >= 0)
			{
				index = num;
			}
		}
		this.SelectLordEntranceByIndex(index);
		base.ScrollEntranceIntoView(index);
		base.RefreshLordGymCurrency();
		LordGymModel instance = LordGymModel.Instance;
		foreach (int entranceId in this.LordEntranceList)
		{
			instance.RecordNewLordGymEntrance(entranceId);
		}
	}

	// Token: 0x0600E0FB RID: 57595 RVA: 0x0041FAD8 File Offset: 0x0041DCD8
	protected override void OnCloseBtnClick()
	{
		if (!LordGymController.Instance.IsInLordGymDungeon())
		{
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GuideLordGymExitChallengeConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
			{
				base.CloseMe(null);
			}).Forget();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}
}
