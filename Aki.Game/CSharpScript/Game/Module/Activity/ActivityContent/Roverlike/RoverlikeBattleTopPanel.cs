using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006146 RID: 24902
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBattleTopPanel : UiPanelBase
	{
		// Token: 0x0603EF26 RID: 257830 RVA: 0x00F34800 File Offset: 0x00F32A00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnDetailClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBlessClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnBackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EF27 RID: 257831 RVA: 0x00F34994 File Offset: 0x00F32B94
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeBattleTopPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeBattleTopPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF28 RID: 257832 RVA: 0x00F349D8 File Offset: 0x00F32BD8
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnPanelSequenceClose), false);
			this.BlessingLayout = new GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData>(base.GetHorizontalLayout(2), () => new RoverlikeBlessingSlotItem(), null, false, true);
			this.RefreshBlessingLayout();
		}

		// Token: 0x0603EF29 RID: 257833 RVA: 0x00F34A48 File Offset: 0x00F32C48
		public void SetCurrencyEnableClick(bool bEnable)
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem == null)
			{
				return;
			}
			currencyItem.SetBtnEnable(bEnable);
		}

		// Token: 0x0603EF2A RID: 257834 RVA: 0x00F34A5B File Offset: 0x00F32C5B
		public void SetRefreshEnabled(bool bEnable)
		{
			this.RefreshEnabled = bEnable;
		}

		// Token: 0x0603EF2B RID: 257835 RVA: 0x00F34A64 File Offset: 0x00F32C64
		public void StartShow()
		{
			this.RefreshBlessingLayout();
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.BeginShow();
			}
			if (this.RefreshEnabled)
			{
				EventSystem.Instance.Add(EEventName.RoverlikeGainDataUpdate, new Action(this.OnGainDataUpdate));
			}
			EventSystem.Instance.Add(EEventName.ActivityDataInitComplete, new Action(this.OnActivityDataInitComplete));
		}

		// Token: 0x0603EF2C RID: 257836 RVA: 0x00F34AC8 File Offset: 0x00F32CC8
		public void EndShow()
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.BeginHide();
			}
			if (this.RefreshEnabled)
			{
				EventSystem.Instance.Remove(EEventName.RoverlikeGainDataUpdate, new Action(this.OnGainDataUpdate));
			}
			EventSystem.Instance.Remove(EEventName.ActivityDataInitComplete, new Action(this.OnActivityDataInitComplete));
		}

		// Token: 0x0603EF2D RID: 257837 RVA: 0x00F34B28 File Offset: 0x00F32D28
		private void InitBlessingSlot()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			RoverRogueActivity? roverRogueActivity = (roverlikeActivityData != null) ? roverlikeActivityData.GetParamConfig() : null;
			this.BlessSlotIds = ((roverRogueActivity != null) ? roverRogueActivity.Value.SlotList().ToList<int>() : new List<int>());
		}

		// Token: 0x0603EF2E RID: 257838 RVA: 0x00F34B88 File Offset: 0x00F32D88
		private void RefreshBlessingLayout()
		{
			IBlessingDisplayDiff blessingDisplayDiff = this.ComputeDisplayDiff();
			bool flag = blessingDisplayDiff.ChangedSlots.Count > 0 || blessingDisplayDiff.Count > this.CachedPassiveCount;
			if (this.RefreshEnabled && this.AnimInitialized && flag)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null || !levelSequencePlayer.IsPlayingSequence("Trail"))
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlayOrReplaySequenceByName("Trail", false, null);
				}
				return;
			}
			this.ApplyDisplay(false);
			this.AnimInitialized = true;
		}

		// Token: 0x0603EF2F RID: 257839 RVA: 0x00F34C18 File Offset: 0x00F32E18
		private void ApplyDisplay(bool playAnim)
		{
			IBlessingDisplayDiff blessingDisplayDiff = this.ComputeDisplayDiff();
			this.BlessingLayout.RefreshByData(blessingDisplayDiff.DataList, null, false);
			UUIText text = base.GetText(4);
			if (blessingDisplayDiff.Count > 0)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(blessingDisplayDiff.Count);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				text.SetUIActive(true);
			}
			else
			{
				text.SetUIActive(false);
			}
			if (playAnim)
			{
				foreach (int num in blessingDisplayDiff.ChangedSlots)
				{
					GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
					if (blessingLayout != null)
					{
						RoverlikeBlessingSlotItem layoutItemByKey = blessingLayout.GetLayoutItemByKey(num);
						if (layoutItemByKey != null)
						{
							layoutItemByKey.PlaySelectAnim();
						}
					}
				}
				if (blessingDisplayDiff.Count > this.CachedPassiveCount)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayOrReplaySequenceByName("Num", false, null);
					}
				}
			}
			foreach (IRoverlikeBlessingSlotItemData roverlikeBlessingSlotItemData in blessingDisplayDiff.DataList)
			{
				this.CachedSlotBlessMap[roverlikeBlessingSlotItemData.SlotId] = roverlikeBlessingSlotItemData.Id;
			}
			this.CachedPassiveCount = blessingDisplayDiff.Count;
		}

		// Token: 0x0603EF30 RID: 257840 RVA: 0x00F34D8C File Offset: 0x00F32F8C
		private IBlessingDisplayDiff ComputeDisplayDiff()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeGainEntry> list = ((instanceData != null) ? instanceData.GetBlessList() : null) ?? new List<RoverlikeGainEntry>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in list)
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig != null && this.BlessSlotIds.Contains(blessConfig.Value.SlotId))
				{
					dictionary[blessConfig.Value.SlotId] = roverlikeGainEntry.ConfigId;
				}
			}
			List<IRoverlikeBlessingSlotItemData> list2 = new List<IRoverlikeBlessingSlotItemData>();
			List<int> list3 = new List<int>();
			foreach (int num in this.BlessSlotIds)
			{
				int num3;
				int num2 = dictionary.TryGetValue(num, out num3) ? num3 : 0;
				int num5;
				int num4 = this.CachedSlotBlessMap.TryGetValue(num, out num5) ? num5 : 0;
				if (num2 != num4)
				{
					list3.Add(num);
				}
				RoverlikeBlessingSlotItemData item = new RoverlikeBlessingSlotItemData
				{
					Id = num2,
					SlotId = num
				};
				list2.Add(item);
			}
			return new BlessingDisplayDiff
			{
				DataList = list2,
				ChangedSlots = list3,
				Count = this.ComputePassiveCount()
			};
		}

		// Token: 0x0603EF31 RID: 257841 RVA: 0x00F34F10 File Offset: 0x00F33110
		private int ComputePassiveCount()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			int num = 0;
			foreach (RoverlikeGainEntry roverlikeGainEntry in (((instanceData != null) ? instanceData.GetBlessList() : null) ?? new List<RoverlikeGainEntry>()))
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig != null && !this.BlessSlotIds.Contains(blessConfig.Value.SlotId))
				{
					num++;
				}
			}
			using (List<RoverlikeGainEntry>.Enumerator enumerator = (((instanceData != null) ? instanceData.GetItemList() : null) ?? new List<RoverlikeGainEntry>()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ItemRemainingRooms > 0)
					{
						num++;
					}
				}
			}
			num += ((instanceData != null) ? instanceData.GetRoleEnhanceList().Count : 0);
			return num;
		}

		// Token: 0x0603EF32 RID: 257842 RVA: 0x00F35020 File Offset: 0x00F33220
		private void OnPanelSequenceClose(string sequenceName)
		{
			if (sequenceName != "Trail")
			{
				return;
			}
			this.ApplyDisplay(true);
			this.AnimInitialized = true;
		}

		// Token: 0x0603EF33 RID: 257843 RVA: 0x00F3503E File Offset: 0x00F3323E
		private void OnActivityDataInitComplete()
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.InitCurrency();
			}
			this.InitBlessingSlot();
			this.RefreshBlessingLayout();
		}

		// Token: 0x0603EF34 RID: 257844 RVA: 0x00F3505D File Offset: 0x00F3325D
		private void OnGainDataUpdate()
		{
			this.RefreshBlessingLayout();
		}

		// Token: 0x0603EF35 RID: 257845 RVA: 0x00F35068 File Offset: 0x00F33268
		private void OnDetailClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(null);
		}

		// Token: 0x0603EF36 RID: 257846 RVA: 0x00F35088 File Offset: 0x00F33288
		private void OnBlessClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(new EUiTabViewName?(EUiTabViewName.RoverlikeDetailBlessTabView));
		}

		// Token: 0x0603EF37 RID: 257847 RVA: 0x00F3509E File Offset: 0x00F3329E
		private void OnBtnBackClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikePauseView, null, null);
		}

		// Token: 0x0603EF38 RID: 257848 RVA: 0x00F350B4 File Offset: 0x00F332B4
		public void SetHighlightByBlessId(int blessId)
		{
			this.ClearHighlight();
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(blessId);
			if (blessConfig == null)
			{
				return;
			}
			GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			RoverlikeBlessingSlotItem layoutItemByKey = blessingLayout.GetLayoutItemByKey(blessConfig.Value.SlotId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.SetSelectOn(true);
		}

		// Token: 0x0603EF39 RID: 257849 RVA: 0x00F3510C File Offset: 0x00F3330C
		public void ClearHighlight()
		{
			GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
			foreach (RoverlikeBlessingSlotItem roverlikeBlessingSlotItem in (((blessingLayout != null) ? blessingLayout.GetLayoutItemList() : null) ?? new List<RoverlikeBlessingSlotItem>()))
			{
				roverlikeBlessingSlotItem.SetSelectOn(false);
			}
		}

		// Token: 0x04020DA9 RID: 134569
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> BlessingLayout;

		// Token: 0x04020DAA RID: 134570
		[Nullable(2)]
		protected RoverlikeTopCurrencyItem CurrencyItem;

		// Token: 0x04020DAB RID: 134571
		private List<int> BlessSlotIds = new List<int>();

		// Token: 0x04020DAC RID: 134572
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020DAD RID: 134573
		private bool RefreshEnabled;

		// Token: 0x04020DAE RID: 134574
		private bool AnimInitialized;

		// Token: 0x04020DAF RID: 134575
		private int CachedPassiveCount;

		// Token: 0x04020DB0 RID: 134576
		private readonly Dictionary<int, int> CachedSlotBlessMap = new Dictionary<int, int>();

		// Token: 0x0200C3A1 RID: 50081
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B08A RID: 241802
			public const int BtnCommon = 0;

			// Token: 0x0403B08B RID: 241803
			public const int ButtonLayout = 1;

			// Token: 0x0403B08C RID: 241804
			public const int BlessSlotLayout = 2;

			// Token: 0x0403B08D RID: 241805
			public const int BlessingItem = 3;

			// Token: 0x0403B08E RID: 241806
			public const int TxtPassiveBlessCount = 4;

			// Token: 0x0403B08F RID: 241807
			public const int ItemCurrency = 5;

			// Token: 0x0403B090 RID: 241808
			public const int BtnBack = 6;
		}
	}
}
