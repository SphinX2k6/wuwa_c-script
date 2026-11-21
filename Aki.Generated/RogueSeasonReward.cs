using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001108 RID: 4360
	public struct RogueSeasonReward : IFlatbufferObject
	{
		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600CB34 RID: 52020 RVA: 0x0030DF7A File Offset: 0x0030C17A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x0030DF87 File Offset: 0x0030C187
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x0030DF90 File Offset: 0x0030C190
		public static RogueSeasonReward GetRootAsRogueSeasonReward(ByteBuffer _bb)
		{
			return RogueSeasonReward.GetRootAsRogueSeasonReward(_bb, default(RogueSeasonReward));
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x0030DFAC File Offset: 0x0030C1AC
		public static RogueSeasonReward GetRootAsRogueSeasonReward(ByteBuffer _bb, RogueSeasonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x0030DFC9 File Offset: 0x0030C1C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x0030DFD8 File Offset: 0x0030C1D8
		public RogueSeasonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600CB3A RID: 52026 RVA: 0x0030DFE8 File Offset: 0x0030C1E8
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

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600CB3B RID: 52027 RVA: 0x0030E024 File Offset: 0x0030C224
		public int SeasonId
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

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x0030E060 File Offset: 0x0030C260
		public int Index
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

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x0030E09C File Offset: 0x0030C29C
		public int Point
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x0030E0DC File Offset: 0x0030C2DC
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040056FA RID: 22266
		private Table __p;
	}
}
