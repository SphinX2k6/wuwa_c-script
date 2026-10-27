using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D85 RID: 3461
	public struct JinzhouFly : IFlatbufferObject
	{
		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008700 RID: 34560 RVA: 0x00267798 File Offset: 0x00265998
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x002677A5 File Offset: 0x002659A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x002677AC File Offset: 0x002659AC
		public static JinzhouFly GetRootAsJinzhouFly(ByteBuffer _bb)
		{
			return JinzhouFly.GetRootAsJinzhouFly(_bb, default(JinzhouFly));
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x002677C8 File Offset: 0x002659C8
		public static JinzhouFly GetRootAsJinzhouFly(ByteBuffer _bb, JinzhouFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x002677E5 File Offset: 0x002659E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x002677F4 File Offset: 0x002659F4
		public JinzhouFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x00267804 File Offset: 0x00265A04
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

		// Token: 0x04004E11 RID: 19985
		private Table __p;
	}
}
