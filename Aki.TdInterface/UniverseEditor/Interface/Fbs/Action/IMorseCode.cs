using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007240 RID: 29248
	public struct IMorseCode : IFlatbufferObject
	{
		// Token: 0x1700D645 RID: 54853
		// (get) Token: 0x06032ECC RID: 208588 RVA: 0x006E00EC File Offset: 0x006DE2EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032ECD RID: 208589 RVA: 0x006E00F9 File Offset: 0x006DE2F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032ECE RID: 208590 RVA: 0x006E0100 File Offset: 0x006DE300
		public static IMorseCode GetRootAsIMorseCode(ByteBuffer _bb)
		{
			return IMorseCode.GetRootAsIMorseCode(_bb, default(IMorseCode));
		}

		// Token: 0x06032ECF RID: 208591 RVA: 0x006E011C File Offset: 0x006DE31C
		public static IMorseCode GetRootAsIMorseCode(ByteBuffer _bb, IMorseCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032ED0 RID: 208592 RVA: 0x006E0139 File Offset: 0x006DE339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032ED1 RID: 208593 RVA: 0x006E0148 File Offset: 0x006DE348
		public IMorseCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D646 RID: 54854
		// (get) Token: 0x06032ED2 RID: 208594 RVA: 0x006E0158 File Offset: 0x006DE358
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D647 RID: 54855
		// (get) Token: 0x06032ED3 RID: 208595 RVA: 0x006E0194 File Offset: 0x006DE394
		public string MorseCodeId
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

		// Token: 0x06032ED4 RID: 208596 RVA: 0x006E01CB File Offset: 0x006DE3CB
		public Span<byte> GetMorseCodeIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032ED5 RID: 208597 RVA: 0x006E01DA File Offset: 0x006DE3DA
		public byte[] GetMorseCodeIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06032ED6 RID: 208598 RVA: 0x006E01E8 File Offset: 0x006DE3E8
		public static Offset<IMorseCode> CreateIMorseCode(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset MorseCodeIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMorseCode.AddMorseCodeId(builder, MorseCodeIdOffset);
			IMorseCode.AddType(builder, Type);
			return IMorseCode.EndIMorseCode(builder);
		}

		// Token: 0x06032ED7 RID: 208599 RVA: 0x006E0205 File Offset: 0x006DE405
		public static void StartIMorseCode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032ED8 RID: 208600 RVA: 0x006E020E File Offset: 0x006DE40E
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032ED9 RID: 208601 RVA: 0x006E0219 File Offset: 0x006DE419
		public static void AddMorseCodeId(FlatBufferBuilder builder, StringOffset morseCodeIdOffset)
		{
			builder.AddOffset(1, morseCodeIdOffset.Value, 0);
		}

		// Token: 0x06032EDA RID: 208602 RVA: 0x006E0229 File Offset: 0x006DE429
		public static Offset<IMorseCode> EndIMorseCode(FlatBufferBuilder builder)
		{
			return new Offset<IMorseCode>(builder.EndTable());
		}

		// Token: 0x06032EDB RID: 208603 RVA: 0x006E0238 File Offset: 0x006DE438
		public IMorseCodeT UnPack()
		{
			IMorseCodeT morseCodeT = new IMorseCodeT();
			this.UnPackTo(morseCodeT);
			return morseCodeT;
		}

		// Token: 0x06032EDC RID: 208604 RVA: 0x006E0253 File Offset: 0x006DE453
		public void UnPackTo(IMorseCodeT _o)
		{
			_o.Type = this.Type;
			_o.MorseCodeId = this.MorseCodeId;
		}

		// Token: 0x06032EDD RID: 208605 RVA: 0x006E0270 File Offset: 0x006DE470
		public static Offset<IMorseCode> Pack(FlatBufferBuilder builder, IMorseCodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMorseCode>);
			}
			StringOffset morseCodeIdOffset = (_o.MorseCodeId == null) ? default(StringOffset) : builder.CreateString(_o.MorseCodeId);
			return IMorseCode.CreateIMorseCode(builder, _o.Type, morseCodeIdOffset);
		}

		// Token: 0x04012291 RID: 74385
		private Table __p;
	}
}
