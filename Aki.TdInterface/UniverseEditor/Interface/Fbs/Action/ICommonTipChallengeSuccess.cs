using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006492 RID: 25746
	public struct ICommonTipChallengeSuccess : IFlatbufferObject
	{
		// Token: 0x1700BF99 RID: 49049
		// (get) Token: 0x0602C9E6 RID: 182758 RVA: 0x006207B5 File Offset: 0x0061E9B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C9E7 RID: 182759 RVA: 0x006207C2 File Offset: 0x0061E9C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C9E8 RID: 182760 RVA: 0x006207CC File Offset: 0x0061E9CC
		public static ICommonTipChallengeSuccess GetRootAsICommonTipChallengeSuccess(ByteBuffer _bb)
		{
			return ICommonTipChallengeSuccess.GetRootAsICommonTipChallengeSuccess(_bb, default(ICommonTipChallengeSuccess));
		}

		// Token: 0x0602C9E9 RID: 182761 RVA: 0x006207E8 File Offset: 0x0061E9E8
		public static ICommonTipChallengeSuccess GetRootAsICommonTipChallengeSuccess(ByteBuffer _bb, ICommonTipChallengeSuccess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C9EA RID: 182762 RVA: 0x00620805 File Offset: 0x0061EA05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C9EB RID: 182763 RVA: 0x00620814 File Offset: 0x0061EA14
		public ICommonTipChallengeSuccess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF9A RID: 49050
		// (get) Token: 0x0602C9EC RID: 182764 RVA: 0x00620824 File Offset: 0x0061EA24
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

		// Token: 0x1700BF9B RID: 49051
		// (get) Token: 0x0602C9ED RID: 182765 RVA: 0x00620860 File Offset: 0x0061EA60
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

		// Token: 0x0602C9EE RID: 182766 RVA: 0x00620897 File Offset: 0x0061EA97
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C9EF RID: 182767 RVA: 0x006208A6 File Offset: 0x0061EAA6
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C9F0 RID: 182768 RVA: 0x006208B4 File Offset: 0x0061EAB4
		public static Offset<ICommonTipChallengeSuccess> CreateICommonTipChallengeSuccess(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipChallengeSuccess.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeSuccess.AddType(builder, Type);
			return ICommonTipChallengeSuccess.EndICommonTipChallengeSuccess(builder);
		}

		// Token: 0x0602C9F1 RID: 182769 RVA: 0x006208D1 File Offset: 0x0061EAD1
		public static void StartICommonTipChallengeSuccess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C9F2 RID: 182770 RVA: 0x006208DA File Offset: 0x0061EADA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C9F3 RID: 182771 RVA: 0x006208E5 File Offset: 0x0061EAE5
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602C9F4 RID: 182772 RVA: 0x006208F5 File Offset: 0x0061EAF5
		public static Offset<ICommonTipChallengeSuccess> EndICommonTipChallengeSuccess(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeSuccess>(builder.EndTable());
		}

		// Token: 0x0602C9F5 RID: 182773 RVA: 0x00620904 File Offset: 0x0061EB04
		public ICommonTipChallengeSuccessT UnPack()
		{
			ICommonTipChallengeSuccessT commonTipChallengeSuccessT = new ICommonTipChallengeSuccessT();
			this.UnPackTo(commonTipChallengeSuccessT);
			return commonTipChallengeSuccessT;
		}

		// Token: 0x0602C9F6 RID: 182774 RVA: 0x0062091F File Offset: 0x0061EB1F
		public void UnPackTo(ICommonTipChallengeSuccessT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602C9F7 RID: 182775 RVA: 0x0062093C File Offset: 0x0061EB3C
		public static Offset<ICommonTipChallengeSuccess> Pack(FlatBufferBuilder builder, ICommonTipChallengeSuccessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeSuccess>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipChallengeSuccess.CreateICommonTipChallengeSuccess(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04010A9F RID: 68255
		private Table __p;
	}
}
