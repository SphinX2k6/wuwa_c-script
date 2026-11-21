using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D40 RID: 32064
	public struct IVisionSettlementHardTip : IFlatbufferObject
	{
		// Token: 0x1700EFF8 RID: 61432
		// (get) Token: 0x06039E20 RID: 237088 RVA: 0x007CEE66 File Offset: 0x007CD066
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E21 RID: 237089 RVA: 0x007CEE73 File Offset: 0x007CD073
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E22 RID: 237090 RVA: 0x007CEE7C File Offset: 0x007CD07C
		public static IVisionSettlementHardTip GetRootAsIVisionSettlementHardTip(ByteBuffer _bb)
		{
			return IVisionSettlementHardTip.GetRootAsIVisionSettlementHardTip(_bb, default(IVisionSettlementHardTip));
		}

		// Token: 0x06039E23 RID: 237091 RVA: 0x007CEE98 File Offset: 0x007CD098
		public static IVisionSettlementHardTip GetRootAsIVisionSettlementHardTip(ByteBuffer _bb, IVisionSettlementHardTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E24 RID: 237092 RVA: 0x007CEEB5 File Offset: 0x007CD0B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E25 RID: 237093 RVA: 0x007CEEC4 File Offset: 0x007CD0C4
		public IVisionSettlementHardTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFF9 RID: 61433
		// (get) Token: 0x06039E26 RID: 237094 RVA: 0x007CEED4 File Offset: 0x007CD0D4
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

		// Token: 0x1700EFFA RID: 61434
		// (get) Token: 0x06039E27 RID: 237095 RVA: 0x007CEF10 File Offset: 0x007CD110
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

		// Token: 0x06039E28 RID: 237096 RVA: 0x007CEF47 File Offset: 0x007CD147
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039E29 RID: 237097 RVA: 0x007CEF56 File Offset: 0x007CD156
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700EFFB RID: 61435
		// (get) Token: 0x06039E2A RID: 237098 RVA: 0x007CEF64 File Offset: 0x007CD164
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

		// Token: 0x06039E2B RID: 237099 RVA: 0x007CEF9B File Offset: 0x007CD19B
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039E2C RID: 237100 RVA: 0x007CEFAA File Offset: 0x007CD1AA
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039E2D RID: 237101 RVA: 0x007CEFB8 File Offset: 0x007CD1B8
		public static Offset<IVisionSettlementHardTip> CreateIVisionSettlementHardTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVisionSettlementHardTip.AddTidSubText(builder, TidSubTextOffset);
			IVisionSettlementHardTip.AddTidMainText(builder, TidMainTextOffset);
			IVisionSettlementHardTip.AddType(builder, Type);
			return IVisionSettlementHardTip.EndIVisionSettlementHardTip(builder);
		}

		// Token: 0x06039E2E RID: 237102 RVA: 0x007CEFDC File Offset: 0x007CD1DC
		public static void StartIVisionSettlementHardTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039E2F RID: 237103 RVA: 0x007CEFE5 File Offset: 0x007CD1E5
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E30 RID: 237104 RVA: 0x007CEFF0 File Offset: 0x007CD1F0
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06039E31 RID: 237105 RVA: 0x007CF000 File Offset: 0x007CD200
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06039E32 RID: 237106 RVA: 0x007CF010 File Offset: 0x007CD210
		public static Offset<IVisionSettlementHardTip> EndIVisionSettlementHardTip(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSettlementHardTip>(builder.EndTable());
		}

		// Token: 0x06039E33 RID: 237107 RVA: 0x007CF020 File Offset: 0x007CD220
		public IVisionSettlementHardTipT UnPack()
		{
			IVisionSettlementHardTipT visionSettlementHardTipT = new IVisionSettlementHardTipT();
			this.UnPackTo(visionSettlementHardTipT);
			return visionSettlementHardTipT;
		}

		// Token: 0x06039E34 RID: 237108 RVA: 0x007CF03B File Offset: 0x007CD23B
		public void UnPackTo(IVisionSettlementHardTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06039E35 RID: 237109 RVA: 0x007CF064 File Offset: 0x007CD264
		public static Offset<IVisionSettlementHardTip> Pack(FlatBufferBuilder builder, IVisionSettlementHardTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSettlementHardTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return IVisionSettlementHardTip.CreateIVisionSettlementHardTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04013471 RID: 78961
		private Table __p;
	}
}
