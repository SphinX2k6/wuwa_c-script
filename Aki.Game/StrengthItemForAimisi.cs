using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F65 RID: 8037
public class StrengthItemForAimisi : StrengthItem
{
	// Token: 0x0600F95F RID: 63839 RVA: 0x003C6A25 File Offset: 0x003C4C25
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnduranceAimisi";
	}

	// Token: 0x0600F960 RID: 63840 RVA: 0x003C6A2C File Offset: 0x003C4C2C
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

	// Token: 0x0600F961 RID: 63841 RVA: 0x003C6AB4 File Offset: 0x003C4CB4
	private int GetEnumValue(int value)
	{
		int result;
		if (!this.ChildTypeMap.TryGetValue(value, out result))
		{
			return value;
		}
		return result;
	}

	// Token: 0x0600F962 RID: 63842 RVA: 0x003C6AD4 File Offset: 0x003C4CD4
	protected override int ResolveChildType(int name)
	{
		return this.GetEnumValue(name);
	}

	// Token: 0x0600F963 RID: 63843 RVA: 0x003C6ADD File Offset: 0x003C4CDD
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (this.EnableByHighPriority)
		{
			this.OnEnableByHighPriority(this.EnableByHighPriority);
		}
	}

	// Token: 0x0600F964 RID: 63844 RVA: 0x003C6AF9 File Offset: 0x003C4CF9
	protected override void InitUi()
	{
	}

	// Token: 0x0600F965 RID: 63845 RVA: 0x003C6AFB File Offset: 0x003C4CFB
	protected override void OnAddEntityEvents()
	{
	}

	// Token: 0x0600F966 RID: 63846 RVA: 0x003C6B00 File Offset: 0x003C4D00
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

	// Token: 0x04007431 RID: 29745
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

	// Token: 0x02008562 RID: 34146
	private new enum EChildType
	{
		// Token: 0x0402B6D0 RID: 177872
		NormalBarSprite,
		// Token: 0x0402B6D1 RID: 177873
		LowBarSprite,
		// Token: 0x0402B6D2 RID: 177874
		StrengthLineItem,
		// Token: 0x0402B6D3 RID: 177875
		StrengthSingleLineItem,
		// Token: 0x0402B6D4 RID: 177876
		FrontMarker,
		// Token: 0x0402B6D5 RID: 177877
		TemporaryItem,
		// Token: 0x0402B6D6 RID: 177878
		TemporaryBarSprite,
		// Token: 0x0402B6D7 RID: 177879
		TemporaryLineItem,
		// Token: 0x0402B6D8 RID: 177880
		TemporarySingleLineItem,
		// Token: 0x0402B6D9 RID: 177881
		AnimStart,
		// Token: 0x0402B6DA RID: 177882
		AnimClose,
		// Token: 0x0402B6DB RID: 177883
		AnimFull,
		// Token: 0x0402B6DC RID: 177884
		AnimNone,
		// Token: 0x0402B6DD RID: 177885
		AnimPickUp,
		// Token: 0x0402B6DE RID: 177886
		AnimTempStart,
		// Token: 0x0402B6DF RID: 177887
		AnimTempClose,
		// Token: 0x0402B6E0 RID: 177888
		AutoMovingItem,
		// Token: 0x0402B6E1 RID: 177889
		NoneItem,
		// Token: 0x0402B6E2 RID: 177890
		BuffItem,
		// Token: 0x0402B6E3 RID: 177891
		DeBuffItem,
		// Token: 0x0402B6E4 RID: 177892
		DisableItem,
		// Token: 0x0402B6E5 RID: 177893
		MaxCount
	}
}
