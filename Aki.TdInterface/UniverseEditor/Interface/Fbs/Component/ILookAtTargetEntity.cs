using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005515 RID: 21781
	public struct ILookAtTargetEntity : IFlatbufferObject
	{
		// Token: 0x1700A0CC RID: 41164
		// (get) Token: 0x06023F95 RID: 147349 RVA: 0x004F8DF8 File Offset: 0x004F6FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F96 RID: 147350 RVA: 0x004F8E05 File Offset: 0x004F7005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F97 RID: 147351 RVA: 0x004F8E0C File Offset: 0x004F700C
		public static ILookAtTargetEntity GetRootAsILookAtTargetEntity(ByteBuffer _bb)
		{
			return ILookAtTargetEntity.GetRootAsILookAtTargetEntity(_bb, default(ILookAtTargetEntity));
		}

		// Token: 0x06023F98 RID: 147352 RVA: 0x004F8E28 File Offset: 0x004F7028
		public static ILookAtTargetEntity GetRootAsILookAtTargetEntity(ByteBuffer _bb, ILookAtTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F99 RID: 147353 RVA: 0x004F8E45 File Offset: 0x004F7045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F9A RID: 147354 RVA: 0x004F8E54 File Offset: 0x004F7054
		public ILookAtTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0CD RID: 41165
		// (get) Token: 0x06023F9B RID: 147355 RVA: 0x004F8E64 File Offset: 0x004F7064
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

		// Token: 0x1700A0CE RID: 41166
		// (get) Token: 0x06023F9C RID: 147356 RVA: 0x004F8EA0 File Offset: 0x004F70A0
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

		// Token: 0x06023F9D RID: 147357 RVA: 0x004F8EDC File Offset: 0x004F70DC
		public static Offset<ILookAtTargetEntity> CreateILookAtTargetEntity(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity, int EntityId = 0)
		{
			builder.StartTable(2);
			ILookAtTargetEntity.AddEntityId(builder, EntityId);
			ILookAtTargetEntity.AddType(builder, Type);
			return ILookAtTargetEntity.EndILookAtTargetEntity(builder);
		}

		// Token: 0x06023F9E RID: 147358 RVA: 0x004F8EF9 File Offset: 0x004F70F9
		public static void StartILookAtTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023F9F RID: 147359 RVA: 0x004F8F02 File Offset: 0x004F7102
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023FA0 RID: 147360 RVA: 0x004F8F0D File Offset: 0x004F710D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06023FA1 RID: 147361 RVA: 0x004F8F18 File Offset: 0x004F7118
		public static Offset<ILookAtTargetEntity> EndILookAtTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetEntity>(builder.EndTable());
		}

		// Token: 0x06023FA2 RID: 147362 RVA: 0x004F8F28 File Offset: 0x004F7128
		public ILookAtTargetEntityT UnPack()
		{
			ILookAtTargetEntityT lookAtTargetEntityT = new ILookAtTargetEntityT();
			this.UnPackTo(lookAtTargetEntityT);
			return lookAtTargetEntityT;
		}

		// Token: 0x06023FA3 RID: 147363 RVA: 0x004F8F43 File Offset: 0x004F7143
		public void UnPackTo(ILookAtTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06023FA4 RID: 147364 RVA: 0x004F8F60 File Offset: 0x004F7160
		public static Offset<ILookAtTargetEntity> Pack(FlatBufferBuilder builder, ILookAtTargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetEntity>);
			}
			return ILookAtTargetEntity.CreateILookAtTargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400E80A RID: 59402
		private Table __p;
	}
}
