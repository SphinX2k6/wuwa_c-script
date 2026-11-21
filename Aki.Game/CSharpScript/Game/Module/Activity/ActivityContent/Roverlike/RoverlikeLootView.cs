using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E7 RID: 20711
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLootView : UiViewBase
	{
		// Token: 0x06033D47 RID: 212295 RVA: 0x00E82128 File Offset: 0x00E80328
		[NullableContext(1)]
		public RoverlikeLootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033D48 RID: 212296 RVA: 0x00E82150 File Offset: 0x00E80350
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033D49 RID: 212297 RVA: 0x00E822A4 File Offset: 0x00E804A4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D4A RID: 212298 RVA: 0x00E822E8 File Offset: 0x00E804E8
		protected override void OnStart()
		{
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.BtnConfirmRoot = base.GetItem(4);
			this.BtnConfirm = new ButtonItem(this.BtnConfirmRoot);
			this.PnlActivated = base.GetItem(5);
			this.PnlBubble = base.GetItem(6);
			this.TxtTips = base.GetText(8);
			this.LootScroll = new LoopScrollView<RoverlikeLootItem, RoverlikeLootGainEntry>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<RoverlikeLootItem>(this.CreateLootItem), false);
			this.InitFromOpenParam();
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.BtnConfirm.SetFunction(new Action<int>(this.OnClickConfirm));
			if (!this.IsInGame)
			{
				RoverlikeActivityData activityData = this.ActivityData;
				if (activityData != null)
				{
					activityData.MarkLootUnlockRedDotRead();
				}
			}
			this.RefreshLootScroll();
			this.UpdateConfirmState();
		}

		// Token: 0x06033D4B RID: 212299 RVA: 0x00E823D5 File Offset: 0x00E805D5
		protected override void OnBeforeDestroy()
		{
			if (!this.IsInGame)
			{
				RoverlikeActivityData activityData = this.ActivityData;
				if (activityData == null)
				{
					return;
				}
				activityData.ClearNewUnlockedLootIds();
			}
		}

		// Token: 0x06033D4C RID: 212300 RVA: 0x00E823F0 File Offset: 0x00E805F0
		private void InitFromOpenParam()
		{
			RoverlikeLootViewOpenParam roverlikeLootViewOpenParam = this.OpenParam as RoverlikeLootViewOpenParam;
			this.IsInGame = (roverlikeLootViewOpenParam != null && roverlikeLootViewOpenParam.IsInGame);
			List<RoverRogueGainEntry> loots = ((roverlikeLootViewOpenParam != null) ? roverlikeLootViewOpenParam.Loots : null) ?? new List<RoverRogueGainEntry>();
			this.OnConfirmSelect = ((roverlikeLootViewOpenParam != null) ? roverlikeLootViewOpenParam.OnConfirmSelect : null);
			this.IsSelectMode = (this.OnConfirmSelect != null);
			this.DefaultSelectedLootId = ((roverlikeLootViewOpenParam != null) ? roverlikeLootViewOpenParam.DefaultSelectedLootId : 0);
			this.EquippedLootIds.Clear();
			foreach (int item in (((roverlikeLootViewOpenParam != null) ? roverlikeLootViewOpenParam.EquippedLootIds : null) ?? new List<int>()))
			{
				this.EquippedLootIds.Add(item);
			}
			if (this.IsInGame)
			{
				this.InitInGame(roverlikeLootViewOpenParam);
			}
			else
			{
				this.InitOutOfGame(roverlikeLootViewOpenParam);
			}
			this.LootDataList = this.BuildLootDataList(loots);
		}

		// Token: 0x06033D4D RID: 212301 RVA: 0x00E824F0 File Offset: 0x00E806F0
		private void InitInGame(RoverlikeLootViewOpenParam param)
		{
			this.CanSwitch = ((param != null) ? param.EnableUse : null).GetValueOrDefault();
		}

		// Token: 0x06033D4E RID: 212302 RVA: 0x00E82520 File Offset: 0x00E80720
		private void InitOutOfGame(RoverlikeLootViewOpenParam param)
		{
			this.CanSwitch = ((param != null) ? param.EnableUse : null).GetValueOrDefault(true);
		}

		// Token: 0x06033D4F RID: 212303 RVA: 0x00E82550 File Offset: 0x00E80750
		[NullableContext(1)]
		private List<RoverlikeLootGainEntry> BuildLootDataList(List<RoverRogueGainEntry> loots)
		{
			List<RoverlikeLootGainEntry> list = new List<RoverlikeLootGainEntry>();
			foreach (RoverRogueGainEntry proto in loots)
			{
				RoverlikeLootGainEntry roverlikeLootGainEntry = new RoverlikeLootGainEntry(proto);
				roverlikeLootGainEntry.IsEquipped = this.EquippedLootIds.Contains(roverlikeLootGainEntry.ConfigId);
				list.Add(roverlikeLootGainEntry);
			}
			list.Sort(delegate(RoverlikeLootGainEntry a, RoverlikeLootGainEntry b)
			{
				if (a.Unlock != b.Unlock)
				{
					if (!a.Unlock)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.LootLv != b.LootLv)
					{
						return b.LootLv - a.LootLv;
					}
					return a.ConfigId - b.ConfigId;
				}
			});
			return list;
		}

		// Token: 0x06033D50 RID: 212304 RVA: 0x00E825E8 File Offset: 0x00E807E8
		[NullableContext(1)]
		private RoverlikeLootItem CreateLootItem()
		{
			RoverlikeLootItem roverlikeLootItem = new RoverlikeLootItem();
			roverlikeLootItem.BindOnItemSelect(new Action<RoverlikeLootGainEntry>(this.OnSelectLoot));
			roverlikeLootItem.GetHasRedDot = new Func<RoverlikeLootGainEntry, bool>(this.IsLootRedDotVisible);
			return roverlikeLootItem;
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x06033D51 RID: 212305 RVA: 0x00E82613 File Offset: 0x00E80813
		private RoverlikeActivityData ActivityData
		{
			get
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetCurrentActivityData();
			}
		}

		// Token: 0x06033D52 RID: 212306 RVA: 0x00E82625 File Offset: 0x00E80825
		[NullableContext(1)]
		private bool IsLootRedDotVisible(RoverlikeLootGainEntry data)
		{
			if (this.IsInGame)
			{
				return false;
			}
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsLootNewUnlocked(data.ConfigId);
		}

		// Token: 0x06033D53 RID: 212307 RVA: 0x00E82648 File Offset: 0x00E80848
		private void RefreshLootScroll()
		{
			this.LootScroll.RefreshByData(this.LootDataList, false, delegate
			{
				int defaultSelectIndex = this.GetDefaultSelectIndex();
				if (defaultSelectIndex >= 0)
				{
					this.OnSelectLoot(this.LootDataList[defaultSelectIndex]);
				}
			}, false);
		}

		// Token: 0x06033D54 RID: 212308 RVA: 0x00E8266C File Offset: 0x00E8086C
		private int GetDefaultSelectIndex()
		{
			if (this.IsSelectMode && this.DefaultSelectedLootId > 0)
			{
				int num = this.LootDataList.FindIndex((RoverlikeLootGainEntry entry) => entry.ConfigId == this.DefaultSelectedLootId && this.IsSelectable(entry));
				if (num >= 0)
				{
					return num;
				}
			}
			int num2 = this.LootDataList.FindIndex((RoverlikeLootGainEntry entry) => entry.Unlock && this.EquippedLootIds.Contains(entry.ConfigId));
			if (num2 >= 0)
			{
				return num2;
			}
			int num3 = this.LootDataList.FindIndex((RoverlikeLootGainEntry entry) => this.IsSelectable(entry));
			if (num3 >= 0)
			{
				return num3;
			}
			if (this.LootDataList.Count <= 0)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06033D55 RID: 212309 RVA: 0x00E826F8 File Offset: 0x00E808F8
		[NullableContext(1)]
		private void OnSelectLoot(RoverlikeLootGainEntry entry)
		{
			if (this.SelectedEntry == entry)
			{
				return;
			}
			if (!this.IsInGame)
			{
				RoverlikeActivityData activityData = this.ActivityData;
				if (activityData != null && activityData.IsLootNewUnlocked(entry.ConfigId))
				{
					this.ActivityData.MarkLootNewUnlockedRead(entry.ConfigId);
					int num = this.LootDataList.IndexOf(entry);
					if (num >= 0)
					{
						LoopScrollView<RoverlikeLootItem, RoverlikeLootGainEntry> lootScroll = this.LootScroll;
						if (lootScroll != null)
						{
							lootScroll.RefreshGridProxy(num);
						}
					}
				}
			}
			bool flag = this.SelectedEntry == null;
			this.SelectedEntry = entry;
			int num2 = this.LootDataList.IndexOf(entry);
			if (num2 >= 0)
			{
				this.LootScroll.SelectGridProxy(num2, false);
			}
			this.RefreshDetail(entry);
			this.UpdateConfirmState();
			if (!flag)
			{
				base.PlayOrReplaySequence("Switch", false, null);
			}
		}

		// Token: 0x06033D56 RID: 212310 RVA: 0x00E827B7 File Offset: 0x00E809B7
		[NullableContext(1)]
		private bool IsSelectable(RoverlikeLootGainEntry entry)
		{
			return entry.Unlock && !this.EquippedLootIds.Contains(entry.ConfigId);
		}

		// Token: 0x06033D57 RID: 212311 RVA: 0x00E827D7 File Offset: 0x00E809D7
		[NullableContext(1)]
		private void RefreshDetail(RoverlikeLootGainEntry entry)
		{
			RoverlikeLootCardItem detailCard = this.DetailCard;
			if (detailCard != null)
			{
				detailCard.Refresh(entry);
			}
			this.RefreshApplyRoleType(entry);
		}

		// Token: 0x06033D58 RID: 212312 RVA: 0x00E827F4 File Offset: 0x00E809F4
		[NullableContext(1)]
		private void RefreshApplyRoleType(RoverlikeLootGainEntry entry)
		{
			RoverRogueLoot? lootConfig = RoverlikeConfig.Instance.GetLootConfig(entry.ConfigId);
			int num = (lootConfig != null) ? lootConfig.GetValueOrDefault().ApplyRoleType : 0;
			if (num != 0)
			{
				UUIItem pnlBubble = this.PnlBubble;
				if (pnlBubble != null)
				{
					pnlBubble.SetUIActive(true);
				}
				RoverRogueRoleType? roleTypeConfig = RoverlikeConfig.Instance.GetRoleTypeConfig(num);
				RoverlikeLootElementIcon elementIcon = this.ElementIcon;
				if (elementIcon != null)
				{
					elementIcon.Refresh(((roleTypeConfig != null) ? roleTypeConfig.GetValueOrDefault().ElementIcon : null) ?? "");
				}
				LguiUtil.Instance.SetLocalTextNew(this.TxtTips, ((lootConfig != null) ? lootConfig.GetValueOrDefault().ApplyRoleTypeLockDesc : null) ?? "", Array.Empty<object>());
				return;
			}
			UUIItem pnlBubble2 = this.PnlBubble;
			if (pnlBubble2 == null)
			{
				return;
			}
			pnlBubble2.SetUIActive(false);
		}

		// Token: 0x06033D59 RID: 212313 RVA: 0x00E828D4 File Offset: 0x00E80AD4
		private void UpdateConfirmState()
		{
			RoverlikeLootGainEntry selectedEntry = this.SelectedEntry;
			bool flag = selectedEntry != null && selectedEntry.Unlock && this.EquippedLootIds.Contains(selectedEntry.ConfigId);
			bool flag2 = selectedEntry != null && !flag;
			UUIItem pnlActivated = this.PnlActivated;
			if (pnlActivated != null)
			{
				pnlActivated.SetUIActive(flag);
			}
			UUIItem btnConfirmRoot = this.BtnConfirmRoot;
			if (btnConfirmRoot != null)
			{
				btnConfirmRoot.SetUIActive(flag2);
			}
			if (flag2)
			{
				this.BtnConfirm.SetEnableClick(this.CanConfirm());
			}
		}

		// Token: 0x06033D5A RID: 212314 RVA: 0x00E8294B File Offset: 0x00E80B4B
		private bool CanConfirm()
		{
			return this.SelectedEntry != null && this.IsSelectable(this.SelectedEntry) && (this.IsSelectMode || this.CanSwitch);
		}

		// Token: 0x06033D5B RID: 212315 RVA: 0x00E82978 File Offset: 0x00E80B78
		private void OnClickConfirm(int _)
		{
			RoverlikeLootGainEntry selectedEntry = this.SelectedEntry;
			if (selectedEntry == null || !this.IsSelectable(selectedEntry))
			{
				return;
			}
			if (this.IsSelectMode)
			{
				this.ConfirmSelect(selectedEntry);
				return;
			}
			if (this.IsInGame)
			{
				this.ConfirmInGame(selectedEntry);
				return;
			}
			this.ConfirmOutOfGame(selectedEntry);
		}

		// Token: 0x06033D5C RID: 212316 RVA: 0x00E829C0 File Offset: 0x00E80BC0
		[NullableContext(1)]
		private void ConfirmSelect(RoverlikeLootGainEntry entry)
		{
			Action<int, int> onConfirmSelect = this.OnConfirmSelect;
			if (onConfirmSelect != null)
			{
				onConfirmSelect(entry.ConfigId, entry.LootLv);
			}
			base.CloseMe(null);
		}

		// Token: 0x06033D5D RID: 212317 RVA: 0x00E829E6 File Offset: 0x00E80BE6
		[NullableContext(1)]
		private void ConfirmInGame(RoverlikeLootGainEntry entry)
		{
			if (!this.CanSwitch)
			{
				return;
			}
			RoverlikeController.Instance.RoverRogueLootChangeRequest(entry.ConfigId, delegate(bool success)
			{
				if (success)
				{
					this.CanSwitch = false;
				}
				base.CloseMe(null);
			});
		}

		// Token: 0x06033D5E RID: 212318 RVA: 0x00E82A0D File Offset: 0x00E80C0D
		[NullableContext(1)]
		private void ConfirmOutOfGame(RoverlikeLootGainEntry entry)
		{
		}

		// Token: 0x0401B73F RID: 112447
		protected PopupCaptionItem Caption;

		// Token: 0x0401B740 RID: 112448
		protected ButtonItem BtnConfirm;

		// Token: 0x0401B741 RID: 112449
		private UUIItem BtnConfirmRoot;

		// Token: 0x0401B742 RID: 112450
		private UUIItem PnlActivated;

		// Token: 0x0401B743 RID: 112451
		private UUIItem PnlBubble;

		// Token: 0x0401B744 RID: 112452
		private RoverlikeLootElementIcon ElementIcon;

		// Token: 0x0401B745 RID: 112453
		private UUIText TxtTips;

		// Token: 0x0401B746 RID: 112454
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RoverlikeLootItem, RoverlikeLootGainEntry> LootScroll;

		// Token: 0x0401B747 RID: 112455
		private RoverlikeLootCardItem DetailCard;

		// Token: 0x0401B748 RID: 112456
		[Nullable(1)]
		private List<RoverlikeLootGainEntry> LootDataList = new List<RoverlikeLootGainEntry>();

		// Token: 0x0401B749 RID: 112457
		private RoverlikeLootGainEntry SelectedEntry;

		// Token: 0x0401B74A RID: 112458
		private bool IsInGame;

		// Token: 0x0401B74B RID: 112459
		private bool CanSwitch = true;

		// Token: 0x0401B74C RID: 112460
		[Nullable(1)]
		private readonly HashSet<int> EquippedLootIds = new HashSet<int>();

		// Token: 0x0401B74D RID: 112461
		private bool IsSelectMode;

		// Token: 0x0401B74E RID: 112462
		private Action<int, int> OnConfirmSelect;

		// Token: 0x0401B74F RID: 112463
		private int DefaultSelectedLootId;

		// Token: 0x0200ADB4 RID: 44468
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035ABD RID: 219837
			public const int Caption = 0;

			// Token: 0x04035ABE RID: 219838
			public const int LootScroll = 1;

			// Token: 0x04035ABF RID: 219839
			public const int LootItemTemplate = 2;

			// Token: 0x04035AC0 RID: 219840
			public const int DetailCard = 3;

			// Token: 0x04035AC1 RID: 219841
			public const int BtnConfirm = 4;

			// Token: 0x04035AC2 RID: 219842
			public const int PnlActivated = 5;

			// Token: 0x04035AC3 RID: 219843
			public const int PnlBubble = 6;

			// Token: 0x04035AC4 RID: 219844
			public const int PnlElementIcon = 7;

			// Token: 0x04035AC5 RID: 219845
			public const int TxtTips = 8;
		}
	}
}
