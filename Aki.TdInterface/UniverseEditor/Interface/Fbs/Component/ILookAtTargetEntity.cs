using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9B RID: 23195
	public struct ILookAtTargetEntity : IFlatbufferObject
	{
		// Token: 0x1700A906 RID: 43270
		// (get) Token: 0x0602604F RID: 155727 RVA: 0x00535F1C File Offset: 0x0053411C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026050 RID: 155728 RVA: 0x00535F29 File Offset: 0x00534129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026051 RID: 155729 RVA: 0x00535F30 File Offset: 0x00534130
		public static ILookAtTargetEntity GetRootAsILookAtTargetEntity(ByteBuffer _bb)
		{
			return ILookAtTargetEntity.GetRootAsILookAtTargetEntity(_bb, default(ILookAtTargetEntity));
		}

		// Token: 0x06026052 RID: 155730 RVA: 0x00535F4C File Offset: 0x0053414C
		public static ILookAtTargetEntity GetRootAsILookAtTargetEntity(ByteBuffer _bb, ILookAtTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026053 RID: 155731 RVA: 0x00535F69 File Offset: 0x00534169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026054 RID: 155732 RVA: 0x00535F78 File Offset: 0x00534178
		public ILookAtTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A907 RID: 43271
		// (get) Token: 0x06026055 RID: 155733 RVA: 0x00535F88 File Offset: 0x00534188
		public ELookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELookAtTargetType.Entity;
				}
				return (ELookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A908 RID: 43272
		// (get) Token: 0x06026056 RID: 155734 RVA: 0x00535FC4 File Offset: 0x005341C4
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

		// Token: 0x06026057 RID: 155735 RVA: 0x00536000 File Offset: 0x00534200
		public static Offset<ILookAtTargetEntity> CreateILookAtTargetEntity(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity, int EntityId = 0)
		{
			builder.StartTable(2);
			ILookAtTargetEntity.AddEntityId(builder, EntityId);
			ILookAtTargetEntity.AddType(builder, Type);
			return ILookAtTargetEntity.EndILookAtTargetEntity(builder);
		}

		// Token: 0x06026058 RID: 155736 RVA: 0x0053601D File Offset: 0x0053421D
		public static void StartILookAtTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026059 RID: 155737 RVA: 0x00536026 File Offset: 0x00534226
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602605A RID: 155738 RVA: 0x00536031 File Offset: 0x00534231
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602605B RID: 155739 RVA: 0x0053603C File Offset: 0x0053423C
		public static Offset<ILookAtTargetEntity> EndILookAtTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetEntity>(builder.EndTable());
		}

		// Token: 0x0602605C RID: 155740 RVA: 0x0053604C File Offset: 0x0053424C
		public ILookAtTargetEntityT UnPack()
		{
			ILookAtTargetEntityT lookAtTargetEntityT = new ILookAtTargetEntityT();
			this.UnPackTo(lookAtTargetEntityT);
			return lookAtTargetEntityT;
		}

		// Token: 0x0602605D RID: 155741 RVA: 0x00536067 File Offset: 0x00534267
		public void UnPackTo(ILookAtTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602605E RID: 155742 RVA: 0x00536084 File Offset: 0x00534284
		public static Offset<ILookAtTargetEntity> Pack(FlatBufferBuilder builder, ILookAtTargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetEntity>);
			}
			return ILookAtTargetEntity.CreateILookAtTargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400F43B RID: 62523
		private Table __p;
	}
}
