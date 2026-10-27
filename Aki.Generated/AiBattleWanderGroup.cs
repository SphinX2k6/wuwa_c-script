using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEA RID: 2794
	public struct AiBattleWanderGroup : IFlatbufferObject
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x001D2639 File Offset: 0x001D0839
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x001D2646 File Offset: 0x001D0846
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x001D2650 File Offset: 0x001D0850
		public static AiBattleWanderGroup GetRootAsAiBattleWanderGroup(ByteBuffer _bb)
		{
			return AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(_bb, default(AiBattleWanderGroup));
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x001D266C File Offset: 0x001D086C
		public static AiBattleWanderGroup GetRootAsAiBattleWanderGroup(ByteBuffer _bb, AiBattleWanderGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x001D2689 File Offset: 0x001D0889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x001D2698 File Offset: 0x001D0898
		public AiBattleWanderGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x001D26A8 File Offset: 0x001D08A8
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

		// Token: 0x06004666 RID: 18022 RVA: 0x001D26E4 File Offset: 0x001D08E4
		public float DistanceRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x001D2728 File Offset: 0x001D0928
		public int DistanceRangeLength
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

		// Token: 0x06004668 RID: 18024 RVA: 0x001D2753 File Offset: 0x001D0953
		public Span<float> GetDistanceRangeBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x001D2762 File Offset: 0x001D0962
		public float[] GetDistanceRangeArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x001D277C File Offset: 0x001D097C
		public float NearActionRates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x001D27C0 File Offset: 0x001D09C0
		public int NearActionRatesLength
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

		// Token: 0x0600466C RID: 18028 RVA: 0x001D27EB File Offset: 0x001D09EB
		public Span<float> GetNearActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x001D27FA File Offset: 0x001D09FA
		public float[] GetNearActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x001D2814 File Offset: 0x001D0A14
		public float MiddleActionRates(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x001D2858 File Offset: 0x001D0A58
		public int MiddleActionRatesLength
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

		// Token: 0x06004670 RID: 18032 RVA: 0x001D2884 File Offset: 0x001D0A84
		public Span<float> GetMiddleActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x001D2894 File Offset: 0x001D0A94
		public float[] GetMiddleActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x001D28AC File Offset: 0x001D0AAC
		public float FarActionRates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x001D28F0 File Offset: 0x001D0AF0
		public int FarActionRatesLength
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

		// Token: 0x06004674 RID: 18036 RVA: 0x001D291C File Offset: 0x001D0B1C
		public Span<float> GetFarActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x001D292C File Offset: 0x001D0B2C
		public float[] GetFarActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x001D2944 File Offset: 0x001D0B44
		public float TurnSpeeds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x001D2988 File Offset: 0x001D0B88
		public int TurnSpeedsLength
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

		// Token: 0x06004678 RID: 18040 RVA: 0x001D29B4 File Offset: 0x001D0BB4
		public Span<float> GetTurnSpeedsBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x001D29C4 File Offset: 0x001D0BC4
		public float[] GetTurnSpeedsArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x001D29DC File Offset: 0x001D0BDC
		public float RunTurnSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 360f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x001D2A20 File Offset: 0x001D0C20
		public FloatRange? WanderTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x001D2A80 File Offset: 0x001D0C80
		public FloatRange? SumWanderTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x001D2AE0 File Offset: 0x001D0CE0
		public bool OnlyForward
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x001D2B20 File Offset: 0x001D0D20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DistanceRangeIter()或GetDistanceRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] DistanceRange()
		{
			AiBattleWanderGroup aiBattleWanderGroup = this;
			return aiBattleWanderGroup.GetDistanceRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x001D2B44 File Offset: 0x001D0D44
		[NullableContext(1)]
		public readonly IEnumerable<float> DistanceRangeIter()
		{
			AiBattleWanderGroup.<DistanceRangeIter>d__44 <DistanceRangeIter>d__ = new AiBattleWanderGroup.<DistanceRangeIter>d__44(-2);
			<DistanceRangeIter>d__.<>3__<>4__this = this;
			return <DistanceRangeIter>d__;
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x001D2B5C File Offset: 0x001D0D5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FarActionRatesIter()或GetFarActionRatesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] FarActionRates()
		{
			AiBattleWanderGroup aiBattleWanderGroup = this;
			return aiBattleWanderGroup.GetFarActionRatesArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x001D2B80 File Offset: 0x001D0D80
		[NullableContext(1)]
		public readonly IEnumerable<float> FarActionRatesIter()
		{
			AiBattleWanderGroup.<FarActionRatesIter>d__46 <FarActionRatesIter>d__ = new AiBattleWanderGroup.<FarActionRatesIter>d__46(-2);
			<FarActionRatesIter>d__.<>3__<>4__this = this;
			return <FarActionRatesIter>d__;
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x001D2B98 File Offset: 0x001D0D98
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MiddleActionRatesIter()或GetMiddleActionRatesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] MiddleActionRates()
		{
			AiBattleWanderGroup aiBattleWanderGroup = this;
			return aiBattleWanderGroup.GetMiddleActionRatesArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x001D2BBC File Offset: 0x001D0DBC
		[NullableContext(1)]
		public readonly IEnumerable<float> MiddleActionRatesIter()
		{
			AiBattleWanderGroup.<MiddleActionRatesIter>d__48 <MiddleActionRatesIter>d__ = new AiBattleWanderGroup.<MiddleActionRatesIter>d__48(-2);
			<MiddleActionRatesIter>d__.<>3__<>4__this = this;
			return <MiddleActionRatesIter>d__;
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x001D2BD4 File Offset: 0x001D0DD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NearActionRatesIter()或GetNearActionRatesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] NearActionRates()
		{
			AiBattleWanderGroup aiBattleWanderGroup = this;
			return aiBattleWanderGroup.GetNearActionRatesArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x001D2BF8 File Offset: 0x001D0DF8
		[NullableContext(1)]
		public readonly IEnumerable<float> NearActionRatesIter()
		{
			AiBattleWanderGroup.<NearActionRatesIter>d__50 <NearActionRatesIter>d__ = new AiBattleWanderGroup.<NearActionRatesIter>d__50(-2);
			<NearActionRatesIter>d__.<>3__<>4__this = this;
			return <NearActionRatesIter>d__;
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x001D2C10 File Offset: 0x001D0E10
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TurnSpeedsIter()或GetTurnSpeedsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] TurnSpeeds()
		{
			AiBattleWanderGroup aiBattleWanderGroup = this;
			return aiBattleWanderGroup.GetTurnSpeedsArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x001D2C34 File Offset: 0x001D0E34
		[NullableContext(1)]
		public readonly IEnumerable<float> TurnSpeedsIter()
		{
			AiBattleWanderGroup.<TurnSpeedsIter>d__52 <TurnSpeedsIter>d__ = new AiBattleWanderGroup.<TurnSpeedsIter>d__52(-2);
			<TurnSpeedsIter>d__.<>3__<>4__this = this;
			return <TurnSpeedsIter>d__;
		}

		// Token: 0x04004ACB RID: 19147
		private Table __p;
	}
}
