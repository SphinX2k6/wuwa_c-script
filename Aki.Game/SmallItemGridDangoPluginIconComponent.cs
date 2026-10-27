using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001971 RID: 6513
public class SmallItemGridDangoPluginIconComponent : SmallItemGridComponent
{
	// Token: 0x0600BEC3 RID: 48835 RVA: 0x002B2954 File Offset: 0x002B0B54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BEC4 RID: 48836 RVA: 0x002B29BD File Offset: 0x002B0BBD
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x0600BEC5 RID: 48837 RVA: 0x002B29C0 File Offset: 0x002B0BC0
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemChipIcon";
	}

	// Token: 0x0600BEC6 RID: 48838 RVA: 0x002B29C7 File Offset: 0x002B0BC7
	[NullableContext(1)]
	public void RefreshByInfo(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		this.OnRefresh(dangoPluginIconInfo);
	}

	// Token: 0x0600BEC7 RID: 48839 RVA: 0x002B29D0 File Offset: 0x002B0BD0
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		int pluginItemId = ((IDangoPluginIconInfo)tempData).PluginItemId;
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(pluginItemId);
		string pluginItemQualityIcon = DangoAbyssModel.Instance.GetPluginItemQualityIcon(pluginItemId);
		if (dangoItemById == null || pluginItemQualityIcon == "")
		{
			this.SetActive(false);
			return;
		}
		int slotType = dangoItemById.Value.SlotType;
		UUITexture texture = base.GetTexture(1);
		int num;
		if (DangoAbyssDefine.iconSizeBySlotType.TryGetValue((DangoAbyssDefine.ESlotType)slotType, out num))
		{
			texture.SetWidth((float)num);
			texture.SetHeight((float)num);
		}
		base.SetTextureByPath(pluginItemQualityIcon, base.GetTexture(0), null, null);
		base.SetTextureByPath(dangoItemById.Value.IconMiddle, texture, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007EC0 RID: 32448
	private enum EChildType
	{
		// Token: 0x040296F9 RID: 169721
		TextureQuality,
		// Token: 0x040296FA RID: 169722
		TextureMain
	}
}
