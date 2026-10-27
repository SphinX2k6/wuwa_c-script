using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012EB RID: 4843
public class ActivityUnlockTipMoonChasingView : UiViewBase
{
	// Token: 0x060085D1 RID: 34257 RVA: 0x001C83DA File Offset: 0x001C65DA
	[NullableContext(1)]
	public ActivityUnlockTipMoonChasingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060085D2 RID: 34258 RVA: 0x001C83E3 File Offset: 0x001C65E3
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
