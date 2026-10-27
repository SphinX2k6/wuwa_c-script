using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0D RID: 3341
	public struct GPUMonsterWave : IFlatbufferObject
	{
		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x0024DF11 File Offset: 0x0024C111
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x0024DF1E File Offset: 0x0024C11E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x0024DF28 File Offset: 0x0024C128
		public static GPUMonsterWave GetRootAsGPUMonsterWave(ByteBuffer _bb)
		{
			return GPUMonsterWave.GetRootAsGPUMonsterWave(_bb, default(GPUMonsterWave));
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x0024DF44 File Offset: 0x0024C144
		public static GPUMonsterWave GetRootAsGPUMonsterWave(ByteBuffer _bb, GPUMonsterWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x0024DF61 File Offset: 0x0024C161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x0024DF70 File Offset: 0x0024C170
		public GPUMonsterWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x0024DF80 File Offset: 0x0024C180
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

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x0024DFBC File Offset: 0x0024C1BC
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

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06007BCA RID: 31690 RVA: 0x0024DFF8 File Offset: 0x0024C1F8
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x0024E034 File Offset: 0x0024C234
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

		// Token: 0x06007BCC RID: 31692 RVA: 0x0024E074 File Offset: 0x0024C274
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x0024E0B4 File Offset: 0x0024C2B4
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

		// Token: 0x06007BCE RID: 31694 RVA: 0x0024E0E0 File Offset: 0x0024C2E0
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x0024E0F0 File Offset: 0x0024C2F0
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0024E108 File Offset: 0x0024C308
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterSpawnGroupIter()或GetMonsterSpawnGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterSpawnGroup()
		{
			GPUMonsterWave gpumonsterWave = this;
			return gpumonsterWave.GetMonsterSpawnGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x0024E12C File Offset: 0x0024C32C
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterSpawnGroupIter()
		{
			GPUMonsterWave.<MonsterSpawnGroupIter>d__22 <MonsterSpawnGroupIter>d__ = new GPUMonsterWave.<MonsterSpawnGroupIter>d__22(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x04004D83 RID: 19843
		private Table __p;
	}
}
