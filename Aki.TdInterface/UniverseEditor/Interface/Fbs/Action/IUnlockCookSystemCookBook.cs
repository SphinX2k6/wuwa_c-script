using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C6 RID: 29894
	public struct IUnlockCookSystemCookBook : IFlatbufferObject
	{
		// Token: 0x1700E2E4 RID: 58084
		// (get) Token: 0x06036595 RID: 222613 RVA: 0x00762BA8 File Offset: 0x00760DA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036596 RID: 222614 RVA: 0x00762BB5 File Offset: 0x00760DB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036597 RID: 222615 RVA: 0x00762BBC File Offset: 0x00760DBC
		public static IUnlockCookSystemCookBook GetRootAsIUnlockCookSystemCookBook(ByteBuffer _bb)
		{
			return IUnlockCookSystemCookBook.GetRootAsIUnlockCookSystemCookBook(_bb, default(IUnlockCookSystemCookBook));
		}

		// Token: 0x06036598 RID: 222616 RVA: 0x00762BD8 File Offset: 0x00760DD8
		public static IUnlockCookSystemCookBook GetRootAsIUnlockCookSystemCookBook(ByteBuffer _bb, IUnlockCookSystemCookBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036599 RID: 222617 RVA: 0x00762BF5 File Offset: 0x00760DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603659A RID: 222618 RVA: 0x00762C04 File Offset: 0x00760E04
		public IUnlockCookSystemCookBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2E5 RID: 58085
		// (get) Token: 0x0603659B RID: 222619 RVA: 0x00762C14 File Offset: 0x00760E14
		public EUnlockCookSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockCookSystemType.UnlockCookBook;
				}
				return (EUnlockCookSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E2E6 RID: 58086
		// (get) Token: 0x0603659C RID: 222620 RVA: 0x00762C50 File Offset: 0x00760E50
		public int CookBookId
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

		// Token: 0x0603659D RID: 222621 RVA: 0x00762C8C File Offset: 0x00760E8C
		public static Offset<IUnlockCookSystemCookBook> CreateIUnlockCookSystemCookBook(FlatBufferBuilder builder, EUnlockCookSystemType Type = EUnlockCookSystemType.UnlockCookBook, int CookBookId = 0)
		{
			builder.StartTable(2);
			IUnlockCookSystemCookBook.AddCookBookId(builder, CookBookId);
			IUnlockCookSystemCookBook.AddType(builder, Type);
			return IUnlockCookSystemCookBook.EndIUnlockCookSystemCookBook(builder);
		}

		// Token: 0x0603659E RID: 222622 RVA: 0x00762CA9 File Offset: 0x00760EA9
		public static void StartIUnlockCookSystemCookBook(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603659F RID: 222623 RVA: 0x00762CB2 File Offset: 0x00760EB2
		public static void AddType(FlatBufferBuilder builder, EUnlockCookSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365A0 RID: 222624 RVA: 0x00762CBD File Offset: 0x00760EBD
		public static void AddCookBookId(FlatBufferBuilder builder, int cookBookId)
		{
			builder.AddInt(1, cookBookId, 0);
		}

		// Token: 0x060365A1 RID: 222625 RVA: 0x00762CC8 File Offset: 0x00760EC8
		public static Offset<IUnlockCookSystemCookBook> EndIUnlockCookSystemCookBook(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockCookSystemCookBook>(builder.EndTable());
		}

		// Token: 0x060365A2 RID: 222626 RVA: 0x00762CD8 File Offset: 0x00760ED8
		public IUnlockCookSystemCookBookT UnPack()
		{
			IUnlockCookSystemCookBookT unlockCookSystemCookBookT = new IUnlockCookSystemCookBookT();
			this.UnPackTo(unlockCookSystemCookBookT);
			return unlockCookSystemCookBookT;
		}

		// Token: 0x060365A3 RID: 222627 RVA: 0x00762CF3 File Offset: 0x00760EF3
		public void UnPackTo(IUnlockCookSystemCookBookT _o)
		{
			_o.Type = this.Type;
			_o.CookBookId = this.CookBookId;
		}

		// Token: 0x060365A4 RID: 222628 RVA: 0x00762D10 File Offset: 0x00760F10
		public static Offset<IUnlockCookSystemCookBook> Pack(FlatBufferBuilder builder, IUnlockCookSystemCookBookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockCookSystemCookBook>);
			}
			return IUnlockCookSystemCookBook.CreateIUnlockCookSystemCookBook(builder, _o.Type, _o.CookBookId);
		}

		// Token: 0x0401238E RID: 74638
		private Table __p;
	}
}
