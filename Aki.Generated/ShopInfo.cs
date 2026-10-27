using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AC RID: 4268
	public struct ShopInfo : IFlatbufferObject
	{
		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x0030F77E File Offset: 0x0030D97E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x0030F78B File Offset: 0x0030D98B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x0030F794 File Offset: 0x0030D994
		public static ShopInfo GetRootAsShopInfo(ByteBuffer _bb)
		{
			return ShopInfo.GetRootAsShopInfo(_bb, default(ShopInfo));
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x0030F7B0 File Offset: 0x0030D9B0
		public static ShopInfo GetRootAsShopInfo(ByteBuffer _bb, ShopInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D202 RID: 53762 RVA: 0x0030F7CD File Offset: 0x0030D9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x0030F7DC File Offset: 0x0030D9DC
		public ShopInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600D204 RID: 53764 RVA: 0x0030F7EC File Offset: 0x0030D9EC
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

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600D205 RID: 53765 RVA: 0x0030F828 File Offset: 0x0030DA28
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

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600D206 RID: 53766 RVA: 0x0030F864 File Offset: 0x0030DA64
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

		// Token: 0x0600D207 RID: 53767 RVA: 0x0030F89B File Offset: 0x0030DA9B
		public Span<byte> GetShopNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x0030F8AA File Offset: 0x0030DAAA
		public byte[] GetShopNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600D209 RID: 53769 RVA: 0x0030F8C4 File Offset: 0x0030DAC4
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

		// Token: 0x0600D20A RID: 53770 RVA: 0x0030F904 File Offset: 0x0030DB04
		public int ShowCurrency(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600D20B RID: 53771 RVA: 0x0030F944 File Offset: 0x0030DB44
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

		// Token: 0x0600D20C RID: 53772 RVA: 0x0030F970 File Offset: 0x0030DB70
		public Span<int> GetShowCurrencyBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D20D RID: 53773 RVA: 0x0030F980 File Offset: 0x0030DB80
		public int[] GetShowCurrencyArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600D20E RID: 53774 RVA: 0x0030F998 File Offset: 0x0030DB98
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

		// Token: 0x0600D20F RID: 53775 RVA: 0x0030F9D0 File Offset: 0x0030DBD0
		public Span<byte> GetDialogueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x0030F9E0 File Offset: 0x0030DBE0
		public byte[] GetDialogueTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600D211 RID: 53777 RVA: 0x0030F9F8 File Offset: 0x0030DBF8
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

		// Token: 0x0600D212 RID: 53778 RVA: 0x0030FA30 File Offset: 0x0030DC30
		public Span<byte> GetUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x0030FA40 File Offset: 0x0030DC40
		public byte[] GetUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x0030FA58 File Offset: 0x0030DC58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowCurrencyIter()或GetShowCurrencyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowCurrency()
		{
			ShopInfo shopInfo = this;
			return shopInfo.GetShowCurrencyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x0030FA7C File Offset: 0x0030DC7C
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowCurrencyIter()
		{
			ShopInfo.<ShowCurrencyIter>d__32 <ShowCurrencyIter>d__ = new ShopInfo.<ShowCurrencyIter>d__32(-2);
			<ShowCurrencyIter>d__.<>3__<>4__this = this;
			return <ShowCurrencyIter>d__;
		}

		// Token: 0x040051BF RID: 20927
		private Table __p;
	}
}
