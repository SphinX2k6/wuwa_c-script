using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B9 RID: 20921
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectView : UiViewBase
	{
		// Token: 0x0603591D RID: 219421 RVA: 0x00CB09BD File Offset: 0x00CAEBBD
		public PhantomArenaCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603591E RID: 219422 RVA: 0x00CB09D4 File Offset: 0x00CAEBD4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603591F RID: 219423 RVA: 0x00CB0A44 File Offset: 0x00CAEC44
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035920 RID: 219424 RVA: 0x00CB0A87 File Offset: 0x00CAEC87
		protected override void OnBeforeShow()
		{
			this.TabComponent.SelectToggleByIndex(this.SelectIndex, false);
			if (PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.ActivityId))
			{
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			this.BindRedDot();
		}

		// Token: 0x06035921 RID: 219425 RVA: 0x00CB0AC6 File Offset: 0x00CAECC6
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06035922 RID: 219426 RVA: 0x00CB0ACE File Offset: 0x00CAECCE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x06035923 RID: 219427 RVA: 0x00CB0B08 File Offset: 0x00CAED08
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x06035924 RID: 219428 RVA: 0x00CB0B44 File Offset: 0x00CAED44
		private void RefreshCount(EUiTabViewName viewName)
		{
			int num = 0;
			int num2 = 0;
			string textStringId = "";
			if (viewName == EUiTabViewName.PhantomArenaCollectBadgeTabView)
			{
				num = PhantomArenaModel.Instance.GetBadgeUnlockCount(this.ActivityId);
				num2 = PhantomArenaModel.Instance.GetBadgeAllCount(this.ActivityId);
				textStringId = "PhantomBattle_1118";
			}
			else if (viewName == EUiTabViewName.PhantomArenaCollectCardTabView || viewName == EUiTabViewName.PhantomArenaCollectCardTabViewNew)
			{
				num = PhantomArenaModel.Instance.GetCardUnlockCount(this.ActivityId);
				num2 = PhantomArenaModel.Instance.GetCardAllCount(this.ActivityId);
				textStringId = "PhantomBattle_1119";
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
		}

		// Token: 0x06035925 RID: 219429 RVA: 0x00CB0C03 File Offset: 0x00CAEE03
		private void OnClickBtnBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035926 RID: 219430 RVA: 0x00CB0C0C File Offset: 0x00CAEE0C
		private void OnClickBtnHelp()
		{
			int helpGroupId = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.ActivityId) ? 477 : 338;
			HelpController.Instance.OpenHelpById(helpGroupId);
		}

		// Token: 0x06035927 RID: 219431 RVA: 0x00CB0C43 File Offset: 0x00CAEE43
		private CommonTabItem TabItemProxyCreate(UUIItem uiItem, int? _)
		{
			return new CommonTabItem();
		}

		// Token: 0x06035928 RID: 219432 RVA: 0x00CB0C4C File Offset: 0x00CAEE4C
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.SelectIndex = index;
			this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, this.ActivityId, null);
			this.RefreshCount(viewName);
		}

		// Token: 0x06035929 RID: 219433 RVA: 0x00CB0CB0 File Offset: 0x00CAEEB0
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0603592A RID: 219434 RVA: 0x00CB0CE8 File Offset: 0x00CAEEE8
		private void OnCardInfoUpdate(int cardId)
		{
			EUiTabViewName viewName = (EUiTabViewName)this.TabDataList[this.SelectIndex].ChildViewName;
			this.RefreshCount(viewName);
		}

		// Token: 0x0603592B RID: 219435 RVA: 0x00CB0D1C File Offset: 0x00CAEF1C
		private void BindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectBadgeTabView.ToString(), ERedDotName.RedDotPhantomArenaBadgeReward.ToEnumString(), true);
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectCardTabView.ToString(), ERedDotName.RedDotPhantomArenaCardReward.ToEnumString(), true);
		}

		// Token: 0x0603592C RID: 219436 RVA: 0x00CB0D6C File Offset: 0x00CAEF6C
		private void UnBindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectBadgeTabView.ToString(), ERedDotName.RedDotPhantomArenaBadgeReward.ToEnumString(), false);
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectCardTabView.ToString(), ERedDotName.RedDotPhantomArenaCardReward.ToEnumString(), false);
		}

		// Token: 0x0603592D RID: 219437 RVA: 0x00CB0DBC File Offset: 0x00CAEFBC
		private void BindRedDotByName(string viewName, string redDotName, bool bIsBind)
		{
			int num = this.TabDataList.FindIndex((UiDynamicTab config) => config.ChildViewName == viewName);
			if (num >= 0)
			{
				CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
				if (bIsBind)
				{
					if (tabItemByIndex != null)
					{
						tabItemByIndex.BindRedDot((ERedDotName)Enum.Parse(typeof(ERedDotName), redDotName), new int?(this.ActivityId));
						return;
					}
				}
				else if (tabItemByIndex != null)
				{
					tabItemByIndex.UnBindRedDot();
				}
			}
		}

		// Token: 0x0401C6FB RID: 116475
		protected int ActivityId;

		// Token: 0x0401C6FC RID: 116476
		private int SelectIndex;

		// Token: 0x0401C6FD RID: 116477
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401C6FE RID: 116478
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401C6FF RID: 116479
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0200B344 RID: 45892
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036553 RID: 222547
			public const int ItemCaption = 0;

			// Token: 0x04036554 RID: 222548
			public const int TextNum = 1;

			// Token: 0x04036555 RID: 222549
			public const int ItemContent = 2;

			// Token: 0x04036556 RID: 222550
			public const int ItemTabPanel = 3;
		}
	}
}
