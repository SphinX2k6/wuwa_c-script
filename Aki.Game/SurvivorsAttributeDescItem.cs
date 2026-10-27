using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B2B RID: 11051
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class SurvivorsAttributeDescItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x06016F09 RID: 93961 RVA: 0x005D2818 File Offset: 0x005D0A18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06016F0A RID: 93962 RVA: 0x005D28CC File Offset: 0x005D0ACC
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		SurvivorsProperty value = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId).Value;
		this.SetTextByTextId(value.Name);
		this.SetIcon(value.Icon);
		this.SetValue(data.Value, value.IsPercent);
		this.SetBgVisible(gridIndex % 2 == 0);
	}

	// Token: 0x06016F0B RID: 93963 RVA: 0x005D292C File Offset: 0x005D0B2C
	public void SetIcon(string icon)
	{
		base.SetTextureByPath(icon, base.GetTexture(4), null, null);
	}

	// Token: 0x06016F0C RID: 93964 RVA: 0x005D2954 File Offset: 0x005D0B54
	public void SetValue(double value, bool isPercent = false)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			if (isPercent)
			{
				text.SetText(Math.Round(value * 100.0, 2).ToString() + "%", true);
				return;
			}
			text.SetText(Math.Round(value, 6).ToString() ?? "", true);
		}
	}

	// Token: 0x06016F0D RID: 93965 RVA: 0x005D29B9 File Offset: 0x005D0BB9
	public void SetTextByTextId(string textId)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x06016F0E RID: 93966 RVA: 0x005D29CD File Offset: 0x005D0BCD
	public void SetBgVisible(bool visible)
	{
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(visible);
	}
}
