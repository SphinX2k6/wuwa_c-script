using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116A RID: 4458
	public struct RougeResPopularEntrie : IFlatbufferObject
	{
		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600D454 RID: 54356 RVA: 0x0032294C File Offset: 0x00320B4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D455 RID: 54357 RVA: 0x00322959 File Offset: 0x00320B59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D456 RID: 54358 RVA: 0x00322960 File Offset: 0x00320B60
		public static RougeResPopularEntrie GetRootAsRougeResPopularEntrie(ByteBuffer _bb)
		{
			return RougeResPopularEntrie.GetRootAsRougeResPopularEntrie(_bb, default(RougeResPopularEntrie));
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x0032297C File Offset: 0x00320B7C
		public static RougeResPopularEntrie GetRootAsRougeResPopularEntrie(ByteBuffer _bb, RougeResPopularEntrie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D458 RID: 54360 RVA: 0x00322999 File Offset: 0x00320B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x003229A8 File Offset: 0x00320BA8
		public RougeResPopularEntrie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600D45A RID: 54362 RVA: 0x003229B8 File Offset: 0x00320BB8
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

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600D45B RID: 54363 RVA: 0x003229F4 File Offset: 0x00320BF4
		public int Category
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

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600D45C RID: 54364 RVA: 0x00322A30 File Offset: 0x00320C30
		public int Rate
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

		// Token: 0x0600D45D RID: 54365 RVA: 0x00322A6C File Offset: 0x00320C6C
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600D45E RID: 54366 RVA: 0x00322AAC File Offset: 0x00320CAC
		public int InstsLength
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

		// Token: 0x0600D45F RID: 54367 RVA: 0x00322AD8 File Offset: 0x00320CD8
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x00322AE8 File Offset: 0x00320CE8
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600D461 RID: 54369 RVA: 0x00322B00 File Offset: 0x00320D00
		public string Icon
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

		// Token: 0x0600D462 RID: 54370 RVA: 0x00322B38 File Offset: 0x00320D38
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x00322B48 File Offset: 0x00320D48
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600D464 RID: 54372 RVA: 0x00322B60 File Offset: 0x00320D60
		public string Title
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

		// Token: 0x0600D465 RID: 54373 RVA: 0x00322B98 File Offset: 0x00320D98
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x00322BA8 File Offset: 0x00320DA8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600D467 RID: 54375 RVA: 0x00322BC0 File Offset: 0x00320DC0
		public string Describe
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

		// Token: 0x0600D468 RID: 54376 RVA: 0x00322BF8 File Offset: 0x00320DF8
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x00322C08 File Offset: 0x00320E08
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D46A RID: 54378 RVA: 0x00322C20 File Offset: 0x00320E20
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600D46B RID: 54379 RVA: 0x00322C5C File Offset: 0x00320E5C
		public int DescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D46C RID: 54380 RVA: 0x00322C88 File Offset: 0x00320E88
		[NullableContext(1)]
		public string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x00322C95 File Offset: 0x00320E95
		[NullableContext(1)]
		public IEnumerable<string> DescriptionParamIter()
		{
			RougeResPopularEntrie.<DescriptionParamIter>d__35 <DescriptionParamIter>d__ = new RougeResPopularEntrie.<DescriptionParamIter>d__35(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x00322CAA File Offset: 0x00320EAA
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x00322CB2 File Offset: 0x00320EB2
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RougeResPopularEntrie.<InstsIter>d__37 <InstsIter>d__ = new RougeResPopularEntrie.<InstsIter>d__37(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x04005773 RID: 22387
		private Table __p;
	}
}
