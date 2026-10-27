using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E48 RID: 3656
	public struct MotorFightMainLevel : IFlatbufferObject
	{
		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x0028FB28 File Offset: 0x0028DD28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x0028FB35 File Offset: 0x0028DD35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x0028FB3C File Offset: 0x0028DD3C
		public static MotorFightMainLevel GetRootAsMotorFightMainLevel(ByteBuffer _bb)
		{
			return MotorFightMainLevel.GetRootAsMotorFightMainLevel(_bb, default(MotorFightMainLevel));
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0028FB58 File Offset: 0x0028DD58
		public static MotorFightMainLevel GetRootAsMotorFightMainLevel(ByteBuffer _bb, MotorFightMainLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0028FB75 File Offset: 0x0028DD75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x0028FB84 File Offset: 0x0028DD84
		public MotorFightMainLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x060098C9 RID: 39113 RVA: 0x0028FB94 File Offset: 0x0028DD94
		public int LevelId
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

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x060098CA RID: 39114 RVA: 0x0028FBD0 File Offset: 0x0028DDD0
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

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x060098CB RID: 39115 RVA: 0x0028FC0C File Offset: 0x0028DE0C
		public int PreLevelId
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x0028FC48 File Offset: 0x0028DE48
		public int LevelType
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

		// Token: 0x060098CD RID: 39117 RVA: 0x0028FC88 File Offset: 0x0028DE88
		public int SubLevels(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x060098CE RID: 39118 RVA: 0x0028FCC8 File Offset: 0x0028DEC8
		public int SubLevelsLength
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

		// Token: 0x060098CF RID: 39119 RVA: 0x0028FCF4 File Offset: 0x0028DEF4
		public Span<int> GetSubLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x0028FD04 File Offset: 0x0028DF04
		public int[] GetSubLevelsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x060098D1 RID: 39121 RVA: 0x0028FD1C File Offset: 0x0028DF1C
		public int PlayerHp
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

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x060098D2 RID: 39122 RVA: 0x0028FD5C File Offset: 0x0028DF5C
		public float BaseWorldSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x060098D3 RID: 39123 RVA: 0x0028FDA0 File Offset: 0x0028DFA0
		public float SceneSegmentLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x0028FDE4 File Offset: 0x0028DFE4
		public int Effects(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x060098D5 RID: 39125 RVA: 0x0028FE24 File Offset: 0x0028E024
		public int EffectsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x0028FE50 File Offset: 0x0028E050
		public Span<int> GetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x0028FE60 File Offset: 0x0028E060
		public int[] GetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x060098D8 RID: 39128 RVA: 0x0028FE78 File Offset: 0x0028E078
		public int BigScore
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 20;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x0028FEB8 File Offset: 0x0028E0B8
		public int SkillEnable
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x0028FEF8 File Offset: 0x0028E0F8
		public string NormalMusic
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x0028FF30 File Offset: 0x0028E130
		public Span<byte> GetNormalMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x0028FF40 File Offset: 0x0028E140
		public byte[] GetNormalMusicArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x060098DD RID: 39133 RVA: 0x0028FF58 File Offset: 0x0028E158
		public string BossMusic
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x0028FF90 File Offset: 0x0028E190
		public Span<byte> GetBossMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0028FFA0 File Offset: 0x0028E1A0
		public byte[] GetBossMusicArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x060098E0 RID: 39136 RVA: 0x0028FFB8 File Offset: 0x0028E1B8
		public string StopMusic
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x0028FFF0 File Offset: 0x0028E1F0
		public Span<byte> GetStopMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x00290000 File Offset: 0x0028E200
		public byte[] GetStopMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x00290018 File Offset: 0x0028E218
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effects()
		{
			MotorFightMainLevel motorFightMainLevel = this;
			return motorFightMainLevel.GetEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x0029003C File Offset: 0x0028E23C
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectsIter()
		{
			MotorFightMainLevel.<EffectsIter>d__49 <EffectsIter>d__ = new MotorFightMainLevel.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x00290054 File Offset: 0x0028E254
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubLevelsIter()或GetSubLevelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubLevels()
		{
			MotorFightMainLevel motorFightMainLevel = this;
			return motorFightMainLevel.GetSubLevelsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x00290078 File Offset: 0x0028E278
		[NullableContext(1)]
		public readonly IEnumerable<int> SubLevelsIter()
		{
			MotorFightMainLevel.<SubLevelsIter>d__51 <SubLevelsIter>d__ = new MotorFightMainLevel.<SubLevelsIter>d__51(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x04004EF0 RID: 20208
		private Table __p;
	}
}
