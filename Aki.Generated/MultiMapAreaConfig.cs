using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5A RID: 3930
	public struct MultiMapAreaConfig : IFlatbufferObject
	{
		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600A39D RID: 41885 RVA: 0x002B7C16 File Offset: 0x002B5E16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x002B7C23 File Offset: 0x002B5E23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A39F RID: 41887 RVA: 0x002B7C2C File Offset: 0x002B5E2C
		public static MultiMapAreaConfig GetRootAsMultiMapAreaConfig(ByteBuffer _bb)
		{
			return MultiMapAreaConfig.GetRootAsMultiMapAreaConfig(_bb, default(MultiMapAreaConfig));
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x002B7C48 File Offset: 0x002B5E48
		public static MultiMapAreaConfig GetRootAsMultiMapAreaConfig(ByteBuffer _bb, MultiMapAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x002B7C65 File Offset: 0x002B5E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x002B7C74 File Offset: 0x002B5E74
		public MultiMapAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600A3A3 RID: 41891 RVA: 0x002B7C84 File Offset: 0x002B5E84
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x002B7CBB File Offset: 0x002B5EBB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x002B7CCA File Offset: 0x002B5ECA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x002B7CE4 File Offset: 0x002B5EE4
		public string Block
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

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x002B7D1B File Offset: 0x002B5F1B
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x002B7D2A File Offset: 0x002B5F2A
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x002B7D44 File Offset: 0x002B5F44
		public int MultiMapList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x002B7D84 File Offset: 0x002B5F84
		public int MultiMapListLength
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

		// Token: 0x0600A3AB RID: 41899 RVA: 0x002B7DAF File Offset: 0x002B5FAF
		public Span<int> GetMultiMapListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x002B7DBE File Offset: 0x002B5FBE
		public int[] GetMultiMapListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x002B7DD8 File Offset: 0x002B5FD8
		public IntArray? MultiMapRangeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x0600A3AE RID: 41902 RVA: 0x002B7E3C File Offset: 0x002B603C
		public int MultiMapRangeListLength
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

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x002B7E68 File Offset: 0x002B6068
		public int MapConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0600A3B0 RID: 41904 RVA: 0x002B7EA8 File Offset: 0x002B60A8
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x002B7EE5 File Offset: 0x002B60E5
		[NullableContext(1)]
		public int[] MultiMapList()
		{
			return this.GetMultiMapListArray();
		}

		// Token: 0x0600A3B2 RID: 41906 RVA: 0x002B7EED File Offset: 0x002B60ED
		[NullableContext(1)]
		public IEnumerable<int> MultiMapListIter()
		{
			MultiMapAreaConfig.<MultiMapListIter>d__29 <MultiMapListIter>d__ = new MultiMapAreaConfig.<MultiMapListIter>d__29(-2);
			<MultiMapListIter>d__.<>3__<>4__this = this;
			return <MultiMapListIter>d__;
		}

		// Token: 0x0600A3B3 RID: 41907 RVA: 0x002B7F02 File Offset: 0x002B6102
		[NullableContext(1)]
		public IntArray[] MultiMapRangeList()
		{
			return this.MultiMapRangeListIter().ToArray<IntArray>();
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x002B7F0F File Offset: 0x002B610F
		[NullableContext(1)]
		public IEnumerable<IntArray> MultiMapRangeListIter()
		{
			MultiMapAreaConfig.<MultiMapRangeListIter>d__31 <MultiMapRangeListIter>d__ = new MultiMapAreaConfig.<MultiMapRangeListIter>d__31(-2);
			<MultiMapRangeListIter>d__.<>3__<>4__this = this;
			return <MultiMapRangeListIter>d__;
		}

		// Token: 0x04005508 RID: 21768
		private Table __p;
	}
}
