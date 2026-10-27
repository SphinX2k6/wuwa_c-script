using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732F RID: 29487
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateMeshVisible : AiStateMachineState
	{
		// Token: 0x060485D8 RID: 296408 RVA: 0x0129D450 File Offset: 0x0129B650
		public AiStateMachineStateMeshVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485D9 RID: 296409 RVA: 0x0129D45A File Offset: 0x0129B65A
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.Tag = new FName?(new FName(state.BindMeshVisible.Tag));
			this.Visible = state.BindMeshVisible.Visible;
			this.PropagateToChildren = state.BindMeshVisible.PropagateToChildren;
			return true;
		}

		// Token: 0x060485DA RID: 296410 RVA: 0x0129D49C File Offset: 0x0129B69C
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

		// Token: 0x060485DB RID: 296411 RVA: 0x0129D52C File Offset: 0x0129B72C
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

		// Token: 0x060485DC RID: 296412 RVA: 0x0129D59C File Offset: 0x0129B79C
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

		// Token: 0x060485DD RID: 296413 RVA: 0x0129D628 File Offset: 0x0129B828
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026436 RID: 156726
		public FName? Tag;

		// Token: 0x04026437 RID: 156727
		public bool Visible;

		// Token: 0x04026438 RID: 156728
		public bool PropagateToChildren;

		// Token: 0x04026439 RID: 156729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<USkeletalMeshComponent> MeshComponentsCache;
	}
}
