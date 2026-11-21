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
	// Token: 0x02004BF0 RID: 19440
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelView : UiViewBase
	{
		// Token: 0x06030829 RID: 198697 RVA: 0x00D83482 File Offset: 0x00D81682
		public BossPilingLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603082A RID: 198698 RVA: 0x00D83498 File Offset: 0x00D81698
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

		// Token: 0x0603082B RID: 198699 RVA: 0x00D83739 File Offset: 0x00D81939
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603082C RID: 198700 RVA: 0x00D83757 File Offset: 0x00D81957
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603082D RID: 198701 RVA: 0x00D83778 File Offset: 0x00D81978
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603082E RID: 198702 RVA: 0x00D837BC File Offset: 0x00D819BC
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

		// Token: 0x0603082F RID: 198703 RVA: 0x00D83860 File Offset: 0x00D81A60
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

		// Token: 0x06030830 RID: 198704 RVA: 0x00D839A4 File Offset: 0x00D81BA4
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

		// Token: 0x06030831 RID: 198705 RVA: 0x00D83A83 File Offset: 0x00D81C83
		private BossPilingBuffSimpleItem CreateBuffItem()
		{
			return new BossPilingBuffSimpleItem();
		}

		// Token: 0x06030832 RID: 198706 RVA: 0x00D83A8A File Offset: 0x00D81C8A
		private BossPilingScoreTabItem CreateScoreItem()
		{
			return new BossPilingScoreTabItem();
		}

		// Token: 0x06030833 RID: 198707 RVA: 0x00D83A91 File Offset: 0x00D81C91
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06030834 RID: 198708 RVA: 0x00D83A9C File Offset: 0x00D81C9C
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

		// Token: 0x06030835 RID: 198709 RVA: 0x00D83AD8 File Offset: 0x00D81CD8
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

		// Token: 0x06030836 RID: 198710 RVA: 0x00D83BC8 File Offset: 0x00D81DC8
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x06030837 RID: 198711 RVA: 0x00D83BD8 File Offset: 0x00D81DD8
		private void OnClickedBuff()
		{
			BossPilingBuffViewInfo param = new BossPilingBuffViewInfo
			{
				LevelId = this.CurLevel,
				InGame = false
			};
			UiManager.Instance.OpenView(EUiViewName.BossPilingBuffView, param, null);
		}

		// Token: 0x04019ADA RID: 105178
		protected int CurLevel;

		// Token: 0x04019ADB RID: 105179
		protected List<BossPilingLevelDescInfo> LevelDataList = new List<BossPilingLevelDescInfo>();

		// Token: 0x04019ADC RID: 105180
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04019ADD RID: 105181
		protected GenericLayout<BossPilingBuffSimpleItem, int> BuffLayout;

		// Token: 0x04019ADE RID: 105182
		protected GenericLayout<BossPilingScoreTabItem, BossPilingScoreTabInfo> ScoreLayout;

		// Token: 0x04019ADF RID: 105183
		protected BossPilingLevelDescItem LevelInfo1;

		// Token: 0x04019AE0 RID: 105184
		protected BossPilingLevelDescItem LevelInfo2;

		// Token: 0x04019AE1 RID: 105185
		protected BossPilingTeamPanel PanelTeam;

		// Token: 0x0200A7F7 RID: 42999
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033E06 RID: 212486
			CaptionItem,
			// Token: 0x04033E07 RID: 212487
			TxtTitle,
			// Token: 0x04033E08 RID: 212488
			SpriteFrameHover,
			// Token: 0x04033E09 RID: 212489
			TxtBuffView,
			// Token: 0x04033E0A RID: 212490
			PanelBuff,
			// Token: 0x04033E0B RID: 212491
			BuffItem,
			// Token: 0x04033E0C RID: 212492
			TxtTitleScore,
			// Token: 0x04033E0D RID: 212493
			ContentScore,
			// Token: 0x04033E0E RID: 212494
			TargetItem,
			// Token: 0x04033E0F RID: 212495
			ScrollViewDefault,
			// Token: 0x04033E10 RID: 212496
			ContentLevelInfo,
			// Token: 0x04033E11 RID: 212497
			LevelInfo1,
			// Token: 0x04033E12 RID: 212498
			PanelTeam,
			// Token: 0x04033E13 RID: 212499
			BtnConfirm,
			// Token: 0x04033E14 RID: 212500
			BtnBuff,
			// Token: 0x04033E15 RID: 212501
			LevelInfo2
		}
	}
}
