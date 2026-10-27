using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002728 RID: 10024
public class RacingBetsDangoActivityOpenTips : UiViewBase
{
	// Token: 0x060148D3 RID: 84179 RVA: 0x00531709 File Offset: 0x0052F909
	[NullableContext(1)]
	public RacingBetsDangoActivityOpenTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148D4 RID: 84180 RVA: 0x00531712 File Offset: 0x0052F912
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
