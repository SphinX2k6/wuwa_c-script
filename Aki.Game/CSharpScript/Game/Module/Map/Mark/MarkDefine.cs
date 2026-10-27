using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054BE RID: 21694
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class MarkDefine
	{
		// Token: 0x0401D338 RID: 119608
		public static readonly HashSet<EMarkType> PermanentUpdateTypeSet = new HashSet<EMarkType>
		{
			EMarkType.OtherPlayers,
			EMarkType.EnrichmentArea,
			EMarkType.TreasureBoxDetector,
			EMarkType.FishingShip
		};

		// Token: 0x0401D339 RID: 119609
		public static readonly HashSet<EMarkType> CanOutOfBoundUpdateTypeSet = new HashSet<EMarkType>
		{
			EMarkType.OtherPlayers
		};

		// Token: 0x0401D33A RID: 119610
		public static readonly HashSet<EMarkType> PermanentShowInGravityLayerTypeSet = new HashSet<EMarkType>
		{
			EMarkType.OtherPlayers,
			EMarkType.EnrichmentArea,
			EMarkType.EnrichmentCollectProduct,
			EMarkType.TreasureBoxDetector,
			EMarkType.TreasureBox,
			EMarkType.SoundBox,
			EMarkType.CalmingWindBell
		};

		// Token: 0x0401D33B RID: 119611
		public static readonly HashSet<EMarkType> AllFloorShowMarkTypeSet = new HashSet<EMarkType>
		{
			EMarkType.Custom,
			EMarkType.SoundBox,
			EMarkType.TreasureBoxDetector
		};

		// Token: 0x0401D33C RID: 119612
		public const int HONAMI_SCAN_MARK_ITEM_ID = 157012;

		// Token: 0x0200B732 RID: 46898
		[NullableContext(0)]
		[RequiredMember]
		public class FishingShipMarkCacheInfo
		{
			// Token: 0x0604F16A RID: 323946 RVA: 0x015228D2 File Offset: 0x01520AD2
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public FishingShipMarkCacheInfo()
			{
			}

			// Token: 0x040377AC RID: 227244
			[RequiredMember]
			public int InstanceId;

			// Token: 0x040377AD RID: 227245
			[RequiredMember]
			public int TemplateId;

			// Token: 0x040377AE RID: 227246
			[RequiredMember]
			public double PositionX;

			// Token: 0x040377AF RID: 227247
			[RequiredMember]
			public double PositionY;

			// Token: 0x040377B0 RID: 227248
			[RequiredMember]
			public double PositionZ;
		}

		// Token: 0x0200B733 RID: 46899
		[NullableContext(0)]
		public class EMarkLockShowState
		{
			// Token: 0x040377B1 RID: 227249
			public const int Hide = 0;

			// Token: 0x040377B2 RID: 227250
			public const int Show = 1;
		}
	}
}
