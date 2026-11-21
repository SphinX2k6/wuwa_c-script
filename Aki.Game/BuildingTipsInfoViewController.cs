using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020007B0 RID: 1968
[NullableContext(1)]
[Nullable(0)]
public class BuildingTipsInfoViewController
{
	// Token: 0x06005A19 RID: 23065 RVA: 0x001D43D4 File Offset: 0x001D25D4
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

	// Token: 0x06005A1A RID: 23066 RVA: 0x001D4446 File Offset: 0x001D2646
	public void RegisterView(BuildingTipsInfoView view)
	{
		this.View = view;
		this.Model = (BuildingTipsInfoViewModel)view.OpenParam;
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x001D4460 File Offset: 0x001D2660
	public UniTask Refresh()
	{
		BuildingTipsInfoViewController.<Refresh>d__4 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<BuildingTipsInfoViewController.<Refresh>d__4>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x001D44A4 File Offset: 0x001D26A4
	public void SwitchPrev()
	{
		this.SwitchBuildingId(true);
		this.View.UiViewSequence.StopPrevSequence(false, true);
		this.View.UiViewSequence.PlaySequence("Switch", false, null);
		this.Refresh().Forget();
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x001D44F4 File Offset: 0x001D26F4
	public void SwitchNext()
	{
		this.SwitchBuildingId(false);
		this.View.UiViewSequence.StopPrevSequence(false, true);
		this.View.UiViewSequence.PlaySequence("Switch", false, null);
		this.Refresh().Forget();
	}

	// Token: 0x06005A1E RID: 23070 RVA: 0x001D4544 File Offset: 0x001D2744
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

	// Token: 0x06005A1F RID: 23071 RVA: 0x001D45A0 File Offset: 0x001D27A0
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

	// Token: 0x06005A20 RID: 23072 RVA: 0x001D45DC File Offset: 0x001D27DC
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

	// Token: 0x06005A21 RID: 23073 RVA: 0x001D462C File Offset: 0x001D282C
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

	// Token: 0x04003CC9 RID: 15561
	private BuildingTipsInfoView View;

	// Token: 0x04003CCA RID: 15562
	private BuildingTipsInfoViewModel Model;
}
