using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6B RID: 3947
	public struct NewPlayerSupportActivityV2 : IFlatbufferObject
	{
		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600A4CD RID: 42189 RVA: 0x002BA14C File Offset: 0x002B834C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x002BA159 File Offset: 0x002B8359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x002BA160 File Offset: 0x002B8360
		public static NewPlayerSupportActivityV2 GetRootAsNewPlayerSupportActivityV2(ByteBuffer _bb)
		{
			return NewPlayerSupportActivityV2.GetRootAsNewPlayerSupportActivityV2(_bb, default(NewPlayerSupportActivityV2));
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x002BA17C File Offset: 0x002B837C
		public static NewPlayerSupportActivityV2 GetRootAsNewPlayerSupportActivityV2(ByteBuffer _bb, NewPlayerSupportActivityV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x002BA199 File Offset: 0x002B8399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x002BA1A8 File Offset: 0x002B83A8
		public NewPlayerSupportActivityV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x0600A4D3 RID: 42195 RVA: 0x002BA1B8 File Offset: 0x002B83B8
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

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x002BA1F4 File Offset: 0x002B83F4
		public int ContinueDays
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

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0600A4D5 RID: 42197 RVA: 0x002BA230 File Offset: 0x002B8430
		public int LivenessContinueDays
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

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x002BA26C File Offset: 0x002B846C
		public int LivenessBonusItemId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600A4D7 RID: 42199 RVA: 0x002BA2AC File Offset: 0x002B84AC
		public int LivenessBonusItemIdLength
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

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x002BA2D8 File Offset: 0x002B84D8
		public Span<int> GetLivenessBonusItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x002BA2E8 File Offset: 0x002B84E8
		public int[] GetLivenessBonusItemIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600A4DA RID: 42202 RVA: 0x002BA300 File Offset: 0x002B8500
		public int LivenessTimes
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

		// Token: 0x0600A4DB RID: 42203 RVA: 0x002BA340 File Offset: 0x002B8540
		public int PayGifts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600A4DC RID: 42204 RVA: 0x002BA380 File Offset: 0x002B8580
		public int PayGiftsLength
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

		// Token: 0x0600A4DD RID: 42205 RVA: 0x002BA3AC File Offset: 0x002B85AC
		public Span<int> GetPayGiftsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x002BA3BC File Offset: 0x002B85BC
		public int[] GetPayGiftsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x002BA3D4 File Offset: 0x002B85D4
		public int PayGiftsContinueDays
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

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x002BA414 File Offset: 0x002B8614
		public int GachaIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600A4E1 RID: 42209 RVA: 0x002BA454 File Offset: 0x002B8654
		public int GachaIdsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x002BA480 File Offset: 0x002B8680
		public Span<int> GetGachaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x002BA490 File Offset: 0x002B8690
		public int[] GetGachaIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x002BA4A8 File Offset: 0x002B86A8
		public int GachaContinueDays
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

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x0600A4E5 RID: 42213 RVA: 0x002BA4E8 File Offset: 0x002B86E8
		public int WeekCardContinueDays
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

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x002BA528 File Offset: 0x002B8728
		public int WeekCardIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600A4E7 RID: 42215 RVA: 0x002BA568 File Offset: 0x002B8768
		public int WeekCardIdsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x002BA594 File Offset: 0x002B8794
		public Span<int> GetWeekCardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x002BA5A4 File Offset: 0x002B87A4
		public int[] GetWeekCardIdsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x002BA5BC File Offset: 0x002B87BC
		[NullableContext(1)]
		public int[] GachaIds()
		{
			return this.GetGachaIdsArray();
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x002BA5C4 File Offset: 0x002B87C4
		[NullableContext(1)]
		public IEnumerable<int> GachaIdsIter()
		{
			NewPlayerSupportActivityV2.<GachaIdsIter>d__43 <GachaIdsIter>d__ = new NewPlayerSupportActivityV2.<GachaIdsIter>d__43(-2);
			<GachaIdsIter>d__.<>3__<>4__this = this;
			return <GachaIdsIter>d__;
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x002BA5D9 File Offset: 0x002B87D9
		[NullableContext(1)]
		public int[] LivenessBonusItemId()
		{
			return this.GetLivenessBonusItemIdArray();
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x002BA5E1 File Offset: 0x002B87E1
		[NullableContext(1)]
		public IEnumerable<int> LivenessBonusItemIdIter()
		{
			NewPlayerSupportActivityV2.<LivenessBonusItemIdIter>d__45 <LivenessBonusItemIdIter>d__ = new NewPlayerSupportActivityV2.<LivenessBonusItemIdIter>d__45(-2);
			<LivenessBonusItemIdIter>d__.<>3__<>4__this = this;
			return <LivenessBonusItemIdIter>d__;
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x002BA5F6 File Offset: 0x002B87F6
		[NullableContext(1)]
		public int[] PayGifts()
		{
			return this.GetPayGiftsArray();
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x002BA5FE File Offset: 0x002B87FE
		[NullableContext(1)]
		public IEnumerable<int> PayGiftsIter()
		{
			NewPlayerSupportActivityV2.<PayGiftsIter>d__47 <PayGiftsIter>d__ = new NewPlayerSupportActivityV2.<PayGiftsIter>d__47(-2);
			<PayGiftsIter>d__.<>3__<>4__this = this;
			return <PayGiftsIter>d__;
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x002BA613 File Offset: 0x002B8813
		[NullableContext(1)]
		public int[] WeekCardIds()
		{
			return this.GetWeekCardIdsArray();
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x002BA61B File Offset: 0x002B881B
		[NullableContext(1)]
		public IEnumerable<int> WeekCardIdsIter()
		{
			NewPlayerSupportActivityV2.<WeekCardIdsIter>d__49 <WeekCardIdsIter>d__ = new NewPlayerSupportActivityV2.<WeekCardIdsIter>d__49(-2);
			<WeekCardIdsIter>d__.<>3__<>4__this = this;
			return <WeekCardIdsIter>d__;
		}

		// Token: 0x04005519 RID: 21785
		private Table __p;
	}
}
