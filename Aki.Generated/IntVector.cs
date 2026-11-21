using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001306 RID: 4870
	public struct IntVector : IFlatbufferObject
	{
		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0600F822 RID: 63522 RVA: 0x003734F0 File Offset: 0x003716F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x003734FD File Offset: 0x003716FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x00373504 File Offset: 0x00371704
		public static IntVector GetRootAsIntVector(ByteBuffer _bb)
		{
			return IntVector.GetRootAsIntVector(_bb, default(IntVector));
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x00373520 File Offset: 0x00371720
		public static IntVector GetRootAsIntVector(ByteBuffer _bb, IntVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x0037353D File Offset: 0x0037173D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x0037354C File Offset: 0x0037174C
		public IntVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x0600F828 RID: 63528 RVA: 0x0037355C File Offset: 0x0037175C
		public int X
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

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x0600F829 RID: 63529 RVA: 0x00373598 File Offset: 0x00371798
		public int Y
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

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x0600F82A RID: 63530 RVA: 0x003735D4 File Offset: 0x003717D4
		public int Z
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

		// Token: 0x04005981 RID: 22913
		private Table __p;
	}
}
