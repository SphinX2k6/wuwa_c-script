using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020007CE RID: 1998
[NullableContext(1)]
[Nullable(0)]
public class BusinessHelperViewController
{
	// Token: 0x06005B44 RID: 23364 RVA: 0x001D8442 File Offset: 0x001D6642
	public void RegisterView(BusinessHelperView view)
	{
		this.View = view;
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x001D844B File Offset: 0x001D664B
	public void Show()
	{
		this.View.ShowView(this.InInteractive);
	}

	// Token: 0x06005B46 RID: 23366 RVA: 0x001D8460 File Offset: 0x001D6660
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

	// Token: 0x06005B47 RID: 23367 RVA: 0x001D84AB File Offset: 0x001D66AB
	public void SkipToHelpPanel()
	{
		this.InInteractive = false;
		this.View.SkipToHelpPanel();
	}

	// Token: 0x06005B48 RID: 23368 RVA: 0x001D84BF File Offset: 0x001D66BF
	public void SkipToInteractivePanel()
	{
		this.InInteractive = true;
		this.View.SkipToInteractivePanel();
	}

	// Token: 0x06005B49 RID: 23369 RVA: 0x001D84D3 File Offset: 0x001D66D3
	public void SkipToTaskView(EMoonChasingTaskType taskType, int taskId)
	{
		MoonChasingController.Instance.OpenTaskView(taskType, taskId, false);
	}

	// Token: 0x06005B4A RID: 23370 RVA: 0x001D84E2 File Offset: 0x001D66E2
	public void SkipToBuildingView(int buildingId)
	{
		MoonChasingController.Instance.OpenBuildingTipsInfoView(buildingId);
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x001D84F0 File Offset: 0x001D66F0
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

	// Token: 0x06005B4C RID: 23372 RVA: 0x001D8538 File Offset: 0x001D6738
	public void RefreshInteractivePanel()
	{
		if (this.InInteractive)
		{
			this.View.RefreshInteractivePanel();
		}
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x001D854D File Offset: 0x001D674D
	public void BackToLastState()
	{
		if (this.InInteractive)
		{
			this.SkipToHelpPanel();
			return;
		}
		this.View.CloseMe(null);
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x001D856A File Offset: 0x001D676A
	public void OpenHelpView()
	{
		if (this.InInteractive)
		{
			HelpController.Instance.OpenHelpById(106);
			return;
		}
		HelpController.Instance.OpenHelpById(105);
	}

	// Token: 0x04003D15 RID: 15637
	private const int INTERACTIVE_HELPID = 106;

	// Token: 0x04003D16 RID: 15638
	private const int HELP_HELPID = 105;

	// Token: 0x04003D17 RID: 15639
	private BusinessHelperView View;

	// Token: 0x04003D18 RID: 15640
	private bool InInteractive;

	// Token: 0x04003D19 RID: 15641
	public int SelectedRoleId;
}
