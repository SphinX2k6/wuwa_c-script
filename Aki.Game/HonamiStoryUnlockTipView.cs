using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020013B6 RID: 5046
public class HonamiStoryUnlockTipView : UiViewBase
{
	// Token: 0x0600C801 RID: 51201 RVA: 0x003B890F File Offset: 0x003B6B0F
	[NullableContext(1)]
	public HonamiStoryUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C802 RID: 51202 RVA: 0x003B8918 File Offset: 0x003B6B18
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
