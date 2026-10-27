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
	// Token: 0x02006112 RID: 24850
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewSelectReinforcement : RoverlikeActionSubViewBase
	{
		// Token: 0x17009180 RID: 37248
		// (get) Token: 0x0603ED50 RID: 257360 RVA: 0x00F2CBE2 File Offset: 0x00F2ADE2
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectReinforcement;
			}
		}

		// Token: 0x17009181 RID: 37249
		// (get) Token: 0x0603ED51 RID: 257361 RVA: 0x00F2CBE5 File Offset: 0x00F2ADE5
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeRoleBuffSelect";
			}
		}

		// Token: 0x0603ED52 RID: 257362 RVA: 0x00F2CBEC File Offset: 0x00F2ADEC
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

		// Token: 0x0603ED53 RID: 257363 RVA: 0x00F2CD18 File Offset: 0x00F2AF18
		protected override void OnStart()
		{
			this.ReinforcementLayout = new GenericLayout<RoverlikeReinforcementCardItem, IRoverlikeReinforcementItemData>(base.GetHorizontalLayout(0), new Func<RoverlikeReinforcementCardItem>(this.CreateReinforcementItem), null, false, true);
			this.RefreshBtn = new ButtonItem(base.GetItem(3));
			this.RefreshBtn.SetFunction(delegate(int _)
			{
				this.OnRefreshClick();
			});
		}

		// Token: 0x0603ED54 RID: 257364 RVA: 0x00F2CD6F File Offset: 0x00F2AF6F
		protected override void OnBeforeDestroy()
		{
			this.ChooseData = null;
		}

		// Token: 0x0603ED55 RID: 257365 RVA: 0x00F2CD78 File Offset: 0x00F2AF78
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ED56 RID: 257366 RVA: 0x00F2CD96 File Offset: 0x00F2AF96
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603ED57 RID: 257367 RVA: 0x00F2CDB4 File Offset: 0x00F2AFB4
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

		// Token: 0x0603ED58 RID: 257368 RVA: 0x00F2CDC9 File Offset: 0x00F2AFC9
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

		// Token: 0x0603ED59 RID: 257369 RVA: 0x00F2CDE0 File Offset: 0x00F2AFE0
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

		// Token: 0x0603ED5A RID: 257370 RVA: 0x00F2CE3B File Offset: 0x00F2B03B
		private RoverlikeReinforcementCardItem CreateReinforcementItem()
		{
			RoverlikeReinforcementCardItem roverlikeReinforcementCardItem = new RoverlikeReinforcementCardItem();
			roverlikeReinforcementCardItem.BindOnItemSelect(new Action<IRoverlikeReinforcementItemData>(this.OnReinforcementItemSelect));
			return roverlikeReinforcementCardItem;
		}

		// Token: 0x0603ED5B RID: 257371 RVA: 0x00F2CE54 File Offset: 0x00F2B054
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

		// Token: 0x0603ED5C RID: 257372 RVA: 0x00F2CEF8 File Offset: 0x00F2B0F8
		private void OnReinforcementLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeSelectReinforcement");
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x0603ED5D RID: 257373 RVA: 0x00F2CF19 File Offset: 0x00F2B119
		private void RefreshReinforcementSelection()
		{
			this.ReinforcementLayout.SelectGridProxy(this.SelectedEntryIndex, false);
			this.RefreshButton();
		}

		// Token: 0x0603ED5E RID: 257374 RVA: 0x00F2CF34 File Offset: 0x00F2B134
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

		// Token: 0x0603ED5F RID: 257375 RVA: 0x00F2D024 File Offset: 0x00F2B224
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

		// Token: 0x0603ED60 RID: 257376 RVA: 0x00F2D08C File Offset: 0x00F2B28C
		private void OnCurrencyChange(int itemId)
		{
			int? goldItemId = RoverlikeModel.Instance.GoldItemId;
			if (!(itemId == goldItemId.GetValueOrDefault() & goldItemId != null))
			{
				return;
			}
			this.RefreshButton();
		}

		// Token: 0x0603ED61 RID: 257377 RVA: 0x00F2D0C0 File Offset: 0x00F2B2C0
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

		// Token: 0x0603ED62 RID: 257378 RVA: 0x00F2D124 File Offset: 0x00F2B324
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

		// Token: 0x04020D15 RID: 134421
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeReinforcementCardItem, IRoverlikeReinforcementItemData> ReinforcementLayout;

		// Token: 0x04020D16 RID: 134422
		[Nullable(2)]
		private ButtonItem RefreshBtn;

		// Token: 0x04020D17 RID: 134423
		[Nullable(2)]
		private RoverlikeChooseData ChooseData;

		// Token: 0x04020D18 RID: 134424
		private int SelectedEntryIndex = -1;

		// Token: 0x0200C36C RID: 50028
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF93 RID: 241555
			public const int ReinforcementLayout = 0;

			// Token: 0x0403AF94 RID: 241556
			public const int ItemReinforcement = 1;

			// Token: 0x0403AF95 RID: 241557
			public const int BtnConfirm = 2;

			// Token: 0x0403AF96 RID: 241558
			public const int BtnRefresh = 3;

			// Token: 0x0403AF97 RID: 241559
			public const int TxtRefreshCost = 4;

			// Token: 0x0403AF98 RID: 241560
			public const int TexRole = 5;
		}
	}
}
