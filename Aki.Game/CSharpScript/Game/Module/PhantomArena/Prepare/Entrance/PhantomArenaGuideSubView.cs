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
	// Token: 0x0200516F RID: 20847
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaGuideSubView : ActivitySubViewBase
	{
		// Token: 0x1700811C RID: 33052
		// (get) Token: 0x060354C5 RID: 218309 RVA: 0x00C9EF30 File Offset: 0x00C9D130
		protected new PhantomArenaGuideActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as PhantomArenaGuideActivityData;
			}
		}

		// Token: 0x060354C6 RID: 218310 RVA: 0x00C9EF40 File Offset: 0x00C9D140
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

		// Token: 0x060354C7 RID: 218311 RVA: 0x00C9EFFF File Offset: 0x00C9D1FF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardInfo));
		}

		// Token: 0x060354C8 RID: 218312 RVA: 0x00C9F01D File Offset: 0x00C9D21D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardInfo));
		}

		// Token: 0x060354C9 RID: 218313 RVA: 0x00C9F03C File Offset: 0x00C9D23C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaGuideSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaGuideSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060354CA RID: 218314 RVA: 0x00C9F080 File Offset: 0x00C9D280
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

		// Token: 0x060354CB RID: 218315 RVA: 0x00C9F0D8 File Offset: 0x00C9D2D8
		protected override void OnRefreshView()
		{
			int questId = this.ActivityBaseData.GetQuestId();
			string textId = QuestNewModel.Instance.CheckQuestFinished(questId) ? "Activity_107200001_Challenge" : "Activity_107200001_Mission";
			this.InfoComponent.SetBtnText(textId, Array.Empty<object>());
			this.InfoComponent.RefreshFunction();
			this.RefreshRewardInfo();
		}

		// Token: 0x060354CC RID: 218316 RVA: 0x00C9F130 File Offset: 0x00C9D330
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

		// Token: 0x060354CD RID: 218317 RVA: 0x00C9F20F File Offset: 0x00C9D40F
		private void OnRefreshRewardInfo(int activityId)
		{
			if (this.ActivityBaseData.Id == activityId)
			{
				this.RefreshRewardInfo();
			}
		}

		// Token: 0x060354CE RID: 218318 RVA: 0x00C9F225 File Offset: 0x00C9D425
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

		// Token: 0x060354CF RID: 218319 RVA: 0x00C9F243 File Offset: 0x00C9D443
		private void OnClickRewardBtn()
		{
			PhantomArenaGuideController.RequestReward(this.ActivityBaseData.Id);
		}

		// Token: 0x0401C58B RID: 116107
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x0200B2D2 RID: 45778
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040362E3 RID: 221923
			public const int InfoItem = 0;

			// Token: 0x040362E4 RID: 221924
			public const int ItemSpine = 1;

			// Token: 0x040362E5 RID: 221925
			public const int LayoutReward = 2;

			// Token: 0x040362E6 RID: 221926
			public const int SpriteLock = 3;

			// Token: 0x040362E7 RID: 221927
			public const int TextProgress = 4;

			// Token: 0x040362E8 RID: 221928
			public const int BtnReward = 5;
		}
	}
}
