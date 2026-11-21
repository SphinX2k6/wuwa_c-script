using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004524 RID: 17700
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x0602CA6B RID: 182891 RVA: 0x00C8645B File Offset: 0x00C8465B
		// (set) Token: 0x0602CA6C RID: 182892 RVA: 0x00C86468 File Offset: 0x00C84668
		public TTrackTarget TrackTarget
		{
			get
			{
				return this.CreateParams.TrackTarget;
			}
			set
			{
				this.CreateParams.TrackTarget = value;
			}
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x0602CA6D RID: 182893 RVA: 0x00C86476 File Offset: 0x00C84676
		// (set) Token: 0x0602CA6E RID: 182894 RVA: 0x00C86483 File Offset: 0x00C84683
		public int MarkConfigId
		{
			get
			{
				return this.CreateParams.MarkConfigId;
			}
			set
			{
				this.CreateParams.MarkConfigId = value;
			}
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x0602CA6F RID: 182895 RVA: 0x00C86491 File Offset: 0x00C84691
		public EMarkType MarkType
		{
			get
			{
				return this.CreateParams.MarkType;
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x0602CA70 RID: 182896 RVA: 0x00C8649E File Offset: 0x00C8469E
		// (set) Token: 0x0602CA71 RID: 182897 RVA: 0x00C864AB File Offset: 0x00C846AB
		public int? MarkId
		{
			get
			{
				return this.CreateParams.MarkId;
			}
			set
			{
				this.CreateParams.MarkId = value;
			}
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x0602CA72 RID: 182898 RVA: 0x00C864B9 File Offset: 0x00C846B9
		public ETrackSource? TrackSource
		{
			get
			{
				return this.CreateParams.TrackSource;
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x0602CA73 RID: 182899 RVA: 0x00C864C8 File Offset: 0x00C846C8
		public bool DestroyOnUnTrack
		{
			get
			{
				return this.CreateParams.DestroyOnUnTrack.GetValueOrDefault();
			}
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x0602CA74 RID: 182900 RVA: 0x00C864E8 File Offset: 0x00C846E8
		// (set) Token: 0x0602CA75 RID: 182901 RVA: 0x00C864F5 File Offset: 0x00C846F5
		public int? TeleportId
		{
			get
			{
				return this.CreateParams.TeleportId;
			}
			set
			{
				this.CreateParams.TeleportId = value;
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x0602CA76 RID: 182902 RVA: 0x00C86503 File Offset: 0x00C84703
		public int? EntityConfigId
		{
			get
			{
				return this.CreateParams.EntityConfigId;
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x0602CA77 RID: 182903 RVA: 0x00C86510 File Offset: 0x00C84710
		// (set) Token: 0x0602CA78 RID: 182904 RVA: 0x00C8651D File Offset: 0x00C8471D
		public int? AreaId
		{
			get
			{
				return this.CreateParams.AreaId;
			}
			set
			{
				this.CreateParams.AreaId = value;
			}
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x0602CA79 RID: 182905 RVA: 0x00C8652C File Offset: 0x00C8472C
		// (set) Token: 0x0602CA7A RID: 182906 RVA: 0x00C8654C File Offset: 0x00C8474C
		public MarkState ServerMarkState
		{
			get
			{
				return this.CreateParams.ServerMarkState.GetValueOrDefault();
			}
			set
			{
				this.CreateParams.ServerMarkState = new MarkState?(value);
			}
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x0602CA7B RID: 182907 RVA: 0x00C8655F File Offset: 0x00C8475F
		public int MapId { get; }

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x0602CA7C RID: 182908 RVA: 0x00C86567 File Offset: 0x00C84767
		public int? InstanceDungeonId { get; }

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x0602CA7D RID: 182909 RVA: 0x00C8656F File Offset: 0x00C8476F
		public EMapGravityDirection MapGravity
		{
			get
			{
				if (this._cachedMapGravity != null)
				{
					return this._cachedMapGravity.Value;
				}
				this._cachedMapGravity = new EMapGravityDirection?(this.CalculateMapGravity());
				return this._cachedMapGravity.Value;
			}
		}

		// Token: 0x0602CA7E RID: 182910 RVA: 0x00C865A8 File Offset: 0x00C847A8
		private EMapGravityDirection CalculateMapGravity()
		{
			if (this.CreateParams.Gravity != null)
			{
				return this.CreateParams.Gravity.Value;
			}
			if (this.EntityConfigId != null)
			{
				EMapGravityDirection entityGravityDirection = WorldMapConfig.Instance.GetEntityGravityDirection(this.MapId, this.EntityConfigId.Value);
				if (entityGravityDirection != EMapGravityDirection.All)
				{
					return entityGravityDirection;
				}
			}
			EMarkType markType = this.MarkType;
			if (markType == EMarkType.Custom || markType == EMarkType.TemporaryTeleport || markType == EMarkType.TreasureBoxDetector)
			{
				return EMapGravityDirection.All;
			}
			if (!WorldMapModel.Instance.IsGravityMap(this.MapId))
			{
				return EMapGravityDirection.All;
			}
			return EMapGravityDirection.Down;
		}

		// Token: 0x0602CA7F RID: 182911 RVA: 0x00C86640 File Offset: 0x00C84840
		public DynamicMarkCreateInfo(IDynamicMarkCreateParams @params) : base(EMarkCreateType.DynamicMark)
		{
			this.CreateParams = @params;
			if (this.CreateParams.MapAndDungeonInfo == null)
			{
				this.CreateParams.MapAndDungeonInfo = new MapAndDungeonInfo
				{
					MapConfigId = new int?(8)
				};
			}
			if (@params.MarkType == EMarkType.Quest)
			{
				int? dungeonId = this.CreateParams.MapAndDungeonInfo.DungeonId;
				if (dungeonId != null)
				{
					this.CreateParams.MapAndDungeonInfo.MapConfigId = dungeonId;
				}
			}
			int? mapConfigId = this.CreateParams.MapAndDungeonInfo.MapConfigId;
			if ((mapConfigId ?? 1) == 0)
			{
				mapConfigId = new int?(8);
			}
			if (mapConfigId != null)
			{
				this.CreateParams.MapAndDungeonInfo.MapConfigId = mapConfigId;
			}
			else
			{
				OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMapConfigByType(this.CreateParams.MarkConfigId, @params.MarkType);
				this.CreateParams.MapAndDungeonInfo.MapConfigId = new int?(oneOf.Value.IsT1 ? oneOf.Value.AsT1.MapId : oneOf.Value.AsT2.MapId);
			}
			MapAndDungeonInfo mapAndDungeonInfo = this.CreateParams.MapAndDungeonInfo;
			int? dungeonId2 = mapAndDungeonInfo.DungeonId;
			if (dungeonId2 == null)
			{
				mapAndDungeonInfo.DungeonId = MapConfig.Instance.SearchMarkInstanceDungeonId(this.CreateParams.MarkConfigId, @params.MarkType);
			}
			this.MapId = this.CreateParams.MapAndDungeonInfo.MapConfigId.Value;
			this.InstanceDungeonId = this.CreateParams.MapAndDungeonInfo.DungeonId;
		}

		// Token: 0x04017EE1 RID: 98017
		protected IDynamicMarkCreateParams CreateParams;

		// Token: 0x04017EE2 RID: 98018
		private EMapGravityDirection? _cachedMapGravity;
	}
}
