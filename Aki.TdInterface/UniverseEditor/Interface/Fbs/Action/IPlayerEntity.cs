using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF0 RID: 27888
	public struct IPlayerEntity : IFlatbufferObject
	{
		// Token: 0x1700CFB4 RID: 53172
		// (get) Token: 0x060312CD RID: 201421 RVA: 0x006AC061 File Offset: 0x006AA261
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312CE RID: 201422 RVA: 0x006AC06E File Offset: 0x006AA26E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312CF RID: 201423 RVA: 0x006AC078 File Offset: 0x006AA278
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb)
		{
			return IPlayerEntity.GetRootAsIPlayerEntity(_bb, default(IPlayerEntity));
		}

		// Token: 0x060312D0 RID: 201424 RVA: 0x006AC094 File Offset: 0x006AA294
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb, IPlayerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312D1 RID: 201425 RVA: 0x006AC0B1 File Offset: 0x006AA2B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312D2 RID: 201426 RVA: 0x006AC0C0 File Offset: 0x006AA2C0
		public IPlayerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFB5 RID: 53173
		// (get) Token: 0x060312D3 RID: 201427 RVA: 0x006AC0D0 File Offset: 0x006AA2D0
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

		// Token: 0x1700CFB6 RID: 53174
		// (get) Token: 0x060312D4 RID: 201428 RVA: 0x006AC10C File Offset: 0x006AA30C
		public EPlayerTargetType PlayerTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerTargetType.CurrentRole;
				}
				return (EPlayerTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFB7 RID: 53175
		// (get) Token: 0x060312D5 RID: 201429 RVA: 0x006AC148 File Offset: 0x006AA348
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060312D6 RID: 201430 RVA: 0x006AC184 File Offset: 0x006AA384
		public static Offset<IPlayerEntity> CreateIPlayerEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, EPlayerTargetType PlayerTargetType = EPlayerTargetType.CurrentRole, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlayerEntity.AddNullMask(builder, NullMask);
			IPlayerEntity.AddPlayerTargetType(builder, PlayerTargetType);
			IPlayerEntity.AddType(builder, Type);
			return IPlayerEntity.EndIPlayerEntity(builder);
		}

		// Token: 0x060312D7 RID: 201431 RVA: 0x006AC1A8 File Offset: 0x006AA3A8
		public static void StartIPlayerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060312D8 RID: 201432 RVA: 0x006AC1B1 File Offset: 0x006AA3B1
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312D9 RID: 201433 RVA: 0x006AC1BC File Offset: 0x006AA3BC
		public static void AddPlayerTargetType(FlatBufferBuilder builder, EPlayerTargetType playerTargetType)
		{
			builder.AddByte(1, (byte)playerTargetType, 0);
		}

		// Token: 0x060312DA RID: 201434 RVA: 0x006AC1C7 File Offset: 0x006AA3C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060312DB RID: 201435 RVA: 0x006AC1D2 File Offset: 0x006AA3D2
		public static Offset<IPlayerEntity> EndIPlayerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerEntity>(builder.EndTable());
		}

		// Token: 0x060312DC RID: 201436 RVA: 0x006AC1E0 File Offset: 0x006AA3E0
		public IPlayerEntityT UnPack()
		{
			IPlayerEntityT playerEntityT = new IPlayerEntityT();
			this.UnPackTo(playerEntityT);
			return playerEntityT;
		}

		// Token: 0x060312DD RID: 201437 RVA: 0x006AC1FB File Offset: 0x006AA3FB
		public void UnPackTo(IPlayerEntityT _o)
		{
			_o.Type = this.Type;
			_o.PlayerTargetType = this.PlayerTargetType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060312DE RID: 201438 RVA: 0x006AC224 File Offset: 0x006AA424
		public static Offset<IPlayerEntity> Pack(FlatBufferBuilder builder, IPlayerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerEntity>);
			}
			return IPlayerEntity.CreateIPlayerEntity(builder, _o.Type, _o.PlayerTargetType, _o.NullMask);
		}

		// Token: 0x0401166D RID: 71277
		private Table __p;
	}
}
