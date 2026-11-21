using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200508B RID: 20619
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingReinforcement : RoverlikeActionSubViewBase
	{
		// Token: 0x170064D8 RID: 25816
		// (get) Token: 0x060339B1 RID: 211377 RVA: 0x00E72014 File Offset: 0x00E70214
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectBlessing;
			}
		}

		// Token: 0x170064D9 RID: 25817
		// (get) Token: 0x060339B2 RID: 211378 RVA: 0x00E72017 File Offset: 0x00E70217
		public override string ResourceId
		{
			get
			{
				return "UiItem_RogueBlessingEnhance";
			}
		}

		// Token: 0x060339B3 RID: 211379 RVA: 0x00E72020 File Offset: 0x00E70220
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060339B4 RID: 211380 RVA: 0x00E7212C File Offset: 0x00E7032C
		protected override void OnStart()
		{
			this.BlessingCardLayout = new GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingCardItem>(this.CreateBlessingItem), null, false, true);
			this.ButtonRefresh = new ButtonItem(base.GetItem(3));
			this.ButtonRefresh.SetFunction(delegate(int _)
			{
				this.OnBtnRefreshClick();
			});
		}

		// Token: 0x060339B5 RID: 211381 RVA: 0x00E72183 File Offset: 0x00E70383
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x060339B6 RID: 211382 RVA: 0x00E7218C File Offset: 0x00E7038C
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x060339B7 RID: 211383 RVA: 0x00E721AA File Offset: 0x00E703AA
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x060339B8 RID: 211384 RVA: 0x00E721C8 File Offset: 0x00E703C8
		private void OnBtnConfirmClick()
		{
			base.TryInteractAction(delegate
			{
				if (this.SelectedEntryIndex < 0 || this.ChooseData == null)
				{
					return;
				}
				RoverlikeGainEntry roverlikeGainEntry = this.ChooseData.Entries[this.SelectedEntryIndex];
				if (roverlikeGainEntry == null)
				{
					return;
				}
				this.OpenBlessingEnhanceConfirmView(roverlikeGainEntry);
			});
		}

		// Token: 0x060339B9 RID: 211385 RVA: 0x00E721DD File Offset: 0x00E703DD
		private void OnBtnRefreshClick()
		{
			base.TryInteractAction(delegate
			{
				if (this.ChooseData == null)
				{
					return;
				}
				if (!this.ChooseData.CanRefresh())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_InsufficientFund", Array.Empty<object>());
					return;
				}
				RoverlikeController.Instance.RoverRogueRefreshGainRequest(this.ChooseData.BindId, null);
			});
		}

		// Token: 0x060339BA RID: 211386 RVA: 0x00E721F4 File Offset: 0x00E703F4
		private void OnBlessingItemSelect(IRoverlikeBlessingItemData data)
		{
			if (this.ChooseData == null)
			{
				return;
			}
			int num = this.ChooseData.Entries.FindIndex(delegate(RoverlikeGainEntry entry)
			{
				int incId = entry.IncId;
				int? incId2 = data.IncId;
				return incId == incId2.GetValueOrDefault() & incId2 != null;
			});
			if (num < 0 || num == this.SelectedEntryIndex)
			{
				return;
			}
			this.SelectedEntryIndex = num;
			this.RefreshBlessingSelection();
		}

		// Token: 0x060339BB RID: 211387 RVA: 0x00E72250 File Offset: 0x00E70450
		private void OpenBlessingEnhanceConfirmView(RoverlikeGainEntry curBless)
		{
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(curBless.ConfigId);
			RoverlikeBlessingReplaceParam param = new RoverlikeBlessingReplaceParam
			{
				CurBlessId = curBless.ConfigId,
				NewBlessId = ((blessConfig != null) ? blessConfig.GetValueOrDefault().NextBlessId : 0),
				Type = ERoverlikeBlessingReplaceType.Enhance,
				OnConfirm = delegate
				{
					RoverlikeController.Instance.RoverRogueChooseDataResultRequest(this.ChooseData.BindId, curBless.IncId, null);
				}
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeBlessingReplaceView, param, null);
		}

		// Token: 0x060339BC RID: 211388 RVA: 0x00E722E9 File Offset: 0x00E704E9
		private RoverlikeBlessingCardItem CreateBlessingItem()
		{
			RoverlikeBlessingCardItem roverlikeBlessingCardItem = new RoverlikeBlessingCardItem();
			roverlikeBlessingCardItem.BindOnItemSelect(new Action<IRoverlikeBlessingItemData>(this.OnBlessingItemSelect));
			return roverlikeBlessingCardItem;
		}

		// Token: 0x060339BD RID: 211389 RVA: 0x00E72302 File Offset: 0x00E70502
		private void RefreshBlessingLayout(List<IRoverlikeBlessingItemData> dataList)
		{
			this.BlessingCardLayout.RefreshByData(dataList, new Action(this.OnBlessingLayoutRefreshed), true);
		}

		// Token: 0x060339BE RID: 211390 RVA: 0x00E7231D File Offset: 0x00E7051D
		private void OnBlessingLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingReinforcement");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x060339BF RID: 211391 RVA: 0x00E7233E File Offset: 0x00E7053E
		private void RefreshBlessingSelection()
		{
			this.BlessingCardLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x060339C0 RID: 211392 RVA: 0x00E72360 File Offset: 0x00E70560
		private void RefreshSlotHighlight()
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			RoverlikeBattleTopPanel roverlikeBattleTopPanel = (actionSubViewManager != null) ? actionSubViewManager.GetActionTopPanel() : null;
			if (roverlikeBattleTopPanel == null)
			{
				return;
			}
			if (this.SelectedEntryIndex >= 0 && this.ChooseData != null)
			{
				RoverlikeGainEntry roverlikeGainEntry = this.ChooseData.Entries[this.SelectedEntryIndex];
				if (roverlikeGainEntry != null)
				{
					roverlikeBattleTopPanel.SetHighlightByBlessId(roverlikeGainEntry.ConfigId);
					return;
				}
			}
			roverlikeBattleTopPanel.ClearHighlight();
		}

		// Token: 0x060339C1 RID: 211393 RVA: 0x00E723C8 File Offset: 0x00E705C8
		private void RefreshButton()
		{
			base.GetButton(2).SetSelfInteractive(this.SelectedEntryIndex >= 0);
			bool flag = this.ChooseData.EnableRefresh();
			base.GetItem(3).SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			UUIText text = base.GetText(4);
			bool enableClick = this.ChooseData.HasRefreshTime();
			bool flag2 = this.ChooseData.HasRefreshCost();
			ButtonItem buttonRefresh = this.ButtonRefresh;
			if (buttonRefresh != null)
			{
				buttonRefresh.SetEnableClick(enableClick);
			}
			ButtonItem buttonRefresh2 = this.ButtonRefresh;
			if (buttonRefresh2 != null)
			{
				buttonRefresh2.SetLocalTextNew("RoverRogue_RefreshCount", new object[]
				{
					this.ChooseData.UseTime,
					this.ChooseData.MaxTime
				});
			}
			LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_RefreshCost", new <>z__ReadOnlySingleElementList<object>(this.ChooseData.RefreshCost));
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag2;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x060339C2 RID: 211394 RVA: 0x00E724BC File Offset: 0x00E706BC
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x060339C3 RID: 211395 RVA: 0x00E724F0 File Offset: 0x00E706F0
		public override void OnRefreshSubView()
		{
			int bindId = (int)this.OpenParam;
			RoverlikeActionData actionData = RoverlikeModel.Instance.ActionData;
			RoverlikeChooseData roverlikeChooseData = (actionData != null) ? actionData.GetChooseDataByBindId(bindId) : null;
			if (roverlikeChooseData == null || roverlikeChooseData.Entries.Count == 0)
			{
				return;
			}
			this.ChooseData = roverlikeChooseData;
			this.SelectedEntryIndex = -1;
			List<IRoverlikeBlessingItemData> list = new List<IRoverlikeBlessingItemData>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in this.ChooseData.Entries)
			{
				RoverlikeBlessingItemData item = new RoverlikeBlessingItemData
				{
					BlessId = roverlikeGainEntry.ConfigId,
					IncId = new int?(roverlikeGainEntry.IncId),
					IsUp = new bool?(true)
				};
				list.Add(item);
			}
			this.RefreshBlessingLayout(list);
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x0401B62D RID: 112173
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> BlessingCardLayout;

		// Token: 0x0401B62E RID: 112174
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x0401B62F RID: 112175
		[Nullable(2)]
		private ButtonItem ButtonRefresh;

		// Token: 0x0401B630 RID: 112176
		private int SelectedEntryIndex = -1;

		// Token: 0x0200AD4B RID: 44363
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358D9 RID: 219353
			public const int BlessingLayout = 0;

			// Token: 0x040358DA RID: 219354
			public const int ItemBlessing = 1;

			// Token: 0x040358DB RID: 219355
			public const int BtnConfirm = 2;

			// Token: 0x040358DC RID: 219356
			public const int BtnRefresh = 3;

			// Token: 0x040358DD RID: 219357
			public const int TxtRefreshCost = 4;
		}
	}
}
