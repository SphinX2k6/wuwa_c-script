using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCC RID: 4044
	public struct PhantomFetterHandBook : IFlatbufferObject
	{
		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x002D0618 File Offset: 0x002CE818
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x002D0625 File Offset: 0x002CE825
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x002D062C File Offset: 0x002CE82C
		public static PhantomFetterHandBook GetRootAsPhantomFetterHandBook(ByteBuffer _bb)
		{
			return PhantomFetterHandBook.GetRootAsPhantomFetterHandBook(_bb, default(PhantomFetterHandBook));
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x002D0648 File Offset: 0x002CE848
		public static PhantomFetterHandBook GetRootAsPhantomFetterHandBook(ByteBuffer _bb, PhantomFetterHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x002D0665 File Offset: 0x002CE865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x002D0674 File Offset: 0x002CE874
		public PhantomFetterHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x002D0684 File Offset: 0x002CE884
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

		// Token: 0x0400558E RID: 21902
		private Table __p;
	}
}
