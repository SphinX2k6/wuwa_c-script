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
	// Token: 0x020053D5 RID: 21461
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectItemView : CollectItemViewBase
	{
		// Token: 0x06036D96 RID: 224662 RVA: 0x00CFD45A File Offset: 0x00CFB65A
		public CollectItemView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036D97 RID: 224663 RVA: 0x00CFD464 File Offset: 0x00CFB664
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedLeftButton)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickedRightButton)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickedConfirmButton)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickedItemButton)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickedCloseButton))
			};
		}

		// Token: 0x06036D98 RID: 224664 RVA: 0x00CFD624 File Offset: 0x00CFB824
		protected override void OnBegined()
		{
			UUIItem item = base.GetItem(5);
			this.RewardItemScrollView = new GenericLayout<CollectSmallItemGrid, IRewardItemData>((UUILayoutBase)item.GetOwner().GetComponentByClass(UUILayoutBase.StaticClass()), new Func<CollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.ProgressBarSprite = base.GetSprite(2);
			this.Refresh();
		}

		// Token: 0x06036D99 RID: 224665 RVA: 0x00CFD680 File Offset: 0x00CFB880
		protected override void OnEnded()
		{
			this.RewardItemScrollView = null;
			this.ProgressBarSprite = null;
		}

		// Token: 0x06036D9A RID: 224666 RVA: 0x00CFD690 File Offset: 0x00CFB890
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpNextLevel();
		}

		// Token: 0x06036D9B RID: 224667 RVA: 0x00CFD698 File Offset: 0x00CFB898
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036D9C RID: 224668 RVA: 0x00CFD6B2 File Offset: 0x00CFB8B2
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036D9D RID: 224669 RVA: 0x00CFD6CC File Offset: 0x00CFB8CC
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036D9E RID: 224670 RVA: 0x00CFD6ED File Offset: 0x00CFB8ED
		protected override void OnLevelMaxSequenceFinished()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036D9F RID: 224671 RVA: 0x00CFD6F8 File Offset: 0x00CFB8F8
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当交付等级提升Sequence播放失败时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036DA0 RID: 224672 RVA: 0x00CFD743 File Offset: 0x00CFB943
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x06036DA1 RID: 224673 RVA: 0x00CFD74C File Offset: 0x00CFB94C
		protected override void OnCloseRewardView()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当关闭了交付奖励结算界面时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036DA2 RID: 224674 RVA: 0x00CFD797 File Offset: 0x00CFB997
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x06036DA3 RID: 224675 RVA: 0x00CFD7D8 File Offset: 0x00CFB9D8
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

		// Token: 0x06036DA4 RID: 224676 RVA: 0x00CFD824 File Offset: 0x00CFBA24
		private void OnClickedLeftButton()
		{
			this.CurrentShowLevel--;
			this.Refresh();
		}

		// Token: 0x06036DA5 RID: 224677 RVA: 0x00CFD83A File Offset: 0x00CFBA3A
		private void OnClickedRightButton()
		{
			this.CurrentShowLevel++;
			this.Refresh();
		}

		// Token: 0x06036DA6 RID: 224678 RVA: 0x00CFD850 File Offset: 0x00CFBA50
		private unsafe void OnClickedConfirmButton()
		{
			if (this.IsInLevelUpDisplay)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[CollectionItemDisplay]当点击交付按钮时，在播放等级提升动画，不做任何响应";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PoolConfigId", this.PoolConfigId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MingSuModel instance2 = MingSuModel.Instance;
			int targetDragonPoolLevelById = instance2.GetTargetDragonPoolLevelById(this.PoolConfigId);
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.NPC;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "[CollectionItemDisplay]当点击交付按钮时";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentShowLevel", this.CurrentShowLevel);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dragonPoolLevel", targetDragonPoolLevelById);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PoolConfigId", this.PoolConfigId);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.CurrentShowLevel != targetDragonPoolLevelById + 1)
			{
				this.JumpNextLevel();
				return;
			}
			if (instance2.CheckUp(this.PoolConfigId))
			{
				instance2.MingSuLastLevel = instance2.GetTargetDragonPoolLevelById(this.PoolConfigId);
				if (instance2.CanLevelUp(this.PoolConfigId))
				{
					Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]提交声匣之后，等级提升会播放等级提升Sequence，IsInLevelUpDisplay设置为true", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.IsInLevelUpDisplay = true;
				}
				Log instance4 = Log.Instance;
				ELogModule module3 = ELogModule.NPC;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "[CollectionItemDisplay]提交声匣之后，隐藏界面并发送给服务端";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PoolConfigId", this.PoolConfigId);
				instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				MingSuController.SendHandInMingSuRequest(this.PoolConfigId);
				return;
			}
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当点击交付按钮时,当前经验无法升级，不会播放提交道具表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.OnSubmitItemFail);
		}

		// Token: 0x06036DA7 RID: 224679 RVA: 0x00CFDA11 File Offset: 0x00CFBC11
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CollectItemConfigId, true, null);
		}

		// Token: 0x06036DA8 RID: 224680 RVA: 0x00CFDA25 File Offset: 0x00CFBC25
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036DA9 RID: 224681 RVA: 0x00CFDA30 File Offset: 0x00CFBC30
		private void JumpNextLevel()
		{
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			this.CurrentShowLevel = Math.Min(targetDragonPoolMaxLevelById, targetDragonPoolLevelById + 1);
			this.Refresh();
		}

		// Token: 0x06036DAA RID: 224682 RVA: 0x00CFDA74 File Offset: 0x00CFBC74
		private void Refresh()
		{
			this.RefreshShowLevel(this.CurrentShowLevel);
			this.RefreshLeftRightBtnState();
			this.RefreshProgressBar();
			this.RefreshReward();
			this.RefreshCostItem();
			this.RefreshConfirmButton();
			this.RefreshCountText();
		}

		// Token: 0x06036DAB RID: 224683 RVA: 0x00CFDAA8 File Offset: 0x00CFBCA8
		private void RefreshShowLevel(int level)
		{
			UUIText text = base.GetText(3);
			int num = Math.Min(MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId), level);
			LguiUtil.Instance.SetLocalTextNew(text, "MingSuLevelText", new <>z__ReadOnlySingleElementList<object>(num));
			this.CurrentShowLevel = num;
			MingSuModel.Instance.CurrentPreviewLevel = this.CurrentShowLevel;
		}

		// Token: 0x06036DAC RID: 224684 RVA: 0x00CFDB08 File Offset: 0x00CFBD08
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

		// Token: 0x06036DAD RID: 224685 RVA: 0x00CFDB8C File Offset: 0x00CFBD8C
		private void RefreshProgressBar()
		{
			MingSuModel instance = MingSuModel.Instance;
			int targetDragonPoolLevelById = instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			int targetDragonPoolMaxLevelById = instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			UUIText text = base.GetText(4);
			int targetDragonPoolActiveById = instance.GetTargetDragonPoolActiveById(this.PoolConfigId);
			if (this.CurrentShowLevel == targetDragonPoolLevelById + 1 || (this.CurrentShowLevel == targetDragonPoolLevelById && this.CurrentShowLevel == targetDragonPoolMaxLevelById))
			{
				int num = targetDragonPoolLevelById;
				this.CurrentShowState = MingSuDefine.EMingSuShowState.OnGoing;
				if (targetDragonPoolActiveById == 2)
				{
					this.CurrentShowState = MingSuDefine.EMingSuShowState.Done;
				}
				if (targetDragonPoolLevelById == targetDragonPoolMaxLevelById)
				{
					num--;
				}
				int targetDragonPoolLevelNeedCoreById = instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, num);
				int num2;
				if (targetDragonPoolActiveById == 2)
				{
					num2 = targetDragonPoolLevelNeedCoreById;
				}
				else
				{
					num2 = instance.GetTargetDragonPoolCoreCountById(this.PoolConfigId);
				}
				float fillAmount = (float)num2 / (float)targetDragonPoolLevelNeedCoreById;
				this.ProgressBarSprite.SetFillAmount(fillAmount);
				text.SetText(num2.ToString() + "/" + targetDragonPoolLevelNeedCoreById.ToString(), true);
				return;
			}
			if (this.CurrentShowLevel <= targetDragonPoolLevelById)
			{
				this.CurrentShowState = MingSuDefine.EMingSuShowState.Done;
				int targetDragonPoolLevelNeedCoreById2 = instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1);
				text.SetText(targetDragonPoolLevelNeedCoreById2.ToString() + "/" + targetDragonPoolLevelNeedCoreById2.ToString(), true);
				this.ProgressBarSprite.SetFillAmount(1f);
				return;
			}
			if (this.CurrentShowLevel > targetDragonPoolLevelById + 1)
			{
				this.CurrentShowState = MingSuDefine.EMingSuShowState.NoStart;
				text.SetText("0/" + instance.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1).ToString(), true);
				this.ProgressBarSprite.SetFillAmount(0f);
			}
		}

		// Token: 0x06036DAE RID: 224686 RVA: 0x00CFDD1C File Offset: 0x00CFBF1C
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = MingSuModel.Instance.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			this.RewardItemScrollView.RefreshByData((targetDragonPoolLevelRewardById != null) ? new List<IRewardItemData>(targetDragonPoolLevelRewardById) : new List<IRewardItemData>(), null, false);
		}

		// Token: 0x06036DAF RID: 224687 RVA: 0x00CFDD60 File Offset: 0x00CFBF60
		private void RefreshCostItem()
		{
			UUIText text = base.GetText(6);
			if (MingSuModel.Instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2)
			{
				this.CurrentShowState = MingSuDefine.EMingSuShowState.Finish;
			}
			if (this.CurrentShowState == MingSuDefine.EMingSuShowState.OnGoing)
			{
				text.SetUIActive(false);
				return;
			}
			if (this.CurrentShowState == MingSuDefine.EMingSuShowState.Done)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
				return;
			}
			if (this.CurrentShowState == MingSuDefine.EMingSuShowState.NoStart)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuNotDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
				return;
			}
			if (this.CurrentShowState == MingSuDefine.EMingSuShowState.Finish)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MingSuDoneTips", Array.Empty<object>());
				text.SetUIActive(true);
			}
		}

		// Token: 0x06036DB0 RID: 224688 RVA: 0x00CFDE10 File Offset: 0x00CFC010
		private void RefreshConfirmButton()
		{
			UUIText text = base.GetText(8);
			bool flag = MingSuModel.Instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2;
			base.GetItem(9).SetUIActive(!flag);
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

		// Token: 0x06036DB1 RID: 224689 RVA: 0x00CFDE94 File Offset: 0x00CFC094
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CollectItemConfigId, 0);
			base.GetText(10).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0401CF2F RID: 118575
		private MingSuDefine.EMingSuShowState CurrentShowState;

		// Token: 0x0401CF30 RID: 118576
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x0401CF31 RID: 118577
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x0401CF32 RID: 118578
		private bool IsInLevelUpDisplay;

		// Token: 0x0200B67A RID: 46714
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x04037460 RID: 226400
			public const int LeftButton = 0;

			// Token: 0x04037461 RID: 226401
			public const int RightButton = 1;

			// Token: 0x04037462 RID: 226402
			public const int ProgressBarSprite = 2;

			// Token: 0x04037463 RID: 226403
			public const int LevelText = 3;

			// Token: 0x04037464 RID: 226404
			public const int NeedCountText = 4;

			// Token: 0x04037465 RID: 226405
			public const int ContentItem = 5;

			// Token: 0x04037466 RID: 226406
			public const int TipsText = 6;

			// Token: 0x04037467 RID: 226407
			public const int ConfirmButton = 7;

			// Token: 0x04037468 RID: 226408
			public const int ConfirmButtonText = 8;

			// Token: 0x04037469 RID: 226409
			public const int ConfirmButtonItem = 9;

			// Token: 0x0403746A RID: 226410
			public const int ItemCountText = 10;

			// Token: 0x0403746B RID: 226411
			public const int ItemButton = 11;

			// Token: 0x0403746C RID: 226412
			public const int CloseButton = 12;
		}
	}
}
