using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE2 RID: 3810
	public struct MatchThreeFillRules : IFlatbufferObject
	{
		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060098BC RID: 39100 RVA: 0x0029FFCA File Offset: 0x0029E1CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x0029FFD7 File Offset: 0x0029E1D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x0029FFE0 File Offset: 0x0029E1E0
		public static MatchThreeFillRules GetRootAsMatchThreeFillRules(ByteBuffer _bb)
		{
			return MatchThreeFillRules.GetRootAsMatchThreeFillRules(_bb, default(MatchThreeFillRules));
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0029FFFC File Offset: 0x0029E1FC
		public static MatchThreeFillRules GetRootAsMatchThreeFillRules(ByteBuffer _bb, MatchThreeFillRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x002A0019 File Offset: 0x0029E219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x002A0028 File Offset: 0x0029E228
		public MatchThreeFillRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060098C2 RID: 39106 RVA: 0x002A0038 File Offset: 0x0029E238
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

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x002A0074 File Offset: 0x0029E274
		public int Count
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

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x002A00B0 File Offset: 0x0029E2B0
		public float EliminateProbability
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x002A00F0 File Offset: 0x0029E2F0
		public float RandomProbability
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x002A0134 File Offset: 0x0029E334
		public int Pool(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x060098C7 RID: 39111 RVA: 0x002A0174 File Offset: 0x0029E374
		public int PoolLength
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

		// Token: 0x060098C8 RID: 39112 RVA: 0x002A01A0 File Offset: 0x0029E3A0
		public Span<int> GetPoolBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x002A01B0 File Offset: 0x0029E3B0
		public int[] GetPoolArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x002A01C8 File Offset: 0x0029E3C8
		[NullableContext(1)]
		public int[] Pool()
		{
			return this.GetPoolArray();
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x002A01D0 File Offset: 0x0029E3D0
		[NullableContext(1)]
		public IEnumerable<int> PoolIter()
		{
			MatchThreeFillRules.<PoolIter>d__22 <PoolIter>d__ = new MatchThreeFillRules.<PoolIter>d__22(-2);
			<PoolIter>d__.<>3__<>4__this = this;
			return <PoolIter>d__;
		}

		// Token: 0x04005482 RID: 21634
		private Table __p;
	}
}
