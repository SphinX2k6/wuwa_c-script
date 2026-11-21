using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200130A RID: 4874
internal class WeaponHandBookTitleItem : UiPanelBase
{
	// Token: 0x0600BFE0 RID: 49120 RVA: 0x0038AEF2 File Offset: 0x003890F2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600BFE1 RID: 49121 RVA: 0x0038AF15 File Offset: 0x00389115
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

	// Token: 0x0200757F RID: 30079
	private class EWeaponHandBookTitleItemDefine
	{
		// Token: 0x04026285 RID: 156293
		public const int TitleText = 0;
	}
}
