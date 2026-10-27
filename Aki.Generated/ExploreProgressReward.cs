using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4E RID: 3150
	public struct ExploreProgressReward : IFlatbufferObject
	{
		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x00228302 File Offset: 0x00226502
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x0022830F File Offset: 0x0022650F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x00228318 File Offset: 0x00226518
		public static ExploreProgressReward GetRootAsExploreProgressReward(ByteBuffer _bb)
		{
			return ExploreProgressReward.GetRootAsExploreProgressReward(_bb, default(ExploreProgressReward));
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x00228334 File Offset: 0x00226534
		public static ExploreProgressReward GetRootAsExploreProgressReward(ByteBuffer _bb, ExploreProgressReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00228351 File Offset: 0x00226551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00228360 File Offset: 0x00226560
		public ExploreProgressReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x00228370 File Offset: 0x00226570
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

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06006B6C RID: 27500 RVA: 0x002283AC File Offset: 0x002265AC
		public int Area
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

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x002283E8 File Offset: 0x002265E8
		public int StepId
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x00228424 File Offset: 0x00226624
		public int DropReward
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

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x00228464 File Offset: 0x00226664
		public int NeedExploreProgress
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

		// Token: 0x04004C95 RID: 19605
		private Table __p;
	}
}
