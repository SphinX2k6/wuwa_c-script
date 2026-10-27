using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006614 RID: 26132
	public class FishingHandBookRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x060417C6 RID: 268230 RVA: 0x00FDCA84 File Offset: 0x00FDAC84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickJumpToBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060417C7 RID: 268231 RVA: 0x00FDCC13 File Offset: 0x00FDAE13
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, null);
		}

		// Token: 0x060417C8 RID: 268232 RVA: 0x00FDCC43 File Offset: 0x00FDAE43
		[NullableContext(1)]
		private CommonItemSmallItemGrid OnRewardLayoutUpdater()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x060417C9 RID: 268233 RVA: 0x00FDCC4C File Offset: 0x00FDAE4C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.RewardId = data;
			IFishingReward fishingReward2;
			IFishingReward fishingReward = FishingModel.Instance.FishingItemHandBookRewardMap.TryGetValue(this.RewardId, out fishingReward2) ? fishingReward2 : null;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
			if (fishingReward != null && fishingReward.IsTaken)
			{
				UUIItem item2 = base.GetItem(3);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				base.GetItem(7).SetAlpha(0.6f);
			}
			else if (fishingReward != null && fishingReward.IsFinished)
			{
				UUIButtonComponent button3 = base.GetButton(0);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(true);
				}
				base.GetItem(7).SetAlpha(1f);
			}
			else
			{
				UUIButtonComponent button4 = base.GetButton(1);
				if (button4 != null)
				{
					button4.RootUIComp.Get().SetUIActive(true);
				}
				base.GetItem(7).SetAlpha(1f);
			}
			UUIText text = base.GetText(5);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int?>((fishingReward != null) ? new int?(fishingReward.Current) : null);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int?>((fishingReward != null) ? new int?(fishingReward.Target) : null);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			FishingIllustratedReward fishingIllustratedRewardById = FishingConfig.Instance.GetFishingIllustratedRewardById(this.RewardId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), fishingIllustratedRewardById.Desc, Array.Empty<object>());
			Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(fishingIllustratedRewardById.DropId);
			List<TItem> list = new List<TItem>();
			foreach (int num in dropShowInfo.Keys)
			{
				TItem item3 = new TItem(new InventoryDefine.GetItemData(num, 0), dropShowInfo[num]);
				list.Add(item3);
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x060417CA RID: 268234 RVA: 0x00FDCE9C File Offset: 0x00FDB09C
		private void OnClickRewardBtn()
		{
			List<int> list = (from v in FishingModel.Instance.FishingItemHandBookRewardMap.Values
			where v.IsFinished && !v.IsTaken
			select v.Id).ToList<int>();
			FishingController.Instance.RequestMultiFishingIllustratedRewardRequest(list.ToArray());
		}

		// Token: 0x060417CB RID: 268235 RVA: 0x00FDCF18 File Offset: 0x00FDB118
		private void OnClickJumpToBtn()
		{
			SkipTaskManager.RunByConfigId(FishingConfig.Instance.GetFishingIllustratedRewardById(this.RewardId).AccessPath, null);
		}

		// Token: 0x0402213F RID: 139583
		private const float TAKEN_ALPHA = 0.6f;

		// Token: 0x04022140 RID: 139584
		private int RewardId;

		// Token: 0x04022141 RID: 139585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200C823 RID: 51235
		private class EComponentDefine
		{
			// Token: 0x0403C71C RID: 247580
			public const int RewardBtn = 0;

			// Token: 0x0403C71D RID: 247581
			public const int JumpToBtn = 1;

			// Token: 0x0403C71E RID: 247582
			public const int DoingItem = 2;

			// Token: 0x0403C71F RID: 247583
			public const int FinishItem = 3;

			// Token: 0x0403C720 RID: 247584
			public const int TitleText = 4;

			// Token: 0x0403C721 RID: 247585
			public const int CountText = 5;

			// Token: 0x0403C722 RID: 247586
			public const int ItemScrollView = 6;

			// Token: 0x0403C723 RID: 247587
			public const int EmptyItem = 7;
		}
	}
}
