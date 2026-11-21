using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F85 RID: 3973
	public struct OccupyScore : IFlatbufferObject
	{
		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x0600A740 RID: 42816 RVA: 0x002BF6E8 File Offset: 0x002BD8E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x002BF6F5 File Offset: 0x002BD8F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A742 RID: 42818 RVA: 0x002BF6FC File Offset: 0x002BD8FC
		public static OccupyScore GetRootAsOccupyScore(ByteBuffer _bb)
		{
			return OccupyScore.GetRootAsOccupyScore(_bb, default(OccupyScore));
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x002BF718 File Offset: 0x002BD918
		public static OccupyScore GetRootAsOccupyScore(ByteBuffer _bb, OccupyScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A744 RID: 42820 RVA: 0x002BF735 File Offset: 0x002BD935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x002BF744 File Offset: 0x002BD944
		public OccupyScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x0600A746 RID: 42822 RVA: 0x002BF754 File Offset: 0x002BD954
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

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600A747 RID: 42823 RVA: 0x002BF790 File Offset: 0x002BD990
		public int NeedScore
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

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x002BF7CC File Offset: 0x002BD9CC
		public int ScoreReward
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

		// Token: 0x04005539 RID: 21817
		private Table __p;
	}
}
