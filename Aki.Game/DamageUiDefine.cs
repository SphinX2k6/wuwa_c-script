using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02001A06 RID: 6662
[NullableContext(1)]
[Nullable(0)]
public class DamageUiDefine
{
	// Token: 0x040059EA RID: 23018
	public const string DEFAULT_DAMAGE_DYNAMIC_BATCH = "UiItem_DamageView_Num_Prefab";

	// Token: 0x040059EB RID: 23019
	public const string DEFAULT_DAMAGE_VIEW = "UiItem_DamageView_Sim_Prefab";

	// Token: 0x040059EC RID: 23020
	[StaticVariableRuleIgnore]
	public static readonly DamageUiDefine.DamageParentSlot DefaultDamageParent = new DamageUiDefine.DamageParentSlot(ELayerType.HUD, 0);

	// Token: 0x040059ED RID: 23021
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, DamageUiDefine.DamageParentSlot> inst2DamageParent = new Dictionary<EDungeonSubType, DamageUiDefine.DamageParentSlot>
	{
		{
			EDungeonSubType.DangoBrawl,
			new DamageUiDefine.DamageParentSlot(ELayerType.BattleFloat, 0)
		}
	};

	// Token: 0x040059EE RID: 23022
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, string> inst2DamageDynamicBatch = new Dictionary<EDungeonSubType, string>
	{
		{
			EDungeonSubType.PinballBattle,
			"UiItem_DamageViewCatapultStory_Num_Prefab"
		},
		{
			EDungeonSubType.Kurotato,
			"UiItem_DamageView_Num_Potato_Prefab"
		},
		{
			EDungeonSubType.DangoBrawl,
			"UiItem_DamageViewDangoBrawl"
		}
	};

	// Token: 0x040059EF RID: 23023
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, string> inst2DamageView = new Dictionary<EDungeonSubType, string>
	{
		{
			EDungeonSubType.PinballBattle,
			"UiItem_DamageView_Sim_Prefab"
		}
	};

	// Token: 0x02007F3D RID: 32573
	[NullableContext(0)]
	public readonly struct DamageParentSlot
	{
		// Token: 0x06049D0A RID: 302346 RVA: 0x0131FDFA File Offset: 0x0131DFFA
		public DamageParentSlot(ELayerType layer, int index)
		{
			this.Layer = layer;
			this.Index = index;
		}

		// Token: 0x040298CE RID: 170190
		public readonly ELayerType Layer;

		// Token: 0x040298CF RID: 170191
		public readonly int Index;
	}
}
