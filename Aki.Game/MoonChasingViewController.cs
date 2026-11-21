using System;
using System.Runtime.CompilerServices;

// Token: 0x0200080B RID: 2059
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingViewController
{
	// Token: 0x06005D76 RID: 23926 RVA: 0x001E0438 File Offset: 0x001DE638
	public void RegisterView(MoonChasingMainView view)
	{
		this.View = view;
		this.Model = (MoonChasingMainViewModel)view.OpenParam;
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x001E0454 File Offset: 0x001DE654
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

	// Token: 0x06005D78 RID: 23928 RVA: 0x001E04C3 File Offset: 0x001DE6C3
	private void RefreshMapModule()
	{
		if (this.Model.RefreshBuildingId > 0)
		{
			this.View.RefreshMainModule(this.Model.RefreshBuildingId);
			this.Model.RefreshBuildingId = 0;
		}
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x001E04F5 File Offset: 0x001DE6F5
	public void Show()
	{
		this.Skip();
		this.RefreshMapModule();
		this.RefreshShowAnimation();
		this.View.RefreshBuildingModule();
		this.View.RefreshRedDot();
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x001E051F File Offset: 0x001DE71F
	public void SkipToBusinessByParam(int _)
	{
		this.SkipToBusiness();
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x001E0527 File Offset: 0x001DE727
	public void SkipToBusiness()
	{
		MoonChasingModel.Instance.RemoveDelegationRedDot();
		MoonChasingController.Instance.OpenBusinessMainView();
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x001E053D File Offset: 0x001DE73D
	public void SkipToReward(int _)
	{
		MoonChasingController.Instance.OpenRewardView(true);
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x001E054A File Offset: 0x001DE74A
	public void SkipToBuildByParam(int _)
	{
		this.SkipToBuild();
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x001E0552 File Offset: 0x001DE752
	public void SkipToBuild()
	{
		this.Model.IsInBuildingModule = true;
		this.View.SkipToBuild();
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x001E056B File Offset: 0x001DE76B
	public void SkipToTask(EMoonChasingTaskType taskType = EMoonChasingTaskType.MainLine, bool isLastTask = false)
	{
		MoonChasingController.Instance.OpenTaskView(taskType, 0, isLastTask);
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x001E057A File Offset: 0x001DE77A
	public void SkipToHandbook(int _)
	{
		MoonChasingController.Instance.OpenHandbookView();
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x001E0586 File Offset: 0x001DE786
	public void CloseSelf()
	{
		if (this.Model.IsInBuildingModule)
		{
			this.BuildingBackToMainView();
			return;
		}
		this.View.CloseMe(null);
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x001E05A8 File Offset: 0x001DE7A8
	public void OpenHelpView()
	{
		if (this.Model.IsInBuildingModule)
		{
			HelpController.Instance.OpenHelpById(102);
			return;
		}
		HelpController.Instance.OpenHelpById(107);
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x001E05D0 File Offset: 0x001DE7D0
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

	// Token: 0x06005D84 RID: 23940 RVA: 0x001E0620 File Offset: 0x001DE820
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

	// Token: 0x04003E1D RID: 15901
	private MoonChasingMainView View;

	// Token: 0x04003E1E RID: 15902
	private MoonChasingMainViewModel Model;
}
