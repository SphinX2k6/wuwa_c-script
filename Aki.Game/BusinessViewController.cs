using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001303 RID: 4867
[NullableContext(1)]
[Nullable(0)]
public class BusinessViewController
{
	// Token: 0x060086D5 RID: 34517 RVA: 0x001CC88C File Offset: 0x001CAA8C
	private void InitViewStateManager()
	{
		this.ViewStateManager.RegisterViewState(EBusinessSkipDefine.MainView, null, new Action(this.View.SkipToMainView));
		this.ViewStateManager.RegisterViewState(EBusinessSkipDefine.DelegationDetails, null, new Action<object[]>(this.View.SkipToDelegationDetails));
	}

	// Token: 0x060086D6 RID: 34518 RVA: 0x001CC8CA File Offset: 0x001CAACA
	public void RegisterView(BusinessMainView view)
	{
		this.View = view;
		this.Model = (MoonChasingBusinessViewModel)view.OpenParam;
		this.InitViewStateManager();
	}

	// Token: 0x060086D7 RID: 34519 RVA: 0x001CC8EC File Offset: 0x001CAAEC
	public UniTask BeforeShowAsync()
	{
		BusinessViewController.<BeforeShowAsync>d__7 <BeforeShowAsync>d__;
		<BeforeShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeShowAsync>d__.<>4__this = this;
		<BeforeShowAsync>d__.<>1__state = -1;
		<BeforeShowAsync>d__.<>t__builder.Start<BusinessViewController.<BeforeShowAsync>d__7>(ref <BeforeShowAsync>d__);
		return <BeforeShowAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086D8 RID: 34520 RVA: 0x001CC930 File Offset: 0x001CAB30
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

	// Token: 0x060086D9 RID: 34521 RVA: 0x001CC98D File Offset: 0x001CAB8D
	public void SwitchToState(EBusinessSkipDefine state, params object[] params_)
	{
		this.ViewStateManager.SwitchToState(state, params_);
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x001CC99C File Offset: 0x001CAB9C
	public void BackToState(EBusinessSkipDefine state)
	{
		this.ViewStateManager.BackToState(state);
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x001CC9AC File Offset: 0x001CABAC
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

	// Token: 0x060086DC RID: 34524 RVA: 0x001CC9FC File Offset: 0x001CABFC
	public void SkipToHelper()
	{
		MoonChasingController.Instance.OpenHelperView();
	}

	// Token: 0x060086DD RID: 34525 RVA: 0x001CCA08 File Offset: 0x001CAC08
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

	// Token: 0x060086DE RID: 34526 RVA: 0x001CCA80 File Offset: 0x001CAC80
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

	// Token: 0x060086DF RID: 34527 RVA: 0x001CCB10 File Offset: 0x001CAD10
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

	// Token: 0x060086E0 RID: 34528 RVA: 0x001CCBA0 File Offset: 0x001CADA0
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

	// Token: 0x060086E1 RID: 34529 RVA: 0x001CCC18 File Offset: 0x001CAE18
	public void JumpEnergyNotEnough()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessEnergyNotEnough);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.BranchLine, 0, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x001CCC68 File Offset: 0x001CAE68
	public void JumpMoneyNotEnough()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBusinessMoneyNotEnough);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x001CCC8C File Offset: 0x001CAE8C
	public void BackToLastState()
	{
		if (this.ViewStateManager.CurrentState == EBusinessSkipDefine.MainView)
		{
			this.View.CloseMe(null);
			return;
		}
		this.ViewStateManager.BackToLastState();
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x001CCCB3 File Offset: 0x001CAEB3
	public void OpenHelpView()
	{
		if (this.ViewStateManager.CurrentState == EBusinessSkipDefine.DelegationDetails)
		{
			HelpController.Instance.OpenHelpById(104);
			return;
		}
		HelpController.Instance.OpenHelpById(103);
	}

	// Token: 0x04003C47 RID: 15431
	private const int MAINVIEW_HELPID = 103;

	// Token: 0x04003C48 RID: 15432
	private const int DELEGATE_HELPID = 104;

	// Token: 0x04003C49 RID: 15433
	private BusinessMainView View;

	// Token: 0x04003C4A RID: 15434
	private MoonChasingBusinessViewModel Model;

	// Token: 0x04003C4B RID: 15435
	private readonly ViewStateManager ViewStateManager = new ViewStateManager();
}
