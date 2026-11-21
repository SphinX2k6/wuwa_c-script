using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012F4 RID: 4852
internal class MonsterHandBookTitleItem : UiPanelBase
{
	// Token: 0x0600BF22 RID: 48930 RVA: 0x00386A20 File Offset: 0x00384C20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600BF23 RID: 48931 RVA: 0x00386A43 File Offset: 0x00384C43
	[NullableContext(1)]
	public void Update(string titleText)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), titleText, Array.Empty<object>());
	}
}
