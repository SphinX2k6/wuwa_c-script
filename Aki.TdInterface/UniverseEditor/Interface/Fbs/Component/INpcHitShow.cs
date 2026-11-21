using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC1 RID: 23489
	public struct INpcHitShow : IFlatbufferObject
	{
		// Token: 0x1700ABAD RID: 43949
		// (get) Token: 0x06026BA3 RID: 158627 RVA: 0x0054CFA3 File Offset: 0x0054B1A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026BA4 RID: 158628 RVA: 0x0054CFB0 File Offset: 0x0054B1B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026BA5 RID: 158629 RVA: 0x0054CFB8 File Offset: 0x0054B1B8
		public static INpcHitShow GetRootAsINpcHitShow(ByteBuffer _bb)
		{
			return INpcHitShow.GetRootAsINpcHitShow(_bb, default(INpcHitShow));
		}

		// Token: 0x06026BA6 RID: 158630 RVA: 0x0054CFD4 File Offset: 0x0054B1D4
		public static INpcHitShow GetRootAsINpcHitShow(ByteBuffer _bb, INpcHitShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026BA7 RID: 158631 RVA: 0x0054CFF1 File Offset: 0x0054B1F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026BA8 RID: 158632 RVA: 0x0054D000 File Offset: 0x0054B200
		public INpcHitShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABAE RID: 43950
		// (get) Token: 0x06026BA9 RID: 158633 RVA: 0x0054D010 File Offset: 0x0054B210
		public string HitMontage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BAA RID: 158634 RVA: 0x0054D047 File Offset: 0x0054B247
		public Span<byte> GetHitMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026BAB RID: 158635 RVA: 0x0054D056 File Offset: 0x0054B256
		public byte[] GetHitMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ABAF RID: 43951
		// (get) Token: 0x06026BAC RID: 158636 RVA: 0x0054D064 File Offset: 0x0054B264
		public IBubbleIndex? HitBubble
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ABB0 RID: 43952
		// (get) Token: 0x06026BAD RID: 158637 RVA: 0x0054D0C4 File Offset: 0x0054B2C4
		public int BubbleRate
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

		// Token: 0x06026BAE RID: 158638 RVA: 0x0054D100 File Offset: 0x0054B300
		public static Offset<INpcHitShow> CreateINpcHitShow(FlatBufferBuilder builder, StringOffset HitMontageOffset = default(StringOffset), Offset<IBubbleIndex> HitBubbleOffset = default(Offset<IBubbleIndex>), int BubbleRate = 0)
		{
			builder.StartTable(3);
			INpcHitShow.AddBubbleRate(builder, BubbleRate);
			INpcHitShow.AddHitBubble(builder, HitBubbleOffset);
			INpcHitShow.AddHitMontage(builder, HitMontageOffset);
			return INpcHitShow.EndINpcHitShow(builder);
		}

		// Token: 0x06026BAF RID: 158639 RVA: 0x0054D124 File Offset: 0x0054B324
		public static void StartINpcHitShow(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026BB0 RID: 158640 RVA: 0x0054D12D File Offset: 0x0054B32D
		public static void AddHitMontage(FlatBufferBuilder builder, StringOffset hitMontageOffset)
		{
			builder.AddOffset(0, hitMontageOffset.Value, 0);
		}

		// Token: 0x06026BB1 RID: 158641 RVA: 0x0054D13D File Offset: 0x0054B33D
		public static void AddHitBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> hitBubbleOffset)
		{
			builder.AddOffset(1, hitBubbleOffset.Value, 0);
		}

		// Token: 0x06026BB2 RID: 158642 RVA: 0x0054D14D File Offset: 0x0054B34D
		public static void AddBubbleRate(FlatBufferBuilder builder, int bubbleRate)
		{
			builder.AddInt(2, bubbleRate, 0);
		}

		// Token: 0x06026BB3 RID: 158643 RVA: 0x0054D158 File Offset: 0x0054B358
		public static Offset<INpcHitShow> EndINpcHitShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcHitShow>(builder.EndTable());
		}

		// Token: 0x06026BB4 RID: 158644 RVA: 0x0054D168 File Offset: 0x0054B368
		public INpcHitShowT UnPack()
		{
			INpcHitShowT npcHitShowT = new INpcHitShowT();
			this.UnPackTo(npcHitShowT);
			return npcHitShowT;
		}

		// Token: 0x06026BB5 RID: 158645 RVA: 0x0054D184 File Offset: 0x0054B384
		public void UnPackTo(INpcHitShowT _o)
		{
			_o.HitMontage = this.HitMontage;
			_o.HitBubble = ((this.HitBubble != null) ? this.HitBubble.Value.UnPack() : null);
			_o.BubbleRate = this.BubbleRate;
		}

		// Token: 0x06026BB6 RID: 158646 RVA: 0x0054D1D8 File Offset: 0x0054B3D8
		public static Offset<INpcHitShow> Pack(FlatBufferBuilder builder, INpcHitShowT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcHitShow>);
			}
			StringOffset hitMontageOffset = (_o.HitMontage == null) ? default(StringOffset) : builder.CreateString(_o.HitMontage);
			Offset<IBubbleIndex> hitBubbleOffset = (_o.HitBubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.HitBubble);
			return INpcHitShow.CreateINpcHitShow(builder, hitMontageOffset, hitBubbleOffset, _o.BubbleRate);
		}

		// Token: 0x0400F609 RID: 62985
		private Table __p;
	}
}
