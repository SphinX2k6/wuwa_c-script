using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200680E RID: 26638
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlHandBookView : UiViewBase
	{
		// Token: 0x06042700 RID: 272128 RVA: 0x01022EC2 File Offset: 0x010210C2
		[NullableContext(1)]
		public DangoBrawlHandBookView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042701 RID: 272129 RVA: 0x01022ED8 File Offset: 0x010210D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042702 RID: 272130 RVA: 0x01022F84 File Offset: 0x01021184
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042703 RID: 272131 RVA: 0x01022FC7 File Offset: 0x010211C7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06042704 RID: 272132 RVA: 0x01022FE5 File Offset: 0x010211E5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06042705 RID: 272133 RVA: 0x01023004 File Offset: 0x01021204
		private void OnRedDotRefresh(int activityId)
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			if (myActivityData == null || myActivityData.Id != activityId)
			{
				return;
			}
			this.RefreshTopTabRedDots();
		}

		// Token: 0x06042706 RID: 272134 RVA: 0x01023030 File Offset: 0x01021230
		private void RefreshTopTabRedDots()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlHandBookTabItem itemTab = this.ItemTab;
			if (itemTab != null)
			{
				itemTab.SetRedDotVisible(myActivityData != null && myActivityData.HasNewItemRedDot(null));
			}
			DangoBrawlHandBookTabItem occupationTab = this.OccupationTab;
			if (occupationTab == null)
			{
				return;
			}
			occupationTab.SetRedDotVisible(false);
		}

		// Token: 0x06042707 RID: 272135 RVA: 0x0102307F File Offset: 0x0102127F
		protected override void OnBeforeShow()
		{
			this.RefreshTopTabRedDots();
		}

		// Token: 0x06042708 RID: 272136 RVA: 0x01023087 File Offset: 0x01021287
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06042709 RID: 272137 RVA: 0x010230A4 File Offset: 0x010212A4
		[NullableContext(1)]
		private void ToggleCallBack(int index, UUIExtendToggle toggle)
		{
			if (this.CurSelectToggle != null)
			{
				this.CurSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurSelectToggle = toggle;
			this.CurSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			this.TabViewComponent.ToggleCallBack(data, viewName, null, this.OpenParam as DangoBrawlHandBookViewOpenData, null);
		}

		// Token: 0x0604270A RID: 272138 RVA: 0x0102311C File Offset: 0x0102131C
		private EDangoBrawlHandBookTab GetOpenTab()
		{
			object openParam = this.OpenParam;
			DangoBrawlHandBookViewOpenData dangoBrawlHandBookViewOpenData = openParam as DangoBrawlHandBookViewOpenData;
			EDangoBrawlHandBookTab result;
			if (dangoBrawlHandBookViewOpenData == null)
			{
				if (openParam is EDangoBrawlHandBookTab)
				{
					EDangoBrawlHandBookTab edangoBrawlHandBookTab = (EDangoBrawlHandBookTab)openParam;
					result = edangoBrawlHandBookTab;
				}
				else
				{
					result = EDangoBrawlHandBookTab.Item;
				}
			}
			else
			{
				result = dangoBrawlHandBookViewOpenData.Tab;
			}
			return result;
		}

		// Token: 0x0604270B RID: 272139 RVA: 0x0102315B File Offset: 0x0102135B
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(682);
		}

		// Token: 0x0604270C RID: 272140 RVA: 0x0102316C File Offset: 0x0102136C
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604270D RID: 272141 RVA: 0x01023178 File Offset: 0x01021378
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			DangoBrawlOccupationTabView dangoBrawlOccupationTabView = ((tabViewComponent != null) ? tabViewComponent.GetCurrentTabView() : null) as DangoBrawlOccupationTabView;
			if (dangoBrawlOccupationTabView == null)
			{
				return null;
			}
			int oneBasedIndex;
			if (configParams.Length == 2 && configParams[0] == "CoreItem" && int.TryParse(configParams[1], out oneBasedIndex))
			{
				UUIItem weaponItemRootItem = dangoBrawlOccupationTabView.GetWeaponItemRootItem(oneBasedIndex);
				if (weaponItemRootItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					weaponItemRootItem,
					weaponItemRootItem
				};
			}
			else
			{
				if (configParams.Length != 1 || !(configParams[0] == "CombineInfoBtn"))
				{
					return null;
				}
				UUIItem itemTipsCombineInfoItem = dangoBrawlOccupationTabView.GetItemTipsCombineInfoItem();
				if (itemTipsCombineInfoItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					itemTipsCombineInfoItem,
					itemTipsCombineInfoItem
				};
			}
		}

		// Token: 0x04022A04 RID: 141828
		private DangoBrawlHandBookTabItem ItemTab;

		// Token: 0x04022A05 RID: 141829
		private DangoBrawlHandBookTabItem OccupationTab;

		// Token: 0x04022A06 RID: 141830
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022A07 RID: 141831
		[Nullable(1)]
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04022A08 RID: 141832
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04022A09 RID: 141833
		private UUIExtendToggle CurSelectToggle;

		// Token: 0x0200C987 RID: 51591
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CDCB RID: 249291
			TabItemA,
			// Token: 0x0403CDCC RID: 249292
			TabItemB,
			// Token: 0x0403CDCD RID: 249293
			CaptionItem,
			// Token: 0x0403CDCE RID: 249294
			ItemContent
		}
	}
}
