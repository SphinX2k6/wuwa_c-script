using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200535D RID: 21341
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffView : UiViewBase
	{
		// Token: 0x0603519F RID: 217503 RVA: 0x00ED4A64 File Offset: 0x00ED2C64
		public MowingBuffView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060351A0 RID: 217504 RVA: 0x00ED4A70 File Offset: 0x00ED2C70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.HandleOnClickLeftToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.HandleOnClickRightToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060351A1 RID: 217505 RVA: 0x00ED4B7C File Offset: 0x00ED2D7C
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351A2 RID: 217506 RVA: 0x00ED4BBF File Offset: 0x00ED2DBF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MowingBasicBuffGridItemClick, new Action(this.HandleMowingBasicBuffGridItemClick));
			EventSystem.Instance.Add(EEventName.MowingSuperBuffGridItemClick, new Action(this.HandleMowingSuperBuffGridItemClick));
		}

		// Token: 0x060351A3 RID: 217507 RVA: 0x00ED4BF9 File Offset: 0x00ED2DF9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MowingBasicBuffGridItemClick, new Action(this.HandleMowingBasicBuffGridItemClick));
			EventSystem.Instance.Remove(EEventName.MowingSuperBuffGridItemClick, new Action(this.HandleMowingSuperBuffGridItemClick));
		}

		// Token: 0x060351A4 RID: 217508 RVA: 0x00ED4C33 File Offset: 0x00ED2E33
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshCurrentTab();
			this.RefreshAllTabView(false);
			this.BindTogglesCanExecuteChange();
		}

		// Token: 0x060351A5 RID: 217509 RVA: 0x00ED4C4E File Offset: 0x00ED2E4E
		protected override void OnBeforeDestroy()
		{
			MowingRiskModel.Instance.ResetBuffViewCache();
			this.UnbindTogglesCanExecuteChange();
		}

		// Token: 0x060351A6 RID: 217510 RVA: 0x00ED4C60 File Offset: 0x00ED2E60
		private void HandleOnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060351A7 RID: 217511 RVA: 0x00ED4C6C File Offset: 0x00ED2E6C
		private void HandleOnClickLeftToggle(EToggleState state)
		{
			UiAsyncTask task = new UiAsyncTask("MowingBuffView.RefreshTab", delegate()
			{
				MowingBuffView.<<HandleOnClickLeftToggle>b__11_0>d <<HandleOnClickLeftToggle>b__11_0>d;
				<<HandleOnClickLeftToggle>b__11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<HandleOnClickLeftToggle>b__11_0>d.<>4__this = this;
				<<HandleOnClickLeftToggle>b__11_0>d.<>1__state = -1;
				<<HandleOnClickLeftToggle>b__11_0>d.<>t__builder.Start<MowingBuffView.<<HandleOnClickLeftToggle>b__11_0>d>(ref <<HandleOnClickLeftToggle>b__11_0>d);
				return <<HandleOnClickLeftToggle>b__11_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060351A8 RID: 217512 RVA: 0x00ED4C9C File Offset: 0x00ED2E9C
		private UniTask HandleOnClickLeftToggleAsync()
		{
			MowingBuffView.<HandleOnClickLeftToggleAsync>d__12 <HandleOnClickLeftToggleAsync>d__;
			<HandleOnClickLeftToggleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnClickLeftToggleAsync>d__.<>4__this = this;
			<HandleOnClickLeftToggleAsync>d__.<>1__state = -1;
			<HandleOnClickLeftToggleAsync>d__.<>t__builder.Start<MowingBuffView.<HandleOnClickLeftToggleAsync>d__12>(ref <HandleOnClickLeftToggleAsync>d__);
			return <HandleOnClickLeftToggleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351A9 RID: 217513 RVA: 0x00ED4CE0 File Offset: 0x00ED2EE0
		private void HandleOnClickRightToggle(EToggleState state)
		{
			UiAsyncTask task = new UiAsyncTask("MowingBuffView.RefreshTab", delegate()
			{
				MowingBuffView.<<HandleOnClickRightToggle>b__13_0>d <<HandleOnClickRightToggle>b__13_0>d;
				<<HandleOnClickRightToggle>b__13_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<HandleOnClickRightToggle>b__13_0>d.<>4__this = this;
				<<HandleOnClickRightToggle>b__13_0>d.<>1__state = -1;
				<<HandleOnClickRightToggle>b__13_0>d.<>t__builder.Start<MowingBuffView.<<HandleOnClickRightToggle>b__13_0>d>(ref <<HandleOnClickRightToggle>b__13_0>d);
				return <<HandleOnClickRightToggle>b__13_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060351AA RID: 217514 RVA: 0x00ED4D10 File Offset: 0x00ED2F10
		private UniTask HandleOnClickRightToggleAsync()
		{
			MowingBuffView.<HandleOnClickRightToggleAsync>d__14 <HandleOnClickRightToggleAsync>d__;
			<HandleOnClickRightToggleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnClickRightToggleAsync>d__.<>4__this = this;
			<HandleOnClickRightToggleAsync>d__.<>1__state = -1;
			<HandleOnClickRightToggleAsync>d__.<>t__builder.Start<MowingBuffView.<HandleOnClickRightToggleAsync>d__14>(ref <HandleOnClickRightToggleAsync>d__);
			return <HandleOnClickRightToggleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351AB RID: 217515 RVA: 0x00ED4D54 File Offset: 0x00ED2F54
		private void HandleMowingBasicBuffGridItemClick()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			if (instance.CurrentBuffViewType == EMowingBuffTabViewType.Progress)
			{
				return;
			}
			IMowingBuffOverviewData data = instance.BuildOverviewViewData();
			this.OverviewPanel.RefreshByCustomDataAsync(data);
		}

		// Token: 0x060351AC RID: 217516 RVA: 0x00ED4D88 File Offset: 0x00ED2F88
		private void HandleMowingSuperBuffGridItemClick()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			if (instance.CurrentBuffViewType == EMowingBuffTabViewType.Overview)
			{
				return;
			}
			IMowingBuffProgressData data = instance.BuildProgressViewData();
			MowingBuffProgress progressPanel = this.ProgressPanel;
			if (progressPanel == null)
			{
				return;
			}
			progressPanel.RefreshByCustomData(data);
		}

		// Token: 0x060351AD RID: 217517 RVA: 0x00ED4DBC File Offset: 0x00ED2FBC
		private bool HandleLeftCanExecuteChange()
		{
			return MowingRiskModel.Instance.CurrentBuffViewType > EMowingBuffTabViewType.Overview;
		}

		// Token: 0x060351AE RID: 217518 RVA: 0x00ED4DCB File Offset: 0x00ED2FCB
		private bool HandleRightCanExecuteChange()
		{
			return MowingRiskModel.Instance.CurrentBuffViewType != EMowingBuffTabViewType.Progress;
		}

		// Token: 0x060351AF RID: 217519 RVA: 0x00ED4DE0 File Offset: 0x00ED2FE0
		private List<UniTask> BuildTabItemTodoList()
		{
			List<UniTask> list = new List<UniTask>();
			list.Add(this.CreateOverviewAsync());
			list.Add(this.CreateCaptionAsync());
			if (MowingRiskModel.Instance.CurrentBuffViewUsage == EMowingBuffViewUsage.InBattle)
			{
				list.Add(this.CreateProgressAsync());
			}
			return list;
		}

		// Token: 0x060351B0 RID: 217520 RVA: 0x00ED4E28 File Offset: 0x00ED3028
		private UniTask CreateOverviewAsync()
		{
			MowingBuffView.<CreateOverviewAsync>d__20 <CreateOverviewAsync>d__;
			<CreateOverviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateOverviewAsync>d__.<>4__this = this;
			<CreateOverviewAsync>d__.<>1__state = -1;
			<CreateOverviewAsync>d__.<>t__builder.Start<MowingBuffView.<CreateOverviewAsync>d__20>(ref <CreateOverviewAsync>d__);
			return <CreateOverviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B1 RID: 217521 RVA: 0x00ED4E6C File Offset: 0x00ED306C
		private UniTask CreateProgressAsync()
		{
			MowingBuffView.<CreateProgressAsync>d__21 <CreateProgressAsync>d__;
			<CreateProgressAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateProgressAsync>d__.<>4__this = this;
			<CreateProgressAsync>d__.<>1__state = -1;
			<CreateProgressAsync>d__.<>t__builder.Start<MowingBuffView.<CreateProgressAsync>d__21>(ref <CreateProgressAsync>d__);
			return <CreateProgressAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B2 RID: 217522 RVA: 0x00ED4EB0 File Offset: 0x00ED30B0
		private UniTask CreateCaptionAsync()
		{
			MowingBuffView.<CreateCaptionAsync>d__22 <CreateCaptionAsync>d__;
			<CreateCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionAsync>d__.<>4__this = this;
			<CreateCaptionAsync>d__.<>1__state = -1;
			<CreateCaptionAsync>d__.<>t__builder.Start<MowingBuffView.<CreateCaptionAsync>d__22>(ref <CreateCaptionAsync>d__);
			return <CreateCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B3 RID: 217523 RVA: 0x00ED4EF4 File Offset: 0x00ED30F4
		private void RefreshCaption()
		{
			IMowingBuffCaptionData mowingBuffCaptionData = MowingRiskModel.Instance.BuildCaptionViewData();
			this.CaptionPanel.SetTitleByTextIdAndArgNew(mowingBuffCaptionData.TitleTextId, Array.Empty<object>());
			this.CaptionPanel.SetTitleIcon(mowingBuffCaptionData.IconPath);
		}

		// Token: 0x060351B4 RID: 217524 RVA: 0x00ED4F34 File Offset: 0x00ED3134
		private void RefreshCurrentTab()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (MowingRiskModel.Instance.CurrentBuffViewUsage == EMowingBuffViewUsage.BeforeBattle)
			{
				extendToggle.RootUIComp.Get().SetUIActive(true);
				extendToggle2.RootUIComp.Get().SetUIActive(false);
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				extendToggle.IsSelfInteractive = false;
				return;
			}
			bool currentBuffViewType = MowingRiskModel.Instance.CurrentBuffViewType != EMowingBuffTabViewType.Overview;
			extendToggle.RootUIComp.Get().SetActive(true, false);
			extendToggle2.RootUIComp.Get().SetActive(true, false);
			if (!currentBuffViewType)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
				extendToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle2.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060351B5 RID: 217525 RVA: 0x00ED4FF8 File Offset: 0x00ED31F8
		private void RefreshAllTabView(bool playStarAnim)
		{
			MowingBuffView.<>c__DisplayClass25_0 CS$<>8__locals1 = new MowingBuffView.<>c__DisplayClass25_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.playStarAnim = playStarAnim;
			UiAsyncTask task = new UiAsyncTask("MowingBuffView.RefreshTab", delegate()
			{
				MowingBuffView.<>c__DisplayClass25_0.<<RefreshAllTabView>b__0>d <<RefreshAllTabView>b__0>d;
				<<RefreshAllTabView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshAllTabView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshAllTabView>b__0>d.<>1__state = -1;
				<<RefreshAllTabView>b__0>d.<>t__builder.Start<MowingBuffView.<>c__DisplayClass25_0.<<RefreshAllTabView>b__0>d>(ref <<RefreshAllTabView>b__0>d);
				return <<RefreshAllTabView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060351B6 RID: 217526 RVA: 0x00ED503C File Offset: 0x00ED323C
		private UniTask RefreshAllTabViewAsync(bool playStarAnim)
		{
			MowingBuffView.<RefreshAllTabViewAsync>d__26 <RefreshAllTabViewAsync>d__;
			<RefreshAllTabViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAllTabViewAsync>d__.<>4__this = this;
			<RefreshAllTabViewAsync>d__.playStarAnim = playStarAnim;
			<RefreshAllTabViewAsync>d__.<>1__state = -1;
			<RefreshAllTabViewAsync>d__.<>t__builder.Start<MowingBuffView.<RefreshAllTabViewAsync>d__26>(ref <RefreshAllTabViewAsync>d__);
			return <RefreshAllTabViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B7 RID: 217527 RVA: 0x00ED5088 File Offset: 0x00ED3288
		private UniTask RefreshOverviewTabViewAsync(bool playStarAnim)
		{
			MowingBuffView.<RefreshOverviewTabViewAsync>d__27 <RefreshOverviewTabViewAsync>d__;
			<RefreshOverviewTabViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshOverviewTabViewAsync>d__.<>4__this = this;
			<RefreshOverviewTabViewAsync>d__.playStarAnim = playStarAnim;
			<RefreshOverviewTabViewAsync>d__.<>1__state = -1;
			<RefreshOverviewTabViewAsync>d__.<>t__builder.Start<MowingBuffView.<RefreshOverviewTabViewAsync>d__27>(ref <RefreshOverviewTabViewAsync>d__);
			return <RefreshOverviewTabViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B8 RID: 217528 RVA: 0x00ED50D4 File Offset: 0x00ED32D4
		private UniTask RefreshProgressTabViewAsync(bool playStarAnim)
		{
			MowingBuffView.<RefreshProgressTabViewAsync>d__28 <RefreshProgressTabViewAsync>d__;
			<RefreshProgressTabViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshProgressTabViewAsync>d__.<>4__this = this;
			<RefreshProgressTabViewAsync>d__.playStarAnim = playStarAnim;
			<RefreshProgressTabViewAsync>d__.<>1__state = -1;
			<RefreshProgressTabViewAsync>d__.<>t__builder.Start<MowingBuffView.<RefreshProgressTabViewAsync>d__28>(ref <RefreshProgressTabViewAsync>d__);
			return <RefreshProgressTabViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351B9 RID: 217529 RVA: 0x00ED5120 File Offset: 0x00ED3320
		private void BindTogglesCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.HandleLeftCanExecuteChange));
			extendToggle2.CanExecuteChange.Bind(new Func<bool>(this.HandleRightCanExecuteChange));
		}

		// Token: 0x060351BA RID: 217530 RVA: 0x00ED516C File Offset: 0x00ED336C
		private void UnbindTogglesCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			extendToggle.CanExecuteChange.Unbind();
			extendToggle2.CanExecuteChange.Unbind();
		}

		// Token: 0x0401C08E RID: 114830
		private MowingBuffOverview OverviewPanel;

		// Token: 0x0401C08F RID: 114831
		[Nullable(2)]
		private MowingBuffProgress ProgressPanel;

		// Token: 0x0401C090 RID: 114832
		private PopupCaptionItem CaptionPanel;

		// Token: 0x0200AFD2 RID: 45010
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036582 RID: 222594
			public const int CaptionItem = 0;

			// Token: 0x04036583 RID: 222595
			public const int LeftToggle = 1;

			// Token: 0x04036584 RID: 222596
			public const int RightToggle = 2;

			// Token: 0x04036585 RID: 222597
			public const int ContentItem = 3;
		}
	}
}
