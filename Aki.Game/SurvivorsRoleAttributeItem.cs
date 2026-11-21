using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020020B3 RID: 8371
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRoleAttributeItem : GridProxyAbstract<ISurvivorsAttributeUiData>
{
	// Token: 0x06014985 RID: 84357 RVA: 0x006004DF File Offset: 0x005FE6DF
	public override void Refresh(ISurvivorsAttributeUiData data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x06014986 RID: 84358 RVA: 0x006004E8 File Offset: 0x005FE6E8
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

	// Token: 0x06014987 RID: 84359 RVA: 0x006005C6 File Offset: 0x005FE7C6
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

	// Token: 0x06014988 RID: 84360 RVA: 0x00600600 File Offset: 0x005FE800
	public void Update(ISurvivorsAttributeUiData data)
	{
		base.GetSprite(1).useChangeColor = (base.GridIndex % 2 == 1);
		SurvivorsProperty value = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId).Value;
		base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(value.Name);
		this.SetValue(data.Value, value.IsPercent);
	}

	// Token: 0x06014989 RID: 84361 RVA: 0x00600684 File Offset: 0x005FE884
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
