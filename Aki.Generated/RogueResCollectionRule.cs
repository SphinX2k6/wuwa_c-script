using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DF RID: 4319
	public struct RogueResCollectionRule : IFlatbufferObject
	{
		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600C79B RID: 51099 RVA: 0x00306569 File Offset: 0x00304769
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C79C RID: 51100 RVA: 0x00306576 File Offset: 0x00304776
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x00306580 File Offset: 0x00304780
		public static RogueResCollectionRule GetRootAsRogueResCollectionRule(ByteBuffer _bb)
		{
			return RogueResCollectionRule.GetRootAsRogueResCollectionRule(_bb, default(RogueResCollectionRule));
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x0030659C File Offset: 0x0030479C
		public static RogueResCollectionRule GetRootAsRogueResCollectionRule(ByteBuffer _bb, RogueResCollectionRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x003065B9 File Offset: 0x003047B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x003065C8 File Offset: 0x003047C8
		public RogueResCollectionRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600C7A1 RID: 51105 RVA: 0x003065D8 File Offset: 0x003047D8
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

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x00306614 File Offset: 0x00304814
		public int Type
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

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x00306650 File Offset: 0x00304850
		public int Seasons(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x00306690 File Offset: 0x00304890
		public int SeasonsLength
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

		// Token: 0x0600C7A5 RID: 51109 RVA: 0x003066BB File Offset: 0x003048BB
		public Span<int> GetSeasonsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C7A6 RID: 51110 RVA: 0x003066CA File Offset: 0x003048CA
		public int[] GetSeasonsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7A7 RID: 51111 RVA: 0x003066E1 File Offset: 0x003048E1
		[NullableContext(1)]
		public int[] Seasons()
		{
			return this.GetSeasonsArray();
		}

		// Token: 0x0600C7A8 RID: 51112 RVA: 0x003066E9 File Offset: 0x003048E9
		[NullableContext(1)]
		public IEnumerable<int> SeasonsIter()
		{
			RogueResCollectionRule.<SeasonsIter>d__18 <SeasonsIter>d__ = new RogueResCollectionRule.<SeasonsIter>d__18(-2);
			<SeasonsIter>d__.<>3__<>4__this = this;
			return <SeasonsIter>d__;
		}

		// Token: 0x040056C7 RID: 22215
		private Table __p;
	}
}
