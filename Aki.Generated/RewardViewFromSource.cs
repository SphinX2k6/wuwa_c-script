using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBE RID: 4030
	public struct RewardViewFromSource : IFlatbufferObject
	{
		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600BC12 RID: 48146 RVA: 0x002DE4E8 File Offset: 0x002DC6E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x002DE4F5 File Offset: 0x002DC6F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x002DE4FC File Offset: 0x002DC6FC
		public static RewardViewFromSource GetRootAsRewardViewFromSource(ByteBuffer _bb)
		{
			return RewardViewFromSource.GetRootAsRewardViewFromSource(_bb, default(RewardViewFromSource));
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x002DE518 File Offset: 0x002DC718
		public static RewardViewFromSource GetRootAsRewardViewFromSource(ByteBuffer _bb, RewardViewFromSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x002DE535 File Offset: 0x002DC735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x002DE544 File Offset: 0x002DC744
		public RewardViewFromSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x002DE554 File Offset: 0x002DC754
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

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600BC19 RID: 48153 RVA: 0x002DE590 File Offset: 0x002DC790
		public int RewardSourceId
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

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x002DE5CC File Offset: 0x002DC7CC
		public int RewardViewId
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

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x002DE608 File Offset: 0x002DC808
		public bool RewardNotifyNotTrick
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005098 RID: 20632
		private Table __p;
	}
}
