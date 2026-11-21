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
	// Token: 0x0200508F RID: 20623
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewSelectBlessing : RoverlikeActionSubViewBase
	{
		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x060339F9 RID: 211449 RVA: 0x00E731BE File Offset: 0x00E713BE
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectBlessing;
			}
		}

		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x060339FA RID: 211450 RVA: 0x00E731C1 File Offset: 0x00E713C1
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSelect";
			}
		}

		// Token: 0x060339FB RID: 211451 RVA: 0x00E731C8 File Offset: 0x00E713C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060339FC RID: 211452 RVA: 0x00E73314 File Offset: 0x00E71514
		protected override void OnStart()
		{
			this.BlessingCardLayout = new GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingCardItem>(this.CreateBlessingItem), null, false, true);
			this.ButtonRefresh = new ButtonItem(base.GetItem(3));
			this.ButtonRefresh.SetFunction(delegate(int _)
			{
				this.OnBtnRefreshClick();
			});
		}

		// Token: 0x060339FD RID: 211453 RVA: 0x00E7336B File Offset: 0x00E7156B
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x060339FE RID: 211454 RVA: 0x00E73374 File Offset: 0x00E71574
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x060339FF RID: 211455 RVA: 0x00E73392 File Offset: 0x00E71592
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x06033A00 RID: 211456 RVA: 0x00E733B0 File Offset: 0x00E715B0
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
				RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
				RoverlikeGainEntry roverlikeGainEntry2 = (instanceData != null) ? instanceData.GetSameSlotIdBless(roverlikeGainEntry.ConfigId) : null;
				if (roverlikeGainEntry2 != null)
				{
					this.OpenBlessingReplaceView(roverlikeGainEntry2.ConfigId, roverlikeGainEntry);
					return;
				}
				RoverlikeController.Instance.RoverRogueChooseDataResultRequest(this.ChooseData.BindId, roverlikeGainEntry.IncId, null);
			});
		}

		// Token: 0x06033A01 RID: 211457 RVA: 0x00E733C5 File Offset: 0x00E715C5
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

		// Token: 0x06033A02 RID: 211458 RVA: 0x00E733DC File Offset: 0x00E715DC
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

		// Token: 0x06033A03 RID: 211459 RVA: 0x00E73438 File Offset: 0x00E71638
		private void OpenBlessingReplaceView(int curBlessConfigId, RoverlikeGainEntry newEntry)
		{
			RoverlikeBlessingReplaceParam param = new RoverlikeBlessingReplaceParam
			{
				CurBlessId = curBlessConfigId,
				NewBlessId = newEntry.ConfigId,
				Type = ERoverlikeBlessingReplaceType.Replace,
				OnConfirm = delegate
				{
					RoverlikeController.Instance.RoverRogueChooseDataResultRequest(this.ChooseData.BindId, newEntry.IncId, null);
				}
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeBlessingReplaceView, param, null);
		}

		// Token: 0x06033A04 RID: 211460 RVA: 0x00E734A1 File Offset: 0x00E716A1
		private RoverlikeBlessingCardItem CreateBlessingItem()
		{
			RoverlikeBlessingCardItem roverlikeBlessingCardItem = new RoverlikeBlessingCardItem();
			roverlikeBlessingCardItem.BindOnItemSelect(new Action<IRoverlikeBlessingItemData>(this.OnBlessingItemSelect));
			return roverlikeBlessingCardItem;
		}

		// Token: 0x06033A05 RID: 211461 RVA: 0x00E734BA File Offset: 0x00E716BA
		private void RefreshBlessingLayout(List<IRoverlikeBlessingItemData> dataList)
		{
			this.BlessingCardLayout.RefreshByData(dataList, new Action(this.OnBlessingLayoutRefreshed), true);
		}

		// Token: 0x06033A06 RID: 211462 RVA: 0x00E734D5 File Offset: 0x00E716D5
		private void OnBlessingLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeSelectBlessing");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x06033A07 RID: 211463 RVA: 0x00E734F6 File Offset: 0x00E716F6
		private void RefreshBlessingSelection()
		{
			this.BlessingCardLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x06033A08 RID: 211464 RVA: 0x00E73518 File Offset: 0x00E71718
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

		// Token: 0x06033A09 RID: 211465 RVA: 0x00E73580 File Offset: 0x00E71780
		private void RefreshRoleInfo()
		{
			if (this.ChooseData == null || this.ChooseData.Entries.Count == 0)
			{
				return;
			}
			RoverlikeGainEntry roverlikeGainEntry = this.ChooseData.Entries[0];
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
			if (blessConfig == null)
			{
				return;
			}
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(blessConfig.Value.BlessRoleId);
			if (blessRoleConfig == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(blessRoleConfig.Value.Stand, base.GetTexture(5), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), blessRoleConfig.Value.BlessSelectDesc, Array.Empty<object>());
			if (!this.HasPlayedVoice)
			{
				this.HasPlayedVoice = true;
				RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
				if (instanceData == null)
				{
					return;
				}
				instanceData.PlayBlessRoleVoice(blessConfig.Value.BlessRoleId);
			}
		}

		// Token: 0x06033A0A RID: 211466 RVA: 0x00E73670 File Offset: 0x00E71870
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

		// Token: 0x06033A0B RID: 211467 RVA: 0x00E73764 File Offset: 0x00E71964
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x06033A0C RID: 211468 RVA: 0x00E73798 File Offset: 0x00E71998
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
				RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
				RoverlikeGainEntry roverlikeGainEntry2 = (instanceData != null) ? instanceData.GetSameSlotIdBless(roverlikeGainEntry.ConfigId) : null;
				RoverlikeBlessingItemData item = new RoverlikeBlessingItemData
				{
					BlessId = roverlikeGainEntry.ConfigId,
					IncId = new int?(roverlikeGainEntry.IncId),
					CheckSameSlot = new bool?(true),
					ShowRecommend = new bool?(roverlikeGainEntry2 == null)
				};
				list.Add(item);
			}
			this.RefreshBlessingLayout(list);
			this.RefreshRoleInfo();
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x06033A0D RID: 211469 RVA: 0x00E738B8 File Offset: 0x00E71AB8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int index;
			if (configParams.Length == 0 || !int.TryParse(configParams[0], out index))
			{
				return null;
			}
			GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> blessingCardLayout = this.BlessingCardLayout;
			UUIItem uuiitem;
			if (blessingCardLayout == null)
			{
				uuiitem = null;
			}
			else
			{
				RoverlikeBlessingCardItem layoutItemByIndex = blessingCardLayout.GetLayoutItemByIndex(index);
				uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetGuideUiItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x0401B63D RID: 112189
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> BlessingCardLayout;

		// Token: 0x0401B63E RID: 112190
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x0401B63F RID: 112191
		[Nullable(2)]
		private ButtonItem ButtonRefresh;

		// Token: 0x0401B640 RID: 112192
		private int SelectedEntryIndex = -1;

		// Token: 0x0401B641 RID: 112193
		private bool HasPlayedVoice;

		// Token: 0x0200AD51 RID: 44369
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358EE RID: 219374
			public const int BlessingLayout = 0;

			// Token: 0x040358EF RID: 219375
			public const int ItemBlessing = 1;

			// Token: 0x040358F0 RID: 219376
			public const int BtnConfirm = 2;

			// Token: 0x040358F1 RID: 219377
			public const int BtnRefresh = 3;

			// Token: 0x040358F2 RID: 219378
			public const int TxtRefreshCost = 4;

			// Token: 0x040358F3 RID: 219379
			public const int TexRole = 5;

			// Token: 0x040358F4 RID: 219380
			public const int TxtRoleName = 6;
		}
	}
}
