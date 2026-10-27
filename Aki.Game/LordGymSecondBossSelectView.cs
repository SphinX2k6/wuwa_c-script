using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020021AF RID: 8623
public class LordGymSecondBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x06010C65 RID: 68709 RVA: 0x004130BC File Offset: 0x004112BC
	[NullableContext(1)]
	public LordGymSecondBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C66 RID: 68710 RVA: 0x004130C5 File Offset: 0x004112C5
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x06010C67 RID: 68711 RVA: 0x004130CD File Offset: 0x004112CD
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

	// Token: 0x06010C68 RID: 68712 RVA: 0x00413100 File Offset: 0x00411300
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

	// Token: 0x06010C69 RID: 68713 RVA: 0x00413154 File Offset: 0x00411354
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

	// Token: 0x06010C6A RID: 68714 RVA: 0x004131F0 File Offset: 0x004113F0
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
