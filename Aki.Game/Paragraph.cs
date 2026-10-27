using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E55 RID: 7765
public class Paragraph : UiPanelBase
{
	// Token: 0x0600EC15 RID: 60437 RVA: 0x00380B30 File Offset: 0x0037ED30
	[NullableContext(2)]
	public Paragraph(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			base.CreateThenShowByActor(commonItemActor, null);
		}
	}

	// Token: 0x0600EC16 RID: 60438 RVA: 0x00380B44 File Offset: 0x0037ED44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600EC17 RID: 60439 RVA: 0x00380BB0 File Offset: 0x0037EDB0
	public void Refresh(HelpText helpTextConfig)
	{
		if (helpTextConfig.Picture == string.Empty)
		{
			base.GetTexture(0).SetUIActive(false);
		}
		else
		{
			base.SetTextureByPath(helpTextConfig.Picture, base.GetTexture(0), null, null);
		}
		if (string.IsNullOrEmpty(helpTextConfig.Content))
		{
			base.GetText(1).SetUIActive(false);
			return;
		}
		base.GetText(1).ShowTextNew(helpTextConfig.Content);
	}

	// Token: 0x02008408 RID: 33800
	private enum EParagraphComponents
	{
		// Token: 0x0402AF9E RID: 176030
		Image,
		// Token: 0x0402AF9F RID: 176031
		Text
	}
}
