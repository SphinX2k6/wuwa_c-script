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
	// Token: 0x0200569C RID: 22172
	public class RewardPopView : UiViewBase
	{
		// Token: 0x060386B8 RID: 231096 RVA: 0x00D64F9E File Offset: 0x00D6319E
		[NullableContext(1)]
		public RewardPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060386B9 RID: 231097 RVA: 0x00D64FA8 File Offset: 0x00D631A8
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

		// Token: 0x060386BA RID: 231098 RVA: 0x00D651C4 File Offset: 0x00D633C4
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

		// Token: 0x060386BB RID: 231099 RVA: 0x00D652AC File Offset: 0x00D634AC
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

		// Token: 0x060386BC RID: 231100 RVA: 0x00D652EB File Offset: 0x00D634EB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x060386BD RID: 231101 RVA: 0x00D65309 File Offset: 0x00D63509
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x060386BE RID: 231102 RVA: 0x00D65327 File Offset: 0x00D63527
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

		// Token: 0x060386BF RID: 231103 RVA: 0x00D65360 File Offset: 0x00D63560
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

		// Token: 0x060386C0 RID: 231104 RVA: 0x00D653D4 File Offset: 0x00D635D4
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

		// Token: 0x060386C1 RID: 231105 RVA: 0x00D654B0 File Offset: 0x00D636B0
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

		// Token: 0x060386C2 RID: 231106 RVA: 0x00D65584 File Offset: 0x00D63784
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

		// Token: 0x060386C3 RID: 231107 RVA: 0x00D65694 File Offset: 0x00D63894
		private void SetExpItem()
		{
			int? sumExpByLevel = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetCurrentRewardLevel().Value);
			int? currentRewardTotalProficiency = CommonManager.Instance.GetCurrentRewardTotalProficiency();
			this.ExpItem.SetExpSprite(currentRewardTotalProficiency.Value, sumExpByLevel.Value);
			this.ExpItem.SetAddText(CommonManager.Instance.GetCurrentRewardAddExp().Value);
			this.ExpItem.SetLastText(currentRewardTotalProficiency.Value);
			this.ExpItem.SetSumText(sumExpByLevel.Value);
		}

		// Token: 0x060386C4 RID: 231108 RVA: 0x00D65724 File Offset: 0x00D63924
		private void RefreshDoubleConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			bool flag = CommonManager.Instance.CheckCanFix();
			uuiinteractionGroup.SetInteractable(flag);
			(base.GetButton(9).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!flag);
		}

		// Token: 0x060386C5 RID: 231109 RVA: 0x00D65787 File Offset: 0x00D63987
		private void OnClose()
		{
			this.DoClose();
		}

		// Token: 0x060386C6 RID: 231110 RVA: 0x00D6578F File Offset: 0x00D6398F
		private void OnCancel()
		{
			this.DoClose();
		}

		// Token: 0x060386C7 RID: 231111 RVA: 0x00D65797 File Offset: 0x00D63997
		private void OnConfirm()
		{
			CommonManager.Instance.SendFixToolRequest();
			this.DoClose();
		}

		// Token: 0x060386C8 RID: 231112 RVA: 0x00D657A9 File Offset: 0x00D639A9
		private void OnSingleConfirm()
		{
			this.DoClose();
		}

		// Token: 0x060386C9 RID: 231113 RVA: 0x00D657B4 File Offset: 0x00D639B4
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

		// Token: 0x060386CA RID: 231114 RVA: 0x00D65818 File Offset: 0x00D63A18
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0401DA2A RID: 121386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RewardPopItem> RewardPopScroll;

		// Token: 0x0401DA2B RID: 121387
		[Nullable(2)]
		private ExpItem ExpItem;

		// Token: 0x0401DA2C RID: 121388
		private ERewardPopType Type;

		// Token: 0x0200B860 RID: 47200
		private class ERewardPopDefine
		{
			// Token: 0x04037CE2 RID: 228578
			public const int TitleText = 0;

			// Token: 0x04037CE3 RID: 228579
			public const int ItemScrollView = 1;

			// Token: 0x04037CE4 RID: 228580
			public const int InfoTextItem = 2;

			// Token: 0x04037CE5 RID: 228581
			public const int InfoText = 3;

			// Token: 0x04037CE6 RID: 228582
			public const int DoubleButtonItem = 4;

			// Token: 0x04037CE7 RID: 228583
			public const int CancelButton = 5;

			// Token: 0x04037CE8 RID: 228584
			public const int ConfirmButton = 6;

			// Token: 0x04037CE9 RID: 228585
			public const int ExpItem = 7;

			// Token: 0x04037CEA RID: 228586
			public const int SingleConfirmButton = 8;

			// Token: 0x04037CEB RID: 228587
			public const int DisableButton = 9;
		}
	}
}
