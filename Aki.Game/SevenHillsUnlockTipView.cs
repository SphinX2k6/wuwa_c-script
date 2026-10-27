using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012B1 RID: 4785
public class SevenHillsUnlockTipView : UiViewBase
{
	// Token: 0x06008380 RID: 33664 RVA: 0x001C0499 File Offset: 0x001BE699
	[NullableContext(1)]
	public SevenHillsUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008381 RID: 33665 RVA: 0x001C04A2 File Offset: 0x001BE6A2
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
