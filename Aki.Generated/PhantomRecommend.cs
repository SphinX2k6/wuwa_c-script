using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDC RID: 4060
	public struct PhantomRecommend : IFlatbufferObject
	{
		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x002D3848 File Offset: 0x002D1A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x002D3855 File Offset: 0x002D1A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x002D385C File Offset: 0x002D1A5C
		public static PhantomRecommend GetRootAsPhantomRecommend(ByteBuffer _bb)
		{
			return PhantomRecommend.GetRootAsPhantomRecommend(_bb, default(PhantomRecommend));
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x002D3878 File Offset: 0x002D1A78
		public static PhantomRecommend GetRootAsPhantomRecommend(ByteBuffer _bb, PhantomRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x002D3895 File Offset: 0x002D1A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x002D38A4 File Offset: 0x002D1AA4
		public PhantomRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x002D38B4 File Offset: 0x002D1AB4
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

		// Token: 0x0600B03C RID: 45116 RVA: 0x002D38F0 File Offset: 0x002D1AF0
		public int PhantomPlanParamId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x002D3930 File Offset: 0x002D1B30
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

		// Token: 0x0600B03E RID: 45118 RVA: 0x002D395B File Offset: 0x002D1B5B
		public Span<int> GetPhantomPlanParamIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x002D396A File Offset: 0x002D1B6A
		public int[] GetPhantomPlanParamIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x002D3984 File Offset: 0x002D1B84
		public int RecommendFetterGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x002D39C4 File Offset: 0x002D1BC4
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

		// Token: 0x0600B042 RID: 45122 RVA: 0x002D39EF File Offset: 0x002D1BEF
		public Span<int> GetRecommendFetterGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x002D39FE File Offset: 0x002D1BFE
		public int[] GetRecommendFetterGroupsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x002D3A15 File Offset: 0x002D1C15
		[NullableContext(1)]
		public int[] PhantomPlanParamId()
		{
			return this.GetPhantomPlanParamIdArray();
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x002D3A1D File Offset: 0x002D1C1D
		[NullableContext(1)]
		public IEnumerable<int> PhantomPlanParamIdIter()
		{
			PhantomRecommend.<PhantomPlanParamIdIter>d__21 <PhantomPlanParamIdIter>d__ = new PhantomRecommend.<PhantomPlanParamIdIter>d__21(-2);
			<PhantomPlanParamIdIter>d__.<>3__<>4__this = this;
			return <PhantomPlanParamIdIter>d__;
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x002D3A32 File Offset: 0x002D1C32
		[NullableContext(1)]
		public int[] RecommendFetterGroups()
		{
			return this.GetRecommendFetterGroupsArray();
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x002D3A3A File Offset: 0x002D1C3A
		[NullableContext(1)]
		public IEnumerable<int> RecommendFetterGroupsIter()
		{
			PhantomRecommend.<RecommendFetterGroupsIter>d__23 <RecommendFetterGroupsIter>d__ = new PhantomRecommend.<RecommendFetterGroupsIter>d__23(-2);
			<RecommendFetterGroupsIter>d__.<>3__<>4__this = this;
			return <RecommendFetterGroupsIter>d__;
		}

		// Token: 0x040055A3 RID: 21923
		private Table __p;
	}
}
