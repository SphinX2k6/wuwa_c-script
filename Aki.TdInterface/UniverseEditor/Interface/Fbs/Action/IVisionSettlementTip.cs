using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D43 RID: 32067
	public struct IVisionSettlementTip : IFlatbufferObject
	{
		// Token: 0x1700EFFF RID: 61439
		// (get) Token: 0x06039E3E RID: 237118 RVA: 0x007CF155 File Offset: 0x007CD355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E3F RID: 237119 RVA: 0x007CF162 File Offset: 0x007CD362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E40 RID: 237120 RVA: 0x007CF16C File Offset: 0x007CD36C
		public static IVisionSettlementTip GetRootAsIVisionSettlementTip(ByteBuffer _bb)
		{
			return IVisionSettlementTip.GetRootAsIVisionSettlementTip(_bb, default(IVisionSettlementTip));
		}

		// Token: 0x06039E41 RID: 237121 RVA: 0x007CF188 File Offset: 0x007CD388
		public static IVisionSettlementTip GetRootAsIVisionSettlementTip(ByteBuffer _bb, IVisionSettlementTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E42 RID: 237122 RVA: 0x007CF1A5 File Offset: 0x007CD3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E43 RID: 237123 RVA: 0x007CF1B4 File Offset: 0x007CD3B4
		public IVisionSettlementTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F000 RID: 61440
		// (get) Token: 0x06039E44 RID: 237124 RVA: 0x007CF1C4 File Offset: 0x007CD3C4
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F001 RID: 61441
		// (get) Token: 0x06039E45 RID: 237125 RVA: 0x007CF200 File Offset: 0x007CD400
		public string TidMainText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039E46 RID: 237126 RVA: 0x007CF237 File Offset: 0x007CD437
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039E47 RID: 237127 RVA: 0x007CF246 File Offset: 0x007CD446
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700F002 RID: 61442
		// (get) Token: 0x06039E48 RID: 237128 RVA: 0x007CF254 File Offset: 0x007CD454
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039E49 RID: 237129 RVA: 0x007CF28B File Offset: 0x007CD48B
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039E4A RID: 237130 RVA: 0x007CF29A File Offset: 0x007CD49A
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039E4B RID: 237131 RVA: 0x007CF2A8 File Offset: 0x007CD4A8
		public static Offset<IVisionSettlementTip> CreateIVisionSettlementTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVisionSettlementTip.AddTidSubText(builder, TidSubTextOffset);
			IVisionSettlementTip.AddTidMainText(builder, TidMainTextOffset);
			IVisionSettlementTip.AddType(builder, Type);
			return IVisionSettlementTip.EndIVisionSettlementTip(builder);
		}

		// Token: 0x06039E4C RID: 237132 RVA: 0x007CF2CC File Offset: 0x007CD4CC
		public static void StartIVisionSettlementTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039E4D RID: 237133 RVA: 0x007CF2D5 File Offset: 0x007CD4D5
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E4E RID: 237134 RVA: 0x007CF2E0 File Offset: 0x007CD4E0
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06039E4F RID: 237135 RVA: 0x007CF2F0 File Offset: 0x007CD4F0
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06039E50 RID: 237136 RVA: 0x007CF300 File Offset: 0x007CD500
		public static Offset<IVisionSettlementTip> EndIVisionSettlementTip(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSettlementTip>(builder.EndTable());
		}

		// Token: 0x06039E51 RID: 237137 RVA: 0x007CF310 File Offset: 0x007CD510
		public IVisionSettlementTipT UnPack()
		{
			IVisionSettlementTipT visionSettlementTipT = new IVisionSettlementTipT();
			this.UnPackTo(visionSettlementTipT);
			return visionSettlementTipT;
		}

		// Token: 0x06039E52 RID: 237138 RVA: 0x007CF32B File Offset: 0x007CD52B
		public void UnPackTo(IVisionSettlementTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06039E53 RID: 237139 RVA: 0x007CF354 File Offset: 0x007CD554
		public static Offset<IVisionSettlementTip> Pack(FlatBufferBuilder builder, IVisionSettlementTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSettlementTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return IVisionSettlementTip.CreateIVisionSettlementTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04013475 RID: 78965
		private Table __p;
	}
}
