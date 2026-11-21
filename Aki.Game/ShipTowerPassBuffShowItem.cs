using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F37 RID: 7991
public class ShipTowerPassBuffShowItem : GridProxyAbstract<TItem>
{
	// Token: 0x06013C70 RID: 81008 RVA: 0x005C5070 File Offset: 0x005C3270
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013C71 RID: 81009 RVA: 0x005C50CA File Offset: 0x005C32CA
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013C72 RID: 81010 RVA: 0x005C50D4 File Offset: 0x005C32D4
	public void Refresh(TItem data)
	{
		this.ItemData = data;
		ItemInfo? config = ItemConfig.Instance.GetConfig(this.ItemData.ItemData.ItemId);
		if (config == null)
		{
			return;
		}
		ItemInfo value = config.Value;
		QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(value.QualityId);
		if (qualityConfig == null)
		{
			return;
		}
		QualityInfo value2 = qualityConfig.Value;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(value.Name);
			text.SetColor(FColor.FromHex(value2.DropColor ?? ""));
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.ShowTextNew(value.AttributesDescription);
		}
		base.SetTextureByPath(value.Icon ?? "", base.GetTexture(0), null, null);
	}

	// Token: 0x0400A8E8 RID: 43240
	private TItem ItemData;

	// Token: 0x0200821D RID: 33309
	private static class EChildType
	{
		// Token: 0x0402A04B RID: 172107
		public const int TextureIcon = 0;

		// Token: 0x0402A04C RID: 172108
		public const int TxtName = 1;

		// Token: 0x0402A04D RID: 172109
		public const int TxtDesc = 2;
	}
}
