using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746B RID: 29803
	public struct IPlayerEntity : IFlatbufferObject
	{
		// Token: 0x1700DAF8 RID: 56056
		// (get) Token: 0x060342C1 RID: 213697 RVA: 0x00707591 File Offset: 0x00705791
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060342C2 RID: 213698 RVA: 0x0070759E File Offset: 0x0070579E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060342C3 RID: 213699 RVA: 0x007075A8 File Offset: 0x007057A8
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb)
		{
			return IPlayerEntity.GetRootAsIPlayerEntity(_bb, default(IPlayerEntity));
		}

		// Token: 0x060342C4 RID: 213700 RVA: 0x007075C4 File Offset: 0x007057C4
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb, IPlayerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060342C5 RID: 213701 RVA: 0x007075E1 File Offset: 0x007057E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060342C6 RID: 213702 RVA: 0x007075F0 File Offset: 0x007057F0
		public IPlayerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAF9 RID: 56057
		// (get) Token: 0x060342C7 RID: 213703 RVA: 0x00707600 File Offset: 0x00705800
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

		// Token: 0x1700DAFA RID: 56058
		// (get) Token: 0x060342C8 RID: 213704 RVA: 0x0070763C File Offset: 0x0070583C
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

		// Token: 0x1700DAFB RID: 56059
		// (get) Token: 0x060342C9 RID: 213705 RVA: 0x00707678 File Offset: 0x00705878
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

		// Token: 0x060342CA RID: 213706 RVA: 0x007076B4 File Offset: 0x007058B4
		public static Offset<IPlayerEntity> CreateIPlayerEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, EPlayerTargetType PlayerTargetType = EPlayerTargetType.CurrentRole, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlayerEntity.AddNullMask(builder, NullMask);
			IPlayerEntity.AddPlayerTargetType(builder, PlayerTargetType);
			IPlayerEntity.AddType(builder, Type);
			return IPlayerEntity.EndIPlayerEntity(builder);
		}

		// Token: 0x060342CB RID: 213707 RVA: 0x007076D8 File Offset: 0x007058D8
		public static void StartIPlayerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060342CC RID: 213708 RVA: 0x007076E1 File Offset: 0x007058E1
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060342CD RID: 213709 RVA: 0x007076EC File Offset: 0x007058EC
		public static void AddPlayerTargetType(FlatBufferBuilder builder, EPlayerTargetType playerTargetType)
		{
			builder.AddByte(1, (byte)playerTargetType, 0);
		}

		// Token: 0x060342CE RID: 213710 RVA: 0x007076F7 File Offset: 0x007058F7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060342CF RID: 213711 RVA: 0x00707702 File Offset: 0x00705902
		public static Offset<IPlayerEntity> EndIPlayerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerEntity>(builder.EndTable());
		}

		// Token: 0x060342D0 RID: 213712 RVA: 0x00707710 File Offset: 0x00705910
		public IPlayerEntityT UnPack()
		{
			IPlayerEntityT playerEntityT = new IPlayerEntityT();
			this.UnPackTo(playerEntityT);
			return playerEntityT;
		}

		// Token: 0x060342D1 RID: 213713 RVA: 0x0070772B File Offset: 0x0070592B
		public void UnPackTo(IPlayerEntityT _o)
		{
			_o.Type = this.Type;
			_o.PlayerTargetType = this.PlayerTargetType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060342D2 RID: 213714 RVA: 0x00707754 File Offset: 0x00705954
		public static Offset<IPlayerEntity> Pack(FlatBufferBuilder builder, IPlayerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerEntity>);
			}
			return IPlayerEntity.CreateIPlayerEntity(builder, _o.Type, _o.PlayerTargetType, _o.NullMask);
		}

		// Token: 0x040125E7 RID: 75239
		private Table __p;
	}
}
