using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Define
{
	// Token: 0x0200720C RID: 29196
	[NullableContext(1)]
	[Nullable(0)]
	public static class SceneItemGraphDefine
	{
		// Token: 0x04025980 RID: 153984
		public const string SCENE_ITEM_GRAPH_DEBUG_KEY = "SceneItemGraphComponent";

		// Token: 0x04025981 RID: 153985
		public const string SCENE_ITEM_GRAPH_EFFECT_DEBUG_KEY = "SceneItemGraphEffectComponent";

		// Token: 0x04025982 RID: 153986
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EGraph3dEffectType, string> graph3dEffectPathMap = new Dictionary<EGraph3dEffectType, string>
		{
			{
				EGraph3dEffectType.FireBoxFish,
				"/Game/Aki/Effect/EffectGroup/BigWorld/3_7MSTL/DA_Fx_Group_Sl2_MSTL_WenHuoChi_Line.DA_Fx_Group_Sl2_MSTL_WenHuoChi_Line"
			}
		};

		// Token: 0x04025983 RID: 153987
		public const float DEBUG_DRAW_PERSISTENT_DURATION = 100000000f;

		// Token: 0x04025984 RID: 153988
		public const float DEBUG_DRAW_NODE_RADIUS = 25f;

		// Token: 0x04025985 RID: 153989
		public const int DEBUG_DRAW_NODE_SEGMENTS = 12;

		// Token: 0x04025986 RID: 153990
		public const float DEBUG_DRAW_LINE_THICKNESS = 3f;

		// Token: 0x04025987 RID: 153991
		public const float DEBUG_DRAW_TEXT_Z_OFFSET = 40f;

		// Token: 0x04025988 RID: 153992
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor nodeColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04025989 RID: 153993
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor edgeColor = new FLinearColor(0f, 1f, 1f, 1f);

		// Token: 0x0402598A RID: 153994
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor textColor = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x0402598B RID: 153995
		public const float DEBUG_DRAW_SELECT_DURATION = 5f;

		// Token: 0x0402598C RID: 153996
		public const float DEBUG_DRAW_SELECT_NODE_RADIUS = 35f;

		// Token: 0x0402598D RID: 153997
		public const float DEBUG_DRAW_SELECT_ARROW_SIZE = 100f;

		// Token: 0x0402598E RID: 153998
		public const float DEBUG_DRAW_SELECT_AWAY_DIR_LENGTH = 200f;

		// Token: 0x0402598F RID: 153999
		public const float DEBUG_DRAW_SELECT_TEXT_Z_OFFSET = 70f;

		// Token: 0x04025990 RID: 154000
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectValidColor = new FLinearColor(0f, 0.3f, 1f, 1f);

		// Token: 0x04025991 RID: 154001
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectInvalidColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04025992 RID: 154002
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectPickedColor = new FLinearColor(1f, 1f, 0f, 1f);

		// Token: 0x04025993 RID: 154003
		[StaticVariableRuleIgnore]
		public static readonly FLinearColor selectAwayDirColor = new FLinearColor(1f, 0f, 1f, 1f);
	}
}
