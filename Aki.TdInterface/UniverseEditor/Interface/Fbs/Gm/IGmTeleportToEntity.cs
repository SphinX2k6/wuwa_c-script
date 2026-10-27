using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200466F RID: 18031
	public struct IGmTeleportToEntity : IFlatbufferObject
	{
		// Token: 0x17008006 RID: 32774
		// (get) Token: 0x0601B5DB RID: 112091 RVA: 0x003E3FC0 File Offset: 0x003E21C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5DC RID: 112092 RVA: 0x003E3FCD File Offset: 0x003E21CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5DD RID: 112093 RVA: 0x003E3FD4 File Offset: 0x003E21D4
		public static IGmTeleportToEntity GetRootAsIGmTeleportToEntity(ByteBuffer _bb)
		{
			return IGmTeleportToEntity.GetRootAsIGmTeleportToEntity(_bb, default(IGmTeleportToEntity));
		}

		// Token: 0x0601B5DE RID: 112094 RVA: 0x003E3FF0 File Offset: 0x003E21F0
		public static IGmTeleportToEntity GetRootAsIGmTeleportToEntity(ByteBuffer _bb, IGmTeleportToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x003E400D File Offset: 0x003E220D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x003E401C File Offset: 0x003E221C
		public IGmTeleportToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008007 RID: 32775
		// (get) Token: 0x0601B5E1 RID: 112097 RVA: 0x003E402C File Offset: 0x003E222C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008008 RID: 32776
		// (get) Token: 0x0601B5E2 RID: 112098 RVA: 0x003E4068 File Offset: 0x003E2268
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

		// Token: 0x17008009 RID: 32777
		// (get) Token: 0x0601B5E3 RID: 112099 RVA: 0x003E40A4 File Offset: 0x003E22A4
		public int PreIncId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B5E4 RID: 112100 RVA: 0x003E40E0 File Offset: 0x003E22E0
		public static Offset<IGmTeleportToEntity> CreateIGmTeleportToEntity(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntityId = 0, int PreIncId = 0)
		{
			builder.StartTable(3);
			IGmTeleportToEntity.AddPreIncId(builder, PreIncId);
			IGmTeleportToEntity.AddEntityId(builder, EntityId);
			IGmTeleportToEntity.AddType(builder, Type);
			return IGmTeleportToEntity.EndIGmTeleportToEntity(builder);
		}

		// Token: 0x0601B5E5 RID: 112101 RVA: 0x003E4104 File Offset: 0x003E2304
		public static void StartIGmTeleportToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B5E6 RID: 112102 RVA: 0x003E410D File Offset: 0x003E230D
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B5E7 RID: 112103 RVA: 0x003E4118 File Offset: 0x003E2318
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601B5E8 RID: 112104 RVA: 0x003E4123 File Offset: 0x003E2323
		public static void AddPreIncId(FlatBufferBuilder builder, int preIncId)
		{
			builder.AddInt(2, preIncId, 0);
		}

		// Token: 0x0601B5E9 RID: 112105 RVA: 0x003E412E File Offset: 0x003E232E
		public static Offset<IGmTeleportToEntity> EndIGmTeleportToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IGmTeleportToEntity>(builder.EndTable());
		}

		// Token: 0x0601B5EA RID: 112106 RVA: 0x003E413C File Offset: 0x003E233C
		public IGmTeleportToEntityT UnPack()
		{
			IGmTeleportToEntityT gmTeleportToEntityT = new IGmTeleportToEntityT();
			this.UnPackTo(gmTeleportToEntityT);
			return gmTeleportToEntityT;
		}

		// Token: 0x0601B5EB RID: 112107 RVA: 0x003E4157 File Offset: 0x003E2357
		public void UnPackTo(IGmTeleportToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PreIncId = this.PreIncId;
		}

		// Token: 0x0601B5EC RID: 112108 RVA: 0x003E4180 File Offset: 0x003E2380
		public static Offset<IGmTeleportToEntity> Pack(FlatBufferBuilder builder, IGmTeleportToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmTeleportToEntity>);
			}
			return IGmTeleportToEntity.CreateIGmTeleportToEntity(builder, _o.Type, _o.EntityId, _o.PreIncId);
		}

		// Token: 0x0400C82F RID: 51247
		private Table __p;
	}
}
