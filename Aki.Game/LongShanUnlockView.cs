using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012A6 RID: 4774
public class LongShanUnlockView : UiViewBase
{
	// Token: 0x060082F5 RID: 33525 RVA: 0x001BD859 File Offset: 0x001BBA59
	[NullableContext(1)]
	public LongShanUnlockView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060082F6 RID: 33526 RVA: 0x001BD862 File Offset: 0x001BBA62
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
