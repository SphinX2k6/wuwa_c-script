using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC4 RID: 3012
	public struct AiBattleWanderGroup : IFlatbufferObject
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x001F20B2 File Offset: 0x001F02B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x001F20BF File Offset: 0x001F02BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x001F20C8 File Offset: 0x001F02C8
		public static AiBattleWanderGroup GetRootAsAiBattleWanderGroup(ByteBuffer _bb)
		{
			return AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(_bb, default(AiBattleWanderGroup));
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x001F20E4 File Offset: 0x001F02E4
		public static AiBattleWanderGroup GetRootAsAiBattleWanderGroup(ByteBuffer _bb, AiBattleWanderGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x001F2101 File Offset: 0x001F0301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x001F2110 File Offset: 0x001F0310
		public AiBattleWanderGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x001F2120 File Offset: 0x001F0320
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

		// Token: 0x06004BAD RID: 19373 RVA: 0x001F215C File Offset: 0x001F035C
		public float DistanceRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x001F21A0 File Offset: 0x001F03A0
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

		// Token: 0x06004BAF RID: 19375 RVA: 0x001F21CB File Offset: 0x001F03CB
		public Span<float> GetDistanceRangeBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x001F21DA File Offset: 0x001F03DA
		public float[] GetDistanceRangeArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x001F21F4 File Offset: 0x001F03F4
		public float NearActionRates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x001F2238 File Offset: 0x001F0438
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

		// Token: 0x06004BB3 RID: 19379 RVA: 0x001F2263 File Offset: 0x001F0463
		public Span<float> GetNearActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x001F2272 File Offset: 0x001F0472
		public float[] GetNearActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x001F228C File Offset: 0x001F048C
		public float MiddleActionRates(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x001F22D0 File Offset: 0x001F04D0
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

		// Token: 0x06004BB7 RID: 19383 RVA: 0x001F22FC File Offset: 0x001F04FC
		public Span<float> GetMiddleActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x001F230C File Offset: 0x001F050C
		public float[] GetMiddleActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x001F2324 File Offset: 0x001F0524
		public float FarActionRates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x001F2368 File Offset: 0x001F0568
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

		// Token: 0x06004BBB RID: 19387 RVA: 0x001F2394 File Offset: 0x001F0594
		public Span<float> GetFarActionRatesBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x001F23A4 File Offset: 0x001F05A4
		public float[] GetFarActionRatesArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x001F23BC File Offset: 0x001F05BC
		public float TurnSpeeds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x001F2400 File Offset: 0x001F0600
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

		// Token: 0x06004BBF RID: 19391 RVA: 0x001F242C File Offset: 0x001F062C
		public Span<float> GetTurnSpeedsBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x001F243C File Offset: 0x001F063C
		public float[] GetTurnSpeedsArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x001F2454 File Offset: 0x001F0654
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x001F2498 File Offset: 0x001F0698
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x001F24F8 File Offset: 0x001F06F8
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x001F2558 File Offset: 0x001F0758
		public bool OnlyForward
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x001F2598 File Offset: 0x001F0798
		[NullableContext(1)]
		public float[] DistanceRange()
		{
			return this.GetDistanceRangeArray();
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x001F25A0 File Offset: 0x001F07A0
		[NullableContext(1)]
		public IEnumerable<float> DistanceRangeIter()
		{
			AiBattleWanderGroup.<DistanceRangeIter>d__44 <DistanceRangeIter>d__ = new AiBattleWanderGroup.<DistanceRangeIter>d__44(-2);
			<DistanceRangeIter>d__.<>3__<>4__this = this;
			return <DistanceRangeIter>d__;
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x001F25B5 File Offset: 0x001F07B5
		[NullableContext(1)]
		public float[] FarActionRates()
		{
			return this.GetFarActionRatesArray();
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x001F25BD File Offset: 0x001F07BD
		[NullableContext(1)]
		public IEnumerable<float> FarActionRatesIter()
		{
			AiBattleWanderGroup.<FarActionRatesIter>d__46 <FarActionRatesIter>d__ = new AiBattleWanderGroup.<FarActionRatesIter>d__46(-2);
			<FarActionRatesIter>d__.<>3__<>4__this = this;
			return <FarActionRatesIter>d__;
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x001F25D2 File Offset: 0x001F07D2
		[NullableContext(1)]
		public float[] MiddleActionRates()
		{
			return this.GetMiddleActionRatesArray();
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x001F25DA File Offset: 0x001F07DA
		[NullableContext(1)]
		public IEnumerable<float> MiddleActionRatesIter()
		{
			AiBattleWanderGroup.<MiddleActionRatesIter>d__48 <MiddleActionRatesIter>d__ = new AiBattleWanderGroup.<MiddleActionRatesIter>d__48(-2);
			<MiddleActionRatesIter>d__.<>3__<>4__this = this;
			return <MiddleActionRatesIter>d__;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x001F25EF File Offset: 0x001F07EF
		[NullableContext(1)]
		public float[] NearActionRates()
		{
			return this.GetNearActionRatesArray();
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x001F25F7 File Offset: 0x001F07F7
		[NullableContext(1)]
		public IEnumerable<float> NearActionRatesIter()
		{
			AiBattleWanderGroup.<NearActionRatesIter>d__50 <NearActionRatesIter>d__ = new AiBattleWanderGroup.<NearActionRatesIter>d__50(-2);
			<NearActionRatesIter>d__.<>3__<>4__this = this;
			return <NearActionRatesIter>d__;
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x001F260C File Offset: 0x001F080C
		[NullableContext(1)]
		public float[] TurnSpeeds()
		{
			return this.GetTurnSpeedsArray();
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x001F2614 File Offset: 0x001F0814
		[NullableContext(1)]
		public IEnumerable<float> TurnSpeedsIter()
		{
			AiBattleWanderGroup.<TurnSpeedsIter>d__52 <TurnSpeedsIter>d__ = new AiBattleWanderGroup.<TurnSpeedsIter>d__52(-2);
			<TurnSpeedsIter>d__.<>3__<>4__this = this;
			return <TurnSpeedsIter>d__;
		}

		// Token: 0x040050A5 RID: 20645
		private Table __p;
	}
}
