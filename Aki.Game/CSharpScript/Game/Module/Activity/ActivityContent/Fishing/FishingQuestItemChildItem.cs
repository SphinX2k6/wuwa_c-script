using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005599 RID: 21913
	public class FishingQuestItemChildItem : GridProxyAbstract<int>
	{
		// Token: 0x0603653A RID: 222522 RVA: 0x00F28BE0 File Offset: 0x00F26DE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603653B RID: 222523 RVA: 0x00F28E80 File Offset: 0x00F27080
		protected override void OnStart()
		{
			this.OnAddEventListener();
			base.GetSprite(11).SetUIActive(false);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603653C RID: 222524 RVA: 0x00F28EDC File Offset: 0x00F270DC
		protected override void OnBeforeDestroy()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x0603653D RID: 222525 RVA: 0x00F28EE4 File Offset: 0x00F270E4
		protected void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x0603653E RID: 222526 RVA: 0x00F28F02 File Offset: 0x00F27102
		protected void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x0603653F RID: 222527 RVA: 0x00F28F20 File Offset: 0x00F27120
		private void FishingRefreshQuestView(bool keepSelect, int? i = null)
		{
			if (keepSelect)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x06036540 RID: 222528 RVA: 0x00F28F2B File Offset: 0x00F2712B
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.EntrustId = data;
			this.RefreshItem();
		}

		// Token: 0x06036541 RID: 222529 RVA: 0x00F28F3C File Offset: 0x00F2713C
		public void RefreshItem()
		{
			if (this.EntrustId == -1)
			{
				this.ShowNullItem();
				return;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.EntrustId);
			if (fishingEntrust == null)
			{
				return;
			}
			base.GetText(15).SetUIActive(false);
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), fishingEntrust.Value.Name, Array.Empty<object>());
			base.GetItem(0).SetUIActive(this.EntrustId == FishingQuestModel.Instance.CurrentTraceEntrust);
			base.GetItem(5).SetColor(FColor.FromHex(FishingDefine.fishingQuestPoolColorText[fishingEntrust.Value.EntrustPool]));
			if (fishingEntrust.Value.EntrustType == 0 || fishingEntrust.Value.EntrustType == 1)
			{
				Dictionary<int, int> dictionary = fishingEntrust.Value.EntrustTarget();
				int num = 0;
				int num2 = 0;
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					int num3;
					int num4;
					keyValuePair.Deconstruct(out num3, out num4);
					int itemId = num3;
					int num5 = num4;
					int itemCountByItemId = DockyardModel.Instance.GetItemCountByItemId(itemId);
					num += num5;
					num2 += Math.Min(itemCountByItemId, num5);
				}
				UUIText text = base.GetText(9);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			else if (fishingEntrust.Value.EntrustType == 2)
			{
				base.GetText(9).SetUIActive(false);
			}
			base.GetItem(16).SetUIActive(fishingEntrust.Value.IsNight);
			this.RefreshStateAbout();
		}

		// Token: 0x06036542 RID: 222530 RVA: 0x00F29120 File Offset: 0x00F27320
		private void RefreshStateAbout()
		{
			if (this.EntrustId == -1)
			{
				return;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.EntrustId);
			if (fishingEntrust == null)
			{
				return;
			}
			bool flag = fishingEntrust.Value.EntrustPool == 2;
			bool entrustsLockState = FishingQuestModel.Instance.GetEntrustsLockState(this.EntrustId);
			if (!flag)
			{
				base.GetText(3).SetUIActive(true);
				int star = fishingEntrust.Value.Star;
				this.RefreshStarCount(star);
				this.RefreshStateText();
			}
			else
			{
				base.GetItem(1).SetUIActive(entrustsLockState);
				base.GetText(9).SetUIActive(!entrustsLockState);
				base.GetItem(6).SetUIActive(false);
				base.GetText(3).SetUIActive(false);
				foreach (UUIItem uuiitem in this.StarList)
				{
					uuiitem.SetUIActive(false);
				}
			}
			this.RefreshTime(flag);
			base.GetItem(1).SetUIActive(entrustsLockState);
			base.GetText(9).SetUIActive(!entrustsLockState);
		}

		// Token: 0x06036543 RID: 222531 RVA: 0x00F2924C File Offset: 0x00F2744C
		public void RefreshStateText()
		{
			EFishingEntrustState efishingEntrustState;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.EntrustId, out efishingEntrustState))
			{
				efishingEntrustState = efishingEntrustState;
			}
			else
			{
				efishingEntrustState = EFishingEntrustState.UnAcceptable;
			}
			base.GetText(3).SetUIActive(true);
			if (base.GetExtendToggle(4).GetToggleState() != EToggleState.ETT_Checked)
			{
				base.GetText(3).SetColor(FColor.FromHex(FishingDefine.fishingStateColorText[(int)efishingEntrustState]));
			}
			else
			{
				base.GetText(3).SetColor(FColor.FromHex(FishingDefine.fishingSelectStateColorText[(int)efishingEntrustState]));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), FishingDefine.fishingStateText[(int)efishingEntrustState], Array.Empty<object>());
			base.GetItem(6).SetUIActive(efishingEntrustState == EFishingEntrustState.Deliverable);
		}

		// Token: 0x06036544 RID: 222532 RVA: 0x00F29300 File Offset: 0x00F27500
		private void ShowNullItem()
		{
			base.GetText(15).SetUIActive(true);
			base.GetText(2).SetUIActive(false);
			base.GetItem(0).SetUIActive(false);
			base.GetText(3).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
			base.GetText(9).SetUIActive(false);
			base.GetText(14).SetUIActive(false);
			base.GetItem(16).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(5).SetColor(FColor.FromHex(FishingDefine.fishingQuestPoolColorText[4]));
			foreach (UUIItem uuiitem in this.StarList)
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x06036545 RID: 222533 RVA: 0x00F293E8 File Offset: 0x00F275E8
		private void RefreshStarCount(int count)
		{
			foreach (UUIItem uuiitem in this.StarList)
			{
				uuiitem.SetUIActive(false);
			}
			for (int i = 0; i < count; i++)
			{
				UUIItem item = base.GetItem(8);
				if (i + 1 > this.StarList.Count)
				{
					UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(base.GetItem(13), item);
					uuiitem2.SetUIActive(true);
					this.StarList.Add(uuiitem2);
				}
				else
				{
					this.StarList[i].SetUIActive(true);
				}
			}
		}

		// Token: 0x06036546 RID: 222534 RVA: 0x00F29498 File Offset: 0x00F27698
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int, UUIExtendToggle, Action> onClickTaskCallBack = this.OnClickTaskCallBack;
			if (onClickTaskCallBack != null)
			{
				onClickTaskCallBack(this.EntrustId, base.GetExtendToggle(4), new Action(this.OnUnSelect));
			}
			EFishingEntrustState efishingEntrustState;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.EntrustId, out efishingEntrustState))
			{
				efishingEntrustState = efishingEntrustState;
			}
			else
			{
				efishingEntrustState = EFishingEntrustState.UnAcceptable;
			}
			base.GetText(3).SetColor(FColor.FromHex(FishingDefine.fishingSelectStateColorText[(int)efishingEntrustState]));
		}

		// Token: 0x06036547 RID: 222535 RVA: 0x00F2950C File Offset: 0x00F2770C
		public void SelectToggle()
		{
			base.GetExtendToggle(4).SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
			Action<int, UUIExtendToggle, Action> onClickTaskCallBack = this.OnClickTaskCallBack;
			if (onClickTaskCallBack != null)
			{
				onClickTaskCallBack(this.EntrustId, base.GetExtendToggle(4), new Action(this.OnUnSelect));
			}
			EFishingEntrustState efishingEntrustState;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.EntrustId, out efishingEntrustState))
			{
				efishingEntrustState = efishingEntrustState;
			}
			else
			{
				efishingEntrustState = EFishingEntrustState.UnAcceptable;
			}
			base.GetText(3).SetColor(FColor.FromHex(FishingDefine.fishingSelectStateColorText[(int)efishingEntrustState]));
		}

		// Token: 0x06036548 RID: 222536 RVA: 0x00F29590 File Offset: 0x00F27790
		private void OnUnSelect()
		{
			EFishingEntrustState efishingEntrustState;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.EntrustId, out efishingEntrustState))
			{
				efishingEntrustState = efishingEntrustState;
			}
			else
			{
				efishingEntrustState = EFishingEntrustState.UnAcceptable;
			}
			base.GetText(3).SetColor(FColor.FromHex(FishingDefine.fishingStateColorText[(int)efishingEntrustState]));
		}

		// Token: 0x06036549 RID: 222537 RVA: 0x00F295D8 File Offset: 0x00F277D8
		private void RefreshTime(bool isShow)
		{
			if (!isShow)
			{
				base.GetText(14).SetUIActive(false);
				return;
			}
			base.GetText(14).SetUIActive(true);
			double nextDayTimeStamp = TimeUtil.Instance.GetNextDayTimeStamp();
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			int num = (int)Math.Ceiling((nextDayTimeStamp - serverTimeStamp) * TimeUtil.Instance.Millisecond / TimeUtil.Instance.Hour);
			if (num <= 1)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "FishingEntrustRefreshRemainTimeInOneHour", new <>z__ReadOnlySingleElementList<object>(num));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "FishingEntrustRefreshRemainTime", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0401CAB7 RID: 117431
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<int, UUIExtendToggle, Action> OnClickTaskCallBack;

		// Token: 0x0401CAB8 RID: 117432
		private int EntrustId;

		// Token: 0x0401CAB9 RID: 117433
		[Nullable(1)]
		private readonly List<UUIItem> StarList = new List<UUIItem>();

		// Token: 0x0200B212 RID: 45586
		private class EComponentDefine
		{
			// Token: 0x040370A0 RID: 225440
			public const int TraceItem = 0;

			// Token: 0x040370A1 RID: 225441
			public const int LockItem = 1;

			// Token: 0x040370A2 RID: 225442
			public const int NameText = 2;

			// Token: 0x040370A3 RID: 225443
			public const int StateText = 3;

			// Token: 0x040370A4 RID: 225444
			public const int Toggle = 4;

			// Token: 0x040370A5 RID: 225445
			public const int QualityColorItem = 5;

			// Token: 0x040370A6 RID: 225446
			public const int RedDotItem = 6;

			// Token: 0x040370A7 RID: 225447
			public const int CircleSprite = 7;

			// Token: 0x040370A8 RID: 225448
			public const int StarPanelItem = 8;

			// Token: 0x040370A9 RID: 225449
			public const int TargetText = 9;

			// Token: 0x040370AA RID: 225450
			public const int IconItem = 10;

			// Token: 0x040370AB RID: 225451
			public const int IconSprite = 11;

			// Token: 0x040370AC RID: 225452
			public const int TagItem = 12;

			// Token: 0x040370AD RID: 225453
			public const int StarItem = 13;

			// Token: 0x040370AE RID: 225454
			public const int RefreshTimeText = 14;

			// Token: 0x040370AF RID: 225455
			public const int LockText = 15;

			// Token: 0x040370B0 RID: 225456
			public const int NightItem = 16;
		}
	}
}
