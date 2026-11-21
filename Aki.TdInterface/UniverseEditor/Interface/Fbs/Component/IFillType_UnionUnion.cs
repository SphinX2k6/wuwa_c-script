using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BB RID: 22459
	public class IFillType_UnionUnion
	{
		// Token: 0x1700A25B RID: 41563
		// (get) Token: 0x06024411 RID: 148497 RVA: 0x004FB9A9 File Offset: 0x004F9BA9
		// (set) Token: 0x06024412 RID: 148498 RVA: 0x004FB9B1 File Offset: 0x004F9BB1
		public IFillType_Union Type { get; set; }

		// Token: 0x1700A25C RID: 41564
		// (get) Token: 0x06024413 RID: 148499 RVA: 0x004FB9BA File Offset: 0x004F9BBA
		// (set) Token: 0x06024414 RID: 148500 RVA: 0x004FB9C2 File Offset: 0x004F9BC2
		public object Value { get; set; }

		// Token: 0x06024415 RID: 148501 RVA: 0x004FB9CB File Offset: 0x004F9BCB
		public IFillType_UnionUnion()
		{
			this.Type = IFillType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024416 RID: 148502 RVA: 0x004FB9E1 File Offset: 0x004F9BE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024417 RID: 148503 RVA: 0x004FB9F3 File Offset: 0x004F9BF3
		public IFillTypeT AsIFillType()
		{
			return this.As<IFillTypeT>();
		}

		// Token: 0x06024418 RID: 148504 RVA: 0x004FB9FB File Offset: 0x004F9BFB
		public static IFillType_UnionUnion FromIFillType(IFillTypeT _ifilltype)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IFillType,
				Value = _ifilltype
			};
		}

		// Token: 0x06024419 RID: 148505 RVA: 0x004FBA10 File Offset: 0x004F9C10
		public IFixedFillT AsIFixedFill()
		{
			return this.As<IFixedFillT>();
		}

		// Token: 0x0602441A RID: 148506 RVA: 0x004FBA18 File Offset: 0x004F9C18
		public static IFillType_UnionUnion FromIFixedFill(IFixedFillT _ifixedfill)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IFixedFill,
				Value = _ifixedfill
			};
		}

		// Token: 0x0602441B RID: 148507 RVA: 0x004FBA2D File Offset: 0x004F9C2D
		public IDirectionFillT AsIDirectionFill()
		{
			return this.As<IDirectionFillT>();
		}

		// Token: 0x0602441C RID: 148508 RVA: 0x004FBA35 File Offset: 0x004F9C35
		public static IFillType_UnionUnion FromIDirectionFill(IDirectionFillT _idirectionfill)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IDirectionFill,
				Value = _idirectionfill
			};
		}

		// Token: 0x0602441D RID: 148509 RVA: 0x004FBA4C File Offset: 0x004F9C4C
		public static int Pack(FlatBufferBuilder builder, IFillType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFillType_Union.IFillType:
				return IFillType.Pack(builder, _o.AsIFillType()).Value;
			case IFillType_Union.IFixedFill:
				return IFixedFill.Pack(builder, _o.AsIFixedFill()).Value;
			case IFillType_Union.IDirectionFill:
				return IDirectionFill.Pack(builder, _o.AsIDirectionFill()).Value;
			default:
				return 0;
			}
		}
	}
}
