using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD1 RID: 4049
	public struct PhantomHandBookPage : IFlatbufferObject
	{
		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x002D119F File Offset: 0x002CF39F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x002D11AC File Offset: 0x002CF3AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x002D11B4 File Offset: 0x002CF3B4
		public static PhantomHandBookPage GetRootAsPhantomHandBookPage(ByteBuffer _bb)
		{
			return PhantomHandBookPage.GetRootAsPhantomHandBookPage(_bb, default(PhantomHandBookPage));
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x002D11D0 File Offset: 0x002CF3D0
		public static PhantomHandBookPage GetRootAsPhantomHandBookPage(ByteBuffer _bb, PhantomHandBookPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x002D11ED File Offset: 0x002CF3ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x002D11FC File Offset: 0x002CF3FC
		public PhantomHandBookPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x002D120C File Offset: 0x002CF40C
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

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x0600AF31 RID: 44849 RVA: 0x002D1248 File Offset: 0x002CF448
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

		// Token: 0x0600AF32 RID: 44850 RVA: 0x002D127F File Offset: 0x002CF47F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x002D128E File Offset: 0x002CF48E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005593 RID: 21907
		private Table __p;
	}
}
