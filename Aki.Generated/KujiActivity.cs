using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E77 RID: 3703
	public struct KujiActivity : IFlatbufferObject
	{
		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06008E74 RID: 36468 RVA: 0x00289DCD File Offset: 0x00287FCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x00289DDA File Offset: 0x00287FDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x00289DE4 File Offset: 0x00287FE4
		public static KujiActivity GetRootAsKujiActivity(ByteBuffer _bb)
		{
			return KujiActivity.GetRootAsKujiActivity(_bb, default(KujiActivity));
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x00289E00 File Offset: 0x00288000
		public static KujiActivity GetRootAsKujiActivity(ByteBuffer _bb, KujiActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x00289E1D File Offset: 0x0028801D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x00289E2C File Offset: 0x0028802C
		public KujiActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06008E7A RID: 36474 RVA: 0x00289E3C File Offset: 0x0028803C
		public int ActivityId
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

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06008E7B RID: 36475 RVA: 0x00289E78 File Offset: 0x00288078
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

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06008E7C RID: 36476 RVA: 0x00289EB4 File Offset: 0x002880B4
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

		// Token: 0x04005404 RID: 21508
		private Table __p;
	}
}
