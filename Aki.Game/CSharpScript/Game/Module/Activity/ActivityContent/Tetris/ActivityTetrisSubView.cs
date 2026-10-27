using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FCA RID: 24522
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityTetrisSubView : ActivitySubViewBase
	{
		// Token: 0x0603E264 RID: 254564 RVA: 0x00F02878 File Offset: 0x00F00A78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603E265 RID: 254565 RVA: 0x00F028E8 File Offset: 0x00F00AE8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisDataUpdate));
		}

		// Token: 0x0603E266 RID: 254566 RVA: 0x00F02906 File Offset: 0x00F00B06
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisDataUpdate));
		}

		// Token: 0x0603E267 RID: 254567 RVA: 0x00F02924 File Offset: 0x00F00B24
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityTetrisSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTetrisSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E268 RID: 254568 RVA: 0x00F02967 File Offset: 0x00F00B67
		protected override void OnRefreshView()
		{
			this.RefreshRedDot();
		}

		// Token: 0x0603E269 RID: 254569 RVA: 0x00F02970 File Offset: 0x00F00B70
		private void RefreshRedDot()
		{
			bool functionRedDotVisible = this.ActivityBaseData.GetPreGuideQuestFinishState() && ActivityTetrisController.Instance.GetRedPointShow();
			this.CommonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
		}

		// Token: 0x0603E26A RID: 254570 RVA: 0x00F029A4 File Offset: 0x00F00BA4
		protected override void OnStart()
		{
			this.RefreshProgress();
		}

		// Token: 0x0603E26B RID: 254571 RVA: 0x00F029AC File Offset: 0x00F00BAC
		private void RefreshProgress()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(3);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(tetrisData.GetCompleteChallengeCount().ToString() + "/" + tetrisData.GetDisplayChallengeCount().ToString(), true);
				return;
			}
		}

		// Token: 0x0603E26C RID: 254572 RVA: 0x00F02A2F File Offset: 0x00F00C2F
		private void OnClickedMapButton(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
					return;
				}
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.TetrisSelectLevelView, null, null);
			});
		}

		// Token: 0x0603E26D RID: 254573 RVA: 0x00F02A4D File Offset: 0x00F00C4D
		private void OnTetrisDataUpdate(int challengeId)
		{
			this.RefreshProgress();
		}

		// Token: 0x0402076E RID: 132974
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
