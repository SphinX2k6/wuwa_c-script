using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB4 RID: 4020
	public struct RegressSignReward : IFlatbufferObject
	{
		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600BB45 RID: 47941 RVA: 0x002DC990 File Offset: 0x002DAB90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x002DC99D File Offset: 0x002DAB9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x002DC9A4 File Offset: 0x002DABA4
		public static RegressSignReward GetRootAsRegressSignReward(ByteBuffer _bb)
		{
			return RegressSignReward.GetRootAsRegressSignReward(_bb, default(RegressSignReward));
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x002DC9C0 File Offset: 0x002DABC0
		public static RegressSignReward GetRootAsRegressSignReward(ByteBuffer _bb, RegressSignReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB49 RID: 47945 RVA: 0x002DC9DD File Offset: 0x002DABDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x002DC9EC File Offset: 0x002DABEC
		public RegressSignReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600BB4B RID: 47947 RVA: 0x002DC9FC File Offset: 0x002DABFC
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

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x002DCA38 File Offset: 0x002DAC38
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

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600BB4D RID: 47949 RVA: 0x002DCA74 File Offset: 0x002DAC74
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002DCAB0 File Offset: 0x002DACB0
		public int SignDayNum
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

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600BB4F RID: 47951 RVA: 0x002DCAF0 File Offset: 0x002DACF0
		public int SignReward
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

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x002DCB30 File Offset: 0x002DAD30
		public int Version
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400508D RID: 20621
		private Table __p;
	}
}
