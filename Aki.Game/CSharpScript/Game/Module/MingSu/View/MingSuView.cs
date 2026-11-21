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
	// Token: 0x020043C3 RID: 17347
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuView : CollectItemViewBase
	{
		// Token: 0x0602BD7D RID: 179581 RVA: 0x00C4FD0C File Offset: 0x00C4DF0C
		public MingSuView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BD7E RID: 179582 RVA: 0x00C4FD18 File Offset: 0x00C4DF18
		protected override void OnRegisterComponent()
		{
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "创建鸣素体界面!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InitComponent();
		}

		// Token: 0x0602BD7F RID: 179583 RVA: 0x00C4FD47 File Offset: 0x00C4DF47
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

		// Token: 0x0602BD80 RID: 179584 RVA: 0x00C4FD84 File Offset: 0x00C4DF84
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequencePurely("Show", false, false);
		}

		// Token: 0x0602BD81 RID: 179585 RVA: 0x00C4FD98 File Offset: 0x00C4DF98
		protected override void OnEnded()
		{
			if (this.LoadSequenceHandleId != null)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadSequenceHandleId.Value);
				this.LoadSequenceHandleId = null;
			}
			this.ExpBarSprite = null;
		}

		// Token: 0x0602BD82 RID: 179586 RVA: 0x00C4FDD0 File Offset: 0x00C4DFD0
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

		// Token: 0x0602BD83 RID: 179587 RVA: 0x00C4FFA6 File Offset: 0x00C4E1A6
		private void InitView()
		{
			this.ExpBarSprite = base.GetSprite(2);
			this.RefreshAll();
		}

		// Token: 0x0602BD84 RID: 179588 RVA: 0x00C4FFBC File Offset: 0x00C4E1BC
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

		// Token: 0x0602BD85 RID: 179589 RVA: 0x00C5001C File Offset: 0x00C4E21C
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

		// Token: 0x0602BD86 RID: 179590 RVA: 0x00C500A0 File Offset: 0x00C4E2A0
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

		// Token: 0x0602BD87 RID: 179591 RVA: 0x00C50230 File Offset: 0x00C4E430
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

		// Token: 0x0602BD88 RID: 179592 RVA: 0x00C502A8 File Offset: 0x00C4E4A8
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x0602BD89 RID: 179593 RVA: 0x00C502E8 File Offset: 0x00C4E4E8
		private void OnExtendToggleRelease(MediumItemGridExtendCallback callbackParameter)
		{
			if (!callbackParameter.MediumItemGrid.IsHover)
			{
				return;
			}
			IRewardItemData rewardItemData = callbackParameter.Data as IRewardItemData;
			if (((rewardItemData != null) ? rewardItemData.ItemInfo : null) != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(rewardItemData.ItemInfo.Id, true, null, false);
			}
		}

		// Token: 0x0602BD8A RID: 179594 RVA: 0x00C50338 File Offset: 0x00C4E538
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

		// Token: 0x0602BD8B RID: 179595 RVA: 0x00C503E8 File Offset: 0x00C4E5E8
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

		// Token: 0x0602BD8C RID: 179596 RVA: 0x00C50470 File Offset: 0x00C4E670
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(40040001, 0);
			base.GetText(11).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0602BD8D RID: 179597 RVA: 0x00C504A4 File Offset: 0x00C4E6A4
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

		// Token: 0x0602BD8E RID: 179598 RVA: 0x00C504EF File Offset: 0x00C4E6EF
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

		// Token: 0x0602BD8F RID: 179599 RVA: 0x00C50521 File Offset: 0x00C4E721
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpLevel();
		}

		// Token: 0x0602BD90 RID: 179600 RVA: 0x00C50529 File Offset: 0x00C4E729
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x0602BD91 RID: 179601 RVA: 0x00C50543 File Offset: 0x00C4E743
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x0602BD92 RID: 179602 RVA: 0x00C5055D File Offset: 0x00C4E75D
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD93 RID: 179603 RVA: 0x00C5057E File Offset: 0x00C4E77E
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x0602BD94 RID: 179604 RVA: 0x00C50586 File Offset: 0x00C4E786
		protected override void OnLevelMaxSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD95 RID: 179605 RVA: 0x00C505A7 File Offset: 0x00C4E7A7
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD96 RID: 179606 RVA: 0x00C505C8 File Offset: 0x00C4E7C8
		private void OnLeftMove()
		{
			this.CurrentShowLevel--;
			this.RefreshAll();
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "当前等级: " + this.CurrentShowLevel.ToString() + " left " + MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId).ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602BD97 RID: 179607 RVA: 0x00C50634 File Offset: 0x00C4E834
		private void OnRightMove()
		{
			this.CurrentShowLevel++;
			this.RefreshAll();
			Log.Instance.Info(ELogModule.MingSuTi, ELogAuthor.BB, "当前等级: " + this.CurrentShowLevel.ToString() + " right " + MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId).ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602BD98 RID: 179608 RVA: 0x00C506A0 File Offset: 0x00C4E8A0
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

		// Token: 0x0602BD99 RID: 179609 RVA: 0x00C50767 File Offset: 0x00C4E967
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(40040001, true, null, false);
		}

		// Token: 0x0602BD9A RID: 179610 RVA: 0x00C5077B File Offset: 0x00C4E97B
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x040179FE RID: 96766
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x040179FF RID: 96767
		private MingSuDefine.EMingSuShowState ShowState;

		// Token: 0x04017A00 RID: 96768
		private int? LoadSequenceHandleId;

		// Token: 0x04017A01 RID: 96769
		[Nullable(2)]
		private UUISprite ExpBarSprite;

		// Token: 0x04017A02 RID: 96770
		private bool IsInLevelUpDisplay;

		// Token: 0x0200A0C2 RID: 41154
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x04031F25 RID: 204581
			public const int LeftButton = 0;

			// Token: 0x04031F26 RID: 204582
			public const int RightButton = 1;

			// Token: 0x04031F27 RID: 204583
			public const int ExpBarSprite = 2;

			// Token: 0x04031F28 RID: 204584
			public const int LevelText = 3;

			// Token: 0x04031F29 RID: 204585
			public const int ExpText = 4;

			// Token: 0x04031F2A RID: 204586
			public const int RewardItemScrollbar = 5;

			// Token: 0x04031F2B RID: 204587
			public const int ContentItem = 6;

			// Token: 0x04031F2C RID: 204588
			public const int TipsText = 7;

			// Token: 0x04031F2D RID: 204589
			public const int ConfirmButton = 8;

			// Token: 0x04031F2E RID: 204590
			public const int ConfirmText = 9;

			// Token: 0x04031F2F RID: 204591
			public const int ConfirmButtonItem = 10;

			// Token: 0x04031F30 RID: 204592
			public const int CountText = 11;

			// Token: 0x04031F31 RID: 204593
			public const int ItemButton = 12;

			// Token: 0x04031F32 RID: 204594
			public const int CloseButton = 13;
		}
	}
}
