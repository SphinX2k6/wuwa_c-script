using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001376 RID: 4982
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryTipsPropertyItem : GridProxyAbstract<IHonamiStoryTipsPropertyData>
{
	// Token: 0x0600C5E0 RID: 50656 RVA: 0x003AEB28 File Offset: 0x003ACD28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600C5E1 RID: 50657 RVA: 0x003AEB98 File Offset: 0x003ACD98
	[NullableContext(1)]
	public override void Refresh(IHonamiStoryTipsPropertyData data, bool isSelected, int gridIndex)
	{
		int propId = data.PropId;
		HonamiStoryProp? honamiStoryProp = HonamiStoryConfig.Instance.GetHonamiStoryProp(propId);
		if (honamiStoryProp == null)
		{
			return;
		}
		PropertyIndexConfig instance = PropertyIndexConfig.Instance;
		string text = (instance != null) ? instance.GetPropertyIndexName(honamiStoryProp.Value.PropId) : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), text ?? string.Empty, Array.Empty<object>());
		PropertyIndexConfig instance2 = PropertyIndexConfig.Instance;
		string text2 = (instance2 != null) ? instance2.GetPropertyIndexIcon(honamiStoryProp.Value.PropId) : null;
		base.SetTextureByPath(text2 ?? string.Empty, base.GetTexture(1), null, null);
		int num = data.PropertyNumber ?? honamiStoryProp.Value.StandardProperty;
		string newText = string.Empty;
		if (honamiStoryProp.Value.ShowPercent)
		{
			newText = ((double)num / 100.0).ToString("F1") + "%";
		}
		else
		{
			newText = num.ToString();
		}
		UUIText text3 = base.GetText(3);
		if (text3 == null)
		{
			return;
		}
		text3.SetText(newText, true);
	}

	// Token: 0x02007615 RID: 30229
	private enum EDefine
	{
		// Token: 0x04026590 RID: 157072
		SpriteBg,
		// Token: 0x04026591 RID: 157073
		TexIcon,
		// Token: 0x04026592 RID: 157074
		TxtName,
		// Token: 0x04026593 RID: 157075
		TxtNum
	}
}
