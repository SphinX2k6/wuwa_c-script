using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108F RID: 4239
	public struct RefreshRatio : IFlatbufferObject
	{
		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x002F7706 File Offset: 0x002F5906
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0D4 RID: 49364 RVA: 0x002F7713 File Offset: 0x002F5913
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x002F771C File Offset: 0x002F591C
		public static RefreshRatio GetRootAsRefreshRatio(ByteBuffer _bb)
		{
			return RefreshRatio.GetRootAsRefreshRatio(_bb, default(RefreshRatio));
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x002F7738 File Offset: 0x002F5938
		public static RefreshRatio GetRootAsRefreshRatio(ByteBuffer _bb, RefreshRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x002F7755 File Offset: 0x002F5955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0D8 RID: 49368 RVA: 0x002F7764 File Offset: 0x002F5964
		public RefreshRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600C0D9 RID: 49369 RVA: 0x002F7774 File Offset: 0x002F5974
		public int Count
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

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x002F77B0 File Offset: 0x002F59B0
		public int DecRatio
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

		// Token: 0x04005668 RID: 22120
		private Table __p;
	}
}
