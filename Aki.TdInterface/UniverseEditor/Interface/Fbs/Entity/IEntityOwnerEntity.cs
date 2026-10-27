using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047BA RID: 18362
	public struct IEntityOwnerEntity : IFlatbufferObject
	{
		// Token: 0x170083E4 RID: 33764
		// (get) Token: 0x0601C595 RID: 116117 RVA: 0x004033AC File Offset: 0x004015AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C596 RID: 116118 RVA: 0x004033B9 File Offset: 0x004015B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C597 RID: 116119 RVA: 0x004033C0 File Offset: 0x004015C0
		public static IEntityOwnerEntity GetRootAsIEntityOwnerEntity(ByteBuffer _bb)
		{
			return IEntityOwnerEntity.GetRootAsIEntityOwnerEntity(_bb, default(IEntityOwnerEntity));
		}

		// Token: 0x0601C598 RID: 116120 RVA: 0x004033DC File Offset: 0x004015DC
		public static IEntityOwnerEntity GetRootAsIEntityOwnerEntity(ByteBuffer _bb, IEntityOwnerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C599 RID: 116121 RVA: 0x004033F9 File Offset: 0x004015F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x00403408 File Offset: 0x00401608
		public IEntityOwnerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083E5 RID: 33765
		// (get) Token: 0x0601C59B RID: 116123 RVA: 0x00403418 File Offset: 0x00401618
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

		// Token: 0x170083E6 RID: 33766
		// (get) Token: 0x0601C59C RID: 116124 RVA: 0x00403454 File Offset: 0x00401654
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

		// Token: 0x170083E7 RID: 33767
		// (get) Token: 0x0601C59D RID: 116125 RVA: 0x00403490 File Offset: 0x00401690
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

		// Token: 0x170083E8 RID: 33768
		// (get) Token: 0x0601C59E RID: 116126 RVA: 0x004034CC File Offset: 0x004016CC
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

		// Token: 0x0601C59F RID: 116127 RVA: 0x00403504 File Offset: 0x00401704
		public Span<byte> GetFromFlowUidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C5A0 RID: 116128 RVA: 0x00403514 File Offset: 0x00401714
		public byte[] GetFromFlowUidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x00403523 File Offset: 0x00401723
		public static Offset<IEntityOwnerEntity> CreateIEntityOwnerEntity(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int LevelId = 0, int EntityId = 0, StringOffset FromFlowUidOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEntityOwnerEntity.AddFromFlowUid(builder, FromFlowUidOffset);
			IEntityOwnerEntity.AddEntityId(builder, EntityId);
			IEntityOwnerEntity.AddLevelId(builder, LevelId);
			IEntityOwnerEntity.AddType(builder, Type);
			return IEntityOwnerEntity.EndIEntityOwnerEntity(builder);
		}

		// Token: 0x0601C5A2 RID: 116130 RVA: 0x0040354F File Offset: 0x0040174F
		public static void StartIEntityOwnerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C5A3 RID: 116131 RVA: 0x00403558 File Offset: 0x00401758
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5A4 RID: 116132 RVA: 0x00403563 File Offset: 0x00401763
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x0040356E File Offset: 0x0040176E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601C5A6 RID: 116134 RVA: 0x00403579 File Offset: 0x00401779
		public static void AddFromFlowUid(FlatBufferBuilder builder, StringOffset fromFlowUidOffset)
		{
			builder.AddOffset(3, fromFlowUidOffset.Value, 0);
		}

		// Token: 0x0601C5A7 RID: 116135 RVA: 0x00403589 File Offset: 0x00401789
		public static Offset<IEntityOwnerEntity> EndIEntityOwnerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerEntity>(builder.EndTable());
		}

		// Token: 0x0601C5A8 RID: 116136 RVA: 0x00403598 File Offset: 0x00401798
		public IEntityOwnerEntityT UnPack()
		{
			IEntityOwnerEntityT entityOwnerEntityT = new IEntityOwnerEntityT();
			this.UnPackTo(entityOwnerEntityT);
			return entityOwnerEntityT;
		}

		// Token: 0x0601C5A9 RID: 116137 RVA: 0x004035B3 File Offset: 0x004017B3
		public void UnPackTo(IEntityOwnerEntityT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.EntityId = this.EntityId;
			_o.FromFlowUid = this.FromFlowUid;
		}

		// Token: 0x0601C5AA RID: 116138 RVA: 0x004035E8 File Offset: 0x004017E8
		public static Offset<IEntityOwnerEntity> Pack(FlatBufferBuilder builder, IEntityOwnerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerEntity>);
			}
			StringOffset fromFlowUidOffset = (_o.FromFlowUid == null) ? default(StringOffset) : builder.CreateString(_o.FromFlowUid);
			return IEntityOwnerEntity.CreateIEntityOwnerEntity(builder, _o.Type, _o.LevelId, _o.EntityId, fromFlowUidOffset);
		}

		// Token: 0x0400CC3D RID: 52285
		private Table __p;
	}
}
