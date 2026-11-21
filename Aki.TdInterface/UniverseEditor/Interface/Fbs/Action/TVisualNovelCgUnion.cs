using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200804C RID: 32844
	public class TVisualNovelCgUnion
	{
		// Token: 0x1700F355 RID: 62293
		// (get) Token: 0x0603B145 RID: 241989 RVA: 0x007EE24A File Offset: 0x007EC44A
		// (set) Token: 0x0603B146 RID: 241990 RVA: 0x007EE252 File Offset: 0x007EC452
		public TVisualNovelCg Type { get; set; }

		// Token: 0x1700F356 RID: 62294
		// (get) Token: 0x0603B147 RID: 241991 RVA: 0x007EE25B File Offset: 0x007EC45B
		// (set) Token: 0x0603B148 RID: 241992 RVA: 0x007EE263 File Offset: 0x007EC463
		public object Value { get; set; }

		// Token: 0x0603B149 RID: 241993 RVA: 0x007EE26C File Offset: 0x007EC46C
		public TVisualNovelCgUnion()
		{
			this.Type = TVisualNovelCg.NONE;
			this.Value = null;
		}

		// Token: 0x0603B14A RID: 241994 RVA: 0x007EE282 File Offset: 0x007EC482
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B14B RID: 241995 RVA: 0x007EE294 File Offset: 0x007EC494
		public IVisualNovelCgCleanT AsIVisualNovelCgClean()
		{
			return this.As<IVisualNovelCgCleanT>();
		}

		// Token: 0x0603B14C RID: 241996 RVA: 0x007EE29C File Offset: 0x007EC49C
		public static TVisualNovelCgUnion FromIVisualNovelCgClean(IVisualNovelCgCleanT _ivisualnovelcgclean)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgClean,
				Value = _ivisualnovelcgclean
			};
		}

		// Token: 0x0603B14D RID: 241997 RVA: 0x007EE2B1 File Offset: 0x007EC4B1
		public IVisualNovelCgLoadImageT AsIVisualNovelCgLoadImage()
		{
			return this.As<IVisualNovelCgLoadImageT>();
		}

		// Token: 0x0603B14E RID: 241998 RVA: 0x007EE2B9 File Offset: 0x007EC4B9
		public static TVisualNovelCgUnion FromIVisualNovelCgLoadImage(IVisualNovelCgLoadImageT _ivisualnovelcgloadimage)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgLoadImage,
				Value = _ivisualnovelcgloadimage
			};
		}

		// Token: 0x0603B14F RID: 241999 RVA: 0x007EE2CE File Offset: 0x007EC4CE
		public IVisualNovelCgLoadPrefabT AsIVisualNovelCgLoadPrefab()
		{
			return this.As<IVisualNovelCgLoadPrefabT>();
		}

		// Token: 0x0603B150 RID: 242000 RVA: 0x007EE2D6 File Offset: 0x007EC4D6
		public static TVisualNovelCgUnion FromIVisualNovelCgLoadPrefab(IVisualNovelCgLoadPrefabT _ivisualnovelcgloadprefab)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgLoadPrefab,
				Value = _ivisualnovelcgloadprefab
			};
		}

		// Token: 0x0603B151 RID: 242001 RVA: 0x007EE2EC File Offset: 0x007EC4EC
		public static int Pack(FlatBufferBuilder builder, TVisualNovelCgUnion _o)
		{
			switch (_o.Type)
			{
			case TVisualNovelCg.IVisualNovelCgClean:
				return IVisualNovelCgClean.Pack(builder, _o.AsIVisualNovelCgClean()).Value;
			case TVisualNovelCg.IVisualNovelCgLoadImage:
				return IVisualNovelCgLoadImage.Pack(builder, _o.AsIVisualNovelCgLoadImage()).Value;
			case TVisualNovelCg.IVisualNovelCgLoadPrefab:
				return IVisualNovelCgLoadPrefab.Pack(builder, _o.AsIVisualNovelCgLoadPrefab()).Value;
			default:
				return 0;
			}
		}
	}
}
