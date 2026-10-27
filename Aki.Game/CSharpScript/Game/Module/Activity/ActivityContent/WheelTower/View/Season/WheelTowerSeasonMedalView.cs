using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F67 RID: 24423
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonMedalView : UiViewBase
	{
		// Token: 0x0603E01D RID: 253981 RVA: 0x00EF7BB5 File Offset: 0x00EF5DB5
		public WheelTowerSeasonMedalView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E01E RID: 253982 RVA: 0x00EF7BE8 File Offset: 0x00EF5DE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnAllSeasonBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnShareBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603E01F RID: 253983 RVA: 0x00EF7E88 File Offset: 0x00EF6088
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerSeasonMedalView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E020 RID: 253984 RVA: 0x00EF7ECC File Offset: 0x00EF60CC
		private UniTask LoadSeasonBgItem()
		{
			WheelTowerSeasonMedalView.<LoadSeasonBgItem>d__11 <LoadSeasonBgItem>d__;
			<LoadSeasonBgItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSeasonBgItem>d__.<>4__this = this;
			<LoadSeasonBgItem>d__.<>1__state = -1;
			<LoadSeasonBgItem>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<LoadSeasonBgItem>d__11>(ref <LoadSeasonBgItem>d__);
			return <LoadSeasonBgItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603E021 RID: 253985 RVA: 0x00EF7F0F File Offset: 0x00EF610F
		protected override void OnStart()
		{
			this.ReportEnterMedalEvent();
		}

		// Token: 0x0603E022 RID: 253986 RVA: 0x00EF7F18 File Offset: 0x00EF6118
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			WheelTowerSeasonMedalView.<OnPlayingStartSequenceAsync>d__13 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnPlayingStartSequenceAsync>d__13>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E023 RID: 253987 RVA: 0x00EF7F5C File Offset: 0x00EF615C
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			WheelTowerSeasonMedalView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E024 RID: 253988 RVA: 0x00EF7F9F File Offset: 0x00EF619F
		protected override void OnBeforeShow()
		{
			if (!this.IsFirstShow)
			{
				this.RefreshMedalLayout();
				this.RefreshScoreLayout();
			}
			else
			{
				this.IsFirstShow = false;
			}
			this.RefreshSeasonInfo();
			this.RefreshAllSeasonBtn();
		}

		// Token: 0x0603E025 RID: 253989 RVA: 0x00EF7FCC File Offset: 0x00EF61CC
		private void ReportEnterMedalEvent()
		{
			NewTowerEnterMedalEvent newTowerEnterMedalEvent = new NewTowerEnterMedalEvent();
			newTowerEnterMedalEvent.i_activity_id = WheelTowerModel.Instance.ActivityData.Id;
			newTowerEnterMedalEvent.i_season_id = this.GetSeasonId();
			LogReportController.Instance.LogReport(newTowerEnterMedalEvent);
		}

		// Token: 0x0603E026 RID: 253990 RVA: 0x00EF800C File Offset: 0x00EF620C
		private void MarkSeasonMedalsRead()
		{
			int seasonId = this.GetSeasonId();
			WheelTowerModel.Instance.MarkSeasonMedalsRead(seasonId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, WheelTowerModel.Instance.ActivityData.Id);
		}

		// Token: 0x0603E027 RID: 253991 RVA: 0x00EF804C File Offset: 0x00EF624C
		private void SnapshotOldMedalIds()
		{
			this.OldMedalIdMap.Clear();
			WheelTowerModel instance = WheelTowerModel.Instance;
			foreach (IWheelTowerMedalItemData wheelTowerMedalItemData in this.MedalItemDataList)
			{
				int seasonMedalReadId = instance.GetSeasonMedalReadId(wheelTowerMedalItemData.GroupId);
				if (seasonMedalReadId != 0)
				{
					this.OldMedalIdMap[wheelTowerMedalItemData.GroupId] = seasonMedalReadId;
				}
			}
			foreach (IWheelTowerMedalItemData wheelTowerMedalItemData2 in this.ScoreItemDataList)
			{
				int seasonMedalReadId2 = instance.GetSeasonMedalReadId(wheelTowerMedalItemData2.GroupId);
				if (seasonMedalReadId2 != 0)
				{
					this.OldMedalIdMap[wheelTowerMedalItemData2.GroupId] = seasonMedalReadId2;
				}
			}
		}

		// Token: 0x0603E028 RID: 253992 RVA: 0x00EF8130 File Offset: 0x00EF6330
		private void ApplyPreviewMedalIds()
		{
			GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> medalLayout = this.MedalLayout;
			foreach (WheelTowerSeasonMedalItem wheelTowerSeasonMedalItem in (((medalLayout != null) ? medalLayout.GetLayoutItemList() : null) ?? new List<WheelTowerSeasonMedalItem>()))
			{
				if (wheelTowerSeasonMedalItem.GridIndex >= 0 && wheelTowerSeasonMedalItem.GridIndex < this.MedalItemDataList.Count)
				{
					IWheelTowerMedalItemData wheelTowerMedalItemData = this.MedalItemDataList[wheelTowerSeasonMedalItem.GridIndex];
					int previewMedalId;
					this.OldMedalIdMap.TryGetValue(wheelTowerMedalItemData.GroupId, out previewMedalId);
					wheelTowerSeasonMedalItem.SetPreviewMedalId(previewMedalId);
				}
			}
			GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> scoreLayout = this.ScoreLayout;
			foreach (WheelTowerStageMedalItem wheelTowerStageMedalItem in (((scoreLayout != null) ? scoreLayout.GetLayoutItemList() : null) ?? new List<WheelTowerStageMedalItem>()))
			{
				if (wheelTowerStageMedalItem.GridIndex >= 0 && wheelTowerStageMedalItem.GridIndex < this.ScoreItemDataList.Count)
				{
					IWheelTowerMedalItemData wheelTowerMedalItemData2 = this.ScoreItemDataList[wheelTowerStageMedalItem.GridIndex];
					int previewMedalId2;
					this.OldMedalIdMap.TryGetValue(wheelTowerMedalItemData2.GroupId, out previewMedalId2);
					wheelTowerStageMedalItem.SetPreviewMedalId(previewMedalId2);
				}
			}
		}

		// Token: 0x0603E029 RID: 253993 RVA: 0x00EF827C File Offset: 0x00EF647C
		private void TryAutoShare()
		{
			WheelTowerSeasonMedalViewData wheelTowerSeasonMedalViewData = this.OpenParam as WheelTowerSeasonMedalViewData;
			if (wheelTowerSeasonMedalViewData == null || !wheelTowerSeasonMedalViewData.AutoShare)
			{
				return;
			}
			this.OpenShareView();
		}

		// Token: 0x0603E02A RID: 253994 RVA: 0x00EF82A8 File Offset: 0x00EF64A8
		private void RefreshAllSeasonBtn()
		{
			WheelTowerSeasonMedalViewData wheelTowerSeasonMedalViewData = this.OpenParam as WheelTowerSeasonMedalViewData;
			bool flag = wheelTowerSeasonMedalViewData != null && wheelTowerSeasonMedalViewData.HideAllSeasonBtn;
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			UUIItem rootComponent = button.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(!flag);
		}

		// Token: 0x0603E02B RID: 253995 RVA: 0x00EF82EC File Offset: 0x00EF64EC
		private void RefreshSeasonInfo()
		{
			int seasonId = this.GetSeasonId();
			if (seasonId == 0)
			{
				return;
			}
			NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(seasonId);
			if (seasonConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), seasonConfig.Value.Name, Array.Empty<object>());
			base.SetTextureByPath(seasonConfig.Value.VersionIconMain, base.GetTexture(4), null, null);
			UUISprite sprite = base.GetSprite(14);
			if (sprite != null)
			{
				sprite.SetUIActive(this.IsCurrentSeason());
			}
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			int num = (activityData != null) ? activityData.SeasonId : 0;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(seasonId <= num);
			}
			if (seasonId < num)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewTower_HistorySeason", new <>z__ReadOnlyArray<object>(new object[]
				{
					seasonConfig.Value.StartVersionId,
					seasonConfig.Value.EndVersionId
				}));
				return;
			}
			if (seasonId == num)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "WheelTower_SeasonReward_EndVersion", new <>z__ReadOnlySingleElementList<object>(seasonConfig.Value.EndVersionId));
			}
		}

		// Token: 0x0603E02C RID: 253996 RVA: 0x00EF841F File Offset: 0x00EF661F
		private void RefreshMedalLayout()
		{
			if (this.MedalItemDataList.Count == 0)
			{
				return;
			}
			GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> medalLayout = this.MedalLayout;
			if (medalLayout == null)
			{
				return;
			}
			medalLayout.RefreshWithoutDataSync();
		}

		// Token: 0x0603E02D RID: 253997 RVA: 0x00EF8440 File Offset: 0x00EF6640
		private UniTask RefreshMedalLayoutAsync()
		{
			WheelTowerSeasonMedalView.<RefreshMedalLayoutAsync>d__24 <RefreshMedalLayoutAsync>d__;
			<RefreshMedalLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMedalLayoutAsync>d__.<>4__this = this;
			<RefreshMedalLayoutAsync>d__.<>1__state = -1;
			<RefreshMedalLayoutAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<RefreshMedalLayoutAsync>d__24>(ref <RefreshMedalLayoutAsync>d__);
			return <RefreshMedalLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E02E RID: 253998 RVA: 0x00EF8483 File Offset: 0x00EF6683
		private void RefreshScoreLayout()
		{
			if (this.ScoreItemDataList.Count == 0)
			{
				return;
			}
			GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> scoreLayout = this.ScoreLayout;
			if (scoreLayout == null)
			{
				return;
			}
			scoreLayout.RefreshWithoutDataSync();
		}

		// Token: 0x0603E02F RID: 253999 RVA: 0x00EF84A4 File Offset: 0x00EF66A4
		private UniTask RefreshScoreLayoutAsync()
		{
			WheelTowerSeasonMedalView.<RefreshScoreLayoutAsync>d__26 <RefreshScoreLayoutAsync>d__;
			<RefreshScoreLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshScoreLayoutAsync>d__.<>4__this = this;
			<RefreshScoreLayoutAsync>d__.<>1__state = -1;
			<RefreshScoreLayoutAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<RefreshScoreLayoutAsync>d__26>(ref <RefreshScoreLayoutAsync>d__);
			return <RefreshScoreLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E030 RID: 254000 RVA: 0x00EF84E7 File Offset: 0x00EF66E7
		private int GetSeasonId()
		{
			WheelTowerSeasonMedalViewData wheelTowerSeasonMedalViewData = this.OpenParam as WheelTowerSeasonMedalViewData;
			if (wheelTowerSeasonMedalViewData != null)
			{
				return wheelTowerSeasonMedalViewData.SeasonId;
			}
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			if (activityData == null)
			{
				return 0;
			}
			return activityData.SeasonId;
		}

		// Token: 0x0603E031 RID: 254001 RVA: 0x00EF8513 File Offset: 0x00EF6713
		private bool IsCurrentSeason()
		{
			int seasonId = this.GetSeasonId();
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			return seasonId == ((activityData != null) ? activityData.SeasonId : 0);
		}

		// Token: 0x0603E032 RID: 254002 RVA: 0x00EF8533 File Offset: 0x00EF6733
		private WheelTowerSeasonMedalItem CreateMedalItem()
		{
			return new WheelTowerSeasonMedalItem();
		}

		// Token: 0x0603E033 RID: 254003 RVA: 0x00EF853A File Offset: 0x00EF673A
		private WheelTowerStageMedalItem CreateScoreMedalItem()
		{
			return new WheelTowerStageMedalItem();
		}

		// Token: 0x0603E034 RID: 254004 RVA: 0x00EF8541 File Offset: 0x00EF6741
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E035 RID: 254005 RVA: 0x00EF854A File Offset: 0x00EF674A
		private void OnAllSeasonBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonOverviewView, null, null);
		}

		// Token: 0x0603E036 RID: 254006 RVA: 0x00EF855D File Offset: 0x00EF675D
		private void OnShareBtnClick()
		{
			this.OpenShareView();
		}

		// Token: 0x0603E037 RID: 254007 RVA: 0x00EF8568 File Offset: 0x00EF6768
		private void OpenShareView()
		{
			this.ReportShareEvent();
			UiAsyncTask task = new UiAsyncTask("OpenShareView", delegate()
			{
				WheelTowerSeasonMedalView.<<OpenShareView>b__34_0>d <<OpenShareView>b__34_0>d;
				<<OpenShareView>b__34_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenShareView>b__34_0>d.<>4__this = this;
				<<OpenShareView>b__34_0>d.<>1__state = -1;
				<<OpenShareView>b__34_0>d.<>t__builder.Start<WheelTowerSeasonMedalView.<<OpenShareView>b__34_0>d>(ref <<OpenShareView>b__34_0>d);
				return <<OpenShareView>b__34_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603E038 RID: 254008 RVA: 0x00EF859C File Offset: 0x00EF679C
		private void ReportShareEvent()
		{
			int seasonId = this.GetSeasonId();
			WheelTowerModel instance = WheelTowerModel.Instance;
			List<IWheelTowerMedalGroupData> seasonMedalGroupList = instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
			List<IWheelTowerMedalGroupData> seasonMedalGroupList2 = instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Stage);
			List<int> list = new List<int>(seasonMedalGroupList.Count + seasonMedalGroupList2.Count);
			foreach (IWheelTowerMedalGroupData wheelTowerMedalGroupData in seasonMedalGroupList)
			{
				list.Add((wheelTowerMedalGroupData.CurrentMedalId != 0) ? wheelTowerMedalGroupData.CurrentMedalId : wheelTowerMedalGroupData.NextMedalId);
			}
			foreach (IWheelTowerMedalGroupData wheelTowerMedalGroupData2 in seasonMedalGroupList2)
			{
				list.Add((wheelTowerMedalGroupData2.CurrentMedalId != 0) ? wheelTowerMedalGroupData2.CurrentMedalId : wheelTowerMedalGroupData2.NextMedalId);
			}
			NewTowerMedalShareEvent newTowerMedalShareEvent = new NewTowerMedalShareEvent();
			newTowerMedalShareEvent.i_season_id = seasonId;
			newTowerMedalShareEvent.s_item_id = string.Join<int>(",", list);
			LogReportController.Instance.LogReport(newTowerMedalShareEvent);
		}

		// Token: 0x0603E039 RID: 254009 RVA: 0x00EF86B8 File Offset: 0x00EF68B8
		private UniTask WaitFrame()
		{
			WheelTowerSeasonMedalView.<WaitFrame>d__36 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<WaitFrame>d__36>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x0603E03A RID: 254010 RVA: 0x00EF86F4 File Offset: 0x00EF68F4
		private UniTask OpenShareViewAsync()
		{
			WheelTowerSeasonMedalView.<OpenShareViewAsync>d__37 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OpenShareViewAsync>d__37>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E03B RID: 254011 RVA: 0x00EF8738 File Offset: 0x00EF6938
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<UTexture2D> TakeShareScreenShotAsync()
		{
			WheelTowerSeasonMedalView.<TakeShareScreenShotAsync>d__38 <TakeShareScreenShotAsync>d__;
			<TakeShareScreenShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture2D>.Create();
			<TakeShareScreenShotAsync>d__.<>4__this = this;
			<TakeShareScreenShotAsync>d__.<>1__state = -1;
			<TakeShareScreenShotAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<TakeShareScreenShotAsync>d__38>(ref <TakeShareScreenShotAsync>d__);
			return <TakeShareScreenShotAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040205FC RID: 132604
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040205FD RID: 132605
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> MedalLayout;

		// Token: 0x040205FE RID: 132606
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> ScoreLayout;

		// Token: 0x040205FF RID: 132607
		[Nullable(2)]
		private WheelTowerSeasonBgItem SeasonBgItem;

		// Token: 0x04020600 RID: 132608
		private List<IWheelTowerMedalItemData> MedalItemDataList = new List<IWheelTowerMedalItemData>();

		// Token: 0x04020601 RID: 132609
		private List<IWheelTowerMedalItemData> ScoreItemDataList = new List<IWheelTowerMedalItemData>();

		// Token: 0x04020602 RID: 132610
		private bool IsFirstShow = true;

		// Token: 0x04020603 RID: 132611
		private readonly Dictionary<int, int> OldMedalIdMap = new Dictionary<int, int>();
	}
}
