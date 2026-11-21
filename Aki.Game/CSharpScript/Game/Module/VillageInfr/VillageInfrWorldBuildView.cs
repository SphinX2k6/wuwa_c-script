using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003802 RID: 14338
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrWorldBuildView : UiViewBase, IUiViewCameraBehavior
	{
		// Token: 0x06025451 RID: 152657 RVA: 0x00A831CB File Offset: 0x00A813CB
		public VillageInfrWorldBuildView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06025452 RID: 152658 RVA: 0x00A831F8 File Offset: 0x00A813F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnFunction))
			};
		}

		// Token: 0x06025453 RID: 152659 RVA: 0x00A83275 File Offset: 0x00A81475
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnSequenceFinished));
		}

		// Token: 0x06025454 RID: 152660 RVA: 0x00A83293 File Offset: 0x00A81493
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnSequenceFinished));
		}

		// Token: 0x06025455 RID: 152661 RVA: 0x00A832B4 File Offset: 0x00A814B4
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrWorldBuildView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrWorldBuildView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025456 RID: 152662 RVA: 0x00A832F8 File Offset: 0x00A814F8
		private void SetOpenParam()
		{
			IVillageInfrDeliveryParam villageInfrDeliveryParam = this.OpenParam as IVillageInfrDeliveryParam;
			this.SelectType = villageInfrDeliveryParam.SelectType;
			this.SelectId = villageInfrDeliveryParam.SelectId;
			this.UiCameraName = villageInfrDeliveryParam.UiCameraName;
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				this.SelectId = VillageInfrModel.Instance.GetVillageLevel();
			}
		}

		// Token: 0x06025457 RID: 152663 RVA: 0x00A83350 File Offset: 0x00A81550
		private UniTask CreateCaption()
		{
			VillageInfrWorldBuildView.<CreateCaption>d__11 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrWorldBuildView.<CreateCaption>d__11>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06025458 RID: 152664 RVA: 0x00A83394 File Offset: 0x00A81594
		private UniTask CreateBuildPanel()
		{
			VillageInfrWorldBuildView.<CreateBuildPanel>d__12 <CreateBuildPanel>d__;
			<CreateBuildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildPanel>d__.<>4__this = this;
			<CreateBuildPanel>d__.<>1__state = -1;
			<CreateBuildPanel>d__.<>t__builder.Start<VillageInfrWorldBuildView.<CreateBuildPanel>d__12>(ref <CreateBuildPanel>d__);
			return <CreateBuildPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06025459 RID: 152665 RVA: 0x00A833D8 File Offset: 0x00A815D8
		protected override void OnStart()
		{
			this.RefreshBuildInfo();
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "VillageInfrWorldBuildVillage");
				return;
			}
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "VillageInfrWorldBuildTree");
			}
		}

		// Token: 0x0602545A RID: 152666 RVA: 0x00A83428 File Offset: 0x00A81628
		protected override void OnBeforeShow()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				UiCameraModel.Instance.DisablePlayerActor();
			}
		}

		// Token: 0x0602545B RID: 152667 RVA: 0x00A8343D File Offset: 0x00A8163D
		protected override void OnAfterDestroy()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				UiCameraModel.Instance.EnablePlayerActor();
			}
		}

		// Token: 0x0602545C RID: 152668 RVA: 0x00A83452 File Offset: 0x00A81652
		public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
		{
			if (this.UiCameraName.Length > 0)
			{
				UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)this.UiCameraName, viewId, operationType);
			}
		}

		// Token: 0x0602545D RID: 152669 RVA: 0x00A83479 File Offset: 0x00A81679
		public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
		{
			if (this.UiCameraName.Length > 0)
			{
				UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.UiCameraName, nextViewName, closeViewId, operationType);
			}
		}

		// Token: 0x0602545E RID: 152670 RVA: 0x00A834A2 File Offset: 0x00A816A2
		protected override void OnBeforeDestroy()
		{
			this.SelectId = 1;
		}

		// Token: 0x0602545F RID: 152671 RVA: 0x00A834AB File Offset: 0x00A816AB
		private void RefreshBuildInfo()
		{
			this.BuildPanel.SetBottomBtnClickCb(delegate
			{
				this.OnClickBuild().Forget();
			});
		}

		// Token: 0x06025460 RID: 152672 RVA: 0x00A834C4 File Offset: 0x00A816C4
		private UniTask OnClickBuild()
		{
			VillageInfrWorldBuildView.<OnClickBuild>d__20 <OnClickBuild>d__;
			<OnClickBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBuild>d__.<>4__this = this;
			<OnClickBuild>d__.<>1__state = -1;
			<OnClickBuild>d__.<>t__builder.Start<VillageInfrWorldBuildView.<OnClickBuild>d__20>(ref <OnClickBuild>d__);
			return <OnClickBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06025461 RID: 152673 RVA: 0x00A83507 File Offset: 0x00A81707
		private void OnClickBtnFunction()
		{
			VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
		}

		// Token: 0x06025462 RID: 152674 RVA: 0x00A83519 File Offset: 0x00A81719
		private void OnSequenceFinished()
		{
			PlotController.Instance.PlotViewManager.HangPlotViewHud(false);
		}

		// Token: 0x04014A1D RID: 84509
		private int SelectId;

		// Token: 0x04014A1E RID: 84510
		private EVillageInfrSelectType SelectType;

		// Token: 0x04014A1F RID: 84511
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x04014A20 RID: 84512
		private readonly VillageInfrBuildPanel BuildPanel = new VillageInfrBuildPanel();

		// Token: 0x04014A21 RID: 84513
		private string UiCameraName = "";
	}
}
