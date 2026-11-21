using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A7 RID: 4519
	public struct ShopInfo : IFlatbufferObject
	{
		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600D9D4 RID: 55764 RVA: 0x0032EC52 File Offset: 0x0032CE52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x0032EC5F File Offset: 0x0032CE5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x0032EC68 File Offset: 0x0032CE68
		public static ShopInfo GetRootAsShopInfo(ByteBuffer _bb)
		{
			return ShopInfo.GetRootAsShopInfo(_bb, default(ShopInfo));
		}

		// Token: 0x0600D9D7 RID: 55767 RVA: 0x0032EC84 File Offset: 0x0032CE84
		public static ShopInfo GetRootAsShopInfo(ByteBuffer _bb, ShopInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9D8 RID: 55768 RVA: 0x0032ECA1 File Offset: 0x0032CEA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9D9 RID: 55769 RVA: 0x0032ECB0 File Offset: 0x0032CEB0
		public ShopInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x0032ECC0 File Offset: 0x0032CEC0
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

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600D9DB RID: 55771 RVA: 0x0032ECFC File Offset: 0x0032CEFC
		public int ShopType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600D9DC RID: 55772 RVA: 0x0032ED38 File Offset: 0x0032CF38
		public string ShopName
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

		// Token: 0x0600D9DD RID: 55773 RVA: 0x0032ED6F File Offset: 0x0032CF6F
		public Span<byte> GetShopNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D9DE RID: 55774 RVA: 0x0032ED7E File Offset: 0x0032CF7E
		public byte[] GetShopNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600D9DF RID: 55775 RVA: 0x0032ED98 File Offset: 0x0032CF98
		public int OpenId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x0032EDD8 File Offset: 0x0032CFD8
		public int ShowCurrency(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600D9E1 RID: 55777 RVA: 0x0032EE18 File Offset: 0x0032D018
		public int ShowCurrencyLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D9E2 RID: 55778 RVA: 0x0032EE44 File Offset: 0x0032D044
		public Span<int> GetShowCurrencyBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x0032EE54 File Offset: 0x0032D054
		public int[] GetShowCurrencyArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600D9E4 RID: 55780 RVA: 0x0032EE6C File Offset: 0x0032D06C
		public string DialogueText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x0032EEA4 File Offset: 0x0032D0A4
		public Span<byte> GetDialogueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x0032EEB4 File Offset: 0x0032D0B4
		public byte[] GetDialogueTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600D9E7 RID: 55783 RVA: 0x0032EECC File Offset: 0x0032D0CC
		public string UiCamera
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x0032EF04 File Offset: 0x0032D104
		public Span<byte> GetUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D9E9 RID: 55785 RVA: 0x0032EF14 File Offset: 0x0032D114
		public byte[] GetUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D9EA RID: 55786 RVA: 0x0032EF2C File Offset: 0x0032D12C
		[NullableContext(1)]
		public int[] ShowCurrency()
		{
			return this.GetShowCurrencyArray();
		}

		// Token: 0x0600D9EB RID: 55787 RVA: 0x0032EF34 File Offset: 0x0032D134
		[NullableContext(1)]
		public IEnumerable<int> ShowCurrencyIter()
		{
			ShopInfo.<ShowCurrencyIter>d__32 <ShowCurrencyIter>d__ = new ShopInfo.<ShowCurrencyIter>d__32(-2);
			<ShowCurrencyIter>d__.<>3__<>4__this = this;
			return <ShowCurrencyIter>d__;
		}

		// Token: 0x040057BE RID: 22462
		private Table __p;
	}
}
