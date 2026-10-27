using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEC RID: 3820
	public struct PhantomHandBookPage : IFlatbufferObject
	{
		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600A909 RID: 43273 RVA: 0x002B41CD File Offset: 0x002B23CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x002B41DA File Offset: 0x002B23DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x002B41E4 File Offset: 0x002B23E4
		public static PhantomHandBookPage GetRootAsPhantomHandBookPage(ByteBuffer _bb)
		{
			return PhantomHandBookPage.GetRootAsPhantomHandBookPage(_bb, default(PhantomHandBookPage));
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x002B4200 File Offset: 0x002B2400
		public static PhantomHandBookPage GetRootAsPhantomHandBookPage(ByteBuffer _bb, PhantomHandBookPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x002B421D File Offset: 0x002B241D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x002B422C File Offset: 0x002B242C
		public PhantomHandBookPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x002B423C File Offset: 0x002B243C
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

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x002B4278 File Offset: 0x002B2478
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x002B42AF File Offset: 0x002B24AF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x002B42BE File Offset: 0x002B24BE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FAE RID: 20398
		private Table __p;
	}
}
