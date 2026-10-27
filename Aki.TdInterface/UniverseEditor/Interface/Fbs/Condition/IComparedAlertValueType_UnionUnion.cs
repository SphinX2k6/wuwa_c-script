using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B90 RID: 19344
	public class IComparedAlertValueType_UnionUnion
	{
		// Token: 0x17008C5F RID: 35935
		// (get) Token: 0x0601E7D2 RID: 124882 RVA: 0x004448E1 File Offset: 0x00442AE1
		// (set) Token: 0x0601E7D3 RID: 124883 RVA: 0x004448E9 File Offset: 0x00442AE9
		public IComparedAlertValueType_Union Type { get; set; }

		// Token: 0x17008C60 RID: 35936
		// (get) Token: 0x0601E7D4 RID: 124884 RVA: 0x004448F2 File Offset: 0x00442AF2
		// (set) Token: 0x0601E7D5 RID: 124885 RVA: 0x004448FA File Offset: 0x00442AFA
		public object Value { get; set; }

		// Token: 0x0601E7D6 RID: 124886 RVA: 0x00444903 File Offset: 0x00442B03
		public IComparedAlertValueType_UnionUnion()
		{
			this.Type = IComparedAlertValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E7D7 RID: 124887 RVA: 0x00444919 File Offset: 0x00442B19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E7D8 RID: 124888 RVA: 0x0044492B File Offset: 0x00442B2B
		public IComparedAlertValueTypeT AsIComparedAlertValueType()
		{
			return this.As<IComparedAlertValueTypeT>();
		}

		// Token: 0x0601E7D9 RID: 124889 RVA: 0x00444933 File Offset: 0x00442B33
		public static IComparedAlertValueType_UnionUnion FromIComparedAlertValueType(IComparedAlertValueTypeT _icomparedalertvaluetype)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.IComparedAlertValueType,
				Value = _icomparedalertvaluetype
			};
		}

		// Token: 0x0601E7DA RID: 124890 RVA: 0x00444948 File Offset: 0x00442B48
		public ICompareMinAlertValueT AsICompareMinAlertValue()
		{
			return this.As<ICompareMinAlertValueT>();
		}

		// Token: 0x0601E7DB RID: 124891 RVA: 0x00444950 File Offset: 0x00442B50
		public static IComparedAlertValueType_UnionUnion FromICompareMinAlertValue(ICompareMinAlertValueT _icompareminalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareMinAlertValue,
				Value = _icompareminalertvalue
			};
		}

		// Token: 0x0601E7DC RID: 124892 RVA: 0x00444965 File Offset: 0x00442B65
		public ICompareMaxAlertValueT AsICompareMaxAlertValue()
		{
			return this.As<ICompareMaxAlertValueT>();
		}

		// Token: 0x0601E7DD RID: 124893 RVA: 0x0044496D File Offset: 0x00442B6D
		public static IComparedAlertValueType_UnionUnion FromICompareMaxAlertValue(ICompareMaxAlertValueT _icomparemaxalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareMaxAlertValue,
				Value = _icomparemaxalertvalue
			};
		}

		// Token: 0x0601E7DE RID: 124894 RVA: 0x00444982 File Offset: 0x00442B82
		public ICompareCustomAlertValueT AsICompareCustomAlertValue()
		{
			return this.As<ICompareCustomAlertValueT>();
		}

		// Token: 0x0601E7DF RID: 124895 RVA: 0x0044498A File Offset: 0x00442B8A
		public static IComparedAlertValueType_UnionUnion FromICompareCustomAlertValue(ICompareCustomAlertValueT _icomparecustomalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareCustomAlertValue,
				Value = _icomparecustomalertvalue
			};
		}

		// Token: 0x0601E7E0 RID: 124896 RVA: 0x004449A0 File Offset: 0x00442BA0
		public static int Pack(FlatBufferBuilder builder, IComparedAlertValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IComparedAlertValueType_Union.IComparedAlertValueType:
				return IComparedAlertValueType.Pack(builder, _o.AsIComparedAlertValueType()).Value;
			case IComparedAlertValueType_Union.ICompareMinAlertValue:
				return ICompareMinAlertValue.Pack(builder, _o.AsICompareMinAlertValue()).Value;
			case IComparedAlertValueType_Union.ICompareMaxAlertValue:
				return ICompareMaxAlertValue.Pack(builder, _o.AsICompareMaxAlertValue()).Value;
			case IComparedAlertValueType_Union.ICompareCustomAlertValue:
				return ICompareCustomAlertValue.Pack(builder, _o.AsICompareCustomAlertValue()).Value;
			default:
				return 0;
			}
		}
	}
}
