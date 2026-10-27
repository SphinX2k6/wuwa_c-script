using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007569 RID: 30057
	public class IVisualNovelCgBase_UnionUnion
	{
		// Token: 0x1700E3F6 RID: 58358
		// (get) Token: 0x06036AD4 RID: 223956 RVA: 0x0076CDC1 File Offset: 0x0076AFC1
		// (set) Token: 0x06036AD5 RID: 223957 RVA: 0x0076CDC9 File Offset: 0x0076AFC9
		public IVisualNovelCgBase_Union Type { get; set; }

		// Token: 0x1700E3F7 RID: 58359
		// (get) Token: 0x06036AD6 RID: 223958 RVA: 0x0076CDD2 File Offset: 0x0076AFD2
		// (set) Token: 0x06036AD7 RID: 223959 RVA: 0x0076CDDA File Offset: 0x0076AFDA
		public object Value { get; set; }

		// Token: 0x06036AD8 RID: 223960 RVA: 0x0076CDE3 File Offset: 0x0076AFE3
		public IVisualNovelCgBase_UnionUnion()
		{
			this.Type = IVisualNovelCgBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036AD9 RID: 223961 RVA: 0x0076CDF9 File Offset: 0x0076AFF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036ADA RID: 223962 RVA: 0x0076CE0B File Offset: 0x0076B00B
		public IVisualNovelCgBaseT AsIVisualNovelCgBase()
		{
			return this.As<IVisualNovelCgBaseT>();
		}

		// Token: 0x06036ADB RID: 223963 RVA: 0x0076CE13 File Offset: 0x0076B013
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgBase(IVisualNovelCgBaseT _ivisualnovelcgbase)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgBase,
				Value = _ivisualnovelcgbase
			};
		}

		// Token: 0x06036ADC RID: 223964 RVA: 0x0076CE28 File Offset: 0x0076B028
		public IVisualNovelCgLoadSpineT AsIVisualNovelCgLoadSpine()
		{
			return this.As<IVisualNovelCgLoadSpineT>();
		}

		// Token: 0x06036ADD RID: 223965 RVA: 0x0076CE30 File Offset: 0x0076B030
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgLoadSpine(IVisualNovelCgLoadSpineT _ivisualnovelcgloadspine)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgLoadSpine,
				Value = _ivisualnovelcgloadspine
			};
		}

		// Token: 0x06036ADE RID: 223966 RVA: 0x0076CE45 File Offset: 0x0076B045
		public IVisualNovelCgLoadImageT AsIVisualNovelCgLoadImage()
		{
			return this.As<IVisualNovelCgLoadImageT>();
		}

		// Token: 0x06036ADF RID: 223967 RVA: 0x0076CE4D File Offset: 0x0076B04D
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgLoadImage(IVisualNovelCgLoadImageT _ivisualnovelcgloadimage)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgLoadImage,
				Value = _ivisualnovelcgloadimage
			};
		}

		// Token: 0x06036AE0 RID: 223968 RVA: 0x0076CE62 File Offset: 0x0076B062
		public IVisualNovelCgCleanT AsIVisualNovelCgClean()
		{
			return this.As<IVisualNovelCgCleanT>();
		}

		// Token: 0x06036AE1 RID: 223969 RVA: 0x0076CE6A File Offset: 0x0076B06A
		public static IVisualNovelCgBase_UnionUnion FromIVisualNovelCgClean(IVisualNovelCgCleanT _ivisualnovelcgclean)
		{
			return new IVisualNovelCgBase_UnionUnion
			{
				Type = IVisualNovelCgBase_Union.IVisualNovelCgClean,
				Value = _ivisualnovelcgclean
			};
		}

		// Token: 0x06036AE2 RID: 223970 RVA: 0x0076CE80 File Offset: 0x0076B080
		public static int Pack(FlatBufferBuilder builder, IVisualNovelCgBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelCgBase_Union.IVisualNovelCgBase:
				return IVisualNovelCgBase.Pack(builder, _o.AsIVisualNovelCgBase()).Value;
			case IVisualNovelCgBase_Union.IVisualNovelCgLoadSpine:
				return IVisualNovelCgLoadSpine.Pack(builder, _o.AsIVisualNovelCgLoadSpine()).Value;
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
