using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732C RID: 29484
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDeathMontageByTag : AiStateMachineState
	{
		// Token: 0x060485CB RID: 296395 RVA: 0x0129D1B7 File Offset: 0x0129B3B7
		public AiStateMachineStateDeathMontageByTag(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485CC RID: 296396 RVA: 0x0129D1E4 File Offset: 0x0129B3E4
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.MontageTagIds = (state.BindDeathMontageByTag.MontageTagIds ?? Array.Empty<int>());
			this.MontageTagNames = (state.BindDeathMontageByTag.MontageTagNames ?? Array.Empty<string>());
			this.TagMontageNames = (state.BindDeathMontageByTag.TagMontageNames ?? Array.Empty<string>());
			return true;
		}

		// Token: 0x060485CD RID: 296397 RVA: 0x0129D240 File Offset: 0x0129B440
		[NullableContext(2)]
		public unsafe override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			BaseDeathComponent deathComponent = this.Node.DeathComponent;
			if (deathComponent == null)
			{
				return;
			}
			if (this.MontageTagIds.Length != this.MontageTagNames.Length || this.MontageTagIds.Length != this.TagMontageNames.Length)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
				Entity entity = this.Node.Entity;
				string message = "[AiStateMachineStateDeathMontageByTag]死亡动画_标签中配置数组长度不一致";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MontageTagIds长度", this.MontageTagIds.Length);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MontageTagNames长度", this.MontageTagNames.Length);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TagMontageNames长度", this.TagMontageNames.Length);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (this.MontageTagIds.Length != 0)
			{
				for (int i = 0; i < this.MontageTagIds.Length; i++)
				{
					deathComponent.RegisterTagDeathMontage(this.MontageTagIds[i], this.MontageTagNames[i], this.TagMontageNames[i]);
				}
			}
		}

		// Token: 0x060485CE RID: 296398 RVA: 0x0129D358 File Offset: 0x0129B558
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.MontageTagIds.Length != 0)
			{
				for (int i = 0; i < this.MontageTagIds.Length; i++)
				{
					BaseDeathComponent deathComponent = this.Node.DeathComponent;
					if (deathComponent != null)
					{
						deathComponent.UnregisterTagDeathMontage(this.MontageTagIds[i], this.TagMontageNames[i]);
					}
				}
			}
		}

		// Token: 0x060485CF RID: 296399 RVA: 0x0129D3A7 File Offset: 0x0129B5A7
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026431 RID: 156721
		public int[] MontageTagIds = Array.Empty<int>();

		// Token: 0x04026432 RID: 156722
		public string[] MontageTagNames = Array.Empty<string>();

		// Token: 0x04026433 RID: 156723
		public string[] TagMontageNames = Array.Empty<string>();
	}
}
