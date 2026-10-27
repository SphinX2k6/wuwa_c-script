using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200100F RID: 4111
public class GolemHackingCodeIconItem : GridProxyAbstract<EGolemHackingBarState>
{
	// Token: 0x06006972 RID: 26994 RVA: 0x00150904 File Offset: 0x0014EB04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006973 RID: 26995 RVA: 0x0015094C File Offset: 0x0014EB4C
	public override void Refresh(EGolemHackingBarState data, bool isSelected, int gridIndex)
	{
		string text;
		string resourceId = GolemHackingCodeIconItem.ResourceIdMap.TryGetValue(gridIndex, out text) ? text : "";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		this.UpdateState(data);
	}

	// Token: 0x06006974 RID: 26996 RVA: 0x001509A0 File Offset: 0x0014EBA0
	public void UpdateState(EGolemHackingBarState state)
	{
		if (state == EGolemHackingBarState.Default)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(this.DefaultColor);
			return;
		}
		else if (state == EGolemHackingBarState.Success)
		{
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetColor(this.SuccessColor);
			return;
		}
		else
		{
			UUISprite sprite3 = base.GetSprite(0);
			if (sprite3 == null)
			{
				return;
			}
			sprite3.SetColor(this.FailColor);
			return;
		}
	}

	// Token: 0x0400309A RID: 12442
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<int, string> ResourceIdMap = new Dictionary<int, string>
	{
		{
			0,
			"SP_GolemHackingArrowLevel1"
		},
		{
			1,
			"SP_GolemHackingArrowLevel2"
		},
		{
			2,
			"SP_GolemHackingArrowLevel3"
		},
		{
			3,
			"SP_GolemHackingArrowLevel4"
		}
	};

	// Token: 0x0400309B RID: 12443
	private readonly FColor DefaultColor = FColor.FromHex("DFFF5E");

	// Token: 0x0400309C RID: 12444
	private readonly FColor SuccessColor = FColor.FromHex("0B4F2E");

	// Token: 0x0400309D RID: 12445
	private readonly FColor FailColor = FColor.FromHex("9C1414");

	// Token: 0x02007609 RID: 30217
	private enum EDefine
	{
		// Token: 0x04026FEA RID: 159722
		Sprite
	}
}
