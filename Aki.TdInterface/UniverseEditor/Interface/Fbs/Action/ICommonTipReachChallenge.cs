using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064AA RID: 25770
	public struct ICommonTipReachChallenge : IFlatbufferObject
	{
		// Token: 0x1700BFC3 RID: 49091
		// (get) Token: 0x0602CAA8 RID: 182952 RVA: 0x006219A5 File Offset: 0x0061FBA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CAA9 RID: 182953 RVA: 0x006219B2 File Offset: 0x0061FBB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAAA RID: 182954 RVA: 0x006219BC File Offset: 0x0061FBBC
		public static ICommonTipReachChallenge GetRootAsICommonTipReachChallenge(ByteBuffer _bb)
		{
			return ICommonTipReachChallenge.GetRootAsICommonTipReachChallenge(_bb, default(ICommonTipReachChallenge));
		}

		// Token: 0x0602CAAB RID: 182955 RVA: 0x006219D8 File Offset: 0x0061FBD8
		public static ICommonTipReachChallenge GetRootAsICommonTipReachChallenge(ByteBuffer _bb, ICommonTipReachChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAAC RID: 182956 RVA: 0x006219F5 File Offset: 0x0061FBF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CAAD RID: 182957 RVA: 0x00621A04 File Offset: 0x0061FC04
		public ICommonTipReachChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFC4 RID: 49092
		// (get) Token: 0x0602CAAE RID: 182958 RVA: 0x00621A14 File Offset: 0x0061FC14
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

		// Token: 0x1700BFC5 RID: 49093
		// (get) Token: 0x0602CAAF RID: 182959 RVA: 0x00621A50 File Offset: 0x0061FC50
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

		// Token: 0x0602CAB0 RID: 182960 RVA: 0x00621A87 File Offset: 0x0061FC87
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CAB1 RID: 182961 RVA: 0x00621A96 File Offset: 0x0061FC96
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CAB2 RID: 182962 RVA: 0x00621AA4 File Offset: 0x0061FCA4
		public static Offset<ICommonTipReachChallenge> CreateICommonTipReachChallenge(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipReachChallenge.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipReachChallenge.AddType(builder, Type);
			return ICommonTipReachChallenge.EndICommonTipReachChallenge(builder);
		}

		// Token: 0x0602CAB3 RID: 182963 RVA: 0x00621AC1 File Offset: 0x0061FCC1
		public static void StartICommonTipReachChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CAB4 RID: 182964 RVA: 0x00621ACA File Offset: 0x0061FCCA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CAB5 RID: 182965 RVA: 0x00621AD5 File Offset: 0x0061FCD5
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602CAB6 RID: 182966 RVA: 0x00621AE5 File Offset: 0x0061FCE5
		public static Offset<ICommonTipReachChallenge> EndICommonTipReachChallenge(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipReachChallenge>(builder.EndTable());
		}

		// Token: 0x0602CAB7 RID: 182967 RVA: 0x00621AF4 File Offset: 0x0061FCF4
		public ICommonTipReachChallengeT UnPack()
		{
			ICommonTipReachChallengeT commonTipReachChallengeT = new ICommonTipReachChallengeT();
			this.UnPackTo(commonTipReachChallengeT);
			return commonTipReachChallengeT;
		}

		// Token: 0x0602CAB8 RID: 182968 RVA: 0x00621B0F File Offset: 0x0061FD0F
		public void UnPackTo(ICommonTipReachChallengeT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602CAB9 RID: 182969 RVA: 0x00621B2C File Offset: 0x0061FD2C
		public static Offset<ICommonTipReachChallenge> Pack(FlatBufferBuilder builder, ICommonTipReachChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipReachChallenge>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipReachChallenge.CreateICommonTipReachChallenge(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04010AB8 RID: 68280
		private Table __p;
	}
}
