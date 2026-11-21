using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107E RID: 4222
	public struct RandomSummon : IFlatbufferObject
	{
		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x002F40E0 File Offset: 0x002F22E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x002F40ED File Offset: 0x002F22ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x002F40F4 File Offset: 0x002F22F4
		public static RandomSummon GetRootAsRandomSummon(ByteBuffer _bb)
		{
			return RandomSummon.GetRootAsRandomSummon(_bb, default(RandomSummon));
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x002F4110 File Offset: 0x002F2310
		public static RandomSummon GetRootAsRandomSummon(ByteBuffer _bb, RandomSummon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x002F412D File Offset: 0x002F232D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x002F413C File Offset: 0x002F233C
		public RandomSummon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600BF5E RID: 48990 RVA: 0x002F414C File Offset: 0x002F234C
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

		// Token: 0x0600BF5F RID: 48991 RVA: 0x002F4188 File Offset: 0x002F2388
		public IntArray? Random(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600BF60 RID: 48992 RVA: 0x002F41E8 File Offset: 0x002F23E8
		public int RandomLength
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

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x002F4214 File Offset: 0x002F2414
		public int Count
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

		// Token: 0x0600BF62 RID: 48994 RVA: 0x002F4250 File Offset: 0x002F2450
		[NullableContext(1)]
		public IntArray[] Random()
		{
			return this.RandomIter().ToArray<IntArray>();
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x002F425D File Offset: 0x002F245D
		[NullableContext(1)]
		public IEnumerable<IntArray> RandomIter()
		{
			RandomSummon.<RandomIter>d__16 <RandomIter>d__ = new RandomSummon.<RandomIter>d__16(-2);
			<RandomIter>d__.<>3__<>4__this = this;
			return <RandomIter>d__;
		}

		// Token: 0x0400564E RID: 22094
		private Table __p;
	}
}
