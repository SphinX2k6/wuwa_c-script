using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001317 RID: 4887
public class Paragraph : UiPanelBase
{
	// Token: 0x0600C034 RID: 49204 RVA: 0x0038C7E0 File Offset: 0x0038A9E0
	[NullableContext(2)]
	public Paragraph(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			base.CreateThenShowByActor(commonItemActor, null);
		}
	}

	// Token: 0x0600C035 RID: 49205 RVA: 0x0038C7F4 File Offset: 0x0038A9F4
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

	// Token: 0x0600C036 RID: 49206 RVA: 0x0038C860 File Offset: 0x0038AA60
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

	// Token: 0x0200758D RID: 30093
	private enum EParagraphComponents
	{
		// Token: 0x040262C2 RID: 156354
		Image,
		// Token: 0x040262C3 RID: 156355
		Text
	}
}
