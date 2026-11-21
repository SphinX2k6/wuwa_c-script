using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8D RID: 3981
	public struct OverlayAbpMontageData : IFlatbufferObject
	{
		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x002C20F4 File Offset: 0x002C02F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x002C2101 File Offset: 0x002C0301
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x002C2108 File Offset: 0x002C0308
		public static OverlayAbpMontageData GetRootAsOverlayAbpMontageData(ByteBuffer _bb)
		{
			return OverlayAbpMontageData.GetRootAsOverlayAbpMontageData(_bb, default(OverlayAbpMontageData));
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x002C2124 File Offset: 0x002C0324
		public static OverlayAbpMontageData GetRootAsOverlayAbpMontageData(ByteBuffer _bb, OverlayAbpMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x002C2141 File Offset: 0x002C0341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x002C2150 File Offset: 0x002C0350
		public OverlayAbpMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x002C2160 File Offset: 0x002C0360
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

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x0600A872 RID: 43122 RVA: 0x002C219C File Offset: 0x002C039C
		public string Montage
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

		// Token: 0x0600A873 RID: 43123 RVA: 0x002C21D3 File Offset: 0x002C03D3
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A874 RID: 43124 RVA: 0x002C21E2 File Offset: 0x002C03E2
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x002C21FC File Offset: 0x002C03FC
		public string MaleVariant
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

		// Token: 0x0600A876 RID: 43126 RVA: 0x002C2233 File Offset: 0x002C0433
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x002C2242 File Offset: 0x002C0442
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x002C225C File Offset: 0x002C045C
		public bool IsWalkingUsable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005542 RID: 21826
		private Table __p;
	}
}
