using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C22 RID: 19490
	public struct IEntityOwnerEntity : IFlatbufferObject
	{
		// Token: 0x17008A25 RID: 35365
		// (get) Token: 0x0601DD6A RID: 122218 RVA: 0x0042F648 File Offset: 0x0042D848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD6B RID: 122219 RVA: 0x0042F655 File Offset: 0x0042D855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD6C RID: 122220 RVA: 0x0042F65C File Offset: 0x0042D85C
		public static IEntityOwnerEntity GetRootAsIEntityOwnerEntity(ByteBuffer _bb)
		{
			return IEntityOwnerEntity.GetRootAsIEntityOwnerEntity(_bb, default(IEntityOwnerEntity));
		}

		// Token: 0x0601DD6D RID: 122221 RVA: 0x0042F678 File Offset: 0x0042D878
		public static IEntityOwnerEntity GetRootAsIEntityOwnerEntity(ByteBuffer _bb, IEntityOwnerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD6E RID: 122222 RVA: 0x0042F695 File Offset: 0x0042D895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD6F RID: 122223 RVA: 0x0042F6A4 File Offset: 0x0042D8A4
		public IEntityOwnerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A26 RID: 35366
		// (get) Token: 0x0601DD70 RID: 122224 RVA: 0x0042F6B4 File Offset: 0x0042D8B4
		public EEntityOwnerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityOwnerType.Quest;
				}
				return (EEntityOwnerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A27 RID: 35367
		// (get) Token: 0x0601DD71 RID: 122225 RVA: 0x0042F6F0 File Offset: 0x0042D8F0
		public int LevelId
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

		// Token: 0x17008A28 RID: 35368
		// (get) Token: 0x0601DD72 RID: 122226 RVA: 0x0042F72C File Offset: 0x0042D92C
		public int EntityId
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

		// Token: 0x17008A29 RID: 35369
		// (get) Token: 0x0601DD73 RID: 122227 RVA: 0x0042F768 File Offset: 0x0042D968
		public string FromFlowUid
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DD74 RID: 122228 RVA: 0x0042F7A0 File Offset: 0x0042D9A0
		public Span<byte> GetFromFlowUidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601DD75 RID: 122229 RVA: 0x0042F7B0 File Offset: 0x0042D9B0
		public byte[] GetFromFlowUidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601DD76 RID: 122230 RVA: 0x0042F7BF File Offset: 0x0042D9BF
		public static Offset<IEntityOwnerEntity> CreateIEntityOwnerEntity(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int LevelId = 0, int EntityId = 0, StringOffset FromFlowUidOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEntityOwnerEntity.AddFromFlowUid(builder, FromFlowUidOffset);
			IEntityOwnerEntity.AddEntityId(builder, EntityId);
			IEntityOwnerEntity.AddLevelId(builder, LevelId);
			IEntityOwnerEntity.AddType(builder, Type);
			return IEntityOwnerEntity.EndIEntityOwnerEntity(builder);
		}

		// Token: 0x0601DD77 RID: 122231 RVA: 0x0042F7EB File Offset: 0x0042D9EB
		public static void StartIEntityOwnerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DD78 RID: 122232 RVA: 0x0042F7F4 File Offset: 0x0042D9F4
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD79 RID: 122233 RVA: 0x0042F7FF File Offset: 0x0042D9FF
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601DD7A RID: 122234 RVA: 0x0042F80A File Offset: 0x0042DA0A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601DD7B RID: 122235 RVA: 0x0042F815 File Offset: 0x0042DA15
		public static void AddFromFlowUid(FlatBufferBuilder builder, StringOffset fromFlowUidOffset)
		{
			builder.AddOffset(3, fromFlowUidOffset.Value, 0);
		}

		// Token: 0x0601DD7C RID: 122236 RVA: 0x0042F825 File Offset: 0x0042DA25
		public static Offset<IEntityOwnerEntity> EndIEntityOwnerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerEntity>(builder.EndTable());
		}

		// Token: 0x0601DD7D RID: 122237 RVA: 0x0042F834 File Offset: 0x0042DA34
		public IEntityOwnerEntityT UnPack()
		{
			IEntityOwnerEntityT entityOwnerEntityT = new IEntityOwnerEntityT();
			this.UnPackTo(entityOwnerEntityT);
			return entityOwnerEntityT;
		}

		// Token: 0x0601DD7E RID: 122238 RVA: 0x0042F84F File Offset: 0x0042DA4F
		public void UnPackTo(IEntityOwnerEntityT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.EntityId = this.EntityId;
			_o.FromFlowUid = this.FromFlowUid;
		}

		// Token: 0x0601DD7F RID: 122239 RVA: 0x0042F884 File Offset: 0x0042DA84
		public static Offset<IEntityOwnerEntity> Pack(FlatBufferBuilder builder, IEntityOwnerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerEntity>);
			}
			StringOffset fromFlowUidOffset = (_o.FromFlowUid == null) ? default(StringOffset) : builder.CreateString(_o.FromFlowUid);
			return IEntityOwnerEntity.CreateIEntityOwnerEntity(builder, _o.Type, _o.LevelId, _o.EntityId, fromFlowUidOffset);
		}

		// Token: 0x0400D673 RID: 54899
		private Table __p;
	}
}
