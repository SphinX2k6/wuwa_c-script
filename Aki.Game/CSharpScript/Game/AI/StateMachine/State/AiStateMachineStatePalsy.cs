using System;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B3 RID: 25779
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStatePalsy : AiStateMachineState
	{
		// Token: 0x0603EA2B RID: 256555 RVA: 0x012400B5 File Offset: 0x0123E2B5
		public AiStateMachineStatePalsy(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA2C RID: 256556 RVA: 0x012400D8 File Offset: 0x0123E2D8
		[NullableContext(2)]
		public unsafe override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			if (!string.IsNullOrEmpty(this.CounterAttackCamera))
			{
				CounterAttackCameraData loadedAsset = ResourceSystem.Instance.GetLoadedAsset<CounterAttackCameraData>(this.CounterAttackCamera);
				if (loadedAsset != null)
				{
					CameraController.Instance.MainModel.FightCamera.LogicComponent.ApplyCameraModify(new FGameplayTag?(loadedAsset.CameraData.Tag), loadedAsset.CameraData.持续时间, loadedAsset.CameraData.淡入时间, loadedAsset.CameraData.淡出时间, loadedAsset.CameraData.摄像机配置, null, loadedAsset.CameraData.打断淡出时间, null, null, default(OneOf<TsBaseCharacter, TsBaseVehicle>), loadedAsset.CameraData.CameraAttachSocket, default(OneOf<TsBaseCharacter, TsBaseVehicle>));
					AiStateMachineBase node = this.Node;
					if (node != null)
					{
						PawnTimeScaleComponent timeScaleComponent = node.TimeScaleComponent;
						if (timeScaleComponent != null)
						{
							timeScaleComponent.SetTimeScale(loadedAsset.VictimTimeScale.优先级, loadedAsset.VictimTimeScale.时间膨胀值, loadedAsset.VictimTimeScale.时间膨胀变化曲线, loadedAsset.VictimTimeScale.时间膨胀时长, ETimeScaleSourceType.BeCountered, false, false);
						}
					}
					EntityHandle currentTarget = this.Node.AiController.AiHateList.GetCurrentTarget();
					if (currentTarget != null)
					{
						currentTarget.Entity.GetComponent<PawnTimeScaleComponent>().SetTimeScale(loadedAsset.AttackerTimeScale.优先级, loadedAsset.AttackerTimeScale.时间膨胀值, loadedAsset.AttackerTimeScale.时间膨胀变化曲线, loadedAsset.AttackerTimeScale.时间膨胀时长, ETimeScaleSourceType.BeCountered, false, false);
					}
					if (loadedAsset.CameraShake != null && !CameraController.Instance.MainModel.IsModeEnabled(ECustomCameraMode.Widget) && !CameraController.Instance.MainModel.IsModeEnabled(ECustomCameraMode.Sequence))
					{
						FVectorDouble value = CameraModel.Instance.MainModel.FightCamera.GetComponent<FightCameraDisplayComponent>().CameraActor.D_K2_GetActorLocation();
						CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(loadedAsset.CameraShake), new FVectorDouble?(value), 0f, 100f, 1f, false, "MainCamera");
					}
				}
				else
				{
					CreatureDataComponent component = this.Node.Entity.GetComponent<CreatureDataComponent>();
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Resource;
					ELogAuthor author = ELogAuthor.WCL;
					string message = "AiStateMachineStatePalsy Camera 资源加载资产为空";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "actorName";
					CharacterActorComponent actorComponent = this.Node.ActorComponent;
					ptr = new ValueTuple<string, object>(item, (actorComponent != null) ? actorComponent.Actor.GetName() : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pbDataId", component.GetPbDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("path", this.CounterAttackCamera);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			if (!string.IsNullOrEmpty(this.CounterAttackEffect))
			{
				CounterAttackEffectData loadedAsset2 = ResourceSystem.Instance.GetLoadedAsset<CounterAttackEffectData>(this.CounterAttackEffect);
				if (loadedAsset2 != null)
				{
					AiStateMachineBase node2 = this.Node;
					HitInformation hitInformation;
					if (node2 == null)
					{
						hitInformation = null;
					}
					else
					{
						CharacterHitComponent hitComponent = node2.HitComponent;
						hitInformation = ((hitComponent != null) ? hitComponent.LastHitData : null);
					}
					HitInformation hitInformation2 = hitInformation;
					if (hitInformation2 != null)
					{
						AiStateMachineBase node3 = this.Node;
						if (node3 == null)
						{
							return;
						}
						CharacterHitComponent hitComponent2 = node3.HitComponent;
						if (hitComponent2 == null)
						{
							return;
						}
						HitInformation hitData = hitInformation2;
						string effectPath = loadedAsset2.EffectDA.AssetPathName.ToString();
						FVector scale = loadedAsset2.Scale;
						hitComponent2.PlayCounterAttackEffect(hitData, effectPath, new FVectorDouble(ref scale));
						return;
					}
				}
				else
				{
					CreatureDataComponent component2 = this.Node.Entity.GetComponent<CreatureDataComponent>();
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Resource;
					ELogAuthor author2 = ELogAuthor.WCL;
					string message2 = "AiStateMachineStatePalsy Effect 资源加载资产为空";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item2 = "actorName";
					CharacterActorComponent actorComponent2 = this.Node.ActorComponent;
					ptr2 = new ValueTuple<string, object>(item2, (actorComponent2 != null) ? actorComponent2.Actor.GetName() : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("pbDataId", component2.GetPbDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("path", this.CounterAttackEffect);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
		}

		// Token: 0x0603EA2D RID: 256557 RVA: 0x012404AF File Offset: 0x0123E6AF
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
		}

		// Token: 0x0603EA2E RID: 256558 RVA: 0x012404B1 File Offset: 0x0123E6B1
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.CounterAttackEffect = state.BindPalsy.CounterAttackEffect;
			this.CounterAttackCamera = state.BindPalsy.CounterAttackCamera;
			return true;
		}

		// Token: 0x0603EA2F RID: 256559 RVA: 0x012404D6 File Offset: 0x0123E6D6
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021727 RID: 136999
		private string CounterAttackEffect = "";

		// Token: 0x04021728 RID: 137000
		private string CounterAttackCamera = "";
	}
}
