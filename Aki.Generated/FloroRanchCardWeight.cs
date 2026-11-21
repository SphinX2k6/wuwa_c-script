using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D89 RID: 3465
	public struct FloroRanchCardWeight : IFlatbufferObject
	{
		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060078F5 RID: 30965 RVA: 0x002591BC File Offset: 0x002573BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x002591C9 File Offset: 0x002573C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x002591D0 File Offset: 0x002573D0
		public static FloroRanchCardWeight GetRootAsFloroRanchCardWeight(ByteBuffer _bb)
		{
			return FloroRanchCardWeight.GetRootAsFloroRanchCardWeight(_bb, default(FloroRanchCardWeight));
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x002591EC File Offset: 0x002573EC
		public static FloroRanchCardWeight GetRootAsFloroRanchCardWeight(ByteBuffer _bb, FloroRanchCardWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00259209 File Offset: 0x00257409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00259218 File Offset: 0x00257418
		public FloroRanchCardWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x00259228 File Offset: 0x00257428
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

		// Token: 0x060078FC RID: 30972 RVA: 0x00259264 File Offset: 0x00257464
		public int ShopRate1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x060078FD RID: 30973 RVA: 0x002592A4 File Offset: 0x002574A4
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

		// Token: 0x060078FE RID: 30974 RVA: 0x002592CF File Offset: 0x002574CF
		public Span<int> GetShopRate1Bytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x002592DE File Offset: 0x002574DE
		public int[] GetShopRate1Array()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x002592F8 File Offset: 0x002574F8
		public int ShopRate2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06007901 RID: 30977 RVA: 0x00259338 File Offset: 0x00257538
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

		// Token: 0x06007902 RID: 30978 RVA: 0x00259363 File Offset: 0x00257563
		public Span<int> GetShopRate2Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00259372 File Offset: 0x00257572
		public int[] GetShopRate2Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x0025938C File Offset: 0x0025758C
		public int ShopRate3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06007905 RID: 30981 RVA: 0x002593CC File Offset: 0x002575CC
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

		// Token: 0x06007906 RID: 30982 RVA: 0x002593F8 File Offset: 0x002575F8
		public Span<int> GetShopRate3Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x00259408 File Offset: 0x00257608
		public int[] GetShopRate3Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00259420 File Offset: 0x00257620
		public int ShopRate4(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06007909 RID: 30985 RVA: 0x00259460 File Offset: 0x00257660
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

		// Token: 0x0600790A RID: 30986 RVA: 0x0025948C File Offset: 0x0025768C
		public Span<int> GetShopRate4Bytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x0025949C File Offset: 0x0025769C
		public int[] GetShopRate4Array()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x002594B4 File Offset: 0x002576B4
		public int ShopRate5(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600790D RID: 30989 RVA: 0x002594F4 File Offset: 0x002576F4
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

		// Token: 0x0600790E RID: 30990 RVA: 0x00259520 File Offset: 0x00257720
		public Span<int> GetShopRate5Bytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00259530 File Offset: 0x00257730
		public int[] GetShopRate5Array()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00259548 File Offset: 0x00257748
		[NullableContext(1)]
		public int[] ShopRate1()
		{
			return this.GetShopRate1Array();
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00259550 File Offset: 0x00257750
		[NullableContext(1)]
		public IEnumerable<int> ShopRate1Iter()
		{
			FloroRanchCardWeight.<ShopRate1Iter>d__36 <ShopRate1Iter>d__ = new FloroRanchCardWeight.<ShopRate1Iter>d__36(-2);
			<ShopRate1Iter>d__.<>3__<>4__this = this;
			return <ShopRate1Iter>d__;
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00259565 File Offset: 0x00257765
		[NullableContext(1)]
		public int[] ShopRate2()
		{
			return this.GetShopRate2Array();
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x0025956D File Offset: 0x0025776D
		[NullableContext(1)]
		public IEnumerable<int> ShopRate2Iter()
		{
			FloroRanchCardWeight.<ShopRate2Iter>d__38 <ShopRate2Iter>d__ = new FloroRanchCardWeight.<ShopRate2Iter>d__38(-2);
			<ShopRate2Iter>d__.<>3__<>4__this = this;
			return <ShopRate2Iter>d__;
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00259582 File Offset: 0x00257782
		[NullableContext(1)]
		public int[] ShopRate3()
		{
			return this.GetShopRate3Array();
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0025958A File Offset: 0x0025778A
		[NullableContext(1)]
		public IEnumerable<int> ShopRate3Iter()
		{
			FloroRanchCardWeight.<ShopRate3Iter>d__40 <ShopRate3Iter>d__ = new FloroRanchCardWeight.<ShopRate3Iter>d__40(-2);
			<ShopRate3Iter>d__.<>3__<>4__this = this;
			return <ShopRate3Iter>d__;
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x0025959F File Offset: 0x0025779F
		[NullableContext(1)]
		public int[] ShopRate4()
		{
			return this.GetShopRate4Array();
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x002595A7 File Offset: 0x002577A7
		[NullableContext(1)]
		public IEnumerable<int> ShopRate4Iter()
		{
			FloroRanchCardWeight.<ShopRate4Iter>d__42 <ShopRate4Iter>d__ = new FloroRanchCardWeight.<ShopRate4Iter>d__42(-2);
			<ShopRate4Iter>d__.<>3__<>4__this = this;
			return <ShopRate4Iter>d__;
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x002595BC File Offset: 0x002577BC
		[NullableContext(1)]
		public int[] ShopRate5()
		{
			return this.GetShopRate5Array();
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x002595C4 File Offset: 0x002577C4
		[NullableContext(1)]
		public IEnumerable<int> ShopRate5Iter()
		{
			FloroRanchCardWeight.<ShopRate5Iter>d__44 <ShopRate5Iter>d__ = new FloroRanchCardWeight.<ShopRate5Iter>d__44(-2);
			<ShopRate5Iter>d__.<>3__<>4__this = this;
			return <ShopRate5Iter>d__;
		}

		// Token: 0x040052EB RID: 21227
		private Table __p;
	}
}
