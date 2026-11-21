using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;
using UnrealEngine;

// Token: 0x0200240C RID: 9228
[NullableContext(2)]
[Nullable(0)]
public class CustomPlayMontage : CustomActionBase
{
	// Token: 0x0601717B RID: 94587 RVA: 0x006C01F0 File Offset: 0x006BE3F0
	public CustomPlayMontage(BasePerformComponent performComp, [Nullable(1)] CharacterAnimationComponent animComp, [Nullable(1)] string path, IAnimStateParam state = null, Action onPlayMontage = null, Action onStopMontage = null, Action callback = null)
	{
		this.PerformComp = performComp;
		this.AnimComp = animComp;
		this.Path = path;
		this.State = state;
		this.OnPlayMontage = onPlayMontage;
		this.OnStopMontage = onStopMontage;
		this.Callback = callback;
	}

	// Token: 0x0601717C RID: 94588 RVA: 0x006C0240 File Offset: 0x006BE440
	protected override void OnRunAction()
	{
		CustomPlayMontage.<>c__DisplayClass8_0 CS$<>8__locals1 = new CustomPlayMontage.<>c__DisplayClass8_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.AnimComp == null)
		{
			base.Finish(false);
			return;
		}
		CS$<>8__locals1.playMontage = delegate()
		{
			Action onPlayMontage2 = CS$<>8__locals1.<>4__this.OnPlayMontage;
			if (onPlayMontage2 == null)
			{
				return;
			}
			onPlayMontage2();
		};
		Action<UAnimMontage> onPlay = delegate(UAnimMontage _)
		{
			CS$<>8__locals1.playMontage();
		};
		Action<PlayingMontageInfo> onPlayMontage = delegate(PlayingMontageInfo _)
		{
			CS$<>8__locals1.playMontage();
		};
		CustomPlayMontage.<>c__DisplayClass8_0 CS$<>8__locals2 = CS$<>8__locals1;
		NpcPerformComponent npcPerformComponent = this.PerformComp as NpcPerformComponent;
		CS$<>8__locals2.lastAnimState = ((npcPerformComponent != null) ? npcPerformComponent.CurAnimState : -1);
		CS$<>8__locals1.stopMontage = delegate()
		{
			if (CS$<>8__locals1.<>4__this.CheckFinish(0f))
			{
				return;
			}
			Action onStopMontage2 = CS$<>8__locals1.<>4__this.OnStopMontage;
			if (onStopMontage2 != null)
			{
				onStopMontage2();
			}
			CS$<>8__locals1.<>4__this.Finish(true);
			if (CS$<>8__locals1.<>4__this.PerformComp != null)
			{
				NpcPerformComponent npcPerformComponent2 = CS$<>8__locals1.<>4__this.PerformComp as NpcPerformComponent;
				if (npcPerformComponent2 == null)
				{
					return;
				}
				npcPerformComponent2.SwitchAnimState(new SwitchState
				{
					TargetStateName = (CS$<>8__locals1.<>4__this.PerformComp as NpcPerformComponent).GetAnimStateName(CS$<>8__locals1.lastAnimState),
					Context = "[CustomAction][CustomPlayMontage]切回之前的状态"
				});
			}
		};
		Action<UAnimMontage, bool> onEnd = delegate(UAnimMontage _, bool _)
		{
			CS$<>8__locals1.stopMontage();
		};
		Action<PlayingMontageInfo> onStopMontage = delegate(PlayingMontageInfo _)
		{
			CS$<>8__locals1.stopMontage();
		};
		if (this.PerformComp != null)
		{
			this.PlayMontageId = this.PerformComp.VolatileMontagePlayByLoad(EPerformMode.Action, this.Path, this.State, onPlay, onEnd, new float?(0f), new float?(0f), new bool?(false), new bool?(false), new bool?(false));
		}
		else
		{
			this.PlayMontageId = PlayMontageUtils.Instance.LoadAndPlayMontage(this.AnimComp, this.Path, new PlayMontageConfig(0, 0.0, false, false), onPlayMontage, onStopMontage, null);
		}
		if (this.PlayMontageId < 0)
		{
			base.Finish(false);
		}
	}

	// Token: 0x0601717D RID: 94589 RVA: 0x006C0374 File Offset: 0x006BE574
	protected override void OnAbort()
	{
		if (this.PlayMontageId < 0)
		{
			return;
		}
		if (this.PerformComp != null)
		{
			this.PerformComp.VolatileMontageStopByLoad(EPerformMode.Ecology, this.PlayMontageId, EStopMethod.BlendOut);
			return;
		}
		PlayMontageUtils.Instance.ClearAndStopMontage(this.PlayMontageId, this.AnimComp, 0f);
	}

	// Token: 0x0400C25C RID: 49756
	private readonly BasePerformComponent PerformComp;

	// Token: 0x0400C25D RID: 49757
	[Nullable(1)]
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400C25E RID: 49758
	[Nullable(1)]
	private readonly string Path;

	// Token: 0x0400C25F RID: 49759
	private readonly IAnimStateParam State;

	// Token: 0x0400C260 RID: 49760
	private readonly Action OnPlayMontage;

	// Token: 0x0400C261 RID: 49761
	private readonly Action OnStopMontage;

	// Token: 0x0400C262 RID: 49762
	private int PlayMontageId = -1;
}
