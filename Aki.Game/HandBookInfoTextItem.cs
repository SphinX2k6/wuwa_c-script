using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012CA RID: 4810
public class HandBookInfoTextItem : UiPanelBase
{
	// Token: 0x0600BDE5 RID: 48613 RVA: 0x00380A99 File Offset: 0x0037EC99
	[NullableContext(1)]
	public HandBookInfoTextItem(string content, UUIItem uiItem)
	{
		this.Content = content;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BDE6 RID: 48614 RVA: 0x00380AB5 File Offset: 0x0037ECB5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600BDE7 RID: 48615 RVA: 0x00380AD8 File Offset: 0x0037ECD8
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(this.Content, true);
	}

	// Token: 0x04006D5E RID: 27998
	[Nullable(1)]
	public string Content;

	// Token: 0x0200754B RID: 30027
	private class EHandBookInfoTextItemDefine
	{
		// Token: 0x040261A3 RID: 156067
		public const int TitleText = 0;
	}
}
