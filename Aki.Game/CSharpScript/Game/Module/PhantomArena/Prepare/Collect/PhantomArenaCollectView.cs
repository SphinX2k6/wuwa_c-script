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
	// Token: 0x02004189 RID: 16777
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectView : UiViewBase
	{
		// Token: 0x0602A818 RID: 174104 RVA: 0x00BFDFF9 File Offset: 0x00BFC1F9
		public PhantomArenaCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A819 RID: 174105 RVA: 0x00BFE010 File Offset: 0x00BFC210
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

		// Token: 0x0602A81A RID: 174106 RVA: 0x00BFE080 File Offset: 0x00BFC280
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A81B RID: 174107 RVA: 0x00BFE0C3 File Offset: 0x00BFC2C3
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

		// Token: 0x0602A81C RID: 174108 RVA: 0x00BFE102 File Offset: 0x00BFC302
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602A81D RID: 174109 RVA: 0x00BFE10A File Offset: 0x00BFC30A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0602A81E RID: 174110 RVA: 0x00BFE144 File Offset: 0x00BFC344
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0602A81F RID: 174111 RVA: 0x00BFE180 File Offset: 0x00BFC380
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

		// Token: 0x0602A820 RID: 174112 RVA: 0x00BFE23F File Offset: 0x00BFC43F
		private void OnClickBtnBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A821 RID: 174113 RVA: 0x00BFE248 File Offset: 0x00BFC448
		private void OnClickBtnHelp()
		{
			int helpGroupId = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.ActivityId) ? 477 : 338;
			HelpController.Instance.OpenHelpById(helpGroupId);
		}

		// Token: 0x0602A822 RID: 174114 RVA: 0x00BFE27F File Offset: 0x00BFC47F
		private CommonTabItem TabItemProxyCreate(UUIItem uiItem, int? _)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602A823 RID: 174115 RVA: 0x00BFE288 File Offset: 0x00BFC488
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.SelectIndex = index;
			this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, this.ActivityId, null);
			this.RefreshCount(viewName);
		}

		// Token: 0x0602A824 RID: 174116 RVA: 0x00BFE2EC File Offset: 0x00BFC4EC
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0602A825 RID: 174117 RVA: 0x00BFE324 File Offset: 0x00BFC524
		private void OnCardInfoUpdate(int cardId)
		{
			EUiTabViewName viewName = (EUiTabViewName)this.TabDataList[this.SelectIndex].ChildViewName;
			this.RefreshCount(viewName);
		}

		// Token: 0x0602A826 RID: 174118 RVA: 0x00BFE358 File Offset: 0x00BFC558
		private void BindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectBadgeTabView.ToString(), ERedDotName.RedDotPhantomArenaBadgeReward.ToEnumString(), true);
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectCardTabView.ToString(), ERedDotName.RedDotPhantomArenaCardReward.ToEnumString(), true);
		}

		// Token: 0x0602A827 RID: 174119 RVA: 0x00BFE3A8 File Offset: 0x00BFC5A8
		private void UnBindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectBadgeTabView.ToString(), ERedDotName.RedDotPhantomArenaBadgeReward.ToEnumString(), false);
			this.BindRedDotByName(EUiTabViewName.PhantomArenaCollectCardTabView.ToString(), ERedDotName.RedDotPhantomArenaCardReward.ToEnumString(), false);
		}

		// Token: 0x0602A828 RID: 174120 RVA: 0x00BFE3F8 File Offset: 0x00BFC5F8
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

		// Token: 0x04017130 RID: 94512
		protected int ActivityId;

		// Token: 0x04017131 RID: 94513
		private int SelectIndex;

		// Token: 0x04017132 RID: 94514
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04017133 RID: 94515
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04017134 RID: 94516
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x02009D7C RID: 40316
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030FA6 RID: 200614
			public const int ItemCaption = 0;

			// Token: 0x04030FA7 RID: 200615
			public const int TextNum = 1;

			// Token: 0x04030FA8 RID: 200616
			public const int ItemContent = 2;

			// Token: 0x04030FA9 RID: 200617
			public const int ItemTabPanel = 3;
		}
	}
}
