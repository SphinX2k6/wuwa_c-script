using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F56 RID: 20310
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonReviewView : UiViewBase
	{
		// Token: 0x06032FF5 RID: 208885 RVA: 0x00E4AE53 File Offset: 0x00E49053
		public WheelTowerSeasonReviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032FF6 RID: 208886 RVA: 0x00E4AE5C File Offset: 0x00E4905C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnConfirmBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnShareBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032FF7 RID: 208887 RVA: 0x00E4B010 File Offset: 0x00E49210
		protected override void OnStart()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("S");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSeasonId());
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "NewTower_medalreview", new <>z__ReadOnlySingleElementList<object>(item));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "NewTower_SeasonMedal", new <>z__ReadOnlySingleElementList<object>(item));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "NewTower_Endlessmodereview", new <>z__ReadOnlySingleElementList<object>(item));
			this.MedalLayout = new GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData>(base.GetHorizontalLayout(2), new Func<WheelTowerSeasonMedalItem>(this.CreateMedalItem), null, false, true);
			this.ScoreLayout = new GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData>(base.GetHorizontalLayout(5), new Func<WheelTowerStageMedalItem>(this.CreateScoreMedalItem), null, false, true);
			this.RefreshMedalLayout();
			this.RefreshScoreLayout();
		}

		// Token: 0x06032FF8 RID: 208888 RVA: 0x00E4B0EC File Offset: 0x00E492EC
		private void RefreshMedalLayout()
		{
			int seasonId = this.GetSeasonId();
			List<IWheelTowerMedalGroupData> seasonMedalGroupList = WheelTowerModel.Instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
			List<IWheelTowerMedalItemData> list = new List<IWheelTowerMedalItemData>();
			for (int i = 0; i < seasonMedalGroupList.Count; i++)
			{
				list.Add(new WheelTowerMedalItemData
				{
					GroupId = seasonMedalGroupList[i].GroupId,
					IsLast = new bool?(i == seasonMedalGroupList.Count - 1),
					DisableInteract = new bool?(true),
					HideDetails = new bool?(true),
					HideMedalPnl = true
				});
			}
			GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> medalLayout = this.MedalLayout;
			if (medalLayout == null)
			{
				return;
			}
			medalLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06032FF9 RID: 208889 RVA: 0x00E4B18C File Offset: 0x00E4938C
		private void RefreshScoreLayout()
		{
			int seasonId = this.GetSeasonId();
			List<IWheelTowerMedalGroupData> seasonMedalGroupList = WheelTowerModel.Instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Stage);
			List<IWheelTowerMedalItemData> list = new List<IWheelTowerMedalItemData>();
			for (int i = 0; i < seasonMedalGroupList.Count; i++)
			{
				list.Add(new WheelTowerMedalItemData
				{
					GroupId = seasonMedalGroupList[i].GroupId,
					IsLast = new bool?(i == seasonMedalGroupList.Count - 1),
					DisableInteract = new bool?(true)
				});
			}
			GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> scoreLayout = this.ScoreLayout;
			if (scoreLayout == null)
			{
				return;
			}
			scoreLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06032FFA RID: 208890 RVA: 0x00E4B216 File Offset: 0x00E49416
		private int GetSeasonId()
		{
			WheelTowerSeasonReviewViewData wheelTowerSeasonReviewViewData = this.OpenParam as WheelTowerSeasonReviewViewData;
			if (wheelTowerSeasonReviewViewData != null)
			{
				return wheelTowerSeasonReviewViewData.SeasonId;
			}
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			if (activityData == null)
			{
				return 0;
			}
			return activityData.SeasonId;
		}

		// Token: 0x06032FFB RID: 208891 RVA: 0x00E4B242 File Offset: 0x00E49442
		private WheelTowerSeasonMedalItem CreateMedalItem()
		{
			return new WheelTowerSeasonMedalItem();
		}

		// Token: 0x06032FFC RID: 208892 RVA: 0x00E4B249 File Offset: 0x00E49449
		private WheelTowerStageMedalItem CreateScoreMedalItem()
		{
			return new WheelTowerStageMedalItem();
		}

		// Token: 0x06032FFD RID: 208893 RVA: 0x00E4B250 File Offset: 0x00E49450
		private void OnConfirmBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032FFE RID: 208894 RVA: 0x00E4B259 File Offset: 0x00E49459
		private void OnShareBtnClick()
		{
			WheelTowerController.Instance.OpenSeasonMedalView(this.GetSeasonId(), true);
		}

		// Token: 0x0401B0FF RID: 110847
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> MedalLayout;

		// Token: 0x0401B100 RID: 110848
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> ScoreLayout;
	}
}
