using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434A RID: 17226
	public class GuqinSubController : MusicalInstrumentSubController
	{
		// Token: 0x0602B806 RID: 178182 RVA: 0x00C394E7 File Offset: 0x00C376E7
		public override EInstrumentType GetType()
		{
			return EInstrumentType.ChineseZither;
		}

		// Token: 0x0602B807 RID: 178183 RVA: 0x00C394EC File Offset: 0x00C376EC
		[NullableContext(2)]
		private string GetAbortReason()
		{
			GameModeModel instance = GameModeModel.Instance;
			if (!instance.WorldDone)
			{
				return "世界未就绪";
			}
			if (instance.IsTeleport)
			{
				return "传送中";
			}
			if (instance.ChangeModeState)
			{
				return "切换世界模式中";
			}
			if (this.IsEnterCancelled)
			{
				return "进入已被取消";
			}
			if (this.IsEntityChanged())
			{
				return "弹琴实体已被换下";
			}
			if (this.IsSkillStarted && !this.IsSkillPlaying())
			{
				return "弹琴技能已被打断";
			}
			return null;
		}

		// Token: 0x0602B808 RID: 178184 RVA: 0x00C3955C File Offset: 0x00C3775C
		private bool CheckAborted()
		{
			string abortReason = this.GetAbortReason();
			if (abortReason == null)
			{
				return false;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:进入中止";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", abortReason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x0602B809 RID: 178185 RVA: 0x00C395A0 File Offset: 0x00C377A0
		public override UniTask<bool> OnEnter([Nullable(1)] MusicalInstrumentEnterParam param)
		{
			GuqinSubController.<OnEnter>d__17 <OnEnter>d__;
			<OnEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnEnter>d__.<>4__this = this;
			<OnEnter>d__.<>1__state = -1;
			<OnEnter>d__.<>t__builder.Start<GuqinSubController.<OnEnter>d__17>(ref <OnEnter>d__);
			return <OnEnter>d__.<>t__builder.Task;
		}

		// Token: 0x0602B80A RID: 178186 RVA: 0x00C395E3 File Offset: 0x00C377E3
		public override void CancelEnter()
		{
			this.IsEnterCancelled = true;
			this.EndSkill();
			this.CancelWaitMontage();
		}

		// Token: 0x0602B80B RID: 178187 RVA: 0x00C395F8 File Offset: 0x00C377F8
		private bool CheckRestrictedWithTip()
		{
			int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
			if (restrictConditionGroupId <= 0)
			{
				return false;
			}
			if (!LevelGeneralController.Instance.CheckCondition(restrictConditionGroupId.ToString(), null, false, Array.Empty<object>()))
			{
				return false;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:进入-限制条件已满足,取消进入";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConditionGroupId", restrictConditionGroupId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
			if (conditionGroupHintText != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x0602B80C RID: 178188 RVA: 0x00C39694 File Offset: 0x00C37894
		private UniTask EnsureBattleViewReset()
		{
			GuqinSubController.<EnsureBattleViewReset>d__20 <EnsureBattleViewReset>d__;
			<EnsureBattleViewReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureBattleViewReset>d__.<>1__state = -1;
			<EnsureBattleViewReset>d__.<>t__builder.Start<GuqinSubController.<EnsureBattleViewReset>d__20>(ref <EnsureBattleViewReset>d__);
			return <EnsureBattleViewReset>d__.<>t__builder.Task;
		}

		// Token: 0x0602B80D RID: 178189 RVA: 0x00C396D0 File Offset: 0x00C378D0
		private UniTask<bool> PrepareNormalEnter()
		{
			GuqinSubController.<PrepareNormalEnter>d__21 <PrepareNormalEnter>d__;
			<PrepareNormalEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareNormalEnter>d__.<>4__this = this;
			<PrepareNormalEnter>d__.<>1__state = -1;
			<PrepareNormalEnter>d__.<>t__builder.Start<GuqinSubController.<PrepareNormalEnter>d__21>(ref <PrepareNormalEnter>d__);
			return <PrepareNormalEnter>d__.<>t__builder.Task;
		}

		// Token: 0x0602B80E RID: 178190 RVA: 0x00C39714 File Offset: 0x00C37914
		private bool PrepareQteEnter()
		{
			this.HandleBattleViewVisible(false);
			string uiCameraId = ConfigGuQinActivityParamById.GetConfig(111400001, true).Value.UiCameraId;
			this.CameraHandle = UiCameraModel.Instance.PushCameraHandleByHandleName(uiCameraId, false, true, "1001", false, null);
			if (!this.CaptureCurrentEntity())
			{
				return false;
			}
			this.PlayQtePreMontage();
			return true;
		}

		// Token: 0x0602B80F RID: 178191 RVA: 0x00C39770 File Offset: 0x00C37970
		private UniTask<bool> EnterInternal([Nullable(2)] MusicalInstrumentQteData qteData)
		{
			GuqinSubController.<EnterInternal>d__23 <EnterInternal>d__;
			<EnterInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInternal>d__.<>4__this = this;
			<EnterInternal>d__.qteData = qteData;
			<EnterInternal>d__.<>1__state = -1;
			<EnterInternal>d__.<>t__builder.Start<GuqinSubController.<EnterInternal>d__23>(ref <EnterInternal>d__);
			return <EnterInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0602B810 RID: 178192 RVA: 0x00C397BC File Offset: 0x00C379BC
		[NullableContext(2)]
		private void RollbackEnter(MusicalInstrumentQteData qteData)
		{
			this.RemoveExitEvents();
			if (this.IsServerEntered)
			{
				this.RequestPlayState(ZitherOpState.OpExit).Forget<bool>();
				this.IsServerEntered = false;
			}
			if (EventSystem.Instance.Has<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd)))
			{
				EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
			}
			this.EndSkill();
			this.CancelWaitMontage();
			this.DestroyView();
			if (qteData == null)
			{
				if (this.ConditionPassCallback != null)
				{
					int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
					LevelConditionRegistry.Instance.UnRegisterConditionGroup(restrictConditionGroupId, this.ConditionPassCallback);
				}
			}
			else if (this.CameraHandle != null)
			{
				this.PlayQteEndSection();
				UiCameraModel.Instance.PopCameraHandle(this.CameraHandle, null);
				this.CameraHandle = null;
			}
			this.HandleBattleViewVisible(true);
			LevelLoadingController.Instance.CloseLoading((qteData == null) ? ELoadingReason.MusicalInstrument : ELoadingReason.Common, "GuqinSubController.Enter", null, new float?(0.5f));
			this.UnlockInput();
		}

		// Token: 0x0602B811 RID: 178193 RVA: 0x00C398C3 File Offset: 0x00C37AC3
		private void RefreshInputTag(EInputControllerMainType last, EInputControllerMainType now)
		{
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0602B812 RID: 178194 RVA: 0x00C398CF File Offset: 0x00C37ACF
		private void LockInput()
		{
			InputManager.Instance.RegisterLockShortcutKeyReason("MusicalInstrument.ChineseZither", null);
			this.SetInputRestricted(true);
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.RefreshInputTag));
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0602B813 RID: 178195 RVA: 0x00C3990E File Offset: 0x00C37B0E
		private void UnlockInput()
		{
			InputManager.Instance.RemoveLockShortcutKeyReason("MusicalInstrument.ChineseZither");
			this.SetInputRestricted(false);
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.RefreshInputTag));
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0602B814 RID: 178196 RVA: 0x00C3994C File Offset: 0x00C37B4C
		private void SetInputRestricted(bool restricted)
		{
			MusicalInstrumentSubModel subModel = base.GetSubModel();
			if (subModel == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到SubModel", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			subModel.IsInputRestricted = restricted;
		}

		// Token: 0x0602B815 RID: 178197 RVA: 0x00C3998C File Offset: 0x00C37B8C
		private void AddExitEvents()
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChanged));
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add(EEventName.ChangeMode, new Action(this.OnGameModeChanged));
		}

		// Token: 0x0602B816 RID: 178198 RVA: 0x00C39A0C File Offset: 0x00C37C0C
		private void RemoveExitEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChanged));
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Remove<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove(EEventName.ChangeMode, new Action(this.OnGameModeChanged));
		}

		// Token: 0x0602B817 RID: 178199 RVA: 0x00C39A8C File Offset: 0x00C37C8C
		private bool CaptureCurrentEntity()
		{
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (this.CurrentEntity == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:进入-取不到弹琴实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0602B818 RID: 178200 RVA: 0x00C39AD3 File Offset: 0x00C37CD3
		private bool IsEntityOnStage()
		{
			return this.CurrentEntity != null && this.CurrentEntity == SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x0602B819 RID: 178201 RVA: 0x00C39AF1 File Offset: 0x00C37CF1
		private bool IsEntityChanged()
		{
			return this.CurrentEntity != null && this.CurrentEntity != SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x0602B81A RID: 178202 RVA: 0x00C39B14 File Offset: 0x00C37D14
		private void OnFormationChanged()
		{
			if (!this.IsEntityChanged())
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:弹琴实体已被换下,触发退出";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Old";
			EntityHandle currentEntity = this.CurrentEntity;
			ptr = new ValueTuple<string, object>(item, (currentEntity != null) ? new int?(currentEntity.Id) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "New";
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			ptr2 = new ValueTuple<string, object>(item2, (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B81B RID: 178203 RVA: 0x00C39BEC File Offset: 0x00C37DEC
		private void OnGameModeChanged()
		{
			global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:世界模式已切换,触发退出", default(ReadOnlySpan<ValueTuple<string, object>>));
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B81C RID: 178204 RVA: 0x00C39C38 File Offset: 0x00C37E38
		private void OnRestrictConditionCallback([Nullable(new byte[]
		{
			2,
			1
		})] object[] parameters)
		{
			int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
			if (restrictConditionGroupId > 0)
			{
				string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
				if (conditionGroupHintText != null)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
				}
			}
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B81D RID: 178205 RVA: 0x00C39CA3 File Offset: 0x00C37EA3
		private void OnTeleportStart(bool loading)
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B81E RID: 178206 RVA: 0x00C39CC8 File Offset: 0x00C37EC8
		private void OnRoleDead(int charId)
		{
			EntityHandle currentEntity = this.CurrentEntity;
			int? num = (currentEntity != null) ? new int?(currentEntity.Id) : null;
			if (!(charId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.CurrentEntity = null;
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B81F RID: 178207 RVA: 0x00C39D34 File Offset: 0x00C37F34
		private void OnSkillEnd(int entityId, int skillId)
		{
			EntityHandle currentEntity = this.CurrentEntity;
			int? num = (currentEntity != null) ? new int?(currentEntity.Id) : null;
			if (!(entityId == num.GetValueOrDefault() & num != null) || skillId != 800030)
			{
				return;
			}
			this.IsSkillEnded = true;
			this.CancelWaitMontage();
		}

		// Token: 0x0602B820 RID: 178208 RVA: 0x00C39D8C File Offset: 0x00C37F8C
		private UniTask<bool> CreateView()
		{
			GuqinSubController.<CreateView>d__40 <CreateView>d__;
			<CreateView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CreateView>d__.<>4__this = this;
			<CreateView>d__.<>1__state = -1;
			<CreateView>d__.<>t__builder.Start<GuqinSubController.<CreateView>d__40>(ref <CreateView>d__);
			return <CreateView>d__.<>t__builder.Task;
		}

		// Token: 0x0602B821 RID: 178209 RVA: 0x00C39DCF File Offset: 0x00C37FCF
		private void DestroyView()
		{
			if (this.ViewId != null)
			{
				UiManager.Instance.CloseViewById(this.ViewId.Value, null);
				this.ViewId = null;
			}
		}

		// Token: 0x0602B822 RID: 178210 RVA: 0x00C39E00 File Offset: 0x00C38000
		private void HandleBattleViewVisible(bool visible)
		{
			if (visible)
			{
				BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
				if (childViewData == null)
				{
					return;
				}
				childViewData.ShowBattleView(EBattleUiVisibleReason.UiControl, 0);
				return;
			}
			else
			{
				BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
				if (childViewData2 == null)
				{
					return;
				}
				childViewData2.HideBattleView(EBattleUiVisibleReason.UiControl, new List<EBattleUiChild>
				{
					EBattleUiChild.GuideTipsView
				}, 0);
				return;
			}
		}

		// Token: 0x0602B823 RID: 178211 RVA: 0x00C39E4C File Offset: 0x00C3804C
		public override UniTask<bool> OnExit([Nullable(1)] MusicalInstrumentExitParam param)
		{
			GuqinSubController.<OnExit>d__43 <OnExit>d__;
			<OnExit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnExit>d__.<>4__this = this;
			<OnExit>d__.<>1__state = -1;
			<OnExit>d__.<>t__builder.Start<GuqinSubController.<OnExit>d__43>(ref <OnExit>d__);
			return <OnExit>d__.<>t__builder.Task;
		}

		// Token: 0x0602B824 RID: 178212 RVA: 0x00C39E90 File Offset: 0x00C38090
		private UniTask<bool> UseSkill()
		{
			GuqinSubController.<UseSkill>d__44 <UseSkill>d__;
			<UseSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UseSkill>d__.<>1__state = -1;
			<UseSkill>d__.<>t__builder.Start<GuqinSubController.<UseSkill>d__44>(ref <UseSkill>d__);
			return <UseSkill>d__.<>t__builder.Task;
		}

		// Token: 0x0602B825 RID: 178213 RVA: 0x00C39ECC File Offset: 0x00C380CC
		private bool IsSkillPlaying()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return false;
			}
			global::Skill currentSkill = obj2.CurrentSkill;
			return ((currentSkill != null) ? new int?(currentSkill.SkillId) : null).GetValueOrDefault() == 800030;
		}

		// Token: 0x0602B826 RID: 178214 RVA: 0x00C39F2C File Offset: 0x00C3812C
		private void EndSkill()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			object obj2 = obj;
			bool flag;
			if (obj2 == null)
			{
				flag = true;
			}
			else
			{
				global::Skill currentSkill = obj2.CurrentSkill;
				flag = (((currentSkill != null) ? new int?(currentSkill.SkillId) : null).GetValueOrDefault() != 800030);
			}
			if (flag)
			{
				return;
			}
			EntityHandle currentEntity2 = this.CurrentEntity;
			BaseTagComponent baseTagComponent;
			if (currentEntity2 == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity2 = currentEntity2.Entity;
				baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到Tag组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int tagIdByName = GameplayTagUtils.GetTagIdByName("系统.活动.弹琴玩法.结束弹琴");
			if (baseTagComponent2.HasTag(tagIdByName))
			{
				return;
			}
			baseTagComponent2.AddTag(new int?(tagIdByName));
		}

		// Token: 0x0602B827 RID: 178215 RVA: 0x00C39FF4 File Offset: 0x00C381F4
		private UniTask WaitQteAudioFinish()
		{
			GuqinSubController.<WaitQteAudioFinish>d__47 <WaitQteAudioFinish>d__;
			<WaitQteAudioFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitQteAudioFinish>d__.<>4__this = this;
			<WaitQteAudioFinish>d__.<>1__state = -1;
			<WaitQteAudioFinish>d__.<>t__builder.Start<GuqinSubController.<WaitQteAudioFinish>d__47>(ref <WaitQteAudioFinish>d__);
			return <WaitQteAudioFinish>d__.<>t__builder.Task;
		}

		// Token: 0x0602B828 RID: 178216 RVA: 0x00C3A037 File Offset: 0x00C38237
		public override void OnQteCompleted()
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x0602B829 RID: 178217 RVA: 0x00C3A05C File Offset: 0x00C3825C
		private void PlayQtePreMontage()
		{
			GuQinActivityParam? config = ConfigGuQinActivityParamById.GetConfig(111400001, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "古琴玩法:获取不到活动配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", 111400001);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			GuQinActivityParam valueOrDefault = config.GetValueOrDefault();
			string montagePath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? valueOrDefault.MaleMontagePaths(0) : valueOrDefault.FemaleMontagePaths(0);
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.PlayMontage(new IPlayMontageParam
			{
				MontagePath = montagePath,
				InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.START_SECTION)
			});
		}

		// Token: 0x0602B82A RID: 178218 RVA: 0x00C3A150 File Offset: 0x00C38350
		private UniTask WaitMontageSection(FName sectionName)
		{
			GuqinSubController.<WaitMontageSection>d__50 <WaitMontageSection>d__;
			<WaitMontageSection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitMontageSection>d__.<>4__this = this;
			<WaitMontageSection>d__.sectionName = sectionName;
			<WaitMontageSection>d__.<>1__state = -1;
			<WaitMontageSection>d__.<>t__builder.Start<GuqinSubController.<WaitMontageSection>d__50>(ref <WaitMontageSection>d__);
			return <WaitMontageSection>d__.<>t__builder.Task;
		}

		// Token: 0x0602B82B RID: 178219 RVA: 0x00C3A19C File Offset: 0x00C3839C
		private void CancelWaitMontage()
		{
			TimerHandle montageTimer = this.MontageTimer;
			if (montageTimer != null && montageTimer.Valid())
			{
				this.MontageTimer.Remove();
			}
			this.MontageTimer = null;
			CustomPromise montagePromise = this.MontagePromise;
			if (montagePromise != null)
			{
				montagePromise.SetResult();
			}
			this.MontagePromise = null;
		}

		// Token: 0x0602B82C RID: 178220 RVA: 0x00C3A1E8 File Offset: 0x00C383E8
		private float? GetMontageSectionEndTime(FName sectionName)
		{
			if (!this.IsEntityOnStage())
			{
				return null;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			UAnimMontage uanimMontage;
			if (obj2 == null)
			{
				uanimMontage = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				uanimMontage = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			UAnimMontage uanimMontage2 = uanimMontage;
			if (uanimMontage2 == null)
			{
				return null;
			}
			TArray<FCompositeSection> compositeSections = uanimMontage2.CompositeSections;
			int num = compositeSections.Num();
			for (int i = 0; i < num; i++)
			{
				if (compositeSections.Get(i).SectionName.Equals(sectionName))
				{
					return new float?((i + 1 < num) ? compositeSections.Get(i + 1).SegmentBeginTime : uanimMontage2.SequenceLength);
				}
			}
			return null;
		}

		// Token: 0x0602B82D RID: 178221 RVA: 0x00C3A2B0 File Offset: 0x00C384B0
		private UniTask WaitMontagePosition(float targetPosition)
		{
			GuqinSubController.<WaitMontagePosition>d__53 <WaitMontagePosition>d__;
			<WaitMontagePosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitMontagePosition>d__.<>4__this = this;
			<WaitMontagePosition>d__.targetPosition = targetPosition;
			<WaitMontagePosition>d__.<>1__state = -1;
			<WaitMontagePosition>d__.<>t__builder.Start<GuqinSubController.<WaitMontagePosition>d__53>(ref <WaitMontagePosition>d__);
			return <WaitMontagePosition>d__.<>t__builder.Task;
		}

		// Token: 0x0602B82E RID: 178222 RVA: 0x00C3A2FC File Offset: 0x00C384FC
		private float GetCurrentMontageBlendInTime()
		{
			if (!this.IsEntityOnStage())
			{
				return 0f;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			object obj3;
			if (obj2 == null)
			{
				obj3 = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				obj3 = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			object obj4 = obj3;
			if (obj4 == null)
			{
				return 0f;
			}
			return obj4.BlendIn.BlendTime;
		}

		// Token: 0x0602B82F RID: 178223 RVA: 0x00C3A364 File Offset: 0x00C38564
		private void PlayQtePostMontage()
		{
			GuQinActivityParam? config = ConfigGuQinActivityParamById.GetConfig(111400001, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "古琴玩法:获取不到活动配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", 111400001);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			GuQinActivityParam valueOrDefault = config.GetValueOrDefault();
			string montagePath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? valueOrDefault.MaleMontagePaths(1) : valueOrDefault.FemaleMontagePaths(1);
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.PlayMontage(new IPlayMontageParam
			{
				MontagePath = montagePath,
				InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.LOOP_SECTION)
			});
		}

		// Token: 0x0602B830 RID: 178224 RVA: 0x00C3A458 File Offset: 0x00C38658
		private void PlayQteEndSection()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendToEndSection)
			});
		}

		// Token: 0x0602B831 RID: 178225 RVA: 0x00C3A4C4 File Offset: 0x00C386C4
		private float GetCurrentMontageBlendOutTime()
		{
			if (!this.IsEntityOnStage())
			{
				return 0f;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			object obj3;
			if (obj2 == null)
			{
				obj3 = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				obj3 = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			object obj4 = obj3;
			if (obj4 == null)
			{
				return 0f;
			}
			return obj4.BlendOut.BlendTime;
		}

		// Token: 0x0602B832 RID: 178226 RVA: 0x00C3A52C File Offset: 0x00C3872C
		private UniTask<bool> RequestPlayState(ZitherOpState state)
		{
			GuqinSubController.<RequestPlayState>d__58 <RequestPlayState>d__;
			<RequestPlayState>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestPlayState>d__.state = state;
			<RequestPlayState>d__.<>1__state = -1;
			<RequestPlayState>d__.<>t__builder.Start<GuqinSubController.<RequestPlayState>d__58>(ref <RequestPlayState>d__);
			return <RequestPlayState>d__.<>t__builder.Task;
		}

		// Token: 0x0602B833 RID: 178227 RVA: 0x00C3A56F File Offset: 0x00C3876F
		[NullableContext(2)]
		public GuqinView GetView()
		{
			if (this.ViewId == null)
			{
				return null;
			}
			return UiManager.Instance.GetView(this.ViewId.Value) as GuqinView;
		}

		// Token: 0x0602B834 RID: 178228 RVA: 0x00C3A59C File Offset: 0x00C3879C
		[NullableContext(1)]
		public void OnGamepadCameraZoom(string axisName, float value)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			MusicalInstrumentSubModel subModel = base.GetSubModel();
			if (((subModel != null) ? subModel.GetQteData() : null) != null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.HelpView))
			{
				return;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterInputComponent characterInputComponent;
			if (currentEntity == null)
			{
				characterInputComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterInputComponent = ((entity != null) ? entity.GetComponent<CharacterInputComponent>() : null);
			}
			CharacterInputComponent characterInputComponent2 = characterInputComponent;
			if (characterInputComponent2 == null)
			{
				return;
			}
			float value2 = value * 80f;
			characterInputComponent2.HandleInputAxis(EInputAxis.Zoom, value2);
		}

		// Token: 0x040177FF RID: 96255
		private const int SKILL_ID = 800030;

		// Token: 0x04017800 RID: 96256
		private const int ACTIVITYID = 111400001;

		// Token: 0x04017801 RID: 96257
		[Nullable(1)]
		private const string END_GUQIN_TAG_NAME = "系统.活动.弹琴玩法.结束弹琴";

		// Token: 0x04017802 RID: 96258
		private const float BLACK_FADE_TIME = 0.5f;

		// Token: 0x04017803 RID: 96259
		[Nullable(2)]
		private CustomPromise MontagePromise;

		// Token: 0x04017804 RID: 96260
		[Nullable(2)]
		private TimerHandle MontageTimer;

		// Token: 0x04017805 RID: 96261
		[Nullable(2)]
		private UiCameraHandleData CameraHandle;

		// Token: 0x04017806 RID: 96262
		private int? ViewId;

		// Token: 0x04017807 RID: 96263
		[Nullable(1)]
		private ConditionPassCallback ConditionPassCallback;

		// Token: 0x04017808 RID: 96264
		[Nullable(2)]
		private EntityHandle CurrentEntity;

		// Token: 0x04017809 RID: 96265
		private bool IsSkillEnded;

		// Token: 0x0401780A RID: 96266
		private bool IsEnterCancelled;

		// Token: 0x0401780B RID: 96267
		private bool IsSkillStarted;

		// Token: 0x0401780C RID: 96268
		private bool IsServerEntered;
	}
}
