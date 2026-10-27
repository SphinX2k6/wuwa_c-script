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
	// Token: 0x0200610D RID: 24845
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingReinforcement : RoverlikeActionSubViewBase
	{
		// Token: 0x17009176 RID: 37238
		// (get) Token: 0x0603ECEF RID: 257263 RVA: 0x00F2B200 File Offset: 0x00F29400
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectBlessing;
			}
		}

		// Token: 0x17009177 RID: 37239
		// (get) Token: 0x0603ECF0 RID: 257264 RVA: 0x00F2B203 File Offset: 0x00F29403
		public override string ResourceId
		{
			get
			{
				return "UiItem_RogueBlessingEnhance";
			}
		}

		// Token: 0x0603ECF1 RID: 257265 RVA: 0x00F2B20C File Offset: 0x00F2940C
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

		// Token: 0x0603ECF2 RID: 257266 RVA: 0x00F2B318 File Offset: 0x00F29518
		protected override void OnStart()
		{
			this.BlessingCardLayout = new GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingCardItem>(this.CreateBlessingItem), null, false, true);
			this.ButtonRefresh = new ButtonItem(base.GetItem(3));
			this.ButtonRefresh.SetFunction(delegate(int _)
			{
				this.OnBtnRefreshClick();
			});
		}

		// Token: 0x0603ECF3 RID: 257267 RVA: 0x00F2B36F File Offset: 0x00F2956F
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x0603ECF4 RID: 257268 RVA: 0x00F2B378 File Offset: 0x00F29578
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ECF5 RID: 257269 RVA: 0x00F2B396 File Offset: 0x00F29596
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ECF6 RID: 257270 RVA: 0x00F2B3B4 File Offset: 0x00F295B4
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

		// Token: 0x0603ECF7 RID: 257271 RVA: 0x00F2B3C9 File Offset: 0x00F295C9
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

		// Token: 0x0603ECF8 RID: 257272 RVA: 0x00F2B3E0 File Offset: 0x00F295E0
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

		// Token: 0x0603ECF9 RID: 257273 RVA: 0x00F2B43C File Offset: 0x00F2963C
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

		// Token: 0x0603ECFA RID: 257274 RVA: 0x00F2B4D5 File Offset: 0x00F296D5
		private RoverlikeBlessingCardItem CreateBlessingItem()
		{
			RoverlikeBlessingCardItem roverlikeBlessingCardItem = new RoverlikeBlessingCardItem();
			roverlikeBlessingCardItem.BindOnItemSelect(new Action<IRoverlikeBlessingItemData>(this.OnBlessingItemSelect));
			return roverlikeBlessingCardItem;
		}

		// Token: 0x0603ECFB RID: 257275 RVA: 0x00F2B4EE File Offset: 0x00F296EE
		private void RefreshBlessingLayout(List<IRoverlikeBlessingItemData> dataList)
		{
			this.BlessingCardLayout.RefreshByData(dataList, new Action(this.OnBlessingLayoutRefreshed), true);
		}

		// Token: 0x0603ECFC RID: 257276 RVA: 0x00F2B509 File Offset: 0x00F29709
		private void OnBlessingLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingReinforcement");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x0603ECFD RID: 257277 RVA: 0x00F2B52A File Offset: 0x00F2972A
		private void RefreshBlessingSelection()
		{
			this.BlessingCardLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x0603ECFE RID: 257278 RVA: 0x00F2B54C File Offset: 0x00F2974C
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

		// Token: 0x0603ECFF RID: 257279 RVA: 0x00F2B5B4 File Offset: 0x00F297B4
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

		// Token: 0x0603ED00 RID: 257280 RVA: 0x00F2B6A8 File Offset: 0x00F298A8
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x0603ED01 RID: 257281 RVA: 0x00F2B6DC File Offset: 0x00F298DC
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

		// Token: 0x04020D00 RID: 134400
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> BlessingCardLayout;

		// Token: 0x04020D01 RID: 134401
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x04020D02 RID: 134402
		[Nullable(2)]
		private ButtonItem ButtonRefresh;

		// Token: 0x04020D03 RID: 134403
		private int SelectedEntryIndex = -1;

		// Token: 0x0200C363 RID: 50019
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF74 RID: 241524
			public const int BlessingLayout = 0;

			// Token: 0x0403AF75 RID: 241525
			public const int ItemBlessing = 1;

			// Token: 0x0403AF76 RID: 241526
			public const int BtnConfirm = 2;

			// Token: 0x0403AF77 RID: 241527
			public const int BtnRefresh = 3;

			// Token: 0x0403AF78 RID: 241528
			public const int TxtRefreshCost = 4;
		}
	}
}
