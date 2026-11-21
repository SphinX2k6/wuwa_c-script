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
	// Token: 0x0200649E RID: 25758
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskLeaveFight : AiStateMachineTask
	{
		// Token: 0x0603E98A RID: 256394 RVA: 0x0123C3E0 File Offset: 0x0123A5E0
		public AiStateMachineTaskLeaveFight(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E98B RID: 256395 RVA: 0x0123C42C File Offset: 0x0123A62C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			this.BlinkTime = task.TaskLeaveFight.BlinkTime;
			this.UsePatrolPointPriority = task.TaskLeaveFight.UsePatrolPointPriority;
			this.MaxStopTime = task.TaskLeaveFight.MaxStopTime;
			return true;
		}

		// Token: 0x0603E98C RID: 256396 RVA: 0x0123C464 File Offset: 0x0123A664
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

		// Token: 0x0603E98D RID: 256397 RVA: 0x0123C7E0 File Offset: 0x0123A9E0
		private void SetAiSceneEnable(AiController aiController, bool enable)
		{
			AiPerception aiPerception = aiController.AiPerception as AiPerception;
			if (aiPerception != null)
			{
				aiPerception.SetAllAiSenseEnable(enable);
			}
		}

		// Token: 0x0603E98E RID: 256398 RVA: 0x0123C803 File Offset: 0x0123AA03
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

		// Token: 0x0603E98F RID: 256399 RVA: 0x0123C829 File Offset: 0x0123AA29
		private void Finish(bool finish)
		{
			if (!this.Running)
			{
				return;
			}
			this.Node.TaskFinished = true;
			this.Running = false;
		}

		// Token: 0x0603E990 RID: 256400 RVA: 0x0123C848 File Offset: 0x0123AA48
		public override void OnExit(long? contextId = null)
		{
			AiController aiController = this.Node.AiController;
			aiController.CharActorComp.SetInputDirect(global::Vector.ZeroVectorProxy, false, EInputDirectSpace.World);
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

		// Token: 0x0603E991 RID: 256401 RVA: 0x0123C968 File Offset: 0x0123AB68
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

		// Token: 0x0603E992 RID: 256402 RVA: 0x0123CABC File Offset: 0x0123ACBC
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

		// Token: 0x0603E993 RID: 256403 RVA: 0x0123CB18 File Offset: 0x0123AD18
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
			actor.SetInputDirect(global::Vector.ZeroVectorProxy, false, EInputDirectSpace.World);
		}

		// Token: 0x0603E994 RID: 256404 RVA: 0x0123CD60 File Offset: 0x0123AF60
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

		// Token: 0x0603E995 RID: 256405 RVA: 0x0123CE1C File Offset: 0x0123B01C
		private void ResetAiInfo(CharacterActorComponent actor)
		{
			FRotator rotation = this.Node.Entity.GetComponent<CreatureDataComponent>().GetRotation();
			actor.SetActorRotation(rotation, "脱战节点.重置为基础方法", false);
		}

		// Token: 0x0603E996 RID: 256406 RVA: 0x0123CE4D File Offset: 0x0123B04D
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x040216B3 RID: 136883
		public float BlinkTime;

		// Token: 0x040216B4 RID: 136884
		public bool UsePatrolPointPriority;

		// Token: 0x040216B5 RID: 136885
		public float MaxStopTime;

		// Token: 0x040216B6 RID: 136886
		private readonly global::Vector InitLocation = global::Vector.Create();

		// Token: 0x040216B7 RID: 136887
		private bool InBlink;

		// Token: 0x040216B8 RID: 136888
		private bool Teleported;

		// Token: 0x040216B9 RID: 136889
		private float BlinkElapseTime;

		// Token: 0x040216BA RID: 136890
		private int? ShowMaterialData;

		// Token: 0x040216BB RID: 136891
		private int? HideMaterialData;

		// Token: 0x040216BC RID: 136892
		private int MoveStateActural;

		// Token: 0x040216BD RID: 136893
		private string TsShowEffectDa = "";

		// Token: 0x040216BE RID: 136894
		private string TsHideEffectDa = "";

		// Token: 0x040216BF RID: 136895
		private string TsShowMaterialDa = "";

		// Token: 0x040216C0 RID: 136896
		private string TsHideMaterialDa = "";

		// Token: 0x040216C1 RID: 136897
		private bool Running;

		// Token: 0x040216C2 RID: 136898
		private const float BLINK_TIME = 1000f;

		// Token: 0x040216C3 RID: 136899
		private const int BLINK_TYPE = 3;
	}
}
