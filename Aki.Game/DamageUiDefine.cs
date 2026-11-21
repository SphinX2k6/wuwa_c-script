using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02000EC5 RID: 3781
[NullableContext(1)]
[Nullable(0)]
public class DamageUiDefine
{
	// Token: 0x04005AB9 RID: 23225
	public const string DEFAULT_DAMAGE_DYNAMIC_BATCH = "UiItem_DamageView_Num_Prefab";

	// Token: 0x04005ABA RID: 23226
	public const string DEFAULT_DAMAGE_VIEW = "UiItem_DamageView_Sim_Prefab";

	// Token: 0x04005ABB RID: 23227
	[StaticVariableRuleIgnore]
	public static readonly DamageUiDefine.DamageParentSlot DefaultDamageParent = new DamageUiDefine.DamageParentSlot(ELayerType.HUD, 0);

	// Token: 0x04005ABC RID: 23228
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, DamageUiDefine.DamageParentSlot> inst2DamageParent = new Dictionary<EDungeonSubType, DamageUiDefine.DamageParentSlot>
	{
		{
			EDungeonSubType.DangoBrawl,
			new DamageUiDefine.DamageParentSlot(ELayerType.BattleFloat, 0)
		}
	};

	// Token: 0x04005ABD RID: 23229
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

	// Token: 0x04005ABE RID: 23230
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, string> inst2DamageView = new Dictionary<EDungeonSubType, string>
	{
		{
			EDungeonSubType.PinballBattle,
			"UiItem_DamageView_Sim_Prefab"
		}
	};

	// Token: 0x020070CC RID: 28876
	[NullableContext(0)]
	public readonly struct DamageParentSlot
	{
		// Token: 0x06040128 RID: 262440 RVA: 0x012C32F6 File Offset: 0x012C14F6
		public DamageParentSlot(ELayerType layer, int index)
		{
			this.Layer = layer;
			this.Index = index;
		}

		// Token: 0x04024C0B RID: 150539
		public readonly ELayerType Layer;

		// Token: 0x04024C0C RID: 150540
		public readonly int Index;
	}
}
