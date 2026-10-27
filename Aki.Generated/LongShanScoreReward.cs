using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDA RID: 3546
	public struct LongShanScoreReward : IFlatbufferObject
	{
		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x0027ABE8 File Offset: 0x00278DE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F6A RID: 36714 RVA: 0x0027ABF5 File Offset: 0x00278DF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x0027ABFC File Offset: 0x00278DFC
		public static LongShanScoreReward GetRootAsLongShanScoreReward(ByteBuffer _bb)
		{
			return LongShanScoreReward.GetRootAsLongShanScoreReward(_bb, default(LongShanScoreReward));
		}

		// Token: 0x06008F6C RID: 36716 RVA: 0x0027AC18 File Offset: 0x00278E18
		public static LongShanScoreReward GetRootAsLongShanScoreReward(ByteBuffer _bb, LongShanScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x0027AC35 File Offset: 0x00278E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x0027AC44 File Offset: 0x00278E44
		public LongShanScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x0027AC54 File Offset: 0x00278E54
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

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0027AC90 File Offset: 0x00278E90
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

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06008F71 RID: 36721 RVA: 0x0027ACCC File Offset: 0x00278ECC
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

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06008F72 RID: 36722 RVA: 0x0027AD08 File Offset: 0x00278F08
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

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06008F73 RID: 36723 RVA: 0x0027AD48 File Offset: 0x00278F48
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

		// Token: 0x04004E75 RID: 20085
		private Table __p;
	}
}
