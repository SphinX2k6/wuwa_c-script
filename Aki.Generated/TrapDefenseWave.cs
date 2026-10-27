using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001171 RID: 4465
	public struct TrapDefenseWave : IFlatbufferObject
	{
		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x0033B2DD File Offset: 0x003394DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x0033B2EA File Offset: 0x003394EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4C5 RID: 58565 RVA: 0x0033B2F4 File Offset: 0x003394F4
		public static TrapDefenseWave GetRootAsTrapDefenseWave(ByteBuffer _bb)
		{
			return TrapDefenseWave.GetRootAsTrapDefenseWave(_bb, default(TrapDefenseWave));
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x0033B310 File Offset: 0x00339510
		public static TrapDefenseWave GetRootAsTrapDefenseWave(ByteBuffer _bb, TrapDefenseWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4C7 RID: 58567 RVA: 0x0033B32D File Offset: 0x0033952D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x0033B33C File Offset: 0x0033953C
		public TrapDefenseWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x0033B34C File Offset: 0x0033954C
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

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x0033B388 File Offset: 0x00339588
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

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x0033B3C4 File Offset: 0x003395C4
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

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x0033B400 File Offset: 0x00339600
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

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x0033B440 File Offset: 0x00339640
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

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600E4CE RID: 58574 RVA: 0x0033B480 File Offset: 0x00339680
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

		// Token: 0x0600E4CF RID: 58575 RVA: 0x0033B4C0 File Offset: 0x003396C0
		public int BdDrawConfigIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600E4D0 RID: 58576 RVA: 0x0033B500 File Offset: 0x00339700
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

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x0033B52C File Offset: 0x0033972C
		public Span<int> GetBdDrawConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x0033B53C File Offset: 0x0033973C
		public int[] GetBdDrawConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600E4D3 RID: 58579 RVA: 0x0033B554 File Offset: 0x00339754
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

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600E4D4 RID: 58580 RVA: 0x0033B594 File Offset: 0x00339794
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

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x0033B5D4 File Offset: 0x003397D4
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

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x0033B614 File Offset: 0x00339814
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

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x0033B64C File Offset: 0x0033984C
		public Span<byte> GetReadStageEnhanceTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x0033B65C File Offset: 0x0033985C
		public byte[] GetReadStageEnhanceTipsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x0033B674 File Offset: 0x00339874
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

		// Token: 0x0600E4DA RID: 58586 RVA: 0x0033B6AC File Offset: 0x003398AC
		public Span<byte> GetWaveEnhanceTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x0033B6BC File Offset: 0x003398BC
		public byte[] GetWaveEnhanceTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x0033B6D4 File Offset: 0x003398D4
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

		// Token: 0x0600E4DD RID: 58589 RVA: 0x0033B70C File Offset: 0x0033990C
		public Span<byte> GetWaveWarningTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x0033B71C File Offset: 0x0033991C
		public byte[] GetWaveWarningTipsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0033B734 File Offset: 0x00339934
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

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x0033B774 File Offset: 0x00339974
		public int SplineList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0033B7B4 File Offset: 0x003399B4
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

		// Token: 0x0600E4E2 RID: 58594 RVA: 0x0033B7E0 File Offset: 0x003399E0
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600E4E3 RID: 58595 RVA: 0x0033B7F0 File Offset: 0x003399F0
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x0033B808 File Offset: 0x00339A08
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

		// Token: 0x0600E4E5 RID: 58597 RVA: 0x0033B848 File Offset: 0x00339A48
		public int WaveGainings(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x0033B888 File Offset: 0x00339A88
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

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x0033B8B4 File Offset: 0x00339AB4
		public Span<int> GetWaveGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x0033B8C4 File Offset: 0x00339AC4
		public int[] GetWaveGainingsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x0033B8DC File Offset: 0x00339ADC
		public bool CanBuildMachine
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x0033B91C File Offset: 0x00339B1C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BdDrawConfigIdsIter()或GetBdDrawConfigIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BdDrawConfigIds()
		{
			TrapDefenseWave trapDefenseWave = this;
			return trapDefenseWave.GetBdDrawConfigIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4EB RID: 58603 RVA: 0x0033B940 File Offset: 0x00339B40
		[NullableContext(1)]
		public readonly IEnumerable<int> BdDrawConfigIdsIter()
		{
			TrapDefenseWave.<BdDrawConfigIdsIter>d__60 <BdDrawConfigIdsIter>d__ = new TrapDefenseWave.<BdDrawConfigIdsIter>d__60(-2);
			<BdDrawConfigIdsIter>d__.<>3__<>4__this = this;
			return <BdDrawConfigIdsIter>d__;
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x0033B958 File Offset: 0x00339B58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SplineListIter()或GetSplineListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SplineList()
		{
			TrapDefenseWave trapDefenseWave = this;
			return trapDefenseWave.GetSplineListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x0033B97C File Offset: 0x00339B7C
		[NullableContext(1)]
		public readonly IEnumerable<int> SplineListIter()
		{
			TrapDefenseWave.<SplineListIter>d__62 <SplineListIter>d__ = new TrapDefenseWave.<SplineListIter>d__62(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x0033B994 File Offset: 0x00339B94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveGainingsIter()或GetWaveGainingsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveGainings()
		{
			TrapDefenseWave trapDefenseWave = this;
			return trapDefenseWave.GetWaveGainingsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x0033B9B8 File Offset: 0x00339BB8
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveGainingsIter()
		{
			TrapDefenseWave.<WaveGainingsIter>d__64 <WaveGainingsIter>d__ = new TrapDefenseWave.<WaveGainingsIter>d__64(-2);
			<WaveGainingsIter>d__.<>3__<>4__this = this;
			return <WaveGainingsIter>d__;
		}

		// Token: 0x040052B7 RID: 21175
		private Table __p;
	}
}
