using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3B RID: 3899
	public struct PinballWaveConfig : IFlatbufferObject
	{
		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x002C53E9 File Offset: 0x002C35E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B07E RID: 45182 RVA: 0x002C53F6 File Offset: 0x002C35F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x002C5400 File Offset: 0x002C3600
		public static PinballWaveConfig GetRootAsPinballWaveConfig(ByteBuffer _bb)
		{
			return PinballWaveConfig.GetRootAsPinballWaveConfig(_bb, default(PinballWaveConfig));
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x002C541C File Offset: 0x002C361C
		public static PinballWaveConfig GetRootAsPinballWaveConfig(ByteBuffer _bb, PinballWaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x002C5439 File Offset: 0x002C3639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x002C5448 File Offset: 0x002C3648
		public PinballWaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x002C5458 File Offset: 0x002C3658
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

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600B084 RID: 45188 RVA: 0x002C5494 File Offset: 0x002C3694
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

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x002C54D0 File Offset: 0x002C36D0
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

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600B086 RID: 45190 RVA: 0x002C550C File Offset: 0x002C370C
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

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600B087 RID: 45191 RVA: 0x002C554C File Offset: 0x002C374C
		public int WaveCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x002C558C File Offset: 0x002C378C
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600B089 RID: 45193 RVA: 0x002C55CC File Offset: 0x002C37CC
		public int ConditionSpawnIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B08A RID: 45194 RVA: 0x002C55F8 File Offset: 0x002C37F8
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B08B RID: 45195 RVA: 0x002C5608 File Offset: 0x002C3808
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600B08C RID: 45196 RVA: 0x002C5620 File Offset: 0x002C3820
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x002C5660 File Offset: 0x002C3860
		public int MonsterSpawnGroupLength
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

		// Token: 0x0600B08E RID: 45198 RVA: 0x002C568C File Offset: 0x002C388C
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B08F RID: 45199 RVA: 0x002C569C File Offset: 0x002C389C
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600B090 RID: 45200 RVA: 0x002C56B4 File Offset: 0x002C38B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionSpawnIdsIter()或GetConditionSpawnIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionSpawnIds()
		{
			PinballWaveConfig pinballWaveConfig = this;
			return pinballWaveConfig.GetConditionSpawnIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B091 RID: 45201 RVA: 0x002C56D8 File Offset: 0x002C38D8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionSpawnIdsIter()
		{
			PinballWaveConfig.<ConditionSpawnIdsIter>d__29 <ConditionSpawnIdsIter>d__ = new PinballWaveConfig.<ConditionSpawnIdsIter>d__29(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600B092 RID: 45202 RVA: 0x002C56F0 File Offset: 0x002C38F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterSpawnGroupIter()或GetMonsterSpawnGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterSpawnGroup()
		{
			PinballWaveConfig pinballWaveConfig = this;
			return pinballWaveConfig.GetMonsterSpawnGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B093 RID: 45203 RVA: 0x002C5714 File Offset: 0x002C3914
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterSpawnGroupIter()
		{
			PinballWaveConfig.<MonsterSpawnGroupIter>d__31 <MonsterSpawnGroupIter>d__ = new PinballWaveConfig.<MonsterSpawnGroupIter>d__31(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x04005005 RID: 20485
		private Table __p;
	}
}
