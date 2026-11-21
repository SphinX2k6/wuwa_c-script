using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004C3 RID: 1219
public class GolemHackingCodeIconItem : GridProxyAbstract<EGolemHackingBarState>
{
	// Token: 0x06003D07 RID: 15623 RVA: 0x0015922C File Offset: 0x0015742C
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

	// Token: 0x06003D08 RID: 15624 RVA: 0x00159274 File Offset: 0x00157474
	public override void Refresh(EGolemHackingBarState data, bool isSelected, int gridIndex)
	{
		string text;
		string resourceId = GolemHackingCodeIconItem.ResourceIdMap.TryGetValue(gridIndex, out text) ? text : "";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		this.UpdateState(data);
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x001592C8 File Offset: 0x001574C8
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

	// Token: 0x04003133 RID: 12595
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

	// Token: 0x04003134 RID: 12596
	private readonly FColor DefaultColor = FColor.FromHex("DFFF5E");

	// Token: 0x04003135 RID: 12597
	private readonly FColor SuccessColor = FColor.FromHex("0B4F2E");

	// Token: 0x04003136 RID: 12598
	private readonly FColor FailColor = FColor.FromHex("9C1414");

	// Token: 0x0200679D RID: 26525
	private enum EDefine
	{
		// Token: 0x04022335 RID: 140085
		Sprite
	}
}
