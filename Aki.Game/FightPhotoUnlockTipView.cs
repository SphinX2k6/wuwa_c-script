using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200127E RID: 4734
public class FightPhotoUnlockTipView : UiViewBase
{
	// Token: 0x06008141 RID: 33089 RVA: 0x001B6A23 File Offset: 0x001B4C23
	[NullableContext(1)]
	public FightPhotoUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008142 RID: 33090 RVA: 0x001B6A2C File Offset: 0x001B4C2C
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
