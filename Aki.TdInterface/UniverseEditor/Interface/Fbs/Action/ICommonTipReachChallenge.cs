using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B15 RID: 27413
	public struct ICommonTipReachChallenge : IFlatbufferObject
	{
		// Token: 0x1700C950 RID: 51536
		// (get) Token: 0x0602F222 RID: 193058 RVA: 0x0066D579 File Offset: 0x0066B779
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F223 RID: 193059 RVA: 0x0066D586 File Offset: 0x0066B786
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F224 RID: 193060 RVA: 0x0066D590 File Offset: 0x0066B790
		public static ICommonTipReachChallenge GetRootAsICommonTipReachChallenge(ByteBuffer _bb)
		{
			return ICommonTipReachChallenge.GetRootAsICommonTipReachChallenge(_bb, default(ICommonTipReachChallenge));
		}

		// Token: 0x0602F225 RID: 193061 RVA: 0x0066D5AC File Offset: 0x0066B7AC
		public static ICommonTipReachChallenge GetRootAsICommonTipReachChallenge(ByteBuffer _bb, ICommonTipReachChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F226 RID: 193062 RVA: 0x0066D5C9 File Offset: 0x0066B7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F227 RID: 193063 RVA: 0x0066D5D8 File Offset: 0x0066B7D8
		public ICommonTipReachChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C951 RID: 51537
		// (get) Token: 0x0602F228 RID: 193064 RVA: 0x0066D5E8 File Offset: 0x0066B7E8
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

		// Token: 0x1700C952 RID: 51538
		// (get) Token: 0x0602F229 RID: 193065 RVA: 0x0066D624 File Offset: 0x0066B824
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

		// Token: 0x0602F22A RID: 193066 RVA: 0x0066D65B File Offset: 0x0066B85B
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F22B RID: 193067 RVA: 0x0066D66A File Offset: 0x0066B86A
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F22C RID: 193068 RVA: 0x0066D678 File Offset: 0x0066B878
		public static Offset<ICommonTipReachChallenge> CreateICommonTipReachChallenge(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipReachChallenge.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipReachChallenge.AddType(builder, Type);
			return ICommonTipReachChallenge.EndICommonTipReachChallenge(builder);
		}

		// Token: 0x0602F22D RID: 193069 RVA: 0x0066D695 File Offset: 0x0066B895
		public static void StartICommonTipReachChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F22E RID: 193070 RVA: 0x0066D69E File Offset: 0x0066B89E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F22F RID: 193071 RVA: 0x0066D6A9 File Offset: 0x0066B8A9
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F230 RID: 193072 RVA: 0x0066D6B9 File Offset: 0x0066B8B9
		public static Offset<ICommonTipReachChallenge> EndICommonTipReachChallenge(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipReachChallenge>(builder.EndTable());
		}

		// Token: 0x0602F231 RID: 193073 RVA: 0x0066D6C8 File Offset: 0x0066B8C8
		public ICommonTipReachChallengeT UnPack()
		{
			ICommonTipReachChallengeT commonTipReachChallengeT = new ICommonTipReachChallengeT();
			this.UnPackTo(commonTipReachChallengeT);
			return commonTipReachChallengeT;
		}

		// Token: 0x0602F232 RID: 193074 RVA: 0x0066D6E3 File Offset: 0x0066B8E3
		public void UnPackTo(ICommonTipReachChallengeT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602F233 RID: 193075 RVA: 0x0066D700 File Offset: 0x0066B900
		public static Offset<ICommonTipReachChallenge> Pack(FlatBufferBuilder builder, ICommonTipReachChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipReachChallenge>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipReachChallenge.CreateICommonTipReachChallenge(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x040118C9 RID: 71881
		private Table __p;
	}
}
