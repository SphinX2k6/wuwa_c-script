using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F09 RID: 7945
public class HonamiStoryWeaponTagItem : GridProxyAbstract<int>
{
	// Token: 0x0600F4A9 RID: 62633 RVA: 0x003B08E8 File Offset: 0x003AEAE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600F4AA RID: 62634 RVA: 0x003B0924 File Offset: 0x003AEB24
	public override void Refresh(int pluginId, bool isSelected, int gridIndex)
	{
		HonamiStoryPluginTag? pluginTag = HonamiStoryConfig.Instance.GetPluginTag(pluginId);
		if (pluginTag == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pluginTag.Value.Name, Array.Empty<object>());
		base.GetSprite(0).SetColor(FColor.FromHex(pluginTag.Value.Color));
	}

	// Token: 0x02008516 RID: 34070
	private enum EHonamiStoryWeaponTagItemComponent
	{
		// Token: 0x0402B4FA RID: 177402
		BgSprite,
		// Token: 0x0402B4FB RID: 177403
		DescText
	}
}
