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
	// Token: 0x020053DB RID: 21467
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryMainView : UiViewBase
	{
		// Token: 0x06036DDF RID: 224735 RVA: 0x00CFE6B7 File Offset: 0x00CFC8B7
		public DarkCoastDeliveryMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036DE0 RID: 224736 RVA: 0x00CFE6E4 File Offset: 0x00CFC8E4
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

		// Token: 0x06036DE1 RID: 224737 RVA: 0x00CFE9FC File Offset: 0x00CFCBFC
		protected override UniTask OnBeforeStartAsync()
		{
			DarkCoastDeliveryMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DarkCoastDeliveryMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036DE2 RID: 224738 RVA: 0x00CFEA40 File Offset: 0x00CFCC40
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

		// Token: 0x06036DE3 RID: 224739 RVA: 0x00CFEA9C File Offset: 0x00CFCC9C
		private UniTask InitLevelItemList()
		{
			DarkCoastDeliveryMainView.<InitLevelItemList>d__19 <InitLevelItemList>d__;
			<InitLevelItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelItemList>d__.<>4__this = this;
			<InitLevelItemList>d__.<>1__state = -1;
			<InitLevelItemList>d__.<>t__builder.Start<DarkCoastDeliveryMainView.<InitLevelItemList>d__19>(ref <InitLevelItemList>d__);
			return <InitLevelItemList>d__.<>t__builder.Task;
		}

		// Token: 0x06036DE4 RID: 224740 RVA: 0x00CFEAE0 File Offset: 0x00CFCCE0
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

		// Token: 0x06036DE5 RID: 224741 RVA: 0x00CFEB2C File Offset: 0x00CFCD2C
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

		// Token: 0x06036DE6 RID: 224742 RVA: 0x00CFEB78 File Offset: 0x00CFCD78
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

		// Token: 0x06036DE7 RID: 224743 RVA: 0x00CFED48 File Offset: 0x00CFCF48
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

		// Token: 0x06036DE8 RID: 224744 RVA: 0x00CFEDEC File Offset: 0x00CFCFEC
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

		// Token: 0x06036DE9 RID: 224745 RVA: 0x00CFEE14 File Offset: 0x00CFD014
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

		// Token: 0x06036DEA RID: 224746 RVA: 0x00CFEE58 File Offset: 0x00CFD058
		private void RefreshLineItemList()
		{
			int dragonPoolLevel = this.Data.GetDragonPoolLevel();
			for (int i = 0; i < this.LightLineItemList.Count; i++)
			{
				this.LightLineItemList[i].SetUIActive(dragonPoolLevel >= i);
				this.GrayLineItemList[i].SetUIActive(dragonPoolLevel < i);
			}
		}

		// Token: 0x06036DEB RID: 224747 RVA: 0x00CFEEB4 File Offset: 0x00CFD0B4
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

		// Token: 0x06036DEC RID: 224748 RVA: 0x00CFEF38 File Offset: 0x00CFD138
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdateDragonPoolView, new Action(this.OnRefreshDragonPoolData));
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshReward));
		}

		// Token: 0x06036DED RID: 224749 RVA: 0x00CFEF72 File Offset: 0x00CFD172
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdateDragonPoolView, new Action(this.OnRefreshDragonPoolData));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshReward));
		}

		// Token: 0x06036DEE RID: 224750 RVA: 0x00CFEFAC File Offset: 0x00CFD1AC
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036DEF RID: 224751 RVA: 0x00CFEFB5 File Offset: 0x00CFD1B5
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(113);
		}

		// Token: 0x06036DF0 RID: 224752 RVA: 0x00CFEFC3 File Offset: 0x00CFD1C3
		private void OnClickLevelItem(DarkCoastDeliveryLevelData data, DarkCoastDeliveryLevelItem item)
		{
			this.SelectLevelItem(data, item);
		}

		// Token: 0x06036DF1 RID: 224753 RVA: 0x00CFEFD0 File Offset: 0x00CFD1D0
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

		// Token: 0x06036DF2 RID: 224754 RVA: 0x00CFF008 File Offset: 0x00CFD208
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

		// Token: 0x06036DF3 RID: 224755 RVA: 0x00CFF064 File Offset: 0x00CFD264
		private void OnClickSubmitIconBtn()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.Data.GetCoreId(), true, null);
		}

		// Token: 0x06036DF4 RID: 224756 RVA: 0x00CFF080 File Offset: 0x00CFD280
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

		// Token: 0x06036DF5 RID: 224757 RVA: 0x00CFF108 File Offset: 0x00CFD308
		private void OnRefreshReward(IActivityRewardViewData data)
		{
			this.RefreshUi();
		}

		// Token: 0x0401CF3B RID: 118587
		private const int LINE_START_INDEX = 1;

		// Token: 0x0401CF3C RID: 118588
		private const int LINE_COUNT = 6;

		// Token: 0x0401CF3D RID: 118589
		private const int ITEM_START_INDEX = 13;

		// Token: 0x0401CF3E RID: 118590
		private const int ITEM_COUNT = 5;

		// Token: 0x0401CF3F RID: 118591
		private const int LEVEL_ITEM_SHOW_DELAY = 300;

		// Token: 0x0401CF40 RID: 118592
		[Nullable(2)]
		private DarkCoastDeliveryData Data;

		// Token: 0x0401CF41 RID: 118593
		[Nullable(2)]
		private DarkCoastDeliveryLevelData CurSelectLevelData;

		// Token: 0x0401CF42 RID: 118594
		[Nullable(2)]
		private DarkCoastDeliveryLevelItem CurSelectLevelItem;

		// Token: 0x0401CF43 RID: 118595
		private List<UUIItem> GrayLineItemList = new List<UUIItem>();

		// Token: 0x0401CF44 RID: 118596
		private List<UUIItem> LightLineItemList = new List<UUIItem>();

		// Token: 0x0401CF45 RID: 118597
		private readonly List<DarkCoastDeliveryLevelItem> LevelItemList = new List<DarkCoastDeliveryLevelItem>();

		// Token: 0x0401CF46 RID: 118598
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CF47 RID: 118599
		[Nullable(2)]
		private DarkCoastDeliveryTipPanel TipPanel;

		// Token: 0x0401CF48 RID: 118600
		private int PreLevel;

		// Token: 0x0200B680 RID: 46720
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0403747F RID: 226431
			public const int LevelTexture = 0;

			// Token: 0x04037480 RID: 226432
			public const int GrayLine1 = 1;

			// Token: 0x04037481 RID: 226433
			public const int LightLine1 = 2;

			// Token: 0x04037482 RID: 226434
			public const int GrayLine2 = 3;

			// Token: 0x04037483 RID: 226435
			public const int LightLine2 = 4;

			// Token: 0x04037484 RID: 226436
			public const int GrayLine3 = 5;

			// Token: 0x04037485 RID: 226437
			public const int LightLine3 = 6;

			// Token: 0x04037486 RID: 226438
			public const int GrayLine4 = 7;

			// Token: 0x04037487 RID: 226439
			public const int LightLine4 = 8;

			// Token: 0x04037488 RID: 226440
			public const int GrayLine5 = 9;

			// Token: 0x04037489 RID: 226441
			public const int LightLine5 = 10;

			// Token: 0x0403748A RID: 226442
			public const int GrayLine6 = 11;

			// Token: 0x0403748B RID: 226443
			public const int LightLine6 = 12;

			// Token: 0x0403748C RID: 226444
			public const int DarkCoastDeliveryItem1 = 13;

			// Token: 0x0403748D RID: 226445
			public const int DarkCoastDeliveryItem2 = 14;

			// Token: 0x0403748E RID: 226446
			public const int DarkCoastDeliveryItem3 = 15;

			// Token: 0x0403748F RID: 226447
			public const int DarkCoastDeliveryItem4 = 16;

			// Token: 0x04037490 RID: 226448
			public const int DarkCoastDeliveryItem5 = 17;

			// Token: 0x04037491 RID: 226449
			public const int TipPanelItem = 18;

			// Token: 0x04037492 RID: 226450
			public const int RewardBtn = 19;

			// Token: 0x04037493 RID: 226451
			public const int RewardProgressText = 20;

			// Token: 0x04037494 RID: 226452
			public const int OwnCountText = 21;

			// Token: 0x04037495 RID: 226453
			public const int SubmitBtn = 22;

			// Token: 0x04037496 RID: 226454
			public const int CaptionItem = 23;

			// Token: 0x04037497 RID: 226455
			public const int SubmitIconBtn = 24;

			// Token: 0x04037498 RID: 226456
			public const int LevelUpRedDot = 25;

			// Token: 0x04037499 RID: 226457
			public const int RewardRedDot = 26;

			// Token: 0x0403749A RID: 226458
			public const int SubmitRootItem = 27;

			// Token: 0x0403749B RID: 226459
			public const int SubmitDoneItem = 28;

			// Token: 0x0403749C RID: 226460
			public const int SubLevelTexture = 29;
		}
	}
}
