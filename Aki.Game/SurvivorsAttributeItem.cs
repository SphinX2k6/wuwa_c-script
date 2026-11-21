using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002077 RID: 8311
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsAttributeItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x0601485E RID: 84062 RVA: 0x005FB128 File Offset: 0x005F9328
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x0601485F RID: 84063 RVA: 0x005FB1B0 File Offset: 0x005F93B0
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId);
		this.SetTextByTextId(propertyConfig.Value.Name);
		this.SetIcon(propertyConfig.Value.Icon);
		this.SetValue(data.Value, propertyConfig.Value.IsPercent, data.IsAddition.GetValueOrDefault());
		this.SetRecommend(data.IsRecommend);
		this.SetBgVisible(gridIndex % 2 == 0);
	}

	// Token: 0x06014860 RID: 84064 RVA: 0x005FB23C File Offset: 0x005F943C
	public void SetIcon(string icon)
	{
		base.SetTextureByPath(icon, base.GetTexture(2), null, null);
	}

	// Token: 0x06014861 RID: 84065 RVA: 0x005FB261 File Offset: 0x005F9461
	public void SetRecommend(bool isRecommend)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isRecommend);
	}

	// Token: 0x06014862 RID: 84066 RVA: 0x005FB278 File Offset: 0x005F9478
	public void SetValue(double value, bool isPercent = false, bool isAddition = false)
	{
		if (isPercent)
		{
			value *= 100.0;
		}
		string text = (Math.Abs(value - Math.Round(value)) < 1E-09) ? Math.Round(value).ToString() : value.ToString("F2");
		if (isPercent)
		{
			text += "%";
		}
		if (isAddition)
		{
			text = "+" + text;
		}
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06014863 RID: 84067 RVA: 0x005FB2FB File Offset: 0x005F94FB
	public void SetTextByTextId(string textId)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x06014864 RID: 84068 RVA: 0x005FB30F File Offset: 0x005F950F
	public void SetBgVisible(bool visible)
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(visible);
	}
}
