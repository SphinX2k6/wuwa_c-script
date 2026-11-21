using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013CB RID: 5067
public class HonamiStoryWeaponTagItem : GridProxyAbstract<int>
{
	// Token: 0x0600C8C8 RID: 51400 RVA: 0x003BC3DC File Offset: 0x003BA5DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600C8C9 RID: 51401 RVA: 0x003BC418 File Offset: 0x003BA618
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

	// Token: 0x0200769B RID: 30363
	private enum EHonamiStoryWeaponTagItemComponent
	{
		// Token: 0x0402681E RID: 157726
		BgSprite,
		// Token: 0x0402681F RID: 157727
		DescText
	}
}
