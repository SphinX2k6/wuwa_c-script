using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8D RID: 3213
	public struct CustomerService : IFlatbufferObject
	{
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x00221E78 File Offset: 0x00220078
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00221E85 File Offset: 0x00220085
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x00221E8C File Offset: 0x0022008C
		public static CustomerService GetRootAsCustomerService(ByteBuffer _bb)
		{
			return CustomerService.GetRootAsCustomerService(_bb, default(CustomerService));
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00221EA8 File Offset: 0x002200A8
		public static CustomerService GetRootAsCustomerService(ByteBuffer _bb, CustomerService obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00221EC5 File Offset: 0x002200C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00221ED4 File Offset: 0x002200D4
		public CustomerService __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x00221EE4 File Offset: 0x002200E4
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

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x00221F20 File Offset: 0x00220120
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

		// Token: 0x0600605B RID: 24667 RVA: 0x00221F5C File Offset: 0x0022015C
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00221F98 File Offset: 0x00220198
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

		// Token: 0x0600605D RID: 24669 RVA: 0x00221FC4 File Offset: 0x002201C4
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x00222000 File Offset: 0x00220200
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

		// Token: 0x0600605F RID: 24671 RVA: 0x0022202C File Offset: 0x0022022C
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x0022206C File Offset: 0x0022026C
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

		// Token: 0x06006061 RID: 24673 RVA: 0x00222098 File Offset: 0x00220298
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x002220A8 File Offset: 0x002202A8
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x002220C0 File Offset: 0x002202C0
		[NullableContext(1)]
		public int[] Channel()
		{
			return this.GetChannelArray();
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x002220C8 File Offset: 0x002202C8
		[NullableContext(1)]
		public IEnumerable<int> ChannelIter()
		{
			CustomerService.<ChannelIter>d__24 <ChannelIter>d__ = new CustomerService.<ChannelIter>d__24(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x002220DD File Offset: 0x002202DD
		[NullableContext(1)]
		public string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x002220EA File Offset: 0x002202EA
		[NullableContext(1)]
		public IEnumerable<string> LanguageIter()
		{
			CustomerService.<LanguageIter>d__26 <LanguageIter>d__ = new CustomerService.<LanguageIter>d__26(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x002220FF File Offset: 0x002202FF
		[NullableContext(1)]
		public string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x0022210C File Offset: 0x0022030C
		[NullableContext(1)]
		public IEnumerable<string> PackageIdIter()
		{
			CustomerService.<PackageIdIter>d__28 <PackageIdIter>d__ = new CustomerService.<PackageIdIter>d__28(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x040051B0 RID: 20912
		private Table __p;
	}
}
