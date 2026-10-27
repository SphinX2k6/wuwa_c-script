using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA5 RID: 3237
	public struct FloroRanchCardWeight : IFlatbufferObject
	{
		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x0023A250 File Offset: 0x00238450
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x0023A25D File Offset: 0x0023845D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x0023A264 File Offset: 0x00238464
		public static FloroRanchCardWeight GetRootAsFloroRanchCardWeight(ByteBuffer _bb)
		{
			return FloroRanchCardWeight.GetRootAsFloroRanchCardWeight(_bb, default(FloroRanchCardWeight));
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x0023A280 File Offset: 0x00238480
		public static FloroRanchCardWeight GetRootAsFloroRanchCardWeight(ByteBuffer _bb, FloroRanchCardWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x0023A29D File Offset: 0x0023849D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x0023A2AC File Offset: 0x002384AC
		public FloroRanchCardWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060072F0 RID: 29424 RVA: 0x0023A2BC File Offset: 0x002384BC
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

		// Token: 0x060072F1 RID: 29425 RVA: 0x0023A2F8 File Offset: 0x002384F8
		public int ShopRate1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x0023A338 File Offset: 0x00238538
		public int ShopRate1Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x0023A363 File Offset: 0x00238563
		public Span<int> GetShopRate1Bytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x0023A372 File Offset: 0x00238572
		public int[] GetShopRate1Array()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0023A38C File Offset: 0x0023858C
		public int ShopRate2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x0023A3CC File Offset: 0x002385CC
		public int ShopRate2Length
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x0023A3F7 File Offset: 0x002385F7
		public Span<int> GetShopRate2Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0023A406 File Offset: 0x00238606
		public int[] GetShopRate2Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0023A420 File Offset: 0x00238620
		public int ShopRate3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x0023A460 File Offset: 0x00238660
		public int ShopRate3Length
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x0023A48C File Offset: 0x0023868C
		public Span<int> GetShopRate3Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x0023A49C File Offset: 0x0023869C
		public int[] GetShopRate3Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x0023A4B4 File Offset: 0x002386B4
		public int ShopRate4(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x0023A4F4 File Offset: 0x002386F4
		public int ShopRate4Length
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

		// Token: 0x060072FF RID: 29439 RVA: 0x0023A520 File Offset: 0x00238720
		public Span<int> GetShopRate4Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x0023A530 File Offset: 0x00238730
		public int[] GetShopRate4Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x0023A548 File Offset: 0x00238748
		public int ShopRate5(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06007302 RID: 29442 RVA: 0x0023A588 File Offset: 0x00238788
		public int ShopRate5Length
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0023A5B4 File Offset: 0x002387B4
		public Span<int> GetShopRate5Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0023A5C4 File Offset: 0x002387C4
		public int[] GetShopRate5Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x0023A5DC File Offset: 0x002387DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRate1Iter()或GetShopRate1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopRate1()
		{
			FloroRanchCardWeight floroRanchCardWeight = this;
			return floroRanchCardWeight.GetShopRate1Array() ?? Array.Empty<int>();
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0023A600 File Offset: 0x00238800
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopRate1Iter()
		{
			FloroRanchCardWeight.<ShopRate1Iter>d__36 <ShopRate1Iter>d__ = new FloroRanchCardWeight.<ShopRate1Iter>d__36(-2);
			<ShopRate1Iter>d__.<>3__<>4__this = this;
			return <ShopRate1Iter>d__;
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x0023A618 File Offset: 0x00238818
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRate2Iter()或GetShopRate2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopRate2()
		{
			FloroRanchCardWeight floroRanchCardWeight = this;
			return floroRanchCardWeight.GetShopRate2Array() ?? Array.Empty<int>();
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x0023A63C File Offset: 0x0023883C
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopRate2Iter()
		{
			FloroRanchCardWeight.<ShopRate2Iter>d__38 <ShopRate2Iter>d__ = new FloroRanchCardWeight.<ShopRate2Iter>d__38(-2);
			<ShopRate2Iter>d__.<>3__<>4__this = this;
			return <ShopRate2Iter>d__;
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x0023A654 File Offset: 0x00238854
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRate3Iter()或GetShopRate3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopRate3()
		{
			FloroRanchCardWeight floroRanchCardWeight = this;
			return floroRanchCardWeight.GetShopRate3Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x0023A678 File Offset: 0x00238878
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopRate3Iter()
		{
			FloroRanchCardWeight.<ShopRate3Iter>d__40 <ShopRate3Iter>d__ = new FloroRanchCardWeight.<ShopRate3Iter>d__40(-2);
			<ShopRate3Iter>d__.<>3__<>4__this = this;
			return <ShopRate3Iter>d__;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x0023A690 File Offset: 0x00238890
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRate4Iter()或GetShopRate4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopRate4()
		{
			FloroRanchCardWeight floroRanchCardWeight = this;
			return floroRanchCardWeight.GetShopRate4Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0023A6B4 File Offset: 0x002388B4
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopRate4Iter()
		{
			FloroRanchCardWeight.<ShopRate4Iter>d__42 <ShopRate4Iter>d__ = new FloroRanchCardWeight.<ShopRate4Iter>d__42(-2);
			<ShopRate4Iter>d__.<>3__<>4__this = this;
			return <ShopRate4Iter>d__;
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x0023A6CC File Offset: 0x002388CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRate5Iter()或GetShopRate5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopRate5()
		{
			FloroRanchCardWeight floroRanchCardWeight = this;
			return floroRanchCardWeight.GetShopRate5Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x0023A6F0 File Offset: 0x002388F0
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopRate5Iter()
		{
			FloroRanchCardWeight.<ShopRate5Iter>d__44 <ShopRate5Iter>d__ = new FloroRanchCardWeight.<ShopRate5Iter>d__44(-2);
			<ShopRate5Iter>d__.<>3__<>4__this = this;
			return <ShopRate5Iter>d__;
		}

		// Token: 0x04004D07 RID: 19719
		private Table __p;
	}
}
