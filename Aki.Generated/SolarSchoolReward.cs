using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FA RID: 4602
	public struct SolarSchoolReward : IFlatbufferObject
	{
		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600E310 RID: 58128 RVA: 0x00344AA1 File Offset: 0x00342CA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00344AAE File Offset: 0x00342CAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x00344AB8 File Offset: 0x00342CB8
		public static SolarSchoolReward GetRootAsSolarSchoolReward(ByteBuffer _bb)
		{
			return SolarSchoolReward.GetRootAsSolarSchoolReward(_bb, default(SolarSchoolReward));
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x00344AD4 File Offset: 0x00342CD4
		public static SolarSchoolReward GetRootAsSolarSchoolReward(ByteBuffer _bb, SolarSchoolReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x00344AF1 File Offset: 0x00342CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x00344B00 File Offset: 0x00342D00
		public SolarSchoolReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600E316 RID: 58134 RVA: 0x00344B10 File Offset: 0x00342D10
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

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600E317 RID: 58135 RVA: 0x00344B4C File Offset: 0x00342D4C
		public int RewardType
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

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600E318 RID: 58136 RVA: 0x00344B88 File Offset: 0x00342D88
		public int TargetId
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

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600E319 RID: 58137 RVA: 0x00344BC4 File Offset: 0x00342DC4
		public int Value
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

		// Token: 0x04005838 RID: 22584
		private Table __p;
	}
}
