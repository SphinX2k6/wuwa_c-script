using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004663 RID: 18019
	public struct IGmGotoRogueRoomInGm : IFlatbufferObject
	{
		// Token: 0x17007FE6 RID: 32742
		// (get) Token: 0x0601B569 RID: 111977 RVA: 0x003E3438 File Offset: 0x003E1638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B56A RID: 111978 RVA: 0x003E3445 File Offset: 0x003E1645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B56B RID: 111979 RVA: 0x003E344C File Offset: 0x003E164C
		public static IGmGotoRogueRoomInGm GetRootAsIGmGotoRogueRoomInGm(ByteBuffer _bb)
		{
			return IGmGotoRogueRoomInGm.GetRootAsIGmGotoRogueRoomInGm(_bb, default(IGmGotoRogueRoomInGm));
		}

		// Token: 0x0601B56C RID: 111980 RVA: 0x003E3468 File Offset: 0x003E1668
		public static IGmGotoRogueRoomInGm GetRootAsIGmGotoRogueRoomInGm(ByteBuffer _bb, IGmGotoRogueRoomInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B56D RID: 111981 RVA: 0x003E3485 File Offset: 0x003E1685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B56E RID: 111982 RVA: 0x003E3494 File Offset: 0x003E1694
		public IGmGotoRogueRoomInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FE7 RID: 32743
		// (get) Token: 0x0601B56F RID: 111983 RVA: 0x003E34A4 File Offset: 0x003E16A4
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

		// Token: 0x17007FE8 RID: 32744
		// (get) Token: 0x0601B570 RID: 111984 RVA: 0x003E34E0 File Offset: 0x003E16E0
		public int RoomId
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

		// Token: 0x17007FE9 RID: 32745
		// (get) Token: 0x0601B571 RID: 111985 RVA: 0x003E351C File Offset: 0x003E171C
		public string RoomType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B572 RID: 111986 RVA: 0x003E3553 File Offset: 0x003E1753
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B573 RID: 111987 RVA: 0x003E3562 File Offset: 0x003E1762
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B574 RID: 111988 RVA: 0x003E3570 File Offset: 0x003E1770
		public static Offset<IGmGotoRogueRoomInGm> CreateIGmGotoRogueRoomInGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int RoomId = 0, StringOffset RoomTypeOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGmGotoRogueRoomInGm.AddRoomType(builder, RoomTypeOffset);
			IGmGotoRogueRoomInGm.AddRoomId(builder, RoomId);
			IGmGotoRogueRoomInGm.AddType(builder, Type);
			return IGmGotoRogueRoomInGm.EndIGmGotoRogueRoomInGm(builder);
		}

		// Token: 0x0601B575 RID: 111989 RVA: 0x003E3594 File Offset: 0x003E1794
		public static void StartIGmGotoRogueRoomInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B576 RID: 111990 RVA: 0x003E359D File Offset: 0x003E179D
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B577 RID: 111991 RVA: 0x003E35A8 File Offset: 0x003E17A8
		public static void AddRoomId(FlatBufferBuilder builder, int roomId)
		{
			builder.AddInt(1, roomId, 0);
		}

		// Token: 0x0601B578 RID: 111992 RVA: 0x003E35B3 File Offset: 0x003E17B3
		public static void AddRoomType(FlatBufferBuilder builder, StringOffset roomTypeOffset)
		{
			builder.AddOffset(2, roomTypeOffset.Value, 0);
		}

		// Token: 0x0601B579 RID: 111993 RVA: 0x003E35C3 File Offset: 0x003E17C3
		public static Offset<IGmGotoRogueRoomInGm> EndIGmGotoRogueRoomInGm(FlatBufferBuilder builder)
		{
			return new Offset<IGmGotoRogueRoomInGm>(builder.EndTable());
		}

		// Token: 0x0601B57A RID: 111994 RVA: 0x003E35D0 File Offset: 0x003E17D0
		public IGmGotoRogueRoomInGmT UnPack()
		{
			IGmGotoRogueRoomInGmT gmGotoRogueRoomInGmT = new IGmGotoRogueRoomInGmT();
			this.UnPackTo(gmGotoRogueRoomInGmT);
			return gmGotoRogueRoomInGmT;
		}

		// Token: 0x0601B57B RID: 111995 RVA: 0x003E35EB File Offset: 0x003E17EB
		public void UnPackTo(IGmGotoRogueRoomInGmT _o)
		{
			_o.Type = this.Type;
			_o.RoomId = this.RoomId;
			_o.RoomType = this.RoomType;
		}

		// Token: 0x0601B57C RID: 111996 RVA: 0x003E3614 File Offset: 0x003E1814
		public static Offset<IGmGotoRogueRoomInGm> Pack(FlatBufferBuilder builder, IGmGotoRogueRoomInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmGotoRogueRoomInGm>);
			}
			StringOffset roomTypeOffset = (_o.RoomType == null) ? default(StringOffset) : builder.CreateString(_o.RoomType);
			return IGmGotoRogueRoomInGm.CreateIGmGotoRogueRoomInGm(builder, _o.Type, _o.RoomId, roomTypeOffset);
		}

		// Token: 0x0400C81D RID: 51229
		private Table __p;
	}
}
