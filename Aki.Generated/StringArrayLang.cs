using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131F RID: 4895
	public struct StringArrayLang : IFlatbufferObject
	{
		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x0600F93E RID: 63806 RVA: 0x00375BF1 File Offset: 0x00373DF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F93F RID: 63807 RVA: 0x00375BFE File Offset: 0x00373DFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F940 RID: 63808 RVA: 0x00375C08 File Offset: 0x00373E08
		public static StringArrayLang GetRootAsStringArrayLang(ByteBuffer _bb)
		{
			return StringArrayLang.GetRootAsStringArrayLang(_bb, default(StringArrayLang));
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x00375C24 File Offset: 0x00373E24
		public static StringArrayLang GetRootAsStringArrayLang(ByteBuffer _bb, StringArrayLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x00375C41 File Offset: 0x00373E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F943 RID: 63811 RVA: 0x00375C50 File Offset: 0x00373E50
		public StringArrayLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F944 RID: 63812 RVA: 0x00375C60 File Offset: 0x00373E60
		public int ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x0600F945 RID: 63813 RVA: 0x00375CA0 File Offset: 0x00373EA0
		public int ArrayStringLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x00375CCB File Offset: 0x00373ECB
		public Span<int> GetArrayStringBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x00375CDA File Offset: 0x00373EDA
		public int[] GetArrayStringArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x0600F948 RID: 63816 RVA: 0x00375CF1 File Offset: 0x00373EF1
		[NullableContext(1)]
		public int[] ArrayString()
		{
			return this.GetArrayStringArray();
		}

		// Token: 0x0600F949 RID: 63817 RVA: 0x00375CF9 File Offset: 0x00373EF9
		[NullableContext(1)]
		public IEnumerable<int> ArrayStringIter()
		{
			StringArrayLang.<ArrayStringIter>d__14 <ArrayStringIter>d__ = new StringArrayLang.<ArrayStringIter>d__14(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x040059A5 RID: 22949
		private Table __p;
	}
}
