using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F9 RID: 4345
	public struct RogueResRoomType : IFlatbufferObject
	{
		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600CA1E RID: 51742 RVA: 0x0030B930 File Offset: 0x00309B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x0030B93D File Offset: 0x00309B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x0030B944 File Offset: 0x00309B44
		public static RogueResRoomType GetRootAsRogueResRoomType(ByteBuffer _bb)
		{
			return RogueResRoomType.GetRootAsRogueResRoomType(_bb, default(RogueResRoomType));
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x0030B960 File Offset: 0x00309B60
		public static RogueResRoomType GetRootAsRogueResRoomType(ByteBuffer _bb, RogueResRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x0030B97D File Offset: 0x00309B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x0030B98C File Offset: 0x00309B8C
		public RogueResRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600CA24 RID: 51748 RVA: 0x0030B99C File Offset: 0x00309B9C
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

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600CA25 RID: 51749 RVA: 0x0030B9D8 File Offset: 0x00309BD8
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

		// Token: 0x0600CA26 RID: 51750 RVA: 0x0030BA0F File Offset: 0x00309C0F
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x0030BA1E File Offset: 0x00309C1E
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600CA28 RID: 51752 RVA: 0x0030BA38 File Offset: 0x00309C38
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

		// Token: 0x0600CA29 RID: 51753 RVA: 0x0030BA6F File Offset: 0x00309C6F
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x0030BA7E File Offset: 0x00309C7E
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040056E6 RID: 22246
		private Table __p;
	}
}
