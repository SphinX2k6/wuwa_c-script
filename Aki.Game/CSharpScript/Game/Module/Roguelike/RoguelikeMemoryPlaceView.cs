using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DDD RID: 15837
	public class RoguelikeMemoryPlaceView : UiViewBase
	{
		// Token: 0x06028767 RID: 165735 RVA: 0x00B56E3E File Offset: 0x00B5503E
		[NullableContext(1)]
		public RoguelikeMemoryPlaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028768 RID: 165736 RVA: 0x00B56E47 File Offset: 0x00B55047
		[NullableContext(1)]
		private RoguelikeMemoryRewardItem CreateLoopScrollItem()
		{
			return new RoguelikeMemoryRewardItem();
		}

		// Token: 0x06028769 RID: 165737 RVA: 0x00B56E50 File Offset: 0x00B55050
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnTokenOverViewClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnAchievementViewClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602876A RID: 165738 RVA: 0x00B57004 File Offset: 0x00B55204
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			});
			this.LoopScrollView = new LoopScrollView<RoguelikeMemoryRewardItem, RoguelikeMemoryRewardItemData>(base.GetLoopScrollViewComponent(7), base.GetItem(8).GetOwner() as AUIBaseActor, new Func<RoguelikeMemoryRewardItem>(this.CreateLoopScrollItem), false);
			base.GetLoopScrollViewComponent(7).RootUIComp.Get().GetParentAsUIItem().SetUIActive(false);
			this.CaptionItem.SetHelpBtnActive(false);
			this.SeasonData = (this.OpenParam as SeasonData);
			IReadOnlyList<Aki.Config.RogueSeasonReward> rogueSeasonReward = RoguelikeConfig.Instance.GetRogueSeasonReward(this.SeasonData.SeasonId);
			List<RoguelikeMemoryRewardItemData> list = new List<RoguelikeMemoryRewardItemData>();
			for (int i = 0; i < rogueSeasonReward.Count; i++)
			{
				Aki.Config.RogueSeasonReward value = rogueSeasonReward[i];
				list.Add(new RoguelikeMemoryRewardItemData
				{
					SeasonReward = this.SeasonData.SeasonRewardList[i],
					Config = new Aki.Config.RogueSeasonReward?(value)
				});
			}
			this.LoopScrollView.ReloadData(list, false);
			this.UpdateView();
		}

		// Token: 0x0602876B RID: 165739 RVA: 0x00B57124 File Offset: 0x00B55324
		private void OnBtnTokenOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeTokenOverView, this.SeasonData, null);
		}

		// Token: 0x0602876C RID: 165740 RVA: 0x00B5713C File Offset: 0x00B5533C
		private void OnBtnAchievementViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeAchievementView, null, null);
		}

		// Token: 0x0602876D RID: 165741 RVA: 0x00B57150 File Offset: 0x00B55350
		protected void UpdateView()
		{
			int count = this.SeasonData.SeasonRewardList.Count;
			int pointItem = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.PointItem;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(pointItem, 0);
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Roguelike_MemoryPlace_Level", new <>z__ReadOnlySingleElementList<object>(count.ToString()));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Roguelike_MemoryPlace_Exp", new <>z__ReadOnlyArray<object>(new object[]
			{
				itemCountByConfigId,
				paramConfigBySeasonId.Value.PointItemMaxCount
			}));
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(this.SeasonData.SeasonId);
			List<AchievementGroupData> achievementCategoryGroups = AchievementModel.Instance.GetAchievementCategoryGroups(rogueSeasonConfigById.Value.Achievement, true);
			int num = 0;
			int num2 = 0;
			foreach (AchievementGroupData achievementGroupData in achievementCategoryGroups)
			{
				num2 += achievementGroupData.GetMaxProgress();
				num += achievementGroupData.GetCurrentProgress();
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Rogue_MemoryPlace_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
			int count2 = RoguelikeConfig.Instance.GetRogueTokenBySeasonId(this.SeasonData.SeasonId).Count;
			int count3 = this.SeasonData.RoguelikeTokenList.Count;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Rogue_MemoryPlace_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				count3,
				count2
			}));
		}

		// Token: 0x04015F67 RID: 89959
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04015F68 RID: 89960
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<RoguelikeMemoryRewardItem, RoguelikeMemoryRewardItemData> LoopScrollView;

		// Token: 0x04015F69 RID: 89961
		[Nullable(2)]
		protected SeasonData SeasonData;

		// Token: 0x020099E1 RID: 39393
		private class ERoguelikeMemoryPlaceViewDefine
		{
			// Token: 0x0402FF82 RID: 196482
			public const int CaptionItem = 0;

			// Token: 0x0402FF83 RID: 196483
			public const int BtnTokenOverView = 1;

			// Token: 0x0402FF84 RID: 196484
			public const int BtnAchievementView = 2;

			// Token: 0x0402FF85 RID: 196485
			public const int TxtCurLevel = 3;

			// Token: 0x0402FF86 RID: 196486
			public const int TxtScore = 4;

			// Token: 0x0402FF87 RID: 196487
			public const int TxtAchievementCollect = 5;

			// Token: 0x0402FF88 RID: 196488
			public const int TxtTokenCollect = 6;

			// Token: 0x0402FF89 RID: 196489
			public const int LoopScrollView = 7;

			// Token: 0x0402FF8A RID: 196490
			public const int LoopScrollItem = 8;

			// Token: 0x0402FF8B RID: 196491
			public const int PanelBottom = 9;
		}
	}
}
