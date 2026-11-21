using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDE RID: 4062
	public struct PhantomSkill : IFlatbufferObject
	{
		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600B061 RID: 45153 RVA: 0x002D3E59 File Offset: 0x002D2059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x002D3E66 File Offset: 0x002D2066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x002D3E70 File Offset: 0x002D2070
		public static PhantomSkill GetRootAsPhantomSkill(ByteBuffer _bb)
		{
			return PhantomSkill.GetRootAsPhantomSkill(_bb, default(PhantomSkill));
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x002D3E8C File Offset: 0x002D208C
		public static PhantomSkill GetRootAsPhantomSkill(ByteBuffer _bb, PhantomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002D3EA9 File Offset: 0x002D20A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002D3EB8 File Offset: 0x002D20B8
		public PhantomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600B067 RID: 45159 RVA: 0x002D3EC8 File Offset: 0x002D20C8
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

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600B068 RID: 45160 RVA: 0x002D3F04 File Offset: 0x002D2104
		public int PhantomSkillId
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

		// Token: 0x0600B069 RID: 45161 RVA: 0x002D3F40 File Offset: 0x002D2140
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600B06A RID: 45162 RVA: 0x002D3F8C File Offset: 0x002D218C
		public int BuffIdsLength
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

		// Token: 0x0600B06B RID: 45163 RVA: 0x002D3FB7 File Offset: 0x002D21B7
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x002D3FCB File Offset: 0x002D21CB
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x002D4008 File Offset: 0x002D2208
		public long SettleIds(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x002D4054 File Offset: 0x002D2254
		public int SettleIdsLength
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

		// Token: 0x0600B06F RID: 45167 RVA: 0x002D4080 File Offset: 0x002D2280
		public Span<long> GetSettleIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x002D4095 File Offset: 0x002D2295
		public long[] GetSettleIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x002D40D4 File Offset: 0x002D22D4
		public long BuffEffects(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600B072 RID: 45170 RVA: 0x002D4120 File Offset: 0x002D2320
		public int BuffEffectsLength
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

		// Token: 0x0600B073 RID: 45171 RVA: 0x002D414C File Offset: 0x002D234C
		public Span<long> GetBuffEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x002D4161 File Offset: 0x002D2361
		public long[] GetBuffEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x002D41A0 File Offset: 0x002D23A0
		public int ChargeEfficiency
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

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x002D41E0 File Offset: 0x002D23E0
		public int SkillGroupId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x002D4220 File Offset: 0x002D2420
		public float SkillCD
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600B078 RID: 45176 RVA: 0x002D4264 File Offset: 0x002D2464
		public string DescriptionEx
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x002D429C File Offset: 0x002D249C
		public Span<byte> GetDescriptionExBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x002D42AC File Offset: 0x002D24AC
		public byte[] GetDescriptionExArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x002D42C4 File Offset: 0x002D24C4
		public string SimplyDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B07C RID: 45180 RVA: 0x002D42FC File Offset: 0x002D24FC
		public Span<byte> GetSimplyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B07D RID: 45181 RVA: 0x002D430C File Offset: 0x002D250C
		public byte[] GetSimplyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x002D4324 File Offset: 0x002D2524
		public bool IfCounterSkill
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x002D4364 File Offset: 0x002D2564
		public string CurLevelDescriptionEx(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600B080 RID: 45184 RVA: 0x002D43A0 File Offset: 0x002D25A0
		public int CurLevelDescriptionExLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x002D43CC File Offset: 0x002D25CC
		public StringArray? LevelDescStrArray(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600B082 RID: 45186 RVA: 0x002D4430 File Offset: 0x002D2630
		public int LevelDescStrArrayLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x002D445C File Offset: 0x002D265C
		public string BattleViewIcon
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

		// Token: 0x0600B084 RID: 45188 RVA: 0x002D4494 File Offset: 0x002D2694
		public Span<byte> GetBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x002D44A4 File Offset: 0x002D26A4
		public byte[] GetBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600B086 RID: 45190 RVA: 0x002D44BC File Offset: 0x002D26BC
		public string SpecialBattleViewIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x002D44F4 File Offset: 0x002D26F4
		public Span<byte> GetSpecialBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x002D4504 File Offset: 0x002D2704
		public byte[] GetSpecialBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x002D451C File Offset: 0x002D271C
		[NullableContext(1)]
		public long[] BuffEffects()
		{
			return this.GetBuffEffectsArray();
		}

		// Token: 0x0600B08A RID: 45194 RVA: 0x002D4524 File Offset: 0x002D2724
		[NullableContext(1)]
		public IEnumerable<long> BuffEffectsIter()
		{
			PhantomSkill.<BuffEffectsIter>d__58 <BuffEffectsIter>d__ = new PhantomSkill.<BuffEffectsIter>d__58(-2);
			<BuffEffectsIter>d__.<>3__<>4__this = this;
			return <BuffEffectsIter>d__;
		}

		// Token: 0x0600B08B RID: 45195 RVA: 0x002D4539 File Offset: 0x002D2739
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600B08C RID: 45196 RVA: 0x002D4541 File Offset: 0x002D2741
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			PhantomSkill.<BuffIdsIter>d__60 <BuffIdsIter>d__ = new PhantomSkill.<BuffIdsIter>d__60(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x002D4556 File Offset: 0x002D2756
		[NullableContext(1)]
		public string[] CurLevelDescriptionEx()
		{
			return this.CurLevelDescriptionExIter().ToArray<string>();
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x002D4563 File Offset: 0x002D2763
		[NullableContext(1)]
		public IEnumerable<string> CurLevelDescriptionExIter()
		{
			PhantomSkill.<CurLevelDescriptionExIter>d__62 <CurLevelDescriptionExIter>d__ = new PhantomSkill.<CurLevelDescriptionExIter>d__62(-2);
			<CurLevelDescriptionExIter>d__.<>3__<>4__this = this;
			return <CurLevelDescriptionExIter>d__;
		}

		// Token: 0x0600B08F RID: 45199 RVA: 0x002D4578 File Offset: 0x002D2778
		[NullableContext(1)]
		public StringArray[] LevelDescStrArray()
		{
			return this.LevelDescStrArrayIter().ToArray<StringArray>();
		}

		// Token: 0x0600B090 RID: 45200 RVA: 0x002D4585 File Offset: 0x002D2785
		[NullableContext(1)]
		public IEnumerable<StringArray> LevelDescStrArrayIter()
		{
			PhantomSkill.<LevelDescStrArrayIter>d__64 <LevelDescStrArrayIter>d__ = new PhantomSkill.<LevelDescStrArrayIter>d__64(-2);
			<LevelDescStrArrayIter>d__.<>3__<>4__this = this;
			return <LevelDescStrArrayIter>d__;
		}

		// Token: 0x0600B091 RID: 45201 RVA: 0x002D459A File Offset: 0x002D279A
		[NullableContext(1)]
		public long[] SettleIds()
		{
			return this.GetSettleIdsArray();
		}

		// Token: 0x0600B092 RID: 45202 RVA: 0x002D45A2 File Offset: 0x002D27A2
		[NullableContext(1)]
		public IEnumerable<long> SettleIdsIter()
		{
			PhantomSkill.<SettleIdsIter>d__66 <SettleIdsIter>d__ = new PhantomSkill.<SettleIdsIter>d__66(-2);
			<SettleIdsIter>d__.<>3__<>4__this = this;
			return <SettleIdsIter>d__;
		}

		// Token: 0x040055A5 RID: 21925
		private Table __p;
	}
}
