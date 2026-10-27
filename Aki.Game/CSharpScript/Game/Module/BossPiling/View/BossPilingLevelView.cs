using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling.View.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C10 RID: 23568
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelView : UiViewBase
	{
		// Token: 0x0603B8DE RID: 243934 RVA: 0x00E3313A File Offset: 0x00E3133A
		public BossPilingLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8DF RID: 243935 RVA: 0x00E33150 File Offset: 0x00E31350
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickedConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickedBuff));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B8E0 RID: 243936 RVA: 0x00E333F1 File Offset: 0x00E315F1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B8E1 RID: 243937 RVA: 0x00E3340F File Offset: 0x00E3160F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B8E2 RID: 243938 RVA: 0x00E33430 File Offset: 0x00E31630
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B8E3 RID: 243939 RVA: 0x00E33474 File Offset: 0x00E31674
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.CaptionItem.SetHelpBtnActive(false);
			bool flag = BossPilingModel.Instance.CheckIsBossPiling();
			this.CaptionItem.SetHomeBtnShowState(!flag);
			this.BuffLayout = new GenericLayout<BossPilingBuffSimpleItem, int>(base.GetHorizontalLayout(4), new Func<BossPilingBuffSimpleItem>(this.CreateBuffItem), null, false, true);
			this.ScoreLayout = new GenericLayout<BossPilingScoreTabItem, BossPilingScoreTabInfo>(base.GetVerticalLayout(7), new Func<BossPilingScoreTabItem>(this.CreateScoreItem), null, false, true);
			this.RefreshPanel();
		}

		// Token: 0x0603B8E4 RID: 243940 RVA: 0x00E33518 File Offset: 0x00E31718
		protected void RefreshPanel()
		{
			BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(this.CurLevel);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(levelInfo.Value.LevelName);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossPilingActivity_DungeonDetail01", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
			List<int> data = new List<int>(levelInfo.Value.BuffShow());
			this.BuffLayout.RefreshByData(data, null, false);
			BossPilingLevelInfo levelInfo2 = BossPilingModel.Instance.GetActivityData().GetLevelInfo(this.CurLevel);
			List<BossPilingScoreTabInfo> list = new List<BossPilingScoreTabInfo>();
			for (int i = 0; i < levelInfo.Value.Achievement().Length; i++)
			{
				int num = levelInfo.Value.Achievement()[i];
				BossPilingScoreTabInfo item = new BossPilingScoreTabInfo
				{
					BossHp = num,
					Quality = i + 1,
					IsAchieve = (levelInfo2.BossHp >= num)
				};
				list.Add(item);
			}
			this.ScoreLayout.RefreshByData(list, null, false);
			List<BossPilingLevelDescInfo> levelDataList = this.GetLevelDataList();
			this.LevelInfo1.Refresh(levelDataList[0], false, 0);
			this.LevelInfo2.Refresh(levelDataList[1], false, 1);
		}

		// Token: 0x0603B8E5 RID: 243941 RVA: 0x00E3365C File Offset: 0x00E3185C
		protected List<BossPilingLevelDescInfo> GetLevelDataList()
		{
			if (this.LevelDataList.Count > 0)
			{
				return this.LevelDataList;
			}
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(this.CurLevel).Value;
			BossPilingLevelDescInfo item = new BossPilingLevelDescInfo
			{
				IsFirstLevel = true,
				LevelId = value.InstIds()[0],
				LevelMechanism = value.LevelMechanism1,
				MonsterDesc = value.LevelMonsterDesc1,
				LevelDesc = value.LevelDesc1
			};
			this.LevelDataList.Add(item);
			BossPilingLevelDescInfo item2 = new BossPilingLevelDescInfo
			{
				IsFirstLevel = false,
				LevelId = value.InstIds()[1],
				LevelMechanism = value.LevelMechanism2,
				MonsterDesc = value.LevelMonsterDesc2,
				LevelDesc = value.LevelDesc2
			};
			this.LevelDataList.Add(item2);
			return this.LevelDataList;
		}

		// Token: 0x0603B8E6 RID: 243942 RVA: 0x00E3373B File Offset: 0x00E3193B
		private BossPilingBuffSimpleItem CreateBuffItem()
		{
			return new BossPilingBuffSimpleItem();
		}

		// Token: 0x0603B8E7 RID: 243943 RVA: 0x00E33742 File Offset: 0x00E31942
		private BossPilingScoreTabItem CreateScoreItem()
		{
			return new BossPilingScoreTabItem();
		}

		// Token: 0x0603B8E8 RID: 243944 RVA: 0x00E33749 File Offset: 0x00E31949
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B8E9 RID: 243945 RVA: 0x00E33754 File Offset: 0x00E31954
		private void OnClickedView(bool isFirst)
		{
			List<BossPilingLevelDescInfo> levelDataList = this.GetLevelDataList();
			BossPilingLevelDetailInfo param = new BossPilingLevelDetailInfo
			{
				IsFirst = isFirst,
				LevelList = levelDataList
			};
			UiManager.Instance.OpenView(EUiViewName.BossPilingLevelDescView, param, null);
		}

		// Token: 0x0603B8EA RID: 243946 RVA: 0x00E33790 File Offset: 0x00E31990
		private void OnClickedConfirm()
		{
			ValueTuple<List<int>, List<int>> teamListResult = this.PanelTeam.GetTeamListResult();
			List<int> teamList = teamListResult.Item1;
			List<int> tagList = teamListResult.Item2;
			int num = 0;
			using (List<int>.Enumerator enumerator = teamList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != 0)
					{
						num++;
					}
				}
			}
			if (num == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_NoRole_Text", Array.Empty<object>());
				return;
			}
			if (num < 3)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BossRushRoleLess);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					BossPilingController.Instance.RequestChallenge(this.CurLevel, teamList, tagList, false);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			BossPilingController.Instance.RequestChallenge(this.CurLevel, teamList, tagList, false);
		}

		// Token: 0x0603B8EB RID: 243947 RVA: 0x00E33880 File Offset: 0x00E31A80
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x0603B8EC RID: 243948 RVA: 0x00E33890 File Offset: 0x00E31A90
		private void OnClickedBuff()
		{
			BossPilingBuffViewInfo param = new BossPilingBuffViewInfo
			{
				LevelId = this.CurLevel,
				InGame = false
			};
			UiManager.Instance.OpenView(EUiViewName.BossPilingBuffView, param, null);
		}

		// Token: 0x0401F029 RID: 127017
		protected int CurLevel;

		// Token: 0x0401F02A RID: 127018
		protected List<BossPilingLevelDescInfo> LevelDataList = new List<BossPilingLevelDescInfo>();

		// Token: 0x0401F02B RID: 127019
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401F02C RID: 127020
		protected GenericLayout<BossPilingBuffSimpleItem, int> BuffLayout;

		// Token: 0x0401F02D RID: 127021
		protected GenericLayout<BossPilingScoreTabItem, BossPilingScoreTabInfo> ScoreLayout;

		// Token: 0x0401F02E RID: 127022
		protected BossPilingLevelDescItem LevelInfo1;

		// Token: 0x0401F02F RID: 127023
		protected BossPilingLevelDescItem LevelInfo2;

		// Token: 0x0401F030 RID: 127024
		protected BossPilingTeamPanel PanelTeam;

		// Token: 0x0200BDEF RID: 48623
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04039443 RID: 234563
			CaptionItem,
			// Token: 0x04039444 RID: 234564
			TxtTitle,
			// Token: 0x04039445 RID: 234565
			SpriteFrameHover,
			// Token: 0x04039446 RID: 234566
			TxtBuffView,
			// Token: 0x04039447 RID: 234567
			PanelBuff,
			// Token: 0x04039448 RID: 234568
			BuffItem,
			// Token: 0x04039449 RID: 234569
			TxtTitleScore,
			// Token: 0x0403944A RID: 234570
			ContentScore,
			// Token: 0x0403944B RID: 234571
			TargetItem,
			// Token: 0x0403944C RID: 234572
			ScrollViewDefault,
			// Token: 0x0403944D RID: 234573
			ContentLevelInfo,
			// Token: 0x0403944E RID: 234574
			LevelInfo1,
			// Token: 0x0403944F RID: 234575
			PanelTeam,
			// Token: 0x04039450 RID: 234576
			BtnConfirm,
			// Token: 0x04039451 RID: 234577
			BtnBuff,
			// Token: 0x04039452 RID: 234578
			LevelInfo2
		}
	}
}
