using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053E0 RID: 21472
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuView : CollectItemViewBase
	{
		// Token: 0x06036E36 RID: 224822 RVA: 0x00D00C34 File Offset: 0x00CFEE34
		public MingSuView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036E37 RID: 224823 RVA: 0x00D00C40 File Offset: 0x00CFEE40
		protected override void OnRegisterComponent()
		{
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "创建鸣素体界面!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InitComponent();
		}

		// Token: 0x06036E38 RID: 224824 RVA: 0x00D00C6F File Offset: 0x00CFEE6F
		protected override void OnBegined()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(delegate
				{
				});
			}
			this.InitView();
		}

		// Token: 0x06036E39 RID: 224825 RVA: 0x00D00CAC File Offset: 0x00CFEEAC
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequencePurely("Show", false, false);
		}

		// Token: 0x06036E3A RID: 224826 RVA: 0x00D00CC0 File Offset: 0x00CFEEC0
		protected override void OnEnded()
		{
			if (this.LoadSequenceHandleId != null)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadSequenceHandleId.Value);
				this.LoadSequenceHandleId = null;
			}
			this.ExpBarSprite = null;
		}

		// Token: 0x06036E3B RID: 224827 RVA: 0x00D00CF8 File Offset: 0x00CFEEF8
		private void InitComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnLeftMove)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnRightMove)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnAddCore)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickedItemButton)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickedCloseButton))
			};
		}

		// Token: 0x06036E3C RID: 224828 RVA: 0x00D00ECE File Offset: 0x00CFF0CE
		private void InitView()
		{
			this.ExpBarSprite = base.GetSprite(2);
			this.RefreshAll();
		}

		// Token: 0x06036E3D RID: 224829 RVA: 0x00D00EE4 File Offset: 0x00CFF0E4
		private void RefreshShowLevel(int level)
		{
			UUIText text = base.GetText(3);
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int num = level;
			if (num > targetDragonPoolMaxLevelById)
			{
				num = targetDragonPoolMaxLevelById;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "MingSuLevelText", new <>z__ReadOnlySingleElementList<object>(num));
			this.CurrentShowLevel = num;
			MingSuModel.Instance.CurrentPreviewLevel = this.CurrentShowLevel;
		}

		// Token: 0x06036E3E RID: 224830 RVA: 0x00D00F44 File Offset: 0x00CFF144
		private void RefreshLeftRightBtnState()
		{
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			UUIItem uuiitem2 = base.GetButton(1).RootUIComp.Get();
			if (this.CurrentShowLevel == 1)
			{
				uuiitem.SetUIActive(false);
				uuiitem2.SetUIActive(true);
				return;
			}
			if (this.CurrentShowLevel == MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId))
			{
				uuiitem2.SetUIActive(false);
				uuiitem.SetUIActive(true);
				return;
			}
			uuiitem2.SetUIActive(true);
			uuiitem.SetUIActive(true);
		}

		// Token: 0x06036E3F RID: 224831 RVA: 0x00D00FC8 File Offset: 0x00CFF1C8
		private void RefreshCoreData()
		{
			MingSuModel instance = MingSuModel.Instance;
			int targetDragonPoolLevelById = instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			int targetDragonPoolMaxLevelById = instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			UUIText text = base.GetText(4);
			if (this.CurrentShowLevel == targetDragonPoolLevelById + 1 || (this.CurrentShowLevel == targetDragonPoolLevelById && this.CurrentShowLevel == targetDragonPoolMaxLevelById))
			{
				int num = targetDragonPoolLevelById;
				this.ShowState = MingSuDefine.EMingSuShowState.OnGoing;
				if (instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2)
				{
					this.ShowState = MingSuDefine.EMingSuShowState.Done;
				}
				if (targetDragonPoolLevelById == targetDragonPoolMaxLevelById)
				{
					num--;
				}
				int targetDragonPoolLevelNeedCoreById = instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, num);
				int num2 = (instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2) ? targetDragonPoolLevelNeedCoreById : instance.GetTargetDragonPoolCoreCountById(this.PoolConfigId);
				float fillAmount = (float)num2 / (float)targetDragonPoolLevelNeedCoreById;
				this.ExpBarSprite.SetFillAmount(fillAmount);
				text.SetText(num2.ToString() + "/" + targetDragonPoolLevelNeedCoreById.ToString(), true);
				return;
			}
			if (this.CurrentShowLevel <= targetDragonPoolLevelById)
			{
				this.ShowState = MingSuDefine.EMingSuShowState.Done;
				int targetDragonPoolLevelNeedCoreById2 = instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1);
				text.SetText(targetDragonPoolLevelNeedCoreById2.ToString() + "/" + targetDragonPoolLevelNeedCoreById2.ToString(), true);
				this.ExpBarSprite.SetFillAmount(1f);
				return;
			}
			if (this.CurrentShowLevel > targetDragonPoolLevelById + 1)
			{
				this.ShowState = MingSuDefine.EMingSuShowState.NoStart;
				text.SetText("0/" + instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1).ToString(), true);
				this.ExpBarSprite.SetFillAmount(0f);
			}
		}

		// Token: 0x06036E40 RID: 224832 RVA: 0x00D01158 File Offset: 0x00CFF358
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = MingSuModel.Instance.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (this.RewardItemScrollView == null)
			{
				this.RewardItemScrollView = new GenericLayout<CollectSmallItemGrid, IRewardItemData>((UUILayoutBase)scrollViewWithScrollbar.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()), new Func<CollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			}
			this.RewardItemScrollView.RefreshByData(targetDragonPoolLevelRewardById, null, false);
		}

		// Token: 0x06036E41 RID: 224833 RVA: 0x00D011D0 File Offset: 0x00CFF3D0
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x06036E42 RID: 224834 RVA: 0x00D01210 File Offset: 0x00CFF410
		private void OnExtendToggleRelease(MediumItemGridExtendCallback callbackParameter)
		{
			if (!callbackParameter.MediumItemGrid.IsHover)
			{
				return;
			}
			IRewardItemData rewardItemData = callbackParameter.Data as IRewardItemData;
			if (((rewardItemData != null) ? rewardItemData.ItemInfo : null) != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(rewardItemData.ItemInfo.Id, true, null);
			}
		}

		// Token: 0x06036E43 RID: 224835 RVA: 0x00D0125C File Offset: 0x00CFF45C
		private void RefreshCostItem()
		{
			UUIText text = base.GetText(7);
			if (MingSuModel.Instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2)
			{
				this.ShowState = MingSuDefine.EMingSuShowState.Finish;
			}
			if (this.ShowState == MingSuDefine.EMingSuShowState.OnGoing)
			{
				text.SetUIActive(false);
				return;
			}
			if (this.ShowState == MingSuDefine.EMingSuShowState.Done)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
				return;
			}
			if (this.ShowState == MingSuDefine.EMingSuShowState.NoStart)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuNotDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
				return;
			}
			if (this.ShowState == MingSuDefine.EMingSuShowState.Finish)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
			}
		}

		// Token: 0x06036E44 RID: 224836 RVA: 0x00D0130C File Offset: 0x00CFF50C
		private void RefreshAddButton()
		{
			UUIText text = base.GetText(9);
			bool flag = MingSuModel.Instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2;
			base.GetItem(10).SetUIActive(!flag);
			if (!flag)
			{
				int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
				if (this.CurrentShowLevel == targetDragonPoolLevelById + 1)
				{
					LguiUtil.Instance.SetLocalText(text, "MingSuTi_Text3", Array.Empty<object>());
					return;
				}
				LguiUtil.Instance.SetLocalText(text, "MingSuTi_Text4", Array.Empty<object>());
			}
		}

		// Token: 0x06036E45 RID: 224837 RVA: 0x00D01394 File Offset: 0x00CFF594
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(40040001, 0);
			base.GetText(11).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x06036E46 RID: 224838 RVA: 0x00D013C8 File Offset: 0x00CFF5C8
		private void JumpLevel()
		{
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			if (targetDragonPoolLevelById == targetDragonPoolMaxLevelById)
			{
				this.CurrentShowLevel = targetDragonPoolLevelById;
			}
			else
			{
				this.CurrentShowLevel = targetDragonPoolLevelById + 1;
			}
			this.RefreshAll();
		}

		// Token: 0x06036E47 RID: 224839 RVA: 0x00D01413 File Offset: 0x00CFF613
		private void RefreshAll()
		{
			this.RefreshShowLevel(this.CurrentShowLevel);
			this.RefreshLeftRightBtnState();
			this.RefreshCoreData();
			this.RefreshReward();
			this.RefreshCostItem();
			this.RefreshAddButton();
			this.RefreshCountText();
		}

		// Token: 0x06036E48 RID: 224840 RVA: 0x00D01445 File Offset: 0x00CFF645
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpLevel();
		}

		// Token: 0x06036E49 RID: 224841 RVA: 0x00D0144D File Offset: 0x00CFF64D
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E4A RID: 224842 RVA: 0x00D01467 File Offset: 0x00CFF667
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E4B RID: 224843 RVA: 0x00D01481 File Offset: 0x00CFF681
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E4C RID: 224844 RVA: 0x00D014A2 File Offset: 0x00CFF6A2
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x06036E4D RID: 224845 RVA: 0x00D014AA File Offset: 0x00CFF6AA
		protected override void OnLevelMaxSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E4E RID: 224846 RVA: 0x00D014CB File Offset: 0x00CFF6CB
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E4F RID: 224847 RVA: 0x00D014EC File Offset: 0x00CFF6EC
		private void OnLeftMove()
		{
			this.CurrentShowLevel--;
			this.RefreshAll();
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "当前等级: " + this.CurrentShowLevel.ToString() + " left " + MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId).ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06036E50 RID: 224848 RVA: 0x00D01558 File Offset: 0x00CFF758
		private void OnRightMove()
		{
			this.CurrentShowLevel++;
			this.RefreshAll();
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "当前等级: " + this.CurrentShowLevel.ToString() + " right " + MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId).ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06036E51 RID: 224849 RVA: 0x00D015C4 File Offset: 0x00CFF7C4
		private void OnAddCore()
		{
			if (this.IsInLevelUpDisplay)
			{
				return;
			}
			MingSuModel instance = MingSuModel.Instance;
			int targetDragonPoolLevelById = instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			if (this.CurrentShowLevel != targetDragonPoolLevelById + 1)
			{
				this.JumpLevel();
				return;
			}
			if (instance.CheckUp(this.PoolConfigId))
			{
				instance.MingSuLastLevel = instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
				if (instance.CanLevelUp(this.PoolConfigId))
				{
					this.IsInLevelUpDisplay = true;
				}
				MingSuController.SendHandInMingSuRequest(this.PoolConfigId);
				Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "可以升级", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnSubmitItemFail);
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "不可升级!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06036E52 RID: 224850 RVA: 0x00D0168B File Offset: 0x00CFF88B
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(40040001, true, null);
		}

		// Token: 0x06036E53 RID: 224851 RVA: 0x00D0169E File Offset: 0x00CFF89E
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401CF66 RID: 118630
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x0401CF67 RID: 118631
		private MingSuDefine.EMingSuShowState ShowState;

		// Token: 0x0401CF68 RID: 118632
		private int? LoadSequenceHandleId;

		// Token: 0x0401CF69 RID: 118633
		[Nullable(2)]
		private UUISprite ExpBarSprite;

		// Token: 0x0401CF6A RID: 118634
		private bool IsInLevelUpDisplay;

		// Token: 0x0200B68A RID: 46730
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x040374D0 RID: 226512
			public const int LeftButton = 0;

			// Token: 0x040374D1 RID: 226513
			public const int RightButton = 1;

			// Token: 0x040374D2 RID: 226514
			public const int ExpBarSprite = 2;

			// Token: 0x040374D3 RID: 226515
			public const int LevelText = 3;

			// Token: 0x040374D4 RID: 226516
			public const int ExpText = 4;

			// Token: 0x040374D5 RID: 226517
			public const int RewardItemScrollbar = 5;

			// Token: 0x040374D6 RID: 226518
			public const int ContentItem = 6;

			// Token: 0x040374D7 RID: 226519
			public const int TipsText = 7;

			// Token: 0x040374D8 RID: 226520
			public const int ConfirmButton = 8;

			// Token: 0x040374D9 RID: 226521
			public const int ConfirmText = 9;

			// Token: 0x040374DA RID: 226522
			public const int ConfirmButtonItem = 10;

			// Token: 0x040374DB RID: 226523
			public const int CountText = 11;

			// Token: 0x040374DC RID: 226524
			public const int ItemButton = 12;

			// Token: 0x040374DD RID: 226525
			public const int CloseButton = 13;
		}
	}
}
