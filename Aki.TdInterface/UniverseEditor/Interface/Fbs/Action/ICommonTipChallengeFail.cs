using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFA RID: 27386
	public struct ICommonTipChallengeFail : IFlatbufferObject
	{
		// Token: 0x1700C921 RID: 51489
		// (get) Token: 0x0602F148 RID: 192840 RVA: 0x0066C155 File Offset: 0x0066A355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F149 RID: 192841 RVA: 0x0066C162 File Offset: 0x0066A362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F14A RID: 192842 RVA: 0x0066C16C File Offset: 0x0066A36C
		public static ICommonTipChallengeFail GetRootAsICommonTipChallengeFail(ByteBuffer _bb)
		{
			return ICommonTipChallengeFail.GetRootAsICommonTipChallengeFail(_bb, default(ICommonTipChallengeFail));
		}

		// Token: 0x0602F14B RID: 192843 RVA: 0x0066C188 File Offset: 0x0066A388
		public static ICommonTipChallengeFail GetRootAsICommonTipChallengeFail(ByteBuffer _bb, ICommonTipChallengeFail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F14C RID: 192844 RVA: 0x0066C1A5 File Offset: 0x0066A3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F14D RID: 192845 RVA: 0x0066C1B4 File Offset: 0x0066A3B4
		public ICommonTipChallengeFail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C922 RID: 51490
		// (get) Token: 0x0602F14E RID: 192846 RVA: 0x0066C1C4 File Offset: 0x0066A3C4
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

		// Token: 0x1700C923 RID: 51491
		// (get) Token: 0x0602F14F RID: 192847 RVA: 0x0066C200 File Offset: 0x0066A400
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

		// Token: 0x0602F150 RID: 192848 RVA: 0x0066C237 File Offset: 0x0066A437
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F151 RID: 192849 RVA: 0x0066C246 File Offset: 0x0066A446
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F152 RID: 192850 RVA: 0x0066C254 File Offset: 0x0066A454
		public static Offset<ICommonTipChallengeFail> CreateICommonTipChallengeFail(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipChallengeFail.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeFail.AddType(builder, Type);
			return ICommonTipChallengeFail.EndICommonTipChallengeFail(builder);
		}

		// Token: 0x0602F153 RID: 192851 RVA: 0x0066C271 File Offset: 0x0066A471
		public static void StartICommonTipChallengeFail(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F154 RID: 192852 RVA: 0x0066C27A File Offset: 0x0066A47A
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F155 RID: 192853 RVA: 0x0066C285 File Offset: 0x0066A485
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F156 RID: 192854 RVA: 0x0066C295 File Offset: 0x0066A495
		public static Offset<ICommonTipChallengeFail> EndICommonTipChallengeFail(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeFail>(builder.EndTable());
		}

		// Token: 0x0602F157 RID: 192855 RVA: 0x0066C2A4 File Offset: 0x0066A4A4
		public ICommonTipChallengeFailT UnPack()
		{
			ICommonTipChallengeFailT commonTipChallengeFailT = new ICommonTipChallengeFailT();
			this.UnPackTo(commonTipChallengeFailT);
			return commonTipChallengeFailT;
		}

		// Token: 0x0602F158 RID: 192856 RVA: 0x0066C2BF File Offset: 0x0066A4BF
		public void UnPackTo(ICommonTipChallengeFailT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602F159 RID: 192857 RVA: 0x0066C2DC File Offset: 0x0066A4DC
		public static Offset<ICommonTipChallengeFail> Pack(FlatBufferBuilder builder, ICommonTipChallengeFailT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeFail>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipChallengeFail.CreateICommonTipChallengeFail(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x040118AD RID: 71853
		private Table __p;
	}
}
