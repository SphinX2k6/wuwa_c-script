using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD6 RID: 3286
	public struct DirectTrainPro : IFlatbufferObject
	{
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x0023390E File Offset: 0x00231B0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x0023391B File Offset: 0x00231B1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00233924 File Offset: 0x00231B24
		public static DirectTrainPro GetRootAsDirectTrainPro(ByteBuffer _bb)
		{
			return DirectTrainPro.GetRootAsDirectTrainPro(_bb, default(DirectTrainPro));
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00233940 File Offset: 0x00231B40
		public static DirectTrainPro GetRootAsDirectTrainPro(ByteBuffer _bb, DirectTrainPro obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x0023395D File Offset: 0x00231B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x0023396C File Offset: 0x00231B6C
		public DirectTrainPro __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x0023397C File Offset: 0x00231B7C
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

		// Token: 0x04005203 RID: 20995
		private Table __p;
	}
}
