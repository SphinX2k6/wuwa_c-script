using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000669 RID: 1641
public class BlackCoastUnlockTipView : UiViewBase
{
	// Token: 0x06004BE5 RID: 19429 RVA: 0x0019C379 File Offset: 0x0019A579
	[NullableContext(1)]
	public BlackCoastUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004BE6 RID: 19430 RVA: 0x0019C382 File Offset: 0x0019A582
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
