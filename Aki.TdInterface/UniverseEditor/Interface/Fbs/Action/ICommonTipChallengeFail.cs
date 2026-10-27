using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200648F RID: 25743
	public struct ICommonTipChallengeFail : IFlatbufferObject
	{
		// Token: 0x1700BF94 RID: 49044
		// (get) Token: 0x0602C9CE RID: 182734 RVA: 0x00620581 File Offset: 0x0061E781
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C9CF RID: 182735 RVA: 0x0062058E File Offset: 0x0061E78E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C9D0 RID: 182736 RVA: 0x00620598 File Offset: 0x0061E798
		public static ICommonTipChallengeFail GetRootAsICommonTipChallengeFail(ByteBuffer _bb)
		{
			return ICommonTipChallengeFail.GetRootAsICommonTipChallengeFail(_bb, default(ICommonTipChallengeFail));
		}

		// Token: 0x0602C9D1 RID: 182737 RVA: 0x006205B4 File Offset: 0x0061E7B4
		public static ICommonTipChallengeFail GetRootAsICommonTipChallengeFail(ByteBuffer _bb, ICommonTipChallengeFail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C9D2 RID: 182738 RVA: 0x006205D1 File Offset: 0x0061E7D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C9D3 RID: 182739 RVA: 0x006205E0 File Offset: 0x0061E7E0
		public ICommonTipChallengeFail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF95 RID: 49045
		// (get) Token: 0x0602C9D4 RID: 182740 RVA: 0x006205F0 File Offset: 0x0061E7F0
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

		// Token: 0x1700BF96 RID: 49046
		// (get) Token: 0x0602C9D5 RID: 182741 RVA: 0x0062062C File Offset: 0x0061E82C
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

		// Token: 0x0602C9D6 RID: 182742 RVA: 0x00620663 File Offset: 0x0061E863
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C9D7 RID: 182743 RVA: 0x00620672 File Offset: 0x0061E872
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C9D8 RID: 182744 RVA: 0x00620680 File Offset: 0x0061E880
		public static Offset<ICommonTipChallengeFail> CreateICommonTipChallengeFail(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipChallengeFail.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeFail.AddType(builder, Type);
			return ICommonTipChallengeFail.EndICommonTipChallengeFail(builder);
		}

		// Token: 0x0602C9D9 RID: 182745 RVA: 0x0062069D File Offset: 0x0061E89D
		public static void StartICommonTipChallengeFail(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C9DA RID: 182746 RVA: 0x006206A6 File Offset: 0x0061E8A6
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C9DB RID: 182747 RVA: 0x006206B1 File Offset: 0x0061E8B1
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602C9DC RID: 182748 RVA: 0x006206C1 File Offset: 0x0061E8C1
		public static Offset<ICommonTipChallengeFail> EndICommonTipChallengeFail(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeFail>(builder.EndTable());
		}

		// Token: 0x0602C9DD RID: 182749 RVA: 0x006206D0 File Offset: 0x0061E8D0
		public ICommonTipChallengeFailT UnPack()
		{
			ICommonTipChallengeFailT commonTipChallengeFailT = new ICommonTipChallengeFailT();
			this.UnPackTo(commonTipChallengeFailT);
			return commonTipChallengeFailT;
		}

		// Token: 0x0602C9DE RID: 182750 RVA: 0x006206EB File Offset: 0x0061E8EB
		public void UnPackTo(ICommonTipChallengeFailT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602C9DF RID: 182751 RVA: 0x00620708 File Offset: 0x0061E908
		public static Offset<ICommonTipChallengeFail> Pack(FlatBufferBuilder builder, ICommonTipChallengeFailT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeFail>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipChallengeFail.CreateICommonTipChallengeFail(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04010A9C RID: 68252
		private Table __p;
	}
}
