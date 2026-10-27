using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D35 RID: 15669
	public class IBindingProgressType_UnionUnion
	{
		// Token: 0x17006B79 RID: 27513
		// (get) Token: 0x06015A3B RID: 88635 RVA: 0x0031F9AD File Offset: 0x0031DBAD
		// (set) Token: 0x06015A3C RID: 88636 RVA: 0x0031F9B5 File Offset: 0x0031DBB5
		public IBindingProgressType_Union Type { get; set; }

		// Token: 0x17006B7A RID: 27514
		// (get) Token: 0x06015A3D RID: 88637 RVA: 0x0031F9BE File Offset: 0x0031DBBE
		// (set) Token: 0x06015A3E RID: 88638 RVA: 0x0031F9C6 File Offset: 0x0031DBC6
		public object Value { get; set; }

		// Token: 0x06015A3F RID: 88639 RVA: 0x0031F9CF File Offset: 0x0031DBCF
		public IBindingProgressType_UnionUnion()
		{
			this.Type = IBindingProgressType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015A40 RID: 88640 RVA: 0x0031F9E5 File Offset: 0x0031DBE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015A41 RID: 88641 RVA: 0x0031F9F7 File Offset: 0x0031DBF7
		public IBindingProgressTypeT AsIBindingProgressType()
		{
			return this.As<IBindingProgressTypeT>();
		}

		// Token: 0x06015A42 RID: 88642 RVA: 0x0031F9FF File Offset: 0x0031DBFF
		public static IBindingProgressType_UnionUnion FromIBindingProgressType(IBindingProgressTypeT _ibindingprogresstype)
		{
			return new IBindingProgressType_UnionUnion
			{
				Type = IBindingProgressType_Union.IBindingProgressType,
				Value = _ibindingprogresstype
			};
		}

		// Token: 0x06015A43 RID: 88643 RVA: 0x0031FA14 File Offset: 0x0031DC14
		public IPlayerHavingItemCountT AsIPlayerHavingItemCount()
		{
			return this.As<IPlayerHavingItemCountT>();
		}

		// Token: 0x06015A44 RID: 88644 RVA: 0x0031FA1C File Offset: 0x0031DC1C
		public static IBindingProgressType_UnionUnion FromIPlayerHavingItemCount(IPlayerHavingItemCountT _iplayerhavingitemcount)
		{
			return new IBindingProgressType_UnionUnion
			{
				Type = IBindingProgressType_Union.IPlayerHavingItemCount,
				Value = _iplayerhavingitemcount
			};
		}

		// Token: 0x06015A45 RID: 88645 RVA: 0x0031FA34 File Offset: 0x0031DC34
		public static int Pack(FlatBufferBuilder builder, IBindingProgressType_UnionUnion _o)
		{
			IBindingProgressType_Union type = _o.Type;
			if (type == IBindingProgressType_Union.IBindingProgressType)
			{
				return IBindingProgressType.Pack(builder, _o.AsIBindingProgressType()).Value;
			}
			if (type != IBindingProgressType_Union.IPlayerHavingItemCount)
			{
				return 0;
			}
			return IPlayerHavingItemCount.Pack(builder, _o.AsIPlayerHavingItemCount()).Value;
		}
	}
}
