using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200079F RID: 1951
public class ActivityUnlockTipMoonChasingView : UiViewBase
{
	// Token: 0x0600596C RID: 22892 RVA: 0x001D1246 File Offset: 0x001CF446
	[NullableContext(1)]
	public ActivityUnlockTipMoonChasingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600596D RID: 22893 RVA: 0x001D124F File Offset: 0x001CF44F
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
