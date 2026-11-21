using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000DC6 RID: 3526
public class MediumItemGridDangoPluginIconComponent : MediumItemGridComponent
{
	// Token: 0x06008FDA RID: 36826 RVA: 0x002B40B0 File Offset: 0x002B22B0
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

	// Token: 0x06008FDB RID: 36827 RVA: 0x002B4119 File Offset: 0x002B2319
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x06008FDC RID: 36828 RVA: 0x002B411C File Offset: 0x002B231C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemChipIcon";
	}

	// Token: 0x06008FDD RID: 36829 RVA: 0x002B4123 File Offset: 0x002B2323
	[NullableContext(1)]
	public void RefreshByInfo(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		this.OnRefresh(dangoPluginIconInfo);
	}

	// Token: 0x06008FDE RID: 36830 RVA: 0x002B412C File Offset: 0x002B232C
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

	// Token: 0x02007007 RID: 28679
	private class EChildType
	{
		// Token: 0x04024971 RID: 149873
		public const int TextureQuality = 0;

		// Token: 0x04024972 RID: 149874
		public const int TextureMain = 1;
	}
}
