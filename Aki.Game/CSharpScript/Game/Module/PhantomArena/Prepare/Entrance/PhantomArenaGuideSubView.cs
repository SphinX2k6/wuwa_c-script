using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200413F RID: 16703
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaGuideSubView : ActivitySubViewBase
	{
		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x0602A3C1 RID: 172993 RVA: 0x00BEC47C File Offset: 0x00BEA67C
		protected new PhantomArenaGuideActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as PhantomArenaGuideActivityData;
			}
		}

		// Token: 0x0602A3C2 RID: 172994 RVA: 0x00BEC48C File Offset: 0x00BEA68C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickRewardBtn))
			};
		}

		// Token: 0x0602A3C3 RID: 172995 RVA: 0x00BEC54B File Offset: 0x00BEA74B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardInfo));
		}

		// Token: 0x0602A3C4 RID: 172996 RVA: 0x00BEC569 File Offset: 0x00BEA769
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardInfo));
		}

		// Token: 0x0602A3C5 RID: 172997 RVA: 0x00BEC588 File Offset: 0x00BEA788
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaGuideSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaGuideSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A3C6 RID: 172998 RVA: 0x00BEC5CC File Offset: 0x00BEA7CC
		protected override void OnBeforeShow()
		{
			string animationName = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "IdleF" : "IdleM";
			base.GetSpine(1).SetAnimation(0, animationName, true);
			bool exDataRedPointShowState = this.ActivityBaseData.GetExDataRedPointShowState();
			ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
			if (infoComponent == null)
			{
				return;
			}
			infoComponent.SetFunctionRedDotVisible(exDataRedPointShowState);
		}

		// Token: 0x0602A3C7 RID: 172999 RVA: 0x00BEC624 File Offset: 0x00BEA824
		protected override void OnRefreshView()
		{
			int questId = this.ActivityBaseData.GetQuestId();
			string textId = QuestNewModel.Instance.CheckQuestFinished(questId) ? "Activity_107200001_Challenge" : "Activity_107200001_Mission";
			this.InfoComponent.SetBtnText(textId, Array.Empty<object>());
			this.InfoComponent.RefreshFunction();
			this.RefreshRewardInfo();
		}

		// Token: 0x0602A3C8 RID: 173000 RVA: 0x00BEC67C File Offset: 0x00BEA87C
		private void RefreshRewardInfo()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			int targetNum = this.ActivityBaseData.GetTargetNum();
			int finishedChallengeCount = PhantomArenaModel.Instance.GetFinishedChallengeCount(this.ActivityBaseData.GetPhantomArenaActivityId());
			bool flag2 = finishedChallengeCount >= targetNum && !this.ActivityBaseData.GetIsReceiveReward();
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(!flag);
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetUIActive(flag && !flag2);
			}
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag && flag2);
			}
			UUIText text2 = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(finishedChallengeCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetNum);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602A3C9 RID: 173001 RVA: 0x00BEC75B File Offset: 0x00BEA95B
		private void OnRefreshRewardInfo(int activityId)
		{
			if (this.ActivityBaseData.Id == activityId)
			{
				this.RefreshRewardInfo();
			}
		}

		// Token: 0x0602A3CA RID: 173002 RVA: 0x00BEC771 File Offset: 0x00BEA971
		private void OnClickConfirm(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				int questId = this.ActivityBaseData.GetQuestId();
				if (QuestNewModel.Instance.CheckQuestFinished(questId))
				{
					PhantomArenaBattleController.OpenPhantomArenaMapEntrance(null, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
			});
		}

		// Token: 0x0602A3CB RID: 173003 RVA: 0x00BEC78F File Offset: 0x00BEA98F
		private void OnClickRewardBtn()
		{
			PhantomArenaGuideController.RequestReward(this.ActivityBaseData.Id);
		}

		// Token: 0x04016FC0 RID: 94144
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x02009D0C RID: 40204
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030D3A RID: 199994
			public const int InfoItem = 0;

			// Token: 0x04030D3B RID: 199995
			public const int ItemSpine = 1;

			// Token: 0x04030D3C RID: 199996
			public const int LayoutReward = 2;

			// Token: 0x04030D3D RID: 199997
			public const int SpriteLock = 3;

			// Token: 0x04030D3E RID: 199998
			public const int TextProgress = 4;

			// Token: 0x04030D3F RID: 199999
			public const int BtnReward = 5;
		}
	}
}
