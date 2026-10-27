using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D40 RID: 19776
	public class TComparedAlertValueUnion
	{
		// Token: 0x17008F45 RID: 36677
		// (get) Token: 0x0601F638 RID: 128568 RVA: 0x0045FE6E File Offset: 0x0045E06E
		// (set) Token: 0x0601F639 RID: 128569 RVA: 0x0045FE76 File Offset: 0x0045E076
		public TComparedAlertValue Type { get; set; }

		// Token: 0x17008F46 RID: 36678
		// (get) Token: 0x0601F63A RID: 128570 RVA: 0x0045FE7F File Offset: 0x0045E07F
		// (set) Token: 0x0601F63B RID: 128571 RVA: 0x0045FE87 File Offset: 0x0045E087
		public object Value { get; set; }

		// Token: 0x0601F63C RID: 128572 RVA: 0x0045FE90 File Offset: 0x0045E090
		public TComparedAlertValueUnion()
		{
			this.Type = TComparedAlertValue.NONE;
			this.Value = null;
		}

		// Token: 0x0601F63D RID: 128573 RVA: 0x0045FEA6 File Offset: 0x0045E0A6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F63E RID: 128574 RVA: 0x0045FEB8 File Offset: 0x0045E0B8
		public ICompareCustomAlertValueT AsICompareCustomAlertValue()
		{
			return this.As<ICompareCustomAlertValueT>();
		}

		// Token: 0x0601F63F RID: 128575 RVA: 0x0045FEC0 File Offset: 0x0045E0C0
		public static TComparedAlertValueUnion FromICompareCustomAlertValue(ICompareCustomAlertValueT _icomparecustomalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareCustomAlertValue,
				Value = _icomparecustomalertvalue
			};
		}

		// Token: 0x0601F640 RID: 128576 RVA: 0x0045FED5 File Offset: 0x0045E0D5
		public ICompareMaxAlertValueT AsICompareMaxAlertValue()
		{
			return this.As<ICompareMaxAlertValueT>();
		}

		// Token: 0x0601F641 RID: 128577 RVA: 0x0045FEDD File Offset: 0x0045E0DD
		public static TComparedAlertValueUnion FromICompareMaxAlertValue(ICompareMaxAlertValueT _icomparemaxalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareMaxAlertValue,
				Value = _icomparemaxalertvalue
			};
		}

		// Token: 0x0601F642 RID: 128578 RVA: 0x0045FEF2 File Offset: 0x0045E0F2
		public ICompareMinAlertValueT AsICompareMinAlertValue()
		{
			return this.As<ICompareMinAlertValueT>();
		}

		// Token: 0x0601F643 RID: 128579 RVA: 0x0045FEFA File Offset: 0x0045E0FA
		public static TComparedAlertValueUnion FromICompareMinAlertValue(ICompareMinAlertValueT _icompareminalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareMinAlertValue,
				Value = _icompareminalertvalue
			};
		}

		// Token: 0x0601F644 RID: 128580 RVA: 0x0045FF10 File Offset: 0x0045E110
		public static int Pack(FlatBufferBuilder builder, TComparedAlertValueUnion _o)
		{
			switch (_o.Type)
			{
			case TComparedAlertValue.ICompareCustomAlertValue:
				return ICompareCustomAlertValue.Pack(builder, _o.AsICompareCustomAlertValue()).Value;
			case TComparedAlertValue.ICompareMaxAlertValue:
				return ICompareMaxAlertValue.Pack(builder, _o.AsICompareMaxAlertValue()).Value;
			case TComparedAlertValue.ICompareMinAlertValue:
				return ICompareMinAlertValue.Pack(builder, _o.AsICompareMinAlertValue()).Value;
			default:
				return 0;
			}
		}
	}
}
