using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F41 RID: 28481
	public struct IGreatSwordChallenge : IFlatbufferObject
	{
		// Token: 0x1700D0BE RID: 53438
		// (get) Token: 0x060314A6 RID: 201894 RVA: 0x006AD5CE File Offset: 0x006AB7CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060314A7 RID: 201895 RVA: 0x006AD5DB File Offset: 0x006AB7DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060314A8 RID: 201896 RVA: 0x006AD5E4 File Offset: 0x006AB7E4
		public static IGreatSwordChallenge GetRootAsIGreatSwordChallenge(ByteBuffer _bb)
		{
			return IGreatSwordChallenge.GetRootAsIGreatSwordChallenge(_bb, default(IGreatSwordChallenge));
		}

		// Token: 0x060314A9 RID: 201897 RVA: 0x006AD600 File Offset: 0x006AB800
		public static IGreatSwordChallenge GetRootAsIGreatSwordChallenge(ByteBuffer _bb, IGreatSwordChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060314AA RID: 201898 RVA: 0x006AD61D File Offset: 0x006AB81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060314AB RID: 201899 RVA: 0x006AD62C File Offset: 0x006AB82C
		public IGreatSwordChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0BF RID: 53439
		// (get) Token: 0x060314AC RID: 201900 RVA: 0x006AD63C File Offset: 0x006AB83C
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

		// Token: 0x1700D0C0 RID: 53440
		// (get) Token: 0x060314AD RID: 201901 RVA: 0x006AD678 File Offset: 0x006AB878
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

		// Token: 0x060314AE RID: 201902 RVA: 0x006AD6AF File Offset: 0x006AB8AF
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060314AF RID: 201903 RVA: 0x006AD6BE File Offset: 0x006AB8BE
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D0C1 RID: 53441
		// (get) Token: 0x060314B0 RID: 201904 RVA: 0x006AD6CC File Offset: 0x006AB8CC
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

		// Token: 0x060314B1 RID: 201905 RVA: 0x006AD703 File Offset: 0x006AB903
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060314B2 RID: 201906 RVA: 0x006AD712 File Offset: 0x006AB912
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060314B3 RID: 201907 RVA: 0x006AD720 File Offset: 0x006AB920
		public static Offset<IGreatSwordChallenge> CreateIGreatSwordChallenge(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset), StringOffset SubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGreatSwordChallenge.AddSubText(builder, SubTextOffset);
			IGreatSwordChallenge.AddMainText(builder, MainTextOffset);
			IGreatSwordChallenge.AddType(builder, Type);
			return IGreatSwordChallenge.EndIGreatSwordChallenge(builder);
		}

		// Token: 0x060314B4 RID: 201908 RVA: 0x006AD744 File Offset: 0x006AB944
		public static void StartIGreatSwordChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060314B5 RID: 201909 RVA: 0x006AD74D File Offset: 0x006AB94D
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060314B6 RID: 201910 RVA: 0x006AD758 File Offset: 0x006AB958
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x060314B7 RID: 201911 RVA: 0x006AD768 File Offset: 0x006AB968
		public static void AddSubText(FlatBufferBuilder builder, StringOffset subTextOffset)
		{
			builder.AddOffset(2, subTextOffset.Value, 0);
		}

		// Token: 0x060314B8 RID: 201912 RVA: 0x006AD778 File Offset: 0x006AB978
		public static Offset<IGreatSwordChallenge> EndIGreatSwordChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IGreatSwordChallenge>(builder.EndTable());
		}

		// Token: 0x060314B9 RID: 201913 RVA: 0x006AD788 File Offset: 0x006AB988
		public IGreatSwordChallengeT UnPack()
		{
			IGreatSwordChallengeT greatSwordChallengeT = new IGreatSwordChallengeT();
			this.UnPackTo(greatSwordChallengeT);
			return greatSwordChallengeT;
		}

		// Token: 0x060314BA RID: 201914 RVA: 0x006AD7A3 File Offset: 0x006AB9A3
		public void UnPackTo(IGreatSwordChallengeT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.SubText = this.SubText;
		}

		// Token: 0x060314BB RID: 201915 RVA: 0x006AD7CC File Offset: 0x006AB9CC
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

		// Token: 0x04011E45 RID: 73285
		private Table __p;
	}
}
