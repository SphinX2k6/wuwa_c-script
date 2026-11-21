using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02002FFF RID: 12287
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEncircleSubView : ActivitySubViewBase
	{
		// Token: 0x0601D2B9 RID: 119481 RVA: 0x008E8E50 File Offset: 0x008E7050
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D2BA RID: 119482 RVA: 0x008E8EDA File Offset: 0x008E70DA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D2BB RID: 119483 RVA: 0x008E8EF8 File Offset: 0x008E70F8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D2BC RID: 119484 RVA: 0x008E8F18 File Offset: 0x008E7118
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityEncircleSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityEncircleSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D2BD RID: 119485 RVA: 0x008E8F5B File Offset: 0x008E715B
		protected override void OnRefreshView()
		{
			this.RefreshRedDot();
		}

		// Token: 0x0601D2BE RID: 119486 RVA: 0x008E8F63 File Offset: 0x008E7163
		private void RefreshRedDot()
		{
			this.CommonInfoPanel.SetFunctionRedDotVisible(ActivityEncircleController.Instance.GetRedPointShow());
		}

		// Token: 0x0601D2BF RID: 119487 RVA: 0x008E8F7A File Offset: 0x008E717A
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
				UiManager.Instance.OpenView(EUiViewName.EncircleSelectLevelView, null, null);
			});
		}

		// Token: 0x0601D2C0 RID: 119488 RVA: 0x008E8F98 File Offset: 0x008E7198
		protected override void OnStart()
		{
			this.RefreshProgress();
		}

		// Token: 0x0601D2C1 RID: 119489 RVA: 0x008E8FA0 File Offset: 0x008E71A0
		private void RefreshProgress()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			StringBuilder stringBuilder = new StringBuilder().Append(encircleData.GetCompleteChallengeCount()).Append('/').Append(encircleData.GetCurrentChallengeCount());
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(stringBuilder.ToString(), true);
		}

		// Token: 0x0601D2C2 RID: 119490 RVA: 0x008E8FF3 File Offset: 0x008E71F3
		[NullableContext(1)]
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			this.RefreshProgress();
		}

		// Token: 0x0400F59E RID: 62878
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
