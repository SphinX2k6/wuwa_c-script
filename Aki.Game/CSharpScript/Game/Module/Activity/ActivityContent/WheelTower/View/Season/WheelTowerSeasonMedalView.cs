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
	// Token: 0x02004F4E RID: 20302
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonMedalView : UiViewBase
	{
		// Token: 0x06032FB8 RID: 208824 RVA: 0x00E498E1 File Offset: 0x00E47AE1
		public WheelTowerSeasonMedalView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032FB9 RID: 208825 RVA: 0x00E49914 File Offset: 0x00E47B14
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

		// Token: 0x06032FBA RID: 208826 RVA: 0x00E49BB4 File Offset: 0x00E47DB4
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerSeasonMedalView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FBB RID: 208827 RVA: 0x00E49BF8 File Offset: 0x00E47DF8
		private UniTask LoadSeasonBgItem()
		{
			WheelTowerSeasonMedalView.<LoadSeasonBgItem>d__11 <LoadSeasonBgItem>d__;
			<LoadSeasonBgItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSeasonBgItem>d__.<>4__this = this;
			<LoadSeasonBgItem>d__.<>1__state = -1;
			<LoadSeasonBgItem>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<LoadSeasonBgItem>d__11>(ref <LoadSeasonBgItem>d__);
			return <LoadSeasonBgItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032FBC RID: 208828 RVA: 0x00E49C3B File Offset: 0x00E47E3B
		protected override void OnStart()
		{
			this.ReportEnterMedalEvent();
		}

		// Token: 0x06032FBD RID: 208829 RVA: 0x00E49C44 File Offset: 0x00E47E44
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			WheelTowerSeasonMedalView.<OnPlayingStartSequenceAsync>d__13 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnPlayingStartSequenceAsync>d__13>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FBE RID: 208830 RVA: 0x00E49C88 File Offset: 0x00E47E88
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			WheelTowerSeasonMedalView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FBF RID: 208831 RVA: 0x00E49CCB File Offset: 0x00E47ECB
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

		// Token: 0x06032FC0 RID: 208832 RVA: 0x00E49CF8 File Offset: 0x00E47EF8
		private void ReportEnterMedalEvent()
		{
			NewTowerEnterMedalEvent newTowerEnterMedalEvent = new NewTowerEnterMedalEvent();
			newTowerEnterMedalEvent.i_activity_id = WheelTowerModel.Instance.ActivityData.Id;
			newTowerEnterMedalEvent.i_season_id = this.GetSeasonId();
			LogReportController.Instance.LogReport(newTowerEnterMedalEvent);
		}

		// Token: 0x06032FC1 RID: 208833 RVA: 0x00E49D38 File Offset: 0x00E47F38
		private void MarkSeasonMedalsRead()
		{
			int seasonId = this.GetSeasonId();
			WheelTowerModel.Instance.MarkSeasonMedalsRead(seasonId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, WheelTowerModel.Instance.ActivityData.Id);
		}

		// Token: 0x06032FC2 RID: 208834 RVA: 0x00E49D78 File Offset: 0x00E47F78
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

		// Token: 0x06032FC3 RID: 208835 RVA: 0x00E49E5C File Offset: 0x00E4805C
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

		// Token: 0x06032FC4 RID: 208836 RVA: 0x00E49FA8 File Offset: 0x00E481A8
		private void TryAutoShare()
		{
			WheelTowerSeasonMedalViewData wheelTowerSeasonMedalViewData = this.OpenParam as WheelTowerSeasonMedalViewData;
			if (wheelTowerSeasonMedalViewData == null || !wheelTowerSeasonMedalViewData.AutoShare)
			{
				return;
			}
			this.OpenShareView();
		}

		// Token: 0x06032FC5 RID: 208837 RVA: 0x00E49FD4 File Offset: 0x00E481D4
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

		// Token: 0x06032FC6 RID: 208838 RVA: 0x00E4A018 File Offset: 0x00E48218
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

		// Token: 0x06032FC7 RID: 208839 RVA: 0x00E4A14B File Offset: 0x00E4834B
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

		// Token: 0x06032FC8 RID: 208840 RVA: 0x00E4A16C File Offset: 0x00E4836C
		private UniTask RefreshMedalLayoutAsync()
		{
			WheelTowerSeasonMedalView.<RefreshMedalLayoutAsync>d__24 <RefreshMedalLayoutAsync>d__;
			<RefreshMedalLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMedalLayoutAsync>d__.<>4__this = this;
			<RefreshMedalLayoutAsync>d__.<>1__state = -1;
			<RefreshMedalLayoutAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<RefreshMedalLayoutAsync>d__24>(ref <RefreshMedalLayoutAsync>d__);
			return <RefreshMedalLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FC9 RID: 208841 RVA: 0x00E4A1AF File Offset: 0x00E483AF
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

		// Token: 0x06032FCA RID: 208842 RVA: 0x00E4A1D0 File Offset: 0x00E483D0
		private UniTask RefreshScoreLayoutAsync()
		{
			WheelTowerSeasonMedalView.<RefreshScoreLayoutAsync>d__26 <RefreshScoreLayoutAsync>d__;
			<RefreshScoreLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshScoreLayoutAsync>d__.<>4__this = this;
			<RefreshScoreLayoutAsync>d__.<>1__state = -1;
			<RefreshScoreLayoutAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<RefreshScoreLayoutAsync>d__26>(ref <RefreshScoreLayoutAsync>d__);
			return <RefreshScoreLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FCB RID: 208843 RVA: 0x00E4A213 File Offset: 0x00E48413
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

		// Token: 0x06032FCC RID: 208844 RVA: 0x00E4A23F File Offset: 0x00E4843F
		private bool IsCurrentSeason()
		{
			int seasonId = this.GetSeasonId();
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			return seasonId == ((activityData != null) ? activityData.SeasonId : 0);
		}

		// Token: 0x06032FCD RID: 208845 RVA: 0x00E4A25F File Offset: 0x00E4845F
		private WheelTowerSeasonMedalItem CreateMedalItem()
		{
			return new WheelTowerSeasonMedalItem();
		}

		// Token: 0x06032FCE RID: 208846 RVA: 0x00E4A266 File Offset: 0x00E48466
		private WheelTowerStageMedalItem CreateScoreMedalItem()
		{
			return new WheelTowerStageMedalItem();
		}

		// Token: 0x06032FCF RID: 208847 RVA: 0x00E4A26D File Offset: 0x00E4846D
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032FD0 RID: 208848 RVA: 0x00E4A276 File Offset: 0x00E48476
		private void OnAllSeasonBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonOverviewView, null, null);
		}

		// Token: 0x06032FD1 RID: 208849 RVA: 0x00E4A289 File Offset: 0x00E48489
		private void OnShareBtnClick()
		{
			this.OpenShareView();
		}

		// Token: 0x06032FD2 RID: 208850 RVA: 0x00E4A294 File Offset: 0x00E48494
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

		// Token: 0x06032FD3 RID: 208851 RVA: 0x00E4A2C8 File Offset: 0x00E484C8
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

		// Token: 0x06032FD4 RID: 208852 RVA: 0x00E4A3E4 File Offset: 0x00E485E4
		private UniTask WaitFrame()
		{
			WheelTowerSeasonMedalView.<WaitFrame>d__36 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<WaitFrame>d__36>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06032FD5 RID: 208853 RVA: 0x00E4A420 File Offset: 0x00E48620
		private UniTask OpenShareViewAsync()
		{
			WheelTowerSeasonMedalView.<OpenShareViewAsync>d__37 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalView.<OpenShareViewAsync>d__37>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B0CE RID: 110798
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B0CF RID: 110799
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerSeasonMedalItem, IWheelTowerMedalItemData> MedalLayout;

		// Token: 0x0401B0D0 RID: 110800
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerStageMedalItem, IWheelTowerMedalItemData> ScoreLayout;

		// Token: 0x0401B0D1 RID: 110801
		[Nullable(2)]
		private WheelTowerSeasonBgItem SeasonBgItem;

		// Token: 0x0401B0D2 RID: 110802
		private List<IWheelTowerMedalItemData> MedalItemDataList = new List<IWheelTowerMedalItemData>();

		// Token: 0x0401B0D3 RID: 110803
		private List<IWheelTowerMedalItemData> ScoreItemDataList = new List<IWheelTowerMedalItemData>();

		// Token: 0x0401B0D4 RID: 110804
		private bool IsFirstShow = true;

		// Token: 0x0401B0D5 RID: 110805
		private readonly Dictionary<int, int> OldMedalIdMap = new Dictionary<int, int>();
	}
}
