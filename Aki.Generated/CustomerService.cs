using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAB RID: 2987
	public struct CustomerService : IFlatbufferObject
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06005A7A RID: 23162 RVA: 0x00202154 File Offset: 0x00200354
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00202161 File Offset: 0x00200361
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00202168 File Offset: 0x00200368
		public static CustomerService GetRootAsCustomerService(ByteBuffer _bb)
		{
			return CustomerService.GetRootAsCustomerService(_bb, default(CustomerService));
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x00202184 File Offset: 0x00200384
		public static CustomerService GetRootAsCustomerService(ByteBuffer _bb, CustomerService obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x002021A1 File Offset: 0x002003A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x002021B0 File Offset: 0x002003B0
		public CustomerService __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x002021C0 File Offset: 0x002003C0
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x002021FC File Offset: 0x002003FC
		public int PackageType
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

		// Token: 0x06005A82 RID: 23170 RVA: 0x00202238 File Offset: 0x00200438
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06005A83 RID: 23171 RVA: 0x00202274 File Offset: 0x00200474
		public int LanguageLength
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

		// Token: 0x06005A84 RID: 23172 RVA: 0x002022A0 File Offset: 0x002004A0
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06005A85 RID: 23173 RVA: 0x002022DC File Offset: 0x002004DC
		public int PackageIdLength
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

		// Token: 0x06005A86 RID: 23174 RVA: 0x00202308 File Offset: 0x00200508
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06005A87 RID: 23175 RVA: 0x00202348 File Offset: 0x00200548
		public int ChannelLength
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

		// Token: 0x06005A88 RID: 23176 RVA: 0x00202374 File Offset: 0x00200574
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00202384 File Offset: 0x00200584
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x0020239C File Offset: 0x0020059C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChannelIter()或GetChannelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Channel()
		{
			CustomerService customerService = this;
			return customerService.GetChannelArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x002023C0 File Offset: 0x002005C0
		[NullableContext(1)]
		public readonly IEnumerable<int> ChannelIter()
		{
			CustomerService.<ChannelIter>d__24 <ChannelIter>d__ = new CustomerService.<ChannelIter>d__24(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x002023D5 File Offset: 0x002005D5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LanguageIter()或GetLanguageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x002023E2 File Offset: 0x002005E2
		[NullableContext(1)]
		public readonly IEnumerable<string> LanguageIter()
		{
			CustomerService.<LanguageIter>d__26 <LanguageIter>d__ = new CustomerService.<LanguageIter>d__26(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x002023F7 File Offset: 0x002005F7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PackageIdIter()或GetPackageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00202404 File Offset: 0x00200604
		[NullableContext(1)]
		public readonly IEnumerable<string> PackageIdIter()
		{
			CustomerService.<PackageIdIter>d__28 <PackageIdIter>d__ = new CustomerService.<PackageIdIter>d__28(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x04004BCE RID: 19406
		private Table __p;
	}
}
