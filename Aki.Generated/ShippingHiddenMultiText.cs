using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A8 RID: 4264
	public struct ShippingHiddenMultiText : IFlatbufferObject
	{
		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x0030E819 File Offset: 0x0030CA19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1A5 RID: 53669 RVA: 0x0030E826 File Offset: 0x0030CA26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x0030E830 File Offset: 0x0030CA30
		public static ShippingHiddenMultiText GetRootAsShippingHiddenMultiText(ByteBuffer _bb)
		{
			return ShippingHiddenMultiText.GetRootAsShippingHiddenMultiText(_bb, default(ShippingHiddenMultiText));
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x0030E84C File Offset: 0x0030CA4C
		public static ShippingHiddenMultiText GetRootAsShippingHiddenMultiText(ByteBuffer _bb, ShippingHiddenMultiText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1A8 RID: 53672 RVA: 0x0030E869 File Offset: 0x0030CA69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1A9 RID: 53673 RVA: 0x0030E878 File Offset: 0x0030CA78
		public ShippingHiddenMultiText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600D1AA RID: 53674 RVA: 0x0030E888 File Offset: 0x0030CA88
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

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600D1AB RID: 53675 RVA: 0x0030E8C4 File Offset: 0x0030CAC4
		public string Key
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

		// Token: 0x0600D1AC RID: 53676 RVA: 0x0030E8FB File Offset: 0x0030CAFB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D1AD RID: 53677 RVA: 0x0030E90A File Offset: 0x0030CB0A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600D1AE RID: 53678 RVA: 0x0030E924 File Offset: 0x0030CB24
		public string HiddenState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D1AF RID: 53679 RVA: 0x0030E95B File Offset: 0x0030CB5B
		public Span<byte> GetHiddenStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x0030E96A File Offset: 0x0030CB6A
		public byte[] GetHiddenStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051B7 RID: 20919
		private Table __p;
	}
}
