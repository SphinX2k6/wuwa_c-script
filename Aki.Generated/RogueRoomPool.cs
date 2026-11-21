using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001104 RID: 4356
	public struct RogueRoomPool : IFlatbufferObject
	{
		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600CAE3 RID: 51939 RVA: 0x0030D348 File Offset: 0x0030B548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x0030D355 File Offset: 0x0030B555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x0030D35C File Offset: 0x0030B55C
		public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb)
		{
			return RogueRoomPool.GetRootAsRogueRoomPool(_bb, default(RogueRoomPool));
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x0030D378 File Offset: 0x0030B578
		public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb, RogueRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x0030D395 File Offset: 0x0030B595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x0030D3A4 File Offset: 0x0030B5A4
		public RogueRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x0030D3B4 File Offset: 0x0030B5B4
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

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600CAEA RID: 51946 RVA: 0x0030D3F0 File Offset: 0x0030B5F0
		public int BehaviorTree
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

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600CAEB RID: 51947 RVA: 0x0030D42C File Offset: 0x0030B62C
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

		// Token: 0x0600CAEC RID: 51948 RVA: 0x0030D463 File Offset: 0x0030B663
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x0030D472 File Offset: 0x0030B672
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040056F4 RID: 22260
		private Table __p;
	}
}
