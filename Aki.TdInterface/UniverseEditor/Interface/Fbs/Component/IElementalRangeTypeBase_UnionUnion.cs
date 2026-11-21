using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A1 RID: 22177
	public class IElementalRangeTypeBase_UnionUnion
	{
		// Token: 0x17009F7C RID: 40828
		// (get) Token: 0x060237F6 RID: 145398 RVA: 0x004E2039 File Offset: 0x004E0239
		// (set) Token: 0x060237F7 RID: 145399 RVA: 0x004E2041 File Offset: 0x004E0241
		public IElementalRangeTypeBase_Union Type { get; set; }

		// Token: 0x17009F7D RID: 40829
		// (get) Token: 0x060237F8 RID: 145400 RVA: 0x004E204A File Offset: 0x004E024A
		// (set) Token: 0x060237F9 RID: 145401 RVA: 0x004E2052 File Offset: 0x004E0252
		public object Value { get; set; }

		// Token: 0x060237FA RID: 145402 RVA: 0x004E205B File Offset: 0x004E025B
		public IElementalRangeTypeBase_UnionUnion()
		{
			this.Type = IElementalRangeTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060237FB RID: 145403 RVA: 0x004E2071 File Offset: 0x004E0271
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060237FC RID: 145404 RVA: 0x004E2083 File Offset: 0x004E0283
		public IElementalRangeTypeBaseT AsIElementalRangeTypeBase()
		{
			return this.As<IElementalRangeTypeBaseT>();
		}

		// Token: 0x060237FD RID: 145405 RVA: 0x004E208B File Offset: 0x004E028B
		public static IElementalRangeTypeBase_UnionUnion FromIElementalRangeTypeBase(IElementalRangeTypeBaseT _ielementalrangetypebase)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.IElementalRangeTypeBase,
				Value = _ielementalrangetypebase
			};
		}

		// Token: 0x060237FE RID: 145406 RVA: 0x004E20A0 File Offset: 0x004E02A0
		public IBaseShapeElementalRangeT AsIBaseShapeElementalRange()
		{
			return this.As<IBaseShapeElementalRangeT>();
		}

		// Token: 0x060237FF RID: 145407 RVA: 0x004E20A8 File Offset: 0x004E02A8
		public static IElementalRangeTypeBase_UnionUnion FromIBaseShapeElementalRange(IBaseShapeElementalRangeT _ibaseshapeelementalrange)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.IBaseShapeElementalRange,
				Value = _ibaseshapeelementalrange
			};
		}

		// Token: 0x06023800 RID: 145408 RVA: 0x004E20BD File Offset: 0x004E02BD
		public ITransportBoxElementalRangeT AsITransportBoxElementalRange()
		{
			return this.As<ITransportBoxElementalRangeT>();
		}

		// Token: 0x06023801 RID: 145409 RVA: 0x004E20C5 File Offset: 0x004E02C5
		public static IElementalRangeTypeBase_UnionUnion FromITransportBoxElementalRange(ITransportBoxElementalRangeT _itransportboxelementalrange)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.ITransportBoxElementalRange,
				Value = _itransportboxelementalrange
			};
		}

		// Token: 0x06023802 RID: 145410 RVA: 0x004E20DC File Offset: 0x004E02DC
		public static int Pack(FlatBufferBuilder builder, IElementalRangeTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalRangeTypeBase_Union.IElementalRangeTypeBase:
				return IElementalRangeTypeBase.Pack(builder, _o.AsIElementalRangeTypeBase()).Value;
			case IElementalRangeTypeBase_Union.IBaseShapeElementalRange:
				return IBaseShapeElementalRange.Pack(builder, _o.AsIBaseShapeElementalRange()).Value;
			case IElementalRangeTypeBase_Union.ITransportBoxElementalRange:
				return ITransportBoxElementalRange.Pack(builder, _o.AsITransportBoxElementalRange()).Value;
			default:
				return 0;
			}
		}
	}
}
