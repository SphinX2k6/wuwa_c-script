using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D66 RID: 3430
	public struct FishingManualRefresh : IFlatbufferObject
	{
		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060075B0 RID: 30128 RVA: 0x00250FA4 File Offset: 0x0024F1A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00250FB1 File Offset: 0x0024F1B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00250FB8 File Offset: 0x0024F1B8
		public static FishingManualRefresh GetRootAsFishingManualRefresh(ByteBuffer _bb)
		{
			return FishingManualRefresh.GetRootAsFishingManualRefresh(_bb, default(FishingManualRefresh));
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00250FD4 File Offset: 0x0024F1D4
		public static FishingManualRefresh GetRootAsFishingManualRefresh(ByteBuffer _bb, FishingManualRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00250FF1 File Offset: 0x0024F1F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00251000 File Offset: 0x0024F200
		public FishingManualRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x00251010 File Offset: 0x0024F210
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x0025104C File Offset: 0x0024F24C
		public int EntrustPoolType
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060075B8 RID: 30136 RVA: 0x00251088 File Offset: 0x0024F288
		public int Star
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x002510C4 File Offset: 0x0024F2C4
		public int RefreshCost
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

		// Token: 0x040052B6 RID: 21174
		private Table __p;
	}
}
