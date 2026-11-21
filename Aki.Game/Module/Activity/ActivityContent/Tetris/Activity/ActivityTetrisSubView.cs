using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Activity
{
	// Token: 0x02002FFA RID: 12282
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityTetrisSubView : ActivitySubViewBase
	{
		// Token: 0x0601D278 RID: 119416 RVA: 0x008E8278 File Offset: 0x008E6478
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D279 RID: 119417 RVA: 0x008E8323 File Offset: 0x008E6523
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisDataUpdate));
		}

		// Token: 0x0601D27A RID: 119418 RVA: 0x008E8341 File Offset: 0x008E6541
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisDataUpdate));
		}

		// Token: 0x0601D27B RID: 119419 RVA: 0x008E8360 File Offset: 0x008E6560
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityTetrisSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTetrisSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D27C RID: 119420 RVA: 0x008E83A3 File Offset: 0x008E65A3
		protected override void OnRefreshView()
		{
			this.RefreshRedDot();
		}

		// Token: 0x0601D27D RID: 119421 RVA: 0x008E83AC File Offset: 0x008E65AC
		private void RefreshRedDot()
		{
			bool functionRedDotVisible = this.ActivityBaseData.GetPreGuideQuestFinishState() && ActivityTetrisController.Instance.GetRedPointShow();
			this.CommonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
		}

		// Token: 0x0601D27E RID: 119422 RVA: 0x008E83E0 File Offset: 0x008E65E0
		protected override void OnStart()
		{
			this.RefreshProgress();
		}

		// Token: 0x0601D27F RID: 119423 RVA: 0x008E83E8 File Offset: 0x008E65E8
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

		// Token: 0x0601D280 RID: 119424 RVA: 0x008E846B File Offset: 0x008E666B
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

		// Token: 0x0601D281 RID: 119425 RVA: 0x008E8489 File Offset: 0x008E6689
		private void OnTetrisDataUpdate(int challengeId)
		{
			this.RefreshProgress();
		}

		// Token: 0x0400F594 RID: 62868
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
