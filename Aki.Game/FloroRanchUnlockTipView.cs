using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001B7B RID: 7035
public class FloroRanchUnlockTipView : UiViewBase
{
	// Token: 0x0600D155 RID: 53589 RVA: 0x002FF415 File Offset: 0x002FD615
	[NullableContext(1)]
	public FloroRanchUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D156 RID: 53590 RVA: 0x002FF41E File Offset: 0x002FD61E
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
