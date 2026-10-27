using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAA RID: 4010
	public struct RegressBonusReward : IFlatbufferObject
	{
		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600BABD RID: 47805 RVA: 0x002DB611 File Offset: 0x002D9811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x002DB61E File Offset: 0x002D981E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x002DB628 File Offset: 0x002D9828
		public static RegressBonusReward GetRootAsRegressBonusReward(ByteBuffer _bb)
		{
			return RegressBonusReward.GetRootAsRegressBonusReward(_bb, default(RegressBonusReward));
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x002DB644 File Offset: 0x002D9844
		public static RegressBonusReward GetRootAsRegressBonusReward(ByteBuffer _bb, RegressBonusReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BAC1 RID: 47809 RVA: 0x002DB661 File Offset: 0x002D9861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x002DB670 File Offset: 0x002D9870
		public RegressBonusReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600BAC3 RID: 47811 RVA: 0x002DB680 File Offset: 0x002D9880
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

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x002DB6BC File Offset: 0x002D98BC
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600BAC5 RID: 47813 RVA: 0x002DB6F8 File Offset: 0x002D98F8
		public int NeedScore
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

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x002DB734 File Offset: 0x002D9934
		public int Drop
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

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600BAC7 RID: 47815 RVA: 0x002DB774 File Offset: 0x002D9974
		public int PayDrop
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

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x002DB7B4 File Offset: 0x002D99B4
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

		// Token: 0x04005083 RID: 20611
		private Table __p;
	}
}
