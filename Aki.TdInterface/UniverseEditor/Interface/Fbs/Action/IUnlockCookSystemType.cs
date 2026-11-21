using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC2 RID: 31938
	public struct IUnlockCookSystemType : IFlatbufferObject
	{
		// Token: 0x1700EF18 RID: 61208
		// (get) Token: 0x060399D6 RID: 235990 RVA: 0x007C6284 File Offset: 0x007C4484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060399D7 RID: 235991 RVA: 0x007C6291 File Offset: 0x007C4491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060399D8 RID: 235992 RVA: 0x007C6298 File Offset: 0x007C4498
		public static IUnlockCookSystemType GetRootAsIUnlockCookSystemType(ByteBuffer _bb)
		{
			return IUnlockCookSystemType.GetRootAsIUnlockCookSystemType(_bb, default(IUnlockCookSystemType));
		}

		// Token: 0x060399D9 RID: 235993 RVA: 0x007C62B4 File Offset: 0x007C44B4
		public static IUnlockCookSystemType GetRootAsIUnlockCookSystemType(ByteBuffer _bb, IUnlockCookSystemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060399DA RID: 235994 RVA: 0x007C62D1 File Offset: 0x007C44D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060399DB RID: 235995 RVA: 0x007C62E0 File Offset: 0x007C44E0
		public IUnlockCookSystemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF19 RID: 61209
		// (get) Token: 0x060399DC RID: 235996 RVA: 0x007C62F0 File Offset: 0x007C44F0
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

		// Token: 0x060399DD RID: 235997 RVA: 0x007C632C File Offset: 0x007C452C
		public static Offset<IUnlockCookSystemType> CreateIUnlockCookSystemType(FlatBufferBuilder builder, EUnlockCookSystemType Type = EUnlockCookSystemType.UnlockCookBook)
		{
			builder.StartTable(1);
			IUnlockCookSystemType.AddType(builder, Type);
			return IUnlockCookSystemType.EndIUnlockCookSystemType(builder);
		}

		// Token: 0x060399DE RID: 235998 RVA: 0x007C6342 File Offset: 0x007C4542
		public static void StartIUnlockCookSystemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060399DF RID: 235999 RVA: 0x007C634B File Offset: 0x007C454B
		public static void AddType(FlatBufferBuilder builder, EUnlockCookSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060399E0 RID: 236000 RVA: 0x007C6356 File Offset: 0x007C4556
		public static Offset<IUnlockCookSystemType> EndIUnlockCookSystemType(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockCookSystemType>(builder.EndTable());
		}

		// Token: 0x060399E1 RID: 236001 RVA: 0x007C6364 File Offset: 0x007C4564
		public IUnlockCookSystemTypeT UnPack()
		{
			IUnlockCookSystemTypeT unlockCookSystemTypeT = new IUnlockCookSystemTypeT();
			this.UnPackTo(unlockCookSystemTypeT);
			return unlockCookSystemTypeT;
		}

		// Token: 0x060399E2 RID: 236002 RVA: 0x007C637F File Offset: 0x007C457F
		public void UnPackTo(IUnlockCookSystemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060399E3 RID: 236003 RVA: 0x007C6390 File Offset: 0x007C4590
		public static Offset<IUnlockCookSystemType> Pack(FlatBufferBuilder builder, IUnlockCookSystemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockCookSystemType>);
			}
			return IUnlockCookSystemType.CreateIUnlockCookSystemType(builder, _o.Type);
		}

		// Token: 0x040133C5 RID: 78789
		private Table __p;
	}
}
