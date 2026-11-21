using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001E6D RID: 7789
public class RoleNewJoinTipView : UiViewBase
{
	// Token: 0x06013440 RID: 78912 RVA: 0x005A12D4 File Offset: 0x0059F4D4
	[NullableContext(1)]
	public RoleNewJoinTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013441 RID: 78913 RVA: 0x005A12DD File Offset: 0x0059F4DD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06013442 RID: 78914 RVA: 0x005A12F8 File Offset: 0x0059F4F8
	protected override void OnAfterPlayStartSequence()
	{
		int num = (int)(this.OpenParam ?? 0);
		UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RoleNewJoinView, num, null, true);
	}
}
