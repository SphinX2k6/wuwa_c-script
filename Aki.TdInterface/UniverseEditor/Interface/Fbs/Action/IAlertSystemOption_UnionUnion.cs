using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F7 RID: 26615
	public class IAlertSystemOption_UnionUnion
	{
		// Token: 0x1700C3AC RID: 50092
		// (get) Token: 0x0602D763 RID: 186211 RVA: 0x0063981E File Offset: 0x00637A1E
		// (set) Token: 0x0602D764 RID: 186212 RVA: 0x00639826 File Offset: 0x00637A26
		public IAlertSystemOption_Union Type { get; set; }

		// Token: 0x1700C3AD RID: 50093
		// (get) Token: 0x0602D765 RID: 186213 RVA: 0x0063982F File Offset: 0x00637A2F
		// (set) Token: 0x0602D766 RID: 186214 RVA: 0x00639837 File Offset: 0x00637A37
		public object Value { get; set; }

		// Token: 0x0602D767 RID: 186215 RVA: 0x00639840 File Offset: 0x00637A40
		public IAlertSystemOption_UnionUnion()
		{
			this.Type = IAlertSystemOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D768 RID: 186216 RVA: 0x00639856 File Offset: 0x00637A56
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D769 RID: 186217 RVA: 0x00639868 File Offset: 0x00637A68
		public IAlertSystemOptionT AsIAlertSystemOption()
		{
			return this.As<IAlertSystemOptionT>();
		}

		// Token: 0x0602D76A RID: 186218 RVA: 0x00639870 File Offset: 0x00637A70
		public static IAlertSystemOption_UnionUnion FromIAlertSystemOption(IAlertSystemOptionT _ialertsystemoption)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IAlertSystemOption,
				Value = _ialertsystemoption
			};
		}

		// Token: 0x0602D76B RID: 186219 RVA: 0x00639885 File Offset: 0x00637A85
		public IEnableAlertAreaT AsIEnableAlertArea()
		{
			return this.As<IEnableAlertAreaT>();
		}

		// Token: 0x0602D76C RID: 186220 RVA: 0x0063988D File Offset: 0x00637A8D
		public static IAlertSystemOption_UnionUnion FromIEnableAlertArea(IEnableAlertAreaT _ienablealertarea)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IEnableAlertArea,
				Value = _ienablealertarea
			};
		}

		// Token: 0x0602D76D RID: 186221 RVA: 0x006398A2 File Offset: 0x00637AA2
		public IModifyAlertValueT AsIModifyAlertValue()
		{
			return this.As<IModifyAlertValueT>();
		}

		// Token: 0x0602D76E RID: 186222 RVA: 0x006398AA File Offset: 0x00637AAA
		public static IAlertSystemOption_UnionUnion FromIModifyAlertValue(IModifyAlertValueT _imodifyalertvalue)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IModifyAlertValue,
				Value = _imodifyalertvalue
			};
		}

		// Token: 0x0602D76F RID: 186223 RVA: 0x006398BF File Offset: 0x00637ABF
		public IEnableAlertUiT AsIEnableAlertUi()
		{
			return this.As<IEnableAlertUiT>();
		}

		// Token: 0x0602D770 RID: 186224 RVA: 0x006398C7 File Offset: 0x00637AC7
		public static IAlertSystemOption_UnionUnion FromIEnableAlertUi(IEnableAlertUiT _ienablealertui)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IEnableAlertUi,
				Value = _ienablealertui
			};
		}

		// Token: 0x0602D771 RID: 186225 RVA: 0x006398DC File Offset: 0x00637ADC
		public ISetAlertUiVisibleT AsISetAlertUiVisible()
		{
			return this.As<ISetAlertUiVisibleT>();
		}

		// Token: 0x0602D772 RID: 186226 RVA: 0x006398E4 File Offset: 0x00637AE4
		public static IAlertSystemOption_UnionUnion FromISetAlertUiVisible(ISetAlertUiVisibleT _isetalertuivisible)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.ISetAlertUiVisible,
				Value = _isetalertuivisible
			};
		}

		// Token: 0x0602D773 RID: 186227 RVA: 0x006398FC File Offset: 0x00637AFC
		public static int Pack(FlatBufferBuilder builder, IAlertSystemOption_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAlertSystemOption_Union.IAlertSystemOption:
				return IAlertSystemOption.Pack(builder, _o.AsIAlertSystemOption()).Value;
			case IAlertSystemOption_Union.IEnableAlertArea:
				return IEnableAlertArea.Pack(builder, _o.AsIEnableAlertArea()).Value;
			case IAlertSystemOption_Union.IModifyAlertValue:
				return IModifyAlertValue.Pack(builder, _o.AsIModifyAlertValue()).Value;
			case IAlertSystemOption_Union.IEnableAlertUi:
				return IEnableAlertUi.Pack(builder, _o.AsIEnableAlertUi()).Value;
			case IAlertSystemOption_Union.ISetAlertUiVisible:
				return ISetAlertUiVisible.Pack(builder, _o.AsISetAlertUiVisible()).Value;
			default:
				return 0;
			}
		}
	}
}
