using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005457 RID: 21591
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGameplayView : UiViewBase
	{
		// Token: 0x06035922 RID: 219426 RVA: 0x00EF65E4 File Offset: 0x00EF47E4
		public MatchThreeGameplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035923 RID: 219427 RVA: 0x00EF66F4 File Offset: 0x00EF48F4
		private UniTask LoadTrailCurvesAsync()
		{
			MatchThreeGameplayView.<LoadTrailCurvesAsync>d__30 <LoadTrailCurvesAsync>d__;
			<LoadTrailCurvesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTrailCurvesAsync>d__.<>4__this = this;
			<LoadTrailCurvesAsync>d__.<>1__state = -1;
			<LoadTrailCurvesAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<LoadTrailCurvesAsync>d__30>(ref <LoadTrailCurvesAsync>d__);
			return <LoadTrailCurvesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035924 RID: 219428 RVA: 0x00EF6738 File Offset: 0x00EF4938
		private void ReadFallCurveRange()
		{
			this.FallCurveStart = 0f;
			this.FallCurveLand = 1f;
			this.FallCurveEnd = 1f;
			UCurveFloat fallCurve = this.FallCurve;
			TArray<FRichCurveKey> tarray = (fallCurve != null) ? fallCurve.FloatCurve.Keys : null;
			if (tarray == null || tarray.Count == 0)
			{
				return;
			}
			float time = tarray[tarray.Count - 1].Time;
			float time2 = tarray[0].Time;
			if (time <= 0f || time <= time2)
			{
				return;
			}
			this.FallCurveStart = ((time2 < 0f) ? 0f : time2);
			this.FallCurveEnd = time;
			this.FallCurveLand = time;
			for (int i = 0; i < tarray.Count; i++)
			{
				if (tarray[i].Value >= 1f)
				{
					this.FallCurveLand = tarray[i].Time;
					break;
				}
			}
			if (this.FallCurveLand <= this.FallCurveStart)
			{
				this.FallCurveLand = time;
			}
		}

		// Token: 0x06035925 RID: 219429 RVA: 0x00EF682C File Offset: 0x00EF4A2C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<UCurveFloat> LoadCurveAsync(EMatchThreeResourceId resourceId)
		{
			MatchThreeGameplayView.<LoadCurveAsync>d__32 <LoadCurveAsync>d__;
			<LoadCurveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
			<LoadCurveAsync>d__.resourceId = resourceId;
			<LoadCurveAsync>d__.<>1__state = -1;
			<LoadCurveAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<LoadCurveAsync>d__32>(ref <LoadCurveAsync>d__);
			return <LoadCurveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035926 RID: 219430 RVA: 0x00EF6870 File Offset: 0x00EF4A70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 34;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickRoleInfo));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.OnClickEnvInfo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035927 RID: 219431 RVA: 0x00EF6D75 File Offset: 0x00EF4F75
		protected override void OnBeforeCreate()
		{
			this.Presenter = (this.OpenParam as MatchThreePresenter);
			MatchThreePresenter presenter = this.Presenter;
			if (presenter == null)
			{
				return;
			}
			presenter.BindView(this);
		}

		// Token: 0x06035928 RID: 219432 RVA: 0x00EF6D9C File Offset: 0x00EF4F9C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ELGUINavigationDirection>(EEventName.MatchThreeSwapPieceInput, new Action<ELGUINavigationDirection>(this.OnSwapPieceInput));
			EventSystem.Instance.Add(EEventName.OnMatchThreeBoardSettled, new Action(this.RestoreSwapNavigationFocus));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06035929 RID: 219433 RVA: 0x00EF6E00 File Offset: 0x00EF5000
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ELGUINavigationDirection>(EEventName.MatchThreeSwapPieceInput, new Action<ELGUINavigationDirection>(this.OnSwapPieceInput));
			EventSystem.Instance.Remove(EEventName.OnMatchThreeBoardSettled, new Action(this.RestoreSwapNavigationFocus));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0603592A RID: 219434 RVA: 0x00EF6E64 File Offset: 0x00EF5064
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeGameplayView.<OnBeforeStartAsync>d__37 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<OnBeforeStartAsync>d__37>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603592B RID: 219435 RVA: 0x00EF6EA7 File Offset: 0x00EF50A7
		protected override void OnAfterPlayStartSequence()
		{
			if (!this.ShowTargetPop())
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter == null)
				{
					return;
				}
				presenter.TryPlayInitialGuideThenMechanicTipsAsync().Forget();
			}
		}

		// Token: 0x0603592C RID: 219436 RVA: 0x00EF6EC8 File Offset: 0x00EF50C8
		public bool ShowTargetPop()
		{
			if (this.Presenter == null)
			{
				return false;
			}
			MatchThreeTargetPopParam param = new MatchThreeTargetPopParam(this.Presenter.Goals, delegate()
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter == null)
				{
					return;
				}
				presenter.TryPlayInitialGuideThenMechanicTipsAsync().Forget();
			});
			UiManager.Instance.OpenView(EUiViewName.MatchThreeTargetPopView, param, delegate(bool success, int _)
			{
				if (!success)
				{
					MatchThreePresenter presenter = this.Presenter;
					if (presenter == null)
					{
						return;
					}
					presenter.TryPlayInitialGuideThenMechanicTipsAsync().Forget();
				}
			});
			return true;
		}

		// Token: 0x0603592D RID: 219437 RVA: 0x00EF6F1C File Offset: 0x00EF511C
		private void OnClickClose()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchThreeExitConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				MatchThreeController.Instance.Restart(false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter == null)
				{
					return;
				}
				presenter.HandleExitConfirmed();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603592E RID: 219438 RVA: 0x00EF6F8A File Offset: 0x00EF518A
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(683);
		}

		// Token: 0x0603592F RID: 219439 RVA: 0x00EF6F9C File Offset: 0x00EF519C
		private UniTask RefreshRoleAsync()
		{
			MatchThreeGameplayView.<RefreshRoleAsync>d__42 <RefreshRoleAsync>d__;
			<RefreshRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleAsync>d__.<>4__this = this;
			<RefreshRoleAsync>d__.<>1__state = -1;
			<RefreshRoleAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<RefreshRoleAsync>d__42>(ref <RefreshRoleAsync>d__);
			return <RefreshRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035930 RID: 219440 RVA: 0x00EF6FE0 File Offset: 0x00EF51E0
		private void RefreshLevelStyle()
		{
			MatchThreePresenter presenter = this.Presenter;
			IReadOnlyList<LevelGoal> readOnlyList = (presenter != null) ? presenter.Goals : null;
			LevelGoal levelGoal = (readOnlyList != null && readOnlyList.Count > 0) ? readOnlyList[0] : null;
			bool flag = levelGoal == null;
			ClearTypeCountGoal clearTypeCountGoal = levelGoal as ClearTypeCountGoal;
			string text;
			if (clearTypeCountGoal != null)
			{
				text = MatchThreeGameplayDefine.GetPieceRes(clearTypeCountGoal.TargetType).Item2;
			}
			else
			{
				text = EMatchThreeResourceId.IconScore.ToEnumString();
			}
			string resourceId = text;
			base.TrySetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetSprite(11), false, null, null);
			UUISprite sprite = base.GetSprite(20);
			if (sprite != null)
			{
				this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath((flag ? EMatchThreeResourceId.ProgressBgEndless : EMatchThreeResourceId.ProgressBgNormal).ToEnumString()), sprite, false, null, null);
			}
			UUIItem item = base.GetItem(27);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(28);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			this.RefreshRecord(flag);
		}

		// Token: 0x06035931 RID: 219441 RVA: 0x00EF70D8 File Offset: 0x00EF52D8
		private void RefreshRecord(bool isEndless)
		{
			UUIText text = base.GetText(32);
			if (text != null)
			{
				text.SetUIActive(isEndless);
			}
			if (!isEndless || text == null)
			{
				return;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			int levelId = (context != null) ? context.LevelId : 0;
			int num = (matchThreeData != null) ? matchThreeData.GetEndlessBestScore(levelId) : 0;
			if (num > 0)
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_BestRecord", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_NoRecord", Array.Empty<object>());
		}

		// Token: 0x06035932 RID: 219442 RVA: 0x00EF7164 File Offset: 0x00EF5364
		private void OnClickRoleInfo()
		{
			ActivityMatchThreeController instance = ActivityMatchThreeController.Instance;
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			instance.OpenRoleInfo((context != null) ? context.RoleId : 0, null);
		}

		// Token: 0x06035933 RID: 219443 RVA: 0x00EF7188 File Offset: 0x00EF5388
		private void OnClickEnvInfo()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (context == null)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(context.LevelId, context.RoleId, true, 0, 0);
		}

		// Token: 0x06035934 RID: 219444 RVA: 0x00EF71BD File Offset: 0x00EF53BD
		private void PlayRoleAmbientAnim()
		{
			this.SetRoleAnim(this.RoleAmbientAnims[this.RoleAnimRandom.Next(this.RoleAmbientAnims.Length)].ToEnumString());
		}

		// Token: 0x06035935 RID: 219445 RVA: 0x00EF71E4 File Offset: 0x00EF53E4
		private void SetRoleAnim(string anim)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(12);
			if (spine != null)
			{
				spine.SetAnimation(0, anim, false);
			}
			USpineSkeletonAnimationComponent spine2 = base.GetSpine(23);
			if (spine2 == null)
			{
				return;
			}
			spine2.SetAnimation(0, anim, false);
		}

		// Token: 0x06035936 RID: 219446 RVA: 0x00EF7213 File Offset: 0x00EF5413
		[NullableContext(2)]
		private void OnRoleAnimComplete(UTrackEntry entry)
		{
			if (entry == null)
			{
				return;
			}
			AutoResetUniTaskCompletionSource roleSkillTcs = this.RoleSkillTcs;
			this.RoleSkillTcs = null;
			if (roleSkillTcs != null)
			{
				roleSkillTcs.TrySetResult();
			}
			this.PlayRoleAmbientAnim();
		}

		// Token: 0x06035937 RID: 219447 RVA: 0x00EF7238 File Offset: 0x00EF5438
		public UniTask PlayRoleSkillAnimAsync(bool isUltimate)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(12);
			if (!this.RoleSpineReady || spine == null)
			{
				return UniTask.CompletedTask;
			}
			AutoResetUniTaskCompletionSource roleSkillTcs = this.RoleSkillTcs;
			this.RoleSkillTcs = null;
			if (roleSkillTcs != null)
			{
				roleSkillTcs.TrySetResult();
			}
			this.SetRoleAnim((isUltimate ? EMatchThreeRoleSpineAnim.Skill2 : EMatchThreeRoleSpineAnim.Skill1).ToEnumString());
			this.RoleSkillTcs = AutoResetUniTaskCompletionSource.Create();
			return this.RoleSkillTcs.Task;
		}

		// Token: 0x06035938 RID: 219448 RVA: 0x00EF72A0 File Offset: 0x00EF54A0
		private void ClearRoleSpine()
		{
			if (this.RoleSpineReady)
			{
				USpineSkeletonAnimationComponent spine = base.GetSpine(12);
				if (spine != null)
				{
					spine.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnRoleAnimComplete));
				}
				this.RoleSpineReady = false;
			}
			AutoResetUniTaskCompletionSource roleSkillTcs = this.RoleSkillTcs;
			this.RoleSkillTcs = null;
			if (roleSkillTcs == null)
			{
				return;
			}
			roleSkillTcs.TrySetResult();
		}

		// Token: 0x06035939 RID: 219449 RVA: 0x00EF72F8 File Offset: 0x00EF54F8
		public void SetRayMaskActive(bool active)
		{
			UUIItem item = base.GetItem(22);
			if (item != null)
			{
				item.SetUIActive(active);
			}
			if (active)
			{
				this.PauseHint();
				return;
			}
			this.ResumeHint();
		}

		// Token: 0x0603593A RID: 219450 RVA: 0x00EF731E File Offset: 0x00EF551E
		public void SetBoardNavigationInputBlocked(bool blocked)
		{
			if (this.BoardNavigationInputBlocked == blocked)
			{
				return;
			}
			this.BoardNavigationInputBlocked = blocked;
			if (blocked)
			{
				UiNavigationGlobalData.AddBlockListenerFocusTag("MatchThreeGameplayBoard");
				UiNavigationNewController.Instance.SwitchNavigationFocus(null);
				return;
			}
			UiNavigationGlobalData.DeleteBlockListenerFocusTag("MatchThreeGameplayBoard");
		}

		// Token: 0x0603593B RID: 219451 RVA: 0x00EF7354 File Offset: 0x00EF5554
		public void ResetHintCountdown()
		{
			this.HintRemainMs = (double)this.HintThresholdMs;
			this.HintMove = null;
		}

		// Token: 0x0603593C RID: 219452 RVA: 0x00EF736F File Offset: 0x00EF556F
		private void PauseHint()
		{
			if (this.HintTimer != null)
			{
				this.HintRemainMs = this.HintDeadlineMs - Time.Instance.Now;
				this.HintTimer.Remove();
				this.HintTimer = null;
			}
			this.StopHintPieces();
		}

		// Token: 0x0603593D RID: 219453 RVA: 0x00EF73AC File Offset: 0x00EF55AC
		private void ResumeHint()
		{
			if (this.HintThresholdMs > 0 && this.HintTimer == null)
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter != null && !presenter.IsGameOver)
				{
					if (this.HintRemainMs < 20.0)
					{
						this.ShowHint();
						return;
					}
					this.HintDeadlineMs = Time.Instance.Now + this.HintRemainMs;
					this.HintTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnHintTimeout), (float)this.HintRemainMs, null, null, true, 1f);
					return;
				}
			}
		}

		// Token: 0x0603593E RID: 219454 RVA: 0x00EF7439 File Offset: 0x00EF5639
		private void OnHintTimeout(float delta)
		{
			this.HintTimer = null;
			this.HintRemainMs = 0.0;
			this.ShowHint();
		}

		// Token: 0x0603593F RID: 219455 RVA: 0x00EF7458 File Offset: 0x00EF5658
		private void ShowHint()
		{
			MatchThreePresenter presenter = this.Presenter;
			IReadOnlyList<ValidMove> readOnlyList = (presenter != null) ? presenter.LastValidMoves : null;
			if (readOnlyList == null || readOnlyList.Count == 0)
			{
				return;
			}
			ValidMove value = this.HintMove.GetValueOrDefault();
			if (this.HintMove == null)
			{
				value = readOnlyList[Random.Shared.Next(readOnlyList.Count)];
				this.HintMove = new ValidMove?(value);
			}
			ValidMove value2 = this.HintMove.Value;
			this.HintPieceA = this.GetPiece(value2.A);
			this.HintPieceB = this.GetPiece(value2.B);
			MatchThreePieceView hintPieceA = this.HintPieceA;
			if (hintPieceA != null)
			{
				hintPieceA.StartHint();
			}
			MatchThreePieceView hintPieceB = this.HintPieceB;
			if (hintPieceB == null)
			{
				return;
			}
			hintPieceB.StartHint();
		}

		// Token: 0x06035940 RID: 219456 RVA: 0x00EF7511 File Offset: 0x00EF5711
		private void StopHintPieces()
		{
			MatchThreePieceView hintPieceA = this.HintPieceA;
			if (hintPieceA != null)
			{
				hintPieceA.StopHint();
			}
			MatchThreePieceView hintPieceB = this.HintPieceB;
			if (hintPieceB != null)
			{
				hintPieceB.StopHint();
			}
			this.HintPieceA = null;
			this.HintPieceB = null;
		}

		// Token: 0x06035941 RID: 219457 RVA: 0x00EF7544 File Offset: 0x00EF5744
		private UniTask CreatePieceAsync(GridPosition pos, Piece piece)
		{
			MatchThreeGameplayView.<CreatePieceAsync>d__72 <CreatePieceAsync>d__;
			<CreatePieceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePieceAsync>d__.<>4__this = this;
			<CreatePieceAsync>d__.pos = pos;
			<CreatePieceAsync>d__.piece = piece;
			<CreatePieceAsync>d__.<>1__state = -1;
			<CreatePieceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<CreatePieceAsync>d__72>(ref <CreatePieceAsync>d__);
			return <CreatePieceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035942 RID: 219458 RVA: 0x00EF7598 File Offset: 0x00EF5798
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<MatchThreePieceView> BuildViewAsync(GridPosition pos, EPieceType type, bool skipInitialVisualReset = false)
		{
			MatchThreeGameplayView.<BuildViewAsync>d__73 <BuildViewAsync>d__;
			<BuildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MatchThreePieceView>.Create();
			<BuildViewAsync>d__.<>4__this = this;
			<BuildViewAsync>d__.pos = pos;
			<BuildViewAsync>d__.type = type;
			<BuildViewAsync>d__.skipInitialVisualReset = skipInitialVisualReset;
			<BuildViewAsync>d__.<>1__state = -1;
			<BuildViewAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<BuildViewAsync>d__73>(ref <BuildViewAsync>d__);
			return <BuildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035943 RID: 219459 RVA: 0x00EF75F3 File Offset: 0x00EF57F3
		public void RefreshMechanics()
		{
			if (this.MechanicsLayout == null || this.Presenter == null)
			{
				return;
			}
			this.MechanicsLayout.RefreshByData(this.Presenter.CollectMechanicDisplays(), null, false);
		}

		// Token: 0x06035944 RID: 219460 RVA: 0x00EF7620 File Offset: 0x00EF5820
		public void RefreshGoalProgress()
		{
			if (this.Presenter == null)
			{
				return;
			}
			IReadOnlyList<LevelGoal> goals = this.Presenter.Goals;
			LevelGoal levelGoal = (goals != null && goals.Count > 0) ? goals[0] : null;
			if (levelGoal == null)
			{
				UUISprite sprite = base.GetSprite(9);
				if (sprite != null)
				{
					sprite.SetFillAmount(1f);
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(10), EMatchThreeTextId.GameplayScoreEndless.ToEnumString(), new <>z__ReadOnlySingleElementList<object>(this.Presenter.Score));
				return;
			}
			UUISprite sprite2 = base.GetSprite(9);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount((levelGoal.Target > 0) ? ((float)levelGoal.Current / (float)levelGoal.Target) : 1f);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(10), EMatchThreeTextId.GameplayScoreNormal.ToEnumString(), new <>z__ReadOnlyArray<object>(new object[]
			{
				levelGoal.Current,
				levelGoal.Target
			}));
		}

		// Token: 0x06035945 RID: 219461 RVA: 0x00EF7714 File Offset: 0x00EF5914
		public void RefreshSkillEnergy()
		{
			if (this.Presenter == null)
			{
				return;
			}
			UUIText text = base.GetText(29);
			if (text != null)
			{
				text.SetText(this.Presenter.Energy.ToString(), true);
			}
			int fullEnergy = this.Presenter.FullEnergy;
			float num = (fullEnergy > 0) ? ((float)this.Presenter.Energy / (float)fullEnergy) : 0f;
			UUISprite sprite = base.GetSprite(15);
			if (sprite != null)
			{
				sprite.SetFillAmount((num > 1f) ? 1f : num);
			}
			UUIItem item = base.GetItem(16);
			float barWidth = (item != null) ? item.GetWidth() : 0f;
			IReadOnlyList<SkillPointDisplayData> points = this.Presenter.CollectSkillPoints();
			MatchThreeGameplayView.RefreshSkillPoint(this.SmallSkillPoint, points, 0, fullEnergy, barWidth);
			MatchThreeGameplayView.RefreshSkillPoint(this.BigSkillPoint, points, 1, fullEnergy, barWidth);
		}

		// Token: 0x06035946 RID: 219462 RVA: 0x00EF77E0 File Offset: 0x00EF59E0
		private static void RefreshSkillPoint([Nullable(2)] MatchThreeSkillPointView view, IReadOnlyList<SkillPointDisplayData> points, int index, int full, float barWidth)
		{
			if (view == null)
			{
				return;
			}
			if (index >= points.Count)
			{
				view.SetUiActive(false);
				return;
			}
			view.SetUiActive(true);
			SkillPointDisplayData skillPointDisplayData = points[index];
			view.Refresh(skillPointDisplayData);
			if (full > 0)
			{
				view.SetOffsetX((float)skillPointDisplayData.EnergyNode / (float)full * barWidth);
			}
		}

		// Token: 0x06035947 RID: 219463 RVA: 0x00EF782F File Offset: 0x00EF5A2F
		public void RefreshTurn()
		{
			if (this.Presenter == null)
			{
				return;
			}
			this.RefreshTurn(this.Presenter.RemainingTurns);
		}

		// Token: 0x06035948 RID: 219464 RVA: 0x00EF784C File Offset: 0x00EF5A4C
		public void RefreshTurn(int remainingTurns)
		{
			if (this.Presenter == null)
			{
				return;
			}
			EMatchThreeTextId value = EMatchThreeTextId.RemainingTurns;
			if (remainingTurns <= 5)
			{
				value = EMatchThreeTextId.RemainingTurnsWarning;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), value.ToEnumString(), new <>z__ReadOnlyArray<object>(new object[]
			{
				remainingTurns,
				this.Presenter.MaxTurns
			}));
		}

		// Token: 0x06035949 RID: 219465 RVA: 0x00EF78A8 File Offset: 0x00EF5AA8
		public void PlayTurnDelta(int delta)
		{
			this.PlayTurnDeltaAsync(delta).Forget();
		}

		// Token: 0x0603594A RID: 219466 RVA: 0x00EF78B8 File Offset: 0x00EF5AB8
		public UniTask PlayTurnDeltaAsync(int delta)
		{
			MatchThreeGameplayView.<PlayTurnDeltaAsync>d__84 <PlayTurnDeltaAsync>d__;
			<PlayTurnDeltaAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTurnDeltaAsync>d__.<>4__this = this;
			<PlayTurnDeltaAsync>d__.delta = delta;
			<PlayTurnDeltaAsync>d__.<>1__state = -1;
			<PlayTurnDeltaAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayTurnDeltaAsync>d__84>(ref <PlayTurnDeltaAsync>d__);
			return <PlayTurnDeltaAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603594B RID: 219467 RVA: 0x00EF7904 File Offset: 0x00EF5B04
		public UniTask ShowEnvTipsAsync(string textId, int remainingRounds, int generateCount)
		{
			MatchThreeGameplayView.<ShowEnvTipsAsync>d__86 <ShowEnvTipsAsync>d__;
			<ShowEnvTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowEnvTipsAsync>d__.<>4__this = this;
			<ShowEnvTipsAsync>d__.textId = textId;
			<ShowEnvTipsAsync>d__.remainingRounds = remainingRounds;
			<ShowEnvTipsAsync>d__.generateCount = generateCount;
			<ShowEnvTipsAsync>d__.<>1__state = -1;
			<ShowEnvTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ShowEnvTipsAsync>d__86>(ref <ShowEnvTipsAsync>d__);
			return <ShowEnvTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603594C RID: 219468 RVA: 0x00EF7960 File Offset: 0x00EF5B60
		public UniTask HideEnvTipsAsync()
		{
			MatchThreeGameplayView.<HideEnvTipsAsync>d__87 <HideEnvTipsAsync>d__;
			<HideEnvTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideEnvTipsAsync>d__.<>4__this = this;
			<HideEnvTipsAsync>d__.<>1__state = -1;
			<HideEnvTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideEnvTipsAsync>d__87>(ref <HideEnvTipsAsync>d__);
			return <HideEnvTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603594D RID: 219469 RVA: 0x00EF79A4 File Offset: 0x00EF5BA4
		[NullableContext(2)]
		public UniTask ShowSkillTipsAsync(string icon, string nameKey)
		{
			MatchThreeGameplayView.<ShowSkillTipsAsync>d__89 <ShowSkillTipsAsync>d__;
			<ShowSkillTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSkillTipsAsync>d__.<>4__this = this;
			<ShowSkillTipsAsync>d__.icon = icon;
			<ShowSkillTipsAsync>d__.nameKey = nameKey;
			<ShowSkillTipsAsync>d__.<>1__state = -1;
			<ShowSkillTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ShowSkillTipsAsync>d__89>(ref <ShowSkillTipsAsync>d__);
			return <ShowSkillTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603594E RID: 219470 RVA: 0x00EF79F8 File Offset: 0x00EF5BF8
		public UniTask HideSkillTipsAsync()
		{
			MatchThreeGameplayView.<HideSkillTipsAsync>d__90 <HideSkillTipsAsync>d__;
			<HideSkillTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideSkillTipsAsync>d__.<>4__this = this;
			<HideSkillTipsAsync>d__.<>1__state = -1;
			<HideSkillTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideSkillTipsAsync>d__90>(ref <HideSkillTipsAsync>d__);
			return <HideSkillTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603594F RID: 219471 RVA: 0x00EF7A3C File Offset: 0x00EF5C3C
		public UniTask ShowScorePopAsync(int score)
		{
			MatchThreeGameplayView.<ShowScorePopAsync>d__94 <ShowScorePopAsync>d__;
			<ShowScorePopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowScorePopAsync>d__.<>4__this = this;
			<ShowScorePopAsync>d__.score = score;
			<ShowScorePopAsync>d__.<>1__state = -1;
			<ShowScorePopAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ShowScorePopAsync>d__94>(ref <ShowScorePopAsync>d__);
			return <ShowScorePopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035950 RID: 219472 RVA: 0x00EF7A88 File Offset: 0x00EF5C88
		public UniTask ShowGradePopAsync(int score)
		{
			MatchThreeGameplayView.<ShowGradePopAsync>d__95 <ShowGradePopAsync>d__;
			<ShowGradePopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowGradePopAsync>d__.<>4__this = this;
			<ShowGradePopAsync>d__.score = score;
			<ShowGradePopAsync>d__.<>1__state = -1;
			<ShowGradePopAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ShowGradePopAsync>d__95>(ref <ShowGradePopAsync>d__);
			return <ShowGradePopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035951 RID: 219473 RVA: 0x00EF7AD4 File Offset: 0x00EF5CD4
		public UniTask HideScoreAndGradeAsync()
		{
			MatchThreeGameplayView.<HideScoreAndGradeAsync>d__96 <HideScoreAndGradeAsync>d__;
			<HideScoreAndGradeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideScoreAndGradeAsync>d__.<>4__this = this;
			<HideScoreAndGradeAsync>d__.<>1__state = -1;
			<HideScoreAndGradeAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideScoreAndGradeAsync>d__96>(ref <HideScoreAndGradeAsync>d__);
			return <HideScoreAndGradeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035952 RID: 219474 RVA: 0x00EF7B17 File Offset: 0x00EF5D17
		private bool RaiseSwap(GridPosition a, GridPosition b)
		{
			MatchThreePresenter presenter = this.Presenter;
			return presenter != null && presenter.RequestSwap(a, b);
		}

		// Token: 0x06035953 RID: 219475 RVA: 0x00EF7B2C File Offset: 0x00EF5D2C
		private void OnSwapPieceInput(ELGUINavigationDirection direction)
		{
			this.TrySwapFocusedPiece(direction);
		}

		// Token: 0x06035954 RID: 219476 RVA: 0x00EF7B38 File Offset: 0x00EF5D38
		private bool TrySwapFocusedPiece(ELGUINavigationDirection direction)
		{
			if (!this.BoardNavigationInputBlocked)
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter != null && presenter.CanFocusBoard() && this.Pieces != null)
				{
					TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
					AActor aactor = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetOwner() : null;
					if (aactor == null)
					{
						return false;
					}
					GridPosition gridPosition = default(GridPosition);
					bool flag = false;
					int num = 0;
					while (num < 7 && !flag)
					{
						for (int i = 0; i < 8; i++)
						{
							MatchThreePieceView matchThreePieceView = this.Pieces[num * 8 + i];
							if (((matchThreePieceView != null) ? matchThreePieceView.GetRootActor() : null) == aactor)
							{
								gridPosition = new GridPosition(num, i);
								flag = true;
								break;
							}
						}
						num++;
					}
					if (!flag)
					{
						return false;
					}
					int num2 = gridPosition.Row;
					int num3 = gridPosition.Col;
					switch (direction)
					{
					case ELGUINavigationDirection.Left:
						num3--;
						break;
					case ELGUINavigationDirection.Right:
						num3++;
						break;
					case ELGUINavigationDirection.Up:
						num2--;
						break;
					case ELGUINavigationDirection.Down:
						num2++;
						break;
					default:
						return false;
					}
					if (!this.Presenter.Board.InBounds(num2, num3))
					{
						return false;
					}
					GridPosition gridPosition2 = new GridPosition(num2, num3);
					if (!this.CanSwap(gridPosition) || !this.CanSwap(gridPosition2))
					{
						return false;
					}
					if (!this.RaiseSwap(gridPosition, gridPosition2))
					{
						return false;
					}
					this.PendingNavigationRestoreSource = new GridPosition?(gridPosition);
					this.PendingNavigationRestoreTarget = new GridPosition?(gridPosition2);
					UiNavigationNewController.Instance.SwitchNavigationFocus(null);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035955 RID: 219477 RVA: 0x00EF7C98 File Offset: 0x00EF5E98
		private void RestoreSwapNavigationFocus()
		{
			GridPosition? pendingNavigationRestoreSource = this.PendingNavigationRestoreSource;
			GridPosition? pendingNavigationRestoreTarget = this.PendingNavigationRestoreTarget;
			this.ClearPendingNavigationRestore();
			if (pendingNavigationRestoreSource == null || pendingNavigationRestoreTarget == null || this.Presenter == null || this.Presenter.IsGameOver || this.Pieces == null)
			{
				return;
			}
			GridPosition pos = this.Presenter.LastSwapAccepted ? pendingNavigationRestoreTarget.Value : pendingNavigationRestoreSource.Value;
			MatchThreePieceView piece = this.GetPiece(pos);
			UUIItem uuiitem = (piece != null) ? piece.GetRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, true, true, true);
		}

		// Token: 0x06035956 RID: 219478 RVA: 0x00EF7D3C File Offset: 0x00EF5F3C
		private void ClearPendingNavigationRestore()
		{
			this.PendingNavigationRestoreSource = null;
			this.PendingNavigationRestoreTarget = null;
		}

		// Token: 0x06035957 RID: 219479 RVA: 0x00EF7D56 File Offset: 0x00EF5F56
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				MatchThreePresenter presenter = this.Presenter;
				if (presenter != null && presenter.CanFocusBoard())
				{
					this.FocusBoardDefaultListener();
					return;
				}
			}
		}

		// Token: 0x06035958 RID: 219480 RVA: 0x00EF7D84 File Offset: 0x00EF5F84
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener UpdateBoardDefaultListener()
		{
			if (this.Pieces == null)
			{
				return null;
			}
			MatchThreePieceView matchThreePieceView = this.Pieces[0];
			UUIItem uuiitem = (matchThreePieceView != null) ? matchThreePieceView.GetRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return null;
			}
			AActor owner = uuiitem.GetOwner();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null || !tsUiNavigationBehaviorListener.IsValid())
			{
				return null;
			}
			NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
			if (navigationGroup == null)
			{
				return null;
			}
			navigationGroup.DefaultListener = tsUiNavigationBehaviorListener;
			if (navigationGroup.SelectableMemory)
			{
				navigationGroup.LastSelectListener = tsUiNavigationBehaviorListener;
			}
			return tsUiNavigationBehaviorListener;
		}

		// Token: 0x06035959 RID: 219481 RVA: 0x00EF7E1C File Offset: 0x00EF601C
		public void FocusBoardDefaultListener()
		{
			if (this.BoardNavigationInputBlocked || base.IsDestroyOrDestroying || this.Presenter == null || this.Presenter.IsGameOver || !Info.Instance.IsInGamepad())
			{
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.UpdateBoardDefaultListener();
			UUIItem uuiitem = (tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.RootUIComp.Get() : null;
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			if (uuiitem != null && uuiitem.IsValid())
			{
				UiNavigationViewHandle uiNavigationViewHandle;
				if (tsUiNavigationBehaviorListener == null)
				{
					uiNavigationViewHandle = null;
				}
				else
				{
					TsUiNavigationPanelConfig panelConfig = tsUiNavigationBehaviorListener.PanelConfig;
					uiNavigationViewHandle = ((panelConfig != null) ? panelConfig.ViewHandle : null);
				}
				if (uiNavigationViewHandle == currentViewHandle)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, false, true, true);
					return;
				}
			}
		}

		// Token: 0x0603595A RID: 219482 RVA: 0x00EF7EBE File Offset: 0x00EF60BE
		private void OnPiecePressed(GridPosition pos)
		{
			this.PressedPos = new GridPosition?(pos);
			this.PressedAtMs = Time.Instance.Now;
		}

		// Token: 0x0603595B RID: 219483 RVA: 0x00EF7EDC File Offset: 0x00EF60DC
		private void OnPieceEntered(GridPosition pos)
		{
			if (this.PressedPos == null)
			{
				return;
			}
			GridPosition value = this.PressedPos.Value;
			if (pos.Row == value.Row && pos.Col == value.Col)
			{
				return;
			}
			this.PressedPos = null;
			if (Math.Abs(pos.Row - value.Row) + Math.Abs(pos.Col - value.Col) != 1)
			{
				return;
			}
			if (!this.CanSwap(value) || !this.CanSwap(pos))
			{
				return;
			}
			this.RaiseSwap(value, pos);
		}

		// Token: 0x0603595C RID: 219484 RVA: 0x00EF7F74 File Offset: 0x00EF6174
		private bool CanSwap(GridPosition pos)
		{
			MatchThreePresenter presenter = this.Presenter;
			if (presenter == null)
			{
				return false;
			}
			Piece piece = presenter.Board.GetPiece(pos.Row, pos.Col);
			return ((piece != null) ? new bool?(piece.Has(EPieceCaps.Swappable)) : null).GetValueOrDefault();
		}

		// Token: 0x0603595D RID: 219485 RVA: 0x00EF7FC8 File Offset: 0x00EF61C8
		private void OnPieceReleased()
		{
			if (this.PressedPos == null)
			{
				return;
			}
			GridPosition value = this.PressedPos.Value;
			this.PressedPos = null;
			if (Time.Instance.Now - this.PressedAtMs <= (double)this.PointerDownThresholdMs)
			{
				this.OnPieceShortPress(value);
			}
		}

		// Token: 0x0603595E RID: 219486 RVA: 0x00EF801C File Offset: 0x00EF621C
		private void OnPieceShortPress(GridPosition pos)
		{
			MatchThreePresenter presenter = this.Presenter;
			Piece piece = (presenter != null) ? presenter.Board.GetPiece(pos.Row, pos.Col) : null;
			MatchThreePieceView piece2 = this.GetPiece(pos);
			if (piece == null || piece2 == null || piece2.Type != piece.Type || !piece2.HasPopupInfo())
			{
				return;
			}
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (context == null)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(context.LevelId, context.RoleId, true, piece2.GetPopupFocusTileId(), 0);
		}

		// Token: 0x0603595F RID: 219487 RVA: 0x00EF80A0 File Offset: 0x00EF62A0
		public UniTask PlaySwapAsync(GridPosition a, GridPosition b)
		{
			MatchThreeGameplayView.<PlaySwapAsync>d__115 <PlaySwapAsync>d__;
			<PlaySwapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwapAsync>d__.<>4__this = this;
			<PlaySwapAsync>d__.a = a;
			<PlaySwapAsync>d__.b = b;
			<PlaySwapAsync>d__.<>1__state = -1;
			<PlaySwapAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlaySwapAsync>d__115>(ref <PlaySwapAsync>d__);
			return <PlaySwapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035960 RID: 219488 RVA: 0x00EF80F4 File Offset: 0x00EF62F4
		public UniTask PlaySwapFailAsync(GridPosition a, GridPosition b)
		{
			MatchThreeGameplayView.<PlaySwapFailAsync>d__116 <PlaySwapFailAsync>d__;
			<PlaySwapFailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwapFailAsync>d__.<>4__this = this;
			<PlaySwapFailAsync>d__.a = a;
			<PlaySwapFailAsync>d__.b = b;
			<PlaySwapFailAsync>d__.<>1__state = -1;
			<PlaySwapFailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlaySwapFailAsync>d__116>(ref <PlaySwapFailAsync>d__);
			return <PlaySwapFailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035961 RID: 219489 RVA: 0x00EF8148 File Offset: 0x00EF6348
		[NullableContext(2)]
		public UniTask ClearPieceAsync(PieceClearEvent ev, int delayMs, Action onTrailLanded, Action onVacated, Action onUltimateFullUp = null)
		{
			MatchThreeGameplayView.<ClearPieceAsync>d__117 <ClearPieceAsync>d__;
			<ClearPieceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearPieceAsync>d__.<>4__this = this;
			<ClearPieceAsync>d__.ev = ev;
			<ClearPieceAsync>d__.delayMs = delayMs;
			<ClearPieceAsync>d__.onTrailLanded = onTrailLanded;
			<ClearPieceAsync>d__.onVacated = onVacated;
			<ClearPieceAsync>d__.onUltimateFullUp = onUltimateFullUp;
			<ClearPieceAsync>d__.<>1__state = -1;
			<ClearPieceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ClearPieceAsync>d__117>(ref <ClearPieceAsync>d__);
			return <ClearPieceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035962 RID: 219490 RVA: 0x00EF81B8 File Offset: 0x00EF63B8
		[NullableContext(2)]
		public UniTask PlayPieceHitAsync(MatchThreePieceView piece, PieceHitEvent ev, Action onStarted, Action onTrailLanded = null, int trailArriveDelayMs = 0)
		{
			MatchThreeGameplayView.<PlayPieceHitAsync>d__118 <PlayPieceHitAsync>d__;
			<PlayPieceHitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPieceHitAsync>d__.<>4__this = this;
			<PlayPieceHitAsync>d__.piece = piece;
			<PlayPieceHitAsync>d__.ev = ev;
			<PlayPieceHitAsync>d__.onStarted = onStarted;
			<PlayPieceHitAsync>d__.onTrailLanded = onTrailLanded;
			<PlayPieceHitAsync>d__.trailArriveDelayMs = trailArriveDelayMs;
			<PlayPieceHitAsync>d__.<>1__state = -1;
			<PlayPieceHitAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayPieceHitAsync>d__118>(ref <PlayPieceHitAsync>d__);
			return <PlayPieceHitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035963 RID: 219491 RVA: 0x00EF8228 File Offset: 0x00EF6428
		private UniTask PlayDirectedTrailAsync(GridPosition origin, GridPosition target, EDirectedTrailType trailType, int arriveDelayMs)
		{
			MatchThreeGameplayView.<PlayDirectedTrailAsync>d__119 <PlayDirectedTrailAsync>d__;
			<PlayDirectedTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDirectedTrailAsync>d__.<>4__this = this;
			<PlayDirectedTrailAsync>d__.origin = origin;
			<PlayDirectedTrailAsync>d__.target = target;
			<PlayDirectedTrailAsync>d__.trailType = trailType;
			<PlayDirectedTrailAsync>d__.arriveDelayMs = arriveDelayMs;
			<PlayDirectedTrailAsync>d__.<>1__state = -1;
			<PlayDirectedTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayDirectedTrailAsync>d__119>(ref <PlayDirectedTrailAsync>d__);
			return <PlayDirectedTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035964 RID: 219492 RVA: 0x00EF828C File Offset: 0x00EF648C
		private static UniTask DelayAsync(int ms)
		{
			if (ms > 0)
			{
				return MatchThreeGameplayView.DelayCoreAsync(ms);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06035965 RID: 219493 RVA: 0x00EF82A0 File Offset: 0x00EF64A0
		private static UniTask DelayCoreAsync(int ms)
		{
			MatchThreeGameplayView.<DelayCoreAsync>d__121 <DelayCoreAsync>d__;
			<DelayCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DelayCoreAsync>d__.ms = ms;
			<DelayCoreAsync>d__.<>1__state = -1;
			<DelayCoreAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<DelayCoreAsync>d__121>(ref <DelayCoreAsync>d__);
			return <DelayCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035966 RID: 219494 RVA: 0x00EF82E4 File Offset: 0x00EF64E4
		public UniTask FlushSpawnsAsync()
		{
			MatchThreeGameplayView.<FlushSpawnsAsync>d__123 <FlushSpawnsAsync>d__;
			<FlushSpawnsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushSpawnsAsync>d__.<>4__this = this;
			<FlushSpawnsAsync>d__.<>1__state = -1;
			<FlushSpawnsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushSpawnsAsync>d__123>(ref <FlushSpawnsAsync>d__);
			return <FlushSpawnsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035967 RID: 219495 RVA: 0x00EF8327 File Offset: 0x00EF6527
		private static int CellIdx(GridPosition pos)
		{
			return pos.Row * 8 + pos.Col;
		}

		// Token: 0x06035968 RID: 219496 RVA: 0x00EF8338 File Offset: 0x00EF6538
		[NullableContext(2)]
		private MatchThreePieceView FindSpawn(GridPosition pos)
		{
			int num = MatchThreeGameplayView.CellIdx(pos);
			for (int i = 0; i < this.SpawnTargets.Count; i++)
			{
				if (this.SpawnTargets[i].Item1 == num)
				{
					return this.SpawnTargets[i].Item2;
				}
			}
			return null;
		}

		// Token: 0x06035969 RID: 219497 RVA: 0x00EF838C File Offset: 0x00EF658C
		public void CaptureClearTargets(IReadOnlyList<PieceClearEvent> clears)
		{
			Array.Clear(this.ClearTargets, 0, this.ClearTargets.Length);
			for (int i = 0; i < clears.Count; i++)
			{
				GridPosition pos = clears[i].Pos;
				MatchThreePieceView piece = this.GetPiece(pos);
				this.ClearTargets[MatchThreeGameplayView.CellIdx(pos)] = piece;
				this.SetPiece(pos, null);
				this.NotifyIfGuideFocusedCleared(piece);
			}
		}

		// Token: 0x0603596A RID: 219498 RVA: 0x00EF83F0 File Offset: 0x00EF65F0
		public UniTask PrepareSpawnsAsync(IReadOnlyList<PieceClearEvent> clears)
		{
			MatchThreeGameplayView.<PrepareSpawnsAsync>d__130 <PrepareSpawnsAsync>d__;
			<PrepareSpawnsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareSpawnsAsync>d__.<>4__this = this;
			<PrepareSpawnsAsync>d__.clears = clears;
			<PrepareSpawnsAsync>d__.<>1__state = -1;
			<PrepareSpawnsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PrepareSpawnsAsync>d__130>(ref <PrepareSpawnsAsync>d__);
			return <PrepareSpawnsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603596B RID: 219499 RVA: 0x00EF843C File Offset: 0x00EF663C
		private UniTask PrepareOneSpawnAsync(PieceClearEvent ev)
		{
			MatchThreeGameplayView.<PrepareOneSpawnAsync>d__131 <PrepareOneSpawnAsync>d__;
			<PrepareOneSpawnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareOneSpawnAsync>d__.<>4__this = this;
			<PrepareOneSpawnAsync>d__.ev = ev;
			<PrepareOneSpawnAsync>d__.<>1__state = -1;
			<PrepareOneSpawnAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PrepareOneSpawnAsync>d__131>(ref <PrepareOneSpawnAsync>d__);
			return <PrepareOneSpawnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603596C RID: 219500 RVA: 0x00EF8488 File Offset: 0x00EF6688
		public UniTask TransformPieceAsync(GridPosition pos, EPieceType type, Piece piece)
		{
			MatchThreeGameplayView.<TransformPieceAsync>d__132 <TransformPieceAsync>d__;
			<TransformPieceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransformPieceAsync>d__.<>4__this = this;
			<TransformPieceAsync>d__.pos = pos;
			<TransformPieceAsync>d__.type = type;
			<TransformPieceAsync>d__.piece = piece;
			<TransformPieceAsync>d__.<>1__state = -1;
			<TransformPieceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<TransformPieceAsync>d__132>(ref <TransformPieceAsync>d__);
			return <TransformPieceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603596D RID: 219501 RVA: 0x00EF84E4 File Offset: 0x00EF66E4
		public UniTask AttachPieceComponentsAsync(GridPosition pos, Piece piece)
		{
			MatchThreePieceView piece2 = this.GetPiece(pos);
			if (piece2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[View.AttachPieceComponentsAsync] 挂组件目标格无单元";
				string item = "Pos";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pos.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return UniTask.CompletedTask;
			}
			return piece2.RefreshPieceStateAsync(piece);
		}

		// Token: 0x0603596E RID: 219502 RVA: 0x00EF8580 File Offset: 0x00EF6780
		[NullableContext(2)]
		public MatchThreePieceView DetachMovePiece(in PieceMoveEvent first)
		{
			if (first.FromRow < 0)
			{
				return null;
			}
			GridPosition pos = new GridPosition(first.FromRow, first.FromCol);
			MatchThreePieceView piece = this.GetPiece(pos);
			this.SetPiece(pos, null);
			return piece;
		}

		// Token: 0x0603596F RID: 219503 RVA: 0x00EF85BC File Offset: 0x00EF67BC
		public void BuildFallDurations(List<PieceMoveEvent> moves)
		{
			Array.Clear(this.FallDurations, 0, this.FallDurations.Length);
			int num = 0;
			for (int i = 1; i <= moves.Count; i++)
			{
				if (i >= moves.Count || moves[i].Piece != moves[num].Piece)
				{
					int toCol = moves[i - 1].ToCol;
					float num2 = MatchThreePieceView.FallFlightDuration(this.TripArcLength(moves, num, i - num), this.CellStepY);
					if (num2 > this.FallDurations[toCol])
					{
						this.FallDurations[toCol] = num2;
					}
					num = i;
				}
			}
		}

		// Token: 0x06035970 RID: 219504 RVA: 0x00EF8650 File Offset: 0x00EF6850
		private float TripArcLength(List<PieceMoveEvent> moves, int start, int count)
		{
			float num = 0f;
			for (int i = 0; i < count; i++)
			{
				PieceMoveEvent pieceMoveEvent = moves[start + i];
				float num2 = (float)(pieceMoveEvent.ToCol - pieceMoveEvent.FromCol) * this.CellStepX;
				float num3 = (float)(pieceMoveEvent.ToRow - pieceMoveEvent.FromRow) * this.CellStepY;
				num += (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
			}
			return num;
		}

		// Token: 0x06035971 RID: 219505 RVA: 0x00EF86BC File Offset: 0x00EF68BC
		[NullableContext(2)]
		public UniTask PlayMoveTripAsync([Nullable(1)] List<PieceMoveEvent> moves, int start, int count, MatchThreePieceView view, Action onFallStarted)
		{
			MatchThreeGameplayView.<PlayMoveTripAsync>d__137 <PlayMoveTripAsync>d__;
			<PlayMoveTripAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveTripAsync>d__.<>4__this = this;
			<PlayMoveTripAsync>d__.moves = moves;
			<PlayMoveTripAsync>d__.start = start;
			<PlayMoveTripAsync>d__.count = count;
			<PlayMoveTripAsync>d__.view = view;
			<PlayMoveTripAsync>d__.onFallStarted = onFallStarted;
			<PlayMoveTripAsync>d__.<>1__state = -1;
			<PlayMoveTripAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayMoveTripAsync>d__137>(ref <PlayMoveTripAsync>d__);
			return <PlayMoveTripAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035972 RID: 219506 RVA: 0x00EF872C File Offset: 0x00EF692C
		public void CaptureHitTargets(List<PieceHitEvent> hits, [Nullable(new byte[]
		{
			1,
			2
		})] List<MatchThreePieceView> targets)
		{
			targets.Clear();
			for (int i = 0; i < hits.Count; i++)
			{
				targets.Add(this.GetPiece(hits[i].Pos));
			}
		}

		// Token: 0x06035973 RID: 219507 RVA: 0x00EF8768 File Offset: 0x00EF6968
		public UniTask FlushEnergyTrailsAsync()
		{
			MatchThreeGameplayView.<FlushEnergyTrailsAsync>d__144 <FlushEnergyTrailsAsync>d__;
			<FlushEnergyTrailsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushEnergyTrailsAsync>d__.<>4__this = this;
			<FlushEnergyTrailsAsync>d__.<>1__state = -1;
			<FlushEnergyTrailsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushEnergyTrailsAsync>d__144>(ref <FlushEnergyTrailsAsync>d__);
			return <FlushEnergyTrailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035974 RID: 219508 RVA: 0x00EF87AC File Offset: 0x00EF69AC
		public UniTask FlushRecycleTrailsAsync()
		{
			MatchThreeGameplayView.<FlushRecycleTrailsAsync>d__145 <FlushRecycleTrailsAsync>d__;
			<FlushRecycleTrailsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushRecycleTrailsAsync>d__.<>4__this = this;
			<FlushRecycleTrailsAsync>d__.<>1__state = -1;
			<FlushRecycleTrailsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushRecycleTrailsAsync>d__145>(ref <FlushRecycleTrailsAsync>d__);
			return <FlushRecycleTrailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035975 RID: 219509 RVA: 0x00EF87EF File Offset: 0x00EF69EF
		public void DiscardEnergyTrails()
		{
			this.TrailGeneration++;
			this.PendingEnergyTrails.Clear();
			this.PendingRecycleTrails.Clear();
			this.TrailsInFlight = 0;
		}

		// Token: 0x06035976 RID: 219510 RVA: 0x00EF881C File Offset: 0x00EF6A1C
		private void DiscardRecolorPresentation()
		{
			this.RecolorGeneration++;
		}

		// Token: 0x06035977 RID: 219511 RVA: 0x00EF882C File Offset: 0x00EF6A2C
		private UniTask PlayEnergyTrailAsync(GridPosition origin, int energy)
		{
			MatchThreeGameplayView.<PlayEnergyTrailAsync>d__148 <PlayEnergyTrailAsync>d__;
			<PlayEnergyTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEnergyTrailAsync>d__.<>4__this = this;
			<PlayEnergyTrailAsync>d__.origin = origin;
			<PlayEnergyTrailAsync>d__.energy = energy;
			<PlayEnergyTrailAsync>d__.<>1__state = -1;
			<PlayEnergyTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayEnergyTrailAsync>d__148>(ref <PlayEnergyTrailAsync>d__);
			return <PlayEnergyTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035978 RID: 219512 RVA: 0x00EF8880 File Offset: 0x00EF6A80
		public UniTask PlaySkillTrailAsync(GridPosition target, ESkillTrailType type, int arriveDelayMs)
		{
			MatchThreeGameplayView.<PlaySkillTrailAsync>d__149 <PlaySkillTrailAsync>d__;
			<PlaySkillTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySkillTrailAsync>d__.<>4__this = this;
			<PlaySkillTrailAsync>d__.target = target;
			<PlaySkillTrailAsync>d__.type = type;
			<PlaySkillTrailAsync>d__.arriveDelayMs = arriveDelayMs;
			<PlaySkillTrailAsync>d__.<>1__state = -1;
			<PlaySkillTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlaySkillTrailAsync>d__149>(ref <PlaySkillTrailAsync>d__);
			return <PlaySkillTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035979 RID: 219513 RVA: 0x00EF88DC File Offset: 0x00EF6ADC
		public UniTask PlayPieceRecolorAsync(PieceRecolorEvent recolorEvent, int delayMs)
		{
			MatchThreeGameplayView.<PlayPieceRecolorAsync>d__150 <PlayPieceRecolorAsync>d__;
			<PlayPieceRecolorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPieceRecolorAsync>d__.<>4__this = this;
			<PlayPieceRecolorAsync>d__.recolorEvent = recolorEvent;
			<PlayPieceRecolorAsync>d__.delayMs = delayMs;
			<PlayPieceRecolorAsync>d__.<>1__state = -1;
			<PlayPieceRecolorAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayPieceRecolorAsync>d__150>(ref <PlayPieceRecolorAsync>d__);
			return <PlayPieceRecolorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603597A RID: 219514 RVA: 0x00EF8930 File Offset: 0x00EF6B30
		private void InitializeRoleSkillPresentation()
		{
			UUIItem item = base.GetItem(26);
			if (item != null)
			{
				this.AllureSkillPlayer = new UiSequencePlayer(item);
				this.AllureSkillActor = (item.GetOwner() as AUIBaseActor);
				AUIBaseActor allureSkillActor = this.AllureSkillActor;
				if (allureSkillActor != null)
				{
					allureSkillActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnAllureSkillSequenceEvent));
				}
			}
			UUIItem item2 = base.GetItem(21);
			if (item2 != null)
			{
				this.ChainSkillPlayer = new UiSequencePlayer(item2);
				this.ChainSkillActor = (item2.GetOwner() as AUIBaseActor);
				AUIBaseActor chainSkillActor = this.ChainSkillActor;
				if (chainSkillActor == null)
				{
					return;
				}
				chainSkillActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnChainSkillSequenceEvent));
			}
		}

		// Token: 0x0603597B RID: 219515 RVA: 0x00EF89D2 File Offset: 0x00EF6BD2
		private void OnAllureSkillSequenceEvent(string sequenceName, string eventName)
		{
			this.OnRoleSkillSequenceEvent(ESkillCastEffect.Allure, sequenceName, eventName);
		}

		// Token: 0x0603597C RID: 219516 RVA: 0x00EF89DD File Offset: 0x00EF6BDD
		private void OnChainSkillSequenceEvent(string sequenceName, string eventName)
		{
			this.OnRoleSkillSequenceEvent(ESkillCastEffect.Chain, sequenceName, eventName);
		}

		// Token: 0x0603597D RID: 219517 RVA: 0x00EF89E8 File Offset: 0x00EF6BE8
		private void OnRoleSkillSequenceEvent(ESkillCastEffect effect, string sequenceName, string eventName)
		{
			if (effect != this.ActiveSmallSkillEffect || this.SmallSkillSequenceGate == null)
			{
				return;
			}
			if (sequenceName != EMatchThreeSkillSequence.Small.ToEnumString() || eventName != EMatchThreeSkillSequenceEvent.Up.ToEnumString())
			{
				return;
			}
			this.SmallSkillUpReceived = true;
			this.SmallSkillSequenceGate.TrySetResult();
		}

		// Token: 0x0603597E RID: 219518 RVA: 0x00EF8A38 File Offset: 0x00EF6C38
		public unsafe UniTask PlaySkillCastEffectAsync(ESkillCastEffect effect, bool isUltimate)
		{
			UiSequencePlayer roleSkillPlayer = this.GetRoleSkillPlayer(effect);
			UUIItem roleSkillPanel = this.GetRoleSkillPanel(effect);
			if (roleSkillPlayer == null || roleSkillPanel == null)
			{
				if (effect != ESkillCastEffect.None)
				{
					EMatchThreeSkillSequence value = isUltimate ? EMatchThreeSkillSequence.Ultimate : EMatchThreeSkillSequence.Small;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.HMQ;
					string message = "[PlaySkillCastEffectAsync] 角色技能表现节点未初始化，兜底放行后续技能表现";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Effect", effect);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Sequence", value.ToEnumString());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return UniTask.CompletedTask;
			}
			this.RoleSkillSequenceVersion++;
			int roleSkillSequenceVersion = this.RoleSkillSequenceVersion;
			this.ReleaseSmallSkillSequenceGate();
			this.StopRoleSkillSequences();
			this.HideOtherRoleSkillPanel(effect);
			if (isUltimate)
			{
				return this.PlayUltimateSkillSequenceAsync(roleSkillPlayer, roleSkillPanel, roleSkillSequenceVersion);
			}
			return this.PlaySmallSkillSequenceAsync(effect, roleSkillPlayer, roleSkillPanel, roleSkillSequenceVersion);
		}

		// Token: 0x0603597F RID: 219519 RVA: 0x00EF8B10 File Offset: 0x00EF6D10
		private UniTask PlayUltimateSkillSequenceAsync(UiSequencePlayer player, UUIItem panel, int version)
		{
			MatchThreeGameplayView.<PlayUltimateSkillSequenceAsync>d__164 <PlayUltimateSkillSequenceAsync>d__;
			<PlayUltimateSkillSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUltimateSkillSequenceAsync>d__.<>4__this = this;
			<PlayUltimateSkillSequenceAsync>d__.player = player;
			<PlayUltimateSkillSequenceAsync>d__.panel = panel;
			<PlayUltimateSkillSequenceAsync>d__.version = version;
			<PlayUltimateSkillSequenceAsync>d__.<>1__state = -1;
			<PlayUltimateSkillSequenceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayUltimateSkillSequenceAsync>d__164>(ref <PlayUltimateSkillSequenceAsync>d__);
			return <PlayUltimateSkillSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035980 RID: 219520 RVA: 0x00EF8B6C File Offset: 0x00EF6D6C
		private UniTask PlaySmallSkillSequenceAsync(ESkillCastEffect effect, UiSequencePlayer player, UUIItem panel, int version)
		{
			MatchThreeGameplayView.<PlaySmallSkillSequenceAsync>d__165 <PlaySmallSkillSequenceAsync>d__;
			<PlaySmallSkillSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySmallSkillSequenceAsync>d__.<>4__this = this;
			<PlaySmallSkillSequenceAsync>d__.effect = effect;
			<PlaySmallSkillSequenceAsync>d__.player = player;
			<PlaySmallSkillSequenceAsync>d__.panel = panel;
			<PlaySmallSkillSequenceAsync>d__.version = version;
			<PlaySmallSkillSequenceAsync>d__.<>1__state = -1;
			<PlaySmallSkillSequenceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlaySmallSkillSequenceAsync>d__165>(ref <PlaySmallSkillSequenceAsync>d__);
			return <PlaySmallSkillSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035981 RID: 219521 RVA: 0x00EF8BD0 File Offset: 0x00EF6DD0
		private UniTask ObserveSmallSkillSequenceCompletionAsync(ESkillCastEffect effect, UUIItem panel, string sequenceName, int version, UniTask sequenceTask)
		{
			MatchThreeGameplayView.<ObserveSmallSkillSequenceCompletionAsync>d__166 <ObserveSmallSkillSequenceCompletionAsync>d__;
			<ObserveSmallSkillSequenceCompletionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ObserveSmallSkillSequenceCompletionAsync>d__.<>4__this = this;
			<ObserveSmallSkillSequenceCompletionAsync>d__.effect = effect;
			<ObserveSmallSkillSequenceCompletionAsync>d__.panel = panel;
			<ObserveSmallSkillSequenceCompletionAsync>d__.sequenceName = sequenceName;
			<ObserveSmallSkillSequenceCompletionAsync>d__.version = version;
			<ObserveSmallSkillSequenceCompletionAsync>d__.sequenceTask = sequenceTask;
			<ObserveSmallSkillSequenceCompletionAsync>d__.<>1__state = -1;
			<ObserveSmallSkillSequenceCompletionAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ObserveSmallSkillSequenceCompletionAsync>d__166>(ref <ObserveSmallSkillSequenceCompletionAsync>d__);
			return <ObserveSmallSkillSequenceCompletionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035982 RID: 219522 RVA: 0x00EF8C3D File Offset: 0x00EF6E3D
		[NullableContext(2)]
		private UiSequencePlayer GetRoleSkillPlayer(ESkillCastEffect effect)
		{
			if (effect == ESkillCastEffect.Allure)
			{
				return this.AllureSkillPlayer;
			}
			if (effect == ESkillCastEffect.Chain)
			{
				return this.ChainSkillPlayer;
			}
			return null;
		}

		// Token: 0x06035983 RID: 219523 RVA: 0x00EF8C56 File Offset: 0x00EF6E56
		[NullableContext(2)]
		private UUIItem GetRoleSkillPanel(ESkillCastEffect effect)
		{
			if (effect == ESkillCastEffect.Allure)
			{
				return base.GetItem(26);
			}
			if (effect == ESkillCastEffect.Chain)
			{
				return base.GetItem(21);
			}
			return null;
		}

		// Token: 0x06035984 RID: 219524 RVA: 0x00EF8C73 File Offset: 0x00EF6E73
		private void HideOtherRoleSkillPanel(ESkillCastEffect effect)
		{
			if (effect != ESkillCastEffect.Allure)
			{
				UUIItem item = base.GetItem(26);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			if (effect != ESkillCastEffect.Chain)
			{
				UUIItem item2 = base.GetItem(21);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
			}
		}

		// Token: 0x06035985 RID: 219525 RVA: 0x00EF8CA4 File Offset: 0x00EF6EA4
		private void ReleaseSmallSkillSequenceGate()
		{
			UniTaskCompletionSource smallSkillSequenceGate = this.SmallSkillSequenceGate;
			this.SmallSkillSequenceGate = null;
			this.ActiveSmallSkillEffect = ESkillCastEffect.None;
			if (smallSkillSequenceGate == null)
			{
				return;
			}
			smallSkillSequenceGate.TrySetResult();
		}

		// Token: 0x06035986 RID: 219526 RVA: 0x00EF8CC8 File Offset: 0x00EF6EC8
		private void StopRoleSkillSequences()
		{
			UiSequencePlayer allureSkillPlayer = this.AllureSkillPlayer;
			if (allureSkillPlayer != null && allureSkillPlayer.IsInSequence())
			{
				this.AllureSkillPlayer.StopPrevSequence(false, false);
			}
			UiSequencePlayer chainSkillPlayer = this.ChainSkillPlayer;
			if (chainSkillPlayer != null && chainSkillPlayer.IsInSequence())
			{
				this.ChainSkillPlayer.StopPrevSequence(false, false);
			}
		}

		// Token: 0x06035987 RID: 219527 RVA: 0x00EF8D18 File Offset: 0x00EF6F18
		private void ResetRoleSkillPresentation()
		{
			this.RoleSkillSequenceVersion++;
			this.ReleaseSmallSkillSequenceGate();
			this.StopRoleSkillSequences();
			UUIItem item = base.GetItem(26);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(21);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06035988 RID: 219528 RVA: 0x00EF8D68 File Offset: 0x00EF6F68
		private void ClearRoleSkillPresentation()
		{
			this.ResetRoleSkillPresentation();
			AUIBaseActor allureSkillActor = this.AllureSkillActor;
			if (allureSkillActor != null)
			{
				allureSkillActor.OnSequencePlayEvent.Unbind();
			}
			AUIBaseActor chainSkillActor = this.ChainSkillActor;
			if (chainSkillActor != null)
			{
				chainSkillActor.OnSequencePlayEvent.Unbind();
			}
			this.AllureSkillActor = null;
			this.ChainSkillActor = null;
			UiSequencePlayer allureSkillPlayer = this.AllureSkillPlayer;
			if (allureSkillPlayer != null)
			{
				allureSkillPlayer.Clear();
			}
			UiSequencePlayer chainSkillPlayer = this.ChainSkillPlayer;
			if (chainSkillPlayer != null)
			{
				chainSkillPlayer.Clear();
			}
			this.AllureSkillPlayer = null;
			this.ChainSkillPlayer = null;
		}

		// Token: 0x06035989 RID: 219529 RVA: 0x00EF8DE8 File Offset: 0x00EF6FE8
		public UniTask PlayMechanicTrailAsync(int envId, GridPosition target, EPieceType mechanicType, int delayMs)
		{
			MatchThreeGameplayView.<PlayMechanicTrailAsync>d__174 <PlayMechanicTrailAsync>d__;
			<PlayMechanicTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMechanicTrailAsync>d__.<>4__this = this;
			<PlayMechanicTrailAsync>d__.envId = envId;
			<PlayMechanicTrailAsync>d__.target = target;
			<PlayMechanicTrailAsync>d__.delayMs = delayMs;
			<PlayMechanicTrailAsync>d__.<>1__state = -1;
			<PlayMechanicTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayMechanicTrailAsync>d__174>(ref <PlayMechanicTrailAsync>d__);
			return <PlayMechanicTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603598A RID: 219530 RVA: 0x00EF8E44 File Offset: 0x00EF7044
		[NullableContext(2)]
		private UUIItem FindMechanicItem(int envId)
		{
			if (this.MechanicsLayout == null)
			{
				return null;
			}
			IReadOnlyList<MechanicDisplayData> datas = this.MechanicsLayout.GetDatas();
			for (int i = 0; i < datas.Count; i++)
			{
				if (datas[i].EnvId == envId)
				{
					return this.MechanicsLayout.GetItemByIndex(i);
				}
			}
			return null;
		}

		// Token: 0x0603598B RID: 219531 RVA: 0x00EF8E98 File Offset: 0x00EF7098
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<MatchThreeTrailEffectView> AcquireTrailAsync(System.Collections.Generic.Stack<MatchThreeTrailEffectView> pool, string resourceId, [Nullable(2)] UCurveFloat curveX = null, [Nullable(2)] UCurveFloat curveY = null)
		{
			MatchThreeGameplayView.<AcquireTrailAsync>d__176 <AcquireTrailAsync>d__;
			<AcquireTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MatchThreeTrailEffectView>.Create();
			<AcquireTrailAsync>d__.<>4__this = this;
			<AcquireTrailAsync>d__.pool = pool;
			<AcquireTrailAsync>d__.resourceId = resourceId;
			<AcquireTrailAsync>d__.curveX = curveX;
			<AcquireTrailAsync>d__.curveY = curveY;
			<AcquireTrailAsync>d__.<>1__state = -1;
			<AcquireTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<AcquireTrailAsync>d__176>(ref <AcquireTrailAsync>d__);
			return <AcquireTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603598C RID: 219532 RVA: 0x00EF8EFC File Offset: 0x00EF70FC
		private void BindTrailBoard(MatchThreeTrailEffectView trail)
		{
			UUIItem item = base.GetItem(3);
			UUIItem uuiitem = (item != null) ? item.GetParentAsUIItem() : null;
			if (item == null || uuiitem == null)
			{
				return;
			}
			FVector lguispaceAbsolutePosition = uuiitem.GetLGUISpaceAbsolutePosition();
			FVector relativeLocation = item.RelativeLocation;
			FVector2D pivot = item.GetPivot();
			trail.BindBoard(lguispaceAbsolutePosition.X + relativeLocation.X - item.GetAnchorOffsetX() + (0.5f - pivot.X) * item.GetWidth(), lguispaceAbsolutePosition.Y + relativeLocation.Y - item.GetAnchorOffsetY() + (0.5f - pivot.Y) * item.GetHeight(), this.CellStepX, this.CellStepY);
		}

		// Token: 0x0603598D RID: 219533 RVA: 0x00EF8FA0 File Offset: 0x00EF71A0
		public UniTask PlayReshuffleAsync()
		{
			MatchThreeGameplayView.<PlayReshuffleAsync>d__178 <PlayReshuffleAsync>d__;
			<PlayReshuffleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReshuffleAsync>d__.<>4__this = this;
			<PlayReshuffleAsync>d__.<>1__state = -1;
			<PlayReshuffleAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayReshuffleAsync>d__178>(ref <PlayReshuffleAsync>d__);
			return <PlayReshuffleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603598E RID: 219534 RVA: 0x00EF8FE4 File Offset: 0x00EF71E4
		[NullableContext(0)]
		public UniTask<bool> ResetForRestartAsync()
		{
			MatchThreeGameplayView.<ResetForRestartAsync>d__179 <ResetForRestartAsync>d__;
			<ResetForRestartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ResetForRestartAsync>d__.<>4__this = this;
			<ResetForRestartAsync>d__.<>1__state = -1;
			<ResetForRestartAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ResetForRestartAsync>d__179>(ref <ResetForRestartAsync>d__);
			return <ResetForRestartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603598F RID: 219535 RVA: 0x00EF9027 File Offset: 0x00EF7227
		private void PrepareBoardRefresh(bool clearPendingNavigationRestore)
		{
			if (clearPendingNavigationRestore)
			{
				this.ClearPendingNavigationRestore();
			}
			this.SetBoardNavigationInputBlocked(true);
		}

		// Token: 0x06035990 RID: 219536 RVA: 0x00EF903C File Offset: 0x00EF723C
		[NullableContext(0)]
		private UniTask<bool> RefreshBoardAsync(bool showReshuffleTips)
		{
			MatchThreeGameplayView.<RefreshBoardAsync>d__183 <RefreshBoardAsync>d__;
			<RefreshBoardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RefreshBoardAsync>d__.<>4__this = this;
			<RefreshBoardAsync>d__.showReshuffleTips = showReshuffleTips;
			<RefreshBoardAsync>d__.<>1__state = -1;
			<RefreshBoardAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<RefreshBoardAsync>d__183>(ref <RefreshBoardAsync>d__);
			return <RefreshBoardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035991 RID: 219537 RVA: 0x00EF9088 File Offset: 0x00EF7288
		[NullableContext(2)]
		private UniTask PlayRestartCleanCellAsync(GridPosition pos, Piece piece, int generation, UniTask abortTask)
		{
			MatchThreeGameplayView.<PlayRestartCleanCellAsync>d__184 <PlayRestartCleanCellAsync>d__;
			<PlayRestartCleanCellAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRestartCleanCellAsync>d__.<>4__this = this;
			<PlayRestartCleanCellAsync>d__.pos = pos;
			<PlayRestartCleanCellAsync>d__.piece = piece;
			<PlayRestartCleanCellAsync>d__.generation = generation;
			<PlayRestartCleanCellAsync>d__.abortTask = abortTask;
			<PlayRestartCleanCellAsync>d__.<>1__state = -1;
			<PlayRestartCleanCellAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayRestartCleanCellAsync>d__184>(ref <PlayRestartCleanCellAsync>d__);
			return <PlayRestartCleanCellAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035992 RID: 219538 RVA: 0x00EF90EC File Offset: 0x00EF72EC
		private UniTask PlayRecycleTrailAsync(GridPosition origin, ERecycleTrailType trailType)
		{
			MatchThreeGameplayView.<PlayRecycleTrailAsync>d__185 <PlayRecycleTrailAsync>d__;
			<PlayRecycleTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRecycleTrailAsync>d__.<>4__this = this;
			<PlayRecycleTrailAsync>d__.origin = origin;
			<PlayRecycleTrailAsync>d__.trailType = trailType;
			<PlayRecycleTrailAsync>d__.<>1__state = -1;
			<PlayRecycleTrailAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayRecycleTrailAsync>d__185>(ref <PlayRecycleTrailAsync>d__);
			return <PlayRecycleTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035993 RID: 219539 RVA: 0x00EF9140 File Offset: 0x00EF7340
		public UniTask ReconcileBoardAsync()
		{
			MatchThreeGameplayView.<ReconcileBoardAsync>d__186 <ReconcileBoardAsync>d__;
			<ReconcileBoardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconcileBoardAsync>d__.<>4__this = this;
			<ReconcileBoardAsync>d__.<>1__state = -1;
			<ReconcileBoardAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ReconcileBoardAsync>d__186>(ref <ReconcileBoardAsync>d__);
			return <ReconcileBoardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035994 RID: 219540 RVA: 0x00EF9183 File Offset: 0x00EF7383
		[NullableContext(2)]
		private MatchThreePieceView GetPiece(GridPosition pos)
		{
			MatchThreePieceView[] pieces = this.Pieces;
			if (pieces == null)
			{
				return null;
			}
			return pieces[MatchThreeGameplayView.CellIdx(pos)];
		}

		// Token: 0x06035995 RID: 219541 RVA: 0x00EF9198 File Offset: 0x00EF7398
		[NullableContext(2)]
		private void SetPiece(GridPosition pos, MatchThreePieceView piece)
		{
			if (this.Pieces != null)
			{
				this.Pieces[MatchThreeGameplayView.CellIdx(pos)] = piece;
			}
		}

		// Token: 0x06035996 RID: 219542 RVA: 0x00EF91B0 File Offset: 0x00EF73B0
		private void AppendNormalPrewarm(List<UniTask> promises)
		{
			for (int i = 0; i < 112; i++)
			{
				promises.Add(this.PrewarmNormalAsync());
			}
		}

		// Token: 0x06035997 RID: 219543 RVA: 0x00EF91D8 File Offset: 0x00EF73D8
		private UniTask PrewarmNormalAsync()
		{
			MatchThreeGameplayView.<PrewarmNormalAsync>d__191 <PrewarmNormalAsync>d__;
			<PrewarmNormalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrewarmNormalAsync>d__.<>4__this = this;
			<PrewarmNormalAsync>d__.<>1__state = -1;
			<PrewarmNormalAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PrewarmNormalAsync>d__191>(ref <PrewarmNormalAsync>d__);
			return <PrewarmNormalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035998 RID: 219544 RVA: 0x00EF921C File Offset: 0x00EF741C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<MatchThreePieceView> AcquirePieceAsync(GridPosition pos, EPieceType type, bool boardRefresh = false)
		{
			MatchThreeGameplayView.<AcquirePieceAsync>d__192 <AcquirePieceAsync>d__;
			<AcquirePieceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MatchThreePieceView>.Create();
			<AcquirePieceAsync>d__.<>4__this = this;
			<AcquirePieceAsync>d__.pos = pos;
			<AcquirePieceAsync>d__.type = type;
			<AcquirePieceAsync>d__.boardRefresh = boardRefresh;
			<AcquirePieceAsync>d__.<>1__state = -1;
			<AcquirePieceAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<AcquirePieceAsync>d__192>(ref <AcquirePieceAsync>d__);
			return <AcquirePieceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035999 RID: 219545 RVA: 0x00EF9277 File Offset: 0x00EF7477
		private void RecyclePiece(MatchThreePieceView view)
		{
			if (this.GuideFocusedPiece == view)
			{
				this.GuideFocusedPiece = null;
			}
			view.RecycleToPool();
			this.PoolOf(view.PrefabId).Push(view);
		}

		// Token: 0x0603599A RID: 219546 RVA: 0x00EF92A4 File Offset: 0x00EF74A4
		private System.Collections.Generic.Stack<MatchThreePieceView> PoolOf(string prefabId)
		{
			System.Collections.Generic.Stack<MatchThreePieceView> stack;
			if (!this.PiecePools.TryGetValue(prefabId, out stack))
			{
				stack = new System.Collections.Generic.Stack<MatchThreePieceView>();
				this.PiecePools[prefabId] = stack;
			}
			return stack;
		}

		// Token: 0x0603599B RID: 219547 RVA: 0x00EF92D8 File Offset: 0x00EF74D8
		protected override void OnBeforeDestroy()
		{
			this.SetBoardNavigationInputBlocked(false);
			this.ClearPendingNavigationRestore();
			this.RestartCleanGeneration++;
			UniTaskCompletionSource restartCleanAbortSource = this.RestartCleanAbortSource;
			if (restartCleanAbortSource != null)
			{
				restartCleanAbortSource.TrySetResult();
			}
			this.RestartCleanAbortSource = null;
			this.PauseHint();
			this.DiscardEnergyTrails();
			UiSequencePlayer turnPopupPlayer = this.TurnPopupPlayer;
			if (turnPopupPlayer != null)
			{
				turnPopupPlayer.Clear();
			}
			this.TurnPopupPlayer = null;
			this.DiscardRecolorPresentation();
			this.ClearRoleSkillPresentation();
			this.ClearRoleSpine();
		}

		// Token: 0x0603599C RID: 219548 RVA: 0x00EF9350 File Offset: 0x00EF7550
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			EPieceComponentType[] array = MatchThreeGameplayView.ParseComponentTypes(configParams);
			if (array.Length == 0 || this.Presenter == null)
			{
				return null;
			}
			GridPosition? gridPosition = this.Presenter.Board.FindFirstPieceWithComponentTypes(array);
			if (gridPosition == null)
			{
				return null;
			}
			MatchThreePieceView piece = this.GetPiece(gridPosition.Value);
			UUIItem uuiitem = (piece != null) ? piece.GetRootItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			this.GuideFocusedPiece = piece;
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0603599D RID: 219549 RVA: 0x00EF93C4 File Offset: 0x00EF75C4
		[NullableContext(2)]
		private void NotifyIfGuideFocusedCleared(MatchThreePieceView piece)
		{
			if (piece == null || this.GuideFocusedPiece != piece)
			{
				return;
			}
			this.GuideFocusedPiece = null;
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MatchThreeGuideFocusPieceCleared");
		}

		// Token: 0x0603599E RID: 219550 RVA: 0x00EF93F0 File Offset: 0x00EF75F0
		private static EPieceComponentType[] ParseComponentTypes(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return Array.Empty<EPieceComponentType>();
			}
			List<EPieceComponentType> list = new List<EPieceComponentType>(configParams.Length);
			for (int i = 0; i < configParams.Length; i++)
			{
				int item;
				if (int.TryParse(configParams[i], out item))
				{
					list.Add((EPieceComponentType)item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0401C516 RID: 115990
		private const string BOARD_NAVIGATION_BLOCK_TAG = "MatchThreeGameplayBoard";

		// Token: 0x0401C517 RID: 115991
		[Nullable(2)]
		private MatchThreePresenter Presenter;

		// Token: 0x0401C518 RID: 115992
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401C519 RID: 115993
		[Nullable(2)]
		private MatchThreePieceView[] Pieces;

		// Token: 0x0401C51A RID: 115994
		private float CellStepX;

		// Token: 0x0401C51B RID: 115995
		private float CellStepY;

		// Token: 0x0401C51C RID: 115996
		private readonly float[] FallDurations = new float[8];

		// Token: 0x0401C51D RID: 115997
		private readonly Dictionary<string, System.Collections.Generic.Stack<MatchThreePieceView>> PiecePools = new Dictionary<string, System.Collections.Generic.Stack<MatchThreePieceView>>();

		// Token: 0x0401C51E RID: 115998
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> TrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C51F RID: 115999
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> EnergyTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C520 RID: 116000
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> AllureTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C521 RID: 116001
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> ChainTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C522 RID: 116002
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> ChainDetonationTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C523 RID: 116003
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> MechanicTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C524 RID: 116004
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> RecycleChargerTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C525 RID: 116005
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> RecycleHourglassTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x0401C526 RID: 116006
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MatchThreeMechanicItemView, MechanicDisplayData> MechanicsLayout;

		// Token: 0x0401C527 RID: 116007
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UCurveFloat[] SkillTrailCurveX = new UCurveFloat[2];

		// Token: 0x0401C528 RID: 116008
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UCurveFloat[] SkillTrailCurveY = new UCurveFloat[2];

		// Token: 0x0401C529 RID: 116009
		[Nullable(2)]
		private UCurveFloat EnergyTrailCurveX;

		// Token: 0x0401C52A RID: 116010
		[Nullable(2)]
		private UCurveFloat EnergyTrailCurveY;

		// Token: 0x0401C52B RID: 116011
		[Nullable(2)]
		private UCurveFloat MechanicTrailCurveX;

		// Token: 0x0401C52C RID: 116012
		[Nullable(2)]
		private UCurveFloat MechanicTrailCurveY;

		// Token: 0x0401C52D RID: 116013
		[Nullable(2)]
		private UCurveFloat ChainSkillTrailCurve;

		// Token: 0x0401C52E RID: 116014
		[Nullable(2)]
		private UCurveFloat FallCurve;

		// Token: 0x0401C52F RID: 116015
		private float FallCurveStart;

		// Token: 0x0401C530 RID: 116016
		private float FallCurveLand = 1f;

		// Token: 0x0401C531 RID: 116017
		private float FallCurveEnd = 1f;

		// Token: 0x0401C532 RID: 116018
		private readonly EMatchThreeRoleSpineAnim[] RoleAmbientAnims = new EMatchThreeRoleSpineAnim[]
		{
			EMatchThreeRoleSpineAnim.Idle,
			EMatchThreeRoleSpineAnim.Start
		};

		// Token: 0x0401C533 RID: 116019
		private readonly Random RoleAnimRandom = new Random();

		// Token: 0x0401C534 RID: 116020
		[Nullable(2)]
		private AutoResetUniTaskCompletionSource RoleSkillTcs;

		// Token: 0x0401C535 RID: 116021
		private bool RoleSpineReady;

		// Token: 0x0401C536 RID: 116022
		private bool BoardNavigationInputBlocked;

		// Token: 0x0401C537 RID: 116023
		private int HintThresholdMs;

		// Token: 0x0401C538 RID: 116024
		private double HintRemainMs;

		// Token: 0x0401C539 RID: 116025
		private double HintDeadlineMs;

		// Token: 0x0401C53A RID: 116026
		[Nullable(2)]
		private TimerHandle HintTimer;

		// Token: 0x0401C53B RID: 116027
		[Nullable(2)]
		private MatchThreePieceView HintPieceA;

		// Token: 0x0401C53C RID: 116028
		[Nullable(2)]
		private MatchThreePieceView HintPieceB;

		// Token: 0x0401C53D RID: 116029
		private ValidMove? HintMove;

		// Token: 0x0401C53E RID: 116030
		[Nullable(2)]
		private MatchThreeSkillPointView SmallSkillPoint;

		// Token: 0x0401C53F RID: 116031
		[Nullable(2)]
		private MatchThreeSkillPointView BigSkillPoint;

		// Token: 0x0401C540 RID: 116032
		[Nullable(2)]
		private UiSequencePlayer TurnPopupPlayer;

		// Token: 0x0401C541 RID: 116033
		[Nullable(2)]
		private MatchThreeEnvTipsView EnvTipsView;

		// Token: 0x0401C542 RID: 116034
		[Nullable(2)]
		private MatchThreeSkillTipsView SkillTipsView;

		// Token: 0x0401C543 RID: 116035
		[Nullable(2)]
		private MatchThreeScorePopView ScorePopView;

		// Token: 0x0401C544 RID: 116036
		[Nullable(2)]
		private MatchThreeGradePopView GradePopView;

		// Token: 0x0401C545 RID: 116037
		private bool ScorePopShown;

		// Token: 0x0401C546 RID: 116038
		private GridPosition? PendingNavigationRestoreSource;

		// Token: 0x0401C547 RID: 116039
		private GridPosition? PendingNavigationRestoreTarget;

		// Token: 0x0401C548 RID: 116040
		private GridPosition? PressedPos;

		// Token: 0x0401C549 RID: 116041
		private double PressedAtMs;

		// Token: 0x0401C54A RID: 116042
		private int PointerDownThresholdMs;

		// Token: 0x0401C54B RID: 116043
		private readonly List<UniTask> PendingSpawns = new List<UniTask>();

		// Token: 0x0401C54C RID: 116044
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly MatchThreePieceView[] ClearTargets = new MatchThreePieceView[56];

		// Token: 0x0401C54D RID: 116045
		[TupleElementNames(new string[]
		{
			"Cell",
			"View"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<int, MatchThreePieceView>> SpawnTargets = new List<ValueTuple<int, MatchThreePieceView>>();

		// Token: 0x0401C54E RID: 116046
		private readonly List<UniTask> SpawnPrepares = new List<UniTask>();

		// Token: 0x0401C54F RID: 116047
		private readonly List<UniTask> PendingEnergyTrails = new List<UniTask>();

		// Token: 0x0401C550 RID: 116048
		private readonly List<UniTask> PendingRecycleTrails = new List<UniTask>();

		// Token: 0x0401C551 RID: 116049
		private int TrailGeneration;

		// Token: 0x0401C552 RID: 116050
		private int RecolorGeneration;

		// Token: 0x0401C553 RID: 116051
		private int TrailsInFlight;

		// Token: 0x0401C554 RID: 116052
		[Nullable(2)]
		private UiSequencePlayer AllureSkillPlayer;

		// Token: 0x0401C555 RID: 116053
		[Nullable(2)]
		private UiSequencePlayer ChainSkillPlayer;

		// Token: 0x0401C556 RID: 116054
		[Nullable(2)]
		private AUIBaseActor AllureSkillActor;

		// Token: 0x0401C557 RID: 116055
		[Nullable(2)]
		private AUIBaseActor ChainSkillActor;

		// Token: 0x0401C558 RID: 116056
		[Nullable(2)]
		private UniTaskCompletionSource SmallSkillSequenceGate;

		// Token: 0x0401C559 RID: 116057
		private ESkillCastEffect ActiveSmallSkillEffect;

		// Token: 0x0401C55A RID: 116058
		private bool SmallSkillUpReceived;

		// Token: 0x0401C55B RID: 116059
		private int RoleSkillSequenceVersion;

		// Token: 0x0401C55C RID: 116060
		private int RestartCleanGeneration;

		// Token: 0x0401C55D RID: 116061
		[Nullable(2)]
		private UniTaskCompletionSource RestartCleanAbortSource;

		// Token: 0x0401C55E RID: 116062
		private const int NORMAL_PREWARM_COUNT = 112;

		// Token: 0x0401C55F RID: 116063
		[Nullable(2)]
		private MatchThreePieceView GuideFocusedPiece;

		// Token: 0x0200B0C0 RID: 45248
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036A12 RID: 223762
			CaptionItem,
			// Token: 0x04036A13 RID: 223763
			PnlTile,
			// Token: 0x04036A14 RID: 223764
			PnlEffect,
			// Token: 0x04036A15 RID: 223765
			TileItem,
			// Token: 0x04036A16 RID: 223766
			MechanicsLayout,
			// Token: 0x04036A17 RID: 223767
			MechanicsLayoutItem,
			// Token: 0x04036A18 RID: 223768
			TextRemainTurn,
			// Token: 0x04036A19 RID: 223769
			PnlPopupTurn,
			// Token: 0x04036A1A RID: 223770
			TextPopupTurn,
			// Token: 0x04036A1B RID: 223771
			SprProgressFill,
			// Token: 0x04036A1C RID: 223772
			TextProgress,
			// Token: 0x04036A1D RID: 223773
			SprTargetIcon,
			// Token: 0x04036A1E RID: 223774
			SpineRole,
			// Token: 0x04036A1F RID: 223775
			TextRoleName,
			// Token: 0x04036A20 RID: 223776
			BtnRoleInfo,
			// Token: 0x04036A21 RID: 223777
			SprSkillBarFill,
			// Token: 0x04036A22 RID: 223778
			PnlHor,
			// Token: 0x04036A23 RID: 223779
			SmallSkillPoint,
			// Token: 0x04036A24 RID: 223780
			BigSkillPoint,
			// Token: 0x04036A25 RID: 223781
			PnlPop,
			// Token: 0x04036A26 RID: 223782
			SprProgressBg,
			// Token: 0x04036A27 RID: 223783
			PnlSkillChain,
			// Token: 0x04036A28 RID: 223784
			PnlRayMask,
			// Token: 0x04036A29 RID: 223785
			SpineRoleBack,
			// Token: 0x04036A2A RID: 223786
			BtnEnvInfo,
			// Token: 0x04036A2B RID: 223787
			NiaEnergy,
			// Token: 0x04036A2C RID: 223788
			PnlSkillXin,
			// Token: 0x04036A2D RID: 223789
			PnlBgNor,
			// Token: 0x04036A2E RID: 223790
			PnlBgEndless,
			// Token: 0x04036A2F RID: 223791
			TxtSkillEnergyNum,
			// Token: 0x04036A30 RID: 223792
			PnlRolePivotWaist,
			// Token: 0x04036A31 RID: 223793
			PnlRolePivotSuoming,
			// Token: 0x04036A32 RID: 223794
			TxtRecord,
			// Token: 0x04036A33 RID: 223795
			PnlRolePivotXin
		}
	}
}
