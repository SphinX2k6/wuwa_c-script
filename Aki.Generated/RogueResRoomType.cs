using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001011 RID: 4113
	public struct RogueResRoomType : IFlatbufferObject
	{
		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600C3D4 RID: 50132 RVA: 0x002EF854 File Offset: 0x002EDA54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x002EF861 File Offset: 0x002EDA61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3D6 RID: 50134 RVA: 0x002EF868 File Offset: 0x002EDA68
		public static RogueResRoomType GetRootAsRogueResRoomType(ByteBuffer _bb)
		{
			return RogueResRoomType.GetRootAsRogueResRoomType(_bb, default(RogueResRoomType));
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x002EF884 File Offset: 0x002EDA84
		public static RogueResRoomType GetRootAsRogueResRoomType(ByteBuffer _bb, RogueResRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x002EF8A1 File Offset: 0x002EDAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x002EF8B0 File Offset: 0x002EDAB0
		public RogueResRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600C3DA RID: 50138 RVA: 0x002EF8C0 File Offset: 0x002EDAC0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x002EF8FC File Offset: 0x002EDAFC
		public string RoomType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x002EF933 File Offset: 0x002EDB33
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x002EF942 File Offset: 0x002EDB42
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600C3DE RID: 50142 RVA: 0x002EF95C File Offset: 0x002EDB5C
		public string RoomsMusicState
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

		// Token: 0x0600C3DF RID: 50143 RVA: 0x002EF993 File Offset: 0x002EDB93
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C3E0 RID: 50144 RVA: 0x002EF9A2 File Offset: 0x002EDBA2
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050FE RID: 20734
		private Table __p;
	}
}
