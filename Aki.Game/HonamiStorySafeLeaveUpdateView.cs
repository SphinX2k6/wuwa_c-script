using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001EE8 RID: 7912
public class HonamiStorySafeLeaveUpdateView : UiViewBase
{
	// Token: 0x0600F39E RID: 62366 RVA: 0x003ABED3 File Offset: 0x003AA0D3
	[NullableContext(1)]
	public HonamiStorySafeLeaveUpdateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F39F RID: 62367 RVA: 0x003ABEDC File Offset: 0x003AA0DC
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
