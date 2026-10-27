using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541F RID: 21535
	public struct IInitStateBirth : IFlatbufferObject
	{
		// Token: 0x17009E67 RID: 40551
		// (get) Token: 0x060235E1 RID: 144865 RVA: 0x004E4F21 File Offset: 0x004E3121
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235E2 RID: 144866 RVA: 0x004E4F2E File Offset: 0x004E312E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235E3 RID: 144867 RVA: 0x004E4F38 File Offset: 0x004E3138
		public static IInitStateBirth GetRootAsIInitStateBirth(ByteBuffer _bb)
		{
			return IInitStateBirth.GetRootAsIInitStateBirth(_bb, default(IInitStateBirth));
		}

		// Token: 0x060235E4 RID: 144868 RVA: 0x004E4F54 File Offset: 0x004E3154
		public static IInitStateBirth GetRootAsIInitStateBirth(ByteBuffer _bb, IInitStateBirth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235E5 RID: 144869 RVA: 0x004E4F71 File Offset: 0x004E3171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235E6 RID: 144870 RVA: 0x004E4F80 File Offset: 0x004E3180
		public IInitStateBirth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E68 RID: 40552
		// (get) Token: 0x060235E7 RID: 144871 RVA: 0x004E4F90 File Offset: 0x004E3190
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

		// Token: 0x17009E69 RID: 40553
		// (get) Token: 0x060235E8 RID: 144872 RVA: 0x004E4FCC File Offset: 0x004E31CC
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

		// Token: 0x060235E9 RID: 144873 RVA: 0x004E5003 File Offset: 0x004E3203
		public Span<byte> GetBirthTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060235EA RID: 144874 RVA: 0x004E5012 File Offset: 0x004E3212
		public byte[] GetBirthTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060235EB RID: 144875 RVA: 0x004E5020 File Offset: 0x004E3220
		public static Offset<IInitStateBirth> CreateIInitStateBirth(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth, StringOffset BirthTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInitStateBirth.AddBirthTag(builder, BirthTagOffset);
			IInitStateBirth.AddType(builder, Type);
			return IInitStateBirth.EndIInitStateBirth(builder);
		}

		// Token: 0x060235EC RID: 144876 RVA: 0x004E503D File Offset: 0x004E323D
		public static void StartIInitStateBirth(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060235ED RID: 144877 RVA: 0x004E5046 File Offset: 0x004E3246
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060235EE RID: 144878 RVA: 0x004E5051 File Offset: 0x004E3251
		public static void AddBirthTag(FlatBufferBuilder builder, StringOffset birthTagOffset)
		{
			builder.AddOffset(1, birthTagOffset.Value, 0);
		}

		// Token: 0x060235EF RID: 144879 RVA: 0x004E5061 File Offset: 0x004E3261
		public static Offset<IInitStateBirth> EndIInitStateBirth(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateBirth>(builder.EndTable());
		}

		// Token: 0x060235F0 RID: 144880 RVA: 0x004E5070 File Offset: 0x004E3270
		public IInitStateBirthT UnPack()
		{
			IInitStateBirthT initStateBirthT = new IInitStateBirthT();
			this.UnPackTo(initStateBirthT);
			return initStateBirthT;
		}

		// Token: 0x060235F1 RID: 144881 RVA: 0x004E508B File Offset: 0x004E328B
		public void UnPackTo(IInitStateBirthT _o)
		{
			_o.Type = this.Type;
			_o.BirthTag = this.BirthTag;
		}

		// Token: 0x060235F2 RID: 144882 RVA: 0x004E50A8 File Offset: 0x004E32A8
		public static Offset<IInitStateBirth> Pack(FlatBufferBuilder builder, IInitStateBirthT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateBirth>);
			}
			StringOffset birthTagOffset = (_o.BirthTag == null) ? default(StringOffset) : builder.CreateString(_o.BirthTag);
			return IInitStateBirth.CreateIInitStateBirth(builder, _o.Type, birthTagOffset);
		}

		// Token: 0x0400E669 RID: 58985
		private Table __p;
	}
}
