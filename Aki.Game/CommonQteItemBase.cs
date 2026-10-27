using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002614 RID: 9748
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonQteItemBase : UiPanelBase
{
	// Token: 0x06013E61 RID: 81505
	public abstract void SetQteContext(CommonQteContextBase context);

	// Token: 0x06013E62 RID: 81506
	public abstract void PlayQteStart();

	// Token: 0x06013E63 RID: 81507
	public abstract void OnInputTest();

	// Token: 0x06013E64 RID: 81508 RVA: 0x004FFD1D File Offset: 0x004FDF1D
	public virtual void SetPreloadQte(int qteId)
	{
	}

	// Token: 0x06013E65 RID: 81509
	public abstract void Reattach(CommonQteContextBase context);
}
