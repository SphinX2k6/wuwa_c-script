using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CBC RID: 31932
	public struct IUnlockCookSystemCookBook : IFlatbufferObject
	{
		// Token: 0x1700EF0E RID: 61198
		// (get) Token: 0x060399AA RID: 235946 RVA: 0x007C5DF8 File Offset: 0x007C3FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060399AB RID: 235947 RVA: 0x007C5E05 File Offset: 0x007C4005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060399AC RID: 235948 RVA: 0x007C5E0C File Offset: 0x007C400C
		public static IUnlockCookSystemCookBook GetRootAsIUnlockCookSystemCookBook(ByteBuffer _bb)
		{
			return IUnlockCookSystemCookBook.GetRootAsIUnlockCookSystemCookBook(_bb, default(IUnlockCookSystemCookBook));
		}

		// Token: 0x060399AD RID: 235949 RVA: 0x007C5E28 File Offset: 0x007C4028
		public static IUnlockCookSystemCookBook GetRootAsIUnlockCookSystemCookBook(ByteBuffer _bb, IUnlockCookSystemCookBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060399AE RID: 235950 RVA: 0x007C5E45 File Offset: 0x007C4045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060399AF RID: 235951 RVA: 0x007C5E54 File Offset: 0x007C4054
		public IUnlockCookSystemCookBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF0F RID: 61199
		// (get) Token: 0x060399B0 RID: 235952 RVA: 0x007C5E64 File Offset: 0x007C4064
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

		// Token: 0x1700EF10 RID: 61200
		// (get) Token: 0x060399B1 RID: 235953 RVA: 0x007C5EA0 File Offset: 0x007C40A0
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

		// Token: 0x060399B2 RID: 235954 RVA: 0x007C5EDC File Offset: 0x007C40DC
		public static Offset<IUnlockCookSystemCookBook> CreateIUnlockCookSystemCookBook(FlatBufferBuilder builder, EUnlockCookSystemType Type = EUnlockCookSystemType.UnlockCookBook, int CookBookId = 0)
		{
			builder.StartTable(2);
			IUnlockCookSystemCookBook.AddCookBookId(builder, CookBookId);
			IUnlockCookSystemCookBook.AddType(builder, Type);
			return IUnlockCookSystemCookBook.EndIUnlockCookSystemCookBook(builder);
		}

		// Token: 0x060399B3 RID: 235955 RVA: 0x007C5EF9 File Offset: 0x007C40F9
		public static void StartIUnlockCookSystemCookBook(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060399B4 RID: 235956 RVA: 0x007C5F02 File Offset: 0x007C4102
		public static void AddType(FlatBufferBuilder builder, EUnlockCookSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060399B5 RID: 235957 RVA: 0x007C5F0D File Offset: 0x007C410D
		public static void AddCookBookId(FlatBufferBuilder builder, int cookBookId)
		{
			builder.AddInt(1, cookBookId, 0);
		}

		// Token: 0x060399B6 RID: 235958 RVA: 0x007C5F18 File Offset: 0x007C4118
		public static Offset<IUnlockCookSystemCookBook> EndIUnlockCookSystemCookBook(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockCookSystemCookBook>(builder.EndTable());
		}

		// Token: 0x060399B7 RID: 235959 RVA: 0x007C5F28 File Offset: 0x007C4128
		public IUnlockCookSystemCookBookT UnPack()
		{
			IUnlockCookSystemCookBookT unlockCookSystemCookBookT = new IUnlockCookSystemCookBookT();
			this.UnPackTo(unlockCookSystemCookBookT);
			return unlockCookSystemCookBookT;
		}

		// Token: 0x060399B8 RID: 235960 RVA: 0x007C5F43 File Offset: 0x007C4143
		public void UnPackTo(IUnlockCookSystemCookBookT _o)
		{
			_o.Type = this.Type;
			_o.CookBookId = this.CookBookId;
		}

		// Token: 0x060399B9 RID: 235961 RVA: 0x007C5F60 File Offset: 0x007C4160
		public static Offset<IUnlockCookSystemCookBook> Pack(FlatBufferBuilder builder, IUnlockCookSystemCookBookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockCookSystemCookBook>);
			}
			return IUnlockCookSystemCookBook.CreateIUnlockCookSystemCookBook(builder, _o.Type, _o.CookBookId);
		}

		// Token: 0x040133BF RID: 78783
		private Table __p;
	}
}
