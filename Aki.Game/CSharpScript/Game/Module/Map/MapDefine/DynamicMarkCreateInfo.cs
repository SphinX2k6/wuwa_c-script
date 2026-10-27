using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005552 RID: 21842
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x170085CF RID: 34255
		// (get) Token: 0x06037B9B RID: 228251 RVA: 0x00D38987 File Offset: 0x00D36B87
		// (set) Token: 0x06037B9C RID: 228252 RVA: 0x00D38994 File Offset: 0x00D36B94
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

		// Token: 0x170085D0 RID: 34256
		// (get) Token: 0x06037B9D RID: 228253 RVA: 0x00D389A2 File Offset: 0x00D36BA2
		// (set) Token: 0x06037B9E RID: 228254 RVA: 0x00D389AF File Offset: 0x00D36BAF
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

		// Token: 0x170085D1 RID: 34257
		// (get) Token: 0x06037B9F RID: 228255 RVA: 0x00D389BD File Offset: 0x00D36BBD
		public EMarkType MarkType
		{
			get
			{
				return this.CreateParams.MarkType;
			}
		}

		// Token: 0x170085D2 RID: 34258
		// (get) Token: 0x06037BA0 RID: 228256 RVA: 0x00D389CA File Offset: 0x00D36BCA
		// (set) Token: 0x06037BA1 RID: 228257 RVA: 0x00D389D7 File Offset: 0x00D36BD7
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

		// Token: 0x170085D3 RID: 34259
		// (get) Token: 0x06037BA2 RID: 228258 RVA: 0x00D389E5 File Offset: 0x00D36BE5
		public ETrackSource? TrackSource
		{
			get
			{
				return this.CreateParams.TrackSource;
			}
		}

		// Token: 0x170085D4 RID: 34260
		// (get) Token: 0x06037BA3 RID: 228259 RVA: 0x00D389F4 File Offset: 0x00D36BF4
		public bool DestroyOnUnTrack
		{
			get
			{
				return this.CreateParams.DestroyOnUnTrack.GetValueOrDefault();
			}
		}

		// Token: 0x170085D5 RID: 34261
		// (get) Token: 0x06037BA4 RID: 228260 RVA: 0x00D38A14 File Offset: 0x00D36C14
		// (set) Token: 0x06037BA5 RID: 228261 RVA: 0x00D38A21 File Offset: 0x00D36C21
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

		// Token: 0x170085D6 RID: 34262
		// (get) Token: 0x06037BA6 RID: 228262 RVA: 0x00D38A2F File Offset: 0x00D36C2F
		public int? EntityConfigId
		{
			get
			{
				return this.CreateParams.EntityConfigId;
			}
		}

		// Token: 0x170085D7 RID: 34263
		// (get) Token: 0x06037BA7 RID: 228263 RVA: 0x00D38A3C File Offset: 0x00D36C3C
		// (set) Token: 0x06037BA8 RID: 228264 RVA: 0x00D38A49 File Offset: 0x00D36C49
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

		// Token: 0x170085D8 RID: 34264
		// (get) Token: 0x06037BA9 RID: 228265 RVA: 0x00D38A58 File Offset: 0x00D36C58
		// (set) Token: 0x06037BAA RID: 228266 RVA: 0x00D38A78 File Offset: 0x00D36C78
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

		// Token: 0x170085D9 RID: 34265
		// (get) Token: 0x06037BAB RID: 228267 RVA: 0x00D38A8B File Offset: 0x00D36C8B
		public int MapId { get; }

		// Token: 0x170085DA RID: 34266
		// (get) Token: 0x06037BAC RID: 228268 RVA: 0x00D38A93 File Offset: 0x00D36C93
		public int? InstanceDungeonId { get; }

		// Token: 0x170085DB RID: 34267
		// (get) Token: 0x06037BAD RID: 228269 RVA: 0x00D38A9B File Offset: 0x00D36C9B
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

		// Token: 0x06037BAE RID: 228270 RVA: 0x00D38AD4 File Offset: 0x00D36CD4
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

		// Token: 0x06037BAF RID: 228271 RVA: 0x00D38B6C File Offset: 0x00D36D6C
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

		// Token: 0x0401D458 RID: 119896
		protected IDynamicMarkCreateParams CreateParams;

		// Token: 0x0401D459 RID: 119897
		private EMapGravityDirection? _cachedMapGravity;
	}
}
