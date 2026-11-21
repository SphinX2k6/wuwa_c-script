using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD7 RID: 19159
	public struct IGmTeleportToEntity : IFlatbufferObject
	{
		// Token: 0x17008647 RID: 34375
		// (get) Token: 0x0601CDB0 RID: 118192 RVA: 0x0041025C File Offset: 0x0040E45C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CDB1 RID: 118193 RVA: 0x00410269 File Offset: 0x0040E469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CDB2 RID: 118194 RVA: 0x00410270 File Offset: 0x0040E470
		public static IGmTeleportToEntity GetRootAsIGmTeleportToEntity(ByteBuffer _bb)
		{
			return IGmTeleportToEntity.GetRootAsIGmTeleportToEntity(_bb, default(IGmTeleportToEntity));
		}

		// Token: 0x0601CDB3 RID: 118195 RVA: 0x0041028C File Offset: 0x0040E48C
		public static IGmTeleportToEntity GetRootAsIGmTeleportToEntity(ByteBuffer _bb, IGmTeleportToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CDB4 RID: 118196 RVA: 0x004102A9 File Offset: 0x0040E4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CDB5 RID: 118197 RVA: 0x004102B8 File Offset: 0x0040E4B8
		public IGmTeleportToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008648 RID: 34376
		// (get) Token: 0x0601CDB6 RID: 118198 RVA: 0x004102C8 File Offset: 0x0040E4C8
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

		// Token: 0x17008649 RID: 34377
		// (get) Token: 0x0601CDB7 RID: 118199 RVA: 0x00410304 File Offset: 0x0040E504
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

		// Token: 0x1700864A RID: 34378
		// (get) Token: 0x0601CDB8 RID: 118200 RVA: 0x00410340 File Offset: 0x0040E540
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

		// Token: 0x0601CDB9 RID: 118201 RVA: 0x0041037C File Offset: 0x0040E57C
		public static Offset<IGmTeleportToEntity> CreateIGmTeleportToEntity(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntityId = 0, int PreIncId = 0)
		{
			builder.StartTable(3);
			IGmTeleportToEntity.AddPreIncId(builder, PreIncId);
			IGmTeleportToEntity.AddEntityId(builder, EntityId);
			IGmTeleportToEntity.AddType(builder, Type);
			return IGmTeleportToEntity.EndIGmTeleportToEntity(builder);
		}

		// Token: 0x0601CDBA RID: 118202 RVA: 0x004103A0 File Offset: 0x0040E5A0
		public static void StartIGmTeleportToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CDBB RID: 118203 RVA: 0x004103A9 File Offset: 0x0040E5A9
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CDBC RID: 118204 RVA: 0x004103B4 File Offset: 0x0040E5B4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601CDBD RID: 118205 RVA: 0x004103BF File Offset: 0x0040E5BF
		public static void AddPreIncId(FlatBufferBuilder builder, int preIncId)
		{
			builder.AddInt(2, preIncId, 0);
		}

		// Token: 0x0601CDBE RID: 118206 RVA: 0x004103CA File Offset: 0x0040E5CA
		public static Offset<IGmTeleportToEntity> EndIGmTeleportToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IGmTeleportToEntity>(builder.EndTable());
		}

		// Token: 0x0601CDBF RID: 118207 RVA: 0x004103D8 File Offset: 0x0040E5D8
		public IGmTeleportToEntityT UnPack()
		{
			IGmTeleportToEntityT gmTeleportToEntityT = new IGmTeleportToEntityT();
			this.UnPackTo(gmTeleportToEntityT);
			return gmTeleportToEntityT;
		}

		// Token: 0x0601CDC0 RID: 118208 RVA: 0x004103F3 File Offset: 0x0040E5F3
		public void UnPackTo(IGmTeleportToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PreIncId = this.PreIncId;
		}

		// Token: 0x0601CDC1 RID: 118209 RVA: 0x0041041C File Offset: 0x0040E61C
		public static Offset<IGmTeleportToEntity> Pack(FlatBufferBuilder builder, IGmTeleportToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmTeleportToEntity>);
			}
			return IGmTeleportToEntity.CreateIGmTeleportToEntity(builder, _o.Type, _o.EntityId, _o.PreIncId);
		}

		// Token: 0x0400D25E RID: 53854
		private Table __p;
	}
}
