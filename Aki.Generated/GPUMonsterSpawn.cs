using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF1 RID: 3569
	public struct GPUMonsterSpawn : IFlatbufferObject
	{
		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060081C7 RID: 33223 RVA: 0x0026C786 File Offset: 0x0026A986
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x0026C793 File Offset: 0x0026A993
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x0026C79C File Offset: 0x0026A99C
		public static GPUMonsterSpawn GetRootAsGPUMonsterSpawn(ByteBuffer _bb)
		{
			return GPUMonsterSpawn.GetRootAsGPUMonsterSpawn(_bb, default(GPUMonsterSpawn));
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x0026C7B8 File Offset: 0x0026A9B8
		public static GPUMonsterSpawn GetRootAsGPUMonsterSpawn(ByteBuffer _bb, GPUMonsterSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x0026C7D5 File Offset: 0x0026A9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x0026C7E4 File Offset: 0x0026A9E4
		public GPUMonsterSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x0026C7F4 File Offset: 0x0026A9F4
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

		// Token: 0x060081CE RID: 33230 RVA: 0x0026C830 File Offset: 0x0026AA30
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060081CF RID: 33231 RVA: 0x0026C870 File Offset: 0x0026AA70
		public int MonsterIdsLength
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

		// Token: 0x060081D0 RID: 33232 RVA: 0x0026C89B File Offset: 0x0026AA9B
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x0026C8AA File Offset: 0x0026AAAA
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x0026C8C4 File Offset: 0x0026AAC4
		public int SplineList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x0026C904 File Offset: 0x0026AB04
		public int SplineListLength
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

		// Token: 0x060081D4 RID: 33236 RVA: 0x0026C92F File Offset: 0x0026AB2F
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x0026C93E File Offset: 0x0026AB3E
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x0026C955 File Offset: 0x0026AB55
		[NullableContext(1)]
		public int[] MonsterIds()
		{
			return this.GetMonsterIdsArray();
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x0026C95D File Offset: 0x0026AB5D
		[NullableContext(1)]
		public IEnumerable<int> MonsterIdsIter()
		{
			GPUMonsterSpawn.<MonsterIdsIter>d__21 <MonsterIdsIter>d__ = new GPUMonsterSpawn.<MonsterIdsIter>d__21(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x0026C972 File Offset: 0x0026AB72
		[NullableContext(1)]
		public int[] SplineList()
		{
			return this.GetSplineListArray();
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x0026C97A File Offset: 0x0026AB7A
		[NullableContext(1)]
		public IEnumerable<int> SplineListIter()
		{
			GPUMonsterSpawn.<SplineListIter>d__23 <SplineListIter>d__ = new GPUMonsterSpawn.<SplineListIter>d__23(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x04005367 RID: 21351
		private Table __p;
	}
}
