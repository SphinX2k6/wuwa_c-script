using System;
using System.Runtime.CompilerServices;

// Token: 0x02001357 RID: 4951
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingViewController
{
	// Token: 0x060089DB RID: 35291 RVA: 0x001D75D4 File Offset: 0x001D57D4
	public void RegisterView(MoonChasingMainView view)
	{
		this.View = view;
		this.Model = (MoonChasingMainViewModel)view.OpenParam;
	}

	// Token: 0x060089DC RID: 35292 RVA: 0x001D75F0 File Offset: 0x001D57F0
	private void Skip()
	{
		if (this.Model.SkipTarget == EMoonChasingSkipDefine.Build)
		{
			this.SkipToBuild();
		}
		else if (this.Model.SkipTarget == EMoonChasingSkipDefine.Business)
		{
			this.SkipToBusiness();
		}
		else if (this.Model.SkipTarget == EMoonChasingSkipDefine.Task)
		{
			this.SkipToTask(this.Model.TaskType, this.Model.IsLastTask);
		}
		this.Model.SkipTarget = EMoonChasingSkipDefine.None;
	}

	// Token: 0x060089DD RID: 35293 RVA: 0x001D765F File Offset: 0x001D585F
	private void RefreshMapModule()
	{
		if (this.Model.RefreshBuildingId > 0)
		{
			this.View.RefreshMainModule(this.Model.RefreshBuildingId);
			this.Model.RefreshBuildingId = 0;
		}
	}

	// Token: 0x060089DE RID: 35294 RVA: 0x001D7691 File Offset: 0x001D5891
	public void Show()
	{
		this.Skip();
		this.RefreshMapModule();
		this.RefreshShowAnimation();
		this.View.RefreshBuildingModule();
		this.View.RefreshRedDot();
	}

	// Token: 0x060089DF RID: 35295 RVA: 0x001D76BB File Offset: 0x001D58BB
	public void SkipToBusinessByParam(int _)
	{
		this.SkipToBusiness();
	}

	// Token: 0x060089E0 RID: 35296 RVA: 0x001D76C3 File Offset: 0x001D58C3
	public void SkipToBusiness()
	{
		MoonChasingModel.Instance.RemoveDelegationRedDot();
		MoonChasingController.Instance.OpenBusinessMainView();
	}

	// Token: 0x060089E1 RID: 35297 RVA: 0x001D76D9 File Offset: 0x001D58D9
	public void SkipToReward(int _)
	{
		MoonChasingController.Instance.OpenRewardView(true);
	}

	// Token: 0x060089E2 RID: 35298 RVA: 0x001D76E6 File Offset: 0x001D58E6
	public void SkipToBuildByParam(int _)
	{
		this.SkipToBuild();
	}

	// Token: 0x060089E3 RID: 35299 RVA: 0x001D76EE File Offset: 0x001D58EE
	public void SkipToBuild()
	{
		this.Model.IsInBuildingModule = true;
		this.View.SkipToBuild();
	}

	// Token: 0x060089E4 RID: 35300 RVA: 0x001D7707 File Offset: 0x001D5907
	public void SkipToTask(EMoonChasingTaskType taskType = EMoonChasingTaskType.MainLine, bool isLastTask = false)
	{
		MoonChasingController.Instance.OpenTaskView(taskType, 0, isLastTask);
	}

	// Token: 0x060089E5 RID: 35301 RVA: 0x001D7716 File Offset: 0x001D5916
	public void SkipToHandbook(int _)
	{
		MoonChasingController.Instance.OpenHandbookView();
	}

	// Token: 0x060089E6 RID: 35302 RVA: 0x001D7722 File Offset: 0x001D5922
	public void CloseSelf()
	{
		if (this.Model.IsInBuildingModule)
		{
			this.BuildingBackToMainView();
			return;
		}
		this.View.CloseMe(null);
	}

	// Token: 0x060089E7 RID: 35303 RVA: 0x001D7744 File Offset: 0x001D5944
	public void OpenHelpView()
	{
		if (this.Model.IsInBuildingModule)
		{
			HelpController.Instance.OpenHelpById(102);
			return;
		}
		HelpController.Instance.OpenHelpById(107);
	}

	// Token: 0x060089E8 RID: 35304 RVA: 0x001D776C File Offset: 0x001D596C
	public void BuildingBackToMainView()
	{
		this.View.RefreshRedDot();
		this.Model.IsInBuildingModule = false;
		this.View.BuildingBackToMainView();
		if (this.Model.BuildingBackToBusiness)
		{
			this.Model.BuildingBackToBusiness = false;
			this.SkipToBusiness();
		}
	}

	// Token: 0x060089E9 RID: 35305 RVA: 0x001D77BC File Offset: 0x001D59BC
	private void RefreshShowAnimation()
	{
		if (MoonChasingModel.Instance.HasEnteredMainViewFlag)
		{
			this.View.UiViewSequence.StartSequenceName = "Start";
			return;
		}
		this.View.UiViewSequence.StartSequenceName = "Start01";
		MoonChasingModel.Instance.HasEnteredMainViewFlag = true;
	}

	// Token: 0x04003D85 RID: 15749
	private MoonChasingMainView View;

	// Token: 0x04003D86 RID: 15750
	private MoonChasingMainViewModel Model;
}
