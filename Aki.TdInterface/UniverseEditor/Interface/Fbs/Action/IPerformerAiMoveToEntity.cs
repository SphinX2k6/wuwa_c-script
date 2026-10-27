using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C84 RID: 27780
	public struct IPerformerAiMoveToEntity : IFlatbufferObject
	{
		// Token: 0x1700CEE2 RID: 52962
		// (get) Token: 0x06030F3B RID: 200507 RVA: 0x006A58FC File Offset: 0x006A3AFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F3C RID: 200508 RVA: 0x006A5909 File Offset: 0x006A3B09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F3D RID: 200509 RVA: 0x006A5910 File Offset: 0x006A3B10
		public static IPerformerAiMoveToEntity GetRootAsIPerformerAiMoveToEntity(ByteBuffer _bb)
		{
			return IPerformerAiMoveToEntity.GetRootAsIPerformerAiMoveToEntity(_bb, default(IPerformerAiMoveToEntity));
		}

		// Token: 0x06030F3E RID: 200510 RVA: 0x006A592C File Offset: 0x006A3B2C
		public static IPerformerAiMoveToEntity GetRootAsIPerformerAiMoveToEntity(ByteBuffer _bb, IPerformerAiMoveToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F3F RID: 200511 RVA: 0x006A5949 File Offset: 0x006A3B49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F40 RID: 200512 RVA: 0x006A5958 File Offset: 0x006A3B58
		public IPerformerAiMoveToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEE3 RID: 52963
		// (get) Token: 0x06030F41 RID: 200513 RVA: 0x006A5968 File Offset: 0x006A3B68
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEE4 RID: 52964
		// (get) Token: 0x06030F42 RID: 200514 RVA: 0x006A59A4 File Offset: 0x006A3BA4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F43 RID: 200515 RVA: 0x006A59E0 File Offset: 0x006A3BE0
		public static Offset<IPerformerAiMoveToEntity> CreateIPerformerAiMoveToEntity(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position, int EntityId = 0)
		{
			builder.StartTable(2);
			IPerformerAiMoveToEntity.AddEntityId(builder, EntityId);
			IPerformerAiMoveToEntity.AddType(builder, Type);
			return IPerformerAiMoveToEntity.EndIPerformerAiMoveToEntity(builder);
		}

		// Token: 0x06030F44 RID: 200516 RVA: 0x006A59FD File Offset: 0x006A3BFD
		public static void StartIPerformerAiMoveToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030F45 RID: 200517 RVA: 0x006A5A06 File Offset: 0x006A3C06
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030F46 RID: 200518 RVA: 0x006A5A11 File Offset: 0x006A3C11
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06030F47 RID: 200519 RVA: 0x006A5A1C File Offset: 0x006A3C1C
		public static Offset<IPerformerAiMoveToEntity> EndIPerformerAiMoveToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToEntity>(builder.EndTable());
		}

		// Token: 0x06030F48 RID: 200520 RVA: 0x006A5A2C File Offset: 0x006A3C2C
		public IPerformerAiMoveToEntityT UnPack()
		{
			IPerformerAiMoveToEntityT performerAiMoveToEntityT = new IPerformerAiMoveToEntityT();
			this.UnPackTo(performerAiMoveToEntityT);
			return performerAiMoveToEntityT;
		}

		// Token: 0x06030F49 RID: 200521 RVA: 0x006A5A47 File Offset: 0x006A3C47
		public void UnPackTo(IPerformerAiMoveToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06030F4A RID: 200522 RVA: 0x006A5A64 File Offset: 0x006A3C64
		public static Offset<IPerformerAiMoveToEntity> Pack(FlatBufferBuilder builder, IPerformerAiMoveToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToEntity>);
			}
			return IPerformerAiMoveToEntity.CreateIPerformerAiMoveToEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040115D9 RID: 71129
		private Table __p;
	}
}
