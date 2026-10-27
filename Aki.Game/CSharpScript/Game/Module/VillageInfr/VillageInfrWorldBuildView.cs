using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200488B RID: 18571
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrWorldBuildView : UiViewBase, IUiCameraBehavior
	{
		// Token: 0x06030925 RID: 198949 RVA: 0x00B483BC File Offset: 0x00B465BC
		public VillageInfrWorldBuildView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030926 RID: 198950 RVA: 0x00B483E8 File Offset: 0x00B465E8
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

		// Token: 0x06030927 RID: 198951 RVA: 0x00B48465 File Offset: 0x00B46665
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnSequenceFinished));
		}

		// Token: 0x06030928 RID: 198952 RVA: 0x00B48483 File Offset: 0x00B46683
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnSequenceFinished));
		}

		// Token: 0x06030929 RID: 198953 RVA: 0x00B484A4 File Offset: 0x00B466A4
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrWorldBuildView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrWorldBuildView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603092A RID: 198954 RVA: 0x00B484E8 File Offset: 0x00B466E8
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

		// Token: 0x0603092B RID: 198955 RVA: 0x00B48540 File Offset: 0x00B46740
		private UniTask CreateCaption()
		{
			VillageInfrWorldBuildView.<CreateCaption>d__11 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrWorldBuildView.<CreateCaption>d__11>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0603092C RID: 198956 RVA: 0x00B48584 File Offset: 0x00B46784
		private UniTask CreateBuildPanel()
		{
			VillageInfrWorldBuildView.<CreateBuildPanel>d__12 <CreateBuildPanel>d__;
			<CreateBuildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildPanel>d__.<>4__this = this;
			<CreateBuildPanel>d__.<>1__state = -1;
			<CreateBuildPanel>d__.<>t__builder.Start<VillageInfrWorldBuildView.<CreateBuildPanel>d__12>(ref <CreateBuildPanel>d__);
			return <CreateBuildPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603092D RID: 198957 RVA: 0x00B485C8 File Offset: 0x00B467C8
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

		// Token: 0x0603092E RID: 198958 RVA: 0x00B48618 File Offset: 0x00B46818
		protected override void OnBeforeShow()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				UiCameraAnimationManager.Instance.DisablePlayerActor();
			}
		}

		// Token: 0x0603092F RID: 198959 RVA: 0x00B4862D File Offset: 0x00B4682D
		protected override void OnAfterDestroy()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				UiCameraAnimationManager.Instance.EnablePlayerActor();
			}
		}

		// Token: 0x06030930 RID: 198960 RVA: 0x00B48642 File Offset: 0x00B46842
		public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
		{
			if (this.UiCameraName.Length > 0)
			{
				UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)this.UiCameraName, new int?(viewId), isBlend);
			}
		}

		// Token: 0x06030931 RID: 198961 RVA: 0x00B4866E File Offset: 0x00B4686E
		[NullableContext(2)]
		public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
		{
			if (this.UiCameraName.Length > 0)
			{
				UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.UiCameraName, stackTopInfo, closeViewId, popOrDelete);
			}
		}

		// Token: 0x06030932 RID: 198962 RVA: 0x00B48697 File Offset: 0x00B46897
		protected override void OnBeforeDestroy()
		{
			this.SelectId = 1;
		}

		// Token: 0x06030933 RID: 198963 RVA: 0x00B486A0 File Offset: 0x00B468A0
		private void RefreshBuildInfo()
		{
			this.BuildPanel.SetBottomBtnClickCb(delegate
			{
				this.OnClickBuild().Forget();
			});
		}

		// Token: 0x06030934 RID: 198964 RVA: 0x00B486BC File Offset: 0x00B468BC
		private UniTask OnClickBuild()
		{
			VillageInfrWorldBuildView.<OnClickBuild>d__20 <OnClickBuild>d__;
			<OnClickBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBuild>d__.<>4__this = this;
			<OnClickBuild>d__.<>1__state = -1;
			<OnClickBuild>d__.<>t__builder.Start<VillageInfrWorldBuildView.<OnClickBuild>d__20>(ref <OnClickBuild>d__);
			return <OnClickBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06030935 RID: 198965 RVA: 0x00B486FF File Offset: 0x00B468FF
		private void OnClickBtnFunction()
		{
			VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
		}

		// Token: 0x06030936 RID: 198966 RVA: 0x00B48711 File Offset: 0x00B46911
		private void OnSequenceFinished()
		{
			PlotController.Instance.PlotViewManager.HangPlotViewHud(false);
		}

		// Token: 0x0401A1AA RID: 106922
		private int SelectId;

		// Token: 0x0401A1AB RID: 106923
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A1AC RID: 106924
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401A1AD RID: 106925
		private readonly VillageInfrBuildPanel BuildPanel = new VillageInfrBuildPanel();

		// Token: 0x0401A1AE RID: 106926
		private string UiCameraName = "";
	}
}
