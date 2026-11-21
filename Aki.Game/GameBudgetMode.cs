using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200116C RID: 4460
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetMode : GameBudgetModeBase
{
	// Token: 0x0600B1B1 RID: 45489 RVA: 0x00348C99 File Offset: 0x00346E99
	public GameBudgetMode(string modeName, EGameBudgetMode gameBudgetMode) : base(modeName, gameBudgetMode)
	{
	}

	// Token: 0x17001227 RID: 4647
	// (get) Token: 0x0600B1B2 RID: 45490 RVA: 0x00348CAE File Offset: 0x00346EAE
	public virtual bool AllowExternalCenter
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600B1B3 RID: 45491 RVA: 0x00348CB1 File Offset: 0x00346EB1
	protected void Active(string name, Action apply, Action revert)
	{
		this.Effects.Add(new GameBudgetModeEffect(name, EGameBudgetEffectKind.Active, apply, revert));
	}

	// Token: 0x0600B1B4 RID: 45492 RVA: 0x00348CC7 File Offset: 0x00346EC7
	protected void Persistent(string name, Action apply, Action revert)
	{
		this.Effects.Add(new GameBudgetModeEffect(name, EGameBudgetEffectKind.Persistent, apply, revert));
	}

	// Token: 0x0600B1B5 RID: 45493 RVA: 0x00348CDD File Offset: 0x00346EDD
	public void EnterMode()
	{
		this.ApplyEffects();
		this.OnModeEnter();
	}

	// Token: 0x0600B1B6 RID: 45494 RVA: 0x00348CEB File Offset: 0x00346EEB
	public void SuspendMode()
	{
		this.OnModeSuspend();
		this.RevertEffects(EGameBudgetEffectKind.Active);
	}

	// Token: 0x0600B1B7 RID: 45495 RVA: 0x00348CFA File Offset: 0x00346EFA
	public void ResumeMode()
	{
		this.ApplyEffects();
		this.OnModeResume();
	}

	// Token: 0x0600B1B8 RID: 45496 RVA: 0x00348D08 File Offset: 0x00346F08
	public void TerminateMode()
	{
		this.OnModeExit();
		this.RevertEffects(EGameBudgetEffectKind.Active);
		this.RevertEffects(EGameBudgetEffectKind.Persistent);
	}

	// Token: 0x0600B1B9 RID: 45497 RVA: 0x00348D20 File Offset: 0x00346F20
	private void ApplyEffects()
	{
		foreach (GameBudgetModeEffect gameBudgetModeEffect in this.Effects)
		{
			if (!gameBudgetModeEffect.Held)
			{
				gameBudgetModeEffect.Held = true;
				gameBudgetModeEffect.Apply();
			}
		}
	}

	// Token: 0x0600B1BA RID: 45498 RVA: 0x00348D88 File Offset: 0x00346F88
	private void RevertEffects(EGameBudgetEffectKind kind)
	{
		for (int i = this.Effects.Count - 1; i >= 0; i--)
		{
			GameBudgetModeEffect gameBudgetModeEffect = this.Effects[i];
			if (gameBudgetModeEffect.Kind == kind && gameBudgetModeEffect.Held)
			{
				gameBudgetModeEffect.Held = false;
				gameBudgetModeEffect.Revert();
			}
		}
	}

	// Token: 0x0600B1BB RID: 45499 RVA: 0x00348DDD File Offset: 0x00346FDD
	public virtual void OnModeEnter()
	{
	}

	// Token: 0x0600B1BC RID: 45500 RVA: 0x00348DDF File Offset: 0x00346FDF
	public virtual void OnModeSuspend()
	{
	}

	// Token: 0x0600B1BD RID: 45501 RVA: 0x00348DE1 File Offset: 0x00346FE1
	public virtual void OnModeResume()
	{
	}

	// Token: 0x0600B1BE RID: 45502 RVA: 0x00348DE3 File Offset: 0x00346FE3
	public virtual void OnModeExit()
	{
	}

	// Token: 0x0400669C RID: 26268
	private readonly List<GameBudgetModeEffect> Effects = new List<GameBudgetModeEffect>();

	// Token: 0x0400669D RID: 26269
	internal long LatestTokenId;
}
