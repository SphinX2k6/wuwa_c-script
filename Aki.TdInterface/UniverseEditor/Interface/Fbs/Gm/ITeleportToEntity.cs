using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B25 RID: 19237
	public struct ITeleportToEntity : IFlatbufferObject
	{
		// Token: 0x170086E9 RID: 34537
		// (get) Token: 0x0601D036 RID: 118838 RVA: 0x0041418C File Offset: 0x0041238C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D037 RID: 118839 RVA: 0x00414199 File Offset: 0x00412399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x004141A0 File Offset: 0x004123A0
		public static ITeleportToEntity GetRootAsITeleportToEntity(ByteBuffer _bb)
		{
			return ITeleportToEntity.GetRootAsITeleportToEntity(_bb, default(ITeleportToEntity));
		}

		// Token: 0x0601D039 RID: 118841 RVA: 0x004141BC File Offset: 0x004123BC
		public static ITeleportToEntity GetRootAsITeleportToEntity(ByteBuffer _bb, ITeleportToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D03A RID: 118842 RVA: 0x004141D9 File Offset: 0x004123D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D03B RID: 118843 RVA: 0x004141E8 File Offset: 0x004123E8
		public ITeleportToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086EA RID: 34538
		// (get) Token: 0x0601D03C RID: 118844 RVA: 0x004141F8 File Offset: 0x004123F8
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

		// Token: 0x170086EB RID: 34539
		// (get) Token: 0x0601D03D RID: 118845 RVA: 0x00414234 File Offset: 0x00412434
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

		// Token: 0x170086EC RID: 34540
		// (get) Token: 0x0601D03E RID: 118846 RVA: 0x00414270 File Offset: 0x00412470
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

		// Token: 0x170086ED RID: 34541
		// (get) Token: 0x0601D03F RID: 118847 RVA: 0x004142B0 File Offset: 0x004124B0
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

		// Token: 0x0601D040 RID: 118848 RVA: 0x004142ED File Offset: 0x004124ED
		public static Offset<ITeleportToEntity> CreateITeleportToEntity(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntityId = 0, float Rotation = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToEntity.AddRotation(builder, Rotation);
			ITeleportToEntity.AddEntityId(builder, EntityId);
			ITeleportToEntity.AddNullMask(builder, NullMask);
			ITeleportToEntity.AddType(builder, Type);
			return ITeleportToEntity.EndITeleportToEntity(builder);
		}

		// Token: 0x0601D041 RID: 118849 RVA: 0x00414319 File Offset: 0x00412519
		public static void StartITeleportToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D042 RID: 118850 RVA: 0x00414322 File Offset: 0x00412522
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D043 RID: 118851 RVA: 0x0041432D File Offset: 0x0041252D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x00414338 File Offset: 0x00412538
		public static void AddRotation(FlatBufferBuilder builder, float rotation)
		{
			builder.AddFloat(2, rotation, 0.0);
		}

		// Token: 0x0601D045 RID: 118853 RVA: 0x0041434B File Offset: 0x0041254B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601D046 RID: 118854 RVA: 0x00414356 File Offset: 0x00412556
		public static Offset<ITeleportToEntity> EndITeleportToEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToEntity>(builder.EndTable());
		}

		// Token: 0x0601D047 RID: 118855 RVA: 0x00414364 File Offset: 0x00412564
		public ITeleportToEntityT UnPack()
		{
			ITeleportToEntityT teleportToEntityT = new ITeleportToEntityT();
			this.UnPackTo(teleportToEntityT);
			return teleportToEntityT;
		}

		// Token: 0x0601D048 RID: 118856 RVA: 0x0041437F File Offset: 0x0041257F
		public void UnPackTo(ITeleportToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Rotation = this.Rotation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D049 RID: 118857 RVA: 0x004143B4 File Offset: 0x004125B4
		public static Offset<ITeleportToEntity> Pack(FlatBufferBuilder builder, ITeleportToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToEntity>);
			}
			return ITeleportToEntity.CreateITeleportToEntity(builder, _o.Type, _o.EntityId, _o.Rotation, _o.NullMask);
		}

		// Token: 0x0400D2BC RID: 53948
		private Table __p;
	}
}
