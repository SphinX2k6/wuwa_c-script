using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD6 RID: 23510
	public struct INpcPerformOnMonsterCloseby : IFlatbufferObject
	{
		// Token: 0x1700AC09 RID: 44041
		// (get) Token: 0x06026D06 RID: 158982 RVA: 0x00550B36 File Offset: 0x0054ED36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D07 RID: 158983 RVA: 0x00550B43 File Offset: 0x0054ED43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D08 RID: 158984 RVA: 0x00550B4C File Offset: 0x0054ED4C
		public static INpcPerformOnMonsterCloseby GetRootAsINpcPerformOnMonsterCloseby(ByteBuffer _bb)
		{
			return INpcPerformOnMonsterCloseby.GetRootAsINpcPerformOnMonsterCloseby(_bb, default(INpcPerformOnMonsterCloseby));
		}

		// Token: 0x06026D09 RID: 158985 RVA: 0x00550B68 File Offset: 0x0054ED68
		public static INpcPerformOnMonsterCloseby GetRootAsINpcPerformOnMonsterCloseby(ByteBuffer _bb, INpcPerformOnMonsterCloseby obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D0A RID: 158986 RVA: 0x00550B85 File Offset: 0x0054ED85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D0B RID: 158987 RVA: 0x00550B94 File Offset: 0x0054ED94
		public INpcPerformOnMonsterCloseby __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC0A RID: 44042
		// (get) Token: 0x06026D0C RID: 158988 RVA: 0x00550BA4 File Offset: 0x0054EDA4
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

		// Token: 0x1700AC0B RID: 44043
		// (get) Token: 0x06026D0D RID: 158989 RVA: 0x00550BE4 File Offset: 0x0054EDE4
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

		// Token: 0x1700AC0C RID: 44044
		// (get) Token: 0x06026D0E RID: 158990 RVA: 0x00550C44 File Offset: 0x0054EE44
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

		// Token: 0x1700AC0D RID: 44045
		// (get) Token: 0x06026D0F RID: 158991 RVA: 0x00550CA4 File Offset: 0x0054EEA4
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

		// Token: 0x06026D10 RID: 158992 RVA: 0x00550CE1 File Offset: 0x0054EEE1
		public static Offset<INpcPerformOnMonsterCloseby> CreateINpcPerformOnMonsterCloseby(FlatBufferBuilder builder, float Range = 0f, Offset<IMontageId> MontageOffset = default(Offset<IMontageId>), Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>), int BubbleRate = 0)
		{
			builder.StartTable(4);
			INpcPerformOnMonsterCloseby.AddBubbleRate(builder, BubbleRate);
			INpcPerformOnMonsterCloseby.AddBubble(builder, BubbleOffset);
			INpcPerformOnMonsterCloseby.AddMontage(builder, MontageOffset);
			INpcPerformOnMonsterCloseby.AddRange(builder, Range);
			return INpcPerformOnMonsterCloseby.EndINpcPerformOnMonsterCloseby(builder);
		}

		// Token: 0x06026D11 RID: 158993 RVA: 0x00550D0D File Offset: 0x0054EF0D
		public static void StartINpcPerformOnMonsterCloseby(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026D12 RID: 158994 RVA: 0x00550D16 File Offset: 0x0054EF16
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(0, range, 0.0);
		}

		// Token: 0x06026D13 RID: 158995 RVA: 0x00550D29 File Offset: 0x0054EF29
		public static void AddMontage(FlatBufferBuilder builder, Offset<IMontageId> montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06026D14 RID: 158996 RVA: 0x00550D39 File Offset: 0x0054EF39
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(2, bubbleOffset.Value, 0);
		}

		// Token: 0x06026D15 RID: 158997 RVA: 0x00550D49 File Offset: 0x0054EF49
		public static void AddBubbleRate(FlatBufferBuilder builder, int bubbleRate)
		{
			builder.AddInt(3, bubbleRate, 0);
		}

		// Token: 0x06026D16 RID: 158998 RVA: 0x00550D54 File Offset: 0x0054EF54
		public static Offset<INpcPerformOnMonsterCloseby> EndINpcPerformOnMonsterCloseby(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformOnMonsterCloseby>(builder.EndTable());
		}

		// Token: 0x06026D17 RID: 158999 RVA: 0x00550D64 File Offset: 0x0054EF64
		public INpcPerformOnMonsterClosebyT UnPack()
		{
			INpcPerformOnMonsterClosebyT npcPerformOnMonsterClosebyT = new INpcPerformOnMonsterClosebyT();
			this.UnPackTo(npcPerformOnMonsterClosebyT);
			return npcPerformOnMonsterClosebyT;
		}

		// Token: 0x06026D18 RID: 159000 RVA: 0x00550D80 File Offset: 0x0054EF80
		public void UnPackTo(INpcPerformOnMonsterClosebyT _o)
		{
			_o.Range = this.Range;
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.Bubble = ((this.Bubble != null) ? this.Bubble.Value.UnPack() : null);
			_o.BubbleRate = this.BubbleRate;
		}

		// Token: 0x06026D19 RID: 159001 RVA: 0x00550E04 File Offset: 0x0054F004
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

		// Token: 0x0400F640 RID: 63040
		private Table __p;
	}
}
