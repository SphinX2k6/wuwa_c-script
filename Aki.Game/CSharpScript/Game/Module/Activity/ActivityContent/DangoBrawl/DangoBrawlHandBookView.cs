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
	// Token: 0x0200575E RID: 22366
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlHandBookView : UiViewBase
	{
		// Token: 0x06037255 RID: 225877 RVA: 0x00F64406 File Offset: 0x00F62606
		[NullableContext(1)]
		public DangoBrawlHandBookView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037256 RID: 225878 RVA: 0x00F6441C File Offset: 0x00F6261C
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

		// Token: 0x06037257 RID: 225879 RVA: 0x00F644C8 File Offset: 0x00F626C8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037258 RID: 225880 RVA: 0x00F6450B File Offset: 0x00F6270B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06037259 RID: 225881 RVA: 0x00F64529 File Offset: 0x00F62729
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x0603725A RID: 225882 RVA: 0x00F64548 File Offset: 0x00F62748
		private void OnRedDotRefresh(int activityId)
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			if (myActivityData == null || myActivityData.Id != activityId)
			{
				return;
			}
			this.RefreshTopTabRedDots();
		}

		// Token: 0x0603725B RID: 225883 RVA: 0x00F64574 File Offset: 0x00F62774
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

		// Token: 0x0603725C RID: 225884 RVA: 0x00F645C3 File Offset: 0x00F627C3
		protected override void OnBeforeShow()
		{
			this.RefreshTopTabRedDots();
		}

		// Token: 0x0603725D RID: 225885 RVA: 0x00F645CB File Offset: 0x00F627CB
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x0603725E RID: 225886 RVA: 0x00F645E8 File Offset: 0x00F627E8
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

		// Token: 0x0603725F RID: 225887 RVA: 0x00F64660 File Offset: 0x00F62860
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

		// Token: 0x06037260 RID: 225888 RVA: 0x00F6469F File Offset: 0x00F6289F
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(682);
		}

		// Token: 0x06037261 RID: 225889 RVA: 0x00F646B0 File Offset: 0x00F628B0
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037262 RID: 225890 RVA: 0x00F646BC File Offset: 0x00F628BC
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

		// Token: 0x0401D261 RID: 119393
		private DangoBrawlHandBookTabItem ItemTab;

		// Token: 0x0401D262 RID: 119394
		private DangoBrawlHandBookTabItem OccupationTab;

		// Token: 0x0401D263 RID: 119395
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D264 RID: 119396
		[Nullable(1)]
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401D265 RID: 119397
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401D266 RID: 119398
		private UUIExtendToggle CurSelectToggle;

		// Token: 0x0200B354 RID: 45908
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040376B8 RID: 227000
			TabItemA,
			// Token: 0x040376B9 RID: 227001
			TabItemB,
			// Token: 0x040376BA RID: 227002
			CaptionItem,
			// Token: 0x040376BB RID: 227003
			ItemContent
		}
	}
}
