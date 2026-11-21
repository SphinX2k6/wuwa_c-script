using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6A RID: 3690
	public struct JinzhouFly : IFlatbufferObject
	{
		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x002859C8 File Offset: 0x00283BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x002859D5 File Offset: 0x00283BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x002859DC File Offset: 0x00283BDC
		public static JinzhouFly GetRootAsJinzhouFly(ByteBuffer _bb)
		{
			return JinzhouFly.GetRootAsJinzhouFly(_bb, default(JinzhouFly));
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x002859F8 File Offset: 0x00283BF8
		public static JinzhouFly GetRootAsJinzhouFly(ByteBuffer _bb, JinzhouFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00285A15 File Offset: 0x00283C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x00285A24 File Offset: 0x00283C24
		public JinzhouFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x00285A34 File Offset: 0x00283C34
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

		// Token: 0x040053F6 RID: 21494
		private Table __p;
	}
}
