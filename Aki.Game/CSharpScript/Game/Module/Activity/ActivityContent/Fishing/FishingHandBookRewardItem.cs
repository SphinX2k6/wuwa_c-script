using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005592 RID: 21906
	public class FishingHandBookRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x0603648B RID: 222347 RVA: 0x00F23B10 File Offset: 0x00F21D10
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

		// Token: 0x0603648C RID: 222348 RVA: 0x00F23C9F File Offset: 0x00F21E9F
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, null);
		}

		// Token: 0x0603648D RID: 222349 RVA: 0x00F23CCF File Offset: 0x00F21ECF
		[NullableContext(1)]
		private CommonItemSmallItemGrid OnRewardLayoutUpdater()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603648E RID: 222350 RVA: 0x00F23CD8 File Offset: 0x00F21ED8
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

		// Token: 0x0603648F RID: 222351 RVA: 0x00F23F28 File Offset: 0x00F22128
		private void OnClickRewardBtn()
		{
			Dictionary<int, IFishingReward> fishingItemHandBookRewardMap = FishingModel.Instance.FishingItemHandBookRewardMap;
			List<int> list = new List<int>();
			foreach (IFishingReward fishingReward in fishingItemHandBookRewardMap.Values)
			{
				if (fishingReward.IsFinished && !fishingReward.IsTaken)
				{
					list.Add(fishingReward.Id);
				}
			}
			FishingController.Instance.RequestMultiFishingIllustratedRewardRequest(list.ToArray());
		}

		// Token: 0x06036490 RID: 222352 RVA: 0x00F23FB0 File Offset: 0x00F221B0
		private void OnClickJumpToBtn()
		{
			SkipTaskManager.RunByConfigId(FishingConfig.Instance.GetFishingIllustratedRewardById(this.RewardId).AccessPath, null);
		}

		// Token: 0x0401CA70 RID: 117360
		private const float TAKEN_ALPHA = 0.6f;

		// Token: 0x0401CA71 RID: 117361
		private int RewardId;

		// Token: 0x0401CA72 RID: 117362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200B206 RID: 45574
		private class EComponentDefine
		{
			// Token: 0x04037064 RID: 225380
			public const int RewardBtn = 0;

			// Token: 0x04037065 RID: 225381
			public const int JumpToBtn = 1;

			// Token: 0x04037066 RID: 225382
			public const int DoingItem = 2;

			// Token: 0x04037067 RID: 225383
			public const int FinishItem = 3;

			// Token: 0x04037068 RID: 225384
			public const int TitleText = 4;

			// Token: 0x04037069 RID: 225385
			public const int CountText = 5;

			// Token: 0x0403706A RID: 225386
			public const int ItemScrollView = 6;

			// Token: 0x0403706B RID: 225387
			public const int EmptyItem = 7;
		}
	}
}
