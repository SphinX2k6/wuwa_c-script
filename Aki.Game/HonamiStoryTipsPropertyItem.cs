using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EB4 RID: 7860
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryTipsPropertyItem : GridProxyAbstract<IHonamiStoryTipsPropertyData>
{
	// Token: 0x0600F1C1 RID: 61889 RVA: 0x003A3028 File Offset: 0x003A1228
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

	// Token: 0x0600F1C2 RID: 61890 RVA: 0x003A3098 File Offset: 0x003A1298
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

	// Token: 0x02008490 RID: 33936
	private enum EDefine
	{
		// Token: 0x0402B26C RID: 176748
		SpriteBg,
		// Token: 0x0402B26D RID: 176749
		TexIcon,
		// Token: 0x0402B26E RID: 176750
		TxtName,
		// Token: 0x0402B26F RID: 176751
		TxtNum
	}
}
