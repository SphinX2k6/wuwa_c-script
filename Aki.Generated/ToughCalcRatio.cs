using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001135 RID: 4405
	public struct ToughCalcRatio : IFlatbufferObject
	{
		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600DF5F RID: 57183 RVA: 0x0032F060 File Offset: 0x0032D260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x0032F06D File Offset: 0x0032D26D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x0032F074 File Offset: 0x0032D274
		public static ToughCalcRatio GetRootAsToughCalcRatio(ByteBuffer _bb)
		{
			return ToughCalcRatio.GetRootAsToughCalcRatio(_bb, default(ToughCalcRatio));
		}

		// Token: 0x0600DF62 RID: 57186 RVA: 0x0032F090 File Offset: 0x0032D290
		public static ToughCalcRatio GetRootAsToughCalcRatio(ByteBuffer _bb, ToughCalcRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF63 RID: 57187 RVA: 0x0032F0AD File Offset: 0x0032D2AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF64 RID: 57188 RVA: 0x0032F0BC File Offset: 0x0032D2BC
		public ToughCalcRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600DF65 RID: 57189 RVA: 0x0032F0CC File Offset: 0x0032D2CC
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x0032F114 File Offset: 0x0032D314
		public int RatioNormal
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

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600DF67 RID: 57191 RVA: 0x0032F150 File Offset: 0x0032D350
		public int RatioSpecial
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

		// Token: 0x04005276 RID: 21110
		private Table __p;
	}
}
