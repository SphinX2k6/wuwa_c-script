using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C74 RID: 3188
	public struct Community : IFlatbufferObject
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06005D9C RID: 23964 RVA: 0x0021B488 File Offset: 0x00219688
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x0021B495 File Offset: 0x00219695
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0021B49C File Offset: 0x0021969C
		public static Community GetRootAsCommunity(ByteBuffer _bb)
		{
			return Community.GetRootAsCommunity(_bb, default(Community));
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x0021B4B8 File Offset: 0x002196B8
		public static Community GetRootAsCommunity(ByteBuffer _bb, Community obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x0021B4D5 File Offset: 0x002196D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0021B4E4 File Offset: 0x002196E4
		public Community __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x0021B4F4 File Offset: 0x002196F4
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x0021B530 File Offset: 0x00219730
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

		// Token: 0x06005DA4 RID: 23972 RVA: 0x0021B56C File Offset: 0x0021976C
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x0021B5A8 File Offset: 0x002197A8
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

		// Token: 0x06005DA6 RID: 23974 RVA: 0x0021B5D4 File Offset: 0x002197D4
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x0021B610 File Offset: 0x00219810
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

		// Token: 0x06005DA8 RID: 23976 RVA: 0x0021B63C File Offset: 0x0021983C
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x0021B67C File Offset: 0x0021987C
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

		// Token: 0x06005DAA RID: 23978 RVA: 0x0021B6A8 File Offset: 0x002198A8
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x0021B6B8 File Offset: 0x002198B8
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06005DAC RID: 23980 RVA: 0x0021B6D0 File Offset: 0x002198D0
		public string Adress
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

		// Token: 0x06005DAD RID: 23981 RVA: 0x0021B708 File Offset: 0x00219908
		public Span<byte> GetAdressBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x0021B718 File Offset: 0x00219918
		public byte[] GetAdressArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x0021B730 File Offset: 0x00219930
		[NullableContext(1)]
		public int[] Channel()
		{
			return this.GetChannelArray();
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x0021B738 File Offset: 0x00219938
		[NullableContext(1)]
		public IEnumerable<int> ChannelIter()
		{
			Community.<ChannelIter>d__28 <ChannelIter>d__ = new Community.<ChannelIter>d__28(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x0021B74D File Offset: 0x0021994D
		[NullableContext(1)]
		public string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x0021B75A File Offset: 0x0021995A
		[NullableContext(1)]
		public IEnumerable<string> LanguageIter()
		{
			Community.<LanguageIter>d__30 <LanguageIter>d__ = new Community.<LanguageIter>d__30(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x0021B76F File Offset: 0x0021996F
		[NullableContext(1)]
		public string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x0021B77C File Offset: 0x0021997C
		[NullableContext(1)]
		public IEnumerable<string> PackageIdIter()
		{
			Community.<PackageIdIter>d__32 <PackageIdIter>d__ = new Community.<PackageIdIter>d__32(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x04005183 RID: 20867
		private Table __p;
	}
}
