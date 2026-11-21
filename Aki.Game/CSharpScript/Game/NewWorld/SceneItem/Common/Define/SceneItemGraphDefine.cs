using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Define
{
	// Token: 0x020062C1 RID: 25281
	[NullableContext(1)]
	[Nullable(0)]
	public static class SceneItemGraphDefine
	{
		// Token: 0x040205EF RID: 132591
		public const string SCENE_ITEM_GRAPH_DEBUG_KEY = "SceneItemGraphComponent";

		// Token: 0x040205F0 RID: 132592
		public const string SCENE_ITEM_GRAPH_EFFECT_DEBUG_KEY = "SceneItemGraphEffectComponent";

		// Token: 0x040205F1 RID: 132593
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EGraph3dEffectType, string> graph3dEffectPathMap = new Dictionary<EGraph3dEffectType, string>
		{
			{
				EGraph3dEffectType.FireBoxFish,
				"/Game/Aki/Effect/EffectGroup/BigWorld/3_7MSTL/DA_Fx_Group_Sl2_MSTL_WenHuoChi_Line.DA_Fx_Group_Sl2_MSTL_WenHuoChi_Line"
			}
		};

		// Token: 0x040205F2 RID: 132594
		public const float DEBUG_DRAW_PERSISTENT_DURATION = 100000000f;

		// Token: 0x040205F3 RID: 132595
		public const float DEBUG_DRAW_NODE_RADIUS = 25f;

		// Token: 0x040205F4 RID: 132596
		public const int DEBUG_DRAW_NODE_SEGMENTS = 12;

		// Token: 0x040205F5 RID: 132597
		public const float DEBUG_DRAW_LINE_THICKNESS = 3f;

		// Token: 0x040205F6 RID: 132598
		public const float DEBUG_DRAW_TEXT_Z_OFFSET = 40f;

		// Token: 0x040205F7 RID: 132599
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor nodeColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x040205F8 RID: 132600
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor edgeColor = new FLinearColor(0f, 1f, 1f, 1f);

		// Token: 0x040205F9 RID: 132601
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor textColor = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x040205FA RID: 132602
		public const float DEBUG_DRAW_SELECT_DURATION = 5f;

		// Token: 0x040205FB RID: 132603
		public const float DEBUG_DRAW_SELECT_NODE_RADIUS = 35f;

		// Token: 0x040205FC RID: 132604
		public const float DEBUG_DRAW_SELECT_ARROW_SIZE = 100f;

		// Token: 0x040205FD RID: 132605
		public const float DEBUG_DRAW_SELECT_AWAY_DIR_LENGTH = 200f;

		// Token: 0x040205FE RID: 132606
		public const float DEBUG_DRAW_SELECT_TEXT_Z_OFFSET = 70f;

		// Token: 0x040205FF RID: 132607
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectValidColor = new FLinearColor(0f, 0.3f, 1f, 1f);

		// Token: 0x04020600 RID: 132608
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectInvalidColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04020601 RID: 132609
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectPickedColor = new FLinearColor(1f, 1f, 0f, 1f);

		// Token: 0x04020602 RID: 132610
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectAwayDirColor = new FLinearColor(1f, 0f, 1f, 1f);
	}
}
