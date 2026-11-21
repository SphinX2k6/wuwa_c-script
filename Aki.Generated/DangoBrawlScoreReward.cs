using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB3 RID: 3251
	public struct DangoBrawlScoreReward : IFlatbufferObject
	{
		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x0022DB08 File Offset: 0x0022BD08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x0022DB15 File Offset: 0x0022BD15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x0022DB1C File Offset: 0x0022BD1C
		public static DangoBrawlScoreReward GetRootAsDangoBrawlScoreReward(ByteBuffer _bb)
		{
			return DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(_bb, default(DangoBrawlScoreReward));
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x0022DB38 File Offset: 0x0022BD38
		public static DangoBrawlScoreReward GetRootAsDangoBrawlScoreReward(ByteBuffer _bb, DangoBrawlScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x0022DB55 File Offset: 0x0022BD55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x0022DB64 File Offset: 0x0022BD64
		public DangoBrawlScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x0022DB74 File Offset: 0x0022BD74
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x0022DBB0 File Offset: 0x0022BDB0
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x0022DBEC File Offset: 0x0022BDEC
		public int Score
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

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x0022DC28 File Offset: 0x0022BE28
		public int DropId
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

		// Token: 0x040051DE RID: 20958
		private Table __p;
	}
}
