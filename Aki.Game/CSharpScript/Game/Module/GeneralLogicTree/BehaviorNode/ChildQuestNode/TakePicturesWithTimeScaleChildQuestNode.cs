using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BD RID: 18877
	[NullableContext(1)]
	[Nullable(0)]
	public class TakePicturesWithTimeScaleChildQuestNode : TickBehaviorNode
	{
		// Token: 0x0602F43F RID: 193599 RVA: 0x00D2E73C File Offset: 0x00D2C93C
		public TakePicturesWithTimeScaleChildQuestNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F440 RID: 193600 RVA: 0x00D2E748 File Offset: 0x00D2C948
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			ITimeScaledPhotograph timeScaledPhotograph = childQuestBtNode.Condition as ITimeScaledPhotograph;
			if (timeScaledPhotograph == null)
			{
				return false;
			}
			this.TipType = new ETimeScaledPhotographTip?(timeScaledPhotograph.ViewFinderTip);
			this.PhotographCondition = timeScaledPhotograph.PhotographCondition;
			if (timeScaledPhotograph.CameraCondition.Condition.Conditions.Count != 0)
			{
				this.CameraCondition = timeScaledPhotograph.CameraCondition;
			}
			this.IsInAutoViewFinderState = false;
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
			this.PostEffectHandle = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White", "TackPictureQuest_effect", null, EEffectType.Scene, null, new Action<ELoadEffectResult, int>(this.OnEffectLoaded), null, true, false);
			FightPhotoModel.Instance.IsNewTaskCreated = true;
			return true;
		}

		// Token: 0x0602F441 RID: 193601 RVA: 0x00D2E814 File Offset: 0x00D2CA14
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602F442 RID: 193602 RVA: 0x00D2E874 File Offset: 0x00D2CA74
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			EventSystem.Instance.Remove(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602F443 RID: 193603 RVA: 0x00D2E8D4 File Offset: 0x00D2CAD4
		protected override void OnTick(float delta)
		{
			if (PhotographController.Instance.CheckIfInFightPhotographCamera())
			{
				if (this.LastStateIsCanFinishTask)
				{
					this.LastStateIsCanFinishTask = false;
					EventSystem.Instance.Emit<bool>(EEventName.OnNeedShowFightPhotoFocus, false);
				}
				return;
			}
			ETimeScaledPhotographTip? tipType = this.TipType;
			ETimeScaledPhotographTip etimeScaledPhotographTip = ETimeScaledPhotographTip.NoTip;
			if (tipType.GetValueOrDefault() == etimeScaledPhotographTip & tipType != null)
			{
				return;
			}
			if (FightPhotoModel.Instance.CheckRoleInCamera(this.PhotographCondition) && FightPhotoModel.Instance.CheckPhotographCondition(this.PhotographCondition))
			{
				if (!this.IsForceUpdate && this.LastStateIsCanFinishTask)
				{
					return;
				}
				EventSystem.Instance.Emit<bool>(EEventName.OnNeedShowFightPhotoFocus, true);
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "PhotoBattleStartFocus");
				this.HighLightExploreSkill(true);
				this.LastStateIsCanFinishTask = true;
				this.IsForceUpdate = false;
				if (this.TipType.GetValueOrDefault() == ETimeScaledPhotographTip.AutoViewFinder)
				{
					PhotographModel.Instance.SetPhotographTimeDilation(BattleUiModel.Instance.TimeDilationSkillRatio);
					this.IsInAutoViewFinderState = true;
					this.UpdateAllEffectState();
					return;
				}
			}
			else
			{
				if (!this.IsForceUpdate && !this.LastStateIsCanFinishTask)
				{
					return;
				}
				EventSystem.Instance.Emit<bool>(EEventName.OnNeedShowFightPhotoFocus, false);
				this.HighLightExploreSkill(false);
				this.LastStateIsCanFinishTask = false;
				this.IsForceUpdate = false;
				if (this.TipType.GetValueOrDefault() == ETimeScaledPhotographTip.AutoViewFinder)
				{
					PhotographModel.Instance.SetPhotographTimeDilation(1f);
					AudioSystem.Instance.SetState("game_sys_fightphoto", "none", true);
					this.IsInAutoViewFinderState = false;
					this.UpdateAllEffectState();
				}
			}
		}

		// Token: 0x0602F444 RID: 193604 RVA: 0x00D2EA48 File Offset: 0x00D2CC48
		private void HighLightExploreSkill(bool isHighLight)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterExploreComponent characterExploreComponent;
			if (baseCharacter == null)
			{
				characterExploreComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterExploreComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterExploreComponent = ((entity != null) ? entity.GetComponent<CharacterExploreComponent>() : null);
				}
			}
			CharacterExploreComponent characterExploreComponent2 = characterExploreComponent;
			if (characterExploreComponent2 == null)
			{
				return;
			}
			if (isHighLight)
			{
				characterExploreComponent2.ShowHighlightExploreSkill(1029, -1f, new bool?(false), "系统.活动.拍照活动.时停技能高亮", null, null, null);
				return;
			}
			characterExploreComponent2.HideHighlightExploreSkill();
		}

		// Token: 0x0602F445 RID: 193605 RVA: 0x00D2EAC4 File Offset: 0x00D2CCC4
		public int? GetTargetRoleId()
		{
			IPhotographCondition photographCondition = this.PhotographCondition;
			if (photographCondition != null)
			{
				IPhotographTargetPlayer photographTargetPlayer = photographCondition.Target as IPhotographTargetPlayer;
				if (photographTargetPlayer != null)
				{
					return photographTargetPlayer.RoleId;
				}
			}
			return null;
		}

		// Token: 0x0602F446 RID: 193606 RVA: 0x00D2EAFA File Offset: 0x00D2CCFA
		private void UpdateAllEffectState()
		{
			this.UpdatePostEffect();
			this.UpdateScreenEffect();
		}

		// Token: 0x0602F447 RID: 193607 RVA: 0x00D2EB08 File Offset: 0x00D2CD08
		private void UpdatePostEffect()
		{
			if (!EffectSystem.Instance.IsValid(this.PostEffectHandle))
			{
				return;
			}
			if (this.IsInAutoViewFinderState && !this.IsPhotographViewOpen)
			{
				EffectSystem instance = EffectSystem.Instance;
				int postEffectHandle = this.PostEffectHandle;
				string reason = "[TackPictureQuest.ReplayEffect]";
				FTransformDouble? ftransformDouble = null;
				instance.ReplayEffect(postEffectHandle, reason, ftransformDouble);
				EffectSystem.Instance.SetEffectHidden(this.PostEffectHandle, false, null, false);
				return;
			}
			EffectSystem.Instance.SetEffectHidden(this.PostEffectHandle, true, null, false);
		}

		// Token: 0x0602F448 RID: 193608 RVA: 0x00D2EB80 File Offset: 0x00D2CD80
		private void UpdateScreenEffect()
		{
			if (this.ScreenEffectHandle != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle);
			}
			if (!this.IsInAutoViewFinderState || this.IsPhotographViewOpen)
			{
				return;
			}
			this.ScreenEffectHandle = ScreenEffectModel.Instance.PlayScreenEffect("/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White", null, null);
		}

		// Token: 0x0602F449 RID: 193609 RVA: 0x00D2EBCD File Offset: 0x00D2CDCD
		private void OnFightPhotoTaskFinish()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0602F44A RID: 193610 RVA: 0x00D2EBD6 File Offset: 0x00D2CDD6
		private void OnEffectLoaded(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.UpdatePostEffect();
		}

		// Token: 0x0602F44B RID: 193611 RVA: 0x00D2EBE3 File Offset: 0x00D2CDE3
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = true;
			this.UpdateAllEffectState();
		}

		// Token: 0x0602F44C RID: 193612 RVA: 0x00D2EC00 File Offset: 0x00D2CE00
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = false;
			this.UpdateAllEffectState();
		}

		// Token: 0x0602F44D RID: 193613 RVA: 0x00D2EC20 File Offset: 0x00D2CE20
		protected override void OnEnd(bool bFinished)
		{
			if (this.IsInAutoViewFinderState)
			{
				PhotographModel.Instance.SetPhotographTimeDilation(1f);
			}
			this.HighLightExploreSkill(false);
			this.IsInAutoViewFinderState = false;
			if (this.PostEffectHandle != 0)
			{
				EffectSystem.Instance.StopEffectById(this.PostEffectHandle, "[TackPictureQuest]OnEnd", true, null);
				this.PostEffectHandle = 0;
			}
			if (this.ScreenEffectHandle != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle);
				this.ScreenEffectHandle = 0;
			}
			base.OnEnd(bFinished);
		}

		// Token: 0x04019116 RID: 102678
		private const string POST_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White";

		// Token: 0x04019117 RID: 102679
		private const string SCREEN_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White";

		// Token: 0x04019118 RID: 102680
		public ETimeScaledPhotographTip? TipType;

		// Token: 0x04019119 RID: 102681
		[Nullable(2)]
		public IPhotographCondition PhotographCondition;

		// Token: 0x0401911A RID: 102682
		[Nullable(2)]
		public ICameraCondition CameraCondition;

		// Token: 0x0401911B RID: 102683
		private bool LastStateIsCanFinishTask;

		// Token: 0x0401911C RID: 102684
		private bool IsInAutoViewFinderState;

		// Token: 0x0401911D RID: 102685
		private bool IsForceUpdate;

		// Token: 0x0401911E RID: 102686
		private int PostEffectHandle;

		// Token: 0x0401911F RID: 102687
		private int ScreenEffectHandle;

		// Token: 0x04019120 RID: 102688
		private bool IsPhotographViewOpen;
	}
}
