using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064AF RID: 25775
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDeathMontageByTag : AiStateMachineState
	{
		// Token: 0x0603EA18 RID: 256536 RVA: 0x0123FC37 File Offset: 0x0123DE37
		public AiStateMachineStateDeathMontageByTag(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA19 RID: 256537 RVA: 0x0123FC64 File Offset: 0x0123DE64
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.MontageTagIds = (state.BindDeathMontageByTag.MontageTagIds ?? Array.Empty<int>());
			this.MontageTagNames = (state.BindDeathMontageByTag.MontageTagNames ?? Array.Empty<string>());
			this.TagMontageNames = (state.BindDeathMontageByTag.TagMontageNames ?? Array.Empty<string>());
			return true;
		}

		// Token: 0x0603EA1A RID: 256538 RVA: 0x0123FCC0 File Offset: 0x0123DEC0
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

		// Token: 0x0603EA1B RID: 256539 RVA: 0x0123FDD8 File Offset: 0x0123DFD8
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

		// Token: 0x0603EA1C RID: 256540 RVA: 0x0123FE27 File Offset: 0x0123E027
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402171E RID: 136990
		public int[] MontageTagIds = Array.Empty<int>();

		// Token: 0x0402171F RID: 136991
		public string[] MontageTagNames = Array.Empty<string>();

		// Token: 0x04021720 RID: 136992
		public string[] TagMontageNames = Array.Empty<string>();
	}
}
