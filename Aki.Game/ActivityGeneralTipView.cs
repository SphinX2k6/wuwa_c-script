using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000B3A RID: 2874
public class ActivityGeneralTipView : UiViewBase
{
	// Token: 0x060076E5 RID: 30437 RVA: 0x0024A480 File Offset: 0x00248680
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x060076E6 RID: 30438 RVA: 0x0024A489 File Offset: 0x00248689
	[NullableContext(1)]
	public ActivityGeneralTipView(UiViewInfo info) : base(info)
	{
	}
}
