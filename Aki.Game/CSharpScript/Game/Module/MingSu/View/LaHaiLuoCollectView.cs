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
	// Token: 0x020043C0 RID: 17344
	[NullableContext(1)]
	[Nullable(0)]
	public class LaHaiLuoCollectView : CollectItemViewBase
	{
		// Token: 0x0602BD42 RID: 179522 RVA: 0x00C4E442 File Offset: 0x00C4C642
		public LaHaiLuoCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BD43 RID: 179523 RVA: 0x00C4E44C File Offset: 0x00C4C64C
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
				new ValueTuple<int, Type>(16, typeof(UUIText)),
				new ValueTuple<int, Type>(17, typeof(UUISprite)),
				new ValueTuple<int, Type>(18, typeof(UUISprite)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem))
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

		// Token: 0x0602BD44 RID: 179524 RVA: 0x00C4E6C4 File Offset: 0x00C4C8C4
		protected override void OnBegined()
		{
			UUIItem item = base.GetItem(5);
			this.RewardItemScrollView = new GenericLayout<CollectSmallItemGrid, IRewardItemData>((UUILayoutBase)item.GetOwner().GetComponentByClass(UUILayoutBase.StaticClass()), new Func<CollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.ProgressBarSprite = base.GetSprite(2);
			this.MingSuMod = MingSuModel.Instance;
			UUIText text = base.GetText(16);
			string textStringId;
			if (LaHaiLuoCollectView.TitleMap.TryGetValue(this.PoolConfigId, out textStringId))
			{
				LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
			}
			base.GetItem(19).SetUIActive(this.PoolConfigId == 6);
			base.GetItem(20).SetUIActive(this.PoolConfigId == 7);
			string path = "";
			string path2 = "";
			if (this.PoolConfigId == 6)
			{
				path = UiResourceConfig.Instance.GetResourcePath("ShengXiaIcon");
				path2 = UiResourceConfig.Instance.GetResourcePath("ShengXiaIcon2");
			}
			else if (this.PoolConfigId == 7)
			{
				path = UiResourceConfig.Instance.GetResourcePath("RiLingIcon");
				path2 = UiResourceConfig.Instance.GetResourcePath("RiLingIcon2");
			}
			this.SetSpriteByPath(path, base.GetSprite(17), false, null, null);
			this.SetSpriteByPath(path2, base.GetSprite(18), false, null, null);
			this.Refresh();
		}

		// Token: 0x0602BD45 RID: 179525 RVA: 0x00C4E81F File Offset: 0x00C4CA1F
		protected override void OnEnded()
		{
			this.RewardItemScrollView = null;
			this.ProgressBarSprite = null;
			this.MingSuMod = null;
			EventSystem.Instance.Emit(EEventName.OnExitNpcInteract);
		}

		// Token: 0x0602BD46 RID: 179526 RVA: 0x00C4E846 File Offset: 0x00C4CA46
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpNextLevel();
		}

		// Token: 0x0602BD47 RID: 179527 RVA: 0x00C4E84E File Offset: 0x00C4CA4E
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x0602BD48 RID: 179528 RVA: 0x00C4E868 File Offset: 0x00C4CA68
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x0602BD49 RID: 179529 RVA: 0x00C4E882 File Offset: 0x00C4CA82
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD4A RID: 179530 RVA: 0x00C4E8A3 File Offset: 0x00C4CAA3
		protected override void OnLevelMaxSequenceFinished()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BD4B RID: 179531 RVA: 0x00C4E8AC File Offset: 0x00C4CAAC
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当交付等级提升Sequence播放失败时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD4C RID: 179532 RVA: 0x00C4E8F7 File Offset: 0x00C4CAF7
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x0602BD4D RID: 179533 RVA: 0x00C4E900 File Offset: 0x00C4CB00
		protected override void OnCloseRewardView()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当关闭了交付奖励结算界面时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602BD4E RID: 179534 RVA: 0x00C4E94B File Offset: 0x00C4CB4B
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x0602BD4F RID: 179535 RVA: 0x00C4E98C File Offset: 0x00C4CB8C
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

		// Token: 0x0602BD50 RID: 179536 RVA: 0x00C4E9D9 File Offset: 0x00C4CBD9
		private void OnClickedLeftButton()
		{
			this.CurrentShowLevel--;
			this.Refresh();
		}

		// Token: 0x0602BD51 RID: 179537 RVA: 0x00C4E9EF File Offset: 0x00C4CBEF
		private void OnClickedRightButton()
		{
			this.CurrentShowLevel++;
			this.Refresh();
		}

		// Token: 0x0602BD52 RID: 179538 RVA: 0x00C4EA08 File Offset: 0x00C4CC08
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
			int targetDragonPoolLevelById = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.NPC;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "[CollectionItemDisplay]当点击交付按钮时";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentShowLevel", this.CurrentShowLevel);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dragonPoolLevel", targetDragonPoolLevelById);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PoolConfigId", this.PoolConfigId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.CurrentShowLevel != targetDragonPoolLevelById + 1)
			{
				this.JumpNextLevel();
				return;
			}
			if (this.MingSuMod.CheckUp(this.PoolConfigId))
			{
				this.MingSuMod.MingSuLastLevel = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
				if (this.MingSuMod.CanLevelUp(this.PoolConfigId))
				{
					Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]提交声匣之后，等级提升会播放等级提升Sequence，IsInLevelUpDisplay设置为true", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.IsInLevelUpDisplay = true;
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.NPC;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "[CollectionItemDisplay]提交声匣之后，隐藏界面并发送给服务端";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PoolConfigId", this.PoolConfigId);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				MingSuController.SendHandInMingSuRequest(this.PoolConfigId);
				return;
			}
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当点击交付按钮时,当前经验无法升级，不会播放提交道具表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.OnSubmitItemFail);
		}

		// Token: 0x0602BD53 RID: 179539 RVA: 0x00C4EBDC File Offset: 0x00C4CDDC
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CollectItemConfigId, true, null, false);
		}

		// Token: 0x0602BD54 RID: 179540 RVA: 0x00C4EBF1 File Offset: 0x00C4CDF1
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BD55 RID: 179541 RVA: 0x00C4EBFC File Offset: 0x00C4CDFC
		private void JumpNextLevel()
		{
			int targetDragonPoolMaxLevelById = this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
			this.CurrentShowLevel = Math.Min(targetDragonPoolMaxLevelById, targetDragonPoolLevelById + 1);
			this.Refresh();
		}

		// Token: 0x0602BD56 RID: 179542 RVA: 0x00C4EC42 File Offset: 0x00C4CE42
		private void Refresh()
		{
			this.RefreshShowLevel(this.CurrentShowLevel);
			this.RefreshLeftRightBtnState();
			this.RefreshProgressBar();
			this.RefreshReward();
			this.RefreshTipsText();
			this.RefreshConfirmButton();
			this.RefreshCountText();
			this.RefreshItemIcon();
		}

		// Token: 0x0602BD57 RID: 179543 RVA: 0x00C4EC7C File Offset: 0x00C4CE7C
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

		// Token: 0x0602BD58 RID: 179544 RVA: 0x00C4ED0C File Offset: 0x00C4CF0C
		private void RefreshShowLevel(int level)
		{
			UUIText text = base.GetText(3);
			int num = Math.Min(this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId), level);
			LguiUtil.Instance.SetLocalTextNew(text, "PupuVillage_LevelText", new <>z__ReadOnlyArray<object>(new object[]
			{
				num - 1,
				num
			}));
			this.CurrentShowLevel = num;
			MingSuModel.Instance.CurrentPreviewLevel = this.CurrentShowLevel;
		}

		// Token: 0x0602BD59 RID: 179545 RVA: 0x00C4ED80 File Offset: 0x00C4CF80
		private void RefreshLeftRightBtnState()
		{
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			UUIItem uuiitem2 = base.GetButton(1).RootUIComp.Get();
			uuiitem.SetUIActive(this.CurrentShowLevel != 1);
			uuiitem2.SetUIActive(this.CurrentShowLevel != this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId));
		}

		// Token: 0x0602BD5A RID: 179546 RVA: 0x00C4EDEC File Offset: 0x00C4CFEC
		private void RefreshProgressBar()
		{
			int targetDragonPoolLevelById = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
			int targetDragonPoolMaxLevelById = this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			UUIText text = base.GetText(4);
			int targetDragonPoolActiveById = this.MingSuMod.GetTargetDragonPoolActiveById(this.PoolConfigId);
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
				int targetDragonPoolLevelNeedCoreById = this.MingSuMod.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, num);
				int num2 = (targetDragonPoolActiveById == 2) ? targetDragonPoolLevelNeedCoreById : this.MingSuMod.GetTargetDragonPoolCoreCountById(this.PoolConfigId);
				float fillAmount = (float)num2 / (float)targetDragonPoolLevelNeedCoreById;
				this.ProgressBarSprite.SetFillAmount(fillAmount);
				text.SetText(num2.ToString() + "/" + targetDragonPoolLevelNeedCoreById.ToString(), true);
				return;
			}
			if (this.CurrentShowLevel <= targetDragonPoolLevelById)
			{
				this.CurrentShowState = MingSuDefine.EMingSuShowState.Done;
				int targetDragonPoolLevelNeedCoreById2 = this.MingSuMod.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1);
				text.SetText(targetDragonPoolLevelNeedCoreById2.ToString() + "/" + targetDragonPoolLevelNeedCoreById2.ToString(), true);
				this.ProgressBarSprite.SetFillAmount(1f);
				return;
			}
			if (this.CurrentShowLevel > targetDragonPoolLevelById + 1)
			{
				this.CurrentShowState = MingSuDefine.EMingSuShowState.NoStart;
				text.SetText("0/" + this.MingSuMod.GetTargetDragonPoolLevelNeedCoreById(this.PoolConfigId, this.CurrentShowLevel - 1).ToString(), true);
				this.ProgressBarSprite.SetFillAmount(0f);
			}
		}

		// Token: 0x0602BD5B RID: 179547 RVA: 0x00C4EF90 File Offset: 0x00C4D190
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = this.MingSuMod.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			this.RewardItemScrollView.RefreshByData(targetDragonPoolLevelRewardById, null, false);
		}

		// Token: 0x0602BD5C RID: 179548 RVA: 0x00C4EFC8 File Offset: 0x00C4D1C8
		private void RefreshTipsText()
		{
			UUIText text = base.GetText(6);
			if (this.MingSuMod.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2)
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

		// Token: 0x0602BD5D RID: 179549 RVA: 0x00C4F07C File Offset: 0x00C4D27C
		private void RefreshConfirmButton()
		{
			UUIText text = base.GetText(8);
			bool flag = this.MingSuMod.GetTargetDragonPoolActiveById(this.PoolConfigId) == 2;
			base.GetItem(9).SetUIActive(!flag);
			base.GetItem(13).SetUIActive(flag);
			if (!flag)
			{
				int targetDragonPoolLevelById = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
				if (this.CurrentShowLevel == targetDragonPoolLevelById + 1)
				{
					LguiUtil.Instance.SetLocalText(text, "MingSuTi_Text3", Array.Empty<object>());
					return;
				}
				LguiUtil.Instance.SetLocalText(text, "MingSuTi_Text4", Array.Empty<object>());
			}
		}

		// Token: 0x0602BD5E RID: 179550 RVA: 0x00C4F110 File Offset: 0x00C4D310
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CollectItemConfigId, 0);
			base.GetText(10).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x040179E2 RID: 96738
		private MingSuDefine.EMingSuShowState CurrentShowState;

		// Token: 0x040179E3 RID: 96739
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x040179E4 RID: 96740
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x040179E5 RID: 96741
		private bool IsInLevelUpDisplay;

		// Token: 0x040179E6 RID: 96742
		[Nullable(2)]
		private MingSuModel MingSuMod;

		// Token: 0x040179E7 RID: 96743
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string> TitleMap = new Dictionary<int, string>
		{
			{
				6,
				"NpcSystemBackground_10132_Title"
			},
			{
				7,
				"NpcSystemBackground_10133_Title"
			}
		};

		// Token: 0x0200A0BF RID: 41151
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x04031F0C RID: 204556
			public const int LeftButton = 0;

			// Token: 0x04031F0D RID: 204557
			public const int RightButton = 1;

			// Token: 0x04031F0E RID: 204558
			public const int ProgressBarSprite = 2;

			// Token: 0x04031F0F RID: 204559
			public const int LevelText = 3;

			// Token: 0x04031F10 RID: 204560
			public const int NeedCountText = 4;

			// Token: 0x04031F11 RID: 204561
			public const int ContentItem = 5;

			// Token: 0x04031F12 RID: 204562
			public const int TipsText = 6;

			// Token: 0x04031F13 RID: 204563
			public const int ConfirmButton = 7;

			// Token: 0x04031F14 RID: 204564
			public const int ConfirmButtonText = 8;

			// Token: 0x04031F15 RID: 204565
			public const int ConfirmButtonItem = 9;

			// Token: 0x04031F16 RID: 204566
			public const int ItemCountText = 10;

			// Token: 0x04031F17 RID: 204567
			public const int ItemButton = 11;

			// Token: 0x04031F18 RID: 204568
			public const int CloseButton = 12;

			// Token: 0x04031F19 RID: 204569
			public const int AllDoneItem = 13;

			// Token: 0x04031F1A RID: 204570
			public const int TextureCostItemIcon = 14;

			// Token: 0x04031F1B RID: 204571
			public const int TextureCostItemIcon2 = 15;

			// Token: 0x04031F1C RID: 204572
			public const int TxtTitle = 16;

			// Token: 0x04031F1D RID: 204573
			public const int SprTitle = 17;

			// Token: 0x04031F1E RID: 204574
			public const int SprXXIcon = 18;

			// Token: 0x04031F1F RID: 204575
			public const int ItemShengXiaBG = 19;

			// Token: 0x04031F20 RID: 204576
			public const int ItemRiLingBg = 20;
		}
	}
}
