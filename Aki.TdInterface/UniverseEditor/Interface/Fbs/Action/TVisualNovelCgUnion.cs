using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780E RID: 30734
	public class TVisualNovelCgUnion
	{
		// Token: 0x1700E6F7 RID: 59127
		// (get) Token: 0x06037BA0 RID: 228256 RVA: 0x007888D2 File Offset: 0x00786AD2
		// (set) Token: 0x06037BA1 RID: 228257 RVA: 0x007888DA File Offset: 0x00786ADA
		public TVisualNovelCg Type { get; set; }

		// Token: 0x1700E6F8 RID: 59128
		// (get) Token: 0x06037BA2 RID: 228258 RVA: 0x007888E3 File Offset: 0x00786AE3
		// (set) Token: 0x06037BA3 RID: 228259 RVA: 0x007888EB File Offset: 0x00786AEB
		public object Value { get; set; }

		// Token: 0x06037BA4 RID: 228260 RVA: 0x007888F4 File Offset: 0x00786AF4
		public TVisualNovelCgUnion()
		{
			this.Type = TVisualNovelCg.NONE;
			this.Value = null;
		}

		// Token: 0x06037BA5 RID: 228261 RVA: 0x0078890A File Offset: 0x00786B0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037BA6 RID: 228262 RVA: 0x0078891C File Offset: 0x00786B1C
		public IVisualNovelCgCleanT AsIVisualNovelCgClean()
		{
			return this.As<IVisualNovelCgCleanT>();
		}

		// Token: 0x06037BA7 RID: 228263 RVA: 0x00788924 File Offset: 0x00786B24
		public static TVisualNovelCgUnion FromIVisualNovelCgClean(IVisualNovelCgCleanT _ivisualnovelcgclean)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgClean,
				Value = _ivisualnovelcgclean
			};
		}

		// Token: 0x06037BA8 RID: 228264 RVA: 0x00788939 File Offset: 0x00786B39
		public IVisualNovelCgLoadImageT AsIVisualNovelCgLoadImage()
		{
			return this.As<IVisualNovelCgLoadImageT>();
		}

		// Token: 0x06037BA9 RID: 228265 RVA: 0x00788941 File Offset: 0x00786B41
		public static TVisualNovelCgUnion FromIVisualNovelCgLoadImage(IVisualNovelCgLoadImageT _ivisualnovelcgloadimage)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgLoadImage,
				Value = _ivisualnovelcgloadimage
			};
		}

		// Token: 0x06037BAA RID: 228266 RVA: 0x00788956 File Offset: 0x00786B56
		public IVisualNovelCgLoadSpineT AsIVisualNovelCgLoadSpine()
		{
			return this.As<IVisualNovelCgLoadSpineT>();
		}

		// Token: 0x06037BAB RID: 228267 RVA: 0x0078895E File Offset: 0x00786B5E
		public static TVisualNovelCgUnion FromIVisualNovelCgLoadSpine(IVisualNovelCgLoadSpineT _ivisualnovelcgloadspine)
		{
			return new TVisualNovelCgUnion
			{
				Type = TVisualNovelCg.IVisualNovelCgLoadSpine,
				Value = _ivisualnovelcgloadspine
			};
		}

		// Token: 0x06037BAC RID: 228268 RVA: 0x00788974 File Offset: 0x00786B74
		public static int Pack(FlatBufferBuilder builder, TVisualNovelCgUnion _o)
		{
			switch (_o.Type)
			{
			case TVisualNovelCg.IVisualNovelCgClean:
				return IVisualNovelCgClean.Pack(builder, _o.AsIVisualNovelCgClean()).Value;
			case TVisualNovelCg.IVisualNovelCgLoadImage:
				return IVisualNovelCgLoadImage.Pack(builder, _o.AsIVisualNovelCgLoadImage()).Value;
			case TVisualNovelCg.IVisualNovelCgLoadSpine:
				return IVisualNovelCgLoadSpine.Pack(builder, _o.AsIVisualNovelCgLoadSpine()).Value;
			default:
				return 0;
			}
		}
	}
}
