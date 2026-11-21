using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000765 RID: 1893
public class SevenHillsUnlockTipView : UiViewBase
{
	// Token: 0x06005717 RID: 22295 RVA: 0x001C9229 File Offset: 0x001C7429
	[NullableContext(1)]
	public SevenHillsUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x001C9232 File Offset: 0x001C7432
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
