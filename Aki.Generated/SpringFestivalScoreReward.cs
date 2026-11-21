using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001221 RID: 4641
	public struct SpringFestivalScoreReward : IFlatbufferObject
	{
		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600E631 RID: 58929 RVA: 0x0034B9F5 File Offset: 0x00349BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E632 RID: 58930 RVA: 0x0034BA02 File Offset: 0x00349C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E633 RID: 58931 RVA: 0x0034BA0C File Offset: 0x00349C0C
		public static SpringFestivalScoreReward GetRootAsSpringFestivalScoreReward(ByteBuffer _bb)
		{
			return SpringFestivalScoreReward.GetRootAsSpringFestivalScoreReward(_bb, default(SpringFestivalScoreReward));
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x0034BA28 File Offset: 0x00349C28
		public static SpringFestivalScoreReward GetRootAsSpringFestivalScoreReward(ByteBuffer _bb, SpringFestivalScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x0034BA45 File Offset: 0x00349C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x0034BA54 File Offset: 0x00349C54
		public SpringFestivalScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600E637 RID: 58935 RVA: 0x0034BA64 File Offset: 0x00349C64
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

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600E638 RID: 58936 RVA: 0x0034BAA0 File Offset: 0x00349CA0
		public int Activity
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

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600E639 RID: 58937 RVA: 0x0034BADC File Offset: 0x00349CDC
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

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600E63A RID: 58938 RVA: 0x0034BB18 File Offset: 0x00349D18
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

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600E63B RID: 58939 RVA: 0x0034BB58 File Offset: 0x00349D58
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

		// Token: 0x04005862 RID: 22626
		private Table __p;
	}
}
