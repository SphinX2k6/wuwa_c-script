using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001112 RID: 4370
public class AvignonUnlockTipView : UiViewBase
{
	// Token: 0x0600724D RID: 29261 RVA: 0x0017622F File Offset: 0x0017442F
	[NullableContext(1)]
	public AvignonUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600724E RID: 29262 RVA: 0x00176238 File Offset: 0x00174438
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
