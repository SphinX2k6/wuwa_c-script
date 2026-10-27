using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA8 RID: 3752
	public struct OverlayAbpMontageData : IFlatbufferObject
	{
		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600A24B RID: 41547 RVA: 0x002A4D20 File Offset: 0x002A2F20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x002A4D2D File Offset: 0x002A2F2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x002A4D34 File Offset: 0x002A2F34
		public static OverlayAbpMontageData GetRootAsOverlayAbpMontageData(ByteBuffer _bb)
		{
			return OverlayAbpMontageData.GetRootAsOverlayAbpMontageData(_bb, default(OverlayAbpMontageData));
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x002A4D50 File Offset: 0x002A2F50
		public static OverlayAbpMontageData GetRootAsOverlayAbpMontageData(ByteBuffer _bb, OverlayAbpMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x002A4D6D File Offset: 0x002A2F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x002A4D7C File Offset: 0x002A2F7C
		public OverlayAbpMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x002A4D8C File Offset: 0x002A2F8C
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

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x002A4DC8 File Offset: 0x002A2FC8
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

		// Token: 0x0600A253 RID: 41555 RVA: 0x002A4DFF File Offset: 0x002A2FFF
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x002A4E0E File Offset: 0x002A300E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600A255 RID: 41557 RVA: 0x002A4E28 File Offset: 0x002A3028
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

		// Token: 0x0600A256 RID: 41558 RVA: 0x002A4E5F File Offset: 0x002A305F
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x002A4E6E File Offset: 0x002A306E
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600A258 RID: 41560 RVA: 0x002A4E88 File Offset: 0x002A3088
		public bool IsWalkingUsable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F5D RID: 20317
		private Table __p;
	}
}
