using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020007B7 RID: 1975
[NullableContext(1)]
[Nullable(0)]
public class BusinessViewController
{
	// Token: 0x06005A70 RID: 23152 RVA: 0x001D56F8 File Offset: 0x001D38F8
	private void InitViewStateManager()
	{
		this.ViewStateManager.RegisterViewState(EBusinessSkipDefine.MainView, null, new Action(this.View.SkipToMainView));
		this.ViewStateManager.RegisterViewState(EBusinessSkipDefine.DelegationDetails, null, new Action<object[]>(this.View.SkipToDelegationDetails));
	}

	// Token: 0x06005A71 RID: 23153 RVA: 0x001D5736 File Offset: 0x001D3936
	public void RegisterView(BusinessMainView view)
	{
		this.View = view;
		this.Model = (MoonChasingBusinessViewModel)view.OpenParam;
		this.InitViewStateManager();
	}

	// Token: 0x06005A72 RID: 23154 RVA: 0x001D5758 File Offset: 0x001D3958
	public UniTask BeforeShowAsync()
	{
		BusinessViewController.<BeforeShowAsync>d__7 <BeforeShowAsync>d__;
		<BeforeShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeShowAsync>d__.<>4__this = this;
		<BeforeShowAsync>d__.<>1__state = -1;
		<BeforeShowAsync>d__.<>t__builder.Start<BusinessViewController.<BeforeShowAsync>d__7>(ref <BeforeShowAsync>d__);
		return <BeforeShowAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A73 RID: 23155 RVA: 0x001D579C File Offset: 0x001D399C
	public void Show()
	{
		if (this.Model.SkipTarget != EBusinessSkipDefine.MainView)
		{
			this.ViewStateManager.SwitchToState(this.Model.SkipTarget, Array.Empty<object>());
		}
		else
		{
			this.View.Refresh();
		}
		bool inMainView = this.ViewStateManager.CurrentState == EBusinessSkipDefine.MainView;
		this.View.SwitchShowViewSequence(inMainView);
	}

	// Token: 0x06005A74 RID: 23156 RVA: 0x001D57F9 File Offset: 0x001D39F9
	public void SwitchToState(EBusinessSkipDefine state, params object[] params_)
	{
		this.ViewStateManager.SwitchToState(state, params_);
	}

	// Token: 0x06005A75 RID: 23157 RVA: 0x001D5808 File Offset: 0x001D3A08
	public void BackToState(EBusinessSkipDefine state)
	{
		this.ViewStateManager.BackToState(state);
	}

	// Token: 0x06005A76 RID: 23158 RVA: 0x001D5818 File Offset: 0x001D3A18
	public void SkipToBuild()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView);
		MoonChasingMainViewModel moonChasingMainViewModel = ((viewByName != null) ? viewByName.OpenParam : null) as MoonChasingMainViewModel;
		if (moonChasingMainViewModel != null)
		{
			moonChasingMainViewModel.SkipTarget = EMoonChasingSkipDefine.Build;
			moonChasingMainViewModel.BuildingBackToBusiness = true;
		}
		UiManager.Instance.NormalResetToView(EUiViewName.MoonChasingMainView, null, true);
	}

	// Token: 0x06005A77 RID: 23159 RVA: 0x001D5868 File Offset: 0x001D3A68
	public void SkipToHelper()
	{
		MoonChasingController.Instance.OpenHelperView();
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x001D5874 File Offset: 0x001D3A74
	public void JumpByConfigCondition(int id)
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(id);
		if (delegationConfig.JumpType == 1)
		{
			this.JumpToMainTask(delegationConfig.JumpParam);
			return;
		}
		if (delegationConfig.JumpType == 2)
		{
			this.JumpToBranchTask(delegationConfig.JumpParam);
			return;
		}
		if (delegationConfig.JumpType == 3)
		{
			this.JumpToBuilding(delegationConfig.JumpParam);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("Moonfiesta_EntrustLock", Array.Empty<object>());
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x001D58EC File Offset: 0x001D3AEC
	private void JumpToMainTask(int mainTaskId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessJumpToTask);
		MainLine? mainLineTaskById = TaskConfig.Instance.GetMainLineTaskById(mainTaskId);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(QuestNewModel.Instance.GetQuestConfig(mainLineTaskById.Value.TaskId).TidName, null);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			localTextNew
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.MainLine, mainTaskId, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005A7A RID: 23162 RVA: 0x001D597C File Offset: 0x001D3B7C
	private void JumpToBranchTask(int branchTaskId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessJumpToTask);
		BranchLine? branchLineTaskById = TaskConfig.Instance.GetBranchLineTaskById(branchTaskId);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(QuestNewModel.Instance.GetQuestConfig(branchLineTaskById.Value.TaskId).TidName, null);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			localTextNew
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.BranchLine, branchTaskId, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x001D5A0C File Offset: 0x001D3C0C
	private void JumpToBuilding(int buildingId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessJumpToBuilding);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(BuildingConfig.Instance.GetBuildingById(buildingId).Name, null);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			localTextNew
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MoonChasingController.Instance.OpenBuildingTipsInfoView(buildingId);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x001D5A84 File Offset: 0x001D3C84
	public void JumpEnergyNotEnough()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessEnergyNotEnough);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.BranchLine, 0, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005A7D RID: 23165 RVA: 0x001D5AD4 File Offset: 0x001D3CD4
	public void JumpMoneyNotEnough()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessMoneyNotEnough);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005A7E RID: 23166 RVA: 0x001D5AF8 File Offset: 0x001D3CF8
	public void BackToLastState()
	{
		if (this.ViewStateManager.CurrentState == EBusinessSkipDefine.MainView)
		{
			this.View.CloseMe(null);
			return;
		}
		this.ViewStateManager.BackToLastState();
	}

	// Token: 0x06005A7F RID: 23167 RVA: 0x001D5B1F File Offset: 0x001D3D1F
	public void OpenHelpView()
	{
		if (this.ViewStateManager.CurrentState == EBusinessSkipDefine.DelegationDetails)
		{
			HelpController.Instance.OpenHelpById(104);
			return;
		}
		HelpController.Instance.OpenHelpById(103);
	}

	// Token: 0x04003CDF RID: 15583
	private const int MAINVIEW_HELPID = 103;

	// Token: 0x04003CE0 RID: 15584
	private const int DELEGATE_HELPID = 104;

	// Token: 0x04003CE1 RID: 15585
	private BusinessMainView View;

	// Token: 0x04003CE2 RID: 15586
	private MoonChasingBusinessViewModel Model;

	// Token: 0x04003CE3 RID: 15587
	private readonly ViewStateManager ViewStateManager = new ViewStateManager();
}
