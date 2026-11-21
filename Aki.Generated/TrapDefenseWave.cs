using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A7 RID: 4775
	public struct TrapDefenseWave : IFlatbufferObject
	{
		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x0600F231 RID: 62001 RVA: 0x00366193 File Offset: 0x00364393
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F232 RID: 62002 RVA: 0x003661A0 File Offset: 0x003643A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F233 RID: 62003 RVA: 0x003661A8 File Offset: 0x003643A8
		public static TrapDefenseWave GetRootAsTrapDefenseWave(ByteBuffer _bb)
		{
			return TrapDefenseWave.GetRootAsTrapDefenseWave(_bb, default(TrapDefenseWave));
		}

		// Token: 0x0600F234 RID: 62004 RVA: 0x003661C4 File Offset: 0x003643C4
		public static TrapDefenseWave GetRootAsTrapDefenseWave(ByteBuffer _bb, TrapDefenseWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F235 RID: 62005 RVA: 0x003661E1 File Offset: 0x003643E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x003661F0 File Offset: 0x003643F0
		public TrapDefenseWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x0600F237 RID: 62007 RVA: 0x00366200 File Offset: 0x00364400
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

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x0600F238 RID: 62008 RVA: 0x0036623C File Offset: 0x0036443C
		public int WaveId
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

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x0600F239 RID: 62009 RVA: 0x00366278 File Offset: 0x00364478
		public int TrapDefenseLevelId
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

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0600F23A RID: 62010 RVA: 0x003662B4 File Offset: 0x003644B4
		public int RewardGold
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

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0600F23B RID: 62011 RVA: 0x003662F4 File Offset: 0x003644F4
		public int BdDrawConfigId
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

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0600F23C RID: 62012 RVA: 0x00366334 File Offset: 0x00364534
		public int BdDrawCount
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

		// Token: 0x0600F23D RID: 62013 RVA: 0x00366374 File Offset: 0x00364574
		public int BdDrawConfigIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0600F23E RID: 62014 RVA: 0x003663B4 File Offset: 0x003645B4
		public int BdDrawConfigIdsLength
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

		// Token: 0x0600F23F RID: 62015 RVA: 0x003663E0 File Offset: 0x003645E0
		public Span<int> GetBdDrawConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600F240 RID: 62016 RVA: 0x003663F0 File Offset: 0x003645F0
		public int[] GetBdDrawConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x0600F241 RID: 62017 RVA: 0x00366408 File Offset: 0x00364608
		public int GurantteBdDrawRefreshCount
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0600F242 RID: 62018 RVA: 0x00366448 File Offset: 0x00364648
		public int GurantteBdDrawRefreshGold
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0600F243 RID: 62019 RVA: 0x00366488 File Offset: 0x00364688
		public int ShopConfigId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0600F244 RID: 62020 RVA: 0x003664C8 File Offset: 0x003646C8
		public string ReadStageEnhanceTips
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F245 RID: 62021 RVA: 0x00366500 File Offset: 0x00364700
		public Span<byte> GetReadStageEnhanceTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00366510 File Offset: 0x00364710
		public byte[] GetReadStageEnhanceTipsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x0600F247 RID: 62023 RVA: 0x00366528 File Offset: 0x00364728
		public string WaveEnhanceTips
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

		// Token: 0x0600F248 RID: 62024 RVA: 0x00366560 File Offset: 0x00364760
		public Span<byte> GetWaveEnhanceTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x00366570 File Offset: 0x00364770
		public byte[] GetWaveEnhanceTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x0600F24A RID: 62026 RVA: 0x00366588 File Offset: 0x00364788
		public string WaveWarningTips
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

		// Token: 0x0600F24B RID: 62027 RVA: 0x003665C0 File Offset: 0x003647C0
		public Span<byte> GetWaveWarningTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x003665D0 File Offset: 0x003647D0
		public byte[] GetWaveWarningTipsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x0600F24D RID: 62029 RVA: 0x003665E8 File Offset: 0x003647E8
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F24E RID: 62030 RVA: 0x00366628 File Offset: 0x00364828
		public int SplineList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x0600F24F RID: 62031 RVA: 0x00366668 File Offset: 0x00364868
		public int SplineListLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x00366694 File Offset: 0x00364894
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600F251 RID: 62033 RVA: 0x003666A4 File Offset: 0x003648A4
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x0600F252 RID: 62034 RVA: 0x003666BC File Offset: 0x003648BC
		public int CampEntityId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F253 RID: 62035 RVA: 0x003666FC File Offset: 0x003648FC
		public int WaveGainings(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0600F254 RID: 62036 RVA: 0x0036673C File Offset: 0x0036493C
		public int WaveGainingsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00366768 File Offset: 0x00364968
		public Span<int> GetWaveGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x00366778 File Offset: 0x00364978
		public int[] GetWaveGainingsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0600F257 RID: 62039 RVA: 0x00366790 File Offset: 0x00364990
		public bool CanBuildMachine
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x003667D0 File Offset: 0x003649D0
		[NullableContext(1)]
		public int[] BdDrawConfigIds()
		{
			return this.GetBdDrawConfigIdsArray();
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x003667D8 File Offset: 0x003649D8
		[NullableContext(1)]
		public IEnumerable<int> BdDrawConfigIdsIter()
		{
			TrapDefenseWave.<BdDrawConfigIdsIter>d__60 <BdDrawConfigIdsIter>d__ = new TrapDefenseWave.<BdDrawConfigIdsIter>d__60(-2);
			<BdDrawConfigIdsIter>d__.<>3__<>4__this = this;
			return <BdDrawConfigIdsIter>d__;
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x003667ED File Offset: 0x003649ED
		[NullableContext(1)]
		public int[] SplineList()
		{
			return this.GetSplineListArray();
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x003667F5 File Offset: 0x003649F5
		[NullableContext(1)]
		public IEnumerable<int> SplineListIter()
		{
			TrapDefenseWave.<SplineListIter>d__62 <SplineListIter>d__ = new TrapDefenseWave.<SplineListIter>d__62(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x0036680A File Offset: 0x00364A0A
		[NullableContext(1)]
		public int[] WaveGainings()
		{
			return this.GetWaveGainingsArray();
		}

		// Token: 0x0600F25D RID: 62045 RVA: 0x00366812 File Offset: 0x00364A12
		[NullableContext(1)]
		public IEnumerable<int> WaveGainingsIter()
		{
			TrapDefenseWave.<WaveGainingsIter>d__64 <WaveGainingsIter>d__ = new TrapDefenseWave.<WaveGainingsIter>d__64(-2);
			<WaveGainingsIter>d__.<>3__<>4__this = this;
			return <WaveGainingsIter>d__;
		}

		// Token: 0x040058FA RID: 22778
		private Table __p;
	}
}
