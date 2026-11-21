using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE5 RID: 3301
	public struct DrinksFlavorRange : IFlatbufferObject
	{
		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060069DB RID: 27099 RVA: 0x00236DA2 File Offset: 0x00234FA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x00236DAF File Offset: 0x00234FAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00236DB8 File Offset: 0x00234FB8
		public static DrinksFlavorRange GetRootAsDrinksFlavorRange(ByteBuffer _bb)
		{
			return DrinksFlavorRange.GetRootAsDrinksFlavorRange(_bb, default(DrinksFlavorRange));
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00236DD4 File Offset: 0x00234FD4
		public static DrinksFlavorRange GetRootAsDrinksFlavorRange(ByteBuffer _bb, DrinksFlavorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00236DF1 File Offset: 0x00234FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00236E00 File Offset: 0x00235000
		public DrinksFlavorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x00236E10 File Offset: 0x00235010
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x00236E4C File Offset: 0x0023504C
		public int FlavorGroupId
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

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x00236E88 File Offset: 0x00235088
		public int FlavorTypeRef
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

		// Token: 0x060069E4 RID: 27108 RVA: 0x00236EC4 File Offset: 0x002350C4
		public int FlavorValues(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x00236F04 File Offset: 0x00235104
		public int FlavorValuesLength
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

		// Token: 0x060069E6 RID: 27110 RVA: 0x00236F30 File Offset: 0x00235130
		public Span<int> GetFlavorValuesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x00236F40 File Offset: 0x00235140
		public int[] GetFlavorValuesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x00236F58 File Offset: 0x00235158
		public int FlavorLikeValue(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x00236F98 File Offset: 0x00235198
		public int FlavorLikeValueLength
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

		// Token: 0x060069EA RID: 27114 RVA: 0x00236FC4 File Offset: 0x002351C4
		public Span<int> GetFlavorLikeValueBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x00236FD4 File Offset: 0x002351D4
		public int[] GetFlavorLikeValueArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060069EC RID: 27116 RVA: 0x00236FEC File Offset: 0x002351EC
		public string Desc
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

		// Token: 0x060069ED RID: 27117 RVA: 0x00237024 File Offset: 0x00235224
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x00237034 File Offset: 0x00235234
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0023704C File Offset: 0x0023524C
		[NullableContext(1)]
		public int[] FlavorLikeValue()
		{
			return this.GetFlavorLikeValueArray();
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00237054 File Offset: 0x00235254
		[NullableContext(1)]
		public IEnumerable<int> FlavorLikeValueIter()
		{
			DrinksFlavorRange.<FlavorLikeValueIter>d__29 <FlavorLikeValueIter>d__ = new DrinksFlavorRange.<FlavorLikeValueIter>d__29(-2);
			<FlavorLikeValueIter>d__.<>3__<>4__this = this;
			return <FlavorLikeValueIter>d__;
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00237069 File Offset: 0x00235269
		[NullableContext(1)]
		public int[] FlavorValues()
		{
			return this.GetFlavorValuesArray();
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00237071 File Offset: 0x00235271
		[NullableContext(1)]
		public IEnumerable<int> FlavorValuesIter()
		{
			DrinksFlavorRange.<FlavorValuesIter>d__31 <FlavorValuesIter>d__ = new DrinksFlavorRange.<FlavorValuesIter>d__31(-2);
			<FlavorValuesIter>d__.<>3__<>4__this = this;
			return <FlavorValuesIter>d__;
		}

		// Token: 0x0400521B RID: 21019
		private Table __p;
	}
}
