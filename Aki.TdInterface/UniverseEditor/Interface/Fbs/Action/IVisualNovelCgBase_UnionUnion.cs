using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D5F RID: 32095
	public class IVisualNovelCgBase_UnionUnion
	{
		// Token: 0x1700F020 RID: 61472
		// (get) Token: 0x06039EEA RID: 237290 RVA: 0x007D0069 File Offset: 0x007CE269
		// (set) Token: 0x06039EEB RID: 237291 RVA: 0x007D0071 File Offset: 0x007CE271
		public IVisualNovelCgBase_Union Type { get; set; }

		// Token: 0x1700F021 RID: 61473
		// (get) Token: 0x06039EEC RID: 237292 RVA: 0x007D007A File Offset: 0x007CE27A
		// (set) Token: 0x06039EED RID: 237293 RVA: 0x007D0082 File Offset: 0x007CE282
		public object Value { get; set; }

		// Token: 0x06039EEE RID: 237294 RVA: 0x007D008B File Offset: 0x007CE28B
		public IVisualNovelCgBase_UnionUnion()
		{
			this.Type = IVisualNovelCgBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039EEF RID: 237295 RVA: 0x007D00A1 File Offset: 0x007CE2A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039EF0 RID: 237296 RVA: 0x007D00B3 File Offset: 0x007CE2B3
		public IVisualNovelCgBaseT AsIVisualNovelCgBase()
		{
			return this.As<IVisualNovelCgBaseT>();
		}

		// Token: 0x06039EF1 RID: 237297 RVA: 0x007D00BB File Offset: 0x007CE2BB
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgBase(IVisualNovelCgBaseT _ivisualnovelcgbase)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgBase,
				Value = _ivisualnovelcgbase
			};
		}

		// Token: 0x06039EF2 RID: 237298 RVA: 0x007D00D0 File Offset: 0x007CE2D0
		public IVisualNovelCgLoadPrefabT AsIVisualNovelCgLoadPrefab()
		{
			return this.As<IVisualNovelCgLoadPrefabT>();
		}

		// Token: 0x06039EF3 RID: 237299 RVA: 0x007D00D8 File Offset: 0x007CE2D8
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgLoadPrefab(IVisualNovelCgLoadPrefabT _ivisualnovelcgloadprefab)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgLoadPrefab,
				Value = _ivisualnovelcgloadprefab
			};
		}

		// Token: 0x06039EF4 RID: 237300 RVA: 0x007D00ED File Offset: 0x007CE2ED
		public IVisualNovelCgLoadImageT AsIVisualNovelCgLoadImage()
		{
			return this.As<IVisualNovelCgLoadImageT>();
		}

		// Token: 0x06039EF5 RID: 237301 RVA: 0x007D00F5 File Offset: 0x007CE2F5
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgLoadImage(IVisualNovelCgLoadImageT _ivisualnovelcgloadimage)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgLoadImage,
				Value = _ivisualnovelcgloadimage
			};
		}

		// Token: 0x06039EF6 RID: 237302 RVA: 0x007D010A File Offset: 0x007CE30A
		public IVisualNovelCgCleanT AsIVisualNovelCgClean()
		{
			return this.As<IVisualNovelCgCleanT>();
		}

		// Token: 0x06039EF7 RID: 237303 RVA: 0x007D0112 File Offset: 0x007CE312
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgClean(IVisualNovelCgCleanT _ivisualnovelcgclean)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgClean,
				Value = _ivisualnovelcgclean
			};
		}

		// Token: 0x06039EF8 RID: 237304 RVA: 0x007D0128 File Offset: 0x007CE328
		public static int Pack(FlatBufferBuilder builder, IVisualNovelCgBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelCgBase_Union.IVisualNovelCgBase:
				return IVisualNovelCgBase.Pack(builder, _o.AsIVisualNovelCgBase()).Value;
			case IVisualNovelCgBase_Union.IVisualNovelCgLoadPrefab:
				return IVisualNovelCgLoadPrefab.Pack(builder, _o.AsIVisualNovelCgLoadPrefab()).Value;
			case IVisualNovelCgBase_Union.IVisualNovelCgLoadImage:
				return IVisualNovelCgLoadImage.Pack(builder, _o.AsIVisualNovelCgLoadImage()).Value;
			case IVisualNovelCgBase_Union.IVisualNovelCgClean:
				return IVisualNovelCgClean.Pack(builder, _o.AsIVisualNovelCgClean()).Value;
			default:
				return 0;
			}
		}
	}
}
