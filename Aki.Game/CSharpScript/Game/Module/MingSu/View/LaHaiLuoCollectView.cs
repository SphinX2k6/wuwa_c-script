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
	// Token: 0x020053DD RID: 21469
	[NullableContext(1)]
	[Nullable(0)]
	public class LaHaiLuoCollectView : CollectItemViewBase
	{
		// Token: 0x06036DFB RID: 224763 RVA: 0x00CFF372 File Offset: 0x00CFD572
		public LaHaiLuoCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036DFC RID: 224764 RVA: 0x00CFF37C File Offset: 0x00CFD57C
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

		// Token: 0x06036DFD RID: 224765 RVA: 0x00CFF5F4 File Offset: 0x00CFD7F4
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

		// Token: 0x06036DFE RID: 224766 RVA: 0x00CFF74F File Offset: 0x00CFD94F
		protected override void OnEnded()
		{
			this.RewardItemScrollView = null;
			this.ProgressBarSprite = null;
			this.MingSuMod = null;
			EventSystem.Instance.Emit(EEventName.OnExitNpcInteract);
		}

		// Token: 0x06036DFF RID: 224767 RVA: 0x00CFF776 File Offset: 0x00CFD976
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpNextLevel();
		}

		// Token: 0x06036E00 RID: 224768 RVA: 0x00CFF77E File Offset: 0x00CFD97E
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E01 RID: 224769 RVA: 0x00CFF798 File Offset: 0x00CFD998
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E02 RID: 224770 RVA: 0x00CFF7B2 File Offset: 0x00CFD9B2
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E03 RID: 224771 RVA: 0x00CFF7D3 File Offset: 0x00CFD9D3
		protected override void OnLevelMaxSequenceFinished()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E04 RID: 224772 RVA: 0x00CFF7DC File Offset: 0x00CFD9DC
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当交付等级提升Sequence播放失败时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E05 RID: 224773 RVA: 0x00CFF827 File Offset: 0x00CFDA27
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x06036E06 RID: 224774 RVA: 0x00CFF830 File Offset: 0x00CFDA30
		protected override void OnCloseRewardView()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当关闭了交付奖励结算界面时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E07 RID: 224775 RVA: 0x00CFF87B File Offset: 0x00CFDA7B
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x06036E08 RID: 224776 RVA: 0x00CFF8BC File Offset: 0x00CFDABC
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

		// Token: 0x06036E09 RID: 224777 RVA: 0x00CFF908 File Offset: 0x00CFDB08
		private void OnClickedLeftButton()
		{
			this.CurrentShowLevel--;
			this.Refresh();
		}

		// Token: 0x06036E0A RID: 224778 RVA: 0x00CFF91E File Offset: 0x00CFDB1E
		private void OnClickedRightButton()
		{
			this.CurrentShowLevel++;
			this.Refresh();
		}

		// Token: 0x06036E0B RID: 224779 RVA: 0x00CFF934 File Offset: 0x00CFDB34
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

		// Token: 0x06036E0C RID: 224780 RVA: 0x00CFFB08 File Offset: 0x00CFDD08
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CollectItemConfigId, true, null);
		}

		// Token: 0x06036E0D RID: 224781 RVA: 0x00CFFB1C File Offset: 0x00CFDD1C
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E0E RID: 224782 RVA: 0x00CFFB28 File Offset: 0x00CFDD28
		private void JumpNextLevel()
		{
			int targetDragonPoolMaxLevelById = this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = this.MingSuMod.GetTargetDragonPoolLevelById(this.PoolConfigId);
			this.CurrentShowLevel = Math.Min(targetDragonPoolMaxLevelById, targetDragonPoolLevelById + 1);
			this.Refresh();
		}

		// Token: 0x06036E0F RID: 224783 RVA: 0x00CFFB6E File Offset: 0x00CFDD6E
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

		// Token: 0x06036E10 RID: 224784 RVA: 0x00CFFBA8 File Offset: 0x00CFDDA8
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

		// Token: 0x06036E11 RID: 224785 RVA: 0x00CFFC38 File Offset: 0x00CFDE38
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

		// Token: 0x06036E12 RID: 224786 RVA: 0x00CFFCAC File Offset: 0x00CFDEAC
		private void RefreshLeftRightBtnState()
		{
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			UUIItem uuiitem2 = base.GetButton(1).RootUIComp.Get();
			uuiitem.SetUIActive(this.CurrentShowLevel != 1);
			uuiitem2.SetUIActive(this.CurrentShowLevel != this.MingSuMod.GetTargetDragonPoolMaxLevelById(this.PoolConfigId));
		}

		// Token: 0x06036E13 RID: 224787 RVA: 0x00CFFD18 File Offset: 0x00CFDF18
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

		// Token: 0x06036E14 RID: 224788 RVA: 0x00CFFEBC File Offset: 0x00CFE0BC
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = this.MingSuMod.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			this.RewardItemScrollView.RefreshByData(targetDragonPoolLevelRewardById, null, false);
		}

		// Token: 0x06036E15 RID: 224789 RVA: 0x00CFFEF4 File Offset: 0x00CFE0F4
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

		// Token: 0x06036E16 RID: 224790 RVA: 0x00CFFFA8 File Offset: 0x00CFE1A8
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

		// Token: 0x06036E17 RID: 224791 RVA: 0x00D0003C File Offset: 0x00CFE23C
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CollectItemConfigId, 0);
			base.GetText(10).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0401CF4A RID: 118602
		private MingSuDefine.EMingSuShowState CurrentShowState;

		// Token: 0x0401CF4B RID: 118603
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x0401CF4C RID: 118604
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x0401CF4D RID: 118605
		private bool IsInLevelUpDisplay;

		// Token: 0x0401CF4E RID: 118606
		[Nullable(2)]
		private MingSuModel MingSuMod;

		// Token: 0x0401CF4F RID: 118607
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

		// Token: 0x0200B687 RID: 46727
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x040374B7 RID: 226487
			public const int LeftButton = 0;

			// Token: 0x040374B8 RID: 226488
			public const int RightButton = 1;

			// Token: 0x040374B9 RID: 226489
			public const int ProgressBarSprite = 2;

			// Token: 0x040374BA RID: 226490
			public const int LevelText = 3;

			// Token: 0x040374BB RID: 226491
			public const int NeedCountText = 4;

			// Token: 0x040374BC RID: 226492
			public const int ContentItem = 5;

			// Token: 0x040374BD RID: 226493
			public const int TipsText = 6;

			// Token: 0x040374BE RID: 226494
			public const int ConfirmButton = 7;

			// Token: 0x040374BF RID: 226495
			public const int ConfirmButtonText = 8;

			// Token: 0x040374C0 RID: 226496
			public const int ConfirmButtonItem = 9;

			// Token: 0x040374C1 RID: 226497
			public const int ItemCountText = 10;

			// Token: 0x040374C2 RID: 226498
			public const int ItemButton = 11;

			// Token: 0x040374C3 RID: 226499
			public const int CloseButton = 12;

			// Token: 0x040374C4 RID: 226500
			public const int AllDoneItem = 13;

			// Token: 0x040374C5 RID: 226501
			public const int TextureCostItemIcon = 14;

			// Token: 0x040374C6 RID: 226502
			public const int TextureCostItemIcon2 = 15;

			// Token: 0x040374C7 RID: 226503
			public const int TxtTitle = 16;

			// Token: 0x040374C8 RID: 226504
			public const int SprTitle = 17;

			// Token: 0x040374C9 RID: 226505
			public const int SprXXIcon = 18;

			// Token: 0x040374CA RID: 226506
			public const int ItemShengXiaBG = 19;

			// Token: 0x040374CB RID: 226507
			public const int ItemRiLingBg = 20;
		}
	}
}
