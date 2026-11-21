using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D53 RID: 32083
	public class IVisualNovelBackgroundBase_UnionUnion
	{
		// Token: 0x1700F013 RID: 61459
		// (get) Token: 0x06039EA2 RID: 237218 RVA: 0x007CFA31 File Offset: 0x007CDC31
		// (set) Token: 0x06039EA3 RID: 237219 RVA: 0x007CFA39 File Offset: 0x007CDC39
		public IVisualNovelBackgroundBase_Union Type { get; set; }

		// Token: 0x1700F014 RID: 61460
		// (get) Token: 0x06039EA4 RID: 237220 RVA: 0x007CFA42 File Offset: 0x007CDC42
		// (set) Token: 0x06039EA5 RID: 237221 RVA: 0x007CFA4A File Offset: 0x007CDC4A
		public object Value { get; set; }

		// Token: 0x06039EA6 RID: 237222 RVA: 0x007CFA53 File Offset: 0x007CDC53
		public IVisualNovelBackgroundBase_UnionUnion()
		{
			this.Type = IVisualNovelBackgroundBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039EA7 RID: 237223 RVA: 0x007CFA69 File Offset: 0x007CDC69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039EA8 RID: 237224 RVA: 0x007CFA7B File Offset: 0x007CDC7B
		public IVisualNovelBackgroundBaseT AsIVisualNovelBackgroundBase()
		{
			return this.As<IVisualNovelBackgroundBaseT>();
		}

		// Token: 0x06039EA9 RID: 237225 RVA: 0x007CFA83 File Offset: 0x007CDC83
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundBase(IVisualNovelBackgroundBaseT _ivisualnovelbackgroundbase)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundBase,
				Value = _ivisualnovelbackgroundbase
			};
		}

		// Token: 0x06039EAA RID: 237226 RVA: 0x007CFA98 File Offset: 0x007CDC98
		public IVisualNovelBackgroundLoadT AsIVisualNovelBackgroundLoad()
		{
			return this.As<IVisualNovelBackgroundLoadT>();
		}

		// Token: 0x06039EAB RID: 237227 RVA: 0x007CFAA0 File Offset: 0x007CDCA0
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundLoad(IVisualNovelBackgroundLoadT _ivisualnovelbackgroundload)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundLoad,
				Value = _ivisualnovelbackgroundload
			};
		}

		// Token: 0x06039EAC RID: 237228 RVA: 0x007CFAB5 File Offset: 0x007CDCB5
		public IVisualNovelBackgroundCleanT AsIVisualNovelBackgroundClean()
		{
			return this.As<IVisualNovelBackgroundCleanT>();
		}

		// Token: 0x06039EAD RID: 237229 RVA: 0x007CFABD File Offset: 0x007CDCBD
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundClean(IVisualNovelBackgroundCleanT _ivisualnovelbackgroundclean)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundClean,
				Value = _ivisualnovelbackgroundclean
			};
		}

		// Token: 0x06039EAE RID: 237230 RVA: 0x007CFAD4 File Offset: 0x007CDCD4
		public static int Pack(FlatBufferBuilder builder, IVisualNovelBackgroundBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundBase:
				return IVisualNovelBackgroundBase.Pack(builder, _o.AsIVisualNovelBackgroundBase()).Value;
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundLoad:
				return IVisualNovelBackgroundLoad.Pack(builder, _o.AsIVisualNovelBackgroundLoad()).Value;
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundClean:
				return IVisualNovelBackgroundClean.Pack(builder, _o.AsIVisualNovelBackgroundClean()).Value;
			default:
				return 0;
			}
		}
	}
}
