using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF7 RID: 3831
	public struct PhantomRecommend : IFlatbufferObject
	{
		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600AA14 RID: 43540 RVA: 0x002B69EC File Offset: 0x002B4BEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x002B69F9 File Offset: 0x002B4BF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x002B6A00 File Offset: 0x002B4C00
		public static PhantomRecommend GetRootAsPhantomRecommend(ByteBuffer _bb)
		{
			return PhantomRecommend.GetRootAsPhantomRecommend(_bb, default(PhantomRecommend));
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x002B6A1C File Offset: 0x002B4C1C
		public static PhantomRecommend GetRootAsPhantomRecommend(ByteBuffer _bb, PhantomRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x002B6A39 File Offset: 0x002B4C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x002B6A48 File Offset: 0x002B4C48
		public PhantomRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x0600AA1A RID: 43546 RVA: 0x002B6A58 File Offset: 0x002B4C58
		public int RoleId
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

		// Token: 0x0600AA1B RID: 43547 RVA: 0x002B6A94 File Offset: 0x002B4C94
		public int PhantomPlanParamId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x0600AA1C RID: 43548 RVA: 0x002B6AD4 File Offset: 0x002B4CD4
		public int PhantomPlanParamIdLength
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

		// Token: 0x0600AA1D RID: 43549 RVA: 0x002B6AFF File Offset: 0x002B4CFF
		public Span<int> GetPhantomPlanParamIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x002B6B0E File Offset: 0x002B4D0E
		public int[] GetPhantomPlanParamIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x002B6B28 File Offset: 0x002B4D28
		public int RecommendFetterGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600AA20 RID: 43552 RVA: 0x002B6B68 File Offset: 0x002B4D68
		public int RecommendFetterGroupsLength
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

		// Token: 0x0600AA21 RID: 43553 RVA: 0x002B6B93 File Offset: 0x002B4D93
		public Span<int> GetRecommendFetterGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x002B6BA2 File Offset: 0x002B4DA2
		public int[] GetRecommendFetterGroupsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x002B6BBC File Offset: 0x002B4DBC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomPlanParamIdIter()或GetPhantomPlanParamIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomPlanParamId()
		{
			PhantomRecommend phantomRecommend = this;
			return phantomRecommend.GetPhantomPlanParamIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x002B6BE0 File Offset: 0x002B4DE0
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomPlanParamIdIter()
		{
			PhantomRecommend.<PhantomPlanParamIdIter>d__21 <PhantomPlanParamIdIter>d__ = new PhantomRecommend.<PhantomPlanParamIdIter>d__21(-2);
			<PhantomPlanParamIdIter>d__.<>3__<>4__this = this;
			return <PhantomPlanParamIdIter>d__;
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x002B6BF8 File Offset: 0x002B4DF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendFetterGroupsIter()或GetRecommendFetterGroupsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendFetterGroups()
		{
			PhantomRecommend phantomRecommend = this;
			return phantomRecommend.GetRecommendFetterGroupsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x002B6C1C File Offset: 0x002B4E1C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendFetterGroupsIter()
		{
			PhantomRecommend.<RecommendFetterGroupsIter>d__23 <RecommendFetterGroupsIter>d__ = new PhantomRecommend.<RecommendFetterGroupsIter>d__23(-2);
			<RecommendFetterGroupsIter>d__.<>3__<>4__this = this;
			return <RecommendFetterGroupsIter>d__;
		}

		// Token: 0x04004FBE RID: 20414
		private Table __p;
	}
}
