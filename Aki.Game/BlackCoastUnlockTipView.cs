using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020011B5 RID: 4533
public class BlackCoastUnlockTipView : UiViewBase
{
	// Token: 0x0600784E RID: 30798 RVA: 0x001937AD File Offset: 0x001919AD
	[NullableContext(1)]
	public BlackCoastUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600784F RID: 30799 RVA: 0x001937B6 File Offset: 0x001919B6
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
