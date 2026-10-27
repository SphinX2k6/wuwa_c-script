using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006652 RID: 26194
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEncircleSubView : ActivitySubViewBase
	{
		// Token: 0x06041A9B RID: 268955 RVA: 0x00FED468 File Offset: 0x00FEB668
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06041A9C RID: 268956 RVA: 0x00FED4C2 File Offset: 0x00FEB6C2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041A9D RID: 268957 RVA: 0x00FED4E0 File Offset: 0x00FEB6E0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041A9E RID: 268958 RVA: 0x00FED500 File Offset: 0x00FEB700
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityEncircleSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityEncircleSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041A9F RID: 268959 RVA: 0x00FED543 File Offset: 0x00FEB743
		protected override void OnRefreshView()
		{
			this.RefreshRedDot();
		}

		// Token: 0x06041AA0 RID: 268960 RVA: 0x00FED54B File Offset: 0x00FEB74B
		private void RefreshRedDot()
		{
			this.CommonInfoPanel.SetFunctionRedDotVisible(ActivityEncircleController.Instance.GetRedPointShow());
		}

		// Token: 0x06041AA1 RID: 268961 RVA: 0x00FED562 File Offset: 0x00FEB762
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

		// Token: 0x06041AA2 RID: 268962 RVA: 0x00FED580 File Offset: 0x00FEB780
		protected override void OnStart()
		{
			this.RefreshProgress();
		}

		// Token: 0x06041AA3 RID: 268963 RVA: 0x00FED588 File Offset: 0x00FEB788
		private void RefreshProgress()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(encircleData.GetCompleteChallengeCount().ToString() + "/" + encircleData.GetCurrentChallengeCount().ToString(), true);
		}

		// Token: 0x06041AA4 RID: 268964 RVA: 0x00FED5D8 File Offset: 0x00FEB7D8
		[NullableContext(1)]
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			this.RefreshProgress();
		}

		// Token: 0x04022294 RID: 139924
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
