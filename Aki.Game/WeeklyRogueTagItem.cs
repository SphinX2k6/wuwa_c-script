using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200229D RID: 8861
public class WeeklyRogueTagItem : GridProxyAbstract<int>
{
	// Token: 0x06015E38 RID: 89656 RVA: 0x00658E01 File Offset: 0x00657001
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06015E39 RID: 89657 RVA: 0x00658E3C File Offset: 0x0065703C
	public override void Refresh(int tagId, bool isSelected, int gridIndex)
	{
		RogueWeekTag? rogueWeekTagConfig = WeeklyRogueConfig.Instance.GetRogueWeekTagConfig(tagId);
		if (rogueWeekTagConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueWeekTagConfig.Value.Name, Array.Empty<object>());
		base.GetSprite(0).SetColor(FColor.FromHex(rogueWeekTagConfig.Value.Color));
	}

	// Token: 0x020084F8 RID: 34040
	private enum EComponents
	{
		// Token: 0x0402ADCF RID: 175567
		SpriteBg,
		// Token: 0x0402ADD0 RID: 175568
		TxtTag
	}
}
