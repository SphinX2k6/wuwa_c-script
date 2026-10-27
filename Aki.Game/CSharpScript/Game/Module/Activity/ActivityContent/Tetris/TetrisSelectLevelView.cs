using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006015 RID: 24597
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisSelectLevelView : UiViewBase
	{
		// Token: 0x0603E499 RID: 255129 RVA: 0x00F0B398 File Offset: 0x00F09598
		public TetrisSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E49A RID: 255130 RVA: 0x00F0B3A8 File Offset: 0x00F095A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603E49B RID: 255131 RVA: 0x00F0B418 File Offset: 0x00F09618
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisSelectLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisSelectLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E49C RID: 255132 RVA: 0x00F0B45C File Offset: 0x00F0965C
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetTitle(ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3394563466_Text", null) ?? "");
			this.CaptionItem.SetHelpBtnActive(true);
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
		}

		// Token: 0x0603E49D RID: 255133 RVA: 0x00F0B4D4 File Offset: 0x00F096D4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603E49E RID: 255134 RVA: 0x00F0B4F2 File Offset: 0x00F096F2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603E49F RID: 255135 RVA: 0x00F0B510 File Offset: 0x00F09710
		protected override void OnBeforeShow()
		{
			this.LevelScroll.RefreshByData(ActivityTetrisController.Instance.GetAllLevelSelectData(), null, false);
			this.RefreshScrollPercentage();
		}

		// Token: 0x0603E4A0 RID: 255136 RVA: 0x00F0B530 File Offset: 0x00F09730
		private void RefreshScrollPercentage()
		{
			TetrisSelectLevelView.<>c__DisplayClass11_0 CS$<>8__locals1 = new TetrisSelectLevelView.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			List<ITetrisSelectGroupData> allLevelSelectData = ActivityTetrisController.Instance.GetAllLevelSelectData();
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
					ITetrisSelectGroupData tetrisSelectGroupData = allLevelSelectData[j];
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

		// Token: 0x0603E4A1 RID: 255137 RVA: 0x00F0B6DF File Offset: 0x00F098DF
		private TetrisSelectLevelItemGrid UpdateItem()
		{
			return new TetrisSelectLevelItemGrid();
		}

		// Token: 0x0603E4A2 RID: 255138 RVA: 0x00F0B6E6 File Offset: 0x00F098E6
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0603E4A3 RID: 255139 RVA: 0x00F0B704 File Offset: 0x00F09904
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisSelectLevelView, null);
		}

		// Token: 0x0603E4A4 RID: 255140 RVA: 0x00F0B718 File Offset: 0x00F09918
		private void OnClickHelpBtn()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(tetrisData.LocalConfig.Value.HelpId);
		}

		// Token: 0x040208DC RID: 133340
		private const int ANIM_ENDCOUNT = 15;

		// Token: 0x040208DD RID: 133341
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040208DE RID: 133342
		private GenericLayout<TetrisSelectLevelItemGrid, ITetrisSelectGroupData> LevelScroll;

		// Token: 0x040208DF RID: 133343
		public int ExecuteCount = 1;
	}
}
