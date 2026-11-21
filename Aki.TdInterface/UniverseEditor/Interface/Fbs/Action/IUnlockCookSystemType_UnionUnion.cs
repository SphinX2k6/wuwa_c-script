using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC6 RID: 31942
	public class IUnlockCookSystemType_UnionUnion
	{
		// Token: 0x1700EF1B RID: 61211
		// (get) Token: 0x060399E8 RID: 236008 RVA: 0x007C63F9 File Offset: 0x007C45F9
		// (set) Token: 0x060399E9 RID: 236009 RVA: 0x007C6401 File Offset: 0x007C4601
		public IUnlockCookSystemType_Union Type { get; set; }

		// Token: 0x1700EF1C RID: 61212
		// (get) Token: 0x060399EA RID: 236010 RVA: 0x007C640A File Offset: 0x007C460A
		// (set) Token: 0x060399EB RID: 236011 RVA: 0x007C6412 File Offset: 0x007C4612
		public object Value { get; set; }

		// Token: 0x060399EC RID: 236012 RVA: 0x007C641B File Offset: 0x007C461B
		public IUnlockCookSystemType_UnionUnion()
		{
			this.Type = IUnlockCookSystemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060399ED RID: 236013 RVA: 0x007C6431 File Offset: 0x007C4631
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060399EE RID: 236014 RVA: 0x007C6443 File Offset: 0x007C4643
		public IUnlockCookSystemTypeT AsIUnlockCookSystemType()
		{
			return this.As<IUnlockCookSystemTypeT>();
		}

		// Token: 0x060399EF RID: 236015 RVA: 0x007C644B File Offset: 0x007C464B
		public static IUnlockCookSystemType_UnionUnion FromIUnlockCookSystemType(IUnlockCookSystemTypeT _iunlockcooksystemtype)
		{
			return new IUnlockCookSystemType_UnionUnion
			{
				Type = IUnlockCookSystemType_Union.IUnlockCookSystemType,
				Value = _iunlockcooksystemtype
			};
		}

		// Token: 0x060399F0 RID: 236016 RVA: 0x007C6460 File Offset: 0x007C4660
		public IUnlockCookSystemCookBookT AsIUnlockCookSystemCookBook()
		{
			return this.As<IUnlockCookSystemCookBookT>();
		}

		// Token: 0x060399F1 RID: 236017 RVA: 0x007C6468 File Offset: 0x007C4668
		public static IUnlockCookSystemType_UnionUnion FromIUnlockCookSystemCookBook(IUnlockCookSystemCookBookT _iunlockcooksystemcookbook)
		{
			return new IUnlockCookSystemType_UnionUnion
			{
				Type = IUnlockCookSystemType_Union.IUnlockCookSystemCookBook,
				Value = _iunlockcooksystemcookbook
			};
		}

		// Token: 0x060399F2 RID: 236018 RVA: 0x007C6480 File Offset: 0x007C4680
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
