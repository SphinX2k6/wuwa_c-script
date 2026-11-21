using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001427 RID: 5159
public class StrengthItemForAimisi : StrengthItem
{
	// Token: 0x0600CD7E RID: 52606 RVA: 0x003D2511 File Offset: 0x003D0711
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnduranceAimisi";
	}

	// Token: 0x0600CD7F RID: 52607 RVA: 0x003D2518 File Offset: 0x003D0718
	protected override void OnRegisterComponent()
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>
		{
			{
				1,
				typeof(UUISprite)
			},
			{
				0,
				typeof(UUISprite)
			},
			{
				6,
				typeof(UUISprite)
			}
		};
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		for (int i = 0; i < 21; i++)
		{
			Type type;
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, dictionary.TryGetValue(i, out type) ? type : typeof(UUIItem)));
		}
	}

	// Token: 0x0600CD80 RID: 52608 RVA: 0x003D25A0 File Offset: 0x003D07A0
	private int GetEnumValue(int value)
	{
		int result;
		if (!this.ChildTypeMap.TryGetValue(value, out result))
		{
			return value;
		}
		return result;
	}

	// Token: 0x0600CD81 RID: 52609 RVA: 0x003D25C0 File Offset: 0x003D07C0
	protected override int ResolveChildType(int name)
	{
		return this.GetEnumValue(name);
	}

	// Token: 0x0600CD82 RID: 52610 RVA: 0x003D25C9 File Offset: 0x003D07C9
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (this.EnableByHighPriority)
		{
			this.OnEnableByHighPriority(this.EnableByHighPriority);
		}
	}

	// Token: 0x0600CD83 RID: 52611 RVA: 0x003D25E5 File Offset: 0x003D07E5
	protected override void InitUi()
	{
	}

	// Token: 0x0600CD84 RID: 52612 RVA: 0x003D25E7 File Offset: 0x003D07E7
	protected override void OnAddEntityEvents()
	{
	}

	// Token: 0x0600CD85 RID: 52613 RVA: 0x003D25EC File Offset: 0x003D07EC
	protected override void SetNormal(bool bNormal)
	{
		if (this.IsNormalState == bNormal)
		{
			return;
		}
		this.IsNormalState = bNormal;
		UUISprite sprite = base.GetSprite(1);
		UUISprite sprite2 = base.GetSprite(0);
		if (sprite.IsUIActiveSelf() == bNormal)
		{
			sprite.SetUIActive(!bNormal);
		}
		if (sprite.IsUIActiveSelf() != bNormal)
		{
			sprite2.SetUIActive(bNormal);
		}
	}

	// Token: 0x04007512 RID: 29970
	[Nullable(1)]
	private readonly Dictionary<int, int> ChildTypeMap = new Dictionary<int, int>
	{
		{
			8,
			0
		},
		{
			7,
			1
		},
		{
			11,
			2
		},
		{
			10,
			3
		},
		{
			3,
			5
		},
		{
			9,
			6
		},
		{
			13,
			7
		},
		{
			12,
			8
		},
		{
			14,
			9
		},
		{
			15,
			10
		},
		{
			16,
			11
		},
		{
			17,
			12
		},
		{
			18,
			13
		},
		{
			19,
			14
		},
		{
			20,
			15
		},
		{
			21,
			16
		},
		{
			2,
			17
		},
		{
			4,
			18
		},
		{
			5,
			19
		},
		{
			6,
			20
		}
	};

	// Token: 0x020076E7 RID: 30439
	private new enum EChildType
	{
		// Token: 0x040269F4 RID: 158196
		NormalBarSprite,
		// Token: 0x040269F5 RID: 158197
		LowBarSprite,
		// Token: 0x040269F6 RID: 158198
		StrengthLineItem,
		// Token: 0x040269F7 RID: 158199
		StrengthSingleLineItem,
		// Token: 0x040269F8 RID: 158200
		FrontMarker,
		// Token: 0x040269F9 RID: 158201
		TemporaryItem,
		// Token: 0x040269FA RID: 158202
		TemporaryBarSprite,
		// Token: 0x040269FB RID: 158203
		TemporaryLineItem,
		// Token: 0x040269FC RID: 158204
		TemporarySingleLineItem,
		// Token: 0x040269FD RID: 158205
		AnimStart,
		// Token: 0x040269FE RID: 158206
		AnimClose,
		// Token: 0x040269FF RID: 158207
		AnimFull,
		// Token: 0x04026A00 RID: 158208
		AnimNone,
		// Token: 0x04026A01 RID: 158209
		AnimPickUp,
		// Token: 0x04026A02 RID: 158210
		AnimTempStart,
		// Token: 0x04026A03 RID: 158211
		AnimTempClose,
		// Token: 0x04026A04 RID: 158212
		AutoMovingItem,
		// Token: 0x04026A05 RID: 158213
		NoneItem,
		// Token: 0x04026A06 RID: 158214
		BuffItem,
		// Token: 0x04026A07 RID: 158215
		DeBuffItem,
		// Token: 0x04026A08 RID: 158216
		DisableItem,
		// Token: 0x04026A09 RID: 158217
		MaxCount
	}
}
