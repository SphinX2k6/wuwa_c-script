using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D92 RID: 3474
	public struct KujiActivity : IFlatbufferObject
	{
		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x0026B0A9 File Offset: 0x002692A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x0026B0B6 File Offset: 0x002692B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x0026B0C0 File Offset: 0x002692C0
		public static KujiActivity GetRootAsKujiActivity(ByteBuffer _bb)
		{
			return KujiActivity.GetRootAsKujiActivity(_bb, default(KujiActivity));
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x0026B0DC File Offset: 0x002692DC
		public static KujiActivity GetRootAsKujiActivity(ByteBuffer _bb, KujiActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x0026B0F9 File Offset: 0x002692F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x0026B108 File Offset: 0x00269308
		public KujiActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x0026B118 File Offset: 0x00269318
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

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x0026B154 File Offset: 0x00269354
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

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06008860 RID: 34912 RVA: 0x0026B190 File Offset: 0x00269390
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

		// Token: 0x04004E1F RID: 19999
		private Table __p;
	}
}
