using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200454D RID: 17741
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MapDefine
	{
		// Token: 0x0602CB49 RID: 183113 RVA: 0x00C86BD4 File Offset: 0x00C84DD4
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static MapDefine()
		{
			int num = 2;
			List<TreasureChestStatType> list = new List<TreasureChestStatType>(num);
			CollectionsMarshal.SetCount<TreasureChestStatType>(list, num);
			Span<TreasureChestStatType> span = CollectionsMarshal.AsSpan<TreasureChestStatType>(list);
			int num2 = 0;
			*span[num2] = TreasureChestStatType.HsinToken;
			num2++;
			*span[num2] = TreasureChestStatType.OneTime;
			MapDefine.TreasureChestStatTypeDisplayOrder = list;
			MapDefine.TreasureChestTitleTextId = new Dictionary<TreasureChestStatType, string>
			{
				{
					TreasureChestStatType.OneTime,
					"DungeonRewardBox_Text"
				},
				{
					TreasureChestStatType.HsinToken,
					"DungeonRewardHsinToken_Text"
				}
			};
			MapDefine.TreasureChestIconResourceId = new Dictionary<TreasureChestStatType, string>
			{
				{
					TreasureChestStatType.OneTime,
					"SP_IconMapBox"
				},
				{
					TreasureChestStatType.HsinToken,
					"SP_IconMapFlower"
				}
			};
			MapDefine.AddMarkFilterInTeamModeSet = new HashSet<PbMapMarkType.Types.ENUMS>
			{
				PbMapMarkType.Types.ENUMS.TreasureBoxPoint,
				PbMapMarkType.Types.ENUMS.SoundBox,
				PbMapMarkType.Types.ENUMS.HookLockSoundBox,
				PbMapMarkType.Types.ENUMS.CalmingWindBell
			};
		}

		// Token: 0x04017F8C RID: 98188
		public const float FLOAT_0_01 = 0.01f;

		// Token: 0x04017F8D RID: 98189
		public static readonly global::Vector world2UiUnit = global::Vector.Create(0.009999999776482582, -0.009999999776482582, 0.009999999776482582);

		// Token: 0x04017F8E RID: 98190
		public static readonly Vector2D worldToScreenScale = Vector2D.Create(0.009999999776482582, -0.009999999776482582);

		// Token: 0x04017F8F RID: 98191
		public const int DETAIL_TILE_REALSIZE = 850;

		// Token: 0x04017F90 RID: 98192
		public const int MINI_MAP_RADIUS = 200;

		// Token: 0x04017F91 RID: 98193
		public const int MINI_MAP_UPDATE_GAP = 20;

		// Token: 0x04017F92 RID: 98194
		public const int MINI_MAP_DEFAULT_SCALE = 150;

		// Token: 0x04017F93 RID: 98195
		public const int UNIT = 100;

		// Token: 0x04017F94 RID: 98196
		public const int MARK_SCOPE = 50;

		// Token: 0x04017F95 RID: 98197
		public const int MARK_HASH_XY_PANDING = 100000;

		// Token: 0x04017F96 RID: 98198
		public const float MARK_WORLD_TO_HASH_SCALE = 0.01f;

		// Token: 0x04017F97 RID: 98199
		public const int BIG_WORLD_MAP_ID = 8;

		// Token: 0x04017F98 RID: 98200
		public const int HHA_BIG_WORLD_MAP_ID = 900;

		// Token: 0x04017F99 RID: 98201
		public const int BOX_MAP_ID = 912;

		// Token: 0x04017F9A RID: 98202
		public const int DETAIL_TILE_SPACE = 850;

		// Token: 0x04017F9B RID: 98203
		public const int DEFAULT_MAP_BORDER_ID = 1;

		// Token: 0x04017F9C RID: 98204
		public const float WORLD_MAP_MAX_SCALE = 2.5f;

		// Token: 0x04017F9D RID: 98205
		public const int HONAMI_MAP_ID = 907;

		// Token: 0x04017F9E RID: 98206
		public const int FISHING_SHIP_MARK_ID = 8;

		// Token: 0x04017F9F RID: 98207
		public static readonly HashSet<EMarkType> HasSingleComponentMarkType = new HashSet<EMarkType>
		{
			EMarkType.TreasureBoxDetector,
			EMarkType.Quest,
			EMarkType.EnrichmentArea
		};

		// Token: 0x04017FA0 RID: 98208
		public static readonly HashSet<EMarkType> CanDisableGameplayFinishMarkType = new HashSet<EMarkType>
		{
			EMarkType.CommonGamePlay
		};

		// Token: 0x04017FA1 RID: 98209
		public static readonly HashSet<EMarkType> ServerMarkIgnoreReadConfigSet = new HashSet<EMarkType>
		{
			EMarkType.Quest,
			EMarkType.Custom,
			EMarkType.EnrichmentArea,
			EMarkType.EnrichmentCollectProduct
		};

		// Token: 0x04017FA2 RID: 98210
		public static readonly HashSet<EMarkType> MapLoadDirectlyConfigMarkSet = new HashSet<EMarkType>
		{
			EMarkType.FloatLightForest
		};

		// Token: 0x04017FA3 RID: 98211
		public static readonly List<TreasureChestStatType> TreasureChestStatTypeDisplayOrder;

		// Token: 0x04017FA4 RID: 98212
		public static readonly Dictionary<TreasureChestStatType, string> TreasureChestTitleTextId;

		// Token: 0x04017FA5 RID: 98213
		public static readonly Dictionary<TreasureChestStatType, string> TreasureChestIconResourceId;

		// Token: 0x04017FA6 RID: 98214
		public static readonly HashSet<PbMapMarkType.Types.ENUMS> AddMarkFilterInTeamModeSet;
	}
}
