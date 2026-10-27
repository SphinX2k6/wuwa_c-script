using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200131A RID: 4890
[NullableContext(1)]
[Nullable(0)]
public class BusinessHelperViewController
{
	// Token: 0x060087A9 RID: 34729 RVA: 0x001CF5D6 File Offset: 0x001CD7D6
	public void RegisterView(BusinessHelperView view)
	{
		this.View = view;
	}

	// Token: 0x060087AA RID: 34730 RVA: 0x001CF5DF File Offset: 0x001CD7DF
	public void Show()
	{
		this.View.ShowView(this.InInteractive);
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x001CF5F4 File Offset: 0x001CD7F4
	public UniTask RefreshSpine(int roleId)
	{
		BusinessHelperViewController.<RefreshSpine>d__7 <RefreshSpine>d__;
		<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSpine>d__.<>4__this = this;
		<RefreshSpine>d__.roleId = roleId;
		<RefreshSpine>d__.<>1__state = -1;
		<RefreshSpine>d__.<>t__builder.Start<BusinessHelperViewController.<RefreshSpine>d__7>(ref <RefreshSpine>d__);
		return <RefreshSpine>d__.<>t__builder.Task;
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x001CF63F File Offset: 0x001CD83F
	public void SkipToHelpPanel()
	{
		this.InInteractive = false;
		this.View.SkipToHelpPanel();
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x001CF653 File Offset: 0x001CD853
	public void SkipToInteractivePanel()
	{
		this.InInteractive = true;
		this.View.SkipToInteractivePanel();
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x001CF667 File Offset: 0x001CD867
	public void SkipToTaskView(EMoonChasingTaskType taskType, int taskId)
	{
		MoonChasingController.Instance.OpenTaskView(taskType, taskId, false);
	}

	// Token: 0x060087AF RID: 34735 RVA: 0x001CF676 File Offset: 0x001CD876
	public void SkipToBuildingView(int buildingId)
	{
		MoonChasingController.Instance.OpenBuildingTipsInfoView(buildingId);
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x001CF684 File Offset: 0x001CD884
	public void SkipToBuildingPreview()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView);
		if (viewByName == null)
		{
			return;
		}
		MoonChasingMainViewModel moonChasingMainViewModel = viewByName.OpenParam as MoonChasingMainViewModel;
		if (moonChasingMainViewModel != null)
		{
			moonChasingMainViewModel.SkipTarget = EMoonChasingSkipDefine.Build;
		}
		UiManager.Instance.NormalResetToView(EUiViewName.MoonChasingMainView, null, true);
	}

	// Token: 0x060087B1 RID: 34737 RVA: 0x001CF6CC File Offset: 0x001CD8CC
	public void RefreshInteractivePanel()
	{
		if (this.InInteractive)
		{
			this.View.RefreshInteractivePanel();
		}
	}

	// Token: 0x060087B2 RID: 34738 RVA: 0x001CF6E1 File Offset: 0x001CD8E1
	public void BackToLastState()
	{
		if (this.InInteractive)
		{
			this.SkipToHelpPanel();
			return;
		}
		this.View.CloseMe(null);
	}

	// Token: 0x060087B3 RID: 34739 RVA: 0x001CF6FE File Offset: 0x001CD8FE
	public void OpenHelpView()
	{
		if (this.InInteractive)
		{
			HelpController.Instance.OpenHelpById(106);
			return;
		}
		HelpController.Instance.OpenHelpById(105);
	}

	// Token: 0x04003C7D RID: 15485
	private const int INTERACTIVE_HELPID = 106;

	// Token: 0x04003C7E RID: 15486
	private const int HELP_HELPID = 105;

	// Token: 0x04003C7F RID: 15487
	private BusinessHelperView View;

	// Token: 0x04003C80 RID: 15488
	private bool InInteractive;

	// Token: 0x04003C81 RID: 15489
	public int SelectedRoleId;
}
