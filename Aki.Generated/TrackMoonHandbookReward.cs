using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001149 RID: 4425
	public struct TrackMoonHandbookReward : IFlatbufferObject
	{
		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600E0E8 RID: 57576 RVA: 0x00332A08 File Offset: 0x00330C08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x00332A15 File Offset: 0x00330C15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x00332A1C File Offset: 0x00330C1C
		public static TrackMoonHandbookReward GetRootAsTrackMoonHandbookReward(ByteBuffer _bb)
		{
			return TrackMoonHandbookReward.GetRootAsTrackMoonHandbookReward(_bb, default(TrackMoonHandbookReward));
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x00332A38 File Offset: 0x00330C38
		public static TrackMoonHandbookReward GetRootAsTrackMoonHandbookReward(ByteBuffer _bb, TrackMoonHandbookReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x00332A55 File Offset: 0x00330C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x00332A64 File Offset: 0x00330C64
		public TrackMoonHandbookReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600E0EE RID: 57582 RVA: 0x00332A74 File Offset: 0x00330C74
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

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600E0EF RID: 57583 RVA: 0x00332AB0 File Offset: 0x00330CB0
		public int Goal
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

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600E0F0 RID: 57584 RVA: 0x00332AEC File Offset: 0x00330CEC
		public int RewardInfo
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

		// Token: 0x0400528E RID: 21134
		private Table __p;
	}
}
