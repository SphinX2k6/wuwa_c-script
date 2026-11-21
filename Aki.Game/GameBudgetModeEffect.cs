using System;
using System.Runtime.CompilerServices;

// Token: 0x0200116A RID: 4458
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetModeEffect
{
	// Token: 0x0600B1AE RID: 45486 RVA: 0x00348C58 File Offset: 0x00346E58
	public GameBudgetModeEffect(string name, EGameBudgetEffectKind kind, Action apply, Action revert)
	{
		this.Name = name;
		this.Kind = kind;
		this.Apply = apply;
		this.Revert = revert;
	}

	// Token: 0x04006695 RID: 26261
	public readonly string Name;

	// Token: 0x04006696 RID: 26262
	public readonly EGameBudgetEffectKind Kind;

	// Token: 0x04006697 RID: 26263
	public readonly Action Apply;

	// Token: 0x04006698 RID: 26264
	public readonly Action Revert;

	// Token: 0x04006699 RID: 26265
	public bool Held;
}
