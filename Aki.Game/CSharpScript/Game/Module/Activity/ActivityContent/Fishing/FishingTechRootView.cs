using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055AB RID: 21931
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechRootView : UiViewBase
	{
		// Token: 0x060365E6 RID: 222694 RVA: 0x00F2E1F3 File Offset: 0x00F2C3F3
		public FishingTechRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060365E7 RID: 222695 RVA: 0x00F2E21C File Offset: 0x00F2C41C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060365E8 RID: 222696 RVA: 0x00F2E309 File Offset: 0x00F2C509
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
			EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x060365E9 RID: 222697 RVA: 0x00F2E343 File Offset: 0x00F2C543
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x060365EA RID: 222698 RVA: 0x00F2E380 File Offset: 0x00F2C580
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTechRootView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTechRootView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060365EB RID: 222699 RVA: 0x00F2E3C3 File Offset: 0x00F2C5C3
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060365EC RID: 222700 RVA: 0x00F2E3CC File Offset: 0x00F2C5CC
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.FishingNormalTech, base.GetItem(4), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.FishingRoleTech, base.GetItem(5), null, 0);
			if (this.OpenParam == null)
			{
				this.TabItemList[0].SetToggleState(EToggleState.ETT_Checked, true);
				return;
			}
			IFishingTechOpenParam fishingTechOpenParam = this.OpenParam as IFishingTechOpenParam;
			int num = fishingTechOpenParam.Type - 1;
			if (num < 0 || num >= this.TabItemList.Count)
			{
				return;
			}
			FishingTechTabItem fishingTechTabItem = this.TabItemList[num];
			if (fishingTechTabItem != null)
			{
				fishingTechTabItem.SetToggleState(EToggleState.ETT_Checked, true);
			}
			this.CurrentTabIndex = num;
			UiDynamicTab data = this.TabDataList[this.CurrentTabIndex];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			this.TabViewComponent.ToggleCallBack(data, viewName, this.TabItemList[this.CurrentTabIndex], fishingTechOpenParam.NodeId, null);
		}

		// Token: 0x060365ED RID: 222701 RVA: 0x00F2E4C2 File Offset: 0x00F2C6C2
		protected override void OnBeforeShow()
		{
			if (this.IsInit)
			{
				EventSystem.Instance.Emit(EEventName.FishingTechViewComeBack);
				this.RefreshRedDot();
			}
			this.IsInit = true;
		}

		// Token: 0x060365EE RID: 222702 RVA: 0x00F2E4E9 File Offset: 0x00F2C6E9
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTech, base.GetItem(4), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleTech, base.GetItem(5), 0);
		}

		// Token: 0x060365EF RID: 222703 RVA: 0x00F2E51C File Offset: 0x00F2C71C
		private UniTask InitTabComponent()
		{
			FishingTechRootView.<InitTabComponent>d__16 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<FishingTechRootView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x060365F0 RID: 222704 RVA: 0x00F2E560 File Offset: 0x00F2C760
		private UniTask InitTabItem(UUIItem uiItem)
		{
			FishingTechRootView.<InitTabItem>d__17 <InitTabItem>d__;
			<InitTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabItem>d__.<>4__this = this;
			<InitTabItem>d__.uiItem = uiItem;
			<InitTabItem>d__.<>1__state = -1;
			<InitTabItem>d__.<>t__builder.Start<FishingTechRootView.<InitTabItem>d__17>(ref <InitTabItem>d__);
			return <InitTabItem>d__.<>t__builder.Task;
		}

		// Token: 0x060365F1 RID: 222705 RVA: 0x00F2E5AC File Offset: 0x00F2C7AC
		private void ToggleCallback(int tabIndex)
		{
			int currentTabIndex = this.CurrentTabIndex;
			this.CurrentTabIndex = tabIndex;
			if (currentTabIndex != -1)
			{
				this.TabItemList[currentTabIndex].SetToggleState(EToggleState.ETT_UnChecked, true);
			}
			UiDynamicTab data = this.TabDataList[tabIndex];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			this.TabViewComponent.ToggleCallBack(data, viewName, this.TabItemList[this.CurrentTabIndex], null, null);
		}

		// Token: 0x060365F2 RID: 222706 RVA: 0x00F2E620 File Offset: 0x00F2C820
		private bool CanExecuteChange(int tabIndex, bool _)
		{
			return this.CurrentTabIndex != tabIndex;
		}

		// Token: 0x060365F3 RID: 222707 RVA: 0x00F2E62E File Offset: 0x00F2C82E
		private void OnCommonItemCountAnyChange(int normalItem, int count)
		{
			if (FishingDefine.fishingItemList.Contains(normalItem))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x060365F4 RID: 222708 RVA: 0x00F2E643 File Offset: 0x00F2C843
		private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (FishingDefine.fishingItemList.Contains(normalItem.Id))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x060365F5 RID: 222709 RVA: 0x00F2E660 File Offset: 0x00F2C860
		private void RefreshRedDot()
		{
			foreach (FishingTech fishingTech in FishingConfig.Instance.GetFishingTechList())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, fishingTech.Id);
			}
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.MainRole);
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.Phoebe);
		}

		// Token: 0x0401CAFF RID: 117503
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401CB00 RID: 117504
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401CB01 RID: 117505
		protected List<FishingTechTabItem> TabItemList = new List<FishingTechTabItem>();

		// Token: 0x0401CB02 RID: 117506
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401CB03 RID: 117507
		protected int CurrentTabIndex = -1;

		// Token: 0x0401CB04 RID: 117508
		private bool IsInit;

		// Token: 0x0200B229 RID: 45609
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037140 RID: 225600
			public const int CaptionItem = 0;

			// Token: 0x04037141 RID: 225601
			public const int TabComponent = 1;

			// Token: 0x04037142 RID: 225602
			public const int TabAItem = 2;

			// Token: 0x04037143 RID: 225603
			public const int TabBItem = 3;

			// Token: 0x04037144 RID: 225604
			public const int TabARedDotItem = 4;

			// Token: 0x04037145 RID: 225605
			public const int TabBRedDotItem = 5;
		}
	}
}
