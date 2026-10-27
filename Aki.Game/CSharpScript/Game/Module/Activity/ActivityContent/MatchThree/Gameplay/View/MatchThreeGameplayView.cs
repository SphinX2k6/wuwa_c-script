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
	// Token: 0x020064D9 RID: 25817
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGameplayView : UiViewBase
	{
		// Token: 0x06040C5E RID: 265310 RVA: 0x00FAF59C File Offset: 0x00FAD79C
		public MatchThreeGameplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040C5F RID: 265311 RVA: 0x00FAF6AC File Offset: 0x00FAD8AC
		private UniTask LoadTrailCurvesAsync()
		{
			MatchThreeGameplayView.<LoadTrailCurvesAsync>d__30 <LoadTrailCurvesAsync>d__;
			<LoadTrailCurvesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTrailCurvesAsync>d__.<>4__this = this;
			<LoadTrailCurvesAsync>d__.<>1__state = -1;
			<LoadTrailCurvesAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<LoadTrailCurvesAsync>d__30>(ref <LoadTrailCurvesAsync>d__);
			return <LoadTrailCurvesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C60 RID: 265312 RVA: 0x00FAF6F0 File Offset: 0x00FAD8F0
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

		// Token: 0x06040C61 RID: 265313 RVA: 0x00FAF7E4 File Offset: 0x00FAD9E4
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

		// Token: 0x06040C62 RID: 265314 RVA: 0x00FAF828 File Offset: 0x00FADA28
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

		// Token: 0x06040C63 RID: 265315 RVA: 0x00FAFD2D File Offset: 0x00FADF2D
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

		// Token: 0x06040C64 RID: 265316 RVA: 0x00FAFD54 File Offset: 0x00FADF54
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ELGUINavigationDirection>(EEventName.MatchThreeSwapPieceInput, new Action<ELGUINavigationDirection>(this.OnSwapPieceInput));
			EventSystem.Instance.Add(EEventName.OnMatchThreeBoardSettled, new Action(this.RestoreSwapNavigationFocus));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06040C65 RID: 265317 RVA: 0x00FAFDB8 File Offset: 0x00FADFB8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ELGUINavigationDirection>(EEventName.MatchThreeSwapPieceInput, new Action<ELGUINavigationDirection>(this.OnSwapPieceInput));
			EventSystem.Instance.Remove(EEventName.OnMatchThreeBoardSettled, new Action(this.RestoreSwapNavigationFocus));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06040C66 RID: 265318 RVA: 0x00FAFE1C File Offset: 0x00FAE01C
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeGameplayView.<OnBeforeStartAsync>d__37 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<OnBeforeStartAsync>d__37>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C67 RID: 265319 RVA: 0x00FAFE5F File Offset: 0x00FAE05F
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

		// Token: 0x06040C68 RID: 265320 RVA: 0x00FAFE80 File Offset: 0x00FAE080
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

		// Token: 0x06040C69 RID: 265321 RVA: 0x00FAFED4 File Offset: 0x00FAE0D4
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

		// Token: 0x06040C6A RID: 265322 RVA: 0x00FAFF42 File Offset: 0x00FAE142
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(683);
		}

		// Token: 0x06040C6B RID: 265323 RVA: 0x00FAFF54 File Offset: 0x00FAE154
		private UniTask RefreshRoleAsync()
		{
			MatchThreeGameplayView.<RefreshRoleAsync>d__42 <RefreshRoleAsync>d__;
			<RefreshRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleAsync>d__.<>4__this = this;
			<RefreshRoleAsync>d__.<>1__state = -1;
			<RefreshRoleAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<RefreshRoleAsync>d__42>(ref <RefreshRoleAsync>d__);
			return <RefreshRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C6C RID: 265324 RVA: 0x00FAFF98 File Offset: 0x00FAE198
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

		// Token: 0x06040C6D RID: 265325 RVA: 0x00FB0090 File Offset: 0x00FAE290
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

		// Token: 0x06040C6E RID: 265326 RVA: 0x00FB011C File Offset: 0x00FAE31C
		private void OnClickRoleInfo()
		{
			ActivityMatchThreeController instance = ActivityMatchThreeController.Instance;
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			instance.OpenRoleInfo((context != null) ? context.RoleId : 0, null);
		}

		// Token: 0x06040C6F RID: 265327 RVA: 0x00FB0140 File Offset: 0x00FAE340
		private void OnClickEnvInfo()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (context == null)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(context.LevelId, context.RoleId, true, 0, 0);
		}

		// Token: 0x06040C70 RID: 265328 RVA: 0x00FB0175 File Offset: 0x00FAE375
		private void PlayRoleAmbientAnim()
		{
			this.SetRoleAnim(this.RoleAmbientAnims[this.RoleAnimRandom.Next(this.RoleAmbientAnims.Length)].ToEnumString());
		}

		// Token: 0x06040C71 RID: 265329 RVA: 0x00FB019C File Offset: 0x00FAE39C
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

		// Token: 0x06040C72 RID: 265330 RVA: 0x00FB01CB File Offset: 0x00FAE3CB
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

		// Token: 0x06040C73 RID: 265331 RVA: 0x00FB01F0 File Offset: 0x00FAE3F0
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

		// Token: 0x06040C74 RID: 265332 RVA: 0x00FB0258 File Offset: 0x00FAE458
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

		// Token: 0x06040C75 RID: 265333 RVA: 0x00FB02B0 File Offset: 0x00FAE4B0
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

		// Token: 0x06040C76 RID: 265334 RVA: 0x00FB02D6 File Offset: 0x00FAE4D6
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

		// Token: 0x06040C77 RID: 265335 RVA: 0x00FB030C File Offset: 0x00FAE50C
		public void ResetHintCountdown()
		{
			this.HintRemainMs = (double)this.HintThresholdMs;
			this.HintMove = null;
		}

		// Token: 0x06040C78 RID: 265336 RVA: 0x00FB0327 File Offset: 0x00FAE527
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

		// Token: 0x06040C79 RID: 265337 RVA: 0x00FB0364 File Offset: 0x00FAE564
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

		// Token: 0x06040C7A RID: 265338 RVA: 0x00FB03F1 File Offset: 0x00FAE5F1
		private void OnHintTimeout(float delta)
		{
			this.HintTimer = null;
			this.HintRemainMs = 0.0;
			this.ShowHint();
		}

		// Token: 0x06040C7B RID: 265339 RVA: 0x00FB0410 File Offset: 0x00FAE610
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

		// Token: 0x06040C7C RID: 265340 RVA: 0x00FB04C9 File Offset: 0x00FAE6C9
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

		// Token: 0x06040C7D RID: 265341 RVA: 0x00FB04FC File Offset: 0x00FAE6FC
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

		// Token: 0x06040C7E RID: 265342 RVA: 0x00FB0550 File Offset: 0x00FAE750
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

		// Token: 0x06040C7F RID: 265343 RVA: 0x00FB05AB File Offset: 0x00FAE7AB
		public void RefreshMechanics()
		{
			if (this.MechanicsLayout == null || this.Presenter == null)
			{
				return;
			}
			this.MechanicsLayout.RefreshByData(this.Presenter.CollectMechanicDisplays(), null, false);
		}

		// Token: 0x06040C80 RID: 265344 RVA: 0x00FB05D8 File Offset: 0x00FAE7D8
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

		// Token: 0x06040C81 RID: 265345 RVA: 0x00FB06CC File Offset: 0x00FAE8CC
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

		// Token: 0x06040C82 RID: 265346 RVA: 0x00FB0798 File Offset: 0x00FAE998
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

		// Token: 0x06040C83 RID: 265347 RVA: 0x00FB07E7 File Offset: 0x00FAE9E7
		public void RefreshTurn()
		{
			if (this.Presenter == null)
			{
				return;
			}
			this.RefreshTurn(this.Presenter.RemainingTurns);
		}

		// Token: 0x06040C84 RID: 265348 RVA: 0x00FB0804 File Offset: 0x00FAEA04
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

		// Token: 0x06040C85 RID: 265349 RVA: 0x00FB0860 File Offset: 0x00FAEA60
		public void PlayTurnDelta(int delta)
		{
			this.PlayTurnDeltaAsync(delta).Forget();
		}

		// Token: 0x06040C86 RID: 265350 RVA: 0x00FB0870 File Offset: 0x00FAEA70
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

		// Token: 0x06040C87 RID: 265351 RVA: 0x00FB08BC File Offset: 0x00FAEABC
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

		// Token: 0x06040C88 RID: 265352 RVA: 0x00FB0918 File Offset: 0x00FAEB18
		public UniTask HideEnvTipsAsync()
		{
			MatchThreeGameplayView.<HideEnvTipsAsync>d__87 <HideEnvTipsAsync>d__;
			<HideEnvTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideEnvTipsAsync>d__.<>4__this = this;
			<HideEnvTipsAsync>d__.<>1__state = -1;
			<HideEnvTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideEnvTipsAsync>d__87>(ref <HideEnvTipsAsync>d__);
			return <HideEnvTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C89 RID: 265353 RVA: 0x00FB095C File Offset: 0x00FAEB5C
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

		// Token: 0x06040C8A RID: 265354 RVA: 0x00FB09B0 File Offset: 0x00FAEBB0
		public UniTask HideSkillTipsAsync()
		{
			MatchThreeGameplayView.<HideSkillTipsAsync>d__90 <HideSkillTipsAsync>d__;
			<HideSkillTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideSkillTipsAsync>d__.<>4__this = this;
			<HideSkillTipsAsync>d__.<>1__state = -1;
			<HideSkillTipsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideSkillTipsAsync>d__90>(ref <HideSkillTipsAsync>d__);
			return <HideSkillTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C8B RID: 265355 RVA: 0x00FB09F4 File Offset: 0x00FAEBF4
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

		// Token: 0x06040C8C RID: 265356 RVA: 0x00FB0A40 File Offset: 0x00FAEC40
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

		// Token: 0x06040C8D RID: 265357 RVA: 0x00FB0A8C File Offset: 0x00FAEC8C
		public UniTask HideScoreAndGradeAsync()
		{
			MatchThreeGameplayView.<HideScoreAndGradeAsync>d__96 <HideScoreAndGradeAsync>d__;
			<HideScoreAndGradeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideScoreAndGradeAsync>d__.<>4__this = this;
			<HideScoreAndGradeAsync>d__.<>1__state = -1;
			<HideScoreAndGradeAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<HideScoreAndGradeAsync>d__96>(ref <HideScoreAndGradeAsync>d__);
			return <HideScoreAndGradeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040C8E RID: 265358 RVA: 0x00FB0ACF File Offset: 0x00FAECCF
		private bool RaiseSwap(GridPosition a, GridPosition b)
		{
			MatchThreePresenter presenter = this.Presenter;
			return presenter != null && presenter.RequestSwap(a, b);
		}

		// Token: 0x06040C8F RID: 265359 RVA: 0x00FB0AE4 File Offset: 0x00FAECE4
		private void OnSwapPieceInput(ELGUINavigationDirection direction)
		{
			this.TrySwapFocusedPiece(direction);
		}

		// Token: 0x06040C90 RID: 265360 RVA: 0x00FB0AF0 File Offset: 0x00FAECF0
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
							MatchThreePieceView matchThreePieceView = this.Pieces[num, i];
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

		// Token: 0x06040C91 RID: 265361 RVA: 0x00FB0C50 File Offset: 0x00FAEE50
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

		// Token: 0x06040C92 RID: 265362 RVA: 0x00FB0CF4 File Offset: 0x00FAEEF4
		private void ClearPendingNavigationRestore()
		{
			this.PendingNavigationRestoreSource = null;
			this.PendingNavigationRestoreTarget = null;
		}

		// Token: 0x06040C93 RID: 265363 RVA: 0x00FB0D0E File Offset: 0x00FAEF0E
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

		// Token: 0x06040C94 RID: 265364 RVA: 0x00FB0D3C File Offset: 0x00FAEF3C
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener UpdateBoardDefaultListener()
		{
			if (this.Pieces == null)
			{
				return null;
			}
			MatchThreePieceView matchThreePieceView = this.Pieces[0, 0];
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

		// Token: 0x06040C95 RID: 265365 RVA: 0x00FB0DD8 File Offset: 0x00FAEFD8
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

		// Token: 0x06040C96 RID: 265366 RVA: 0x00FB0E7A File Offset: 0x00FAF07A
		private void OnPiecePressed(GridPosition pos)
		{
			this.PressedPos = new GridPosition?(pos);
			this.PressedAtMs = Time.Instance.Now;
		}

		// Token: 0x06040C97 RID: 265367 RVA: 0x00FB0E98 File Offset: 0x00FAF098
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

		// Token: 0x06040C98 RID: 265368 RVA: 0x00FB0F30 File Offset: 0x00FAF130
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

		// Token: 0x06040C99 RID: 265369 RVA: 0x00FB0F84 File Offset: 0x00FAF184
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

		// Token: 0x06040C9A RID: 265370 RVA: 0x00FB0FD8 File Offset: 0x00FAF1D8
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

		// Token: 0x06040C9B RID: 265371 RVA: 0x00FB105C File Offset: 0x00FAF25C
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

		// Token: 0x06040C9C RID: 265372 RVA: 0x00FB10B0 File Offset: 0x00FAF2B0
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

		// Token: 0x06040C9D RID: 265373 RVA: 0x00FB1104 File Offset: 0x00FAF304
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

		// Token: 0x06040C9E RID: 265374 RVA: 0x00FB1174 File Offset: 0x00FAF374
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

		// Token: 0x06040C9F RID: 265375 RVA: 0x00FB11E4 File Offset: 0x00FAF3E4
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

		// Token: 0x06040CA0 RID: 265376 RVA: 0x00FB1248 File Offset: 0x00FAF448
		private static UniTask DelayAsync(int ms)
		{
			if (ms > 0)
			{
				return MatchThreeGameplayView.DelayCoreAsync(ms);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06040CA1 RID: 265377 RVA: 0x00FB125C File Offset: 0x00FAF45C
		private static UniTask DelayCoreAsync(int ms)
		{
			MatchThreeGameplayView.<DelayCoreAsync>d__121 <DelayCoreAsync>d__;
			<DelayCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DelayCoreAsync>d__.ms = ms;
			<DelayCoreAsync>d__.<>1__state = -1;
			<DelayCoreAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<DelayCoreAsync>d__121>(ref <DelayCoreAsync>d__);
			return <DelayCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CA2 RID: 265378 RVA: 0x00FB12A0 File Offset: 0x00FAF4A0
		public UniTask FlushSpawnsAsync()
		{
			MatchThreeGameplayView.<FlushSpawnsAsync>d__123 <FlushSpawnsAsync>d__;
			<FlushSpawnsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushSpawnsAsync>d__.<>4__this = this;
			<FlushSpawnsAsync>d__.<>1__state = -1;
			<FlushSpawnsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushSpawnsAsync>d__123>(ref <FlushSpawnsAsync>d__);
			return <FlushSpawnsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CA3 RID: 265379 RVA: 0x00FB12E3 File Offset: 0x00FAF4E3
		private static int CellIdx(GridPosition pos)
		{
			return pos.Row * 8 + pos.Col;
		}

		// Token: 0x06040CA4 RID: 265380 RVA: 0x00FB12F4 File Offset: 0x00FAF4F4
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

		// Token: 0x06040CA5 RID: 265381 RVA: 0x00FB1348 File Offset: 0x00FAF548
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

		// Token: 0x06040CA6 RID: 265382 RVA: 0x00FB13AC File Offset: 0x00FAF5AC
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

		// Token: 0x06040CA7 RID: 265383 RVA: 0x00FB13F8 File Offset: 0x00FAF5F8
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

		// Token: 0x06040CA8 RID: 265384 RVA: 0x00FB1444 File Offset: 0x00FAF644
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

		// Token: 0x06040CA9 RID: 265385 RVA: 0x00FB14A0 File Offset: 0x00FAF6A0
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

		// Token: 0x06040CAA RID: 265386 RVA: 0x00FB153C File Offset: 0x00FAF73C
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

		// Token: 0x06040CAB RID: 265387 RVA: 0x00FB1578 File Offset: 0x00FAF778
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

		// Token: 0x06040CAC RID: 265388 RVA: 0x00FB160C File Offset: 0x00FAF80C
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

		// Token: 0x06040CAD RID: 265389 RVA: 0x00FB1678 File Offset: 0x00FAF878
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

		// Token: 0x06040CAE RID: 265390 RVA: 0x00FB16E8 File Offset: 0x00FAF8E8
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

		// Token: 0x06040CAF RID: 265391 RVA: 0x00FB1724 File Offset: 0x00FAF924
		public UniTask FlushEnergyTrailsAsync()
		{
			MatchThreeGameplayView.<FlushEnergyTrailsAsync>d__144 <FlushEnergyTrailsAsync>d__;
			<FlushEnergyTrailsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushEnergyTrailsAsync>d__.<>4__this = this;
			<FlushEnergyTrailsAsync>d__.<>1__state = -1;
			<FlushEnergyTrailsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushEnergyTrailsAsync>d__144>(ref <FlushEnergyTrailsAsync>d__);
			return <FlushEnergyTrailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CB0 RID: 265392 RVA: 0x00FB1768 File Offset: 0x00FAF968
		public UniTask FlushRecycleTrailsAsync()
		{
			MatchThreeGameplayView.<FlushRecycleTrailsAsync>d__145 <FlushRecycleTrailsAsync>d__;
			<FlushRecycleTrailsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushRecycleTrailsAsync>d__.<>4__this = this;
			<FlushRecycleTrailsAsync>d__.<>1__state = -1;
			<FlushRecycleTrailsAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<FlushRecycleTrailsAsync>d__145>(ref <FlushRecycleTrailsAsync>d__);
			return <FlushRecycleTrailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CB1 RID: 265393 RVA: 0x00FB17AB File Offset: 0x00FAF9AB
		public void DiscardEnergyTrails()
		{
			this.TrailGeneration++;
			this.PendingEnergyTrails.Clear();
			this.PendingRecycleTrails.Clear();
			this.TrailsInFlight = 0;
		}

		// Token: 0x06040CB2 RID: 265394 RVA: 0x00FB17D8 File Offset: 0x00FAF9D8
		private void DiscardRecolorPresentation()
		{
			this.RecolorGeneration++;
		}

		// Token: 0x06040CB3 RID: 265395 RVA: 0x00FB17E8 File Offset: 0x00FAF9E8
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

		// Token: 0x06040CB4 RID: 265396 RVA: 0x00FB183C File Offset: 0x00FAFA3C
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

		// Token: 0x06040CB5 RID: 265397 RVA: 0x00FB1898 File Offset: 0x00FAFA98
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

		// Token: 0x06040CB6 RID: 265398 RVA: 0x00FB18EC File Offset: 0x00FAFAEC
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

		// Token: 0x06040CB7 RID: 265399 RVA: 0x00FB198E File Offset: 0x00FAFB8E
		private void OnAllureSkillSequenceEvent(string sequenceName, string eventName)
		{
			this.OnRoleSkillSequenceEvent(ESkillCastEffect.Allure, sequenceName, eventName);
		}

		// Token: 0x06040CB8 RID: 265400 RVA: 0x00FB1999 File Offset: 0x00FAFB99
		private void OnChainSkillSequenceEvent(string sequenceName, string eventName)
		{
			this.OnRoleSkillSequenceEvent(ESkillCastEffect.Chain, sequenceName, eventName);
		}

		// Token: 0x06040CB9 RID: 265401 RVA: 0x00FB19A4 File Offset: 0x00FAFBA4
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

		// Token: 0x06040CBA RID: 265402 RVA: 0x00FB19F4 File Offset: 0x00FAFBF4
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

		// Token: 0x06040CBB RID: 265403 RVA: 0x00FB1ACC File Offset: 0x00FAFCCC
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

		// Token: 0x06040CBC RID: 265404 RVA: 0x00FB1B28 File Offset: 0x00FAFD28
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

		// Token: 0x06040CBD RID: 265405 RVA: 0x00FB1B8C File Offset: 0x00FAFD8C
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

		// Token: 0x06040CBE RID: 265406 RVA: 0x00FB1BF9 File Offset: 0x00FAFDF9
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

		// Token: 0x06040CBF RID: 265407 RVA: 0x00FB1C12 File Offset: 0x00FAFE12
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

		// Token: 0x06040CC0 RID: 265408 RVA: 0x00FB1C2F File Offset: 0x00FAFE2F
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

		// Token: 0x06040CC1 RID: 265409 RVA: 0x00FB1C60 File Offset: 0x00FAFE60
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

		// Token: 0x06040CC2 RID: 265410 RVA: 0x00FB1C84 File Offset: 0x00FAFE84
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

		// Token: 0x06040CC3 RID: 265411 RVA: 0x00FB1CD4 File Offset: 0x00FAFED4
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

		// Token: 0x06040CC4 RID: 265412 RVA: 0x00FB1D24 File Offset: 0x00FAFF24
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

		// Token: 0x06040CC5 RID: 265413 RVA: 0x00FB1DA4 File Offset: 0x00FAFFA4
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

		// Token: 0x06040CC6 RID: 265414 RVA: 0x00FB1E00 File Offset: 0x00FB0000
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

		// Token: 0x06040CC7 RID: 265415 RVA: 0x00FB1E54 File Offset: 0x00FB0054
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

		// Token: 0x06040CC8 RID: 265416 RVA: 0x00FB1EB8 File Offset: 0x00FB00B8
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

		// Token: 0x06040CC9 RID: 265417 RVA: 0x00FB1F5C File Offset: 0x00FB015C
		public UniTask PlayReshuffleAsync()
		{
			MatchThreeGameplayView.<PlayReshuffleAsync>d__178 <PlayReshuffleAsync>d__;
			<PlayReshuffleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReshuffleAsync>d__.<>4__this = this;
			<PlayReshuffleAsync>d__.<>1__state = -1;
			<PlayReshuffleAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PlayReshuffleAsync>d__178>(ref <PlayReshuffleAsync>d__);
			return <PlayReshuffleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CCA RID: 265418 RVA: 0x00FB1FA0 File Offset: 0x00FB01A0
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

		// Token: 0x06040CCB RID: 265419 RVA: 0x00FB1FE3 File Offset: 0x00FB01E3
		private void PrepareBoardRefresh(bool clearPendingNavigationRestore)
		{
			if (clearPendingNavigationRestore)
			{
				this.ClearPendingNavigationRestore();
			}
			this.SetBoardNavigationInputBlocked(true);
		}

		// Token: 0x06040CCC RID: 265420 RVA: 0x00FB1FF8 File Offset: 0x00FB01F8
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

		// Token: 0x06040CCD RID: 265421 RVA: 0x00FB2044 File Offset: 0x00FB0244
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

		// Token: 0x06040CCE RID: 265422 RVA: 0x00FB20A8 File Offset: 0x00FB02A8
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

		// Token: 0x06040CCF RID: 265423 RVA: 0x00FB20FC File Offset: 0x00FB02FC
		public UniTask ReconcileBoardAsync()
		{
			MatchThreeGameplayView.<ReconcileBoardAsync>d__186 <ReconcileBoardAsync>d__;
			<ReconcileBoardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconcileBoardAsync>d__.<>4__this = this;
			<ReconcileBoardAsync>d__.<>1__state = -1;
			<ReconcileBoardAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<ReconcileBoardAsync>d__186>(ref <ReconcileBoardAsync>d__);
			return <ReconcileBoardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CD0 RID: 265424 RVA: 0x00FB213F File Offset: 0x00FB033F
		[NullableContext(2)]
		private MatchThreePieceView GetPiece(GridPosition pos)
		{
			MatchThreePieceView[,] pieces = this.Pieces;
			if (pieces == null)
			{
				return null;
			}
			return pieces[pos.Row, pos.Col];
		}

		// Token: 0x06040CD1 RID: 265425 RVA: 0x00FB215E File Offset: 0x00FB035E
		[NullableContext(2)]
		private void SetPiece(GridPosition pos, MatchThreePieceView piece)
		{
			if (this.Pieces != null)
			{
				this.Pieces[pos.Row, pos.Col] = piece;
			}
		}

		// Token: 0x06040CD2 RID: 265426 RVA: 0x00FB2180 File Offset: 0x00FB0380
		private void AppendNormalPrewarm(List<UniTask> promises)
		{
			for (int i = 0; i < 112; i++)
			{
				promises.Add(this.PrewarmNormalAsync());
			}
		}

		// Token: 0x06040CD3 RID: 265427 RVA: 0x00FB21A8 File Offset: 0x00FB03A8
		private UniTask PrewarmNormalAsync()
		{
			MatchThreeGameplayView.<PrewarmNormalAsync>d__191 <PrewarmNormalAsync>d__;
			<PrewarmNormalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrewarmNormalAsync>d__.<>4__this = this;
			<PrewarmNormalAsync>d__.<>1__state = -1;
			<PrewarmNormalAsync>d__.<>t__builder.Start<MatchThreeGameplayView.<PrewarmNormalAsync>d__191>(ref <PrewarmNormalAsync>d__);
			return <PrewarmNormalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CD4 RID: 265428 RVA: 0x00FB21EC File Offset: 0x00FB03EC
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

		// Token: 0x06040CD5 RID: 265429 RVA: 0x00FB2247 File Offset: 0x00FB0447
		private void RecyclePiece(MatchThreePieceView view)
		{
			if (this.GuideFocusedPiece == view)
			{
				this.GuideFocusedPiece = null;
			}
			view.RecycleToPool();
			this.PoolOf(view.PrefabId).Push(view);
		}

		// Token: 0x06040CD6 RID: 265430 RVA: 0x00FB2274 File Offset: 0x00FB0474
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

		// Token: 0x06040CD7 RID: 265431 RVA: 0x00FB22A8 File Offset: 0x00FB04A8
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

		// Token: 0x06040CD8 RID: 265432 RVA: 0x00FB2320 File Offset: 0x00FB0520
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

		// Token: 0x06040CD9 RID: 265433 RVA: 0x00FB2394 File Offset: 0x00FB0594
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

		// Token: 0x06040CDA RID: 265434 RVA: 0x00FB23C0 File Offset: 0x00FB05C0
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

		// Token: 0x04021BE5 RID: 138213
		private const string BOARD_NAVIGATION_BLOCK_TAG = "MatchThreeGameplayBoard";

		// Token: 0x04021BE6 RID: 138214
		[Nullable(2)]
		private MatchThreePresenter Presenter;

		// Token: 0x04021BE7 RID: 138215
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04021BE8 RID: 138216
		[Nullable(2)]
		private MatchThreePieceView[,] Pieces;

		// Token: 0x04021BE9 RID: 138217
		private float CellStepX;

		// Token: 0x04021BEA RID: 138218
		private float CellStepY;

		// Token: 0x04021BEB RID: 138219
		private readonly float[] FallDurations = new float[8];

		// Token: 0x04021BEC RID: 138220
		private readonly Dictionary<string, System.Collections.Generic.Stack<MatchThreePieceView>> PiecePools = new Dictionary<string, System.Collections.Generic.Stack<MatchThreePieceView>>();

		// Token: 0x04021BED RID: 138221
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> TrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BEE RID: 138222
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> EnergyTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BEF RID: 138223
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> AllureTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF0 RID: 138224
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> ChainTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF1 RID: 138225
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> ChainDetonationTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF2 RID: 138226
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> MechanicTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF3 RID: 138227
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> RecycleChargerTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF4 RID: 138228
		private readonly System.Collections.Generic.Stack<MatchThreeTrailEffectView> RecycleHourglassTrailPool = new System.Collections.Generic.Stack<MatchThreeTrailEffectView>();

		// Token: 0x04021BF5 RID: 138229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MatchThreeMechanicItemView, MechanicDisplayData> MechanicsLayout;

		// Token: 0x04021BF6 RID: 138230
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UCurveFloat[] SkillTrailCurveX = new UCurveFloat[2];

		// Token: 0x04021BF7 RID: 138231
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UCurveFloat[] SkillTrailCurveY = new UCurveFloat[2];

		// Token: 0x04021BF8 RID: 138232
		[Nullable(2)]
		private UCurveFloat EnergyTrailCurveX;

		// Token: 0x04021BF9 RID: 138233
		[Nullable(2)]
		private UCurveFloat EnergyTrailCurveY;

		// Token: 0x04021BFA RID: 138234
		[Nullable(2)]
		private UCurveFloat MechanicTrailCurveX;

		// Token: 0x04021BFB RID: 138235
		[Nullable(2)]
		private UCurveFloat MechanicTrailCurveY;

		// Token: 0x04021BFC RID: 138236
		[Nullable(2)]
		private UCurveFloat ChainSkillTrailCurve;

		// Token: 0x04021BFD RID: 138237
		[Nullable(2)]
		private UCurveFloat FallCurve;

		// Token: 0x04021BFE RID: 138238
		private float FallCurveStart;

		// Token: 0x04021BFF RID: 138239
		private float FallCurveLand = 1f;

		// Token: 0x04021C00 RID: 138240
		private float FallCurveEnd = 1f;

		// Token: 0x04021C01 RID: 138241
		private readonly EMatchThreeRoleSpineAnim[] RoleAmbientAnims = new EMatchThreeRoleSpineAnim[]
		{
			EMatchThreeRoleSpineAnim.Idle,
			EMatchThreeRoleSpineAnim.Start
		};

		// Token: 0x04021C02 RID: 138242
		private readonly Random RoleAnimRandom = new Random();

		// Token: 0x04021C03 RID: 138243
		[Nullable(2)]
		private AutoResetUniTaskCompletionSource RoleSkillTcs;

		// Token: 0x04021C04 RID: 138244
		private bool RoleSpineReady;

		// Token: 0x04021C05 RID: 138245
		private bool BoardNavigationInputBlocked;

		// Token: 0x04021C06 RID: 138246
		private int HintThresholdMs;

		// Token: 0x04021C07 RID: 138247
		private double HintRemainMs;

		// Token: 0x04021C08 RID: 138248
		private double HintDeadlineMs;

		// Token: 0x04021C09 RID: 138249
		[Nullable(2)]
		private TimerHandle HintTimer;

		// Token: 0x04021C0A RID: 138250
		[Nullable(2)]
		private MatchThreePieceView HintPieceA;

		// Token: 0x04021C0B RID: 138251
		[Nullable(2)]
		private MatchThreePieceView HintPieceB;

		// Token: 0x04021C0C RID: 138252
		private ValidMove? HintMove;

		// Token: 0x04021C0D RID: 138253
		[Nullable(2)]
		private MatchThreeSkillPointView SmallSkillPoint;

		// Token: 0x04021C0E RID: 138254
		[Nullable(2)]
		private MatchThreeSkillPointView BigSkillPoint;

		// Token: 0x04021C0F RID: 138255
		[Nullable(2)]
		private UiSequencePlayer TurnPopupPlayer;

		// Token: 0x04021C10 RID: 138256
		[Nullable(2)]
		private MatchThreeEnvTipsView EnvTipsView;

		// Token: 0x04021C11 RID: 138257
		[Nullable(2)]
		private MatchThreeSkillTipsView SkillTipsView;

		// Token: 0x04021C12 RID: 138258
		[Nullable(2)]
		private MatchThreeScorePopView ScorePopView;

		// Token: 0x04021C13 RID: 138259
		[Nullable(2)]
		private MatchThreeGradePopView GradePopView;

		// Token: 0x04021C14 RID: 138260
		private bool ScorePopShown;

		// Token: 0x04021C15 RID: 138261
		private GridPosition? PendingNavigationRestoreSource;

		// Token: 0x04021C16 RID: 138262
		private GridPosition? PendingNavigationRestoreTarget;

		// Token: 0x04021C17 RID: 138263
		private GridPosition? PressedPos;

		// Token: 0x04021C18 RID: 138264
		private double PressedAtMs;

		// Token: 0x04021C19 RID: 138265
		private int PointerDownThresholdMs;

		// Token: 0x04021C1A RID: 138266
		private readonly List<UniTask> PendingSpawns = new List<UniTask>();

		// Token: 0x04021C1B RID: 138267
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly MatchThreePieceView[] ClearTargets = new MatchThreePieceView[56];

		// Token: 0x04021C1C RID: 138268
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

		// Token: 0x04021C1D RID: 138269
		private readonly List<UniTask> SpawnPrepares = new List<UniTask>();

		// Token: 0x04021C1E RID: 138270
		private readonly List<UniTask> PendingEnergyTrails = new List<UniTask>();

		// Token: 0x04021C1F RID: 138271
		private readonly List<UniTask> PendingRecycleTrails = new List<UniTask>();

		// Token: 0x04021C20 RID: 138272
		private int TrailGeneration;

		// Token: 0x04021C21 RID: 138273
		private int RecolorGeneration;

		// Token: 0x04021C22 RID: 138274
		private int TrailsInFlight;

		// Token: 0x04021C23 RID: 138275
		[Nullable(2)]
		private UiSequencePlayer AllureSkillPlayer;

		// Token: 0x04021C24 RID: 138276
		[Nullable(2)]
		private UiSequencePlayer ChainSkillPlayer;

		// Token: 0x04021C25 RID: 138277
		[Nullable(2)]
		private AUIBaseActor AllureSkillActor;

		// Token: 0x04021C26 RID: 138278
		[Nullable(2)]
		private AUIBaseActor ChainSkillActor;

		// Token: 0x04021C27 RID: 138279
		[Nullable(2)]
		private UniTaskCompletionSource SmallSkillSequenceGate;

		// Token: 0x04021C28 RID: 138280
		private ESkillCastEffect ActiveSmallSkillEffect;

		// Token: 0x04021C29 RID: 138281
		private bool SmallSkillUpReceived;

		// Token: 0x04021C2A RID: 138282
		private int RoleSkillSequenceVersion;

		// Token: 0x04021C2B RID: 138283
		private int RestartCleanGeneration;

		// Token: 0x04021C2C RID: 138284
		[Nullable(2)]
		private UniTaskCompletionSource RestartCleanAbortSource;

		// Token: 0x04021C2D RID: 138285
		private const int NORMAL_PREWARM_COUNT = 112;

		// Token: 0x04021C2E RID: 138286
		[Nullable(2)]
		private MatchThreePieceView GuideFocusedPiece;

		// Token: 0x0200C6DA RID: 50906
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403C0B7 RID: 245943
			CaptionItem,
			// Token: 0x0403C0B8 RID: 245944
			PnlTile,
			// Token: 0x0403C0B9 RID: 245945
			PnlEffect,
			// Token: 0x0403C0BA RID: 245946
			TileItem,
			// Token: 0x0403C0BB RID: 245947
			MechanicsLayout,
			// Token: 0x0403C0BC RID: 245948
			MechanicsLayoutItem,
			// Token: 0x0403C0BD RID: 245949
			TextRemainTurn,
			// Token: 0x0403C0BE RID: 245950
			PnlPopupTurn,
			// Token: 0x0403C0BF RID: 245951
			TextPopupTurn,
			// Token: 0x0403C0C0 RID: 245952
			SprProgressFill,
			// Token: 0x0403C0C1 RID: 245953
			TextProgress,
			// Token: 0x0403C0C2 RID: 245954
			SprTargetIcon,
			// Token: 0x0403C0C3 RID: 245955
			SpineRole,
			// Token: 0x0403C0C4 RID: 245956
			TextRoleName,
			// Token: 0x0403C0C5 RID: 245957
			BtnRoleInfo,
			// Token: 0x0403C0C6 RID: 245958
			SprSkillBarFill,
			// Token: 0x0403C0C7 RID: 245959
			PnlHor,
			// Token: 0x0403C0C8 RID: 245960
			SmallSkillPoint,
			// Token: 0x0403C0C9 RID: 245961
			BigSkillPoint,
			// Token: 0x0403C0CA RID: 245962
			PnlPop,
			// Token: 0x0403C0CB RID: 245963
			SprProgressBg,
			// Token: 0x0403C0CC RID: 245964
			PnlSkillChain,
			// Token: 0x0403C0CD RID: 245965
			PnlRayMask,
			// Token: 0x0403C0CE RID: 245966
			SpineRoleBack,
			// Token: 0x0403C0CF RID: 245967
			BtnEnvInfo,
			// Token: 0x0403C0D0 RID: 245968
			NiaEnergy,
			// Token: 0x0403C0D1 RID: 245969
			PnlSkillXin,
			// Token: 0x0403C0D2 RID: 245970
			PnlBgNor,
			// Token: 0x0403C0D3 RID: 245971
			PnlBgEndless,
			// Token: 0x0403C0D4 RID: 245972
			TxtSkillEnergyNum,
			// Token: 0x0403C0D5 RID: 245973
			PnlRolePivotWaist,
			// Token: 0x0403C0D6 RID: 245974
			PnlRolePivotSuoming,
			// Token: 0x0403C0D7 RID: 245975
			TxtRecord,
			// Token: 0x0403C0D8 RID: 245976
			PnlRolePivotXin
		}
	}
}
