using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001EF4 RID: 7924
public class HonamiStoryUnlockTipView : UiViewBase
{
	// Token: 0x0600F3E2 RID: 62434 RVA: 0x003ACE13 File Offset: 0x003AB013
	[NullableContext(1)]
	public HonamiStoryUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3E3 RID: 62435 RVA: 0x003ACE1C File Offset: 0x003AB01C
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
