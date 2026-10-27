using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA6 RID: 4006
	public struct RefineRecommend : IFlatbufferObject
	{
		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600BA75 RID: 47733 RVA: 0x002DACD5 File Offset: 0x002D8ED5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x002DACE2 File Offset: 0x002D8EE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x002DACEC File Offset: 0x002D8EEC
		public static RefineRecommend GetRootAsRefineRecommend(ByteBuffer _bb)
		{
			return RefineRecommend.GetRootAsRefineRecommend(_bb, default(RefineRecommend));
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x002DAD08 File Offset: 0x002D8F08
		public static RefineRecommend GetRootAsRefineRecommend(ByteBuffer _bb, RefineRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA79 RID: 47737 RVA: 0x002DAD25 File Offset: 0x002D8F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA7A RID: 47738 RVA: 0x002DAD34 File Offset: 0x002D8F34
		public RefineRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600BA7B RID: 47739 RVA: 0x002DAD44 File Offset: 0x002D8F44
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

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x002DAD80 File Offset: 0x002D8F80
		public int Cost
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

		// Token: 0x0600BA7D RID: 47741 RVA: 0x002DADBC File Offset: 0x002D8FBC
		public int FetterArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x002DADFC File Offset: 0x002D8FFC
		public int FetterArrayLength
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

		// Token: 0x0600BA7F RID: 47743 RVA: 0x002DAE27 File Offset: 0x002D9027
		public Span<int> GetFetterArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x002DAE36 File Offset: 0x002D9036
		public int[] GetFetterArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x002DAE50 File Offset: 0x002D9050
		public int PropertyArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600BA82 RID: 47746 RVA: 0x002DAE90 File Offset: 0x002D9090
		public int PropertyArrayLength
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

		// Token: 0x0600BA83 RID: 47747 RVA: 0x002DAEBC File Offset: 0x002D90BC
		public Span<int> GetPropertyArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x002DAECC File Offset: 0x002D90CC
		public int[] GetPropertyArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x002DAEE4 File Offset: 0x002D90E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FetterArrayIter()或GetFetterArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FetterArray()
		{
			RefineRecommend refineRecommend = this;
			return refineRecommend.GetFetterArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x002DAF08 File Offset: 0x002D9108
		[NullableContext(1)]
		public readonly IEnumerable<int> FetterArrayIter()
		{
			RefineRecommend.<FetterArrayIter>d__23 <FetterArrayIter>d__ = new RefineRecommend.<FetterArrayIter>d__23(-2);
			<FetterArrayIter>d__.<>3__<>4__this = this;
			return <FetterArrayIter>d__;
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x002DAF20 File Offset: 0x002D9120
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyArrayIter()或GetPropertyArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropertyArray()
		{
			RefineRecommend refineRecommend = this;
			return refineRecommend.GetPropertyArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x002DAF44 File Offset: 0x002D9144
		[NullableContext(1)]
		public readonly IEnumerable<int> PropertyArrayIter()
		{
			RefineRecommend.<PropertyArrayIter>d__25 <PropertyArrayIter>d__ = new RefineRecommend.<PropertyArrayIter>d__25(-2);
			<PropertyArrayIter>d__.<>3__<>4__this = this;
			return <PropertyArrayIter>d__;
		}

		// Token: 0x0400507F RID: 20607
		private Table __p;
	}
}
