using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200523C RID: 21052
	public class TComparedAlertValueUnion
	{
		// Token: 0x1700967E RID: 38526
		// (get) Token: 0x06021281 RID: 135809 RVA: 0x00493E42 File Offset: 0x00492042
		// (set) Token: 0x06021282 RID: 135810 RVA: 0x00493E4A File Offset: 0x0049204A
		public TComparedAlertValue Type { get; set; }

		// Token: 0x1700967F RID: 38527
		// (get) Token: 0x06021283 RID: 135811 RVA: 0x00493E53 File Offset: 0x00492053
		// (set) Token: 0x06021284 RID: 135812 RVA: 0x00493E5B File Offset: 0x0049205B
		public object Value { get; set; }

		// Token: 0x06021285 RID: 135813 RVA: 0x00493E64 File Offset: 0x00492064
		public TComparedAlertValueUnion()
		{
			this.Type = TComparedAlertValue.NONE;
			this.Value = null;
		}

		// Token: 0x06021286 RID: 135814 RVA: 0x00493E7A File Offset: 0x0049207A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021287 RID: 135815 RVA: 0x00493E8C File Offset: 0x0049208C
		public ICompareCustomAlertValueT AsICompareCustomAlertValue()
		{
			return this.As<ICompareCustomAlertValueT>();
		}

		// Token: 0x06021288 RID: 135816 RVA: 0x00493E94 File Offset: 0x00492094
		public static TComparedAlertValueUnion FromICompareCustomAlertValue(ICompareCustomAlertValueT _icomparecustomalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareCustomAlertValue,
				Value = _icomparecustomalertvalue
			};
		}

		// Token: 0x06021289 RID: 135817 RVA: 0x00493EA9 File Offset: 0x004920A9
		public ICompareMaxAlertValueT AsICompareMaxAlertValue()
		{
			return this.As<ICompareMaxAlertValueT>();
		}

		// Token: 0x0602128A RID: 135818 RVA: 0x00493EB1 File Offset: 0x004920B1
		public static TComparedAlertValueUnion FromICompareMaxAlertValue(ICompareMaxAlertValueT _icomparemaxalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareMaxAlertValue,
				Value = _icomparemaxalertvalue
			};
		}

		// Token: 0x0602128B RID: 135819 RVA: 0x00493EC6 File Offset: 0x004920C6
		public ICompareMinAlertValueT AsICompareMinAlertValue()
		{
			return this.As<ICompareMinAlertValueT>();
		}

		// Token: 0x0602128C RID: 135820 RVA: 0x00493ECE File Offset: 0x004920CE
		public static TComparedAlertValueUnion FromICompareMinAlertValue(ICompareMinAlertValueT _icompareminalertvalue)
		{
			return new TComparedAlertValueUnion
			{
				Type = TComparedAlertValue.ICompareMinAlertValue,
				Value = _icompareminalertvalue
			};
		}

		// Token: 0x0602128D RID: 135821 RVA: 0x00493EE4 File Offset: 0x004920E4
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
