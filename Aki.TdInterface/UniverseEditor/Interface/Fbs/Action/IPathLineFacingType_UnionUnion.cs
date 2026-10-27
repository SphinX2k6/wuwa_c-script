using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6D RID: 27757
	public class IPathLineFacingType_UnionUnion
	{
		// Token: 0x1700CEB0 RID: 52912
		// (get) Token: 0x06030E6F RID: 200303 RVA: 0x006A4199 File Offset: 0x006A2399
		// (set) Token: 0x06030E70 RID: 200304 RVA: 0x006A41A1 File Offset: 0x006A23A1
		public IPathLineFacingType_Union Type { get; set; }

		// Token: 0x1700CEB1 RID: 52913
		// (get) Token: 0x06030E71 RID: 200305 RVA: 0x006A41AA File Offset: 0x006A23AA
		// (set) Token: 0x06030E72 RID: 200306 RVA: 0x006A41B2 File Offset: 0x006A23B2
		public object Value { get; set; }

		// Token: 0x06030E73 RID: 200307 RVA: 0x006A41BB File Offset: 0x006A23BB
		public IPathLineFacingType_UnionUnion()
		{
			this.Type = IPathLineFacingType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030E74 RID: 200308 RVA: 0x006A41D1 File Offset: 0x006A23D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030E75 RID: 200309 RVA: 0x006A41E3 File Offset: 0x006A23E3
		public IPathLineFacingTypeT AsIPathLineFacingType()
		{
			return this.As<IPathLineFacingTypeT>();
		}

		// Token: 0x06030E76 RID: 200310 RVA: 0x006A41EB File Offset: 0x006A23EB
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingType(IPathLineFacingTypeT _ipathlinefacingtype)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingType,
				Value = _ipathlinefacingtype
			};
		}

		// Token: 0x06030E77 RID: 200311 RVA: 0x006A4200 File Offset: 0x006A2400
		public IPathLineFacingCurrentDirectionT AsIPathLineFacingCurrentDirection()
		{
			return this.As<IPathLineFacingCurrentDirectionT>();
		}

		// Token: 0x06030E78 RID: 200312 RVA: 0x006A4208 File Offset: 0x006A2408
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingCurrentDirection(IPathLineFacingCurrentDirectionT _ipathlinefacingcurrentdirection)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingCurrentDirection,
				Value = _ipathlinefacingcurrentdirection
			};
		}

		// Token: 0x06030E79 RID: 200313 RVA: 0x006A421D File Offset: 0x006A241D
		public IPathLineFacingCustomDirectionT AsIPathLineFacingCustomDirection()
		{
			return this.As<IPathLineFacingCustomDirectionT>();
		}

		// Token: 0x06030E7A RID: 200314 RVA: 0x006A4225 File Offset: 0x006A2425
		public static IPathLineFacingType_UnionUnion FromIPathLineFacingCustomDirection(IPathLineFacingCustomDirectionT _ipathlinefacingcustomdirection)
		{
			return new IPathLineFacingType_UnionUnion
			{
				Type = IPathLineFacingType_Union.IPathLineFacingCustomDirection,
				Value = _ipathlinefacingcustomdirection
			};
		}

		// Token: 0x06030E7B RID: 200315 RVA: 0x006A423C File Offset: 0x006A243C
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
