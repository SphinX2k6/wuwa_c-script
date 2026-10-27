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
	// Token: 0x020053DF RID: 21471
	[NullableContext(1)]
	[Nullable(0)]
	public class MengZhouCollectView : CollectItemViewBase
	{
		// Token: 0x06036E19 RID: 224793 RVA: 0x00D00094 File Offset: 0x00CFE294
		public MengZhouCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036E1A RID: 224794 RVA: 0x00D000A0 File Offset: 0x00CFE2A0
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

		// Token: 0x06036E1B RID: 224795 RVA: 0x00D002BC File Offset: 0x00CFE4BC
		protected override void OnBegined()
		{
			UUIItem item = base.GetItem(5);
			this.RewardItemScrollView = new GenericLayout<CollectSmallItemGrid, IRewardItemData>((UUILayoutBase)item.GetOwner().GetComponentByClass(UUILayoutBase.StaticClass()), new Func<CollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.ProgressBarSprite = base.GetSprite(2);
			if (this.PoolConfigId == 8)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "NpcSystemBackground_10145_Title", Array.Empty<object>());
			}
			this.Refresh();
		}

		// Token: 0x06036E1C RID: 224796 RVA: 0x00D0033D File Offset: 0x00CFE53D
		protected override void OnEnded()
		{
			this.RewardItemScrollView = null;
			this.ProgressBarSprite = null;
			EventSystem.Instance.Emit(EEventName.OnExitNpcInteract);
		}

		// Token: 0x06036E1D RID: 224797 RVA: 0x00D0035D File Offset: 0x00CFE55D
		protected override void OnUpdateDragonPoolView()
		{
			this.JumpNextLevel();
		}

		// Token: 0x06036E1E RID: 224798 RVA: 0x00D00365 File Offset: 0x00CFE565
		protected override void OnSubmitItemLevelUp()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E1F RID: 224799 RVA: 0x00D0037F File Offset: 0x00CFE57F
		protected override void OnSubmitItemLevelMax()
		{
			this.SetActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06036E20 RID: 224800 RVA: 0x00D00399 File Offset: 0x00CFE599
		protected override void OnLevelUpSequenceFinished()
		{
			this.SetActive(true);
			this.IsInLevelUpDisplay = false;
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E21 RID: 224801 RVA: 0x00D003BA File Offset: 0x00CFE5BA
		protected override void OnLevelMaxSequenceFinished()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E22 RID: 224802 RVA: 0x00D003C4 File Offset: 0x00CFE5C4
		protected override void OnSubmitItemLevelUpSequencePlayFail()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当交付等级提升Sequence播放失败时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E23 RID: 224803 RVA: 0x00D0040F File Offset: 0x00CFE60F
		protected override void OnCollectItemCountChanged(int count)
		{
			this.RefreshCountText();
		}

		// Token: 0x06036E24 RID: 224804 RVA: 0x00D00418 File Offset: 0x00CFE618
		protected override void OnCloseRewardView()
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.BB, "[CollectionItemDisplay]当关闭了交付奖励结算界面时，重新显示提交道具界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInLevelUpDisplay = false;
			this.SetActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x06036E25 RID: 224805 RVA: 0x00D00463 File Offset: 0x00CFE663
		private CollectSmallItemGrid OnCreateRewardItem()
		{
			CollectSmallItemGrid collectSmallItemGrid = new CollectSmallItemGrid();
			collectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			collectSmallItemGrid.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			return collectSmallItemGrid;
		}

		// Token: 0x06036E26 RID: 224806 RVA: 0x00D004A4 File Offset: 0x00CFE6A4
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

		// Token: 0x06036E27 RID: 224807 RVA: 0x00D004F0 File Offset: 0x00CFE6F0
		private void OnClickedLeftButton()
		{
			this.CurrentShowLevel--;
			this.Refresh();
		}

		// Token: 0x06036E28 RID: 224808 RVA: 0x00D00506 File Offset: 0x00CFE706
		private void OnClickedRightButton()
		{
			this.CurrentShowLevel++;
			this.Refresh();
		}

		// Token: 0x06036E29 RID: 224809 RVA: 0x00D0051C File Offset: 0x00CFE71C
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

		// Token: 0x06036E2A RID: 224810 RVA: 0x00D006DD File Offset: 0x00CFE8DD
		private void OnClickedItemButton()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CollectItemConfigId, true, null);
		}

		// Token: 0x06036E2B RID: 224811 RVA: 0x00D006F1 File Offset: 0x00CFE8F1
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036E2C RID: 224812 RVA: 0x00D006FC File Offset: 0x00CFE8FC
		private void JumpNextLevel()
		{
			int targetDragonPoolMaxLevelById = MingSuModel.Instance.GetTargetDragonPoolMaxLevelById(this.PoolConfigId);
			int targetDragonPoolLevelById = MingSuModel.Instance.GetTargetDragonPoolLevelById(this.PoolConfigId);
			this.CurrentShowLevel = Math.Min(targetDragonPoolMaxLevelById, targetDragonPoolLevelById + 1);
			this.Refresh();
		}

		// Token: 0x06036E2D RID: 224813 RVA: 0x00D00740 File Offset: 0x00CFE940
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

		// Token: 0x06036E2E RID: 224814 RVA: 0x00D00778 File Offset: 0x00CFE978
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

		// Token: 0x06036E2F RID: 224815 RVA: 0x00D00808 File Offset: 0x00CFEA08
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

		// Token: 0x06036E30 RID: 224816 RVA: 0x00D0087C File Offset: 0x00CFEA7C
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

		// Token: 0x06036E31 RID: 224817 RVA: 0x00D00900 File Offset: 0x00CFEB00
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

		// Token: 0x06036E32 RID: 224818 RVA: 0x00D00A88 File Offset: 0x00CFEC88
		private void RefreshReward()
		{
			List<IRewardItemData> targetDragonPoolLevelRewardById = MingSuModel.Instance.GetTargetDragonPoolLevelRewardById(this.PoolConfigId, this.CurrentShowLevel - 1);
			this.RewardItemScrollView.RefreshByData(targetDragonPoolLevelRewardById, null, false);
		}

		// Token: 0x06036E33 RID: 224819 RVA: 0x00D00ABC File Offset: 0x00CFECBC
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

		// Token: 0x06036E34 RID: 224820 RVA: 0x00D00B6C File Offset: 0x00CFED6C
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

		// Token: 0x06036E35 RID: 224821 RVA: 0x00D00C00 File Offset: 0x00CFEE00
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CollectItemConfigId, 0);
			base.GetText(10).SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0401CF62 RID: 118626
		private MingSuDefine.EMingSuShowState CurrentShowState;

		// Token: 0x0401CF63 RID: 118627
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CollectSmallItemGrid, IRewardItemData> RewardItemScrollView;

		// Token: 0x0401CF64 RID: 118628
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x0401CF65 RID: 118629
		private bool IsInLevelUpDisplay;
	}
}
