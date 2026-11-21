using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A10 RID: 23056
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolBehaviorExecutePanel : SolarSchoolChildViewBase, IPanelTickInterface
	{
		// Token: 0x06038C52 RID: 232530 RVA: 0x00FE415A File Offset: 0x00FE235A
		protected override SolarSchoolRootUiParams CreateRootUiParams()
		{
			return new SolarSchoolRootUiParams
			{
				Caption = new SolarSchoolCaptionParams
				{
					TipCostVisible = true
				}
			};
		}

		// Token: 0x06038C53 RID: 232531 RVA: 0x00FE4174 File Offset: 0x00FE2374
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickFinish));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnFastForwardChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C54 RID: 232532 RVA: 0x00FE436C File Offset: 0x00FE256C
		protected override void OnStart()
		{
			UUIItem rootItem = base.GetRootItem();
			object obj;
			if (rootItem == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = rootItem.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiBlur.StaticClass()) : null);
			}
			this.UiBlur = (obj as TsUiBlur);
			if (this.UiBlur != null)
			{
				this.UiBlur.ApplyItem = base.GetRootItem();
			}
			this.SkillLayout = new GenericLayout<SolarSchoolSkillItem, SolarSchoolBehaviorSkill>(base.GetVerticalLayout(0), () => new SolarSchoolSkillItem(), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
			this.ApplyBehaviorData();
		}

		// Token: 0x06038C55 RID: 232533 RVA: 0x00FE440F File Offset: 0x00FE260F
		public override void OnReopen()
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur != null)
			{
				uiBlur.SetEnableUiBlur(true);
			}
			this.ApplyBehaviorData();
			this.ApplyBehaviorPresentation();
			this.PlaySequence("Switch");
		}

		// Token: 0x06038C56 RID: 232534 RVA: 0x00FE443C File Offset: 0x00FE263C
		private void ApplyBehaviorData()
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			GenericLayout<SolarSchoolSkillItem, SolarSchoolBehaviorSkill> skillLayout = this.SkillLayout;
			if (skillLayout != null)
			{
				UUIItem rootUiItem = skillLayout.GetRootUiItem();
				if (rootUiItem != null)
				{
					rootUiItem.SetUIActive(false);
				}
			}
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			this.SetSpineVisible(false);
			this.SequencePlayer.StopSequenceByKey("Great_Start", false, false);
			this.SequencePlayer.StopSequenceByKey("Bad_Start", false, false);
			this.Finished = false;
			base.ClearPresentFinished();
			this.Stage = SolarSchoolBehaviorExecutePanel.EStage.Loading;
			this.StageElapsedMs = 0f;
			this.FastForwardElapsedMs = 0f;
			this.PresentationVersion++;
			SolarSchoolBehaviorExecuteParam solarSchoolBehaviorExecuteParam = this.OpenParam as SolarSchoolBehaviorExecuteParam;
			if (solarSchoolBehaviorExecuteParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 执行行为界面打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolBehavior? behavior = this.GetBehavior();
			SolarSchoolConfig instance = SolarSchoolConfig.Instance;
			this.IdleDurationMs = instance.GetParamInt(activityId, "BehaviorIdleDuration", 2000);
			this.IdleLockMs = instance.GetParamInt(activityId, "BehaviorIdleLockTime", 500);
			this.ResultLockMs = instance.GetParamInt(activityId, "BehaviorResultLockTime", 1000);
			this.FastForwardNoResultTimeMs = instance.GetParamInt(activityId, "BehaviorFastForwardNoResultTime", 700);
			this.FastForwardResultTimeMs = instance.GetParamInt(activityId, "BehaviorFastForwardResultTime", 1000);
			this.NeedResultShow = (behavior == null || behavior.GetValueOrDefault().NeedSucShow);
			SolarSchoolGamePlayModel instance2 = SolarSchoolGamePlayModel.Instance;
			EToggleState state = instance2.GetBehaviorFastForwardEnabled() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(10);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			this.ApplyPlaybackRate(instance2.GetBehaviorPlaybackRate());
			this.SetBehaviorInfo(behavior);
			this.ApplySkillList(behavior, this.PresentationVersion);
			if (!this.NeedResultShow)
			{
				Action onSettle = solarSchoolBehaviorExecuteParam.OnSettle;
				if (onSettle != null)
				{
					onSettle();
				}
			}
			this.PlayIdleSpineAsync(behavior, this.PresentationVersion).Forget();
		}

		// Token: 0x06038C57 RID: 232535 RVA: 0x00FE465C File Offset: 0x00FE285C
		private void ApplySkillList(SolarSchoolBehavior? behavior, int presentationVersion)
		{
			if (this.SkillLayout == null || behavior == null)
			{
				return;
			}
			List<SolarSchoolBehaviorSkill> skills = SolarSchoolGamePlayModel.Instance.GetBehaviorSkills(behavior.Value.BehaviorId);
			this.SkillLayout.RefreshByData(skills, delegate
			{
				this.PlaySkillListEnterAnimation(skills.Count, presentationVersion);
			}, false);
		}

		// Token: 0x06038C58 RID: 232536 RVA: 0x00FE46CC File Offset: 0x00FE28CC
		private void PlaySkillListEnterAnimation(int skillCount, int presentationVersion)
		{
			if (presentationVersion != this.PresentationVersion || this.SkillLayout == null)
			{
				return;
			}
			UUIItem rootUiItem = this.SkillLayout.GetRootUiItem();
			if (rootUiItem != null)
			{
				rootUiItem.SetUIActive(skillCount > 0);
			}
			if (skillCount <= 0)
			{
				return;
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(0);
			object obj;
			if (verticalLayout == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = verticalLayout.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
			}
			UUIInturnAnimController uuiinturnAnimController = obj as UUIInturnAnimController;
			if (uuiinturnAnimController == null)
			{
				return;
			}
			uuiinturnAnimController.Play("", -1, false);
		}

		// Token: 0x06038C59 RID: 232537 RVA: 0x00FE474C File Offset: 0x00FE294C
		private SolarSchoolBehavior? GetBehavior()
		{
			SolarSchoolBehaviorExecuteParam solarSchoolBehaviorExecuteParam = this.OpenParam as SolarSchoolBehaviorExecuteParam;
			if (solarSchoolBehaviorExecuteParam == null)
			{
				return null;
			}
			return SolarSchoolConfig.Instance.GetBehaviorRowByLevel(SolarSchoolGamePlayModel.Instance.ActivityId, solarSchoolBehaviorExecuteParam.BehaviorId, solarSchoolBehaviorExecuteParam.Level);
		}

		// Token: 0x06038C5A RID: 232538 RVA: 0x00FE4792 File Offset: 0x00FE2992
		protected override void OnBeforeShow()
		{
			UiManager.Instance.AddTickView(this);
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur != null)
			{
				uiBlur.SetEnableUiBlur(true);
			}
			this.ApplyBehaviorPresentation();
		}

		// Token: 0x06038C5B RID: 232539 RVA: 0x00FE47B7 File Offset: 0x00FE29B7
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			this.ApplyPlaybackRate(this.PlaybackRate);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C5C RID: 232540 RVA: 0x00FE47CA File Offset: 0x00FE29CA
		protected override UniTask OnPlayingShowSequenceAsync()
		{
			this.ApplyPlaybackRate(this.PlaybackRate);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C5D RID: 232541 RVA: 0x00FE47DD File Offset: 0x00FE29DD
		protected override UniTask OnPlayingHideSequenceAsync()
		{
			this.ApplyPlaybackRate(this.PlaybackRate);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C5E RID: 232542 RVA: 0x00FE47F0 File Offset: 0x00FE29F0
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			this.ApplyPlaybackRate(this.PlaybackRate);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C5F RID: 232543 RVA: 0x00FE4804 File Offset: 0x00FE2A04
		private void ApplyBehaviorPresentation()
		{
			SolarSchoolRootViewModel solarSchoolViewModel = base.SolarSchoolViewModel;
			Action refreshDate = solarSchoolViewModel.RefreshDate;
			if (refreshDate != null)
			{
				refreshDate();
			}
			SolarSchoolBehavior? solarSchoolBehavior;
			int num = (this.GetBehavior() != null) ? solarSchoolBehavior.GetValueOrDefault().Location : 0;
			if (num != 0 && SolarSchoolConfig.Instance.GetLocation(num) != null)
			{
				solarSchoolViewModel.SetBackgroundByLocationId(num, "Bg_Switch01");
			}
			solarSchoolViewModel.RefreshLocationRole();
		}

		// Token: 0x06038C60 RID: 232544 RVA: 0x00FE4877 File Offset: 0x00FE2A77
		protected override void OnAfterHide()
		{
			UiManager.Instance.RemoveTickView(this);
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(false);
		}

		// Token: 0x06038C61 RID: 232545 RVA: 0x00FE4898 File Offset: 0x00FE2A98
		private UniTask PlayIdleSpineAsync(SolarSchoolBehavior? behavior, int presentationVersion)
		{
			SolarSchoolBehaviorExecutePanel.<PlayIdleSpineAsync>d__33 <PlayIdleSpineAsync>d__;
			<PlayIdleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayIdleSpineAsync>d__.<>4__this = this;
			<PlayIdleSpineAsync>d__.behavior = behavior;
			<PlayIdleSpineAsync>d__.presentationVersion = presentationVersion;
			<PlayIdleSpineAsync>d__.<>1__state = -1;
			<PlayIdleSpineAsync>d__.<>t__builder.Start<SolarSchoolBehaviorExecutePanel.<PlayIdleSpineAsync>d__33>(ref <PlayIdleSpineAsync>d__);
			return <PlayIdleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C62 RID: 232546 RVA: 0x00FE48EC File Offset: 0x00FE2AEC
		private void SetSpineVisible(bool visible)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			spine.SetActive(visible, false);
			AActor owner = spine.GetOwner();
			UUIItem uuiitem = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06038C63 RID: 232547 RVA: 0x00FE4944 File Offset: 0x00FE2B44
		private string GetSpineBasePath(SolarSchoolBehavior? behavior)
		{
			if (behavior == null)
			{
				return string.Empty;
			}
			return ((SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? behavior.Value.SpineResFemale : behavior.Value.SpineResMale) ?? string.Empty;
		}

		// Token: 0x06038C64 RID: 232548 RVA: 0x00FE4998 File Offset: 0x00FE2B98
		private void EnterIdleStage()
		{
			this.Stage = SolarSchoolBehaviorExecutePanel.EStage.Idle;
			this.StageElapsedMs = 0f;
			this.FastForwardElapsedMs = 0f;
		}

		// Token: 0x06038C65 RID: 232549 RVA: 0x00FE49B8 File Offset: 0x00FE2BB8
		public void Tick(float delta)
		{
			if (this.Finished)
			{
				return;
			}
			this.StageElapsedMs += delta * this.PlaybackRate;
			if (SolarSchoolGamePlayModel.Instance.GetBehaviorFastForwardEnabled())
			{
				this.FastForwardElapsedMs += delta * this.PlaybackRate;
				this.AutoAdvance();
				return;
			}
			if (this.Stage == SolarSchoolBehaviorExecutePanel.EStage.Idle && this.NeedResultShow && this.StageElapsedMs >= (float)this.IdleDurationMs)
			{
				this.EnterResultStage();
			}
		}

		// Token: 0x06038C66 RID: 232550 RVA: 0x00FE4A31 File Offset: 0x00FE2C31
		public void AfterTick(float delta)
		{
		}

		// Token: 0x06038C67 RID: 232551 RVA: 0x00FE4A34 File Offset: 0x00FE2C34
		private void EnterResultStage()
		{
			this.Stage = SolarSchoolBehaviorExecutePanel.EStage.Result;
			this.StageElapsedMs = 0f;
			this.FastForwardElapsedMs = 0f;
			SolarSchoolBehaviorExecuteParam solarSchoolBehaviorExecuteParam = this.OpenParam as SolarSchoolBehaviorExecuteParam;
			bool flag = solarSchoolBehaviorExecuteParam != null && solarSchoolBehaviorExecuteParam.Success;
			if (solarSchoolBehaviorExecuteParam != null)
			{
				Action onSettle = solarSchoolBehaviorExecuteParam.OnSettle;
				if (onSettle != null)
				{
					onSettle();
				}
			}
			UUIItem item = base.GetItem(flag ? 7 : 8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.PlaySequence(flag ? "Great_Start" : "Bad_Start");
			this.PlayResultSpine(flag);
		}

		// Token: 0x06038C68 RID: 232552 RVA: 0x00FE4AC4 File Offset: 0x00FE2CC4
		private unsafe void PlayResultSpine(bool success)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine == null || !spine.IsValid() || spine.SkeletonData == null)
			{
				return;
			}
			string text = success ? "suc_in" : "fl_in";
			string animationName = success ? "suc_idle" : "fl_idle";
			if (!spine.HasAnimation(text))
			{
				SolarSchoolBehaviorExecuteParam solarSchoolBehaviorExecuteParam = this.OpenParam as SolarSchoolBehaviorExecuteParam;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为配了 NeedSucShow 但 spine 资源缺成败动画";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", (solarSchoolBehaviorExecuteParam != null) ? new int?(solarSchoolBehaviorExecuteParam.BehaviorId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", (solarSchoolBehaviorExecuteParam != null) ? new int?(solarSchoolBehaviorExecuteParam.Level) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("spine", this.GetSpineBasePath(this.GetBehavior()));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("success", success);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("animation", text);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				return;
			}
			SpineAnimationQueue spineAnimationQueue = new SpineAnimationQueue(spine);
			spineAnimationQueue.PushAnimation(0, text, false);
			spineAnimationQueue.PushAnimation(0, animationName, true);
			spine.SetTimeScale(this.PlaybackRate);
		}

		// Token: 0x06038C69 RID: 232553 RVA: 0x00FE4C38 File Offset: 0x00FE2E38
		private void OnFastForwardChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked && state != EToggleState.ETT_UnChecked)
			{
				return;
			}
			bool behaviorFastForwardEnabled = state == EToggleState.ETT_Checked;
			this.FastForwardElapsedMs = 0f;
			this.ApplyPlaybackRate(SolarSchoolGamePlayModel.Instance.SetBehaviorFastForwardEnabled(behaviorFastForwardEnabled));
		}

		// Token: 0x06038C6A RID: 232554 RVA: 0x00FE4C70 File Offset: 0x00FE2E70
		private void AutoAdvance()
		{
			if (this.Stage != SolarSchoolBehaviorExecutePanel.EStage.Idle)
			{
				if (this.Stage == SolarSchoolBehaviorExecutePanel.EStage.Result && this.FastForwardElapsedMs >= (float)this.FastForwardResultTimeMs)
				{
					this.FinishBehaviorPresentation();
				}
				return;
			}
			if (this.NeedResultShow)
			{
				if (this.StageElapsedMs >= (float)this.IdleDurationMs)
				{
					this.EnterResultStage();
				}
				return;
			}
			if (this.FastForwardElapsedMs >= (float)this.FastForwardNoResultTimeMs)
			{
				this.FinishBehaviorPresentation();
			}
		}

		// Token: 0x06038C6B RID: 232555 RVA: 0x00FE4CD8 File Offset: 0x00FE2ED8
		private void ApplyPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine != null)
			{
				spine.SetTimeScale(this.PlaybackRate);
			}
			string currentSequence = this.SequencePlayer.GetCurrentSequence();
			if (currentSequence == null)
			{
				return;
			}
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey(currentSequence);
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(this.PlaybackRate);
		}

		// Token: 0x06038C6C RID: 232556 RVA: 0x00FE4D3F File Offset: 0x00FE2F3F
		private void PlaySequence(string sequenceName)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, new float?(this.PlaybackRate));
		}

		// Token: 0x06038C6D RID: 232557 RVA: 0x00FE4D5C File Offset: 0x00FE2F5C
		private void SetBehaviorInfo(SolarSchoolBehavior? behavior)
		{
			if (behavior == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), behavior.Value.ExcuteDescText, Array.Empty<object>());
		}

		// Token: 0x06038C6E RID: 232558 RVA: 0x00FE4D98 File Offset: 0x00FE2F98
		protected override void OnBeforeDestroy()
		{
			UiManager.Instance.RemoveTickView(this);
			GenericLayout<SolarSchoolSkillItem, SolarSchoolBehaviorSkill> skillLayout = this.SkillLayout;
			if (skillLayout != null)
			{
				skillLayout.ClearChildren();
			}
			this.SkillLayout = null;
			this.SetFinished();
		}

		// Token: 0x06038C6F RID: 232559 RVA: 0x00FE4DC4 File Offset: 0x00FE2FC4
		private void SetFinished()
		{
			if (this.Finished)
			{
				return;
			}
			this.Finished = true;
			this.PresentationVersion++;
			GenericLayout<SolarSchoolSkillItem, SolarSchoolBehaviorSkill> skillLayout = this.SkillLayout;
			if (skillLayout != null)
			{
				UUIItem rootUiItem = skillLayout.GetRootUiItem();
				if (rootUiItem != null)
				{
					rootUiItem.SetUIActive(false);
				}
			}
			SolarSchoolBehaviorExecuteParam solarSchoolBehaviorExecuteParam = this.OpenParam as SolarSchoolBehaviorExecuteParam;
			Action action = (solarSchoolBehaviorExecuteParam != null) ? solarSchoolBehaviorExecuteParam.OnFinish : null;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06038C70 RID: 232560 RVA: 0x00FE4E30 File Offset: 0x00FE3030
		private void OnClickFinish()
		{
			if (this.Finished)
			{
				return;
			}
			switch (this.Stage)
			{
			case SolarSchoolBehaviorExecutePanel.EStage.Loading:
				return;
			case SolarSchoolBehaviorExecutePanel.EStage.Idle:
				if (this.StageElapsedMs < (float)this.IdleLockMs)
				{
					return;
				}
				if (this.NeedResultShow)
				{
					this.EnterResultStage();
					return;
				}
				break;
			case SolarSchoolBehaviorExecutePanel.EStage.Result:
				if (this.StageElapsedMs < (float)this.ResultLockMs)
				{
					return;
				}
				break;
			}
			this.FinishBehaviorPresentation();
		}

		// Token: 0x06038C71 RID: 232561 RVA: 0x00FE4E97 File Offset: 0x00FE3097
		private void FinishBehaviorPresentation()
		{
			this.SetFinished();
			base.MarkPresentFinished();
		}

		// Token: 0x0401DE29 RID: 122409
		[Nullable(2)]
		private TsUiBlur UiBlur;

		// Token: 0x0401DE2A RID: 122410
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolSkillItem, SolarSchoolBehaviorSkill> SkillLayout;

		// Token: 0x0401DE2B RID: 122411
		private bool Finished;

		// Token: 0x0401DE2C RID: 122412
		private SolarSchoolBehaviorExecutePanel.EStage Stage;

		// Token: 0x0401DE2D RID: 122413
		private float StageElapsedMs;

		// Token: 0x0401DE2E RID: 122414
		private float FastForwardElapsedMs;

		// Token: 0x0401DE2F RID: 122415
		private bool NeedResultShow;

		// Token: 0x0401DE30 RID: 122416
		private int IdleDurationMs;

		// Token: 0x0401DE31 RID: 122417
		private int IdleLockMs;

		// Token: 0x0401DE32 RID: 122418
		private int ResultLockMs;

		// Token: 0x0401DE33 RID: 122419
		private int FastForwardNoResultTimeMs;

		// Token: 0x0401DE34 RID: 122420
		private int FastForwardResultTimeMs;

		// Token: 0x0401DE35 RID: 122421
		private int PresentationVersion;

		// Token: 0x0401DE36 RID: 122422
		private float PlaybackRate = 1f;

		// Token: 0x0200B5C4 RID: 46532
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038361 RID: 230241
			public const int PnlSkillList = 0;

			// Token: 0x04038362 RID: 230242
			public const int SkillItem = 1;

			// Token: 0x04038363 RID: 230243
			public const int TexPlace = 2;

			// Token: 0x04038364 RID: 230244
			public const int TexRole = 3;

			// Token: 0x04038365 RID: 230245
			public const int Spine = 4;

			// Token: 0x04038366 RID: 230246
			public const int PnlTxt = 5;

			// Token: 0x04038367 RID: 230247
			public const int TxtTalk = 6;

			// Token: 0x04038368 RID: 230248
			public const int PnlSuccess = 7;

			// Token: 0x04038369 RID: 230249
			public const int PnlFail = 8;

			// Token: 0x0403836A RID: 230250
			public const int BtnMask = 9;

			// Token: 0x0403836B RID: 230251
			public const int FastForwardToggle = 10;
		}

		// Token: 0x0200B5C5 RID: 46533
		[Nullable(0)]
		private static class ESpineAnim
		{
			// Token: 0x0403836C RID: 230252
			public const string Idle = "idle";

			// Token: 0x0403836D RID: 230253
			public const string SuccessIn = "suc_in";

			// Token: 0x0403836E RID: 230254
			public const string SuccessIdle = "suc_idle";

			// Token: 0x0403836F RID: 230255
			public const string FailIn = "fl_in";

			// Token: 0x04038370 RID: 230256
			public const string FailIdle = "fl_idle";
		}

		// Token: 0x0200B5C6 RID: 46534
		[Nullable(0)]
		private static class ESequence
		{
			// Token: 0x04038371 RID: 230257
			public const string Success = "Great_Start";

			// Token: 0x04038372 RID: 230258
			public const string Fail = "Bad_Start";

			// Token: 0x04038373 RID: 230259
			public const string Switch = "Switch";
		}

		// Token: 0x0200B5C7 RID: 46535
		[NullableContext(0)]
		private enum EStage
		{
			// Token: 0x04038375 RID: 230261
			Loading,
			// Token: 0x04038376 RID: 230262
			Idle,
			// Token: 0x04038377 RID: 230263
			Result
		}
	}
}
