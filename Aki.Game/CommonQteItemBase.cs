using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001AFF RID: 6911
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonQteItemBase : UiPanelBase
{
	// Token: 0x06011343 RID: 70467
	public abstract void SetQteContext(CommonQteContextBase context);

	// Token: 0x06011344 RID: 70468
	public abstract void PlayQteStart();

	// Token: 0x06011345 RID: 70469
	public abstract void OnInputTest();

	// Token: 0x06011346 RID: 70470 RVA: 0x0050EB91 File Offset: 0x0050CD91
	public virtual void SetPreloadQte(int qteId)
	{
	}

	// Token: 0x06011347 RID: 70471
	public abstract void Reattach(CommonQteContextBase context);
}
