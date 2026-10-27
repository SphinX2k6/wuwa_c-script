using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019B1 RID: 6577
public class CommonTabTitle : UiPanelBase
{
	// Token: 0x0600BFD7 RID: 49111 RVA: 0x002B47A4 File Offset: 0x002B29A4
	[NullableContext(1)]
	public CommonTabTitle(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BFD8 RID: 49112 RVA: 0x002B47B9 File Offset: 0x002B29B9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600BFD9 RID: 49113 RVA: 0x002B47F4 File Offset: 0x002B29F4
	[NullableContext(1)]
	public void UpdateIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x002B481C File Offset: 0x002B2A1C
	[NullableContext(2)]
	public void UpdateTitle(CommonTabTitleData titleData)
	{
		UUIText text = base.GetText(1);
		if (titleData == null)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		if (!string.IsNullOrEmpty(titleData.RawText))
		{
			text.SetText(titleData.RawText, true);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, titleData.TextId, titleData.Args);
	}

	// Token: 0x02007ED6 RID: 32470
	private class ECommonTabTitle
	{
		// Token: 0x0402972D RID: 169773
		public const int Icon = 0;

		// Token: 0x0402972E RID: 169774
		public const int Title = 1;
	}
}
