using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001C13 RID: 7187
public class RacingBetsDangoActivityOpenTips : UiViewBase
{
	// Token: 0x06011DB5 RID: 73141 RVA: 0x00540421 File Offset: 0x0053E621
	[NullableContext(1)]
	public RacingBetsDangoActivityOpenTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DB6 RID: 73142 RVA: 0x0054042A File Offset: 0x0053E62A
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
