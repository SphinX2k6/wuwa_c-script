using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053E1 RID: 21473
	[NullableContext(1)]
	[Nullable(0)]
	public class PupuVillageCollectView : CollectItemViewBase
	{
		// Token: 0x06036E54 RID: 224852 RVA: 0x00D016A7 File Offset: 0x00CFF8A7
		public PupuVillageCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036E55 RID: 224853 RVA: 0x00D016B0 File Offset: 0x00CFF8B0
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
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUITexture)),
				new ValueTuple<int, Type>(15, typeof(UUITexture)),
				new ValueTuple<int, Type>(16, typeof(UUIText))
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

		// Token: 0x06036E56 RID: 224854 RVA: 0x00D018CC File Offset: 0x00CFFACC
		protected override void OnBegined()
		{
			UUIItem item = base.GetItem(5);
			this.RewardItemScrollView = new GenericLayout<CollectSmallItemGrid, IRewardItemData>((UUILayoutBase)item.GetOwner().GetComponentByClass(UUILayoutBase.StaticClass()), new Func<CollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.ProgressBarSprite = base.GetSprite(2);
			if (this.PoolConfigId == 5)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "NpcSystemBackground_1010_Title", Array.Empty<object>());
			}
			this.Refresh();
		}

		// Token: 0x06036E57 RID: 224855 RVA: 0x00D0194D File Offset: 0x00CFFB4D
		protected override void OnEnded()
		{
			this.RewardItemScrollView = null;
			this.ProgressBarSprite = null;
			EventSystem.Instance.Emit(EEventName.OnExitNpcInteract);
		}

		// Token: 0x06036E58 RID: 224856 RVA: 0x00D0196D File Offset: 0x00CFFB6D
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpNextLevel();
		}

		// Token: 0x06036E59 RID: 224857 RVA: 0x00D01975 File Offset: 0x00CFFB75
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E5A RID: 224858 RVA: 0x00D0198F File Offset: 0x00CFFB8F
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E5B RID: 224859 RVA: 0x00D019A9 File Offset: 0x00CFFBA9
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E5C RID: 224860 RVA: 0x00D019CA File Offset: 0x00CFFBCA
		protected override void OnLevelMaxSequenceFinished()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E5D RID: 224861 RVA: 0x00D019D4 File Offset: 0x00CFFBD4
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当交付等级提升Sequence播放失败时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E5E RID: 224862 RVA: 0x00D01A1F File Offset: 0x00CFFC1F
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x06036E5F RID: 224863 RVA: 0x00D01A28 File Offset: 0x00CFFC28
		protected override void OnCloseRewardView()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当关闭了交付奖励结算界面时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E60 RID: 224864 RVA: 0x00D01A73 File Offset: 0x00CFFC73
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x06036E61 RID: 224865 RVA: 0x00D01AB4 File Offset: 0x00CFFCB4
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

		// Token: 0x06036E62 RID: 224866 RVA: 0x00D01B00 File Offset: 0x00CFFD00
		private void OnClickedLeftButton()
		{
			this.CurrentShowLevel--;
			this.Refresh();
		}

		// Token: 0x06036E63 RID: 224867 RVA: 0x00D01B16 File Offset: 0x00CFFD16
		private void OnClickedRightButton()
		{
			this.CurrentShowLevel++;
			this.Refresh();
		}

		// Token: 0x06036E64 RID: 224868 RVA: 0x00D01B2C File Offset: 0x00CFFD2C
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

		// Token: 0x06036E65 RID: 224869 RVA: 0x00D01CED File Offset: 0x00CFFEED
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CollectItemConfigId, true, null);
		}

		// Token: 0x06036E66 RID: 224870 RVA: 0x00D01D01 File Offset: 0x00CFFF01
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E67 RID: 224871 RVA: 0x00D01D0C File Offset: 0x00CFFF0C
		private void JumpNextLevel()
		{
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			this.CurrentShowLevel = Math.Min(targetDragonPoolMaxLevelById, targetDragonPoolLevelById + 1);
			this.Refresh();
		}

		// Token: 0x06036E68 RID: 224872 RVA: 0x00D01D50 File Offset: 0x00CFFF50
		private void Refresh()
		{
			this.RefreshShowLevel(this.CurrentShowLevel);
			this.RefreshLeftRightBtnState();
			this.RefreshProgressBar();
			this.RefreshReward();
			this.RefreshCostItem();
			this.RefreshConfirmButton();
			this.RefreshCountText();
			this.RefreshItemIcon();
		}

		// Token: 0x06036E69 RID: 224873 RVA: 0x00D01D88 File Offset: 0x00CFFF88
		private void RefreshItemIcon()
		{
			UUITexture texture = base.GetTexture(14);
			UUITexture texture2 = base.GetTexture(15);
			DragonPool? dragonPoolConfigById = CollectItemConfig.Instance.GetDragonPoolConfigById(this.PoolConfigId);
			if (dragonPoolConfigById != null)
			{
				ItemInfo? config = ItemConfig.Instance.GetConfig(dragonPoolConfigById.Value.CoreId);
				if (config != null)
				{
					base.SetTextureShowUntilLoaded(config.Value.IconSmall, texture, null);
					base.SetTextureShowUntilLoaded(config.Value.IconSmall, texture2, null);
				}
			}
		}

		// Token: 0x06036E6A RID: 224874 RVA: 0x00D01E18 File Offset: 0x00D00018
		private void RefreshShowLevel(int level)
		{
			UUIText text = base.GetText(3);
			int num = Math.Min(MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId), level);
			LguiUtil.Instance.SetLocalTextNew(text, "PupuVillage_LevelText", new <>z__ReadOnlyArray<object>(new object[]
			{
				num - 1,
				num
			}));
			this.CurrentShowLevel = num;
			MingSuModel.Instance.CurrentPreviewLevel = this.CurrentShowLevel;
		}

		// Token: 0x06036E6B RID: 224875 RVA: 0x00D01E8C File Offset: 0x00D0008C
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

		// Token: 0x06036E6C RID: 224876 RVA: 0x00D01F10 File Offset: 0x00D00110
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
				int num2 = (targetDragonPoolActiveById == 2) ? targetDragonPoolLevelNeedCoreById : instance.GetTargetDragonPoolCoreCountById(this.PoolConfigId);
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

		// Token: 0x06036E6D RID: 224877 RVA: 0x00D02098 File Offset: 0x00D00298
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = MingSuModel.Instance.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			this.RewardItemScrollView.RefreshByData(targetDragonPoolLevelRewardById, null, false);
		}

		// Token: 0x06036E6E RID: 224878 RVA: 0x00D020CC File Offset: 0x00D002CC
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
				text.SetUIActive(false);
			}
		}

		// Token: 0x06036E6F RID: 224879 RVA: 0x00D0217C File Offset: 0x00D0037C
		private void RefreshConfirmButton()
		{
			UUIText text = base.GetText(8);
			bool flag = MingSuModel.Instance.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2;
			base.GetItem(9).SetUIActive(!flag);
			base.GetItem(13).SetUIActive(flag);
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

		// Token: 0x06036E70 RID: 224880 RVA: 0x00D02210 File Offset: 0x00D00410
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CollectItemConfigId, 0);
			base.GetText(10).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0401CF6B RID: 118635
		private MingSuDefine.EMingSuShowState CurrentShowState;

		// Token: 0x0401CF6C RID: 118636
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x0401CF6D RID: 118637
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x0401CF6E RID: 118638
		private bool IsInLevelUpDisplay;

		// Token: 0x0200B68C RID: 46732
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x040374E1 RID: 226529
			public const int LeftButton = 0;

			// Token: 0x040374E2 RID: 226530
			public const int RightButton = 1;

			// Token: 0x040374E3 RID: 226531
			public const int ProgressBarSprite = 2;

			// Token: 0x040374E4 RID: 226532
			public const int LevelText = 3;

			// Token: 0x040374E5 RID: 226533
			public const int NeedCountText = 4;

			// Token: 0x040374E6 RID: 226534
			public const int ContentItem = 5;

			// Token: 0x040374E7 RID: 226535
			public const int TipsText = 6;

			// Token: 0x040374E8 RID: 226536
			public const int ConfirmButton = 7;

			// Token: 0x040374E9 RID: 226537
			public const int ConfirmButtonText = 8;

			// Token: 0x040374EA RID: 226538
			public const int ConfirmButtonItem = 9;

			// Token: 0x040374EB RID: 226539
			public const int ItemCountText = 10;

			// Token: 0x040374EC RID: 226540
			public const int ItemButton = 11;

			// Token: 0x040374ED RID: 226541
			public const int CloseButton = 12;

			// Token: 0x040374EE RID: 226542
			public const int AllDoneItem = 13;

			// Token: 0x040374EF RID: 226543
			public const int TextureCostItemIcon = 14;

			// Token: 0x040374F0 RID: 226544
			public const int TextureCostItemIcon2 = 15;

			// Token: 0x040374F1 RID: 226545
			public const int TxtTitle = 16;
		}
	}
}
