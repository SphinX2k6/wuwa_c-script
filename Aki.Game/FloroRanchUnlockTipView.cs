using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200103A RID: 4154
public class FloroRanchUnlockTipView : UiViewBase
{
	// Token: 0x0600A566 RID: 42342 RVA: 0x0030A4ED File Offset: 0x003086ED
	[NullableContext(1)]
	public FloroRanchUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A567 RID: 42343 RVA: 0x0030A4F6 File Offset: 0x003086F6
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
