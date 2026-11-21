using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B4 RID: 4788
	public struct TurntableInfo : IFlatbufferObject
	{
		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x0600F333 RID: 62259 RVA: 0x00368700 File Offset: 0x00366900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F334 RID: 62260 RVA: 0x0036870D File Offset: 0x0036690D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F335 RID: 62261 RVA: 0x00368714 File Offset: 0x00366914
		public static TurntableInfo GetRootAsTurntableInfo(ByteBuffer _bb)
		{
			return TurntableInfo.GetRootAsTurntableInfo(_bb, default(TurntableInfo));
		}

		// Token: 0x0600F336 RID: 62262 RVA: 0x00368730 File Offset: 0x00366930
		public static TurntableInfo GetRootAsTurntableInfo(ByteBuffer _bb, TurntableInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F337 RID: 62263 RVA: 0x0036874D File Offset: 0x0036694D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F338 RID: 62264 RVA: 0x0036875C File Offset: 0x0036695C
		public TurntableInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x0600F339 RID: 62265 RVA: 0x0036876C File Offset: 0x0036696C
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

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x0600F33A RID: 62266 RVA: 0x003687A8 File Offset: 0x003669A8
		public int CostItemId
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

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x0600F33B RID: 62267 RVA: 0x003687E4 File Offset: 0x003669E4
		public int CostItemCount
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

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x0600F33C RID: 62268 RVA: 0x00368820 File Offset: 0x00366A20
		public int TurntableType
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

		// Token: 0x04005908 RID: 22792
		private Table __p;
	}
}
