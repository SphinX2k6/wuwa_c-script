using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200075A RID: 1882
public class LongShanUnlockView : UiViewBase
{
	// Token: 0x0600568C RID: 22156 RVA: 0x001C65E9 File Offset: 0x001C47E9
	[NullableContext(1)]
	public LongShanUnlockView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600568D RID: 22157 RVA: 0x001C65F2 File Offset: 0x001C47F2
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
