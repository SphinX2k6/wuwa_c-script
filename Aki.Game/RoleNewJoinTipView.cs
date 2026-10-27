using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020028F2 RID: 10482
public class RoleNewJoinTipView : UiViewBase
{
	// Token: 0x06015A3C RID: 88636 RVA: 0x00576400 File Offset: 0x00574600
	[NullableContext(1)]
	public RoleNewJoinTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015A3D RID: 88637 RVA: 0x00576409 File Offset: 0x00574609
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06015A3E RID: 88638 RVA: 0x00576424 File Offset: 0x00574624
	protected override void OnAfterPlayStartSequence()
	{
		int num = (int)(this.OpenParam ?? 0);
		UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RoleNewJoinView, num, null, true);
	}
}
