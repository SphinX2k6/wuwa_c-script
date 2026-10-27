using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013D2 RID: 5074
internal class NewPlayerAdventureV2Tag : UiPanelBase
{
	// Token: 0x06008F2D RID: 36653 RVA: 0x001EF328 File Offset: 0x001ED528
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06008F2E RID: 36654 RVA: 0x001EF364 File Offset: 0x001ED564
	public void RefreshItem(bool isActivity)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(isActivity ? "SP_TagFrameBgOrange" : "SP_TagFrameBgYellow");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isActivity ? "Regress_Adventure_Tag_Activity" : "Regress_Adventure_Tag_PreOpen", Array.Empty<object>());
	}
}
