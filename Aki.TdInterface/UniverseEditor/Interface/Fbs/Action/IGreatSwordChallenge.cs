using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A0 RID: 26784
	public struct IGreatSwordChallenge : IFlatbufferObject
	{
		// Token: 0x1700C6D8 RID: 50904
		// (get) Token: 0x0602EB6C RID: 191340 RVA: 0x0065E54E File Offset: 0x0065C74E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB6D RID: 191341 RVA: 0x0065E55B File Offset: 0x0065C75B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB6E RID: 191342 RVA: 0x0065E564 File Offset: 0x0065C764
		public static IGreatSwordChallenge GetRootAsIGreatSwordChallenge(ByteBuffer _bb)
		{
			return IGreatSwordChallenge.GetRootAsIGreatSwordChallenge(_bb, default(IGreatSwordChallenge));
		}

		// Token: 0x0602EB6F RID: 191343 RVA: 0x0065E580 File Offset: 0x0065C780
		public static IGreatSwordChallenge GetRootAsIGreatSwordChallenge(ByteBuffer _bb, IGreatSwordChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB70 RID: 191344 RVA: 0x0065E59D File Offset: 0x0065C79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB71 RID: 191345 RVA: 0x0065E5AC File Offset: 0x0065C7AC
		public IGreatSwordChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6D9 RID: 50905
		// (get) Token: 0x0602EB72 RID: 191346 RVA: 0x0065E5BC File Offset: 0x0065C7BC
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

		// Token: 0x1700C6DA RID: 50906
		// (get) Token: 0x0602EB73 RID: 191347 RVA: 0x0065E5F8 File Offset: 0x0065C7F8
		public string MainText
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

		// Token: 0x0602EB74 RID: 191348 RVA: 0x0065E62F File Offset: 0x0065C82F
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602EB75 RID: 191349 RVA: 0x0065E63E File Offset: 0x0065C83E
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C6DB RID: 50907
		// (get) Token: 0x0602EB76 RID: 191350 RVA: 0x0065E64C File Offset: 0x0065C84C
		public string SubText
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

		// Token: 0x0602EB77 RID: 191351 RVA: 0x0065E683 File Offset: 0x0065C883
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602EB78 RID: 191352 RVA: 0x0065E692 File Offset: 0x0065C892
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602EB79 RID: 191353 RVA: 0x0065E6A0 File Offset: 0x0065C8A0
		public static Offset<IGreatSwordChallenge> CreateIGreatSwordChallenge(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset), StringOffset SubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGreatSwordChallenge.AddSubText(builder, SubTextOffset);
			IGreatSwordChallenge.AddMainText(builder, MainTextOffset);
			IGreatSwordChallenge.AddType(builder, Type);
			return IGreatSwordChallenge.EndIGreatSwordChallenge(builder);
		}

		// Token: 0x0602EB7A RID: 191354 RVA: 0x0065E6C4 File Offset: 0x0065C8C4
		public static void StartIGreatSwordChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EB7B RID: 191355 RVA: 0x0065E6CD File Offset: 0x0065C8CD
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB7C RID: 191356 RVA: 0x0065E6D8 File Offset: 0x0065C8D8
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x0602EB7D RID: 191357 RVA: 0x0065E6E8 File Offset: 0x0065C8E8
		public static void AddSubText(FlatBufferBuilder builder, StringOffset subTextOffset)
		{
			builder.AddOffset(2, subTextOffset.Value, 0);
		}

		// Token: 0x0602EB7E RID: 191358 RVA: 0x0065E6F8 File Offset: 0x0065C8F8
		public static Offset<IGreatSwordChallenge> EndIGreatSwordChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IGreatSwordChallenge>(builder.EndTable());
		}

		// Token: 0x0602EB7F RID: 191359 RVA: 0x0065E708 File Offset: 0x0065C908
		public IGreatSwordChallengeT UnPack()
		{
			IGreatSwordChallengeT greatSwordChallengeT = new IGreatSwordChallengeT();
			this.UnPackTo(greatSwordChallengeT);
			return greatSwordChallengeT;
		}

		// Token: 0x0602EB80 RID: 191360 RVA: 0x0065E723 File Offset: 0x0065C923
		public void UnPackTo(IGreatSwordChallengeT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.SubText = this.SubText;
		}

		// Token: 0x0602EB81 RID: 191361 RVA: 0x0065E74C File Offset: 0x0065C94C
		public static Offset<IGreatSwordChallenge> Pack(FlatBufferBuilder builder, IGreatSwordChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGreatSwordChallenge>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			StringOffset subTextOffset = (_o.SubText == null) ? default(StringOffset) : builder.CreateString(_o.SubText);
			return IGreatSwordChallenge.CreateIGreatSwordChallenge(builder, _o.Type, mainTextOffset, subTextOffset);
		}

		// Token: 0x04010FF0 RID: 69616
		private Table __p;
	}
}
