using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001106 RID: 4358
	public struct SurvivorsScoreReward : IFlatbufferObject
	{
		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600DB67 RID: 56167 RVA: 0x00326054 File Offset: 0x00324254
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x00326061 File Offset: 0x00324261
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB69 RID: 56169 RVA: 0x00326068 File Offset: 0x00324268
		public static SurvivorsScoreReward GetRootAsSurvivorsScoreReward(ByteBuffer _bb)
		{
			return SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(_bb, default(SurvivorsScoreReward));
		}

		// Token: 0x0600DB6A RID: 56170 RVA: 0x00326084 File Offset: 0x00324284
		public static SurvivorsScoreReward GetRootAsSurvivorsScoreReward(ByteBuffer _bb, SurvivorsScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x003260A1 File Offset: 0x003242A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x003260B0 File Offset: 0x003242B0
		public SurvivorsScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x003260C0 File Offset: 0x003242C0
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

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600DB6E RID: 56174 RVA: 0x003260FC File Offset: 0x003242FC
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

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x00326138 File Offset: 0x00324338
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

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600DB70 RID: 56176 RVA: 0x00326174 File Offset: 0x00324374
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

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600DB71 RID: 56177 RVA: 0x003261B4 File Offset: 0x003243B4
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

		// Token: 0x0400523F RID: 21055
		private Table __p;
	}
}
