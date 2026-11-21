using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBF RID: 3775
	public struct LongShanScoreReward : IFlatbufferObject
	{
		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009585 RID: 38277 RVA: 0x00298F20 File Offset: 0x00297120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00298F2D File Offset: 0x0029712D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00298F34 File Offset: 0x00297134
		public static LongShanScoreReward GetRootAsLongShanScoreReward(ByteBuffer _bb)
		{
			return LongShanScoreReward.GetRootAsLongShanScoreReward(_bb, default(LongShanScoreReward));
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00298F50 File Offset: 0x00297150
		public static LongShanScoreReward GetRootAsLongShanScoreReward(ByteBuffer _bb, LongShanScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00298F6D File Offset: 0x0029716D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00298F7C File Offset: 0x0029717C
		public LongShanScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x00298F8C File Offset: 0x0029718C
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

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600958C RID: 38284 RVA: 0x00298FC8 File Offset: 0x002971C8
		public int ActivityId
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

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x00299004 File Offset: 0x00297204
		public int ItemId
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

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600958E RID: 38286 RVA: 0x00299040 File Offset: 0x00297240
		public int Score
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

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x00299080 File Offset: 0x00297280
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

		// Token: 0x0400545A RID: 21594
		private Table __p;
	}
}
