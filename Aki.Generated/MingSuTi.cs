using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF0 RID: 3824
	public struct MingSuTi : IFlatbufferObject
	{
		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x002A37A9 File Offset: 0x002A19A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x002A37B6 File Offset: 0x002A19B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x002A37C0 File Offset: 0x002A19C0
		public static MingSuTi GetRootAsMingSuTi(ByteBuffer _bb)
		{
			return MingSuTi.GetRootAsMingSuTi(_bb, default(MingSuTi));
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x002A37DC File Offset: 0x002A19DC
		public static MingSuTi GetRootAsMingSuTi(ByteBuffer _bb, MingSuTi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x002A37F9 File Offset: 0x002A19F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x002A3808 File Offset: 0x002A1A08
		public MingSuTi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06009A50 RID: 39504 RVA: 0x002A3818 File Offset: 0x002A1A18
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

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x002A3854 File Offset: 0x002A1A54
		public int Type
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

		// Token: 0x04005495 RID: 21653
		private Table __p;
	}
}
