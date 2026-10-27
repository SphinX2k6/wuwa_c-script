using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C82 RID: 3202
	public struct FishingManualRefresh : IFlatbufferObject
	{
		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x00231E34 File Offset: 0x00230034
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00231E41 File Offset: 0x00230041
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00231E48 File Offset: 0x00230048
		public static FishingManualRefresh GetRootAsFishingManualRefresh(ByteBuffer _bb)
		{
			return FishingManualRefresh.GetRootAsFishingManualRefresh(_bb, default(FishingManualRefresh));
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00231E64 File Offset: 0x00230064
		public static FishingManualRefresh GetRootAsFishingManualRefresh(ByteBuffer _bb, FishingManualRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x00231E81 File Offset: 0x00230081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x00231E90 File Offset: 0x00230090
		public FishingManualRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06006FAB RID: 28587 RVA: 0x00231EA0 File Offset: 0x002300A0
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

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00231EDC File Offset: 0x002300DC
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

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06006FAD RID: 28589 RVA: 0x00231F18 File Offset: 0x00230118
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

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x00231F54 File Offset: 0x00230154
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

		// Token: 0x04004CD2 RID: 19666
		private Table __p;
	}
}
