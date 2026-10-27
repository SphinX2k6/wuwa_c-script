using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E48 RID: 7752
internal class WeaponHandBookTitleItem : UiPanelBase
{
	// Token: 0x0600EBC1 RID: 60353 RVA: 0x0037F262 File Offset: 0x0037D462
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600EBC2 RID: 60354 RVA: 0x0037F285 File Offset: 0x0037D485
	[NullableContext(1)]
	public void Update(string titleText)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(titleText, true);
	}

	// Token: 0x020083FA RID: 33786
	private class EWeaponHandBookTitleItemDefine
	{
		// Token: 0x0402AF61 RID: 175969
		public const int TitleText = 0;
	}
}
