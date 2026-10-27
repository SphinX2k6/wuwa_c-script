using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020012FC RID: 4860
[NullableContext(1)]
[Nullable(0)]
public class BuildingTipsInfoViewController
{
	// Token: 0x0600867E RID: 34430 RVA: 0x001CB568 File Offset: 0x001C9768
	private void SwitchBuildingId(bool isPrev)
	{
		int buildingDataSize = MoonChasingBuildingModel.Instance.GetBuildingDataSize();
		if (isPrev)
		{
			this.Model.BuildingId = ((this.Model.BuildingId - 1 > 0) ? (this.Model.BuildingId - 1) : buildingDataSize);
			return;
		}
		this.Model.BuildingId = ((this.Model.BuildingId + 1 <= buildingDataSize) ? (this.Model.BuildingId + 1) : 1);
	}

	// Token: 0x0600867F RID: 34431 RVA: 0x001CB5DA File Offset: 0x001C97DA
	public void RegisterView(BuildingTipsInfoView view)
	{
		this.View = view;
		this.Model = (BuildingTipsInfoViewModel)view.OpenParam;
	}

	// Token: 0x06008680 RID: 34432 RVA: 0x001CB5F4 File Offset: 0x001C97F4
	public UniTask Refresh()
	{
		BuildingTipsInfoViewController.<Refresh>d__4 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<BuildingTipsInfoViewController.<Refresh>d__4>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06008681 RID: 34433 RVA: 0x001CB638 File Offset: 0x001C9838
	public void SwitchPrev()
	{
		this.SwitchBuildingId(true);
		this.View.UiViewSequence.StopPrevSequence(false, true);
		this.View.UiViewSequence.PlaySequence("Switch", false, null);
		this.Refresh().Forget();
	}

	// Token: 0x06008682 RID: 34434 RVA: 0x001CB688 File Offset: 0x001C9888
	public void SwitchNext()
	{
		this.SwitchBuildingId(false);
		this.View.UiViewSequence.StopPrevSequence(false, true);
		this.View.UiViewSequence.PlaySequence("Switch", false, null);
		this.Refresh().Forget();
	}

	// Token: 0x06008683 RID: 34435 RVA: 0x001CB6D8 File Offset: 0x001C98D8
	public void JumpToMap()
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Model.BuildingId);
		if (buildingById.MapMarkId > 0)
		{
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(buildingById.MapMarkId),
				MarkType = EMarkType.None
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}
	}

	// Token: 0x06008684 RID: 34436 RVA: 0x001CB734 File Offset: 0x001C9934
	public void JumpToConditionTip()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBuildingJumpToTask);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			Building buildingById = BuildingConfig.Instance.GetBuildingById(this.Model.BuildingId);
			MoonChasingController.Instance.OpenTaskView((EMoonChasingTaskType)buildingById.JumpType, buildingById.JumpParam, false);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06008685 RID: 34437 RVA: 0x001CB770 File Offset: 0x001C9970
	public void CloseSelf()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView);
		MoonChasingMainViewModel moonChasingMainViewModel = ((viewByName != null) ? viewByName.OpenParam : null) as MoonChasingMainViewModel;
		if (moonChasingMainViewModel != null)
		{
			moonChasingMainViewModel.RefreshBuildingId = this.Model.BuildingId;
		}
		this.View.CloseMe(null);
	}

	// Token: 0x06008686 RID: 34438 RVA: 0x001CB7C0 File Offset: 0x001C99C0
	public void UnlockOrLevelUp(int _)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.Model.BuildingId);
		if (!buildingDataById.IsCanLevelUp)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingBuildingNotEnough);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				MoonChasingController.Instance.OpenBusinessMainView();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (!buildingDataById.IsBuild)
		{
			this.View.UiViewSequence.HideSequenceName = "HideView01";
			MoonChasingController.Instance.BuildingUnLockRequest(this.Model.BuildingId);
			return;
		}
		this.View.UiViewSequence.HideSequenceName = "HideView02";
		MoonChasingController.Instance.BuildingLevelUpRequest(this.Model.BuildingId);
	}

	// Token: 0x04003C31 RID: 15409
	private BuildingTipsInfoView View;

	// Token: 0x04003C32 RID: 15410
	private BuildingTipsInfoViewModel Model;
}
