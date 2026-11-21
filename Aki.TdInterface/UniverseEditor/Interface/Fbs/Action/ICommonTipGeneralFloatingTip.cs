using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B06 RID: 27398
	public struct ICommonTipGeneralFloatingTip : IFlatbufferObject
	{
		// Token: 0x1700C935 RID: 51509
		// (get) Token: 0x0602F1A8 RID: 192936 RVA: 0x0066CA25 File Offset: 0x0066AC25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1A9 RID: 192937 RVA: 0x0066CA32 File Offset: 0x0066AC32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1AA RID: 192938 RVA: 0x0066CA3C File Offset: 0x0066AC3C
		public static ICommonTipGeneralFloatingTip GetRootAsICommonTipGeneralFloatingTip(ByteBuffer _bb)
		{
			return ICommonTipGeneralFloatingTip.GetRootAsICommonTipGeneralFloatingTip(_bb, default(ICommonTipGeneralFloatingTip));
		}

		// Token: 0x0602F1AB RID: 192939 RVA: 0x0066CA58 File Offset: 0x0066AC58
		public static ICommonTipGeneralFloatingTip GetRootAsICommonTipGeneralFloatingTip(ByteBuffer _bb, ICommonTipGeneralFloatingTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1AC RID: 192940 RVA: 0x0066CA75 File Offset: 0x0066AC75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1AD RID: 192941 RVA: 0x0066CA84 File Offset: 0x0066AC84
		public ICommonTipGeneralFloatingTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C936 RID: 51510
		// (get) Token: 0x0602F1AE RID: 192942 RVA: 0x0066CA94 File Offset: 0x0066AC94
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

		// Token: 0x1700C937 RID: 51511
		// (get) Token: 0x0602F1AF RID: 192943 RVA: 0x0066CAD0 File Offset: 0x0066ACD0
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

		// Token: 0x0602F1B0 RID: 192944 RVA: 0x0066CB07 File Offset: 0x0066AD07
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F1B1 RID: 192945 RVA: 0x0066CB16 File Offset: 0x0066AD16
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F1B2 RID: 192946 RVA: 0x0066CB24 File Offset: 0x0066AD24
		public static Offset<ICommonTipGeneralFloatingTip> CreateICommonTipGeneralFloatingTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipGeneralFloatingTip.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipGeneralFloatingTip.AddType(builder, Type);
			return ICommonTipGeneralFloatingTip.EndICommonTipGeneralFloatingTip(builder);
		}

		// Token: 0x0602F1B3 RID: 192947 RVA: 0x0066CB41 File Offset: 0x0066AD41
		public static void StartICommonTipGeneralFloatingTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F1B4 RID: 192948 RVA: 0x0066CB4A File Offset: 0x0066AD4A
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F1B5 RID: 192949 RVA: 0x0066CB55 File Offset: 0x0066AD55
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F1B6 RID: 192950 RVA: 0x0066CB65 File Offset: 0x0066AD65
		public static Offset<ICommonTipGeneralFloatingTip> EndICommonTipGeneralFloatingTip(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipGeneralFloatingTip>(builder.EndTable());
		}

		// Token: 0x0602F1B7 RID: 192951 RVA: 0x0066CB74 File Offset: 0x0066AD74
		public ICommonTipGeneralFloatingTipT UnPack()
		{
			ICommonTipGeneralFloatingTipT commonTipGeneralFloatingTipT = new ICommonTipGeneralFloatingTipT();
			this.UnPackTo(commonTipGeneralFloatingTipT);
			return commonTipGeneralFloatingTipT;
		}

		// Token: 0x0602F1B8 RID: 192952 RVA: 0x0066CB8F File Offset: 0x0066AD8F
		public void UnPackTo(ICommonTipGeneralFloatingTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602F1B9 RID: 192953 RVA: 0x0066CBAC File Offset: 0x0066ADAC
		public static Offset<ICommonTipGeneralFloatingTip> Pack(FlatBufferBuilder builder, ICommonTipGeneralFloatingTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipGeneralFloatingTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipGeneralFloatingTip.CreateICommonTipGeneralFloatingTip(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x040118B9 RID: 71865
		private Table __p;
	}
}
