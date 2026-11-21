using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000E2E RID: 3630
public class SmallItemGridDangoPluginIconComponent : SmallItemGridComponent
{
	// Token: 0x060092CB RID: 37579 RVA: 0x002BD8D8 File Offset: 0x002BBAD8
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

	// Token: 0x060092CC RID: 37580 RVA: 0x002BD941 File Offset: 0x002BBB41
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x060092CD RID: 37581 RVA: 0x002BD944 File Offset: 0x002BBB44
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemChipIcon";
	}

	// Token: 0x060092CE RID: 37582 RVA: 0x002BD94B File Offset: 0x002BBB4B
	[NullableContext(1)]
	public void RefreshByInfo(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		this.OnRefresh(dangoPluginIconInfo);
	}

	// Token: 0x060092CF RID: 37583 RVA: 0x002BD954 File Offset: 0x002BBB54
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

	// Token: 0x0200704F RID: 28751
	private enum EChildType
	{
		// Token: 0x04024A36 RID: 150070
		TextureQuality,
		// Token: 0x04024A37 RID: 150071
		TextureMain
	}
}
