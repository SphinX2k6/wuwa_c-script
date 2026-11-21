using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000732 RID: 1842
public class FightPhotoUnlockTipView : UiViewBase
{
	// Token: 0x060054D8 RID: 21720 RVA: 0x001BF6F3 File Offset: 0x001BD8F3
	[NullableContext(1)]
	public FightPhotoUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x001BF6FC File Offset: 0x001BD8FC
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
