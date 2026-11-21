using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020005C6 RID: 1478
public class AvignonUnlockTipView : UiViewBase
{
	// Token: 0x060045E3 RID: 17891 RVA: 0x0017EBEB File Offset: 0x0017CDEB
	[NullableContext(1)]
	public AvignonUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x0017EBF4 File Offset: 0x0017CDF4
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
