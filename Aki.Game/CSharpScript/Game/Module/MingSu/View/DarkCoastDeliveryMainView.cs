using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BE RID: 17342
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryMainView : UiViewBase
	{
		// Token: 0x0602BD26 RID: 179494 RVA: 0x00C4D787 File Offset: 0x00C4B987
		public DarkCoastDeliveryMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BD27 RID: 179495 RVA: 0x00C4D7B4 File Offset: 0x00C4B9B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(20, typeof(UUIText)),
				new ValueTuple<int, Type>(21, typeof(UUIText)),
				new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(25, typeof(UUIItem)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUIItem)),
				new ValueTuple<int, Type>(28, typeof(UUIItem)),
				new ValueTuple<int, Type>(29, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(19, new Action(this.OnClickRewardBtn)),
				new ValueTuple<int, Delegate>(22, new Action(this.OnClickSubmitBtn)),
				new ValueTuple<int, Delegate>(24, new Action(this.OnClickSubmitIconBtn))
			};
		}

		// Token: 0x0602BD28 RID: 179496 RVA: 0x00C4DACC File Offset: 0x00C4BCCC
		protected override UniTask OnBeforeStartAsync()
		{
			DarkCoastDeliveryMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DarkCoastDeliveryMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BD29 RID: 179497 RVA: 0x00C4DB10 File Offset: 0x00C4BD10
		private void InitLineItemList()
		{
			this.GrayLineItemList = new List<UUIItem>();
			this.LightLineItemList = new List<UUIItem>();
			for (int i = 1; i < 13; i++)
			{
				if (i % 2 != 0)
				{
					this.GrayLineItemList.Add(base.GetItem(i));
				}
				else
				{
					this.LightLineItemList.Add(base.GetItem(i));
				}
			}
		}

		// Token: 0x0602BD2A RID: 179498 RVA: 0x00C4DB6C File Offset: 0x00C4BD6C
		private UniTask InitLevelItemList()
		{
			DarkCoastDeliveryMainView.<InitLevelItemList>d__19 <InitLevelItemList>d__;
			<InitLevelItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelItemList>d__.<>4__this = this;
			<InitLevelItemList>d__.<>1__state = -1;
			<InitLevelItemList>d__.<>t__builder.Start<DarkCoastDeliveryMainView.<InitLevelItemList>d__19>(ref <InitLevelItemList>d__);
			return <InitLevelItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0602BD2B RID: 179499 RVA: 0x00C4DBB0 File Offset: 0x00C4BDB0
		private UniTask InitLevelItem(DarkCoastDeliveryLevelItem levelItem, UUIItem item)
		{
			DarkCoastDeliveryMainView.<InitLevelItem>d__20 <InitLevelItem>d__;
			<InitLevelItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelItem>d__.levelItem = levelItem;
			<InitLevelItem>d__.item = item;
			<InitLevelItem>d__.<>1__state = -1;
			<InitLevelItem>d__.<>t__builder.Start<DarkCoastDeliveryMainView.<InitLevelItem>d__20>(ref <InitLevelItem>d__);
			return <InitLevelItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602BD2C RID: 179500 RVA: 0x00C4DBFC File Offset: 0x00C4BDFC
		protected override void OnBeforeShow()
		{
			MingSuModel.Instance.CurrentInteractCreatureDataLongId = InteractionModel.Instance.InteractCreatureDataLongId;
			this.RefreshUi();
			this.RefreshLineItemList();
			if (this.CurSelectLevelData != null)
			{
				this.TipPanel.RefreshUi(this.CurSelectLevelData);
			}
			this.RefreshLevelUpItemList();
		}

		// Token: 0x0602BD2D RID: 179501 RVA: 0x00C4DC48 File Offset: 0x00C4BE48
		private void RefreshUi()
		{
			string curLevelTexturePath = this.Data.GetCurLevelTexturePath();
			base.SetTextureShowUntilLoaded(curLevelTexturePath, base.GetTexture(0), null);
			base.SetTextureShowUntilLoaded(curLevelTexturePath, base.GetTexture(29), null);
			int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.Data.DragonPoolId);
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.Data.DragonPoolId);
			if (targetDragonPoolLevelById >= targetDragonPoolMaxLevelById)
			{
				int targetDragonPoolLevelNeedCoreById = MingSuModel.Instance.GetTargetDragonPoolLevelNeedCoreById(this.Data.DragonPoolId, targetDragonPoolLevelById - 1);
				base.GetText(20).SetText(targetDragonPoolLevelNeedCoreById.ToString() + "/" + targetDragonPoolLevelNeedCoreById.ToString(), true);
				base.GetItem(27).SetUIActive(false);
				base.GetItem(28).SetUIActive(true);
			}
			else
			{
				int targetDragonPoolCoreCountById = MingSuModel.Instance.GetTargetDragonPoolCoreCountById(this.Data.DragonPoolId);
				int targetDragonPoolLevelNeedCoreById2 = MingSuModel.Instance.GetTargetDragonPoolLevelNeedCoreById(this.Data.DragonPoolId, targetDragonPoolLevelById);
				base.GetText(20).SetText(targetDragonPoolCoreCountById.ToString() + "/" + targetDragonPoolLevelNeedCoreById2.ToString(), true);
				base.GetItem(27).SetUIActive(true);
				base.GetItem(28).SetUIActive(false);
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.Data.GetCoreId(), 0);
			UUIText text = base.GetText(21);
			text.SetText(itemCountByConfigId.ToString(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = itemCountByConfigId <= 0 && targetDragonPoolLevelById < targetDragonPoolMaxLevelById;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			bool uiactive = MingSuModel.Instance.CheckUp(this.Data.DragonPoolId);
			base.GetItem(25).SetUIActive(uiactive);
			bool rewardRedDotState = this.Data.GetRewardRedDotState();
			UUIItem item = base.GetItem(26);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(rewardRedDotState);
		}

		// Token: 0x0602BD2E RID: 179502 RVA: 0x00C4DE18 File Offset: 0x00C4C018
		private void RefreshLevelUpItemList()
		{
			int dragonPoolLevel = this.Data.GetDragonPoolLevel();
			if (this.PreLevel >= dragonPoolLevel)
			{
				return;
			}
			int level = this.PreLevel + 1;
			int num = dragonPoolLevel - level + 1;
			if (num <= 0)
			{
				return;
			}
			if (num == 1)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					this.RefreshLevelItem(level);
				}, 300f, null, null, true, 1f);
			}
			else
			{
				TimerSystem.Instance.Loop(delegate(float _)
				{
					int level;
					this.RefreshLevelItem(level);
					level = level;
					level++;
				}, 300f, num, 1f, null, null, true);
			}
			this.PreLevel = dragonPoolLevel;
		}

		// Token: 0x0602BD2F RID: 179503 RVA: 0x00C4DEBC File Offset: 0x00C4C0BC
		private void RefreshLevelItem(int level)
		{
			DarkCoastDeliveryLevelItem selectItemByLevel = this.GetSelectItemByLevel(level);
			if (selectItemByLevel == null)
			{
				return;
			}
			selectItemByLevel.RefreshUi();
			selectItemByLevel.PlaySequence(false);
		}

		// Token: 0x0602BD30 RID: 179504 RVA: 0x00C4DEE4 File Offset: 0x00C4C0E4
		[NullableContext(2)]
		private DarkCoastDeliveryLevelItem GetSelectItemByLevel(int level)
		{
			for (int i = 0; i < this.LevelItemList.Count; i++)
			{
				DarkCoastDeliveryLevelItem darkCoastDeliveryLevelItem = this.LevelItemList[i];
				if (darkCoastDeliveryLevelItem.LevelData.Id == level)
				{
					return darkCoastDeliveryLevelItem;
				}
			}
			return null;
		}

		// Token: 0x0602BD31 RID: 179505 RVA: 0x00C4DF28 File Offset: 0x00C4C128
		private void RefreshLineItemList()
		{
			int dragonPoolLevel = this.Data.GetDragonPoolLevel();
			for (int i = 0; i < this.LightLineItemList.Count; i++)
			{
				this.LightLineItemList[i].SetUIActive(dragonPoolLevel >= i);
				this.GrayLineItemList[i].SetUIActive(dragonPoolLevel < i);
			}
		}

		// Token: 0x0602BD32 RID: 179506 RVA: 0x00C4DF84 File Offset: 0x00C4C184
		private void SelectLevelItem(DarkCoastDeliveryLevelData data, DarkCoastDeliveryLevelItem item)
		{
			if (this.CurSelectLevelData == data)
			{
				return;
			}
			if (this.CurSelectLevelItem != null)
			{
				this.CurSelectLevelItem.SetSelect(false);
			}
			this.CurSelectLevelData = data;
			this.CurSelectLevelItem = item;
			this.CurSelectLevelItem.SetSelect(true);
			this.TipPanel.RefreshUi(data);
			this.TipPanel.SetUiActive(true);
			this.UiViewSequence.StopPrevSequence(false, false);
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x0602BD33 RID: 179507 RVA: 0x00C4E008 File Offset: 0x00C4C208
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdateDragonPoolView, new Action(this.OnRefreshDragonPoolData));
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshReward));
		}

		// Token: 0x0602BD34 RID: 179508 RVA: 0x00C4E042 File Offset: 0x00C4C242
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdateDragonPoolView, new Action(this.OnRefreshDragonPoolData));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshReward));
		}

		// Token: 0x0602BD35 RID: 179509 RVA: 0x00C4E07C File Offset: 0x00C4C27C
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BD36 RID: 179510 RVA: 0x00C4E085 File Offset: 0x00C4C285
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(113);
		}

		// Token: 0x0602BD37 RID: 179511 RVA: 0x00C4E093 File Offset: 0x00C4C293
		private void OnClickLevelItem(DarkCoastDeliveryLevelData data, DarkCoastDeliveryLevelItem item)
		{
			this.SelectLevelItem(data, item);
		}

		// Token: 0x0602BD38 RID: 179512 RVA: 0x00C4E0A0 File Offset: 0x00C4C2A0
		private void OnClickRewardBtn()
		{
			IActivityRewardViewData activityRewardViewData = this.Data.GetActivityRewardViewData();
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, activityRewardViewData, delegate(bool success, int viewId)
			{
				if (!success)
				{
					return;
				}
				base.AddChildViewById(viewId);
			});
		}

		// Token: 0x0602BD39 RID: 179513 RVA: 0x00C4E0D8 File Offset: 0x00C4C2D8
		private void OnClickSubmitBtn()
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(this.Data.GetCoreId(), 0) <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DarkCoastDelivery_Item_0", Array.Empty<object>());
				return;
			}
			this.PreLevel = this.Data.GetDragonPoolLevel();
			MingSuController.SendHandInMingSuRequest(this.Data.DragonPoolId);
		}

		// Token: 0x0602BD3A RID: 179514 RVA: 0x00C4E134 File Offset: 0x00C4C334
		private void OnClickSubmitIconBtn()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.Data.GetCoreId(), true, null, false);
		}

		// Token: 0x0602BD3B RID: 179515 RVA: 0x00C4E150 File Offset: 0x00C4C350
		private void OnRefreshDragonPoolData()
		{
			int curLevel = this.Data.GetDragonPoolLevel();
			if (curLevel > this.PreLevel)
			{
				DarkCoastDeliveryLevelUpViewData param = new DarkCoastDeliveryLevelUpViewData(this.PreLevel, curLevel);
				UiManager.Instance.OpenView(EUiViewName.DarkCoastDeliveryLevelUpView, param, delegate(bool _, int __)
				{
					DarkCoastDeliveryLevelItem selectItemByLevel = this.GetSelectItemByLevel(curLevel);
					if (selectItemByLevel == null)
					{
						return;
					}
					this.SelectLevelItem(selectItemByLevel.LevelData, selectItemByLevel);
				});
				return;
			}
			this.UiViewSequence.PlaySequence("Sweep", false, null);
			this.RefreshUi();
		}

		// Token: 0x0602BD3C RID: 179516 RVA: 0x00C4E1D8 File Offset: 0x00C4C3D8
		private void OnRefreshReward(IActivityRewardViewData data)
		{
			this.RefreshUi();
		}

		// Token: 0x040179D3 RID: 96723
		private const int LINE_START_INDEX = 1;

		// Token: 0x040179D4 RID: 96724
		private const int LINE_COUNT = 6;

		// Token: 0x040179D5 RID: 96725
		private const int ITEM_START_INDEX = 13;

		// Token: 0x040179D6 RID: 96726
		private const int ITEM_COUNT = 5;

		// Token: 0x040179D7 RID: 96727
		private const int LEVEL_ITEM_SHOW_DELAY = 300;

		// Token: 0x040179D8 RID: 96728
		[Nullable(2)]
		private DarkCoastDeliveryData Data;

		// Token: 0x040179D9 RID: 96729
		[Nullable(2)]
		private DarkCoastDeliveryLevelData CurSelectLevelData;

		// Token: 0x040179DA RID: 96730
		[Nullable(2)]
		private DarkCoastDeliveryLevelItem CurSelectLevelItem;

		// Token: 0x040179DB RID: 96731
		private List<UUIItem> GrayLineItemList = new List<UUIItem>();

		// Token: 0x040179DC RID: 96732
		private List<UUIItem> LightLineItemList = new List<UUIItem>();

		// Token: 0x040179DD RID: 96733
		private readonly List<DarkCoastDeliveryLevelItem> LevelItemList = new List<DarkCoastDeliveryLevelItem>();

		// Token: 0x040179DE RID: 96734
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040179DF RID: 96735
		[Nullable(2)]
		private DarkCoastDeliveryTipPanel TipPanel;

		// Token: 0x040179E0 RID: 96736
		private int PreLevel;

		// Token: 0x0200A0B8 RID: 41144
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04031ED4 RID: 204500
			public const int LevelTexture = 0;

			// Token: 0x04031ED5 RID: 204501
			public const int GrayLine1 = 1;

			// Token: 0x04031ED6 RID: 204502
			public const int LightLine1 = 2;

			// Token: 0x04031ED7 RID: 204503
			public const int GrayLine2 = 3;

			// Token: 0x04031ED8 RID: 204504
			public const int LightLine2 = 4;

			// Token: 0x04031ED9 RID: 204505
			public const int GrayLine3 = 5;

			// Token: 0x04031EDA RID: 204506
			public const int LightLine3 = 6;

			// Token: 0x04031EDB RID: 204507
			public const int GrayLine4 = 7;

			// Token: 0x04031EDC RID: 204508
			public const int LightLine4 = 8;

			// Token: 0x04031EDD RID: 204509
			public const int GrayLine5 = 9;

			// Token: 0x04031EDE RID: 204510
			public const int LightLine5 = 10;

			// Token: 0x04031EDF RID: 204511
			public const int GrayLine6 = 11;

			// Token: 0x04031EE0 RID: 204512
			public const int LightLine6 = 12;

			// Token: 0x04031EE1 RID: 204513
			public const int DarkCoastDeliveryItem1 = 13;

			// Token: 0x04031EE2 RID: 204514
			public const int DarkCoastDeliveryItem2 = 14;

			// Token: 0x04031EE3 RID: 204515
			public const int DarkCoastDeliveryItem3 = 15;

			// Token: 0x04031EE4 RID: 204516
			public const int DarkCoastDeliveryItem4 = 16;

			// Token: 0x04031EE5 RID: 204517
			public const int DarkCoastDeliveryItem5 = 17;

			// Token: 0x04031EE6 RID: 204518
			public const int TipPanelItem = 18;

			// Token: 0x04031EE7 RID: 204519
			public const int RewardBtn = 19;

			// Token: 0x04031EE8 RID: 204520
			public const int RewardProgressText = 20;

			// Token: 0x04031EE9 RID: 204521
			public const int OwnCountText = 21;

			// Token: 0x04031EEA RID: 204522
			public const int SubmitBtn = 22;

			// Token: 0x04031EEB RID: 204523
			public const int CaptionItem = 23;

			// Token: 0x04031EEC RID: 204524
			public const int SubmitIconBtn = 24;

			// Token: 0x04031EED RID: 204525
			public const int LevelUpRedDot = 25;

			// Token: 0x04031EEE RID: 204526
			public const int RewardRedDot = 26;

			// Token: 0x04031EEF RID: 204527
			public const int SubmitRootItem = 27;

			// Token: 0x04031EF0 RID: 204528
			public const int SubmitDoneItem = 28;

			// Token: 0x04031EF1 RID: 204529
			public const int SubLevelTexture = 29;
		}
	}
}
