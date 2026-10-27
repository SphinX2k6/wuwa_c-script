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
	// Token: 0x020059E4 RID: 23012
	[NullableContext(1)]
	[Nullable(0)]
	public class TakePicturesWithTimeScaleChildQuestNode : TickBehaviorNode
	{
		// Token: 0x0603A518 RID: 238872 RVA: 0x00DDEED0 File Offset: 0x00DDD0D0
		public TakePicturesWithTimeScaleChildQuestNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A519 RID: 238873 RVA: 0x00DDEEDC File Offset: 0x00DDD0DC
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

		// Token: 0x0603A51A RID: 238874 RVA: 0x00DDEFA8 File Offset: 0x00DDD1A8
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0603A51B RID: 238875 RVA: 0x00DDF008 File Offset: 0x00DDD208
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			EventSystem.Instance.Remove(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0603A51C RID: 238876 RVA: 0x00DDF068 File Offset: 0x00DDD268
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

		// Token: 0x0603A51D RID: 238877 RVA: 0x00DDF1DC File Offset: 0x00DDD3DC
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

		// Token: 0x0603A51E RID: 238878 RVA: 0x00DDF258 File Offset: 0x00DDD458
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

		// Token: 0x0603A51F RID: 238879 RVA: 0x00DDF28E File Offset: 0x00DDD48E
		private void UpdateAllEffectState()
		{
			this.UpdatePostEffect();
			this.UpdateScreenEffect();
		}

		// Token: 0x0603A520 RID: 238880 RVA: 0x00DDF29C File Offset: 0x00DDD49C
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

		// Token: 0x0603A521 RID: 238881 RVA: 0x00DDF314 File Offset: 0x00DDD514
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

		// Token: 0x0603A522 RID: 238882 RVA: 0x00DDF361 File Offset: 0x00DDD561
		private void OnFightPhotoTaskFinish()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0603A523 RID: 238883 RVA: 0x00DDF36A File Offset: 0x00DDD56A
		private void OnEffectLoaded(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.UpdatePostEffect();
		}

		// Token: 0x0603A524 RID: 238884 RVA: 0x00DDF377 File Offset: 0x00DDD577
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = true;
			this.UpdateAllEffectState();
		}

		// Token: 0x0603A525 RID: 238885 RVA: 0x00DDF394 File Offset: 0x00DDD594
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = false;
			this.UpdateAllEffectState();
		}

		// Token: 0x0603A526 RID: 238886 RVA: 0x00DDF3B4 File Offset: 0x00DDD5B4
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

		// Token: 0x0401E677 RID: 124535
		private const string POST_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White";

		// Token: 0x0401E678 RID: 124536
		private const string SCREEN_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White";

		// Token: 0x0401E679 RID: 124537
		public ETimeScaledPhotographTip? TipType;

		// Token: 0x0401E67A RID: 124538
		[Nullable(2)]
		public IPhotographCondition PhotographCondition;

		// Token: 0x0401E67B RID: 124539
		[Nullable(2)]
		public ICameraCondition CameraCondition;

		// Token: 0x0401E67C RID: 124540
		private bool LastStateIsCanFinishTask;

		// Token: 0x0401E67D RID: 124541
		private bool IsInAutoViewFinderState;

		// Token: 0x0401E67E RID: 124542
		private bool IsForceUpdate;

		// Token: 0x0401E67F RID: 124543
		private int PostEffectHandle;

		// Token: 0x0401E680 RID: 124544
		private int ScreenEffectHandle;

		// Token: 0x0401E681 RID: 124545
		private bool IsPhotographViewOpen;
	}
}
