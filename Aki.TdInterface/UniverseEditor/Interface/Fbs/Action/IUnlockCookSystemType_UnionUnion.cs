using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D0 RID: 29904
	public class IUnlockCookSystemType_UnionUnion
	{
		// Token: 0x1700E2F1 RID: 58097
		// (get) Token: 0x060365D3 RID: 222675 RVA: 0x007631A9 File Offset: 0x007613A9
		// (set) Token: 0x060365D4 RID: 222676 RVA: 0x007631B1 File Offset: 0x007613B1
		public IUnlockCookSystemType_Union Type { get; set; }

		// Token: 0x1700E2F2 RID: 58098
		// (get) Token: 0x060365D5 RID: 222677 RVA: 0x007631BA File Offset: 0x007613BA
		// (set) Token: 0x060365D6 RID: 222678 RVA: 0x007631C2 File Offset: 0x007613C2
		public object Value { get; set; }

		// Token: 0x060365D7 RID: 222679 RVA: 0x007631CB File Offset: 0x007613CB
		public IUnlockCookSystemType_UnionUnion()
		{
			this.Type = IUnlockCookSystemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060365D8 RID: 222680 RVA: 0x007631E1 File Offset: 0x007613E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060365D9 RID: 222681 RVA: 0x007631F3 File Offset: 0x007613F3
		public IUnlockCookSystemTypeT AsIUnlockCookSystemType()
		{
			return this.As<IUnlockCookSystemTypeT>();
		}

		// Token: 0x060365DA RID: 222682 RVA: 0x007631FB File Offset: 0x007613FB
		public static IUnlockCookSystemType_UnionUnion FromIUnlockCookSystemType(IUnlockCookSystemTypeT _iunlockcooksystemtype)
		{
			return new IUnlockCookSystemType_UnionUnion
			{
				Type = IUnlockCookSystemType_Union.IUnlockCookSystemType,
				Value = _iunlockcooksystemtype
			};
		}

		// Token: 0x060365DB RID: 222683 RVA: 0x00763210 File Offset: 0x00761410
		public IUnlockCookSystemCookBookT AsIUnlockCookSystemCookBook()
		{
			return this.As<IUnlockCookSystemCookBookT>();
		}

		// Token: 0x060365DC RID: 222684 RVA: 0x00763218 File Offset: 0x00761418
		public static IUnlockCookSystemType_UnionUnion FromIUnlockCookSystemCookBook(IUnlockCookSystemCookBookT _iunlockcooksystemcookbook)
		{
			return new IUnlockCookSystemType_UnionUnion
			{
				Type = IUnlockCookSystemType_Union.IUnlockCookSystemCookBook,
				Value = _iunlockcooksystemcookbook
			};
		}

		// Token: 0x060365DD RID: 222685 RVA: 0x00763230 File Offset: 0x00761430
		public static int Pack(FlatBufferBuilder builder, IUnlockCookSystemType_UnionUnion _o)
		{
			IUnlockCookSystemType_Union type = _o.Type;
			if (type == IUnlockCookSystemType_Union.IUnlockCookSystemType)
			{
				return IUnlockCookSystemType.Pack(builder, _o.AsIUnlockCookSystemType()).Value;
			}
			if (type != IUnlockCookSystemType_Union.IUnlockCookSystemCookBook)
			{
				return 0;
			}
			return IUnlockCookSystemCookBook.Pack(builder, _o.AsIUnlockCookSystemCookBook()).Value;
		}
	}
}
