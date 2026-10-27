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
	// Token: 0x02006111 RID: 24849
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewSelectBlessing : RoverlikeActionSubViewBase
	{
		// Token: 0x1700917E RID: 37246
		// (get) Token: 0x0603ED37 RID: 257335 RVA: 0x00F2C3AA File Offset: 0x00F2A5AA
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectBlessing;
			}
		}

		// Token: 0x1700917F RID: 37247
		// (get) Token: 0x0603ED38 RID: 257336 RVA: 0x00F2C3AD File Offset: 0x00F2A5AD
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSelect";
			}
		}

		// Token: 0x0603ED39 RID: 257337 RVA: 0x00F2C3B4 File Offset: 0x00F2A5B4
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

		// Token: 0x0603ED3A RID: 257338 RVA: 0x00F2C500 File Offset: 0x00F2A700
		protected override void OnStart()
		{
			this.BlessingCardLayout = new GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingCardItem>(this.CreateBlessingItem), null, false, true);
			this.ButtonRefresh = new ButtonItem(base.GetItem(3));
			this.ButtonRefresh.SetFunction(delegate(int _)
			{
				this.OnBtnRefreshClick();
			});
		}

		// Token: 0x0603ED3B RID: 257339 RVA: 0x00F2C557 File Offset: 0x00F2A757
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x0603ED3C RID: 257340 RVA: 0x00F2C560 File Offset: 0x00F2A760
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ED3D RID: 257341 RVA: 0x00F2C57E File Offset: 0x00F2A77E
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ED3E RID: 257342 RVA: 0x00F2C59C File Offset: 0x00F2A79C
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

		// Token: 0x0603ED3F RID: 257343 RVA: 0x00F2C5B1 File Offset: 0x00F2A7B1
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

		// Token: 0x0603ED40 RID: 257344 RVA: 0x00F2C5C8 File Offset: 0x00F2A7C8
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

		// Token: 0x0603ED41 RID: 257345 RVA: 0x00F2C624 File Offset: 0x00F2A824
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

		// Token: 0x0603ED42 RID: 257346 RVA: 0x00F2C68D File Offset: 0x00F2A88D
		private RoverlikeBlessingCardItem CreateBlessingItem()
		{
			RoverlikeBlessingCardItem roverlikeBlessingCardItem = new RoverlikeBlessingCardItem();
			roverlikeBlessingCardItem.BindOnItemSelect(new Action<IRoverlikeBlessingItemData>(this.OnBlessingItemSelect));
			return roverlikeBlessingCardItem;
		}

		// Token: 0x0603ED43 RID: 257347 RVA: 0x00F2C6A6 File Offset: 0x00F2A8A6
		private void RefreshBlessingLayout(List<IRoverlikeBlessingItemData> dataList)
		{
			this.BlessingCardLayout.RefreshByData(dataList, new Action(this.OnBlessingLayoutRefreshed), true);
		}

		// Token: 0x0603ED44 RID: 257348 RVA: 0x00F2C6C1 File Offset: 0x00F2A8C1
		private void OnBlessingLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeSelectBlessing");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x0603ED45 RID: 257349 RVA: 0x00F2C6E2 File Offset: 0x00F2A8E2
		private void RefreshBlessingSelection()
		{
			this.BlessingCardLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
			this.RefreshSlotHighlight();
		}

		// Token: 0x0603ED46 RID: 257350 RVA: 0x00F2C704 File Offset: 0x00F2A904
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

		// Token: 0x0603ED47 RID: 257351 RVA: 0x00F2C76C File Offset: 0x00F2A96C
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

		// Token: 0x0603ED48 RID: 257352 RVA: 0x00F2C85C File Offset: 0x00F2AA5C
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

		// Token: 0x0603ED49 RID: 257353 RVA: 0x00F2C950 File Offset: 0x00F2AB50
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x0603ED4A RID: 257354 RVA: 0x00F2C984 File Offset: 0x00F2AB84
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

		// Token: 0x0603ED4B RID: 257355 RVA: 0x00F2CAA4 File Offset: 0x00F2ACA4
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

		// Token: 0x04020D10 RID: 134416
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> BlessingCardLayout;

		// Token: 0x04020D11 RID: 134417
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x04020D12 RID: 134418
		[Nullable(2)]
		private ButtonItem ButtonRefresh;

		// Token: 0x04020D13 RID: 134419
		private int SelectedEntryIndex = -1;

		// Token: 0x04020D14 RID: 134420
		private bool HasPlayedVoice;

		// Token: 0x0200C369 RID: 50025
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF89 RID: 241545
			public const int BlessingLayout = 0;

			// Token: 0x0403AF8A RID: 241546
			public const int ItemBlessing = 1;

			// Token: 0x0403AF8B RID: 241547
			public const int BtnConfirm = 2;

			// Token: 0x0403AF8C RID: 241548
			public const int BtnRefresh = 3;

			// Token: 0x0403AF8D RID: 241549
			public const int TxtRefreshCost = 4;

			// Token: 0x0403AF8E RID: 241550
			public const int TexRole = 5;

			// Token: 0x0403AF8F RID: 241551
			public const int TxtRoleName = 6;
		}
	}
}
