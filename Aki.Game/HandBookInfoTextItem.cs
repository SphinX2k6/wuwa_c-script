using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E08 RID: 7688
public class HandBookInfoTextItem : UiPanelBase
{
	// Token: 0x0600E9C6 RID: 59846 RVA: 0x00374D91 File Offset: 0x00372F91
	[NullableContext(1)]
	public HandBookInfoTextItem(string content, UUIItem uiItem)
	{
		this.Content = content;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600E9C7 RID: 59847 RVA: 0x00374DAD File Offset: 0x00372FAD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600E9C8 RID: 59848 RVA: 0x00374DD0 File Offset: 0x00372FD0
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(this.Content, true);
	}

	// Token: 0x04006C7D RID: 27773
	[Nullable(1)]
	public string Content;

	// Token: 0x020083C6 RID: 33734
	private class EHandBookInfoTextItemDefine
	{
		// Token: 0x0402AE80 RID: 175744
		public const int TitleText = 0;
	}
}
