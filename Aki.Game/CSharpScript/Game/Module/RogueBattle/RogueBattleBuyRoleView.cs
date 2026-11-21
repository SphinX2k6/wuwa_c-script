using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EAB RID: 16043
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleBuyRoleView : UiViewBase
	{
		// Token: 0x06028BAF RID: 166831 RVA: 0x00B6CCBC File Offset: 0x00B6AEBC
		[NullableContext(1)]
		public RogueBattleBuyRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BB0 RID: 166832 RVA: 0x00B6CCCC File Offset: 0x00B6AECC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnSelectOnPanelBack))
			};
		}

		// Token: 0x06028BB1 RID: 166833 RVA: 0x00B6CDE5 File Offset: 0x00B6AFE5
		private void OnBtnHelp()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x06028BB2 RID: 166834 RVA: 0x00B6CDF4 File Offset: 0x00B6AFF4
		private void OnBtnCancel()
		{
			MapRogueOpSelectView mapRogueOpSelectView = MapRogueModel.Instance.GetOpData(this.IncId) as MapRogueOpSelectView;
			if (mapRogueOpSelectView == null)
			{
				return;
			}
			mapRogueOpSelectView.Select(-2);
		}

		// Token: 0x06028BB3 RID: 166835 RVA: 0x00B6CE24 File Offset: 0x00B6B024
		private void OnBtnRefresh()
		{
			MapRogueOpSelectView mapRogueOpSelectView = MapRogueModel.Instance.GetOpData(this.IncId) as MapRogueOpSelectView;
			if (mapRogueOpSelectView == null)
			{
				return;
			}
			RogueResOption rogueResOption = mapRogueOpSelectView.Data.SelectViewOp.RogueResOption;
			if (rogueResOption.RefreshCost > InventoryModel.Instance.GetItemCountByConfigId(rogueResOption.RefreshItem, 0))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RogueBattle_RefreshItemNotEnough", Array.Empty<object>());
				return;
			}
			if (rogueResOption.UseRefreshCount >= rogueResOption.MaxRefreshCount)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RogueBattle_RefreshCountMax", Array.Empty<object>());
				return;
			}
			mapRogueOpSelectView.Select(-1);
		}

		// Token: 0x06028BB4 RID: 166836 RVA: 0x00B6CEB4 File Offset: 0x00B6B0B4
		private int GetGroupIndex(int index)
		{
			return index / 2;
		}

		// Token: 0x06028BB5 RID: 166837 RVA: 0x00B6CEB9 File Offset: 0x00B6B0B9
		private void OnSelectOnPanelBack()
		{
			if (this.ViewSelectState)
			{
				this.DeselectCurrentRole();
			}
		}

		// Token: 0x06028BB6 RID: 166838 RVA: 0x00B6CECC File Offset: 0x00B6B0CC
		private void DeselectCurrentRole()
		{
			if (this.SelectUiIndex >= 0)
			{
				int groupIndex = this.GetGroupIndex(this.SelectUiIndex);
				if (this.ScrollViewComponent.IsGridDisplaying(groupIndex))
				{
					RogueBattleBuyRoleGroupItem rogueBattleBuyRoleGroupItem = this.ScrollViewComponent.UnsafeGetGridProxy(groupIndex, false);
					if (rogueBattleBuyRoleGroupItem != null)
					{
						rogueBattleBuyRoleGroupItem.Deselect(this.SelectUiIndex);
					}
				}
			}
			this.SelectUiIndex = -1;
			this.SetViewState(false);
		}

		// Token: 0x06028BB7 RID: 166839 RVA: 0x00B6CF2C File Offset: 0x00B6B12C
		[NullableContext(1)]
		private void OnSelectCallback(int index, RogueResGainData data)
		{
			int selectUiIndex = this.SelectUiIndex;
			if (this.SelectUiIndex >= 0)
			{
				int groupIndex = this.GetGroupIndex(this.SelectUiIndex);
				if (this.ScrollViewComponent.IsGridDisplaying(groupIndex))
				{
					RogueBattleBuyRoleGroupItem rogueBattleBuyRoleGroupItem = this.ScrollViewComponent.UnsafeGetGridProxy(groupIndex, false);
					if (rogueBattleBuyRoleGroupItem != null)
					{
						rogueBattleBuyRoleGroupItem.Deselect(this.SelectUiIndex);
					}
				}
			}
			this.SelectUiIndex = index;
			RogueBattleBuyRoleGroupItem rogueBattleBuyRoleGroupItem2 = this.ScrollViewComponent.UnsafeGetGridProxy(this.GetGroupIndex(this.SelectUiIndex), false);
			if (rogueBattleBuyRoleGroupItem2 != null)
			{
				rogueBattleBuyRoleGroupItem2.Select(index);
			}
			RogueBattleShopButton refreshButton = this.RefreshButton;
			RogueResRole rogueResRole = data.RogueResRole;
			refreshButton.SetInteractive(rogueResRole == null || !rogueResRole.IsSell);
			this.PanelSelectOn.Refresh(data);
			this.SetViewState(true);
			if (selectUiIndex != -1)
			{
				if (selectUiIndex != this.SelectUiIndex)
				{
					UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
					if (uiViewSequence != null)
					{
						uiViewSequence.StopSequenceByKey("Switch02", false, true);
					}
					UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
					if (uiViewSequence2 != null)
					{
						uiViewSequence2.StopSequenceByKey("Switch", false, true);
					}
					UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
					if (uiViewSequence3 == null)
					{
						return;
					}
					uiViewSequence3.PlaySequence("Switch02", false, null);
				}
				return;
			}
			UiBehaviorLevelSequence uiViewSequence4 = this.UiViewSequence;
			if (uiViewSequence4 != null)
			{
				uiViewSequence4.StopSequenceByKey("Switch02", false, true);
			}
			UiBehaviorLevelSequence uiViewSequence5 = this.UiViewSequence;
			if (uiViewSequence5 != null)
			{
				uiViewSequence5.StopSequenceByKey("Switch", false, true);
			}
			UiBehaviorLevelSequence uiViewSequence6 = this.UiViewSequence;
			if (uiViewSequence6 == null)
			{
				return;
			}
			uiViewSequence6.PlaySequence("Switch", false, null);
		}

		// Token: 0x06028BB8 RID: 166840 RVA: 0x00B6D08C File Offset: 0x00B6B28C
		private bool IsSelectOn(int index)
		{
			return this.SelectUiIndex == index;
		}

		// Token: 0x06028BB9 RID: 166841 RVA: 0x00B6D097 File Offset: 0x00B6B297
		[NullableContext(1)]
		private RogueBattleBuyRoleGroupItem CreateItem()
		{
			return new RogueBattleBuyRoleGroupItem
			{
				OnSelectCallback = new Action<int, RogueResGainData>(this.OnSelectCallback),
				IsSelectOn = new Func<int, bool>(this.IsSelectOn)
			};
		}

		// Token: 0x06028BBA RID: 166842 RVA: 0x00B6D0C4 File Offset: 0x00B6B2C4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleBuyRoleView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRoleView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028BBB RID: 166843 RVA: 0x00B6D107 File Offset: 0x00B6B307
		private void InitViewState()
		{
			this.ViewSelectState = false;
			this.CaptionItem.SetCloseBtnActive(true);
			this.CaptionItem.SetHelpBtnActive(true);
			base.GetItem(5).SetUIActive(true);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06028BBC RID: 166844 RVA: 0x00B6D144 File Offset: 0x00B6B344
		private void SetViewState(bool selectOn)
		{
			if (this.ViewSelectState == selectOn)
			{
				return;
			}
			this.ViewSelectState = selectOn;
			this.CaptionItem.SetCloseBtnActive(!selectOn);
			this.CaptionItem.SetHelpBtnActive(!selectOn);
			this.RefreshBtnRefresh();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("SwClose", false, true);
			}
			base.GetItem(7).SetUIActive(true);
			if (!selectOn)
			{
				this.PanelFetter.RefreshFetter();
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 == null)
				{
					return;
				}
				uiViewSequence2.PlaySequence("SwClose", false, null);
			}
		}

		// Token: 0x06028BBD RID: 166845 RVA: 0x00B6D1D8 File Offset: 0x00B6B3D8
		private UniTask RefreshRoleList()
		{
			RogueBattleBuyRoleView.<RefreshRoleList>d__23 <RefreshRoleList>d__;
			<RefreshRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleList>d__.<>4__this = this;
			<RefreshRoleList>d__.<>1__state = -1;
			<RefreshRoleList>d__.<>t__builder.Start<RogueBattleBuyRoleView.<RefreshRoleList>d__23>(ref <RefreshRoleList>d__);
			return <RefreshRoleList>d__.<>t__builder.Task;
		}

		// Token: 0x06028BBE RID: 166846 RVA: 0x00B6D21C File Offset: 0x00B6B41C
		private void RefreshBtnRefresh()
		{
			MapRogueOpSelectView mapRogueOpSelectView = MapRogueModel.Instance.GetOpData(this.IncId) as MapRogueOpSelectView;
			if (mapRogueOpSelectView == null)
			{
				return;
			}
			RogueResOption rogueResOption = mapRogueOpSelectView.Data.SelectViewOp.RogueResOption;
			bool flag = rogueResOption.MaxRefreshCount > 0 && !this.ViewSelectState;
			this.RefreshButton.SetActive(flag);
			if (!flag)
			{
				return;
			}
			if (rogueResOption.RefreshCost != 0)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(rogueResOption.RefreshItem, 0);
				this.RefreshButton.SetCostText(rogueResOption.RefreshCost.ToString(), new bool?(itemCountByConfigId < rogueResOption.RefreshCost));
			}
			this.RefreshButton.SetText("RogueBattle_BuyRole_RefreshCost", new object[]
			{
				rogueResOption.UseRefreshCount,
				rogueResOption.MaxRefreshCount
			});
			if (rogueResOption.RefreshItem != 0)
			{
				this.RefreshButton.SetCostItem(rogueResOption.RefreshItem);
			}
		}

		// Token: 0x06028BBF RID: 166847 RVA: 0x00B6D30C File Offset: 0x00B6B50C
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
			string a = configParams[0];
			if (a == "FirstRole")
			{
				LoopScrollView<RogueBattleBuyRoleGroupItem, RoleBuyInfoGroupData> scrollViewComponent = this.ScrollViewComponent;
				if (scrollViewComponent == null)
				{
					return null;
				}
				RogueBattleBuyRoleGroupItem rogueBattleBuyRoleGroupItem = scrollViewComponent.UnsafeGetGridProxy(0, false);
				if (rogueBattleBuyRoleGroupItem == null)
				{
					return null;
				}
				return rogueBattleBuyRoleGroupItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "FirstFetter"))
				{
					return null;
				}
				MapRoguePanelFetter panelFetter = this.PanelFetter;
				if (panelFetter == null)
				{
					return null;
				}
				return panelFetter.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x04016249 RID: 90697
		private int SelectUiIndex = -1;

		// Token: 0x0401624A RID: 90698
		private bool ViewSelectState;

		// Token: 0x0401624B RID: 90699
		private int IncId;

		// Token: 0x0401624C RID: 90700
		private MapRogueTitleItem MapTitleItem;

		// Token: 0x0401624D RID: 90701
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401624E RID: 90702
		private MapRoguePanelFetter PanelFetter;

		// Token: 0x0401624F RID: 90703
		private RogueBattleBuyRolePreviewPanel PanelSelectOn;

		// Token: 0x04016250 RID: 90704
		private RogueBattleShopButton RefreshButton;

		// Token: 0x04016251 RID: 90705
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RogueBattleBuyRoleGroupItem, RoleBuyInfoGroupData> ScrollViewComponent;
	}
}
