using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CC RID: 29900
	public struct IUnlockCookSystemType : IFlatbufferObject
	{
		// Token: 0x1700E2EE RID: 58094
		// (get) Token: 0x060365C1 RID: 222657 RVA: 0x00763034 File Offset: 0x00761234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365C2 RID: 222658 RVA: 0x00763041 File Offset: 0x00761241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365C3 RID: 222659 RVA: 0x00763048 File Offset: 0x00761248
		public static IUnlockCookSystemType GetRootAsIUnlockCookSystemType(ByteBuffer _bb)
		{
			return IUnlockCookSystemType.GetRootAsIUnlockCookSystemType(_bb, default(IUnlockCookSystemType));
		}

		// Token: 0x060365C4 RID: 222660 RVA: 0x00763064 File Offset: 0x00761264
		public static IUnlockCookSystemType GetRootAsIUnlockCookSystemType(ByteBuffer _bb, IUnlockCookSystemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365C5 RID: 222661 RVA: 0x00763081 File Offset: 0x00761281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365C6 RID: 222662 RVA: 0x00763090 File Offset: 0x00761290
		public IUnlockCookSystemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2EF RID: 58095
		// (get) Token: 0x060365C7 RID: 222663 RVA: 0x007630A0 File Offset: 0x007612A0
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

		// Token: 0x060365C8 RID: 222664 RVA: 0x007630DC File Offset: 0x007612DC
		public static Offset<IUnlockCookSystemType> CreateIUnlockCookSystemType(FlatBufferBuilder builder, EUnlockCookSystemType Type = EUnlockCookSystemType.UnlockCookBook)
		{
			builder.StartTable(1);
			IUnlockCookSystemType.AddType(builder, Type);
			return IUnlockCookSystemType.EndIUnlockCookSystemType(builder);
		}

		// Token: 0x060365C9 RID: 222665 RVA: 0x007630F2 File Offset: 0x007612F2
		public static void StartIUnlockCookSystemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060365CA RID: 222666 RVA: 0x007630FB File Offset: 0x007612FB
		public static void AddType(FlatBufferBuilder builder, EUnlockCookSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365CB RID: 222667 RVA: 0x00763106 File Offset: 0x00761306
		public static Offset<IUnlockCookSystemType> EndIUnlockCookSystemType(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockCookSystemType>(builder.EndTable());
		}

		// Token: 0x060365CC RID: 222668 RVA: 0x00763114 File Offset: 0x00761314
		public IUnlockCookSystemTypeT UnPack()
		{
			IUnlockCookSystemTypeT unlockCookSystemTypeT = new IUnlockCookSystemTypeT();
			this.UnPackTo(unlockCookSystemTypeT);
			return unlockCookSystemTypeT;
		}

		// Token: 0x060365CD RID: 222669 RVA: 0x0076312F File Offset: 0x0076132F
		public void UnPackTo(IUnlockCookSystemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060365CE RID: 222670 RVA: 0x00763140 File Offset: 0x00761340
		public static Offset<IUnlockCookSystemType> Pack(FlatBufferBuilder builder, IUnlockCookSystemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockCookSystemType>);
			}
			return IUnlockCookSystemType.CreateIUnlockCookSystemType(builder, _o.Type);
		}

		// Token: 0x04012394 RID: 74644
		private Table __p;
	}
}
