using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064AC RID: 25772
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateCollisionChannel : AiStateMachineState
	{
		// Token: 0x0603EA08 RID: 256520 RVA: 0x0123F4AE File Offset: 0x0123D6AE
		public AiStateMachineStateCollisionChannel(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA09 RID: 256521 RVA: 0x0123F4C3 File Offset: 0x0123D6C3
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.IgnoreChannels = state.BindCollisionChannel.IgnoreChannels;
			return true;
		}

		// Token: 0x0603EA0A RID: 256522 RVA: 0x0123F4D8 File Offset: 0x0123D6D8
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

		// Token: 0x0603EA0B RID: 256523 RVA: 0x0123F5A8 File Offset: 0x0123D7A8
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

		// Token: 0x04021710 RID: 136976
		[Nullable(2)]
		public List<int> IgnoreChannels;

		// Token: 0x04021711 RID: 136977
		private readonly Dictionary<int, Dictionary<UShapeComponent, ECollisionResponse>> OriginalResponses = new Dictionary<int, Dictionary<UShapeComponent, ECollisionResponse>>();
	}
}
