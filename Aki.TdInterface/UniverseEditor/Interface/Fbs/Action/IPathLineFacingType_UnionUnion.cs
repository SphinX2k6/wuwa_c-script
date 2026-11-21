using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D4 RID: 29652
	public class IPathLineFacingType_UnionUnion
	{
		// Token: 0x1700D9CB RID: 55755
		// (get) Token: 0x06033DCA RID: 212426 RVA: 0x006FE699 File Offset: 0x006FC899
		// (set) Token: 0x06033DCB RID: 212427 RVA: 0x006FE6A1 File Offset: 0x006FC8A1
		public IPathLineFacingType_Union Type { get; set; }

		// Token: 0x1700D9CC RID: 55756
		// (get) Token: 0x06033DCC RID: 212428 RVA: 0x006FE6AA File Offset: 0x006FC8AA
		// (set) Token: 0x06033DCD RID: 212429 RVA: 0x006FE6B2 File Offset: 0x006FC8B2
		public object Value { get; set; }

		// Token: 0x06033DCE RID: 212430 RVA: 0x006FE6BB File Offset: 0x006FC8BB
		public IPathLineFacingType_UnionUnion()
		{
			this.Type = IPathLineFacingType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033DCF RID: 212431 RVA: 0x006FE6D1 File Offset: 0x006FC8D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033DD0 RID: 212432 RVA: 0x006FE6E3 File Offset: 0x006FC8E3
		public IPathLineFacingTypeT AsIPathLineFacingType()
		{
			return this.As<IPathLineFacingTypeT>();
		}

		// Token: 0x06033DD1 RID: 212433 RVA: 0x006FE6EB File Offset: 0x006FC8EB
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingType(IPathLineFacingTypeT _ipathlinefacingtype)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingType,
				Value = _ipathlinefacingtype
			};
		}

		// Token: 0x06033DD2 RID: 212434 RVA: 0x006FE700 File Offset: 0x006FC900
		public IPathLineFacingCurrentDirectionT AsIPathLineFacingCurrentDirection()
		{
			return this.As<IPathLineFacingCurrentDirectionT>();
		}

		// Token: 0x06033DD3 RID: 212435 RVA: 0x006FE708 File Offset: 0x006FC908
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingCurrentDirection(IPathLineFacingCurrentDirectionT _ipathlinefacingcurrentdirection)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingCurrentDirection,
				Value = _ipathlinefacingcurrentdirection
			};
		}

		// Token: 0x06033DD4 RID: 212436 RVA: 0x006FE71D File Offset: 0x006FC91D
		public IPathLineFacingCustomDirectionT AsIPathLineFacingCustomDirection()
		{
			return this.As<IPathLineFacingCustomDirectionT>();
		}

		// Token: 0x06033DD5 RID: 212437 RVA: 0x006FE725 File Offset: 0x006FC925
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingCustomDirection(IPathLineFacingCustomDirectionT _ipathlinefacingcustomdirection)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingCustomDirection,
				Value = _ipathlinefacingcustomdirection
			};
		}

		// Token: 0x06033DD6 RID: 212438 RVA: 0x006FE73C File Offset: 0x006FC93C
		public static int Pack(FlatBufferBuilder builder, IPathLineFacingType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPathLineFacingType_Union.IPathLineFacingType:
				return IPathLineFacingType.Pack(builder, _o.AsIPathLineFacingType()).Value;
			case IPathLineFacingType_Union.IPathLineFacingCurrentDirection:
				return IPathLineFacingCurrentDirection.Pack(builder, _o.AsIPathLineFacingCurrentDirection()).Value;
			case IPathLineFacingType_Union.IPathLineFacingCustomDirection:
				return IPathLineFacingCustomDirection.Pack(builder, _o.AsIPathLineFacingCustomDirection()).Value;
			default:
				return 0;
			}
		}
	}
}
