using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B2 RID: 25778
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateMeshVisible : AiStateMachineState
	{
		// Token: 0x0603EA25 RID: 256549 RVA: 0x0123FED0 File Offset: 0x0123E0D0
		public AiStateMachineStateMeshVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA26 RID: 256550 RVA: 0x0123FEDA File Offset: 0x0123E0DA
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.Tag = new FName?(new FName(state.BindMeshVisible.Tag));
			this.Visible = state.BindMeshVisible.Visible;
			this.PropagateToChildren = state.BindMeshVisible.PropagateToChildren;
			return true;
		}

		// Token: 0x0603EA27 RID: 256551 RVA: 0x0123FF1C File Offset: 0x0123E11C
		private void InitMeshComponentsCache()
		{
			if (this.MeshComponentsCache == null)
			{
				TArray<UActorComponent> componentsByTag = this.Node.ActorComponent.Actor.GetComponentsByTag(USkeletalMeshComponent.StaticClass(), this.Tag.Value);
				this.MeshComponentsCache = new List<USkeletalMeshComponent>();
				foreach (UActorComponent uactorComponent in componentsByTag)
				{
					this.MeshComponentsCache.Add(uactorComponent as USkeletalMeshComponent);
				}
			}
		}

		// Token: 0x0603EA28 RID: 256552 RVA: 0x0123FFB0 File Offset: 0x0123E1B0
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.InitMeshComponentsCache();
			if (this.MeshComponentsCache != null)
			{
				foreach (USkeletalMeshComponent uskeletalMeshComponent in this.MeshComponentsCache)
				{
					uskeletalMeshComponent.SetHiddenInGame(!this.Visible, this.PropagateToChildren);
				}
			}
		}

		// Token: 0x0603EA29 RID: 256553 RVA: 0x01240020 File Offset: 0x0123E220
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				return;
			}
			this.InitMeshComponentsCache();
			if (this.MeshComponentsCache != null)
			{
				foreach (USkeletalMeshComponent uskeletalMeshComponent in this.MeshComponentsCache)
				{
					uskeletalMeshComponent.SetHiddenInGame(this.Visible, this.PropagateToChildren);
				}
			}
		}

		// Token: 0x0603EA2A RID: 256554 RVA: 0x012400AC File Offset: 0x0123E2AC
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021723 RID: 136995
		public FName? Tag;

		// Token: 0x04021724 RID: 136996
		public bool Visible;

		// Token: 0x04021725 RID: 136997
		public bool PropagateToChildren;

		// Token: 0x04021726 RID: 136998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<USkeletalMeshComponent> MeshComponentsCache;
	}
}
