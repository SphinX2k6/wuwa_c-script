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
	// Token: 0x02006169 RID: 24937
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLootView : UiViewBase
	{
		// Token: 0x0603F087 RID: 258183 RVA: 0x00F3B254 File Offset: 0x00F39454
		[NullableContext(1)]
		public RoverlikeLootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F088 RID: 258184 RVA: 0x00F3B27C File Offset: 0x00F3947C
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

		// Token: 0x0603F089 RID: 258185 RVA: 0x00F3B3D0 File Offset: 0x00F395D0
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F08A RID: 258186 RVA: 0x00F3B414 File Offset: 0x00F39614
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

		// Token: 0x0603F08B RID: 258187 RVA: 0x00F3B501 File Offset: 0x00F39701
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

		// Token: 0x0603F08C RID: 258188 RVA: 0x00F3B51C File Offset: 0x00F3971C
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

		// Token: 0x0603F08D RID: 258189 RVA: 0x00F3B61C File Offset: 0x00F3981C
		private void InitInGame(RoverlikeLootViewOpenParam param)
		{
			this.CanSwitch = ((param != null) ? param.EnableUse : null).GetValueOrDefault();
		}

		// Token: 0x0603F08E RID: 258190 RVA: 0x00F3B64C File Offset: 0x00F3984C
		private void InitOutOfGame(RoverlikeLootViewOpenParam param)
		{
			this.CanSwitch = ((param != null) ? param.EnableUse : null).GetValueOrDefault(true);
		}

		// Token: 0x0603F08F RID: 258191 RVA: 0x00F3B67C File Offset: 0x00F3987C
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

		// Token: 0x0603F090 RID: 258192 RVA: 0x00F3B714 File Offset: 0x00F39914
		[NullableContext(1)]
		private RoverlikeLootItem CreateLootItem()
		{
			RoverlikeLootItem roverlikeLootItem = new RoverlikeLootItem();
			roverlikeLootItem.BindOnItemSelect(new Action<RoverlikeLootGainEntry>(this.OnSelectLoot));
			roverlikeLootItem.GetHasRedDot = new Func<RoverlikeLootGainEntry, bool>(this.IsLootRedDotVisible);
			return roverlikeLootItem;
		}

		// Token: 0x170091B9 RID: 37305
		// (get) Token: 0x0603F091 RID: 258193 RVA: 0x00F3B73F File Offset: 0x00F3993F
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

		// Token: 0x0603F092 RID: 258194 RVA: 0x00F3B751 File Offset: 0x00F39951
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

		// Token: 0x0603F093 RID: 258195 RVA: 0x00F3B774 File Offset: 0x00F39974
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

		// Token: 0x0603F094 RID: 258196 RVA: 0x00F3B798 File Offset: 0x00F39998
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

		// Token: 0x0603F095 RID: 258197 RVA: 0x00F3B824 File Offset: 0x00F39A24
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

		// Token: 0x0603F096 RID: 258198 RVA: 0x00F3B8E3 File Offset: 0x00F39AE3
		[NullableContext(1)]
		private bool IsSelectable(RoverlikeLootGainEntry entry)
		{
			return entry.Unlock && !this.EquippedLootIds.Contains(entry.ConfigId);
		}

		// Token: 0x0603F097 RID: 258199 RVA: 0x00F3B903 File Offset: 0x00F39B03
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

		// Token: 0x0603F098 RID: 258200 RVA: 0x00F3B920 File Offset: 0x00F39B20
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

		// Token: 0x0603F099 RID: 258201 RVA: 0x00F3BA00 File Offset: 0x00F39C00
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

		// Token: 0x0603F09A RID: 258202 RVA: 0x00F3BA77 File Offset: 0x00F39C77
		private bool CanConfirm()
		{
			return this.SelectedEntry != null && this.IsSelectable(this.SelectedEntry) && (this.IsSelectMode || this.CanSwitch);
		}

		// Token: 0x0603F09B RID: 258203 RVA: 0x00F3BAA4 File Offset: 0x00F39CA4
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

		// Token: 0x0603F09C RID: 258204 RVA: 0x00F3BAEC File Offset: 0x00F39CEC
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

		// Token: 0x0603F09D RID: 258205 RVA: 0x00F3BB12 File Offset: 0x00F39D12
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

		// Token: 0x0603F09E RID: 258206 RVA: 0x00F3BB39 File Offset: 0x00F39D39
		[NullableContext(1)]
		private void ConfirmOutOfGame(RoverlikeLootGainEntry entry)
		{
		}

		// Token: 0x04020E12 RID: 134674
		protected PopupCaptionItem Caption;

		// Token: 0x04020E13 RID: 134675
		protected ButtonItem BtnConfirm;

		// Token: 0x04020E14 RID: 134676
		private UUIItem BtnConfirmRoot;

		// Token: 0x04020E15 RID: 134677
		private UUIItem PnlActivated;

		// Token: 0x04020E16 RID: 134678
		private UUIItem PnlBubble;

		// Token: 0x04020E17 RID: 134679
		private RoverlikeLootElementIcon ElementIcon;

		// Token: 0x04020E18 RID: 134680
		private UUIText TxtTips;

		// Token: 0x04020E19 RID: 134681
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RoverlikeLootItem, RoverlikeLootGainEntry> LootScroll;

		// Token: 0x04020E1A RID: 134682
		private RoverlikeLootCardItem DetailCard;

		// Token: 0x04020E1B RID: 134683
		[Nullable(1)]
		private List<RoverlikeLootGainEntry> LootDataList = new List<RoverlikeLootGainEntry>();

		// Token: 0x04020E1C RID: 134684
		private RoverlikeLootGainEntry SelectedEntry;

		// Token: 0x04020E1D RID: 134685
		private bool IsInGame;

		// Token: 0x04020E1E RID: 134686
		private bool CanSwitch = true;

		// Token: 0x04020E1F RID: 134687
		[Nullable(1)]
		private readonly HashSet<int> EquippedLootIds = new HashSet<int>();

		// Token: 0x04020E20 RID: 134688
		private bool IsSelectMode;

		// Token: 0x04020E21 RID: 134689
		private Action<int, int> OnConfirmSelect;

		// Token: 0x04020E22 RID: 134690
		private int DefaultSelectedLootId;

		// Token: 0x0200C3CD RID: 50125
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B15C RID: 242012
			public const int Caption = 0;

			// Token: 0x0403B15D RID: 242013
			public const int LootScroll = 1;

			// Token: 0x0403B15E RID: 242014
			public const int LootItemTemplate = 2;

			// Token: 0x0403B15F RID: 242015
			public const int DetailCard = 3;

			// Token: 0x0403B160 RID: 242016
			public const int BtnConfirm = 4;

			// Token: 0x0403B161 RID: 242017
			public const int PnlActivated = 5;

			// Token: 0x0403B162 RID: 242018
			public const int PnlBubble = 6;

			// Token: 0x0403B163 RID: 242019
			public const int PnlElementIcon = 7;

			// Token: 0x0403B164 RID: 242020
			public const int TxtTips = 8;
		}
	}
}
