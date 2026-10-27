using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFD RID: 3837
	public struct PhantomWildItem : IFlatbufferObject
	{
		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600AA97 RID: 43671 RVA: 0x002B7D18 File Offset: 0x002B5F18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x002B7D25 File Offset: 0x002B5F25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x002B7D2C File Offset: 0x002B5F2C
		public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb)
		{
			return PhantomWildItem.GetRootAsPhantomWildItem(_bb, default(PhantomWildItem));
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x002B7D48 File Offset: 0x002B5F48
		public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb, PhantomWildItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x002B7D65 File Offset: 0x002B5F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x002B7D74 File Offset: 0x002B5F74
		public PhantomWildItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x002B7D84 File Offset: 0x002B5F84
		public int ItemId
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

		// Token: 0x04004FC5 RID: 20421
		private Table __p;
	}
}
