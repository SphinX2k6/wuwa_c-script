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
	// Token: 0x0200661B RID: 26139
	public class FishingQuestItemChildItem : GridProxyAbstract<int>
	{
		// Token: 0x06041875 RID: 268405 RVA: 0x00FE1B6C File Offset: 0x00FDFD6C
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

		// Token: 0x06041876 RID: 268406 RVA: 0x00FE1E0C File Offset: 0x00FE000C
		protected override void OnStart()
		{
			this.OnAddEventListener();
			base.GetSprite(11).SetUIActive(false);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06041877 RID: 268407 RVA: 0x00FE1E68 File Offset: 0x00FE0068
		protected override void OnBeforeDestroy()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x06041878 RID: 268408 RVA: 0x00FE1E70 File Offset: 0x00FE0070
		protected void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x06041879 RID: 268409 RVA: 0x00FE1E8E File Offset: 0x00FE008E
		protected void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x0604187A RID: 268410 RVA: 0x00FE1EAC File Offset: 0x00FE00AC
		private void FishingRefreshQuestView(bool keepSelect, int? i = null)
		{
			if (keepSelect)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x0604187B RID: 268411 RVA: 0x00FE1EB7 File Offset: 0x00FE00B7
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.EntrustId = data;
			this.RefreshItem();
		}

		// Token: 0x0604187C RID: 268412 RVA: 0x00FE1EC8 File Offset: 0x00FE00C8
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

		// Token: 0x0604187D RID: 268413 RVA: 0x00FE20AC File Offset: 0x00FE02AC
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

		// Token: 0x0604187E RID: 268414 RVA: 0x00FE21D8 File Offset: 0x00FE03D8
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

		// Token: 0x0604187F RID: 268415 RVA: 0x00FE228C File Offset: 0x00FE048C
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

		// Token: 0x06041880 RID: 268416 RVA: 0x00FE2374 File Offset: 0x00FE0574
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

		// Token: 0x06041881 RID: 268417 RVA: 0x00FE2424 File Offset: 0x00FE0624
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

		// Token: 0x06041882 RID: 268418 RVA: 0x00FE2498 File Offset: 0x00FE0698
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

		// Token: 0x06041883 RID: 268419 RVA: 0x00FE251C File Offset: 0x00FE071C
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

		// Token: 0x06041884 RID: 268420 RVA: 0x00FE2564 File Offset: 0x00FE0764
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

		// Token: 0x04022186 RID: 139654
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<int, UUIExtendToggle, Action> OnClickTaskCallBack;

		// Token: 0x04022187 RID: 139655
		private int EntrustId;

		// Token: 0x04022188 RID: 139656
		[Nullable(1)]
		private readonly List<UUIItem> StarList = new List<UUIItem>();

		// Token: 0x0200C830 RID: 51248
		private class EComponentDefine
		{
			// Token: 0x0403C75B RID: 247643
			public const int TraceItem = 0;

			// Token: 0x0403C75C RID: 247644
			public const int LockItem = 1;

			// Token: 0x0403C75D RID: 247645
			public const int NameText = 2;

			// Token: 0x0403C75E RID: 247646
			public const int StateText = 3;

			// Token: 0x0403C75F RID: 247647
			public const int Toggle = 4;

			// Token: 0x0403C760 RID: 247648
			public const int QualityColorItem = 5;

			// Token: 0x0403C761 RID: 247649
			public const int RedDotItem = 6;

			// Token: 0x0403C762 RID: 247650
			public const int CircleSprite = 7;

			// Token: 0x0403C763 RID: 247651
			public const int StarPanelItem = 8;

			// Token: 0x0403C764 RID: 247652
			public const int TargetText = 9;

			// Token: 0x0403C765 RID: 247653
			public const int IconItem = 10;

			// Token: 0x0403C766 RID: 247654
			public const int IconSprite = 11;

			// Token: 0x0403C767 RID: 247655
			public const int TagItem = 12;

			// Token: 0x0403C768 RID: 247656
			public const int StarItem = 13;

			// Token: 0x0403C769 RID: 247657
			public const int RefreshTimeText = 14;

			// Token: 0x0403C76A RID: 247658
			public const int LockText = 15;

			// Token: 0x0403C76B RID: 247659
			public const int NightItem = 16;
		}
	}
}
