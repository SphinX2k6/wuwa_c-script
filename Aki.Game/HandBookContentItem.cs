using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012AE RID: 4782
public class HandBookContentItem : UiPanelBase
{
	// Token: 0x0600BD89 RID: 48521 RVA: 0x0037F783 File Offset: 0x0037D983
	[NullableContext(1)]
	public HandBookContentItem(HandBookContentItemData handBookContentItemData, UUIItem uiItem)
	{
		this.HandBookContentItemData = handBookContentItemData;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BD8A RID: 48522 RVA: 0x0037F79F File Offset: 0x0037D99F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600BD8B RID: 48523 RVA: 0x0037F7D8 File Offset: 0x0037D9D8
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

	// Token: 0x0600BD8C RID: 48524 RVA: 0x0037F865 File Offset: 0x0037DA65
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x04006CF7 RID: 27895
	[Nullable(1)]
	public HandBookContentItemData HandBookContentItemData;

	// Token: 0x02007541 RID: 30017
	private class EHandBookContentItemDefine
	{
		// Token: 0x04026184 RID: 156036
		public const int TitleText = 0;

		// Token: 0x04026185 RID: 156037
		public const int ContentText = 1;
	}
}
