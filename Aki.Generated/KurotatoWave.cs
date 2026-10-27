using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB6 RID: 3510
	public struct KurotatoWave : IFlatbufferObject
	{
		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x002730A4 File Offset: 0x002712A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x002730B1 File Offset: 0x002712B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x002730B8 File Offset: 0x002712B8
		public static KurotatoWave GetRootAsKurotatoWave(ByteBuffer _bb)
		{
			return KurotatoWave.GetRootAsKurotatoWave(_bb, default(KurotatoWave));
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x002730D4 File Offset: 0x002712D4
		public static KurotatoWave GetRootAsKurotatoWave(ByteBuffer _bb, KurotatoWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x002730F1 File Offset: 0x002712F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00273100 File Offset: 0x00271300
		public KurotatoWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06008BEE RID: 35822 RVA: 0x00273110 File Offset: 0x00271310
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

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06008BEF RID: 35823 RVA: 0x0027314C File Offset: 0x0027134C
		public int Level
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

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06008BF0 RID: 35824 RVA: 0x00273188 File Offset: 0x00271388
		public int Wave
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

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06008BF1 RID: 35825 RVA: 0x002731C4 File Offset: 0x002713C4
		public int WaveType
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

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00273204 File Offset: 0x00271404
		public int WaveConditions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06008BF3 RID: 35827 RVA: 0x00273244 File Offset: 0x00271444
		public int WaveConditionsLength
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

		// Token: 0x06008BF4 RID: 35828 RVA: 0x00273270 File Offset: 0x00271470
		public Span<int> GetWaveConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00273280 File Offset: 0x00271480
		public int[] GetWaveConditionsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x00273298 File Offset: 0x00271498
		public int WaveTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x002732D8 File Offset: 0x002714D8
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x00273318 File Offset: 0x00271518
		public int ConditionSpawnIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00273344 File Offset: 0x00271544
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x00273354 File Offset: 0x00271554
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06008BFB RID: 35835 RVA: 0x0027336C File Offset: 0x0027156C
		public bool HasEndlessModeSelection
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x002733AC File Offset: 0x002715AC
		public bool IsPowerWave
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x002733EC File Offset: 0x002715EC
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x0027342C File Offset: 0x0027162C
		public int MonsterSpawnGroupLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x00273458 File Offset: 0x00271658
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00273468 File Offset: 0x00271668
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x00273480 File Offset: 0x00271680
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionSpawnIdsIter()或GetConditionSpawnIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionSpawnIds()
		{
			KurotatoWave kurotatoWave = this;
			return kurotatoWave.GetConditionSpawnIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x002734A4 File Offset: 0x002716A4
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionSpawnIdsIter()
		{
			KurotatoWave.<ConditionSpawnIdsIter>d__38 <ConditionSpawnIdsIter>d__ = new KurotatoWave.<ConditionSpawnIdsIter>d__38(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x002734BC File Offset: 0x002716BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterSpawnGroupIter()或GetMonsterSpawnGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterSpawnGroup()
		{
			KurotatoWave kurotatoWave = this;
			return kurotatoWave.GetMonsterSpawnGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x002734E0 File Offset: 0x002716E0
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterSpawnGroupIter()
		{
			KurotatoWave.<MonsterSpawnGroupIter>d__40 <MonsterSpawnGroupIter>d__ = new KurotatoWave.<MonsterSpawnGroupIter>d__40(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x002734F8 File Offset: 0x002716F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveConditionsIter()或GetWaveConditionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveConditions()
		{
			KurotatoWave kurotatoWave = this;
			return kurotatoWave.GetWaveConditionsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x0027351C File Offset: 0x0027171C
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveConditionsIter()
		{
			KurotatoWave.<WaveConditionsIter>d__42 <WaveConditionsIter>d__ = new KurotatoWave.<WaveConditionsIter>d__42(-2);
			<WaveConditionsIter>d__.<>3__<>4__this = this;
			return <WaveConditionsIter>d__;
		}

		// Token: 0x04004E4A RID: 20042
		private Table __p;
	}
}
