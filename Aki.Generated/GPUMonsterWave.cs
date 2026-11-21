using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF2 RID: 3570
	public struct GPUMonsterWave : IFlatbufferObject
	{
		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060081DA RID: 33242 RVA: 0x0026C98F File Offset: 0x0026AB8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x0026C99C File Offset: 0x0026AB9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x0026C9A4 File Offset: 0x0026ABA4
		public static GPUMonsterWave GetRootAsGPUMonsterWave(ByteBuffer _bb)
		{
			return GPUMonsterWave.GetRootAsGPUMonsterWave(_bb, default(GPUMonsterWave));
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x0026C9C0 File Offset: 0x0026ABC0
		public static GPUMonsterWave GetRootAsGPUMonsterWave(ByteBuffer _bb, GPUMonsterWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x0026C9DD File Offset: 0x0026ABDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x0026C9EC File Offset: 0x0026ABEC
		public GPUMonsterWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060081E0 RID: 33248 RVA: 0x0026C9FC File Offset: 0x0026ABFC
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060081E1 RID: 33249 RVA: 0x0026CA38 File Offset: 0x0026AC38
		public int InstId
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

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060081E2 RID: 33250 RVA: 0x0026CA74 File Offset: 0x0026AC74
		public int WaveType
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

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x0026CAB0 File Offset: 0x0026ACB0
		public int WaveCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x0026CAF0 File Offset: 0x0026ACF0
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060081E5 RID: 33253 RVA: 0x0026CB30 File Offset: 0x0026AD30
		public int MonsterSpawnGroupLength
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

		// Token: 0x060081E6 RID: 33254 RVA: 0x0026CB5C File Offset: 0x0026AD5C
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x0026CB6C File Offset: 0x0026AD6C
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x0026CB84 File Offset: 0x0026AD84
		[NullableContext(1)]
		public int[] MonsterSpawnGroup()
		{
			return this.GetMonsterSpawnGroupArray();
		}

		// Token: 0x060081E9 RID: 33257 RVA: 0x0026CB8C File Offset: 0x0026AD8C
		[NullableContext(1)]
		public IEnumerable<int> MonsterSpawnGroupIter()
		{
			GPUMonsterWave.<MonsterSpawnGroupIter>d__22 <MonsterSpawnGroupIter>d__ = new GPUMonsterWave.<MonsterSpawnGroupIter>d__22(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x04005368 RID: 21352
		private Table __p;
	}
}
