using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002AFB RID: 11003
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsAttributeItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x06016E2D RID: 93741 RVA: 0x005CE5A8 File Offset: 0x005CC7A8
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

	// Token: 0x06016E2E RID: 93742 RVA: 0x005CE630 File Offset: 0x005CC830
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId);
		this.SetTextByTextId(propertyConfig.Value.Name);
		this.SetIcon(propertyConfig.Value.Icon);
		this.SetValue(data.Value, propertyConfig.Value.IsPercent, data.IsAddition.GetValueOrDefault());
		this.SetRecommend(data.IsRecommend);
		this.SetBgVisible(gridIndex % 2 == 0);
	}

	// Token: 0x06016E2F RID: 93743 RVA: 0x005CE6BC File Offset: 0x005CC8BC
	public void SetIcon(string icon)
	{
		base.SetTextureByPath(icon, base.GetTexture(2), null, null);
	}

	// Token: 0x06016E30 RID: 93744 RVA: 0x005CE6E1 File Offset: 0x005CC8E1
	public void SetRecommend(bool isRecommend)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isRecommend);
	}

	// Token: 0x06016E31 RID: 93745 RVA: 0x005CE6F8 File Offset: 0x005CC8F8
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

	// Token: 0x06016E32 RID: 93746 RVA: 0x005CE77B File Offset: 0x005CC97B
	public void SetTextByTextId(string textId)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x06016E33 RID: 93747 RVA: 0x005CE78F File Offset: 0x005CC98F
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
