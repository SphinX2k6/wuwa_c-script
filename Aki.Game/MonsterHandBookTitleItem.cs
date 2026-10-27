using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E32 RID: 7730
internal class MonsterHandBookTitleItem : UiPanelBase
{
	// Token: 0x0600EB03 RID: 60163 RVA: 0x0037AD94 File Offset: 0x00378F94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600EB04 RID: 60164 RVA: 0x0037ADB7 File Offset: 0x00378FB7
	[NullableContext(1)]
	public void Update(string titleText)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), titleText, Array.Empty<object>());
	}
}
