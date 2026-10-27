using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9A RID: 3482
	public struct KurotatoDraw : IFlatbufferObject
	{
		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x0026D0ED File Offset: 0x0026B2ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x0026D0FA File Offset: 0x0026B2FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x0026D104 File Offset: 0x0026B304
		public static KurotatoDraw GetRootAsKurotatoDraw(ByteBuffer _bb)
		{
			return KurotatoDraw.GetRootAsKurotatoDraw(_bb, default(KurotatoDraw));
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x0026D120 File Offset: 0x0026B320
		public static KurotatoDraw GetRootAsKurotatoDraw(ByteBuffer _bb, KurotatoDraw obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x0026D13D File Offset: 0x0026B33D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x0026D14C File Offset: 0x0026B34C
		public KurotatoDraw __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x0026D15C File Offset: 0x0026B35C
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

		// Token: 0x04004E2A RID: 20010
		private Table __p;
	}
}
