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
	// Token: 0x0200662D RID: 26157
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechRootView : UiViewBase
	{
		// Token: 0x06041921 RID: 268577 RVA: 0x00FE713B File Offset: 0x00FE533B
		public FishingTechRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041922 RID: 268578 RVA: 0x00FE7164 File Offset: 0x00FE5364
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

		// Token: 0x06041923 RID: 268579 RVA: 0x00FE7251 File Offset: 0x00FE5451
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
			EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06041924 RID: 268580 RVA: 0x00FE728B File Offset: 0x00FE548B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06041925 RID: 268581 RVA: 0x00FE72C8 File Offset: 0x00FE54C8
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTechRootView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTechRootView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041926 RID: 268582 RVA: 0x00FE730B File Offset: 0x00FE550B
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06041927 RID: 268583 RVA: 0x00FE7314 File Offset: 0x00FE5514
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

		// Token: 0x06041928 RID: 268584 RVA: 0x00FE740A File Offset: 0x00FE560A
		protected override void OnBeforeShow()
		{
			if (this.IsInit)
			{
				EventSystem.Instance.Emit(EEventName.FishingTechViewComeBack);
				this.RefreshRedDot();
			}
			this.IsInit = true;
		}

		// Token: 0x06041929 RID: 268585 RVA: 0x00FE7431 File Offset: 0x00FE5631
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTech, base.GetItem(4), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleTech, base.GetItem(5), 0);
		}

		// Token: 0x0604192A RID: 268586 RVA: 0x00FE7464 File Offset: 0x00FE5664
		private UniTask InitTabComponent()
		{
			FishingTechRootView.<InitTabComponent>d__16 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<FishingTechRootView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0604192B RID: 268587 RVA: 0x00FE74A8 File Offset: 0x00FE56A8
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

		// Token: 0x0604192C RID: 268588 RVA: 0x00FE74F4 File Offset: 0x00FE56F4
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

		// Token: 0x0604192D RID: 268589 RVA: 0x00FE7568 File Offset: 0x00FE5768
		private bool CanExecuteChange(int tabIndex, bool _)
		{
			return this.CurrentTabIndex != tabIndex;
		}

		// Token: 0x0604192E RID: 268590 RVA: 0x00FE7576 File Offset: 0x00FE5776
		private void OnCommonItemCountAnyChange(int normalItem, int count)
		{
			if (FishingDefine.fishingItemList.Contains(normalItem))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x0604192F RID: 268591 RVA: 0x00FE758B File Offset: 0x00FE578B
		private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (FishingDefine.fishingItemList.Contains(normalItem.Id))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x06041930 RID: 268592 RVA: 0x00FE75A8 File Offset: 0x00FE57A8
		private void RefreshRedDot()
		{
			foreach (FishingTech fishingTech in FishingConfig.Instance.GetFishingTechList())
			{
				EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, fishingTech.Id);
			}
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.MainRole);
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.Phoebe);
		}

		// Token: 0x040221CE RID: 139726
		protected PopupCaptionItem CaptionItem;

		// Token: 0x040221CF RID: 139727
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x040221D0 RID: 139728
		protected List<FishingTechTabItem> TabItemList = new List<FishingTechTabItem>();

		// Token: 0x040221D1 RID: 139729
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x040221D2 RID: 139730
		protected int CurrentTabIndex = -1;

		// Token: 0x040221D3 RID: 139731
		private bool IsInit;

		// Token: 0x0200C847 RID: 51271
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C7FB RID: 247803
			public const int CaptionItem = 0;

			// Token: 0x0403C7FC RID: 247804
			public const int TabComponent = 1;

			// Token: 0x0403C7FD RID: 247805
			public const int TabAItem = 2;

			// Token: 0x0403C7FE RID: 247806
			public const int TabBItem = 3;

			// Token: 0x0403C7FF RID: 247807
			public const int TabARedDotItem = 4;

			// Token: 0x0403C800 RID: 247808
			public const int TabBRedDotItem = 5;
		}
	}
}
