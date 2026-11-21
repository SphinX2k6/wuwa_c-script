using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E24 RID: 32292
	public struct IWriteLetter : IFlatbufferObject
	{
		// Token: 0x1700F1D1 RID: 61905
		// (get) Token: 0x0603A5A1 RID: 239009 RVA: 0x007DC0A5 File Offset: 0x007DA2A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A5A2 RID: 239010 RVA: 0x007DC0B2 File Offset: 0x007DA2B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A5A3 RID: 239011 RVA: 0x007DC0BC File Offset: 0x007DA2BC
		public static IWriteLetter GetRootAsIWriteLetter(ByteBuffer _bb)
		{
			return IWriteLetter.GetRootAsIWriteLetter(_bb, default(IWriteLetter));
		}

		// Token: 0x0603A5A4 RID: 239012 RVA: 0x007DC0D8 File Offset: 0x007DA2D8
		public static IWriteLetter GetRootAsIWriteLetter(ByteBuffer _bb, IWriteLetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A5A5 RID: 239013 RVA: 0x007DC0F5 File Offset: 0x007DA2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A5A6 RID: 239014 RVA: 0x007DC104 File Offset: 0x007DA304
		public IWriteLetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1D2 RID: 61906
		// (get) Token: 0x0603A5A7 RID: 239015 RVA: 0x007DC114 File Offset: 0x007DA314
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

		// Token: 0x1700F1D3 RID: 61907
		// (get) Token: 0x0603A5A8 RID: 239016 RVA: 0x007DC150 File Offset: 0x007DA350
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A5A9 RID: 239017 RVA: 0x007DC18C File Offset: 0x007DA38C
		public static Offset<IWriteLetter> CreateIWriteLetter(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			IWriteLetter.AddId(builder, Id);
			IWriteLetter.AddType(builder, Type);
			return IWriteLetter.EndIWriteLetter(builder);
		}

		// Token: 0x0603A5AA RID: 239018 RVA: 0x007DC1A9 File Offset: 0x007DA3A9
		public static void StartIWriteLetter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A5AB RID: 239019 RVA: 0x007DC1B2 File Offset: 0x007DA3B2
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A5AC RID: 239020 RVA: 0x007DC1BD File Offset: 0x007DA3BD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603A5AD RID: 239021 RVA: 0x007DC1C8 File Offset: 0x007DA3C8
		public static Offset<IWriteLetter> EndIWriteLetter(FlatBufferBuilder builder)
		{
			return new Offset<IWriteLetter>(builder.EndTable());
		}

		// Token: 0x0603A5AE RID: 239022 RVA: 0x007DC1D8 File Offset: 0x007DA3D8
		public IWriteLetterT UnPack()
		{
			IWriteLetterT writeLetterT = new IWriteLetterT();
			this.UnPackTo(writeLetterT);
			return writeLetterT;
		}

		// Token: 0x0603A5AF RID: 239023 RVA: 0x007DC1F3 File Offset: 0x007DA3F3
		public void UnPackTo(IWriteLetterT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0603A5B0 RID: 239024 RVA: 0x007DC210 File Offset: 0x007DA410
		public static Offset<IWriteLetter> Pack(FlatBufferBuilder builder, IWriteLetterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWriteLetter>);
			}
			return IWriteLetter.CreateIWriteLetter(builder, _o.Type, _o.Id);
		}

		// Token: 0x040135CD RID: 79309
		private Table __p;
	}
}
