using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007329 RID: 29481
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateCollisionChannel : AiStateMachineState
	{
		// Token: 0x060485BB RID: 296379 RVA: 0x0129CA2E File Offset: 0x0129AC2E
		public AiStateMachineStateCollisionChannel(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485BC RID: 296380 RVA: 0x0129CA43 File Offset: 0x0129AC43
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.IgnoreChannels = state.BindCollisionChannel.IgnoreChannels;
			return true;
		}

		// Token: 0x060485BD RID: 296381 RVA: 0x0129CA58 File Offset: 0x0129AC58
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			TArray<UActorComponent> tarray = this.Node.ActorComponent.Actor.K2_GetComponentsByClass(UShapeComponent.StaticClass());
			foreach (int num in this.IgnoreChannels)
			{
				this.OriginalResponses[num] = new Dictionary<UShapeComponent, ECollisionResponse>();
				Dictionary<UShapeComponent, ECollisionResponse> dictionary = this.OriginalResponses[num];
				for (int i = 0; i < tarray.Num(); i++)
				{
					UShapeComponent ushapeComponent = tarray.Get(i) as UShapeComponent;
					TEnumAsByte<ECollisionResponse> collisionResponseToChannel = ushapeComponent.GetCollisionResponseToChannel((ECollisionChannel)num);
					dictionary[ushapeComponent] = collisionResponseToChannel;
					ushapeComponent.SetCollisionResponseToChannel((ECollisionChannel)num, ECollisionResponse.ECR_Ignore);
				}
			}
		}

		// Token: 0x060485BE RID: 296382 RVA: 0x0129CB28 File Offset: 0x0129AD28
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			TArray<UActorComponent> tarray = this.Node.ActorComponent.Actor.K2_GetComponentsByClass(UShapeComponent.StaticClass());
			foreach (int num in this.IgnoreChannels)
			{
				Dictionary<UShapeComponent, ECollisionResponse> dictionary;
				if (this.OriginalResponses.TryGetValue(num, out dictionary))
				{
					for (int i = 0; i < tarray.Num(); i++)
					{
						UShapeComponent ushapeComponent = tarray.Get(i) as UShapeComponent;
						ECollisionResponse newResponse;
						if (dictionary.TryGetValue(ushapeComponent, out newResponse))
						{
							ushapeComponent.SetCollisionResponseToChannel((ECollisionChannel)num, newResponse);
						}
					}
				}
			}
			this.OriginalResponses.Clear();
		}

		// Token: 0x04026423 RID: 156707
		[Nullable(2)]
		public List<int> IgnoreChannels;

		// Token: 0x04026424 RID: 156708
		private readonly Dictionary<int, Dictionary<UShapeComponent, ECollisionResponse>> OriginalResponses = new Dictionary<int, Dictionary<UShapeComponent, ECollisionResponse>>();
	}
}
