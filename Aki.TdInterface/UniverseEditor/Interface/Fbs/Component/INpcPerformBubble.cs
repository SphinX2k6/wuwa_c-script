using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCD RID: 23501
	public struct INpcPerformBubble : IFlatbufferObject
	{
		// Token: 0x1700ABCE RID: 43982
		// (get) Token: 0x06026C2C RID: 158764 RVA: 0x0054E17A File Offset: 0x0054C37A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C2D RID: 158765 RVA: 0x0054E187 File Offset: 0x0054C387
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C2E RID: 158766 RVA: 0x0054E190 File Offset: 0x0054C390
		public static INpcPerformBubble GetRootAsINpcPerformBubble(ByteBuffer _bb)
		{
			return INpcPerformBubble.GetRootAsINpcPerformBubble(_bb, default(INpcPerformBubble));
		}

		// Token: 0x06026C2F RID: 158767 RVA: 0x0054E1AC File Offset: 0x0054C3AC
		public static INpcPerformBubble GetRootAsINpcPerformBubble(ByteBuffer _bb, INpcPerformBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C30 RID: 158768 RVA: 0x0054E1C9 File Offset: 0x0054C3C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C31 RID: 158769 RVA: 0x0054E1D8 File Offset: 0x0054C3D8
		public INpcPerformBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABCF RID: 43983
		// (get) Token: 0x06026C32 RID: 158770 RVA: 0x0054E1E8 File Offset: 0x0054C3E8
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

		// Token: 0x1700ABD0 RID: 43984
		// (get) Token: 0x06026C33 RID: 158771 RVA: 0x0054E248 File Offset: 0x0054C448
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

		// Token: 0x06026C34 RID: 158772 RVA: 0x0054E284 File Offset: 0x0054C484
		public static Offset<INpcPerformBubble> CreateINpcPerformBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>), int Rate = 0)
		{
			builder.StartTable(2);
			INpcPerformBubble.AddRate(builder, Rate);
			INpcPerformBubble.AddBubble(builder, BubbleOffset);
			return INpcPerformBubble.EndINpcPerformBubble(builder);
		}

		// Token: 0x06026C35 RID: 158773 RVA: 0x0054E2A1 File Offset: 0x0054C4A1
		public static void StartINpcPerformBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026C36 RID: 158774 RVA: 0x0054E2AA File Offset: 0x0054C4AA
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(0, bubbleOffset.Value, 0);
		}

		// Token: 0x06026C37 RID: 158775 RVA: 0x0054E2BA File Offset: 0x0054C4BA
		public static void AddRate(FlatBufferBuilder builder, int rate)
		{
			builder.AddInt(1, rate, 0);
		}

		// Token: 0x06026C38 RID: 158776 RVA: 0x0054E2C5 File Offset: 0x0054C4C5
		public static Offset<INpcPerformBubble> EndINpcPerformBubble(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformBubble>(builder.EndTable());
		}

		// Token: 0x06026C39 RID: 158777 RVA: 0x0054E2D4 File Offset: 0x0054C4D4
		public INpcPerformBubbleT UnPack()
		{
			INpcPerformBubbleT npcPerformBubbleT = new INpcPerformBubbleT();
			this.UnPackTo(npcPerformBubbleT);
			return npcPerformBubbleT;
		}

		// Token: 0x06026C3A RID: 158778 RVA: 0x0054E2F0 File Offset: 0x0054C4F0
		public void UnPackTo(INpcPerformBubbleT _o)
		{
			_o.Bubble = ((this.Bubble != null) ? this.Bubble.Value.UnPack() : null);
			_o.Rate = this.Rate;
		}

		// Token: 0x06026C3B RID: 158779 RVA: 0x0054E338 File Offset: 0x0054C538
		public static Offset<INpcPerformBubble> Pack(FlatBufferBuilder builder, INpcPerformBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformBubble>);
			}
			Offset<IBubbleIndex> bubbleOffset = (_o.Bubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Bubble);
			return INpcPerformBubble.CreateINpcPerformBubble(builder, bubbleOffset, _o.Rate);
		}

		// Token: 0x0400F622 RID: 63010
		private Table __p;
	}
}
