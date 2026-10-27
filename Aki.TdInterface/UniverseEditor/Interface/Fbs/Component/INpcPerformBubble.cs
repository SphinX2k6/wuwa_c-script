using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562F RID: 22063
	public struct INpcPerformBubble : IFlatbufferObject
	{
		// Token: 0x1700A346 RID: 41798
		// (get) Token: 0x06024A19 RID: 150041 RVA: 0x0050DABC File Offset: 0x0050BCBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A1A RID: 150042 RVA: 0x0050DAC9 File Offset: 0x0050BCC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A1B RID: 150043 RVA: 0x0050DAD0 File Offset: 0x0050BCD0
		public static INpcPerformBubble GetRootAsINpcPerformBubble(ByteBuffer _bb)
		{
			return INpcPerformBubble.GetRootAsINpcPerformBubble(_bb, default(INpcPerformBubble));
		}

		// Token: 0x06024A1C RID: 150044 RVA: 0x0050DAEC File Offset: 0x0050BCEC
		public static INpcPerformBubble GetRootAsINpcPerformBubble(ByteBuffer _bb, INpcPerformBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A1D RID: 150045 RVA: 0x0050DB09 File Offset: 0x0050BD09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A1E RID: 150046 RVA: 0x0050DB18 File Offset: 0x0050BD18
		public INpcPerformBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A347 RID: 41799
		// (get) Token: 0x06024A1F RID: 150047 RVA: 0x0050DB28 File Offset: 0x0050BD28
		public IBubbleIndex? Bubble
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A348 RID: 41800
		// (get) Token: 0x06024A20 RID: 150048 RVA: 0x0050DB88 File Offset: 0x0050BD88
		public int Rate
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

		// Token: 0x06024A21 RID: 150049 RVA: 0x0050DBC4 File Offset: 0x0050BDC4
		public static Offset<INpcPerformBubble> CreateINpcPerformBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>), int Rate = 0)
		{
			builder.StartTable(2);
			INpcPerformBubble.AddRate(builder, Rate);
			INpcPerformBubble.AddBubble(builder, BubbleOffset);
			return INpcPerformBubble.EndINpcPerformBubble(builder);
		}

		// Token: 0x06024A22 RID: 150050 RVA: 0x0050DBE1 File Offset: 0x0050BDE1
		public static void StartINpcPerformBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024A23 RID: 150051 RVA: 0x0050DBEA File Offset: 0x0050BDEA
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(0, bubbleOffset.Value, 0);
		}

		// Token: 0x06024A24 RID: 150052 RVA: 0x0050DBFA File Offset: 0x0050BDFA
		public static void AddRate(FlatBufferBuilder builder, int rate)
		{
			builder.AddInt(1, rate, 0);
		}

		// Token: 0x06024A25 RID: 150053 RVA: 0x0050DC05 File Offset: 0x0050BE05
		public static Offset<INpcPerformBubble> EndINpcPerformBubble(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformBubble>(builder.EndTable());
		}

		// Token: 0x06024A26 RID: 150054 RVA: 0x0050DC14 File Offset: 0x0050BE14
		public INpcPerformBubbleT UnPack()
		{
			INpcPerformBubbleT npcPerformBubbleT = new INpcPerformBubbleT();
			this.UnPackTo(npcPerformBubbleT);
			return npcPerformBubbleT;
		}

		// Token: 0x06024A27 RID: 150055 RVA: 0x0050DC30 File Offset: 0x0050BE30
		public void UnPackTo(INpcPerformBubbleT _o)
		{
			_o.Bubble = ((this.Bubble != null) ? this.Bubble.Value.UnPack() : null);
			_o.Rate = this.Rate;
		}

		// Token: 0x06024A28 RID: 150056 RVA: 0x0050DC78 File Offset: 0x0050BE78
		public static Offset<INpcPerformBubble> Pack(FlatBufferBuilder builder, INpcPerformBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformBubble>);
			}
			Offset<IBubbleIndex> bubbleOffset = (_o.Bubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Bubble);
			return INpcPerformBubble.CreateINpcPerformBubble(builder, bubbleOffset, _o.Rate);
		}

		// Token: 0x0400E9BE RID: 59838
		private Table __p;
	}
}
