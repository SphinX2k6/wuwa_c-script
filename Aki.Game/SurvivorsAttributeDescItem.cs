using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020020A7 RID: 8359
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class SurvivorsAttributeDescItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x0601493A RID: 84282 RVA: 0x005FF38C File Offset: 0x005FD58C
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

	// Token: 0x0601493B RID: 84283 RVA: 0x005FF440 File Offset: 0x005FD640
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		SurvivorsProperty value = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId).Value;
		this.SetTextByTextId(value.Name);
		this.SetIcon(value.Icon);
		this.SetValue(data.Value, value.IsPercent);
		this.SetBgVisible(gridIndex % 2 == 0);
	}

	// Token: 0x0601493C RID: 84284 RVA: 0x005FF4A0 File Offset: 0x005FD6A0
	public void SetIcon(string icon)
	{
		base.SetTextureByPath(icon, base.GetTexture(4), null, null);
	}

	// Token: 0x0601493D RID: 84285 RVA: 0x005FF4C8 File Offset: 0x005FD6C8
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

	// Token: 0x0601493E RID: 84286 RVA: 0x005FF52D File Offset: 0x005FD72D
	public void SetTextByTextId(string textId)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x0601493F RID: 84287 RVA: 0x005FF541 File Offset: 0x005FD741
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
