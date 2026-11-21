using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C8 RID: 25800
	public class TGiantStableValueUnion
	{
		// Token: 0x1700BE40 RID: 48704
		// (get) Token: 0x0602BDC0 RID: 179648 RVA: 0x005F6E2A File Offset: 0x005F502A
		// (set) Token: 0x0602BDC1 RID: 179649 RVA: 0x005F6E32 File Offset: 0x005F5032
		public TGiantStableValue Type { get; set; }

		// Token: 0x1700BE41 RID: 48705
		// (get) Token: 0x0602BDC2 RID: 179650 RVA: 0x005F6E3B File Offset: 0x005F503B
		// (set) Token: 0x0602BDC3 RID: 179651 RVA: 0x005F6E43 File Offset: 0x005F5043
		public object Value { get; set; }

		// Token: 0x0602BDC4 RID: 179652 RVA: 0x005F6E4C File Offset: 0x005F504C
		public TGiantStableValueUnion()
		{
			this.Type = TGiantStableValue.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDC5 RID: 179653 RVA: 0x005F6E62 File Offset: 0x005F5062
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDC6 RID: 179654 RVA: 0x005F6E74 File Offset: 0x005F5074
		public IGiantStableValueRegionT AsIGiantStableValueRegion()
		{
			return this.As<IGiantStableValueRegionT>();
		}

		// Token: 0x0602BDC7 RID: 179655 RVA: 0x005F6E7C File Offset: 0x005F507C
		public static TGiantStableValueUnion FromIGiantStableValueRegion(IGiantStableValueRegionT _igiantstablevalueregion)
		{
			return new TGiantStableValueUnion
			{
				Type = TGiantStableValue.IGiantStableValueRegion,
				Value = _igiantstablevalueregion
			};
		}

		// Token: 0x0602BDC8 RID: 179656 RVA: 0x005F6E91 File Offset: 0x005F5091
		public IGiantStableValueTotalT AsIGiantStableValueTotal()
		{
			return this.As<IGiantStableValueTotalT>();
		}

		// Token: 0x0602BDC9 RID: 179657 RVA: 0x005F6E99 File Offset: 0x005F5099
		public static TGiantStableValueUnion FromIGiantStableValueTotal(IGiantStableValueTotalT _igiantstablevaluetotal)
		{
			return new TGiantStableValueUnion
			{
				Type = TGiantStableValue.IGiantStableValueTotal,
				Value = _igiantstablevaluetotal
			};
		}

		// Token: 0x0602BDCA RID: 179658 RVA: 0x005F6EB0 File Offset: 0x005F50B0
		public static int Pack(FlatBufferBuilder builder, TGiantStableValueUnion _o)
		{
			TGiantStableValue type = _o.Type;
			if (type == TGiantStableValue.IGiantStableValueRegion)
			{
				return IGiantStableValueRegion.Pack(builder, _o.AsIGiantStableValueRegion()).Value;
			}
			if (type != TGiantStableValue.IGiantStableValueTotal)
			{
				return 0;
			}
			return IGiantStableValueTotal.Pack(builder, _o.AsIGiantStableValueTotal()).Value;
		}
	}
}
