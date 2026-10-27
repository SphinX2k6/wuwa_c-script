using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001682 RID: 5762
public class ActivityGeneralTipView : UiViewBase
{
	// Token: 0x0600A307 RID: 41735 RVA: 0x002404F4 File Offset: 0x0023E6F4
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A308 RID: 41736 RVA: 0x002404FD File Offset: 0x0023E6FD
	[NullableContext(1)]
	public ActivityGeneralTipView(UiViewInfo info) : base(info)
	{
	}
}
