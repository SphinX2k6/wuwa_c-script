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
	// Token: 0x02004EE2 RID: 20194
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleBuyRoleView : UiViewBase
	{
		// Token: 0x06033D44 RID: 212292 RVA: 0x00C23712 File Offset: 0x00C21912
		[NullableContext(1)]
		public RogueBattleBuyRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D45 RID: 212293 RVA: 0x00C23724 File Offset: 0x00C21924
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

		// Token: 0x06033D46 RID: 212294 RVA: 0x00C2383D File Offset: 0x00C21A3D
		private void OnBtnHelp()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x06033D47 RID: 212295 RVA: 0x00C2384C File Offset: 0x00C21A4C
		private void OnBtnCancel()
		{
			MapRogueOpSelectView mapRogueOpSelectView = MapRogueModel.Instance.GetOpData(this.IncId) as MapRogueOpSelectView;
			if (mapRogueOpSelectView == null)
			{
				return;
			}
			mapRogueOpSelectView.Select(-2);
		}

		// Token: 0x06033D48 RID: 212296 RVA: 0x00C2387C File Offset: 0x00C21A7C
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

		// Token: 0x06033D49 RID: 212297 RVA: 0x00C2390C File Offset: 0x00C21B0C
		private int GetGroupIndex(int index)
		{
			return index / 2;
		}

		// Token: 0x06033D4A RID: 212298 RVA: 0x00C23911 File Offset: 0x00C21B11
		private void OnSelectOnPanelBack()
		{
			if (this.ViewSelectState)
			{
				this.DeselectCurrentRole();
			}
		}

		// Token: 0x06033D4B RID: 212299 RVA: 0x00C23924 File Offset: 0x00C21B24
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

		// Token: 0x06033D4C RID: 212300 RVA: 0x00C23984 File Offset: 0x00C21B84
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

		// Token: 0x06033D4D RID: 212301 RVA: 0x00C23AE4 File Offset: 0x00C21CE4
		private bool IsSelectOn(int index)
		{
			return this.SelectUiIndex == index;
		}

		// Token: 0x06033D4E RID: 212302 RVA: 0x00C23AEF File Offset: 0x00C21CEF
		[NullableContext(1)]
		private RogueBattleBuyRoleGroupItem CreateItem()
		{
			return new RogueBattleBuyRoleGroupItem
			{
				OnSelectCallback = new Action<int, RogueResGainData>(this.OnSelectCallback),
				IsSelectOn = new Func<int, bool>(this.IsSelectOn)
			};
		}

		// Token: 0x06033D4F RID: 212303 RVA: 0x00C23B1C File Offset: 0x00C21D1C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleBuyRoleView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRoleView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D50 RID: 212304 RVA: 0x00C23B5F File Offset: 0x00C21D5F
		private void InitViewState()
		{
			this.ViewSelectState = false;
			this.CaptionItem.SetCloseBtnActive(true);
			this.CaptionItem.SetHelpBtnActive(true);
			base.GetItem(5).SetUIActive(true);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06033D51 RID: 212305 RVA: 0x00C23B9C File Offset: 0x00C21D9C
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

		// Token: 0x06033D52 RID: 212306 RVA: 0x00C23C30 File Offset: 0x00C21E30
		private UniTask RefreshRoleList()
		{
			RogueBattleBuyRoleView.<RefreshRoleList>d__23 <RefreshRoleList>d__;
			<RefreshRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleList>d__.<>4__this = this;
			<RefreshRoleList>d__.<>1__state = -1;
			<RefreshRoleList>d__.<>t__builder.Start<RogueBattleBuyRoleView.<RefreshRoleList>d__23>(ref <RefreshRoleList>d__);
			return <RefreshRoleList>d__.<>t__builder.Task;
		}

		// Token: 0x06033D53 RID: 212307 RVA: 0x00C23C74 File Offset: 0x00C21E74
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

		// Token: 0x06033D54 RID: 212308 RVA: 0x00C23D64 File Offset: 0x00C21F64
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

		// Token: 0x0401B876 RID: 112758
		private int SelectUiIndex = -1;

		// Token: 0x0401B877 RID: 112759
		private bool ViewSelectState;

		// Token: 0x0401B878 RID: 112760
		private int IncId;

		// Token: 0x0401B879 RID: 112761
		private MapRogueTitleItem MapTitleItem;

		// Token: 0x0401B87A RID: 112762
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B87B RID: 112763
		private MapRoguePanelFetter PanelFetter;

		// Token: 0x0401B87C RID: 112764
		private RogueBattleBuyRolePreviewPanel PanelSelectOn;

		// Token: 0x0401B87D RID: 112765
		private RogueBattleShopButton RefreshButton;

		// Token: 0x0401B87E RID: 112766
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RogueBattleBuyRoleGroupItem, RoleBuyInfoGroupData> ScrollViewComponent;
	}
}
