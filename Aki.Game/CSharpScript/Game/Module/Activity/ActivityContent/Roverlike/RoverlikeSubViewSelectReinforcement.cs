using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005090 RID: 20624
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewSelectReinforcement : RoverlikeActionSubViewBase
	{
		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x06033A12 RID: 211474 RVA: 0x00E739F6 File Offset: 0x00E71BF6
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectReinforcement;
			}
		}

		// Token: 0x170064E3 RID: 25827
		// (get) Token: 0x06033A13 RID: 211475 RVA: 0x00E739F9 File Offset: 0x00E71BF9
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeRoleBuffSelect";
			}
		}

		// Token: 0x06033A14 RID: 211476 RVA: 0x00E73A00 File Offset: 0x00E71C00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033A15 RID: 211477 RVA: 0x00E73B2C File Offset: 0x00E71D2C
		protected override void OnStart()
		{
			this.ReinforcementLayout = new GenericLayout<RoverlikeReinforcementCardItem, IRoverlikeReinforcementItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeReinforcementCardItem>(this.CreateReinforcementItem), null, false, true);
			this.RefreshBtn = new ButtonItem(base.GetItem(3));
			this.RefreshBtn.SetFunction(delegate(int _)
			{
				this.OnRefreshClick();
			});
		}

		// Token: 0x06033A16 RID: 211478 RVA: 0x00E73B83 File Offset: 0x00E71D83
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x06033A17 RID: 211479 RVA: 0x00E73B8C File Offset: 0x00E71D8C
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x06033A18 RID: 211480 RVA: 0x00E73BAA File Offset: 0x00E71DAA
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x06033A19 RID: 211481 RVA: 0x00E73BC8 File Offset: 0x00E71DC8
		private void OnConfirmClick()
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
				RoverlikeController.Instance.RoverRogueChooseDataResultRequest(this.ChooseData.BindId, roverlikeGainEntry.IncId, null);
			});
		}

		// Token: 0x06033A1A RID: 211482 RVA: 0x00E73BDD File Offset: 0x00E71DDD
		private void OnRefreshClick()
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

		// Token: 0x06033A1B RID: 211483 RVA: 0x00E73BF4 File Offset: 0x00E71DF4
		private void OnReinforcementItemSelect(IRoverlikeReinforcementItemData data)
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
			this.RefreshReinforcementSelection();
		}

		// Token: 0x06033A1C RID: 211484 RVA: 0x00E73C4F File Offset: 0x00E71E4F
		private RoverlikeReinforcementCardItem CreateReinforcementItem()
		{
			RoverlikeReinforcementCardItem roverlikeReinforcementCardItem = new RoverlikeReinforcementCardItem();
			roverlikeReinforcementCardItem.BindOnItemSelect(new Action<IRoverlikeReinforcementItemData>(this.OnReinforcementItemSelect));
			return roverlikeReinforcementCardItem;
		}

		// Token: 0x06033A1D RID: 211485 RVA: 0x00E73C68 File Offset: 0x00E71E68
		private void RefreshReinforcementLayout()
		{
			if (this.ChooseData == null)
			{
				return;
			}
			List<IRoverlikeReinforcementItemData> list = new List<IRoverlikeReinforcementItemData>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in this.ChooseData.Entries)
			{
				RoverlikeReinforcementItemData item = new RoverlikeReinforcementItemData
				{
					ConfigId = roverlikeGainEntry.ConfigId,
					IncId = new int?(roverlikeGainEntry.IncId)
				};
				list.Add(item);
			}
			this.ReinforcementLayout.RefreshByData(list, new Action(this.OnReinforcementLayoutRefreshed), true);
		}

		// Token: 0x06033A1E RID: 211486 RVA: 0x00E73D0C File Offset: 0x00E71F0C
		private void OnReinforcementLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeSelectReinforcement");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x06033A1F RID: 211487 RVA: 0x00E73D2D File Offset: 0x00E71F2D
		private void RefreshReinforcementSelection()
		{
			this.ReinforcementLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
		}

		// Token: 0x06033A20 RID: 211488 RVA: 0x00E73D48 File Offset: 0x00E71F48
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
			ButtonItem refreshBtn = this.RefreshBtn;
			if (refreshBtn != null)
			{
				refreshBtn.SetEnableClick(this.ChooseData.HasRefreshTime());
			}
			ButtonItem refreshBtn2 = this.RefreshBtn;
			if (refreshBtn2 != null)
			{
				refreshBtn2.SetLocalTextNew("RoverRogue_RefreshCount", new object[]
				{
					this.ChooseData.UseTime,
					this.ChooseData.MaxTime
				});
			}
			LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_RefreshCost", new <>z__ReadOnlySingleElementList<object>(this.ChooseData.RefreshCost));
			UUIItem uuiitem = text;
			bool bUseChangeColor = !this.ChooseData.HasRefreshCost();
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x06033A21 RID: 211489 RVA: 0x00E73E38 File Offset: 0x00E72038
		private void RefreshRoleInfo()
		{
			int mainRoleId = RoverlikeModel.Instance.GetMainRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(mainRoleId, true);
			RoleInfo? roleInfo = (roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : null;
			if (roleInfo == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(roleInfo.Value.FormationRoleCard, base.GetTexture(5), null);
		}

		// Token: 0x06033A22 RID: 211490 RVA: 0x00E73EA0 File Offset: 0x00E720A0
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x06033A23 RID: 211491 RVA: 0x00E73ED4 File Offset: 0x00E720D4
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
			this.RefreshReinforcementLayout();
			this.RefreshRoleInfo();
			this.RefreshButton();
		}

		// Token: 0x06033A24 RID: 211492 RVA: 0x00E73F38 File Offset: 0x00E72138
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
			GenericLayout<RoverlikeReinforcementCardItem, IRoverlikeReinforcementItemData> reinforcementLayout = this.ReinforcementLayout;
			UUIItem uuiitem;
			if (reinforcementLayout == null)
			{
				uuiitem = null;
			}
			else
			{
				RoverlikeReinforcementCardItem layoutItemByIndex = reinforcementLayout.GetLayoutItemByIndex(index);
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

		// Token: 0x0401B642 RID: 112194
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeReinforcementCardItem, IRoverlikeReinforcementItemData> ReinforcementLayout;

		// Token: 0x0401B643 RID: 112195
		[Nullable(2)]
		private ButtonItem RefreshBtn;

		// Token: 0x0401B644 RID: 112196
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x0401B645 RID: 112197
		private int SelectedEntryIndex = -1;

		// Token: 0x0200AD54 RID: 44372
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358F8 RID: 219384
			public const int ReinforcementLayout = 0;

			// Token: 0x040358F9 RID: 219385
			public const int ItemReinforcement = 1;

			// Token: 0x040358FA RID: 219386
			public const int BtnConfirm = 2;

			// Token: 0x040358FB RID: 219387
			public const int BtnRefresh = 3;

			// Token: 0x040358FC RID: 219388
			public const int TxtRefreshCost = 4;

			// Token: 0x040358FD RID: 219389
			public const int TexRole = 5;
		}
	}
}
