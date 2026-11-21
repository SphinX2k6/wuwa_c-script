using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B1D RID: 2845
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WuWuLogisticsInfoItem : GridProxyAbstract<IWuWuLogisticsInfoItemData>
{
	// Token: 0x0600757B RID: 30075 RVA: 0x002446CC File Offset: 0x002428CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600757C RID: 30076 RVA: 0x00244728 File Offset: 0x00242928
	public override void Refresh(IWuWuLogisticsInfoItemData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(2);
		if (data == null)
		{
			return;
		}
		if (data.CfgId > 0)
		{
			WuWuLogisticsDesc? descById = WuWuLogisticsConfig.Instance.GetDescById(data.CfgId);
			if (descById == null)
			{
				return;
			}
			if (text != null)
			{
				text.ShowTextNew(descById.Value.Desc);
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(!data.IsToday);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(data.IsToday);
			}
		}
		else if (!string.IsNullOrEmpty(data.Content))
		{
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.ShowTextNew(data.Content);
			}
		}
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = !data.IsToday;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
	}
}
