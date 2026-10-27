using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D43 RID: 11587
public class WeeklyRogueTagItem : GridProxyAbstract<int>
{
	// Token: 0x06018596 RID: 99734 RVA: 0x00632DF1 File Offset: 0x00630FF1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06018597 RID: 99735 RVA: 0x00632E2C File Offset: 0x0063102C
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

	// Token: 0x020092D1 RID: 37585
	private enum EComponents
	{
		// Token: 0x0402F747 RID: 194375
		SpriteBg,
		// Token: 0x0402F748 RID: 194376
		TxtTag
	}
}
