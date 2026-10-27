using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001174 RID: 4468
	public struct TravelTaskArea : IFlatbufferObject
	{
		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x0033BFD1 File Offset: 0x0033A1D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E51B RID: 58651 RVA: 0x0033BFDE File Offset: 0x0033A1DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E51C RID: 58652 RVA: 0x0033BFE8 File Offset: 0x0033A1E8
		public static TravelTaskArea GetRootAsTravelTaskArea(ByteBuffer _bb)
		{
			return TravelTaskArea.GetRootAsTravelTaskArea(_bb, default(TravelTaskArea));
		}

		// Token: 0x0600E51D RID: 58653 RVA: 0x0033C004 File Offset: 0x0033A204
		public static TravelTaskArea GetRootAsTravelTaskArea(ByteBuffer _bb, TravelTaskArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E51E RID: 58654 RVA: 0x0033C021 File Offset: 0x0033A221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E51F RID: 58655 RVA: 0x0033C030 File Offset: 0x0033A230
		public TravelTaskArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600E520 RID: 58656 RVA: 0x0033C040 File Offset: 0x0033A240
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

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600E521 RID: 58657 RVA: 0x0033C07C File Offset: 0x0033A27C
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

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600E522 RID: 58658 RVA: 0x0033C0B8 File Offset: 0x0033A2B8
		public int UnLockCondition
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

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600E523 RID: 58659 RVA: 0x0033C0F4 File Offset: 0x0033A2F4
		public int UnlockAccessId
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

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600E524 RID: 58660 RVA: 0x0033C134 File Offset: 0x0033A334
		public int Sort
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

		// Token: 0x040052BA RID: 21178
		private Table __p;
	}
}
