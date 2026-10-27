using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0C RID: 27660
	public struct IOpenLevelQte : IFlatbufferObject
	{
		// Token: 0x1700CDB6 RID: 52662
		// (get) Token: 0x06030A2A RID: 199210 RVA: 0x0069A2D8 File Offset: 0x006984D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A2B RID: 199211 RVA: 0x0069A2E5 File Offset: 0x006984E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A2C RID: 199212 RVA: 0x0069A2EC File Offset: 0x006984EC
		public static IOpenLevelQte GetRootAsIOpenLevelQte(ByteBuffer _bb)
		{
			return IOpenLevelQte.GetRootAsIOpenLevelQte(_bb, default(IOpenLevelQte));
		}

		// Token: 0x06030A2D RID: 199213 RVA: 0x0069A308 File Offset: 0x00698508
		public static IOpenLevelQte GetRootAsIOpenLevelQte(ByteBuffer _bb, IOpenLevelQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A2E RID: 199214 RVA: 0x0069A325 File Offset: 0x00698525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A2F RID: 199215 RVA: 0x0069A334 File Offset: 0x00698534
		public IOpenLevelQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDB7 RID: 52663
		// (get) Token: 0x06030A30 RID: 199216 RVA: 0x0069A344 File Offset: 0x00698544
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

		// Token: 0x1700CDB8 RID: 52664
		// (get) Token: 0x06030A31 RID: 199217 RVA: 0x0069A380 File Offset: 0x00698580
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

		// Token: 0x06030A32 RID: 199218 RVA: 0x0069A3BC File Offset: 0x006985BC
		public TTable? LevelQteEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A33 RID: 199219 RVA: 0x0069A400 File Offset: 0x00698600
		public IPlayerEntity LevelQteEntityAsIPlayerEntity()
		{
			return this.LevelQteEntity<IPlayerEntity>().Value;
		}

		// Token: 0x06030A34 RID: 199220 RVA: 0x0069A41C File Offset: 0x0069861C
		public ISelfEntity LevelQteEntityAsISelfEntity()
		{
			return this.LevelQteEntity<ISelfEntity>().Value;
		}

		// Token: 0x06030A35 RID: 199221 RVA: 0x0069A438 File Offset: 0x00698638
		public ITargetEntity LevelQteEntityAsITargetEntity()
		{
			return this.LevelQteEntity<ITargetEntity>().Value;
		}

		// Token: 0x06030A36 RID: 199222 RVA: 0x0069A454 File Offset: 0x00698654
		public ITriggeredEntity LevelQteEntityAsITriggeredEntity()
		{
			return this.LevelQteEntity<ITriggeredEntity>().Value;
		}

		// Token: 0x06030A37 RID: 199223 RVA: 0x0069A470 File Offset: 0x00698670
		public IVehicleEntity LevelQteEntityAsIVehicleEntity()
		{
			return this.LevelQteEntity<IVehicleEntity>().Value;
		}

		// Token: 0x06030A38 RID: 199224 RVA: 0x0069A48B File Offset: 0x0069868B
		public static Offset<IOpenLevelQte> CreateIOpenLevelQte(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte, TTargetEntity LevelQteEntity_type = TTargetEntity.NONE, int LevelQteEntityOffset = 0)
		{
			builder.StartTable(3);
			IOpenLevelQte.AddLevelQteEntity(builder, LevelQteEntityOffset);
			IOpenLevelQte.AddLevelQteEntityType(builder, LevelQteEntity_type);
			IOpenLevelQte.AddType(builder, Type);
			return IOpenLevelQte.EndIOpenLevelQte(builder);
		}

		// Token: 0x06030A39 RID: 199225 RVA: 0x0069A4AF File Offset: 0x006986AF
		public static void StartIOpenLevelQte(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030A3A RID: 199226 RVA: 0x0069A4B8 File Offset: 0x006986B8
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A3B RID: 199227 RVA: 0x0069A4C3 File Offset: 0x006986C3
		public static void AddLevelQteEntityType(FlatBufferBuilder builder, TTargetEntity levelQteEntityType)
		{
			builder.AddByte(1, (byte)levelQteEntityType, 0);
		}

		// Token: 0x06030A3C RID: 199228 RVA: 0x0069A4CE File Offset: 0x006986CE
		public static void AddLevelQteEntity(FlatBufferBuilder builder, int levelQteEntityOffset)
		{
			builder.AddOffset(2, levelQteEntityOffset, 0);
		}

		// Token: 0x06030A3D RID: 199229 RVA: 0x0069A4D9 File Offset: 0x006986D9
		public static Offset<IOpenLevelQte> EndIOpenLevelQte(FlatBufferBuilder builder)
		{
			return new Offset<IOpenLevelQte>(builder.EndTable());
		}

		// Token: 0x06030A3E RID: 199230 RVA: 0x0069A4E8 File Offset: 0x006986E8
		public IOpenLevelQteT UnPack()
		{
			IOpenLevelQteT openLevelQteT = new IOpenLevelQteT();
			this.UnPackTo(openLevelQteT);
			return openLevelQteT;
		}

		// Token: 0x06030A3F RID: 199231 RVA: 0x0069A504 File Offset: 0x00698704
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

		// Token: 0x06030A40 RID: 199232 RVA: 0x0069A670 File Offset: 0x00698870
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

		// Token: 0x0401150D RID: 70925
		private Table __p;
	}
}
