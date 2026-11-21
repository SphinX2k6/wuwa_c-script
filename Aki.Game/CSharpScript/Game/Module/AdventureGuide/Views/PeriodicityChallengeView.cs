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

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004ECE RID: 20174
	[NullableContext(1)]
	[Nullable(0)]
	public class PeriodicityChallengeView : UiTabViewBase
	{
		// Token: 0x06032B70 RID: 207728 RVA: 0x00E3D8CC File Offset: 0x00E3BACC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032B71 RID: 207729 RVA: 0x00E3D9B9 File Offset: 0x00E3BBB9
		private PeriodicityChallengeTypeItem InitTypeItem()
		{
			PeriodicityChallengeTypeItem periodicityChallengeTypeItem = new PeriodicityChallengeTypeItem();
			periodicityChallengeTypeItem.BindOnToggleFunc(new Action<int, UUIExtendToggle>(this.OnClickTypeItem));
			periodicityChallengeTypeItem.BindCanToggleExecuteChange(new Func<int, bool>(this.CanClickTypeItem));
			return periodicityChallengeTypeItem;
		}

		// Token: 0x06032B72 RID: 207730 RVA: 0x00E3D9E4 File Offset: 0x00E3BBE4
		private PeriodicityChallengeItem InitPlayItem()
		{
			return new PeriodicityChallengeItem();
		}

		// Token: 0x06032B73 RID: 207731 RVA: 0x00E3D9EC File Offset: 0x00E3BBEC
		private void OnClickTypeItem(int currentType, UUIExtendToggle toggle)
		{
			this.CurrentType = (EDungeonType)currentType;
			UUIExtendToggle currentSelectedToggle = this.CurrentSelectedToggle;
			if (currentSelectedToggle != null)
			{
				currentSelectedToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectedToggle = toggle;
			int num = this.TypeList.IndexOf(currentType);
			if (num >= 0)
			{
				this.TypeScroll.SelectGridProxy(num, false);
			}
			SecondaryGuideData? secondaryGuideDataConf = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(currentType);
			EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, secondaryGuideDataConf.Value.HelpGroupId);
			this.RefreshPlayScrollView();
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (((switchLevelSequencePlayer != null) ? switchLevelSequencePlayer.GetCurrentSequence() : null) == null)
			{
				LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer2 == null)
				{
					return;
				}
				switchLevelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer switchLevelSequencePlayer3 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer3 == null)
				{
					return;
				}
				switchLevelSequencePlayer3.ReplaySequenceByKey("Switch");
				return;
			}
		}

		// Token: 0x06032B74 RID: 207732 RVA: 0x00E3DAB8 File Offset: 0x00E3BCB8
		private void RefreshPlayScrollView()
		{
			List<SoundAreaDetectionRecord> item = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2;
			GenericScrollViewNew<PeriodicityChallengeItem, IPeriodicityChallengeItem> playScroll = this.PlayScroll;
			if (playScroll == null)
			{
				return;
			}
			playScroll.RefreshByData(this.GetPeriodicityChallengeItemDataList(item), null, false);
		}

		// Token: 0x06032B75 RID: 207733 RVA: 0x00E3DB00 File Offset: 0x00E3BD00
		private void RefreshTypeScrollView()
		{
			int index = this.TypeList.IndexOf((int)this.CurrentType);
			this.TypeScroll.RefreshByData(this.BuildTypeItemDataList(), false, delegate
			{
				PeriodicityChallengeTypeItem periodicityChallengeTypeItem = this.TypeScroll.UnsafeGetGridProxy(index, false);
				if (periodicityChallengeTypeItem == null)
				{
					return;
				}
				periodicityChallengeTypeItem.OnlySetSelectToggle(EToggleState.ETT_Checked);
			}, false);
		}

		// Token: 0x06032B76 RID: 207734 RVA: 0x00E3DB50 File Offset: 0x00E3BD50
		private List<EDungeonType> BuildTypeItemDataList()
		{
			int count = this.TypeList.Count;
			List<EDungeonType> list = new List<EDungeonType>();
			for (int i = 0; i < count; i++)
			{
				int cycleId = WeeklyRogueModel.Instance.CycleId;
				if (this.TypeList[i] != 29 || cycleId != 0)
				{
					list.Add((EDungeonType)this.TypeList[i]);
				}
			}
			return list;
		}

		// Token: 0x06032B77 RID: 207735 RVA: 0x00E3DBAC File Offset: 0x00E3BDAC
		private List<IPeriodicityChallengeItem> GetPeriodicityChallengeItemDataList(IEnumerable<SoundAreaDetectionRecord> list)
		{
			List<IPeriodicityChallengeItem> list2 = new List<IPeriodicityChallengeItem>();
			Dictionary<int, List<SoundAreaDetectionRecord>> dictionary = new Dictionary<int, List<SoundAreaDetectionRecord>>();
			foreach (SoundAreaDetectionRecord soundAreaDetectionRecord in list)
			{
				List<SoundAreaDetectionRecord> list3;
				if (!dictionary.TryGetValue(soundAreaDetectionRecord.DetectionTitlePanel, out list3))
				{
					list3 = new List<SoundAreaDetectionRecord>();
					dictionary[soundAreaDetectionRecord.DetectionTitlePanel] = list3;
				}
				list3.Add(soundAreaDetectionRecord);
			}
			foreach (KeyValuePair<int, List<SoundAreaDetectionRecord>> keyValuePair in dictionary)
			{
				List<SoundAreaDetectionRecord> value = keyValuePair.Value;
				if (AdventureGuideModel.Instance.IsTowerType((EPeriodicityChallengeType)value[0].PeriodicityChallengeType))
				{
					value.Sort(delegate(SoundAreaDetectionRecord a, SoundAreaDetectionRecord b)
					{
						int num = (a.GetTargetTowerIsUnlock() > false) ? 1 : 0;
						int num2 = (b.GetTargetTowerIsUnlock() > false) ? 1 : 0;
						if (num != num2)
						{
							return num2 - num;
						}
						int targetTowerDifficulty = a.GetTargetTowerDifficulty();
						int targetTowerDifficulty2 = b.GetTargetTowerDifficulty();
						if (num != 0)
						{
							return targetTowerDifficulty2 - targetTowerDifficulty;
						}
						return targetTowerDifficulty - targetTowerDifficulty2;
					});
				}
				for (int i = 0; i < value.Count; i++)
				{
					IPeriodicityChallengeItem periodicityChallengeItem = new IPeriodicityChallengeItem
					{
						Data = value[i],
						Title = (value[i].DetectionTitlePanel > 0 && i < 1)
					};
					if (this.CurrentType == EDungeonType.WeeklyRogue)
					{
						WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
						int freeCount = activityDataNew.FreeCount;
						int freeCountMax = activityDataNew.FreeCountMax;
						PeriodicityChallengeTopTipsData periodicityChallengeTopTipsData = new PeriodicityChallengeTopTipsData();
						periodicityChallengeTopTipsData.TitleTips = "Text_WeeklyRogue_FreeTime_Title";
						periodicityChallengeTopTipsData.Args = Array.Empty<string>();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(freeCount);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted<int>(freeCountMax);
						periodicityChallengeTopTipsData.TxtNum = defaultInterpolatedStringHandler.ToStringAndClear();
						PeriodicityChallengeTopTipsData topTips = periodicityChallengeTopTipsData;
						periodicityChallengeItem.TopTips = topTips;
					}
					list2.Add(periodicityChallengeItem);
				}
			}
			return list2;
		}

		// Token: 0x06032B78 RID: 207736 RVA: 0x00E3DD9C File Offset: 0x00E3BF9C
		private bool CanClickTypeItem(int currentType)
		{
			return this.CurrentType != (EDungeonType)currentType;
		}

		// Token: 0x06032B79 RID: 207737 RVA: 0x00E3DDAC File Offset: 0x00E3BFAC
		protected override UniTask OnBeforeStartAsync()
		{
			PeriodicityChallengeView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PeriodicityChallengeView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B7A RID: 207738 RVA: 0x00E3DDE8 File Offset: 0x00E3BFE8
		protected override void OnStart()
		{
			this.PlayScroll = new GenericScrollViewNew<PeriodicityChallengeItem, IPeriodicityChallengeItem>(base.GetScrollViewWithScrollbar(3), new Func<PeriodicityChallengeItem>(this.InitPlayItem), null, false, null);
			this.TypeScroll = new LoopScrollView<PeriodicityChallengeTypeItem, EDungeonType>(base.GetLoopScrollViewComponent(0), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PeriodicityChallengeTypeItem>(this.InitTypeItem), false);
			List<int> allCanShowDungeonTypeList = AdventureGuideModel.Instance.GetAllCanShowDungeonTypeList(new EUiTabViewName?(EUiTabViewName.PeriodicityChallengeView), true);
			this.TypeList = new List<int>(allCanShowDungeonTypeList);
			this.StartLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SwitchLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TryAddTimer();
		}

		// Token: 0x06032B7B RID: 207739 RVA: 0x00E3DE94 File Offset: 0x00E3C094
		protected override void OnBeforeShow()
		{
			this.CurrentData = (this.ExtraParams as AdventureGuideViewOpenData);
			AdventureGuideViewOpenData currentData = this.CurrentData;
			int? num = (((currentData != null) ? currentData.OpenTabViewName : null) == EUiTabViewName.PeriodicityChallengeView) ? ((currentData != null) ? currentData.OpenParam : null) : new int?((int)this.CurrentType);
			int dungeonIndex = 0;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					int num4 = this.TypeList.IndexOf(num.Value);
					if (num4 >= 0)
					{
						dungeonIndex = num4;
					}
				}
			}
			List<EDungeonType> data = this.BuildTypeItemDataList();
			this.TypeScroll.RefreshByData(data, false, delegate
			{
				this.TypeScroll.SelectGridProxy(dungeonIndex, false);
				this.TypeScroll.ScrollToGridIndex(dungeonIndex, true);
				PeriodicityChallengeTypeItem periodicityChallengeTypeItem = this.TypeScroll.UnsafeGetGridProxy(dungeonIndex, false);
				if (periodicityChallengeTypeItem == null)
				{
					return;
				}
				periodicityChallengeTypeItem.SetSelectToggle(EToggleState.ETT_Checked);
			}, false);
			LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
			if (startLevelSequencePlayer == null)
			{
				return;
			}
			startLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06032B7C RID: 207740 RVA: 0x00E3DFB1 File Offset: 0x00E3C1B1
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
			if (startLevelSequencePlayer != null)
			{
				startLevelSequencePlayer.Clear();
			}
			this.StartLevelSequencePlayer = null;
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (switchLevelSequencePlayer != null)
			{
				switchLevelSequencePlayer.Clear();
			}
			this.SwitchLevelSequencePlayer = null;
			this.TryRemoveTimer();
		}

		// Token: 0x06032B7D RID: 207741 RVA: 0x00E3DFEA File Offset: 0x00E3C1EA
		private bool TryAddTimer()
		{
			if (this.RefreshTimer != null)
			{
				return false;
			}
			this.AddTimer();
			return true;
		}

		// Token: 0x06032B7E RID: 207742 RVA: 0x00E3DFFD File Offset: 0x00E3C1FD
		private bool TryRemoveTimer()
		{
			if (this.RefreshTimer == null)
			{
				return false;
			}
			this.RemoveTimer();
			return true;
		}

		// Token: 0x06032B7F RID: 207743 RVA: 0x00E3E010 File Offset: 0x00E3C210
		private void AddTimer()
		{
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x06032B80 RID: 207744 RVA: 0x00E3E041 File Offset: 0x00E3C241
		private void RemoveTimer()
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}

		// Token: 0x06032B81 RID: 207745 RVA: 0x00E3E05B File Offset: 0x00E3C25B
		private void OnTimerRefresh(float delta)
		{
			this.RefreshTypeScrollView();
			this.RefreshPlayScrollView();
		}

		// Token: 0x0401AEF2 RID: 110322
		[Nullable(2)]
		private AdventureGuideViewOpenData CurrentData;

		// Token: 0x0401AEF3 RID: 110323
		private EDungeonType CurrentType = EDungeonType.Mat;

		// Token: 0x0401AEF4 RID: 110324
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectedToggle;

		// Token: 0x0401AEF5 RID: 110325
		private List<int> TypeList = new List<int>();

		// Token: 0x0401AEF6 RID: 110326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<PeriodicityChallengeTypeItem, EDungeonType> TypeScroll;

		// Token: 0x0401AEF7 RID: 110327
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PeriodicityChallengeItem, IPeriodicityChallengeItem> PlayScroll;

		// Token: 0x0401AEF8 RID: 110328
		[Nullable(2)]
		private LevelSequencePlayer StartLevelSequencePlayer;

		// Token: 0x0401AEF9 RID: 110329
		[Nullable(2)]
		private LevelSequencePlayer SwitchLevelSequencePlayer;

		// Token: 0x0401AEFA RID: 110330
		[Nullable(2)]
		private TimerHandle RefreshTimer;
	}
}
