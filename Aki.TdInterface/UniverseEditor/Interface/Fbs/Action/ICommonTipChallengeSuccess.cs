using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFD RID: 27389
	public struct ICommonTipChallengeSuccess : IFlatbufferObject
	{
		// Token: 0x1700C926 RID: 51494
		// (get) Token: 0x0602F160 RID: 192864 RVA: 0x0066C389 File Offset: 0x0066A589
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F161 RID: 192865 RVA: 0x0066C396 File Offset: 0x0066A596
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F162 RID: 192866 RVA: 0x0066C3A0 File Offset: 0x0066A5A0
		public static ICommonTipChallengeSuccess GetRootAsICommonTipChallengeSuccess(ByteBuffer _bb)
		{
			return ICommonTipChallengeSuccess.GetRootAsICommonTipChallengeSuccess(_bb, default(ICommonTipChallengeSuccess));
		}

		// Token: 0x0602F163 RID: 192867 RVA: 0x0066C3BC File Offset: 0x0066A5BC
		public static ICommonTipChallengeSuccess GetRootAsICommonTipChallengeSuccess(ByteBuffer _bb, ICommonTipChallengeSuccess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F164 RID: 192868 RVA: 0x0066C3D9 File Offset: 0x0066A5D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F165 RID: 192869 RVA: 0x0066C3E8 File Offset: 0x0066A5E8
		public ICommonTipChallengeSuccess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C927 RID: 51495
		// (get) Token: 0x0602F166 RID: 192870 RVA: 0x0066C3F8 File Offset: 0x0066A5F8
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

		// Token: 0x1700C928 RID: 51496
		// (get) Token: 0x0602F167 RID: 192871 RVA: 0x0066C434 File Offset: 0x0066A634
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

		// Token: 0x0602F168 RID: 192872 RVA: 0x0066C46B File Offset: 0x0066A66B
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F169 RID: 192873 RVA: 0x0066C47A File Offset: 0x0066A67A
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F16A RID: 192874 RVA: 0x0066C488 File Offset: 0x0066A688
		public static Offset<ICommonTipChallengeSuccess> CreateICommonTipChallengeSuccess(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipChallengeSuccess.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeSuccess.AddType(builder, Type);
			return ICommonTipChallengeSuccess.EndICommonTipChallengeSuccess(builder);
		}

		// Token: 0x0602F16B RID: 192875 RVA: 0x0066C4A5 File Offset: 0x0066A6A5
		public static void StartICommonTipChallengeSuccess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F16C RID: 192876 RVA: 0x0066C4AE File Offset: 0x0066A6AE
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F16D RID: 192877 RVA: 0x0066C4B9 File Offset: 0x0066A6B9
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F16E RID: 192878 RVA: 0x0066C4C9 File Offset: 0x0066A6C9
		public static Offset<ICommonTipChallengeSuccess> EndICommonTipChallengeSuccess(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeSuccess>(builder.EndTable());
		}

		// Token: 0x0602F16F RID: 192879 RVA: 0x0066C4D8 File Offset: 0x0066A6D8
		public ICommonTipChallengeSuccessT UnPack()
		{
			ICommonTipChallengeSuccessT commonTipChallengeSuccessT = new ICommonTipChallengeSuccessT();
			this.UnPackTo(commonTipChallengeSuccessT);
			return commonTipChallengeSuccessT;
		}

		// Token: 0x0602F170 RID: 192880 RVA: 0x0066C4F3 File Offset: 0x0066A6F3
		public void UnPackTo(ICommonTipChallengeSuccessT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602F171 RID: 192881 RVA: 0x0066C510 File Offset: 0x0066A710
		public static Offset<ICommonTipChallengeSuccess> Pack(FlatBufferBuilder builder, ICommonTipChallengeSuccessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeSuccess>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipChallengeSuccess.CreateICommonTipChallengeSuccess(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x040118B0 RID: 71856
		private Table __p;
	}
}
