using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007616 RID: 30230
	public struct IWriteLetter : IFlatbufferObject
	{
		// Token: 0x1700E593 RID: 58771
		// (get) Token: 0x060370FC RID: 225532 RVA: 0x00777FA9 File Offset: 0x007761A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370FD RID: 225533 RVA: 0x00777FB6 File Offset: 0x007761B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370FE RID: 225534 RVA: 0x00777FC0 File Offset: 0x007761C0
		public static IWriteLetter GetRootAsIWriteLetter(ByteBuffer _bb)
		{
			return IWriteLetter.GetRootAsIWriteLetter(_bb, default(IWriteLetter));
		}

		// Token: 0x060370FF RID: 225535 RVA: 0x00777FDC File Offset: 0x007761DC
		public static IWriteLetter GetRootAsIWriteLetter(ByteBuffer _bb, IWriteLetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037100 RID: 225536 RVA: 0x00777FF9 File Offset: 0x007761F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037101 RID: 225537 RVA: 0x00778008 File Offset: 0x00776208
		public IWriteLetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E594 RID: 58772
		// (get) Token: 0x06037102 RID: 225538 RVA: 0x00778018 File Offset: 0x00776218
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

		// Token: 0x1700E595 RID: 58773
		// (get) Token: 0x06037103 RID: 225539 RVA: 0x00778054 File Offset: 0x00776254
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

		// Token: 0x06037104 RID: 225540 RVA: 0x00778090 File Offset: 0x00776290
		public static Offset<IWriteLetter> CreateIWriteLetter(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			IWriteLetter.AddId(builder, Id);
			IWriteLetter.AddType(builder, Type);
			return IWriteLetter.EndIWriteLetter(builder);
		}

		// Token: 0x06037105 RID: 225541 RVA: 0x007780AD File Offset: 0x007762AD
		public static void StartIWriteLetter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037106 RID: 225542 RVA: 0x007780B6 File Offset: 0x007762B6
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037107 RID: 225543 RVA: 0x007780C1 File Offset: 0x007762C1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06037108 RID: 225544 RVA: 0x007780CC File Offset: 0x007762CC
		public static Offset<IWriteLetter> EndIWriteLetter(FlatBufferBuilder builder)
		{
			return new Offset<IWriteLetter>(builder.EndTable());
		}

		// Token: 0x06037109 RID: 225545 RVA: 0x007780DC File Offset: 0x007762DC
		public IWriteLetterT UnPack()
		{
			IWriteLetterT writeLetterT = new IWriteLetterT();
			this.UnPackTo(writeLetterT);
			return writeLetterT;
		}

		// Token: 0x0603710A RID: 225546 RVA: 0x007780F7 File Offset: 0x007762F7
		public void UnPackTo(IWriteLetterT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0603710B RID: 225547 RVA: 0x00778114 File Offset: 0x00776314
		public static Offset<IWriteLetter> Pack(FlatBufferBuilder builder, IWriteLetterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWriteLetter>);
			}
			return IWriteLetter.CreateIWriteLetter(builder, _o.Type, _o.Id);
		}

		// Token: 0x04012583 RID: 75139
		private Table __p;
	}
}
