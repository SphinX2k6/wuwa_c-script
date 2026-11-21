using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034FC RID: 13564
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PostProcessTriggerStateBase : StateBase<PostProcessTrigger, EPostProcessTriggerState>
	{
		// Token: 0x0602282A RID: 141354 RVA: 0x009CB878 File Offset: 0x009C9A78
		public PostProcessTriggerStateBase(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602282B RID: 141355 RVA: 0x009CB883 File Offset: 0x009C9A83
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
		}

		// Token: 0x0602282C RID: 141356 RVA: 0x009CB885 File Offset: 0x009C9A85
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x009CB887 File Offset: 0x009C9A87
		protected override void OnExit(EPostProcessTriggerState nextState)
		{
		}

		// Token: 0x0602282E RID: 141358 RVA: 0x009CB88C File Offset: 0x009C9A8C
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
