using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCD RID: 4045
	public struct RiskHarvestDifficulty : IFlatbufferObject
	{
		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x002E1238 File Offset: 0x002DF438
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x002E1245 File Offset: 0x002DF445
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x002E124C File Offset: 0x002DF44C
		public static RiskHarvestDifficulty GetRootAsRiskHarvestDifficulty(ByteBuffer _bb)
		{
			return RiskHarvestDifficulty.GetRootAsRiskHarvestDifficulty(_bb, default(RiskHarvestDifficulty));
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x002E1268 File Offset: 0x002DF468
		public static RiskHarvestDifficulty GetRootAsRiskHarvestDifficulty(ByteBuffer _bb, RiskHarvestDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x002E1285 File Offset: 0x002DF485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x002E1294 File Offset: 0x002DF494
		public RiskHarvestDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x002E12A4 File Offset: 0x002DF4A4
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

		// Token: 0x0600BD67 RID: 48487 RVA: 0x002E12E0 File Offset: 0x002DF4E0
		public int LevelGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x002E1320 File Offset: 0x002DF520
		public int LevelGroupLength
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

		// Token: 0x0600BD69 RID: 48489 RVA: 0x002E134B File Offset: 0x002DF54B
		public Span<int> GetLevelGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BD6A RID: 48490 RVA: 0x002E135A File Offset: 0x002DF55A
		public int[] GetLevelGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x002E1374 File Offset: 0x002DF574
		public int TimeRatio
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

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x002E13B0 File Offset: 0x002DF5B0
		public int MonsterRatio
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

		// Token: 0x0600BD6D RID: 48493 RVA: 0x002E13F0 File Offset: 0x002DF5F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelGroupIter()或GetLevelGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelGroup()
		{
			RiskHarvestDifficulty riskHarvestDifficulty = this;
			return riskHarvestDifficulty.GetLevelGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x002E1414 File Offset: 0x002DF614
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelGroupIter()
		{
			RiskHarvestDifficulty.<LevelGroupIter>d__20 <LevelGroupIter>d__ = new RiskHarvestDifficulty.<LevelGroupIter>d__20(-2);
			<LevelGroupIter>d__.<>3__<>4__this = this;
			return <LevelGroupIter>d__;
		}

		// Token: 0x040050A8 RID: 20648
		private Table __p;
	}
}
