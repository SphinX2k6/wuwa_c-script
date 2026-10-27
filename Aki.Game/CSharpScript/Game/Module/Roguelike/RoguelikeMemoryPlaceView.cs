using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E14 RID: 19988
	public class RoguelikeMemoryPlaceView : UiViewBase
	{
		// Token: 0x060338FC RID: 211196 RVA: 0x00C0D932 File Offset: 0x00C0BB32
		[NullableContext(1)]
		public RoguelikeMemoryPlaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060338FD RID: 211197 RVA: 0x00C0D93B File Offset: 0x00C0BB3B
		[NullableContext(1)]
		private RoguelikeMemoryRewardItem CreateLoopScrollItem()
		{
			return new RoguelikeMemoryRewardItem();
		}

		// Token: 0x060338FE RID: 211198 RVA: 0x00C0D944 File Offset: 0x00C0BB44
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

		// Token: 0x060338FF RID: 211199 RVA: 0x00C0DAF8 File Offset: 0x00C0BCF8
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
			for (int i = 0; i < rogueSeasonReward.Count<Aki.Config.RogueSeasonReward>(); i++)
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

		// Token: 0x06033900 RID: 211200 RVA: 0x00C0DC18 File Offset: 0x00C0BE18
		private void OnBtnTokenOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeTokenOverView, this.SeasonData, null);
		}

		// Token: 0x06033901 RID: 211201 RVA: 0x00C0DC30 File Offset: 0x00C0BE30
		private void OnBtnAchievementViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeAchievementView, null, null);
		}

		// Token: 0x06033902 RID: 211202 RVA: 0x00C0DC44 File Offset: 0x00C0BE44
		protected void UpdateView()
		{
			int num = this.SeasonData.SeasonRewardList.Count<SeasonReward>();
			int pointItem = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.PointItem;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(pointItem, 0);
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Roguelike_MemoryPlace_Level", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Roguelike_MemoryPlace_Exp", new <>z__ReadOnlyArray<object>(new object[]
			{
				itemCountByConfigId,
				paramConfigBySeasonId.Value.PointItemMaxCount
			}));
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(this.SeasonData.SeasonId);
			List<AchievementGroupData> achievementCategoryGroups = AchievementModel.Instance.GetAchievementCategoryGroups(rogueSeasonConfigById.Value.Achievement, true);
			int num2 = 0;
			int num3 = 0;
			foreach (AchievementGroupData achievementGroupData in achievementCategoryGroups)
			{
				num3 += achievementGroupData.GetMaxProgress();
				num2 += achievementGroupData.GetCurrentProgress();
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Rogue_MemoryPlace_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2,
				num3
			}));
			int num4 = RoguelikeConfig.Instance.GetRogueTokenBySeasonId(this.SeasonData.SeasonId).Count<Aki.Config.RogueToken>();
			int num5 = this.SeasonData.RoguelikeTokenList.Count<RoguelikeToken>();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Rogue_MemoryPlace_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num5,
				num4
			}));
		}

		// Token: 0x0401B594 RID: 112020
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401B595 RID: 112021
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<RoguelikeMemoryRewardItem, RoguelikeMemoryRewardItemData> LoopScrollView;

		// Token: 0x0401B596 RID: 112022
		[Nullable(2)]
		protected SeasonData SeasonData;

		// Token: 0x0200AFAC RID: 44972
		private class ERoguelikeMemoryPlaceViewDefine
		{
			// Token: 0x0403554F RID: 218447
			public const int CaptionItem = 0;

			// Token: 0x04035550 RID: 218448
			public const int BtnTokenOverView = 1;

			// Token: 0x04035551 RID: 218449
			public const int BtnAchievementView = 2;

			// Token: 0x04035552 RID: 218450
			public const int TxtCurLevel = 3;

			// Token: 0x04035553 RID: 218451
			public const int TxtScore = 4;

			// Token: 0x04035554 RID: 218452
			public const int TxtAchievementCollect = 5;

			// Token: 0x04035555 RID: 218453
			public const int TxtTokenCollect = 6;

			// Token: 0x04035556 RID: 218454
			public const int LoopScrollView = 7;

			// Token: 0x04035557 RID: 218455
			public const int LoopScrollItem = 8;

			// Token: 0x04035558 RID: 218456
			public const int PanelBottom = 9;
		}
	}
}
