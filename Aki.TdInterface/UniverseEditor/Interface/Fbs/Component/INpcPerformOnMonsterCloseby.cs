using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005638 RID: 22072
	public struct INpcPerformOnMonsterCloseby : IFlatbufferObject
	{
		// Token: 0x1700A37F RID: 41855
		// (get) Token: 0x06024AE7 RID: 150247 RVA: 0x00510212 File Offset: 0x0050E412
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024AE8 RID: 150248 RVA: 0x0051021F File Offset: 0x0050E41F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024AE9 RID: 150249 RVA: 0x00510228 File Offset: 0x0050E428
		public static INpcPerformOnMonsterCloseby GetRootAsINpcPerformOnMonsterCloseby(ByteBuffer _bb)
		{
			return INpcPerformOnMonsterCloseby.GetRootAsINpcPerformOnMonsterCloseby(_bb, default(INpcPerformOnMonsterCloseby));
		}

		// Token: 0x06024AEA RID: 150250 RVA: 0x00510244 File Offset: 0x0050E444
		public static INpcPerformOnMonsterCloseby GetRootAsINpcPerformOnMonsterCloseby(ByteBuffer _bb, INpcPerformOnMonsterCloseby obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024AEB RID: 150251 RVA: 0x00510261 File Offset: 0x0050E461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AEC RID: 150252 RVA: 0x00510270 File Offset: 0x0050E470
		public INpcPerformOnMonsterCloseby __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A380 RID: 41856
		// (get) Token: 0x06024AED RID: 150253 RVA: 0x00510280 File Offset: 0x0050E480
		public float Range
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A381 RID: 41857
		// (get) Token: 0x06024AEE RID: 150254 RVA: 0x005102C0 File Offset: 0x0050E4C0
		public IMontageId? Montage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A382 RID: 41858
		// (get) Token: 0x06024AEF RID: 150255 RVA: 0x00510320 File Offset: 0x0050E520
		public IBubbleIndex? Bubble
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A383 RID: 41859
		// (get) Token: 0x06024AF0 RID: 150256 RVA: 0x00510380 File Offset: 0x0050E580
		public int BubbleRate
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

		// Token: 0x06024AF1 RID: 150257 RVA: 0x005103BD File Offset: 0x0050E5BD
		public static Offset<INpcPerformOnMonsterCloseby> CreateINpcPerformOnMonsterCloseby(FlatBufferBuilder builder, float Range = 0f, Offset<IMontageId> MontageOffset = default(Offset<IMontageId>), Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>), int BubbleRate = 0)
		{
			builder.StartTable(4);
			INpcPerformOnMonsterCloseby.AddBubbleRate(builder, BubbleRate);
			INpcPerformOnMonsterCloseby.AddBubble(builder, BubbleOffset);
			INpcPerformOnMonsterCloseby.AddMontage(builder, MontageOffset);
			INpcPerformOnMonsterCloseby.AddRange(builder, Range);
			return INpcPerformOnMonsterCloseby.EndINpcPerformOnMonsterCloseby(builder);
		}

		// Token: 0x06024AF2 RID: 150258 RVA: 0x005103E9 File Offset: 0x0050E5E9
		public static void StartINpcPerformOnMonsterCloseby(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024AF3 RID: 150259 RVA: 0x005103F2 File Offset: 0x0050E5F2
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(0, range, 0.0);
		}

		// Token: 0x06024AF4 RID: 150260 RVA: 0x00510405 File Offset: 0x0050E605
		public static void AddMontage(FlatBufferBuilder builder, Offset<IMontageId> montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06024AF5 RID: 150261 RVA: 0x00510415 File Offset: 0x0050E615
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(2, bubbleOffset.Value, 0);
		}

		// Token: 0x06024AF6 RID: 150262 RVA: 0x00510425 File Offset: 0x0050E625
		public static void AddBubbleRate(FlatBufferBuilder builder, int bubbleRate)
		{
			builder.AddInt(3, bubbleRate, 0);
		}

		// Token: 0x06024AF7 RID: 150263 RVA: 0x00510430 File Offset: 0x0050E630
		public static Offset<INpcPerformOnMonsterCloseby> EndINpcPerformOnMonsterCloseby(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformOnMonsterCloseby>(builder.EndTable());
		}

		// Token: 0x06024AF8 RID: 150264 RVA: 0x00510440 File Offset: 0x0050E640
		public INpcPerformOnMonsterClosebyT UnPack()
		{
			INpcPerformOnMonsterClosebyT npcPerformOnMonsterClosebyT = new INpcPerformOnMonsterClosebyT();
			this.UnPackTo(npcPerformOnMonsterClosebyT);
			return npcPerformOnMonsterClosebyT;
		}

		// Token: 0x06024AF9 RID: 150265 RVA: 0x0051045C File Offset: 0x0050E65C
		public void UnPackTo(INpcPerformOnMonsterClosebyT _o)
		{
			_o.Range = this.Range;
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.Bubble = ((this.Bubble != null) ? this.Bubble.Value.UnPack() : null);
			_o.BubbleRate = this.BubbleRate;
		}

		// Token: 0x06024AFA RID: 150266 RVA: 0x005104E0 File Offset: 0x0050E6E0
		public static Offset<INpcPerformOnMonsterCloseby> Pack(FlatBufferBuilder builder, INpcPerformOnMonsterClosebyT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformOnMonsterCloseby>);
			}
			Offset<IMontageId> montageOffset = (_o.Montage == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.Montage);
			Offset<IBubbleIndex> bubbleOffset = (_o.Bubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Bubble);
			return INpcPerformOnMonsterCloseby.CreateINpcPerformOnMonsterCloseby(builder, _o.Range, montageOffset, bubbleOffset, _o.BubbleRate);
		}

		// Token: 0x0400E9DB RID: 59867
		private Table __p;
	}
}
