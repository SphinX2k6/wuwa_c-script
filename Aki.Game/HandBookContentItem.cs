using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DEC RID: 7660
public class HandBookContentItem : UiPanelBase
{
	// Token: 0x0600E96A RID: 59754 RVA: 0x00373A7B File Offset: 0x00371C7B
	[NullableContext(1)]
	public HandBookContentItem(HandBookContentItemData handBookContentItemData, UUIItem uiItem)
	{
		this.HandBookContentItemData = handBookContentItemData;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600E96B RID: 59755 RVA: 0x00373A97 File Offset: 0x00371C97
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600E96C RID: 59756 RVA: 0x00373AD0 File Offset: 0x00371CD0
	protected override void OnStart()
	{
		if (this.HandBookContentItemData == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (!string.IsNullOrEmpty(this.HandBookContentItemData.Title))
		{
			text.SetUIActive(true);
			text.SetText(this.HandBookContentItemData.Title, true);
		}
		else
		{
			text.SetUIActive(false);
		}
		UUIText text2 = base.GetText(1);
		if (!string.IsNullOrEmpty(this.HandBookContentItemData.Desc))
		{
			text2.SetUIActive(true);
			text2.SetText(this.HandBookContentItemData.Desc, true);
			return;
		}
		text2.SetUIActive(false);
	}

	// Token: 0x0600E96D RID: 59757 RVA: 0x00373B5D File Offset: 0x00371D5D
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x04006C16 RID: 27670
	[Nullable(1)]
	public HandBookContentItemData HandBookContentItemData;

	// Token: 0x020083BC RID: 33724
	private class EHandBookContentItemDefine
	{
		// Token: 0x0402AE61 RID: 175713
		public const int TitleText = 0;

		// Token: 0x0402AE62 RID: 175714
		public const int ContentText = 1;
	}
}
