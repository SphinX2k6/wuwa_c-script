using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020013AA RID: 5034
public class HonamiStorySafeLeaveUpdateView : UiViewBase
{
	// Token: 0x0600C7BD RID: 51133 RVA: 0x003B79CF File Offset: 0x003B5BCF
	[NullableContext(1)]
	public HonamiStorySafeLeaveUpdateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7BE RID: 51134 RVA: 0x003B79D8 File Offset: 0x003B5BD8
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
