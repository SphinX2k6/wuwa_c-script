using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108E RID: 4238
	public struct RefineRecommend : IFlatbufferObject
	{
		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600C0BF RID: 49343 RVA: 0x002F74BD File Offset: 0x002F56BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x002F74CA File Offset: 0x002F56CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x002F74D4 File Offset: 0x002F56D4
		public static RefineRecommend GetRootAsRefineRecommend(ByteBuffer _bb)
		{
			return RefineRecommend.GetRootAsRefineRecommend(_bb, default(RefineRecommend));
		}

		// Token: 0x0600C0C2 RID: 49346 RVA: 0x002F74F0 File Offset: 0x002F56F0
		public static RefineRecommend GetRootAsRefineRecommend(ByteBuffer _bb, RefineRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x002F750D File Offset: 0x002F570D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x002F751C File Offset: 0x002F571C
		public RefineRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600C0C5 RID: 49349 RVA: 0x002F752C File Offset: 0x002F572C
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

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600C0C6 RID: 49350 RVA: 0x002F7568 File Offset: 0x002F5768
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

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x002F75A4 File Offset: 0x002F57A4
		public int FetterArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600C0C8 RID: 49352 RVA: 0x002F75E4 File Offset: 0x002F57E4
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

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x002F760F File Offset: 0x002F580F
		public Span<int> GetFetterArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x002F761E File Offset: 0x002F581E
		public int[] GetFetterArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x002F7638 File Offset: 0x002F5838
		public int PropertyArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600C0CC RID: 49356 RVA: 0x002F7678 File Offset: 0x002F5878
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

		// Token: 0x0600C0CD RID: 49357 RVA: 0x002F76A4 File Offset: 0x002F58A4
		public Span<int> GetPropertyArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x002F76B4 File Offset: 0x002F58B4
		public int[] GetPropertyArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x002F76CC File Offset: 0x002F58CC
		[NullableContext(1)]
		public int[] FetterArray()
		{
			return this.GetFetterArrayArray();
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x002F76D4 File Offset: 0x002F58D4
		[NullableContext(1)]
		public IEnumerable<int> FetterArrayIter()
		{
			RefineRecommend.<FetterArrayIter>d__23 <FetterArrayIter>d__ = new RefineRecommend.<FetterArrayIter>d__23(-2);
			<FetterArrayIter>d__.<>3__<>4__this = this;
			return <FetterArrayIter>d__;
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x002F76E9 File Offset: 0x002F58E9
		[NullableContext(1)]
		public int[] PropertyArray()
		{
			return this.GetPropertyArrayArray();
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x002F76F1 File Offset: 0x002F58F1
		[NullableContext(1)]
		public IEnumerable<int> PropertyArrayIter()
		{
			RefineRecommend.<PropertyArrayIter>d__25 <PropertyArrayIter>d__ = new RefineRecommend.<PropertyArrayIter>d__25(-2);
			<PropertyArrayIter>d__.<>3__<>4__this = this;
			return <PropertyArrayIter>d__;
		}

		// Token: 0x04005667 RID: 22119
		private Table __p;
	}
}
