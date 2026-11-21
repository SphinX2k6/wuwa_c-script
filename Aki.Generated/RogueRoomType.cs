using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001106 RID: 4358
	public struct RogueRoomType : IFlatbufferObject
	{
		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600CB00 RID: 51968 RVA: 0x0030D6D1 File Offset: 0x0030B8D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x0030D6DE File Offset: 0x0030B8DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x0030D6E8 File Offset: 0x0030B8E8
		public static RogueRoomType GetRootAsRogueRoomType(ByteBuffer _bb)
		{
			return RogueRoomType.GetRootAsRogueRoomType(_bb, default(RogueRoomType));
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x0030D704 File Offset: 0x0030B904
		public static RogueRoomType GetRootAsRogueRoomType(ByteBuffer _bb, RogueRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x0030D721 File Offset: 0x0030B921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x0030D730 File Offset: 0x0030B930
		public RogueRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x0030D740 File Offset: 0x0030B940
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

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600CB07 RID: 51975 RVA: 0x0030D77C File Offset: 0x0030B97C
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

		// Token: 0x0600CB08 RID: 51976 RVA: 0x0030D7B3 File Offset: 0x0030B9B3
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CB09 RID: 51977 RVA: 0x0030D7C2 File Offset: 0x0030B9C2
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x0030D7DC File Offset: 0x0030B9DC
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

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x0030D818 File Offset: 0x0030BA18
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

		// Token: 0x0600CB0C RID: 51980 RVA: 0x0030D850 File Offset: 0x0030BA50
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x0030D860 File Offset: 0x0030BA60
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040056F6 RID: 22262
		private Table __p;
	}
}
