using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200190D RID: 6413
public class MediumItemGridDangoPluginIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BBF0 RID: 48112 RVA: 0x002A9954 File Offset: 0x002A7B54
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

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x002A99BD File Offset: 0x002A7BBD
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x002A99C0 File Offset: 0x002A7BC0
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemChipIcon";
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x002A99C7 File Offset: 0x002A7BC7
	[NullableContext(1)]
	public void RefreshByInfo(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		this.OnRefresh(dangoPluginIconInfo);
	}

	// Token: 0x0600BBF4 RID: 48116 RVA: 0x002A99D0 File Offset: 0x002A7BD0
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IDangoPluginIconInfo dangoPluginIconInfo = data as IDangoPluginIconInfo;
		if (dangoPluginIconInfo == null)
		{
			return;
		}
		int pluginItemId = dangoPluginIconInfo.PluginItemId;
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
			if (texture != null)
			{
				texture.SetWidth((float)num);
			}
			if (texture != null)
			{
				texture.SetHeight((float)num);
			}
		}
		base.SetTextureByPath(pluginItemQualityIcon, base.GetTexture(0), null, null);
		base.SetTextureByPath(dangoItemById.Value.IconMiddle, texture, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007E80 RID: 32384
	private class EChildType
	{
		// Token: 0x04029645 RID: 169541
		public const int TextureQuality = 0;

		// Token: 0x04029646 RID: 169542
		public const int TextureMain = 1;
	}
}
