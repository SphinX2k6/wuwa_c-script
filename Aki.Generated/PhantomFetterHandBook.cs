using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE7 RID: 3815
	public struct PhantomFetterHandBook : IFlatbufferObject
	{
		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002B35CC File Offset: 0x002B17CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8AA RID: 43178 RVA: 0x002B35D9 File Offset: 0x002B17D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x002B35E0 File Offset: 0x002B17E0
		public static PhantomFetterHandBook GetRootAsPhantomFetterHandBook(ByteBuffer _bb)
		{
			return PhantomFetterHandBook.GetRootAsPhantomFetterHandBook(_bb, default(PhantomFetterHandBook));
		}

		// Token: 0x0600A8AC RID: 43180 RVA: 0x002B35FC File Offset: 0x002B17FC
		public static PhantomFetterHandBook GetRootAsPhantomFetterHandBook(ByteBuffer _bb, PhantomFetterHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x002B3619 File Offset: 0x002B1819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x002B3628 File Offset: 0x002B1828
		public PhantomFetterHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600A8AF RID: 43183 RVA: 0x002B3638 File Offset: 0x002B1838
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

		// Token: 0x04004FA9 RID: 20393
		private Table __p;
	}
}
