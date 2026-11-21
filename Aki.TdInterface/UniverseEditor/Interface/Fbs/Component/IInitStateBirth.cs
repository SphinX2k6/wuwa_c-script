using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A5 RID: 22949
	public struct IInitStateBirth : IFlatbufferObject
	{
		// Token: 0x1700A6A1 RID: 42657
		// (get) Token: 0x06025699 RID: 153241 RVA: 0x00521F4D File Offset: 0x0052014D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602569A RID: 153242 RVA: 0x00521F5A File Offset: 0x0052015A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602569B RID: 153243 RVA: 0x00521F64 File Offset: 0x00520164
		public static IInitStateBirth GetRootAsIInitStateBirth(ByteBuffer _bb)
		{
			return IInitStateBirth.GetRootAsIInitStateBirth(_bb, default(IInitStateBirth));
		}

		// Token: 0x0602569C RID: 153244 RVA: 0x00521F80 File Offset: 0x00520180
		public static IInitStateBirth GetRootAsIInitStateBirth(ByteBuffer _bb, IInitStateBirth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602569D RID: 153245 RVA: 0x00521F9D File Offset: 0x0052019D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602569E RID: 153246 RVA: 0x00521FAC File Offset: 0x005201AC
		public IInitStateBirth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6A2 RID: 42658
		// (get) Token: 0x0602569F RID: 153247 RVA: 0x00521FBC File Offset: 0x005201BC
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6A3 RID: 42659
		// (get) Token: 0x060256A0 RID: 153248 RVA: 0x00521FF8 File Offset: 0x005201F8
		public string BirthTag
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

		// Token: 0x060256A1 RID: 153249 RVA: 0x0052202F File Offset: 0x0052022F
		public Span<byte> GetBirthTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060256A2 RID: 153250 RVA: 0x0052203E File Offset: 0x0052023E
		public byte[] GetBirthTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060256A3 RID: 153251 RVA: 0x0052204C File Offset: 0x0052024C
		public static Offset<IInitStateBirth> CreateIInitStateBirth(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth, StringOffset BirthTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInitStateBirth.AddBirthTag(builder, BirthTagOffset);
			IInitStateBirth.AddType(builder, Type);
			return IInitStateBirth.EndIInitStateBirth(builder);
		}

		// Token: 0x060256A4 RID: 153252 RVA: 0x00522069 File Offset: 0x00520269
		public static void StartIInitStateBirth(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060256A5 RID: 153253 RVA: 0x00522072 File Offset: 0x00520272
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060256A6 RID: 153254 RVA: 0x0052207D File Offset: 0x0052027D
		public static void AddBirthTag(FlatBufferBuilder builder, StringOffset birthTagOffset)
		{
			builder.AddOffset(1, birthTagOffset.Value, 0);
		}

		// Token: 0x060256A7 RID: 153255 RVA: 0x0052208D File Offset: 0x0052028D
		public static Offset<IInitStateBirth> EndIInitStateBirth(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateBirth>(builder.EndTable());
		}

		// Token: 0x060256A8 RID: 153256 RVA: 0x0052209C File Offset: 0x0052029C
		public IInitStateBirthT UnPack()
		{
			IInitStateBirthT initStateBirthT = new IInitStateBirthT();
			this.UnPackTo(initStateBirthT);
			return initStateBirthT;
		}

		// Token: 0x060256A9 RID: 153257 RVA: 0x005220B7 File Offset: 0x005202B7
		public void UnPackTo(IInitStateBirthT _o)
		{
			_o.Type = this.Type;
			_o.BirthTag = this.BirthTag;
		}

		// Token: 0x060256AA RID: 153258 RVA: 0x005220D4 File Offset: 0x005202D4
		public static Offset<IInitStateBirth> Pack(FlatBufferBuilder builder, IInitStateBirthT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateBirth>);
			}
			StringOffset birthTagOffset = (_o.BirthTag == null) ? default(StringOffset) : builder.CreateString(_o.BirthTag);
			return IInitStateBirth.CreateIInitStateBirth(builder, _o.Type, birthTagOffset);
		}

		// Token: 0x0400F29A RID: 62106
		private Table __p;
	}
}
