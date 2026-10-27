using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA7 RID: 4007
	public struct RefreshRatio : IFlatbufferObject
	{
		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x002DAF59 File Offset: 0x002D9159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x002DAF66 File Offset: 0x002D9166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x002DAF70 File Offset: 0x002D9170
		public static RefreshRatio GetRootAsRefreshRatio(ByteBuffer _bb)
		{
			return RefreshRatio.GetRootAsRefreshRatio(_bb, default(RefreshRatio));
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x002DAF8C File Offset: 0x002D918C
		public static RefreshRatio GetRootAsRefreshRatio(ByteBuffer _bb, RefreshRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x002DAFA9 File Offset: 0x002D91A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x002DAFB8 File Offset: 0x002D91B8
		public RefreshRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x002DAFC8 File Offset: 0x002D91C8
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

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x002DB004 File Offset: 0x002D9204
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

		// Token: 0x04005080 RID: 20608
		private Table __p;
	}
}
