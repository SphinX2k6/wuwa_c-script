using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2E RID: 2862
	public struct BattleScoreLevelConf : IFlatbufferObject
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x001E28C0 File Offset: 0x001E0AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x001E28CD File Offset: 0x001E0ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x001E28D4 File Offset: 0x001E0AD4
		public static BattleScoreLevelConf GetRootAsBattleScoreLevelConf(ByteBuffer _bb)
		{
			return BattleScoreLevelConf.GetRootAsBattleScoreLevelConf(_bb, default(BattleScoreLevelConf));
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x001E28F0 File Offset: 0x001E0AF0
		public static BattleScoreLevelConf GetRootAsBattleScoreLevelConf(ByteBuffer _bb, BattleScoreLevelConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x001E290D File Offset: 0x001E0B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x001E291C File Offset: 0x001E0B1C
		public BattleScoreLevelConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x001E292C File Offset: 0x001E0B2C
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x001E2968 File Offset: 0x001E0B68
		public int GroupId
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x001E29A4 File Offset: 0x001E0BA4
		public int Level
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

		// Token: 0x06004CDA RID: 19674 RVA: 0x001E29E0 File Offset: 0x001E0BE0
		public int LowerUpperLimits(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x001E2A20 File Offset: 0x001E0C20
		public int LowerUpperLimitsLength
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

		// Token: 0x06004CDC RID: 19676 RVA: 0x001E2A4C File Offset: 0x001E0C4C
		public Span<int> GetLowerUpperLimitsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x001E2A5C File Offset: 0x001E0C5C
		public int[] GetLowerUpperLimitsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x001E2A74 File Offset: 0x001E0C74
		public int BuffTime
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x001E2AB4 File Offset: 0x001E0CB4
		public string Bgm
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x001E2AEC File Offset: 0x001E0CEC
		public Span<byte> GetBgmBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x001E2AFC File Offset: 0x001E0CFC
		public byte[] GetBgmArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x001E2B14 File Offset: 0x001E0D14
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LowerUpperLimitsIter()或GetLowerUpperLimitsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LowerUpperLimits()
		{
			BattleScoreLevelConf battleScoreLevelConf = this;
			return battleScoreLevelConf.GetLowerUpperLimitsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x001E2B38 File Offset: 0x001E0D38
		[NullableContext(1)]
		public readonly IEnumerable<int> LowerUpperLimitsIter()
		{
			BattleScoreLevelConf.<LowerUpperLimitsIter>d__26 <LowerUpperLimitsIter>d__ = new BattleScoreLevelConf.<LowerUpperLimitsIter>d__26(-2);
			<LowerUpperLimitsIter>d__.<>3__<>4__this = this;
			return <LowerUpperLimitsIter>d__;
		}

		// Token: 0x04004B26 RID: 19238
		private Table __p;
	}
}
