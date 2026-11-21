using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A3 RID: 4515
	public struct ShippingHiddenMultiText : IFlatbufferObject
	{
		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x0032DCEE File Offset: 0x0032BEEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D97B RID: 55675 RVA: 0x0032DCFB File Offset: 0x0032BEFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x0032DD04 File Offset: 0x0032BF04
		public static ShippingHiddenMultiText GetRootAsShippingHiddenMultiText(ByteBuffer _bb)
		{
			return ShippingHiddenMultiText.GetRootAsShippingHiddenMultiText(_bb, default(ShippingHiddenMultiText));
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x0032DD20 File Offset: 0x0032BF20
		public static ShippingHiddenMultiText GetRootAsShippingHiddenMultiText(ByteBuffer _bb, ShippingHiddenMultiText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D97E RID: 55678 RVA: 0x0032DD3D File Offset: 0x0032BF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D97F RID: 55679 RVA: 0x0032DD4C File Offset: 0x0032BF4C
		public ShippingHiddenMultiText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600D980 RID: 55680 RVA: 0x0032DD5C File Offset: 0x0032BF5C
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

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600D981 RID: 55681 RVA: 0x0032DD98 File Offset: 0x0032BF98
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

		// Token: 0x0600D982 RID: 55682 RVA: 0x0032DDCF File Offset: 0x0032BFCF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x0032DDDE File Offset: 0x0032BFDE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600D984 RID: 55684 RVA: 0x0032DDF8 File Offset: 0x0032BFF8
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

		// Token: 0x0600D985 RID: 55685 RVA: 0x0032DE2F File Offset: 0x0032C02F
		public Span<byte> GetHiddenStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x0032DE3E File Offset: 0x0032C03E
		public byte[] GetHiddenStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040057B6 RID: 22454
		private Table __p;
	}
}
