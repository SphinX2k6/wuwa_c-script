using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754D RID: 30029
	public struct IVisionSettlementTip : IFlatbufferObject
	{
		// Token: 0x1700E3D5 RID: 58325
		// (get) Token: 0x06036A28 RID: 223784 RVA: 0x0076BEAD File Offset: 0x0076A0AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A29 RID: 223785 RVA: 0x0076BEBA File Offset: 0x0076A0BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A2A RID: 223786 RVA: 0x0076BEC4 File Offset: 0x0076A0C4
		public static IVisionSettlementTip GetRootAsIVisionSettlementTip(ByteBuffer _bb)
		{
			return IVisionSettlementTip.GetRootAsIVisionSettlementTip(_bb, default(IVisionSettlementTip));
		}

		// Token: 0x06036A2B RID: 223787 RVA: 0x0076BEE0 File Offset: 0x0076A0E0
		public static IVisionSettlementTip GetRootAsIVisionSettlementTip(ByteBuffer _bb, IVisionSettlementTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A2C RID: 223788 RVA: 0x0076BEFD File Offset: 0x0076A0FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A2D RID: 223789 RVA: 0x0076BF0C File Offset: 0x0076A10C
		public IVisionSettlementTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3D6 RID: 58326
		// (get) Token: 0x06036A2E RID: 223790 RVA: 0x0076BF1C File Offset: 0x0076A11C
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

		// Token: 0x1700E3D7 RID: 58327
		// (get) Token: 0x06036A2F RID: 223791 RVA: 0x0076BF58 File Offset: 0x0076A158
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

		// Token: 0x06036A30 RID: 223792 RVA: 0x0076BF8F File Offset: 0x0076A18F
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036A31 RID: 223793 RVA: 0x0076BF9E File Offset: 0x0076A19E
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E3D8 RID: 58328
		// (get) Token: 0x06036A32 RID: 223794 RVA: 0x0076BFAC File Offset: 0x0076A1AC
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

		// Token: 0x06036A33 RID: 223795 RVA: 0x0076BFE3 File Offset: 0x0076A1E3
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036A34 RID: 223796 RVA: 0x0076BFF2 File Offset: 0x0076A1F2
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06036A35 RID: 223797 RVA: 0x0076C000 File Offset: 0x0076A200
		public static Offset<IVisionSettlementTip> CreateIVisionSettlementTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVisionSettlementTip.AddTidSubText(builder, TidSubTextOffset);
			IVisionSettlementTip.AddTidMainText(builder, TidMainTextOffset);
			IVisionSettlementTip.AddType(builder, Type);
			return IVisionSettlementTip.EndIVisionSettlementTip(builder);
		}

		// Token: 0x06036A36 RID: 223798 RVA: 0x0076C024 File Offset: 0x0076A224
		public static void StartIVisionSettlementTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036A37 RID: 223799 RVA: 0x0076C02D File Offset: 0x0076A22D
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A38 RID: 223800 RVA: 0x0076C038 File Offset: 0x0076A238
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06036A39 RID: 223801 RVA: 0x0076C048 File Offset: 0x0076A248
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06036A3A RID: 223802 RVA: 0x0076C058 File Offset: 0x0076A258
		public static Offset<IVisionSettlementTip> EndIVisionSettlementTip(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSettlementTip>(builder.EndTable());
		}

		// Token: 0x06036A3B RID: 223803 RVA: 0x0076C068 File Offset: 0x0076A268
		public IVisionSettlementTipT UnPack()
		{
			IVisionSettlementTipT visionSettlementTipT = new IVisionSettlementTipT();
			this.UnPackTo(visionSettlementTipT);
			return visionSettlementTipT;
		}

		// Token: 0x06036A3C RID: 223804 RVA: 0x0076C083 File Offset: 0x0076A283
		public void UnPackTo(IVisionSettlementTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06036A3D RID: 223805 RVA: 0x0076C0AC File Offset: 0x0076A2AC
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

		// Token: 0x04012444 RID: 74820
		private Table __p;
	}
}
