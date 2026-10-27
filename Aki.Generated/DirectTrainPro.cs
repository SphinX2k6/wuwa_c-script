using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF4 RID: 3060
	public struct DirectTrainPro : IFlatbufferObject
	{
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x00214239 File Offset: 0x00212439
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00214246 File Offset: 0x00212446
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00214250 File Offset: 0x00212450
		public static DirectTrainPro GetRootAsDirectTrainPro(ByteBuffer _bb)
		{
			return DirectTrainPro.GetRootAsDirectTrainPro(_bb, default(DirectTrainPro));
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x0021426C File Offset: 0x0021246C
		public static DirectTrainPro GetRootAsDirectTrainPro(ByteBuffer _bb, DirectTrainPro obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00214289 File Offset: 0x00212489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00214298 File Offset: 0x00212498
		public DirectTrainPro __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06006299 RID: 25241 RVA: 0x002142A8 File Offset: 0x002124A8
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

		// Token: 0x04004C21 RID: 19489
		private Table __p;
	}
}
