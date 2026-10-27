using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029BC RID: 10684
public class ShipTowerPassBuffShowItem : GridProxyAbstract<TItem>
{
	// Token: 0x0601626A RID: 90730 RVA: 0x0059A0E4 File Offset: 0x005982E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601626B RID: 90731 RVA: 0x0059A13E File Offset: 0x0059833E
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0601626C RID: 90732 RVA: 0x0059A148 File Offset: 0x00598348
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

	// Token: 0x0400A4FE RID: 42238
	private TItem ItemData;

	// Token: 0x02008FD5 RID: 36821
	private static class EChildType
	{
		// Token: 0x0402E94E RID: 190798
		public const int TextureIcon = 0;

		// Token: 0x0402E94F RID: 190799
		public const int TxtName = 1;

		// Token: 0x0402E950 RID: 190800
		public const int TxtDesc = 2;
	}
}
