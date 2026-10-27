using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200731B RID: 29467
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskLeaveFight : AiStateMachineTask
	{
		// Token: 0x0604853D RID: 296253 RVA: 0x01299960 File Offset: 0x01297B60
		public AiStateMachineTaskLeaveFight(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0604853E RID: 296254 RVA: 0x012999AC File Offset: 0x01297BAC
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			this.BlinkTime = task.TaskLeaveFight.BlinkTime;
			this.UsePatrolPointPriority = task.TaskLeaveFight.UsePatrolPointPriority;
			this.MaxStopTime = task.TaskLeaveFight.MaxStopTime;
			return true;
		}

		// Token: 0x0604853F RID: 296255 RVA: 0x012999E4 File Offset: 0x01297BE4
		public override void OnEnter(long? contextId = null)
		{
			this.Running = true;
			this.Teleported = false;
			AiController aiController = this.Node.AiController;
			if (aiController == null)
			{
				Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.LCZ, "错误的Controller类型", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Node.SkillComponent.StopAllSkills("AiStateMachineTaskLeaveFight.OnEnter");
			UAnimInstance mainAnimInstance = this.Node.AnimationComponent.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.Montage_Stop(0f, null);
			}
			AiWanderInfos aiWanderInfos = aiController.AiWanderInfos;
			AiWander? aiWander = (aiWanderInfos != null) ? aiWanderInfos.AiWander : null;
			if (aiWander == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BehaviorTree;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "没有配置AiWander";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.MoveStateActural = aiWander.Value.ResetMoveState;
				this.TsShowEffectDa = aiWander.Value.ShowEffectDaPath;
				this.TsHideEffectDa = aiWander.Value.HideEffectDaPath;
				this.TsShowMaterialDa = aiWander.Value.ShowMaterialDaPath;
				this.TsHideMaterialDa = aiWander.Value.HideMaterialDaPath;
			}
			CharacterActorComponent character = aiController.CharActorComp;
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				this.InitLocation.DeepCopy(monsterInfoByEntityId.PauseLocation);
			}
			else
			{
				AiPatrolConfig config = aiController.AiPatrol.GetConfig();
				global::Vector vector = null;
				if (config != null)
				{
					int splineEntityId = config.SplineEntityId;
					CharacterPatrolComponent component = character.Entity.GetComponent<CharacterPatrolComponent>();
					if (component != null)
					{
						vector = component.GetLastPatrolLocation((long)config.SplineEntityId);
					}
				}
				if (vector != null)
				{
					this.InitLocation.DeepCopy(vector);
				}
				else
				{
					this.InitLocation.DeepCopy(this.Node.AiComponent.HatredInitLocation);
				}
			}
			if (aiWander == null || this.MoveStateActural == 3)
			{
				this.BlinkBegin(character);
			}
			else
			{
				AiStateMachineBase node = this.Node;
				bool flag;
				if (node == null)
				{
					flag = false;
				}
				else
				{
					CharacterActorComponent actorComponent = node.ActorComponent;
					flag = ((actorComponent != null) ? new bool?(actorComponent.IsAutonomousProxy) : null).GetValueOrDefault();
				}
				if (flag)
				{
					MoveCharacterPoint item = new MoveCharacterPoint
					{
						Index = 0,
						Position = global::Vector.Create(this.InitLocation),
						MoveState = new EPatrolMoveState?((EPatrolMoveState)this.MoveStateActural),
						MoveSpeed = new float?((float)400)
					};
					List<MoveCharacterPoint> list = new List<MoveCharacterPoint>();
					list.Add(item);
					MoveCharacterConfig config2 = new MoveCharacterConfig
					{
						Points = list,
						Navigation = true,
						IsFly = false,
						DebugMode = false,
						Loop = false,
						ReturnTimeoutFailed = new float?(this.MaxStopTime / 1000f),
						Callback = delegate(ELevelEventState result)
						{
							if (result == ELevelEventState.Success)
							{
								this.Finish(true);
								return;
							}
							this.BlinkBegin(character);
							CombatLog.Instance.Warn(CombatLog.EDebugModule.StateMachineNew, this.Node.Entity, "脱战复位未找到路，瞬移移动回初始点", default(ReadOnlySpan<ValueTuple<string, object>>));
						},
						ReturnFalseWhenNavigationFailed = true
					};
					this.Node.MoveComponent.MoveAlongPath(config2, "AiStateMachineTaskLeaveFight.OnEnter");
					BaseUnifiedStateComponent baseUnifiedStateComponent = character.Entity.CheckGetComponent<BaseUnifiedStateComponent>();
					if (baseUnifiedStateComponent.Valid)
					{
						int moveStateActural = this.MoveStateActural;
						if (moveStateActural != 1)
						{
							if (moveStateActural == 2)
							{
								baseUnifiedStateComponent.SetMoveState(ECharMoveState.Run);
							}
						}
						else
						{
							baseUnifiedStateComponent.SetMoveState(ECharMoveState.Walk);
						}
					}
				}
			}
			this.SetAiSceneEnable(aiController, false);
		}

		// Token: 0x06048540 RID: 296256 RVA: 0x01299D60 File Offset: 0x01297F60
		private void SetAiSceneEnable(AiController aiController, bool enable)
		{
			AiPerception aiPerception = aiController.AiPerception as AiPerception;
			if (aiPerception != null)
			{
				aiPerception.SetAllAiSenseEnable(enable);
			}
		}

		// Token: 0x06048541 RID: 296257 RVA: 0x01299D83 File Offset: 0x01297F83
		protected override void OnTick(float delta, long? contextId = null)
		{
			if (this.Node.AiController == null)
			{
				this.Finish(false);
				return;
			}
			if (this.InBlink)
			{
				this.BlinkTick(delta);
			}
		}

		// Token: 0x06048542 RID: 296258 RVA: 0x01299DA9 File Offset: 0x01297FA9
		private void Finish(bool finish)
		{
			if (!this.Running)
			{
				return;
			}
			this.Node.TaskFinished = true;
			this.Running = false;
		}

		// Token: 0x06048543 RID: 296259 RVA: 0x01299DC8 File Offset: 0x01297FC8
		public override void OnExit(long? contextId = null)
		{
			AiController aiController = this.Node.AiController;
			aiController.CharActorComp.SetInputDirect(global::Vector.ZeroVectorProxy, false);
			this.SetAiSceneEnable(aiController, true);
			TsBaseCharacter actor = this.Node.ActorComponent.Actor;
			if (this.InBlink)
			{
				actor.SetActorEnableCollision(true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BehaviorTree;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "AiWander[OnClear]怪物闪烁导致Actor碰撞为True";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			int? num = this.HideMaterialData;
			int num2 = 0;
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				actor.CharRenderingComponent.RemoveMaterialControllerData(this.HideMaterialData.Value);
			}
			num = this.ShowMaterialData;
			num2 = 0;
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				actor.CharRenderingComponent.RemoveMaterialControllerData(this.ShowMaterialData.Value);
			}
			this.InBlink = false;
			this.Teleported = false;
			this.BlinkElapseTime = 0f;
			this.HideMaterialData = null;
			this.ShowMaterialData = null;
		}

		// Token: 0x06048544 RID: 296260 RVA: 0x01299EE8 File Offset: 0x012980E8
		private void BlinkBegin(CharacterActorComponent actor)
		{
			this.InBlink = true;
			this.BlinkElapseTime = 0f;
			this.ShowMaterialData = null;
			this.HideMaterialData = null;
			if (!string.IsNullOrEmpty(this.TsHideEffectDa))
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				int id = instance.SpawnEffect(world, ftransformDouble, this.TsHideEffectDa, "[AiStateMachineTaskLeaveFight.BlinkMoveBegin] hideEffect", new EffectContext(new int?(actor.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
				if (effectActor.IsValid())
				{
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FVectorDouble actorLocation = actor.ActorLocation;
					self.D_K2_SetActorLocation(actorLocation, false, ref WorldGlobal.SweepHitResult, false);
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.BehaviorTree;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "AiWander瞬移隐藏特效生成失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			if (!string.IsNullOrEmpty(this.TsHideMaterialDa))
			{
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(this.TsHideMaterialDa, delegate([Nullable(2)] PD_CharacterControllerData_C hideMaterial, string assetPath)
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "脱战隐藏材质加载回调";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					if (!this.Node.Activated)
					{
						return;
					}
					this.HideMaterialData = new int?(actor.Actor.CharRenderingComponent.AddMaterialControllerData(hideMaterial));
				}, 100, "js_undefined");
				return;
			}
			this.HideMaterialData = new int?(-1);
		}

		// Token: 0x06048545 RID: 296261 RVA: 0x0129A03C File Offset: 0x0129823C
		private void BlinkTick(float delta)
		{
			this.BlinkElapseTime += delta;
			if (this.BlinkElapseTime >= this.BlinkTime - 1000f && !this.Teleported)
			{
				this.BlinkTeleport();
				this.Teleported = true;
			}
			if (this.BlinkElapseTime >= this.BlinkTime)
			{
				this.BlinkEnd();
			}
		}

		// Token: 0x06048546 RID: 296262 RVA: 0x0129A098 File Offset: 0x01298298
		private void BlinkTeleport()
		{
			CharacterActorComponent actor = this.Node.ActorComponent;
			this.Node.ActorComponent.SetMoveControlled(true, (double)(this.BlinkTime * 0.001f), "脱战传送");
			actor.SetActorLocation(this.InitLocation.ToUeVector(false), "脱战节点.执行瞬移重置位置", false);
			actor.FixBornLocation("脱战节点.修正角色地面位置", true, null, false, false, true);
			actor.Actor.SetActorEnableCollision(true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "AiWander[BlinkMoveTick]怪物闪烁导致Actor碰撞为True";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor.Actor.GetName());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ResetAiInfo(actor);
			if (!string.IsNullOrEmpty(this.TsShowEffectDa))
			{
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				int id = instance2.SpawnEffect(world, ftransformDouble, this.TsShowEffectDa, "[AiStateMachineTaskLeaveFight.BlinkMoveTick] showEffect", new EffectContext(new int?(actor.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
				if (effectActor.IsValid())
				{
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FVectorDouble actorLocation = actor.ActorLocation;
					self.D_K2_SetActorLocation(actorLocation, false, ref WorldGlobal.SweepHitResult, false);
				}
				else
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "AiWander瞬移显示特效生成失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			int? hideMaterialData = this.HideMaterialData;
			int num = 0;
			if (hideMaterialData.GetValueOrDefault() >= num & hideMaterialData != null)
			{
				actor.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.HideMaterialData.Value);
				this.HideMaterialData = null;
			}
			if (!string.IsNullOrEmpty(this.TsShowMaterialDa))
			{
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(this.TsShowMaterialDa, delegate([Nullable(2)] PD_CharacterControllerData_C showMaterial, string assetPath)
				{
					if (!this.Node.Activated)
					{
						return;
					}
					this.ShowMaterialData = new int?(actor.Actor.CharRenderingComponent.AddMaterialControllerData(showMaterial));
				}, 100, "js_undefined");
			}
			else
			{
				this.ShowMaterialData = new int?(-1);
			}
			actor.SetInputDirect(global::Vector.ZeroVectorProxy, false);
		}

		// Token: 0x06048547 RID: 296263 RVA: 0x0129A2E0 File Offset: 0x012984E0
		private bool BlinkEnd()
		{
			CharacterActorComponent actorComponent = this.Node.ActorComponent;
			if (this.InBlink)
			{
				this.InBlink = false;
				if (!actorComponent.Actor.bActorEnableCollision)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.BehaviorTree;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "AiWander[BlinkMoveEnd]怪物闪烁此刻Actor碰撞不应该为False,查看[BlinkMoveTick]是否置为True";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actorComponent.Actor.GetName());
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				int? showMaterialData = this.ShowMaterialData;
				int num = 0;
				if (showMaterialData.GetValueOrDefault() >= num & showMaterialData != null)
				{
					actorComponent.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.ShowMaterialData.Value);
					this.ShowMaterialData = null;
				}
				this.Finish(true);
				return true;
			}
			return false;
		}

		// Token: 0x06048548 RID: 296264 RVA: 0x0129A39C File Offset: 0x0129859C
		private void ResetAiInfo(CharacterActorComponent actor)
		{
			FRotator rotation = this.Node.Entity.GetComponent<CreatureDataComponent>().GetRotation();
			actor.SetActorRotation(rotation, "脱战节点.重置为基础方法", false);
		}

		// Token: 0x06048549 RID: 296265 RVA: 0x0129A3CD File Offset: 0x012985CD
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x040263C6 RID: 156614
		public float BlinkTime;

		// Token: 0x040263C7 RID: 156615
		public bool UsePatrolPointPriority;

		// Token: 0x040263C8 RID: 156616
		public float MaxStopTime;

		// Token: 0x040263C9 RID: 156617
		private readonly global::Vector InitLocation = global::Vector.Create();

		// Token: 0x040263CA RID: 156618
		private bool InBlink;

		// Token: 0x040263CB RID: 156619
		private bool Teleported;

		// Token: 0x040263CC RID: 156620
		private float BlinkElapseTime;

		// Token: 0x040263CD RID: 156621
		private int? ShowMaterialData;

		// Token: 0x040263CE RID: 156622
		private int? HideMaterialData;

		// Token: 0x040263CF RID: 156623
		private int MoveStateActural;

		// Token: 0x040263D0 RID: 156624
		private string TsShowEffectDa = "";

		// Token: 0x040263D1 RID: 156625
		private string TsHideEffectDa = "";

		// Token: 0x040263D2 RID: 156626
		private string TsShowMaterialDa = "";

		// Token: 0x040263D3 RID: 156627
		private string TsHideMaterialDa = "";

		// Token: 0x040263D4 RID: 156628
		private bool Running;

		// Token: 0x040263D5 RID: 156629
		private const float BLINK_TIME = 1000f;

		// Token: 0x040263D6 RID: 156630
		private const int BLINK_TYPE = 3;
	}
}
