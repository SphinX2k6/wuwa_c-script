using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7E RID: 2942
	public struct AbpMontageData : IFlatbufferObject
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x001E3A90 File Offset: 0x001E1C90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x001E3A9D File Offset: 0x001E1C9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x001E3AA4 File Offset: 0x001E1CA4
		public static AbpMontageData GetRootAsAbpMontageData(ByteBuffer _bb)
		{
			return AbpMontageData.GetRootAsAbpMontageData(_bb, default(AbpMontageData));
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x001E3AC0 File Offset: 0x001E1CC0
		public static AbpMontageData GetRootAsAbpMontageData(ByteBuffer _bb, AbpMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x001E3ADD File Offset: 0x001E1CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x001E3AEC File Offset: 0x001E1CEC
		public AbpMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x001E3AFC File Offset: 0x001E1CFC
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x001E3B38 File Offset: 0x001E1D38
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

		// Token: 0x0600451D RID: 17693 RVA: 0x001E3B6F File Offset: 0x001E1D6F
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001E3B7E File Offset: 0x001E1D7E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x001E3B98 File Offset: 0x001E1D98
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

		// Token: 0x06004520 RID: 17696 RVA: 0x001E3BCF File Offset: 0x001E1DCF
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x001E3BDE File Offset: 0x001E1DDE
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x001E3BF8 File Offset: 0x001E1DF8
		public string InitState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001E3C30 File Offset: 0x001E1E30
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001E3C40 File Offset: 0x001E1E40
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x001E3C58 File Offset: 0x001E1E58
		public string EndState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x001E3C90 File Offset: 0x001E1E90
		public Span<byte> GetEndStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x001E3CA0 File Offset: 0x001E1EA0
		public byte[] GetEndStateArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x001E3CB8 File Offset: 0x001E1EB8
		public bool DisableBlinkCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400504C RID: 20556
		private Table __p;
	}
}
