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
	// Token: 0x020063DF RID: 25567
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffView : UiViewBase
	{
		// Token: 0x060404DE RID: 263390 RVA: 0x00F8DACC File Offset: 0x00F8BCCC
		public MowingBuffView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060404DF RID: 263391 RVA: 0x00F8DAD8 File Offset: 0x00F8BCD8
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

		// Token: 0x060404E0 RID: 263392 RVA: 0x00F8DBE4 File Offset: 0x00F8BDE4
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404E1 RID: 263393 RVA: 0x00F8DC27 File Offset: 0x00F8BE27
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MowingBasicBuffGridItemClick, new Action(this.HandleMowingBasicBuffGridItemClick));
			EventSystem.Instance.Add(EEventName.MowingSuperBuffGridItemClick, new Action(this.HandleMowingSuperBuffGridItemClick));
		}

		// Token: 0x060404E2 RID: 263394 RVA: 0x00F8DC61 File Offset: 0x00F8BE61
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MowingBasicBuffGridItemClick, new Action(this.HandleMowingBasicBuffGridItemClick));
			EventSystem.Instance.Remove(EEventName.MowingSuperBuffGridItemClick, new Action(this.HandleMowingSuperBuffGridItemClick));
		}

		// Token: 0x060404E3 RID: 263395 RVA: 0x00F8DC9B File Offset: 0x00F8BE9B
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshCurrentTab();
			this.RefreshAllTabView(false);
			this.BindTogglesCanExecuteChange();
		}

		// Token: 0x060404E4 RID: 263396 RVA: 0x00F8DCB6 File Offset: 0x00F8BEB6
		protected override void OnBeforeDestroy()
		{
			MowingRiskModel.Instance.ResetBuffViewCache();
			this.UnbindTogglesCanExecuteChange();
		}

		// Token: 0x060404E5 RID: 263397 RVA: 0x00F8DCC8 File Offset: 0x00F8BEC8
		private void HandleOnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060404E6 RID: 263398 RVA: 0x00F8DCD4 File Offset: 0x00F8BED4
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

		// Token: 0x060404E7 RID: 263399 RVA: 0x00F8DD04 File Offset: 0x00F8BF04
		private UniTask HandleOnClickLeftToggleAsync()
		{
			MowingBuffView.<HandleOnClickLeftToggleAsync>d__12 <HandleOnClickLeftToggleAsync>d__;
			<HandleOnClickLeftToggleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnClickLeftToggleAsync>d__.<>4__this = this;
			<HandleOnClickLeftToggleAsync>d__.<>1__state = -1;
			<HandleOnClickLeftToggleAsync>d__.<>t__builder.Start<MowingBuffView.<HandleOnClickLeftToggleAsync>d__12>(ref <HandleOnClickLeftToggleAsync>d__);
			return <HandleOnClickLeftToggleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404E8 RID: 263400 RVA: 0x00F8DD48 File Offset: 0x00F8BF48
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

		// Token: 0x060404E9 RID: 263401 RVA: 0x00F8DD78 File Offset: 0x00F8BF78
		private UniTask HandleOnClickRightToggleAsync()
		{
			MowingBuffView.<HandleOnClickRightToggleAsync>d__14 <HandleOnClickRightToggleAsync>d__;
			<HandleOnClickRightToggleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnClickRightToggleAsync>d__.<>4__this = this;
			<HandleOnClickRightToggleAsync>d__.<>1__state = -1;
			<HandleOnClickRightToggleAsync>d__.<>t__builder.Start<MowingBuffView.<HandleOnClickRightToggleAsync>d__14>(ref <HandleOnClickRightToggleAsync>d__);
			return <HandleOnClickRightToggleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404EA RID: 263402 RVA: 0x00F8DDBC File Offset: 0x00F8BFBC
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

		// Token: 0x060404EB RID: 263403 RVA: 0x00F8DDF0 File Offset: 0x00F8BFF0
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

		// Token: 0x060404EC RID: 263404 RVA: 0x00F8DE24 File Offset: 0x00F8C024
		private bool HandleLeftCanExecuteChange()
		{
			return MowingRiskModel.Instance.CurrentBuffViewType > EMowingBuffTabViewType.Overview;
		}

		// Token: 0x060404ED RID: 263405 RVA: 0x00F8DE33 File Offset: 0x00F8C033
		private bool HandleRightCanExecuteChange()
		{
			return MowingRiskModel.Instance.CurrentBuffViewType != EMowingBuffTabViewType.Progress;
		}

		// Token: 0x060404EE RID: 263406 RVA: 0x00F8DE48 File Offset: 0x00F8C048
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

		// Token: 0x060404EF RID: 263407 RVA: 0x00F8DE90 File Offset: 0x00F8C090
		private UniTask CreateOverviewAsync()
		{
			MowingBuffView.<CreateOverviewAsync>d__20 <CreateOverviewAsync>d__;
			<CreateOverviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateOverviewAsync>d__.<>4__this = this;
			<CreateOverviewAsync>d__.<>1__state = -1;
			<CreateOverviewAsync>d__.<>t__builder.Start<MowingBuffView.<CreateOverviewAsync>d__20>(ref <CreateOverviewAsync>d__);
			return <CreateOverviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404F0 RID: 263408 RVA: 0x00F8DED4 File Offset: 0x00F8C0D4
		private UniTask CreateProgressAsync()
		{
			MowingBuffView.<CreateProgressAsync>d__21 <CreateProgressAsync>d__;
			<CreateProgressAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateProgressAsync>d__.<>4__this = this;
			<CreateProgressAsync>d__.<>1__state = -1;
			<CreateProgressAsync>d__.<>t__builder.Start<MowingBuffView.<CreateProgressAsync>d__21>(ref <CreateProgressAsync>d__);
			return <CreateProgressAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404F1 RID: 263409 RVA: 0x00F8DF18 File Offset: 0x00F8C118
		private UniTask CreateCaptionAsync()
		{
			MowingBuffView.<CreateCaptionAsync>d__22 <CreateCaptionAsync>d__;
			<CreateCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionAsync>d__.<>4__this = this;
			<CreateCaptionAsync>d__.<>1__state = -1;
			<CreateCaptionAsync>d__.<>t__builder.Start<MowingBuffView.<CreateCaptionAsync>d__22>(ref <CreateCaptionAsync>d__);
			return <CreateCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404F2 RID: 263410 RVA: 0x00F8DF5C File Offset: 0x00F8C15C
		private void RefreshCaption()
		{
			IMowingBuffCaptionData mowingBuffCaptionData = MowingRiskModel.Instance.BuildCaptionViewData();
			this.CaptionPanel.SetTitleByTextIdAndArgNew(mowingBuffCaptionData.TitleTextId, Array.Empty<object>());
			this.CaptionPanel.SetTitleIcon(mowingBuffCaptionData.IconPath);
		}

		// Token: 0x060404F3 RID: 263411 RVA: 0x00F8DF9C File Offset: 0x00F8C19C
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

		// Token: 0x060404F4 RID: 263412 RVA: 0x00F8E060 File Offset: 0x00F8C260
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

		// Token: 0x060404F5 RID: 263413 RVA: 0x00F8E0A4 File Offset: 0x00F8C2A4
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

		// Token: 0x060404F6 RID: 263414 RVA: 0x00F8E0F0 File Offset: 0x00F8C2F0
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

		// Token: 0x060404F7 RID: 263415 RVA: 0x00F8E13C File Offset: 0x00F8C33C
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

		// Token: 0x060404F8 RID: 263416 RVA: 0x00F8E188 File Offset: 0x00F8C388
		private void BindTogglesCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.HandleLeftCanExecuteChange));
			extendToggle2.CanExecuteChange.Bind(new Func<bool>(this.HandleRightCanExecuteChange));
		}

		// Token: 0x060404F9 RID: 263417 RVA: 0x00F8E1D4 File Offset: 0x00F8C3D4
		private void UnbindTogglesCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			extendToggle.CanExecuteChange.Unbind();
			extendToggle2.CanExecuteChange.Unbind();
		}

		// Token: 0x0402175F RID: 137055
		private MowingBuffOverview OverviewPanel;

		// Token: 0x04021760 RID: 137056
		[Nullable(2)]
		private MowingBuffProgress ProgressPanel;

		// Token: 0x04021761 RID: 137057
		private PopupCaptionItem CaptionPanel;

		// Token: 0x0200C5EB RID: 50667
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BC23 RID: 244771
			public const int CaptionItem = 0;

			// Token: 0x0403BC24 RID: 244772
			public const int LeftToggle = 1;

			// Token: 0x0403BC25 RID: 244773
			public const int RightToggle = 2;

			// Token: 0x0403BC26 RID: 244774
			public const int ContentItem = 3;
		}
	}
}
