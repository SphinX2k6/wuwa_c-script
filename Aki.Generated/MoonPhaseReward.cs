using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E22 RID: 3618
	public struct MoonPhaseReward : IFlatbufferObject
	{
		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x002891E4 File Offset: 0x002873E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x002891F1 File Offset: 0x002873F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x002891F8 File Offset: 0x002873F8
		public static MoonPhaseReward GetRootAsMoonPhaseReward(ByteBuffer _bb)
		{
			return MoonPhaseReward.GetRootAsMoonPhaseReward(_bb, default(MoonPhaseReward));
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x00289214 File Offset: 0x00287414
		public static MoonPhaseReward GetRootAsMoonPhaseReward(ByteBuffer _bb, MoonPhaseReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x00289231 File Offset: 0x00287431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x00289240 File Offset: 0x00287440
		public MoonPhaseReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x060095D7 RID: 38359 RVA: 0x00289250 File Offset: 0x00287450
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x060095D8 RID: 38360 RVA: 0x0028928C File Offset: 0x0028748C
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x002892C8 File Offset: 0x002874C8
		public int Reward
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

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x060095DA RID: 38362 RVA: 0x00289304 File Offset: 0x00287504
		public int NeedMoonNum
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

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x060095DB RID: 38363 RVA: 0x00289344 File Offset: 0x00287544
		public int ItemId
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

		// Token: 0x04004EC7 RID: 20167
		private Table __p;
	}
}
