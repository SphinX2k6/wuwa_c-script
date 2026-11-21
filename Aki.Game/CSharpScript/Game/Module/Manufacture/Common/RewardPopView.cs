using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004672 RID: 18034
	public class RewardPopView : UiViewBase
	{
		// Token: 0x0602D5B5 RID: 185781 RVA: 0x00CB30EE File Offset: 0x00CB12EE
		[NullableContext(1)]
		public RewardPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D5B6 RID: 185782 RVA: 0x00CB30F8 File Offset: 0x00CB12F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnCancel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnSingleConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnDisable));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D5B7 RID: 185783 RVA: 0x00CB3314 File Offset: 0x00CB1514
		protected override void OnStart()
		{
			RewardPopViewData rewardPopViewData = this.OpenParam as RewardPopViewData;
			if (rewardPopViewData == null)
			{
				return;
			}
			this.Type = rewardPopViewData.RewardPopType.Value;
			this.RewardPopScroll = new GenericScrollView<RewardPopItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RewardPopItem>(this.InitCommonPopItem), null);
			base.GetItem(2).SetUIActive(this.Type == ERewardPopType.Unlock || this.Type == ERewardPopType.StudyFail);
			base.GetItem(4).SetUIActive(this.Type == ERewardPopType.Unlock);
			bool flag = this.Type == ERewardPopType.Cook || CommonManager.Instance.CheckCanShowExpItem().GetValueOrDefault();
			base.GetItem(7).SetUIActive(flag);
			if (flag)
			{
				this.ExpItem = new ExpItem(base.GetItem(7));
			}
			(base.GetButton(8).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(this.Type > ERewardPopType.Unlock);
		}

		// Token: 0x0602D5B8 RID: 185784 RVA: 0x00CB33FC File Offset: 0x00CB15FC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<RewardPopItem> InitCommonPopItem(object data, UUIItem item, int index)
		{
			ICommonPopItemData commonPopItemData = data as ICommonPopItemData;
			if (commonPopItemData == null)
			{
				return null;
			}
			RewardPopItem rewardPopItem = new RewardPopItem(item);
			rewardPopItem.Update(commonPopItemData);
			return new LayoutItem<RewardPopItem>
			{
				Key = index,
				Value = rewardPopItem
			};
		}

		// Token: 0x0602D5B9 RID: 185785 RVA: 0x00CB343B File Offset: 0x00CB163B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0602D5BA RID: 185786 RVA: 0x00CB3459 File Offset: 0x00CB1659
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0602D5BB RID: 185787 RVA: 0x00CB3477 File Offset: 0x00CB1677
		protected override void OnBeforeDestroy()
		{
			if (this.RewardPopScroll != null)
			{
				this.RewardPopScroll.ClearChildren();
				this.RewardPopScroll = null;
			}
			if (this.ExpItem != null)
			{
				this.ExpItem.Destroy(null);
				this.ExpItem = null;
			}
		}

		// Token: 0x0602D5BC RID: 185788 RVA: 0x00CB34B0 File Offset: 0x00CB16B0
		protected override void OnAfterShow()
		{
			this.SetTitle();
			this.SetItemScroll();
			switch (this.Type)
			{
			case ERewardPopType.Unlock:
				this.SetInfoText();
				this.RefreshDoubleConfirmButton();
				return;
			case ERewardPopType.Cook:
				this.SetExpItem();
				return;
			case ERewardPopType.Machining:
			case ERewardPopType.Forging:
				break;
			case ERewardPopType.StudyFail:
				this.SetInfoText();
				return;
			case ERewardPopType.Compose:
				if (CommonManager.Instance.CheckCanShowExpItem().GetValueOrDefault())
				{
					this.SetExpItem();
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0602D5BD RID: 185789 RVA: 0x00CB3524 File Offset: 0x00CB1724
		private void SetTitle()
		{
			switch (this.Type)
			{
			case ERewardPopType.Unlock:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "UnlockTitle", Array.Empty<object>());
				return;
			case ERewardPopType.Cook:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
				return;
			case ERewardPopType.Machining:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
				return;
			case ERewardPopType.StudyFail:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "StudyFail", Array.Empty<object>());
				return;
			case ERewardPopType.Compose:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "ComposeSuccess", Array.Empty<object>());
				return;
			case ERewardPopType.Forging:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "ForgingSuccess", Array.Empty<object>());
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D5BE RID: 185790 RVA: 0x00CB3600 File Offset: 0x00CB1800
		private void SetItemScroll()
		{
			if (this.Type == ERewardPopType.Unlock)
			{
				List<ICommonPopItemData> list = new List<ICommonPopItemData>();
				CookFixTool cookFixToolById = CookConfig.Instance.GetCookFixToolById(CommonManager.Instance.GetCurrentFixId());
				for (int i = 0; i < cookFixToolById.ItemsLength; i++)
				{
					DicIntInt? dicIntInt = cookFixToolById.Items(i);
					if (dicIntInt != null)
					{
						int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(dicIntInt.Value.Key, 0);
						list.Add(new ICommonPopItemData
						{
							ItemId = dicIntInt.Value.Key,
							ItemNum = itemCountByConfigId
						});
					}
				}
				this.RewardPopScroll.RefreshByData<ICommonPopItemData>(list, null);
				return;
			}
			this.RewardPopScroll.RefreshByData<ICommonPopItemData>(CommonManager.Instance.GetCommonItemList(), null);
		}

		// Token: 0x0602D5BF RID: 185791 RVA: 0x00CB36D4 File Offset: 0x00CB18D4
		private void SetInfoText()
		{
			if (this.Type == ERewardPopType.Unlock)
			{
				CookFixTool cookFixToolById = CookConfig.Instance.GetCookFixToolById(CommonManager.Instance.GetCurrentFixId());
				string localText = CookConfig.Instance.GetLocalText(cookFixToolById.Description);
				int num = 0;
				string text = string.Empty;
				cookFixToolById.Items(0);
				for (int i = 0; i < cookFixToolById.ItemsLength; i++)
				{
					DicIntInt? dicIntInt = cookFixToolById.Items(i);
					if (dicIntInt != null)
					{
						num = dicIntInt.Value.Value;
						ItemInfo? config = ItemConfig.Instance.GetConfig(dicIntInt.Value.Key);
						text = CookConfig.Instance.GetLocalText(config.Value.Name);
					}
				}
				LguiUtil.Instance.SetLocalText(base.GetText(3), "FixText", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					text,
					localText
				}));
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(3), "MaciningStudyFail", Array.Empty<object>());
		}

		// Token: 0x0602D5C0 RID: 185792 RVA: 0x00CB37E4 File Offset: 0x00CB19E4
		private void SetExpItem()
		{
			int? sumExpByLevel = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetCurrentRewardLevel().Value);
			int? currentRewardTotalProficiency = CommonManager.Instance.GetCurrentRewardTotalProficiency();
			this.ExpItem.SetExpSprite(currentRewardTotalProficiency.Value, sumExpByLevel.Value);
			this.ExpItem.SetAddText(CommonManager.Instance.GetCurrentRewardAddExp().Value);
			this.ExpItem.SetLastText(currentRewardTotalProficiency.Value);
			this.ExpItem.SetSumText(sumExpByLevel.Value);
		}

		// Token: 0x0602D5C1 RID: 185793 RVA: 0x00CB3874 File Offset: 0x00CB1A74
		private void RefreshDoubleConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			bool flag = CommonManager.Instance.CheckCanFix();
			uuiinteractionGroup.SetInteractable(flag);
			(base.GetButton(9).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!flag);
		}

		// Token: 0x0602D5C2 RID: 185794 RVA: 0x00CB38D7 File Offset: 0x00CB1AD7
		private void OnClose()
		{
			this.DoClose();
		}

		// Token: 0x0602D5C3 RID: 185795 RVA: 0x00CB38DF File Offset: 0x00CB1ADF
		private void OnCancel()
		{
			this.DoClose();
		}

		// Token: 0x0602D5C4 RID: 185796 RVA: 0x00CB38E7 File Offset: 0x00CB1AE7
		private void OnConfirm()
		{
			CommonManager.Instance.SendFixToolRequest();
			this.DoClose();
		}

		// Token: 0x0602D5C5 RID: 185797 RVA: 0x00CB38F9 File Offset: 0x00CB1AF9
		private void OnSingleConfirm()
		{
			this.DoClose();
		}

		// Token: 0x0602D5C6 RID: 185798 RVA: 0x00CB3904 File Offset: 0x00CB1B04
		private void DoClose()
		{
			ERewardPopType type = this.Type;
			if (type == ERewardPopType.Unlock)
			{
				UiManager.Instance.CloseView(EUiViewName.CookPopFixView, null);
				return;
			}
			if (type == ERewardPopType.Compose)
			{
				UiManager.Instance.CloseView(EUiViewName.RewardPopView, null);
				return;
			}
			if (type != ERewardPopType.Forging)
			{
				UiManager.Instance.CloseView(EUiViewName.CookPopView, null);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.RewardPopView, null);
		}

		// Token: 0x0602D5C7 RID: 185799 RVA: 0x00CB3968 File Offset: 0x00CB1B68
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x040184B5 RID: 99509
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RewardPopItem> RewardPopScroll;

		// Token: 0x040184B6 RID: 99510
		[Nullable(2)]
		private ExpItem ExpItem;

		// Token: 0x040184B7 RID: 99511
		private ERewardPopType Type;

		// Token: 0x0200A288 RID: 41608
		private class ERewardPopDefine
		{
			// Token: 0x040326FF RID: 206591
			public const int TitleText = 0;

			// Token: 0x04032700 RID: 206592
			public const int ItemScrollView = 1;

			// Token: 0x04032701 RID: 206593
			public const int InfoTextItem = 2;

			// Token: 0x04032702 RID: 206594
			public const int InfoText = 3;

			// Token: 0x04032703 RID: 206595
			public const int DoubleButtonItem = 4;

			// Token: 0x04032704 RID: 206596
			public const int CancelButton = 5;

			// Token: 0x04032705 RID: 206597
			public const int ConfirmButton = 6;

			// Token: 0x04032706 RID: 206598
			public const int ExpItem = 7;

			// Token: 0x04032707 RID: 206599
			public const int SingleConfirmButton = 8;

			// Token: 0x04032708 RID: 206600
			public const int DisableButton = 9;
		}
	}
}
