using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046BD RID: 18109
	public struct ITeleportToEntity : IFlatbufferObject
	{
		// Token: 0x170080A8 RID: 32936
		// (get) Token: 0x0601B861 RID: 112737 RVA: 0x003E7EF0 File Offset: 0x003E60F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B862 RID: 112738 RVA: 0x003E7EFD File Offset: 0x003E60FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B863 RID: 112739 RVA: 0x003E7F04 File Offset: 0x003E6104
		public static ITeleportToEntity GetRootAsITeleportToEntity(ByteBuffer _bb)
		{
			return ITeleportToEntity.GetRootAsITeleportToEntity(_bb, default(ITeleportToEntity));
		}

		// Token: 0x0601B864 RID: 112740 RVA: 0x003E7F20 File Offset: 0x003E6120
		public static ITeleportToEntity GetRootAsITeleportToEntity(ByteBuffer _bb, ITeleportToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B865 RID: 112741 RVA: 0x003E7F3D File Offset: 0x003E613D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B866 RID: 112742 RVA: 0x003E7F4C File Offset: 0x003E614C
		public ITeleportToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080A9 RID: 32937
		// (get) Token: 0x0601B867 RID: 112743 RVA: 0x003E7F5C File Offset: 0x003E615C
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

		// Token: 0x170080AA RID: 32938
		// (get) Token: 0x0601B868 RID: 112744 RVA: 0x003E7F98 File Offset: 0x003E6198
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

		// Token: 0x170080AB RID: 32939
		// (get) Token: 0x0601B869 RID: 112745 RVA: 0x003E7FD4 File Offset: 0x003E61D4
		public float Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170080AC RID: 32940
		// (get) Token: 0x0601B86A RID: 112746 RVA: 0x003E8014 File Offset: 0x003E6214
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B86B RID: 112747 RVA: 0x003E8051 File Offset: 0x003E6251
		public static Offset<ITeleportToEntity> CreateITeleportToEntity(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntityId = 0, float Rotation = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToEntity.AddRotation(builder, Rotation);
			ITeleportToEntity.AddEntityId(builder, EntityId);
			ITeleportToEntity.AddNullMask(builder, NullMask);
			ITeleportToEntity.AddType(builder, Type);
			return ITeleportToEntity.EndITeleportToEntity(builder);
		}

		// Token: 0x0601B86C RID: 112748 RVA: 0x003E807D File Offset: 0x003E627D
		public static void StartITeleportToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B86D RID: 112749 RVA: 0x003E8086 File Offset: 0x003E6286
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B86E RID: 112750 RVA: 0x003E8091 File Offset: 0x003E6291
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601B86F RID: 112751 RVA: 0x003E809C File Offset: 0x003E629C
		public static void AddRotation(FlatBufferBuilder builder, float rotation)
		{
			builder.AddFloat(2, rotation, 0.0);
		}

		// Token: 0x0601B870 RID: 112752 RVA: 0x003E80AF File Offset: 0x003E62AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B871 RID: 112753 RVA: 0x003E80BA File Offset: 0x003E62BA
		public static Offset<ITeleportToEntity> EndITeleportToEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToEntity>(builder.EndTable());
		}

		// Token: 0x0601B872 RID: 112754 RVA: 0x003E80C8 File Offset: 0x003E62C8
		public ITeleportToEntityT UnPack()
		{
			ITeleportToEntityT teleportToEntityT = new ITeleportToEntityT();
			this.UnPackTo(teleportToEntityT);
			return teleportToEntityT;
		}

		// Token: 0x0601B873 RID: 112755 RVA: 0x003E80E3 File Offset: 0x003E62E3
		public void UnPackTo(ITeleportToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Rotation = this.Rotation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x003E8118 File Offset: 0x003E6318
		public static Offset<ITeleportToEntity> Pack(FlatBufferBuilder builder, ITeleportToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToEntity>);
			}
			return ITeleportToEntity.CreateITeleportToEntity(builder, _o.Type, _o.EntityId, _o.Rotation, _o.NullMask);
		}

		// Token: 0x0400C88D RID: 51341
		private Table __p;
	}
}
