using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557A RID: 21882
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MapDefine
	{
		// Token: 0x06037C6F RID: 228463 RVA: 0x00D39100 File Offset: 0x00D37300
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

		// Token: 0x0401D503 RID: 120067
		public const float FLOAT_0_01 = 0.01f;

		// Token: 0x0401D504 RID: 120068
		public static readonly global::Vector world2UiUnit = global::Vector.Create(0.009999999776482582, -0.009999999776482582, 0.009999999776482582);

		// Token: 0x0401D505 RID: 120069
		public static readonly Vector2D worldToScreenScale = Vector2D.Create(0.009999999776482582, -0.009999999776482582);

		// Token: 0x0401D506 RID: 120070
		public const int DETAIL_TILE_REALSIZE = 850;

		// Token: 0x0401D507 RID: 120071
		public const int MINI_MAP_RADIUS = 200;

		// Token: 0x0401D508 RID: 120072
		public const int MINI_MAP_UPDATE_GAP = 20;

		// Token: 0x0401D509 RID: 120073
		public const int MINI_MAP_DEFAULT_SCALE = 150;

		// Token: 0x0401D50A RID: 120074
		public const int UNIT = 100;

		// Token: 0x0401D50B RID: 120075
		public const int MARK_SCOPE = 50;

		// Token: 0x0401D50C RID: 120076
		public const int MARK_HASH_XY_PANDING = 100000;

		// Token: 0x0401D50D RID: 120077
		public const float MARK_WORLD_TO_HASH_SCALE = 0.01f;

		// Token: 0x0401D50E RID: 120078
		public const int BIG_WORLD_MAP_ID = 8;

		// Token: 0x0401D50F RID: 120079
		public const int HHA_BIG_WORLD_MAP_ID = 900;

		// Token: 0x0401D510 RID: 120080
		public const int BOX_MAP_ID = 912;

		// Token: 0x0401D511 RID: 120081
		public const int DETAIL_TILE_SPACE = 850;

		// Token: 0x0401D512 RID: 120082
		public const int DEFAULT_MAP_BORDER_ID = 1;

		// Token: 0x0401D513 RID: 120083
		public const float WORLD_MAP_MAX_SCALE = 2.5f;

		// Token: 0x0401D514 RID: 120084
		public const int HONAMI_MAP_ID = 907;

		// Token: 0x0401D515 RID: 120085
		public const int FISHING_SHIP_MARK_ID = 8;

		// Token: 0x0401D516 RID: 120086
		public static readonly HashSet<EMarkType> HasSingleComponentMarkType = new HashSet<EMarkType>
		{
			EMarkType.TreasureBoxDetector,
			EMarkType.Quest,
			EMarkType.EnrichmentArea
		};

		// Token: 0x0401D517 RID: 120087
		public static readonly HashSet<EMarkType> CanDisableGameplayFinishMarkType = new HashSet<EMarkType>
		{
			EMarkType.CommonGamePlay
		};

		// Token: 0x0401D518 RID: 120088
		public static readonly HashSet<EMarkType> ServerMarkIgnoreReadConfigSet = new HashSet<EMarkType>
		{
			EMarkType.Quest,
			EMarkType.Custom,
			EMarkType.EnrichmentArea,
			EMarkType.EnrichmentCollectProduct
		};

		// Token: 0x0401D519 RID: 120089
		public static readonly HashSet<EMarkType> MapLoadDirectlyConfigMarkSet = new HashSet<EMarkType>
		{
			EMarkType.FloatLightForest
		};

		// Token: 0x0401D51A RID: 120090
		public static readonly List<TreasureChestStatType> TreasureChestStatTypeDisplayOrder;

		// Token: 0x0401D51B RID: 120091
		public static readonly Dictionary<TreasureChestStatType, string> TreasureChestTitleTextId;

		// Token: 0x0401D51C RID: 120092
		public static readonly Dictionary<TreasureChestStatType, string> TreasureChestIconResourceId;

		// Token: 0x0401D51D RID: 120093
		public static readonly HashSet<PbMapMarkType.Types.ENUMS> AddMarkFilterInTeamModeSet;
	}
}
