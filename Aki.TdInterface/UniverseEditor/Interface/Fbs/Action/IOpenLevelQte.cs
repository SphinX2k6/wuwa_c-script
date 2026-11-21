using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007370 RID: 29552
	public struct IOpenLevelQte : IFlatbufferObject
	{
		// Token: 0x1700D8C4 RID: 55492
		// (get) Token: 0x0603394A RID: 211274 RVA: 0x006F3C6C File Offset: 0x006F1E6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603394B RID: 211275 RVA: 0x006F3C79 File Offset: 0x006F1E79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603394C RID: 211276 RVA: 0x006F3C80 File Offset: 0x006F1E80
		public static IOpenLevelQte GetRootAsIOpenLevelQte(ByteBuffer _bb)
		{
			return IOpenLevelQte.GetRootAsIOpenLevelQte(_bb, default(IOpenLevelQte));
		}

		// Token: 0x0603394D RID: 211277 RVA: 0x006F3C9C File Offset: 0x006F1E9C
		public static IOpenLevelQte GetRootAsIOpenLevelQte(ByteBuffer _bb, IOpenLevelQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603394E RID: 211278 RVA: 0x006F3CB9 File Offset: 0x006F1EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603394F RID: 211279 RVA: 0x006F3CC8 File Offset: 0x006F1EC8
		public IOpenLevelQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8C5 RID: 55493
		// (get) Token: 0x06033950 RID: 211280 RVA: 0x006F3CD8 File Offset: 0x006F1ED8
		public EOpenQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOpenQteType.PanelQte;
				}
				return (EOpenQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8C6 RID: 55494
		// (get) Token: 0x06033951 RID: 211281 RVA: 0x006F3D14 File Offset: 0x006F1F14
		public TTargetEntity LevelQteEntityType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033952 RID: 211282 RVA: 0x006F3D50 File Offset: 0x006F1F50
		public TTable? LevelQteEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033953 RID: 211283 RVA: 0x006F3D94 File Offset: 0x006F1F94
		public IPlayerEntity LevelQteEntityAsIPlayerEntity()
		{
			return this.LevelQteEntity<IPlayerEntity>().Value;
		}

		// Token: 0x06033954 RID: 211284 RVA: 0x006F3DB0 File Offset: 0x006F1FB0
		public ISelfEntity LevelQteEntityAsISelfEntity()
		{
			return this.LevelQteEntity<ISelfEntity>().Value;
		}

		// Token: 0x06033955 RID: 211285 RVA: 0x006F3DCC File Offset: 0x006F1FCC
		public ITargetEntity LevelQteEntityAsITargetEntity()
		{
			return this.LevelQteEntity<ITargetEntity>().Value;
		}

		// Token: 0x06033956 RID: 211286 RVA: 0x006F3DE8 File Offset: 0x006F1FE8
		public ITriggeredEntity LevelQteEntityAsITriggeredEntity()
		{
			return this.LevelQteEntity<ITriggeredEntity>().Value;
		}

		// Token: 0x06033957 RID: 211287 RVA: 0x006F3E04 File Offset: 0x006F2004
		public IVehicleEntity LevelQteEntityAsIVehicleEntity()
		{
			return this.LevelQteEntity<IVehicleEntity>().Value;
		}

		// Token: 0x06033958 RID: 211288 RVA: 0x006F3E1F File Offset: 0x006F201F
		public static Offset<IOpenLevelQte> CreateIOpenLevelQte(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte, TTargetEntity LevelQteEntity_type = TTargetEntity.NONE, int LevelQteEntityOffset = 0)
		{
			builder.StartTable(3);
			IOpenLevelQte.AddLevelQteEntity(builder, LevelQteEntityOffset);
			IOpenLevelQte.AddLevelQteEntityType(builder, LevelQteEntity_type);
			IOpenLevelQte.AddType(builder, Type);
			return IOpenLevelQte.EndIOpenLevelQte(builder);
		}

		// Token: 0x06033959 RID: 211289 RVA: 0x006F3E43 File Offset: 0x006F2043
		public static void StartIOpenLevelQte(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603395A RID: 211290 RVA: 0x006F3E4C File Offset: 0x006F204C
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603395B RID: 211291 RVA: 0x006F3E57 File Offset: 0x006F2057
		public static void AddLevelQteEntityType(FlatBufferBuilder builder, TTargetEntity levelQteEntityType)
		{
			builder.AddByte(1, (byte)levelQteEntityType, 0);
		}

		// Token: 0x0603395C RID: 211292 RVA: 0x006F3E62 File Offset: 0x006F2062
		public static void AddLevelQteEntity(FlatBufferBuilder builder, int levelQteEntityOffset)
		{
			builder.AddOffset(2, levelQteEntityOffset, 0);
		}

		// Token: 0x0603395D RID: 211293 RVA: 0x006F3E6D File Offset: 0x006F206D
		public static Offset<IOpenLevelQte> EndIOpenLevelQte(FlatBufferBuilder builder)
		{
			return new Offset<IOpenLevelQte>(builder.EndTable());
		}

		// Token: 0x0603395E RID: 211294 RVA: 0x006F3E7C File Offset: 0x006F207C
		public IOpenLevelQteT UnPack()
		{
			IOpenLevelQteT openLevelQteT = new IOpenLevelQteT();
			this.UnPackTo(openLevelQteT);
			return openLevelQteT;
		}

		// Token: 0x0603395F RID: 211295 RVA: 0x006F3E98 File Offset: 0x006F2098
		public void UnPackTo(IOpenLevelQteT _o)
		{
			_o.Type = this.Type;
			_o.LevelQteEntity = new TTargetEntityUnion();
			_o.LevelQteEntity.Type = this.LevelQteEntityType;
			switch (this.LevelQteEntityType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.LevelQteEntity.Value = ((this.LevelQteEntity<IPlayerEntity>() != null) ? this.LevelQteEntity<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.LevelQteEntity.Value = ((this.LevelQteEntity<ISelfEntity>() != null) ? this.LevelQteEntity<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.LevelQteEntity.Value = ((this.LevelQteEntity<ITargetEntity>() != null) ? this.LevelQteEntity<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.LevelQteEntity.Value = ((this.LevelQteEntity<ITriggeredEntity>() != null) ? this.LevelQteEntity<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.LevelQteEntity.Value = ((this.LevelQteEntity<IVehicleEntity>() != null) ? this.LevelQteEntity<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033960 RID: 211296 RVA: 0x006F4004 File Offset: 0x006F2204
		public static Offset<IOpenLevelQte> Pack(FlatBufferBuilder builder, IOpenLevelQteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenLevelQte>);
			}
			TTargetEntity levelQteEntity_type = (_o.LevelQteEntity == null) ? TTargetEntity.NONE : _o.LevelQteEntity.Type;
			int levelQteEntityOffset = (_o.LevelQteEntity == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.LevelQteEntity);
			return IOpenLevelQte.CreateIOpenLevelQte(builder, _o.Type, levelQteEntity_type, levelQteEntityOffset);
		}

		// Token: 0x0401245D RID: 74845
		private Table __p;
	}
}
