using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126B RID: 4715
	public struct ToughCalcRatio : IFlatbufferObject
	{
		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600ECCD RID: 60621 RVA: 0x0035A5D8 File Offset: 0x003587D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECCE RID: 60622 RVA: 0x0035A5E5 File Offset: 0x003587E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECCF RID: 60623 RVA: 0x0035A5EC File Offset: 0x003587EC
		public static ToughCalcRatio GetRootAsToughCalcRatio(ByteBuffer _bb)
		{
			return ToughCalcRatio.GetRootAsToughCalcRatio(_bb, default(ToughCalcRatio));
		}

		// Token: 0x0600ECD0 RID: 60624 RVA: 0x0035A608 File Offset: 0x00358808
		public static ToughCalcRatio GetRootAsToughCalcRatio(ByteBuffer _bb, ToughCalcRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECD1 RID: 60625 RVA: 0x0035A625 File Offset: 0x00358825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECD2 RID: 60626 RVA: 0x0035A634 File Offset: 0x00358834
		public ToughCalcRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x0035A644 File Offset: 0x00358844
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600ECD4 RID: 60628 RVA: 0x0035A68C File Offset: 0x0035888C
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

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600ECD5 RID: 60629 RVA: 0x0035A6C8 File Offset: 0x003588C8
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

		// Token: 0x040058B9 RID: 22713
		private Table __p;
	}
}
