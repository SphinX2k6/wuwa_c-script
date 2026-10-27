using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200143C RID: 5180
internal class AdventureTag : UiPanelBase
{
	// Token: 0x0600924A RID: 37450 RVA: 0x001F4BA0 File Offset: 0x001F2DA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600924B RID: 37451 RVA: 0x001F4BDC File Offset: 0x001F2DDC
	public void RefreshItem(bool isActivity)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(isActivity ? "SP_TagFrameBgOrange" : "SP_TagFrameBgYellow");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isActivity ? "Regress_Adventure_Tag_Activity" : "Regress_Adventure_Tag_PreOpen", Array.Empty<object>());
	}
}
