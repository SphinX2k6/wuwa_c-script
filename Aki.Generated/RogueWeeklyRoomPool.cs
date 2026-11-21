using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001117 RID: 4375
	public struct RogueWeeklyRoomPool : IFlatbufferObject
	{
		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x003117D1 File Offset: 0x0030F9D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x003117DE File Offset: 0x0030F9DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x003117E8 File Offset: 0x0030F9E8
		public static RogueWeeklyRoomPool GetRootAsRogueWeeklyRoomPool(ByteBuffer _bb)
		{
			return RogueWeeklyRoomPool.GetRootAsRogueWeeklyRoomPool(_bb, default(RogueWeeklyRoomPool));
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x00311804 File Offset: 0x0030FA04
		public static RogueWeeklyRoomPool GetRootAsRogueWeeklyRoomPool(ByteBuffer _bb, RogueWeeklyRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x00311821 File Offset: 0x0030FA21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x00311830 File Offset: 0x0030FA30
		public RogueWeeklyRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x00311840 File Offset: 0x0030FA40
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

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x0031187C File Offset: 0x0030FA7C
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

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x003118B8 File Offset: 0x0030FAB8
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

		// Token: 0x0600CCBD RID: 52413 RVA: 0x003118EF File Offset: 0x0030FAEF
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x003118FE File Offset: 0x0030FAFE
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400570F RID: 22287
		private Table __p;
	}
}
