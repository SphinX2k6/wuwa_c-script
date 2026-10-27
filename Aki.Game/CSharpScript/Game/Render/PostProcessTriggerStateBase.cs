using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D3 RID: 17875
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PostProcessTriggerStateBase : StateBase<PostProcessTrigger, EPostProcessTriggerState>
	{
		// Token: 0x0602E136 RID: 188726 RVA: 0x00A9F1A8 File Offset: 0x00A9D3A8
		public PostProcessTriggerStateBase(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E137 RID: 188727 RVA: 0x00A9F1B3 File Offset: 0x00A9D3B3
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
		}

		// Token: 0x0602E138 RID: 188728 RVA: 0x00A9F1B5 File Offset: 0x00A9D3B5
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x0602E139 RID: 188729 RVA: 0x00A9F1B7 File Offset: 0x00A9D3B7
		protected override void OnExit(EPostProcessTriggerState nextState)
		{
		}

		// Token: 0x0602E13A RID: 188730 RVA: 0x00A9F1BC File Offset: 0x00A9D3BC
		public double GetTargetDefaultValue()
		{
			EWuYinQuState? wuYinQuBattleState = this.Owner.GetWuYinQuBattleState();
			string wuYinQuBattleKey = this.Owner.GetWuYinQuBattleKey();
			EWuYinQuState? ewuYinQuState = wuYinQuBattleState;
			EWuYinQuState ewuYinQuState2 = EWuYinQuState.StateIdle;
			if (!(ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null))
			{
				ewuYinQuState = wuYinQuBattleState;
				ewuYinQuState2 = EWuYinQuState.Nothing;
				if (!(ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null))
				{
					ewuYinQuState = wuYinQuBattleState;
					ewuYinQuState2 = EWuYinQuState.StateFighting1;
					if (!(ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null))
					{
						ewuYinQuState = wuYinQuBattleState;
						ewuYinQuState2 = EWuYinQuState.StateFighting2;
						if (!(ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null))
						{
							ewuYinQuState = wuYinQuBattleState;
							ewuYinQuState2 = EWuYinQuState.StateFighting3;
							if (!(ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null))
							{
								return 0.0;
							}
						}
					}
					EWuYinQuState currentKeyState = RenderModuleController.Instance.GetCurrentKeyState(wuYinQuBattleKey);
					ewuYinQuState = wuYinQuBattleState;
					ewuYinQuState2 = currentKeyState;
					if (ewuYinQuState.GetValueOrDefault() == ewuYinQuState2 & ewuYinQuState != null)
					{
						return 1.0;
					}
					return 0.0;
				}
			}
			return !RenderModuleController.Instance.GetIdleClearAtmosphere(this.Owner.GetWuYinQuBattleKey());
		}
	}
}
