using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001199 RID: 4505
	public struct SheriffCriminal : IFlatbufferObject
	{
		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600D89C RID: 55452 RVA: 0x0032BE74 File Offset: 0x0032A074
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D89D RID: 55453 RVA: 0x0032BE81 File Offset: 0x0032A081
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D89E RID: 55454 RVA: 0x0032BE88 File Offset: 0x0032A088
		public static SheriffCriminal GetRootAsSheriffCriminal(ByteBuffer _bb)
		{
			return SheriffCriminal.GetRootAsSheriffCriminal(_bb, default(SheriffCriminal));
		}

		// Token: 0x0600D89F RID: 55455 RVA: 0x0032BEA4 File Offset: 0x0032A0A4
		public static SheriffCriminal GetRootAsSheriffCriminal(ByteBuffer _bb, SheriffCriminal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8A0 RID: 55456 RVA: 0x0032BEC1 File Offset: 0x0032A0C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x0032BED0 File Offset: 0x0032A0D0
		public SheriffCriminal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x0032BEE0 File Offset: 0x0032A0E0
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

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x0032BF1C File Offset: 0x0032A11C
		public int InitIdentityId
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

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x0032BF58 File Offset: 0x0032A158
		public int SheriffAnomalyId
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

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600D8A5 RID: 55461 RVA: 0x0032BF94 File Offset: 0x0032A194
		public int DropId
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

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x0032BFD4 File Offset: 0x0032A1D4
		public int Priority
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

		// Token: 0x040057AB RID: 22443
		private Table __p;
	}
}
