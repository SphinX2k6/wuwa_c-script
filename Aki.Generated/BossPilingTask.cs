using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B42 RID: 2882
	public struct BossPilingTask : IFlatbufferObject
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x001E69DD File Offset: 0x001E4BDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x001E69EA File Offset: 0x001E4BEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x001E69F4 File Offset: 0x001E4BF4
		public static BossPilingTask GetRootAsBossPilingTask(ByteBuffer _bb)
		{
			return BossPilingTask.GetRootAsBossPilingTask(_bb, default(BossPilingTask));
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x001E6A10 File Offset: 0x001E4C10
		public static BossPilingTask GetRootAsBossPilingTask(ByteBuffer _bb, BossPilingTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x001E6A2D File Offset: 0x001E4C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x001E6A3C File Offset: 0x001E4C3C
		public BossPilingTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x001E6A4C File Offset: 0x001E4C4C
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

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x001E6A88 File Offset: 0x001E4C88
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

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x001E6AC4 File Offset: 0x001E4CC4
		public int DropId
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x001E6B00 File Offset: 0x001E4D00
		public int RewardCount
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x001E6B40 File Offset: 0x001E4D40
		public int BelongLevel
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

		// Token: 0x04004B3D RID: 19261
		private Table __p;
	}
}
