using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020008F0 RID: 2288
internal class AdventureTag : UiPanelBase
{
	// Token: 0x060065DF RID: 26079 RVA: 0x001FD6DC File Offset: 0x001FB8DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060065E0 RID: 26080 RVA: 0x001FD718 File Offset: 0x001FB918
	public void RefreshItem(bool isActivity)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(isActivity ? "SP_TagFrameBgOrange" : "SP_TagFrameBgYellow");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isActivity ? "Regress_Adventure_Tag_Activity" : "Regress_Adventure_Tag_PreOpen", Array.Empty<object>());
	}
}
