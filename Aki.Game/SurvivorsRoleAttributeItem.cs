using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B37 RID: 11063
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRoleAttributeItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x06016F54 RID: 94036 RVA: 0x005D396F File Offset: 0x005D1B6F
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x06016F55 RID: 94037 RVA: 0x005D3978 File Offset: 0x005D1B78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x06016F56 RID: 94038 RVA: 0x005D3A56 File Offset: 0x005D1C56
	protected override void OnStart()
	{
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06016F57 RID: 94039 RVA: 0x005D3A90 File Offset: 0x005D1C90
	public void Update(ISurvivorsAttributeUiData data)
	{
		base.GetSprite(1).useChangeColor = (base.GridIndex % 2 == 1);
		SurvivorsProperty value = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId).Value;
		base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(value.Name);
		this.SetValue(data.Value, value.IsPercent);
	}

	// Token: 0x06016F58 RID: 94040 RVA: 0x005D3B14 File Offset: 0x005D1D14
	public void SetValue(double value, bool isPercent = false)
	{
		UUIText text = base.GetText(4);
		if (isPercent)
		{
			text.SetText(Math.Round(value * 100.0, 2).ToString() + "%", true);
			return;
		}
		text.SetText(value.ToString(), true);
	}
}
