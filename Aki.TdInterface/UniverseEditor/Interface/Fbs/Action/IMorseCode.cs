using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B09 RID: 27401
	public struct IMorseCode : IFlatbufferObject
	{
		// Token: 0x1700CB76 RID: 52086
		// (get) Token: 0x060300F8 RID: 196856 RVA: 0x00688A34 File Offset: 0x00686C34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300F9 RID: 196857 RVA: 0x00688A41 File Offset: 0x00686C41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300FA RID: 196858 RVA: 0x00688A48 File Offset: 0x00686C48
		public static IMorseCode GetRootAsIMorseCode(ByteBuffer _bb)
		{
			return IMorseCode.GetRootAsIMorseCode(_bb, default(IMorseCode));
		}

		// Token: 0x060300FB RID: 196859 RVA: 0x00688A64 File Offset: 0x00686C64
		public static IMorseCode GetRootAsIMorseCode(ByteBuffer _bb, IMorseCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300FC RID: 196860 RVA: 0x00688A81 File Offset: 0x00686C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300FD RID: 196861 RVA: 0x00688A90 File Offset: 0x00686C90
		public IMorseCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB77 RID: 52087
		// (get) Token: 0x060300FE RID: 196862 RVA: 0x00688AA0 File Offset: 0x00686CA0
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

		// Token: 0x1700CB78 RID: 52088
		// (get) Token: 0x060300FF RID: 196863 RVA: 0x00688ADC File Offset: 0x00686CDC
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

		// Token: 0x06030100 RID: 196864 RVA: 0x00688B13 File Offset: 0x00686D13
		public Span<byte> GetMorseCodeIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030101 RID: 196865 RVA: 0x00688B22 File Offset: 0x00686D22
		public byte[] GetMorseCodeIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030102 RID: 196866 RVA: 0x00688B30 File Offset: 0x00686D30
		public static Offset<IMorseCode> CreateIMorseCode(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset MorseCodeIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMorseCode.AddMorseCodeId(builder, MorseCodeIdOffset);
			IMorseCode.AddType(builder, Type);
			return IMorseCode.EndIMorseCode(builder);
		}

		// Token: 0x06030103 RID: 196867 RVA: 0x00688B4D File Offset: 0x00686D4D
		public static void StartIMorseCode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030104 RID: 196868 RVA: 0x00688B56 File Offset: 0x00686D56
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030105 RID: 196869 RVA: 0x00688B61 File Offset: 0x00686D61
		public static void AddMorseCodeId(FlatBufferBuilder builder, StringOffset morseCodeIdOffset)
		{
			builder.AddOffset(1, morseCodeIdOffset.Value, 0);
		}

		// Token: 0x06030106 RID: 196870 RVA: 0x00688B71 File Offset: 0x00686D71
		public static Offset<IMorseCode> EndIMorseCode(FlatBufferBuilder builder)
		{
			return new Offset<IMorseCode>(builder.EndTable());
		}

		// Token: 0x06030107 RID: 196871 RVA: 0x00688B80 File Offset: 0x00686D80
		public IMorseCodeT UnPack()
		{
			IMorseCodeT morseCodeT = new IMorseCodeT();
			this.UnPackTo(morseCodeT);
			return morseCodeT;
		}

		// Token: 0x06030108 RID: 196872 RVA: 0x00688B9B File Offset: 0x00686D9B
		public void UnPackTo(IMorseCodeT _o)
		{
			_o.Type = this.Type;
			_o.MorseCodeId = this.MorseCodeId;
		}

		// Token: 0x06030109 RID: 196873 RVA: 0x00688BB8 File Offset: 0x00686DB8
		public static Offset<IMorseCode> Pack(FlatBufferBuilder builder, IMorseCodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMorseCode>);
			}
			StringOffset morseCodeIdOffset = (_o.MorseCodeId == null) ? default(StringOffset) : builder.CreateString(_o.MorseCodeId);
			return IMorseCode.CreateIMorseCode(builder, _o.Type, morseCodeIdOffset);
		}

		// Token: 0x0401137E RID: 70526
		private Table __p;
	}
}
