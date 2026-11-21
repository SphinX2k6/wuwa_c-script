using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005184 RID: 20868
	public struct IPlayerEntity : IFlatbufferObject
	{
		// Token: 0x17009576 RID: 38262
		// (get) Token: 0x06020D5F RID: 134495 RVA: 0x0048B854 File Offset: 0x00489A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D60 RID: 134496 RVA: 0x0048B861 File Offset: 0x00489A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D61 RID: 134497 RVA: 0x0048B868 File Offset: 0x00489A68
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb)
		{
			return IPlayerEntity.GetRootAsIPlayerEntity(_bb, default(IPlayerEntity));
		}

		// Token: 0x06020D62 RID: 134498 RVA: 0x0048B884 File Offset: 0x00489A84
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb, IPlayerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D63 RID: 134499 RVA: 0x0048B8A1 File Offset: 0x00489AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D64 RID: 134500 RVA: 0x0048B8B0 File Offset: 0x00489AB0
		public IPlayerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009577 RID: 38263
		// (get) Token: 0x06020D65 RID: 134501 RVA: 0x0048B8C0 File Offset: 0x00489AC0
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D66 RID: 134502 RVA: 0x0048B8FC File Offset: 0x00489AFC
		public static Offset<IPlayerEntity> CreateIPlayerEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			IPlayerEntity.AddType(builder, Type);
			return IPlayerEntity.EndIPlayerEntity(builder);
		}

		// Token: 0x06020D67 RID: 134503 RVA: 0x0048B912 File Offset: 0x00489B12
		public static void StartIPlayerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020D68 RID: 134504 RVA: 0x0048B91B File Offset: 0x00489B1B
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D69 RID: 134505 RVA: 0x0048B926 File Offset: 0x00489B26
		public static Offset<IPlayerEntity> EndIPlayerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerEntity>(builder.EndTable());
		}

		// Token: 0x06020D6A RID: 134506 RVA: 0x0048B934 File Offset: 0x00489B34
		public IPlayerEntityT UnPack()
		{
			IPlayerEntityT playerEntityT = new IPlayerEntityT();
			this.UnPackTo(playerEntityT);
			return playerEntityT;
		}

		// Token: 0x06020D6B RID: 134507 RVA: 0x0048B94F File Offset: 0x00489B4F
		public void UnPackTo(IPlayerEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020D6C RID: 134508 RVA: 0x0048B960 File Offset: 0x00489B60
		public static Offset<IPlayerEntity> Pack(FlatBufferBuilder builder, IPlayerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerEntity>);
			}
			return IPlayerEntity.CreateIPlayerEntity(builder, _o.Type);
		}

		// Token: 0x0400E16C RID: 57708
		private Table __p;
	}
}
