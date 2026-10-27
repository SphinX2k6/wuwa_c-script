using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005253 RID: 21075
	public class IFillType_UnionUnion
	{
		// Token: 0x17009A5F RID: 39519
		// (get) Token: 0x0602247B RID: 140411 RVA: 0x004C0EE5 File Offset: 0x004BF0E5
		// (set) Token: 0x0602247C RID: 140412 RVA: 0x004C0EED File Offset: 0x004BF0ED
		public IFillType_Union Type { get; set; }

		// Token: 0x17009A60 RID: 39520
		// (get) Token: 0x0602247D RID: 140413 RVA: 0x004C0EF6 File Offset: 0x004BF0F6
		// (set) Token: 0x0602247E RID: 140414 RVA: 0x004C0EFE File Offset: 0x004BF0FE
		public object Value { get; set; }

		// Token: 0x0602247F RID: 140415 RVA: 0x004C0F07 File Offset: 0x004BF107
		public IFillType_UnionUnion()
		{
			this.Type = IFillType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022480 RID: 140416 RVA: 0x004C0F1D File Offset: 0x004BF11D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022481 RID: 140417 RVA: 0x004C0F2F File Offset: 0x004BF12F
		public IFillTypeT AsIFillType()
		{
			return this.As<IFillTypeT>();
		}

		// Token: 0x06022482 RID: 140418 RVA: 0x004C0F37 File Offset: 0x004BF137
		public static IFillType_UnionUnion FromIFillType(IFillTypeT _ifilltype)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IFillType,
				Value = _ifilltype
			};
		}

		// Token: 0x06022483 RID: 140419 RVA: 0x004C0F4C File Offset: 0x004BF14C
		public IFixedFillT AsIFixedFill()
		{
			return this.As<IFixedFillT>();
		}

		// Token: 0x06022484 RID: 140420 RVA: 0x004C0F54 File Offset: 0x004BF154
		public static IFillType_UnionUnion FromIFixedFill(IFixedFillT _ifixedfill)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IFixedFill,
				Value = _ifixedfill
			};
		}

		// Token: 0x06022485 RID: 140421 RVA: 0x004C0F69 File Offset: 0x004BF169
		public IDirectionFillT AsIDirectionFill()
		{
			return this.As<IDirectionFillT>();
		}

		// Token: 0x06022486 RID: 140422 RVA: 0x004C0F71 File Offset: 0x004BF171
		public static IFillType_UnionUnion FromIDirectionFill(IDirectionFillT _idirectionfill)
		{
			return new IFillType_UnionUnion
			{
				Type = IFillType_Union.IDirectionFill,
				Value = _idirectionfill
			};
		}

		// Token: 0x06022487 RID: 140423 RVA: 0x004C0F88 File Offset: 0x004BF188
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
