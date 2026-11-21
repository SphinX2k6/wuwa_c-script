using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001118 RID: 4376
	public struct RogueWeeklyRoomType : IFlatbufferObject
	{
		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x00311915 File Offset: 0x0030FB15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x00311922 File Offset: 0x0030FB22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x0031192C File Offset: 0x0030FB2C
		public static RogueWeeklyRoomType GetRootAsRogueWeeklyRoomType(ByteBuffer _bb)
		{
			return RogueWeeklyRoomType.GetRootAsRogueWeeklyRoomType(_bb, default(RogueWeeklyRoomType));
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x00311948 File Offset: 0x0030FB48
		public static RogueWeeklyRoomType GetRootAsRogueWeeklyRoomType(ByteBuffer _bb, RogueWeeklyRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x00311965 File Offset: 0x0030FB65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x00311974 File Offset: 0x0030FB74
		public RogueWeeklyRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600CCC5 RID: 52421 RVA: 0x00311984 File Offset: 0x0030FB84
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

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600CCC6 RID: 52422 RVA: 0x003119C0 File Offset: 0x0030FBC0
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

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x003119F7 File Offset: 0x0030FBF7
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x00311A06 File Offset: 0x0030FC06
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600CCC9 RID: 52425 RVA: 0x00311A20 File Offset: 0x0030FC20
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

		// Token: 0x0600CCCA RID: 52426 RVA: 0x00311A57 File Offset: 0x0030FC57
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x00311A66 File Offset: 0x0030FC66
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005710 RID: 22288
		private Table __p;
	}
}
