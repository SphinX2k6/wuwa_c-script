using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE2 RID: 4066
	public struct PhantomWildItem : IFlatbufferObject
	{
		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x002D4AB8 File Offset: 0x002D2CB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x002D4AC5 File Offset: 0x002D2CC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x002D4ACC File Offset: 0x002D2CCC
		public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb)
		{
			return PhantomWildItem.GetRootAsPhantomWildItem(_bb, default(PhantomWildItem));
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x002D4AE8 File Offset: 0x002D2CE8
		public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb, PhantomWildItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0BC RID: 45244 RVA: 0x002D4B05 File Offset: 0x002D2D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x002D4B14 File Offset: 0x002D2D14
		public PhantomWildItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x002D4B24 File Offset: 0x002D2D24
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

		// Token: 0x040055AA RID: 21930
		private Table __p;
	}
}
