using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FDD RID: 12253
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisSelectLevelView : UiViewBase
	{
		// Token: 0x0601D15C RID: 119132 RVA: 0x008E40FC File Offset: 0x008E22FC
		public TetrisSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D15D RID: 119133 RVA: 0x008E410C File Offset: 0x008E230C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x008E41B8 File Offset: 0x008E23B8
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisSelectLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisSelectLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D15F RID: 119135 RVA: 0x008E41FC File Offset: 0x008E23FC
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData != null)
			{
				this.CaptionItem.SetTitleLocalText(tetrisData.GetTitleTextId());
			}
			else
			{
				this.CaptionItem.SetTitle(ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3394563466_Text", null) ?? "");
			}
			this.CaptionItem.SetHelpBtnActive(true);
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
		}

		// Token: 0x0601D160 RID: 119136 RVA: 0x008E4295 File Offset: 0x008E2495
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D161 RID: 119137 RVA: 0x008E42B3 File Offset: 0x008E24B3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D162 RID: 119138 RVA: 0x008E42D1 File Offset: 0x008E24D1
		protected override void OnBeforeShow()
		{
			this.LevelScroll.RefreshByData(ActivityTetrisController.Instance.GetAllLevelSelectData(), null, false);
			this.RefreshScrollPercentage();
		}

		// Token: 0x0601D163 RID: 119139 RVA: 0x008E42F0 File Offset: 0x008E24F0
		private void RefreshScrollPercentage()
		{
			TetrisSelectLevelView.<>c__DisplayClass11_0 CS$<>8__locals1 = new TetrisSelectLevelView.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			List<TetrisSelectGroupData> allLevelSelectData = ActivityTetrisController.Instance.GetAllLevelSelectData();
			if (allLevelSelectData == null || allLevelSelectData.Count == 0)
			{
				return;
			}
			CS$<>8__locals1.targetIndex = 0;
			bool flag = false;
			for (int i = 0; i < allLevelSelectData.Count; i++)
			{
				int challengeId = allLevelSelectData[i].ChallengeIds[0];
				if (tetrisData.CheckChallengeIsOpen(challengeId) && tetrisData.CheckPreChallengeComplete(challengeId) && !tetrisData.CheckChallengeComplete(challengeId))
				{
					CS$<>8__locals1.targetIndex = i;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < allLevelSelectData.Count; j++)
				{
					TetrisSelectGroupData tetrisSelectGroupData = allLevelSelectData[j];
					if (tetrisSelectGroupData.ChallengeIds.Count > 1)
					{
						int challengeId2 = tetrisSelectGroupData.ChallengeIds[1];
						if (tetrisData.CheckChallengeIsOpen(challengeId2) && tetrisData.CheckPreChallengeComplete(challengeId2) && !tetrisData.CheckChallengeComplete(challengeId2))
						{
							CS$<>8__locals1.targetIndex = j;
							flag = true;
							break;
						}
					}
				}
			}
			if (!flag)
			{
				for (int k = allLevelSelectData.Count - 1; k >= 0; k--)
				{
					int challengeId3 = allLevelSelectData[k].ChallengeIds[0];
					if (tetrisData.CheckChallengeIsOpen(challengeId3) && tetrisData.CheckPreChallengeComplete(challengeId3))
					{
						CS$<>8__locals1.targetIndex = k;
						break;
					}
				}
			}
			CS$<>8__locals1.percentage = (float)CS$<>8__locals1.targetIndex / (float)allLevelSelectData.Count;
			if (float.IsNaN(CS$<>8__locals1.percentage) || allLevelSelectData.Count <= 1)
			{
				return;
			}
			CS$<>8__locals1.scrollItem = base.GetScrollViewWithScrollbar(1);
			CS$<>8__locals1.scrollItem.OnLateUpdate.Bind(new Action<float>(CS$<>8__locals1.<RefreshScrollPercentage>g__callBack|0));
		}

		// Token: 0x0601D164 RID: 119140 RVA: 0x008E449F File Offset: 0x008E269F
		private TetrisSelectLevelItemGrid UpdateItem()
		{
			return new TetrisSelectLevelItemGrid();
		}

		// Token: 0x0601D165 RID: 119141 RVA: 0x008E44A6 File Offset: 0x008E26A6
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0601D166 RID: 119142 RVA: 0x008E44C4 File Offset: 0x008E26C4
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisSelectLevelView, null);
		}

		// Token: 0x0601D167 RID: 119143 RVA: 0x008E44D8 File Offset: 0x008E26D8
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

		// Token: 0x0400F523 RID: 62755
		private const int ANIM_ENDCOUNT = 15;

		// Token: 0x0400F524 RID: 62756
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F525 RID: 62757
		private GenericLayout<TetrisSelectLevelItemGrid, TetrisSelectGroupData> LevelScroll;

		// Token: 0x0400F526 RID: 62758
		public int ExecuteCount = 1;
	}
}
