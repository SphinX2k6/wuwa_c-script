using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E85 RID: 24197
	public class TGiantStableValueUnion
	{
		// Token: 0x1700B4D5 RID: 46293
		// (get) Token: 0x06029718 RID: 169752 RVA: 0x005ADE86 File Offset: 0x005AC086
		// (set) Token: 0x06029719 RID: 169753 RVA: 0x005ADE8E File Offset: 0x005AC08E
		public TGiantStableValue Type { get; set; }

		// Token: 0x1700B4D6 RID: 46294
		// (get) Token: 0x0602971A RID: 169754 RVA: 0x005ADE97 File Offset: 0x005AC097
		// (set) Token: 0x0602971B RID: 169755 RVA: 0x005ADE9F File Offset: 0x005AC09F
		public object Value { get; set; }

		// Token: 0x0602971C RID: 169756 RVA: 0x005ADEA8 File Offset: 0x005AC0A8
		public TGiantStableValueUnion()
		{
			this.Type = TGiantStableValue.NONE;
			this.Value = null;
		}

		// Token: 0x0602971D RID: 169757 RVA: 0x005ADEBE File Offset: 0x005AC0BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602971E RID: 169758 RVA: 0x005ADED0 File Offset: 0x005AC0D0
		public IGiantStableValueRegionT AsIGiantStableValueRegion()
		{
			return this.As<IGiantStableValueRegionT>();
		}

		// Token: 0x0602971F RID: 169759 RVA: 0x005ADED8 File Offset: 0x005AC0D8
		public static TGiantStableValueUnion FromIGiantStableValueRegion(IGiantStableValueRegionT _igiantstablevalueregion)
		{
			return new TGiantStableValueUnion
			{
				Type = TGiantStableValue.IGiantStableValueRegion,
				Value = _igiantstablevalueregion
			};
		}

		// Token: 0x06029720 RID: 169760 RVA: 0x005ADEED File Offset: 0x005AC0ED
		public IGiantStableValueTotalT AsIGiantStableValueTotal()
		{
			return this.As<IGiantStableValueTotalT>();
		}

		// Token: 0x06029721 RID: 169761 RVA: 0x005ADEF5 File Offset: 0x005AC0F5
		public static TGiantStableValueUnion FromIGiantStableValueTotal(IGiantStableValueTotalT _igiantstablevaluetotal)
		{
			return new TGiantStableValueUnion
			{
				Type = TGiantStableValue.IGiantStableValueTotal,
				Value = _igiantstablevaluetotal
			};
		}

		// Token: 0x06029722 RID: 169762 RVA: 0x005ADF0C File Offset: 0x005AC10C
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
