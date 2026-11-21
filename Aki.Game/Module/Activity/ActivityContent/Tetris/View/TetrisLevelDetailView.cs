using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FCE RID: 12238
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisLevelDetailView : UiViewBase
	{
		// Token: 0x0601D0A6 RID: 118950 RVA: 0x008DEF0E File Offset: 0x008DD10E
		public TetrisLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x008DEF24 File Offset: 0x008DD124
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickedEnterButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x008DF1C2 File Offset: 0x008DD3C2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0601D0A9 RID: 118953 RVA: 0x008DF1FC File Offset: 0x008DD3FC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0601D0AA RID: 118954 RVA: 0x008DF236 File Offset: 0x008DD436
		private void OnTetrisChallengeStateUpdate(int challengeId)
		{
			this.GetCurrentDifficulty();
			this.RefreshAllGridToggleState();
			this.Refresh(false);
		}

		// Token: 0x0601D0AB RID: 118955 RVA: 0x008DF24C File Offset: 0x008DD44C
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisLevelDetailView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisLevelDetailView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D0AC RID: 118956 RVA: 0x008DF290 File Offset: 0x008DD490
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData != null)
			{
				this.CaptionItem.SetTitleLocalText(tetrisData.GetTitleTextId());
			}
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.Param = (this.OpenParam as TetrisSelectGroupData);
			int activityId = ActivityTetrisController.Instance.ActivityId;
			this.Levels = ActivityTetrisConfig.Instance.GetGroupLevels(activityId, this.Param.GroupId);
			this.DifficultyScroll = new GenericLayout<TetrisLevelDetailGridView, Tetris>(base.GetVerticalLayout(8), new Func<TetrisLevelDetailGridView>(this.InitDifficultyItem), null, false, true);
			this.RewardListScroll = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(11), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, true);
			this.TargetListScroll = new GenericLayout<TetrisTargetItemPanel, TetrisTargetData>(base.GetVerticalLayout(4), new Func<TetrisTargetItemPanel>(this.InitTargetItem), null, false, true);
			Tetris tetris = this.Levels[this.DifficultyIndex];
			if (tetris.Mode == 3)
			{
				IntIntMap? intIntMap = tetris.TargetResults(0);
				if (intIntMap != null)
				{
					for (int i = 0; i < intIntMap.Value.MapIntIntLength; i++)
					{
						DicIntInt value = intIntMap.Value.MapIntInt(i).Value;
						if (value.Key == 0 && value.Value > 0)
						{
							LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Tetris2UIText_005", new <>z__ReadOnlySingleElementList<object>(value.Value));
							return;
						}
					}
				}
			}
		}

		// Token: 0x0601D0AD RID: 118957 RVA: 0x008DF454 File Offset: 0x008DD654
		private void GetCurrentDifficulty()
		{
			if (this.Levels == null)
			{
				return;
			}
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			for (int i = 0; i < this.Levels.Count; i++)
			{
				if (this.Levels[i].UnlockId == 0 || tetrisData.CheckChallengeComplete(this.Levels[i].UnlockId))
				{
					this.DifficultyIndex = i;
				}
			}
		}

		// Token: 0x0601D0AE RID: 118958 RVA: 0x008DF4CB File Offset: 0x008DD6CB
		protected override void OnBeforeShow()
		{
			this.GetCurrentDifficulty();
			this.Refresh(false);
			this.RefreshScroller();
		}

		// Token: 0x0601D0AF RID: 118959 RVA: 0x008DF4E0 File Offset: 0x008DD6E0
		public void Refresh(bool isSwitch = false)
		{
			this.RefreshDesc(isSwitch);
			this.RefreshReward();
			this.RefreshTarget();
			this.RefreshLockBtn();
			this.DetailIconItem.Refresh(this.Param);
			this.RefreshHighestScore();
		}

		// Token: 0x0601D0B0 RID: 118960 RVA: 0x008DF512 File Offset: 0x008DD712
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D0B1 RID: 118961 RVA: 0x008DF52C File Offset: 0x008DD72C
		private void RefreshAllGridToggleState()
		{
			foreach (TetrisLevelDetailGridView tetrisLevelDetailGridView in this.GridViews)
			{
				int? challengeDifficulty = tetrisLevelDetailGridView.GetChallengeDifficulty();
				int? num = challengeDifficulty;
				int difficultyIndex = this.DifficultyIndex;
				tetrisLevelDetailGridView.SetToggleActive(num.GetValueOrDefault() == difficultyIndex & num != null);
			}
		}

		// Token: 0x0601D0B2 RID: 118962 RVA: 0x008DF5A0 File Offset: 0x008DD7A0
		private void RefreshDesc(bool isSwitch = false)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex]).LevelName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex]).LevelDes, Array.Empty<object>());
			base.GetArtText(12).SetText(this.Param.GroupId.ToString());
		}

		// Token: 0x0601D0B3 RID: 118963 RVA: 0x008DF64C File Offset: 0x008DD84C
		private void RefreshReward()
		{
			int dropId = this.Levels[this.DifficultyIndex].DropId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			this.RewardListScroll.RefreshByData(dropPackagePreviewItemList, null, false);
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x008DF68D File Offset: 0x008DD88D
		private void RefreshTarget()
		{
			this.TargetListScroll.RefreshByData(this.GenTargetData(), null, false);
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x008DF6A4 File Offset: 0x008DD8A4
		private void RefreshLockBtn()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			bool flag = tetrisData.CheckPreChallengeComplete(this.Levels[this.DifficultyIndex].Id);
			base.GetItem(13).SetUIActive(!flag);
			UUIButtonComponent button = base.GetButton(7);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(flag);
		}

		// Token: 0x0601D0B6 RID: 118966 RVA: 0x008DF718 File Offset: 0x008DD918
		private void RefreshScroller()
		{
			if (TetrisUtils.IsActivityEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex])))
			{
				this.ClearEggLevelRedDot();
				return;
			}
			this.DifficultyScroll.RefreshByData(this.Levels, new Action(this.RefreshAllGridToggleState), false);
		}

		// Token: 0x0601D0B7 RID: 118967 RVA: 0x008DF774 File Offset: 0x008DD974
		private void RefreshHighestScore()
		{
			int num = this.Param.ChallengeIds[this.DifficultyIndex];
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(num);
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(levelConfig.NeedRecord);
			}
			if (levelConfig.NeedRecord)
			{
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				int? num2 = (tetrisData != null) ? tetrisData.GetChallengeRecord(num, 0) : null;
				if (num2 != null)
				{
					UUIText text = base.GetText(16);
					string inString = new StringBuilder(ConfigMultiTextLang.GetLocalTextNew("Tetris2UIText_001", null)).Append(ConfigMultiTextLang.GetLocalTextNew("Tetris2UIText_002", null)).ToString();
					text.SetText(StringUtils.FormatStaticBuilder(inString, new object[]
					{
						(num2.Value > 0) ? num2.Value.ToString() : ConfigMultiTextLang.GetLocalTextNew("Tetris2UIText_008", null)
					}), true);
				}
			}
		}

		// Token: 0x0601D0B8 RID: 118968 RVA: 0x008DF860 File Offset: 0x008DDA60
		private void ClearEggLevelRedDot()
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			int key = this.Param.ChallengeIds[this.DifficultyIndex];
			ActivityModel.Instance.SaveActivityData(activityId, 10001, key, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0601D0B9 RID: 118969 RVA: 0x008DF8B4 File Offset: 0x008DDAB4
		private List<TetrisTargetData> GenTargetData()
		{
			List<TetrisTargetData> list = new List<TetrisTargetData>();
			Tetris tetris = this.Levels[this.DifficultyIndex];
			if (tetris.Mode == 3)
			{
				list.Add(new TetrisTargetData
				{
					Icon = "",
					Num = 0,
					Tip = "Tetris2UIText_004"
				});
			}
			else
			{
				IntIntMap value = tetris.TargetResults(0).Value;
				int mapIntIntLength = value.MapIntIntLength;
				for (int i = 0; i < mapIntIntLength; i++)
				{
					DicIntInt value2 = value.MapIntInt(i).Value;
					list.Add(new TetrisTargetData
					{
						Icon = ActivityTetrisConfig.Instance.GetGemConfig(value2.Key).Value.TargetIconPath,
						Num = value2.Value,
						Tip = ((value2.Key == 0) ? "Tetristext_09" : "Tetristext_10")
					});
				}
			}
			return list;
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x008DF9AB File Offset: 0x008DDBAB
		private TetrisTargetItemPanel InitTargetItem()
		{
			return new TetrisTargetItemPanel();
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x008DF9B2 File Offset: 0x008DDBB2
		public CommonItemSmallItemGrid InitRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => ActivityTetrisController.Instance.GetTetrisData().CheckChallengeComplete(this.Levels[this.DifficultyIndex].Id))
			};
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x008DF9CC File Offset: 0x008DDBCC
		private TetrisLevelDetailGridView InitDifficultyItem()
		{
			TetrisLevelDetailGridView tetrisLevelDetailGridView = new TetrisLevelDetailGridView();
			this.GridViews.Add(tetrisLevelDetailGridView);
			return tetrisLevelDetailGridView;
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x008DF9EC File Offset: 0x008DDBEC
		private void OnClickedEnterButton()
		{
			TetrisController.Instance.OpenActivityTetris(this.Levels[this.DifficultyIndex].Id);
		}

		// Token: 0x0601D0BE RID: 118974 RVA: 0x008DFA1C File Offset: 0x008DDC1C
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisLevelDetailView, null);
		}

		// Token: 0x0601D0BF RID: 118975 RVA: 0x008DFA2E File Offset: 0x008DDC2E
		public void ChangeDifficultyIndex(int value)
		{
			this.DifficultyIndex = value;
			this.RefreshAllGridToggleState();
			this.Refresh(true);
		}

		// Token: 0x0601D0C0 RID: 118976 RVA: 0x008DFA44 File Offset: 0x008DDC44
		private void OnClickHelpBtn()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData != null)
			{
				Activity? localConfig = tetrisData.LocalConfig;
				if (localConfig != null)
				{
					Activity valueOrDefault = localConfig.GetValueOrDefault();
					HelpController.Instance.OpenHelpById(valueOrDefault.HelpId);
				}
			}
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x008DFA88 File Offset: 0x008DDC88
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0400F4CB RID: 62667
		[Nullable(2)]
		private TetrisSelectGroupData Param;

		// Token: 0x0400F4CC RID: 62668
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F4CD RID: 62669
		[Nullable(2)]
		private TetrisDetailIconPanel DetailIconItem;

		// Token: 0x0400F4CE RID: 62670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardListScroll;

		// Token: 0x0400F4CF RID: 62671
		private GenericLayout<TetrisLevelDetailGridView, Tetris> DifficultyScroll;

		// Token: 0x0400F4D0 RID: 62672
		private GenericLayout<TetrisTargetItemPanel, TetrisTargetData> TargetListScroll;

		// Token: 0x0400F4D1 RID: 62673
		private int DifficultyIndex;

		// Token: 0x0400F4D2 RID: 62674
		[Nullable(2)]
		private IReadOnlyList<Tetris> Levels;

		// Token: 0x0400F4D3 RID: 62675
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F4D4 RID: 62676
		private readonly List<TetrisLevelDetailGridView> GridViews = new List<TetrisLevelDetailGridView>();

		// Token: 0x0400F4D5 RID: 62677
		[Nullable(2)]
		private LockBtnPanel LockBtnItem;
	}
}
