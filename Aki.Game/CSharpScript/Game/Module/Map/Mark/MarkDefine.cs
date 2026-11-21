using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020044A0 RID: 17568
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class MarkDefine
	{
		// Token: 0x04017DCF RID: 97743
		public static readonly HashSet<EMarkType> PermanentUpdateTypeSet = new HashSet<EMarkType>
		{
			EMarkType.OtherPlayers,
			EMarkType.EnrichmentArea,
			EMarkType.TreasureBoxDetector,
			EMarkType.FishingShip
		};

		// Token: 0x04017DD0 RID: 97744
		public static readonly HashSet<EMarkType> CanOutOfBoundUpdateTypeSet = new HashSet<EMarkType>
		{
			EMarkType.OtherPlayers
		};

		// Token: 0x04017DD1 RID: 97745
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

		// Token: 0x04017DD2 RID: 97746
		public static readonly HashSet<EMarkType> AllFloorShowMarkTypeSet = new HashSet<EMarkType>
		{
			EMarkType.Custom,
			EMarkType.SoundBox,
			EMarkType.TreasureBoxDetector
		};

		// Token: 0x04017DD3 RID: 97747
		public const int HONAMI_SCAN_MARK_ITEM_ID = 157012;

		// Token: 0x0200A169 RID: 41321
		[NullableContext(0)]
		[RequiredMember]
		public class FishingShipMarkCacheInfo
		{
			// Token: 0x0604575E RID: 284510 RVA: 0x014DC798 File Offset: 0x014DA998
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public FishingShipMarkCacheInfo()
			{
			}

			// Token: 0x04032203 RID: 205315
			[RequiredMember]
			public int InstanceId;

			// Token: 0x04032204 RID: 205316
			[RequiredMember]
			public int TemplateId;

			// Token: 0x04032205 RID: 205317
			[RequiredMember]
			public double PositionX;

			// Token: 0x04032206 RID: 205318
			[RequiredMember]
			public double PositionY;

			// Token: 0x04032207 RID: 205319
			[RequiredMember]
			public double PositionZ;
		}

		// Token: 0x0200A16A RID: 41322
		[NullableContext(0)]
		public class EMarkLockShowState
		{
			// Token: 0x04032208 RID: 205320
			public const int Hide = 0;

			// Token: 0x04032209 RID: 205321
			public const int Show = 1;
		}
	}
}
