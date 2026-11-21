using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001195 RID: 4501
	public struct SharePlatform : IFlatbufferObject
	{
		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600D840 RID: 55360 RVA: 0x0032B134 File Offset: 0x00329334
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D841 RID: 55361 RVA: 0x0032B141 File Offset: 0x00329341
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D842 RID: 55362 RVA: 0x0032B148 File Offset: 0x00329348
		public static SharePlatform GetRootAsSharePlatform(ByteBuffer _bb)
		{
			return SharePlatform.GetRootAsSharePlatform(_bb, default(SharePlatform));
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x0032B164 File Offset: 0x00329364
		public static SharePlatform GetRootAsSharePlatform(ByteBuffer _bb, SharePlatform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x0032B181 File Offset: 0x00329381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D845 RID: 55365 RVA: 0x0032B190 File Offset: 0x00329390
		public SharePlatform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600D846 RID: 55366 RVA: 0x0032B1A0 File Offset: 0x003293A0
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

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600D847 RID: 55367 RVA: 0x0032B1DC File Offset: 0x003293DC
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

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600D848 RID: 55368 RVA: 0x0032B218 File Offset: 0x00329418
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x0032B254 File Offset: 0x00329454
		public string Language(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600D84A RID: 55370 RVA: 0x0032B290 File Offset: 0x00329490
		public int LanguageLength
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

		// Token: 0x0600D84B RID: 55371 RVA: 0x0032B2BC File Offset: 0x003294BC
		public string PackageId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600D84C RID: 55372 RVA: 0x0032B2F8 File Offset: 0x003294F8
		public int PackageIdLength
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

		// Token: 0x0600D84D RID: 55373 RVA: 0x0032B324 File Offset: 0x00329524
		public int Channel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600D84E RID: 55374 RVA: 0x0032B364 File Offset: 0x00329564
		public int ChannelLength
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

		// Token: 0x0600D84F RID: 55375 RVA: 0x0032B390 File Offset: 0x00329590
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D850 RID: 55376 RVA: 0x0032B3A0 File Offset: 0x003295A0
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600D851 RID: 55377 RVA: 0x0032B3B8 File Offset: 0x003295B8
		public int ShareId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600D852 RID: 55378 RVA: 0x0032B3F8 File Offset: 0x003295F8
		public string ShareName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D853 RID: 55379 RVA: 0x0032B430 File Offset: 0x00329630
		public Span<byte> GetShareNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x0032B440 File Offset: 0x00329640
		public byte[] GetShareNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600D855 RID: 55381 RVA: 0x0032B458 File Offset: 0x00329658
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D856 RID: 55382 RVA: 0x0032B490 File Offset: 0x00329690
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D857 RID: 55383 RVA: 0x0032B4A0 File Offset: 0x003296A0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x0032B4B8 File Offset: 0x003296B8
		[NullableContext(1)]
		public int[] Channel()
		{
			return this.GetChannelArray();
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x0032B4C0 File Offset: 0x003296C0
		[NullableContext(1)]
		public IEnumerable<int> ChannelIter()
		{
			SharePlatform.<ChannelIter>d__36 <ChannelIter>d__ = new SharePlatform.<ChannelIter>d__36(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x0600D85A RID: 55386 RVA: 0x0032B4D5 File Offset: 0x003296D5
		[NullableContext(1)]
		public string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x0600D85B RID: 55387 RVA: 0x0032B4E2 File Offset: 0x003296E2
		[NullableContext(1)]
		public IEnumerable<string> LanguageIter()
		{
			SharePlatform.<LanguageIter>d__38 <LanguageIter>d__ = new SharePlatform.<LanguageIter>d__38(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x0600D85C RID: 55388 RVA: 0x0032B4F7 File Offset: 0x003296F7
		[NullableContext(1)]
		public string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x0032B504 File Offset: 0x00329704
		[NullableContext(1)]
		public IEnumerable<string> PackageIdIter()
		{
			SharePlatform.<PackageIdIter>d__40 <PackageIdIter>d__ = new SharePlatform.<PackageIdIter>d__40(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x040057A6 RID: 22438
		private Table __p;
	}
}
