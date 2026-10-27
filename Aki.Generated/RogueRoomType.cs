using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101E RID: 4126
	public struct RogueRoomType : IFlatbufferObject
	{
		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600C4B6 RID: 50358 RVA: 0x002F16C9 File Offset: 0x002EF8C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x002F16D6 File Offset: 0x002EF8D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x002F16E0 File Offset: 0x002EF8E0
		public static RogueRoomType GetRootAsRogueRoomType(ByteBuffer _bb)
		{
			return RogueRoomType.GetRootAsRogueRoomType(_bb, default(RogueRoomType));
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x002F16FC File Offset: 0x002EF8FC
		public static RogueRoomType GetRootAsRogueRoomType(ByteBuffer _bb, RogueRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x002F1719 File Offset: 0x002EF919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x002F1728 File Offset: 0x002EF928
		public RogueRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600C4BC RID: 50364 RVA: 0x002F1738 File Offset: 0x002EF938
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

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600C4BD RID: 50365 RVA: 0x002F1774 File Offset: 0x002EF974
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

		// Token: 0x0600C4BE RID: 50366 RVA: 0x002F17AB File Offset: 0x002EF9AB
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x002F17BA File Offset: 0x002EF9BA
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600C4C0 RID: 50368 RVA: 0x002F17D4 File Offset: 0x002EF9D4
		public int RoomTipsType
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

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600C4C1 RID: 50369 RVA: 0x002F1810 File Offset: 0x002EFA10
		public string RoomsMusicState
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

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x002F1848 File Offset: 0x002EFA48
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x002F1858 File Offset: 0x002EFA58
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400510E RID: 20750
		private Table __p;
	}
}
