using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763F RID: 30271
	public class TAlertSystemOptionUnion
	{
		// Token: 0x1700E5BD RID: 58813
		// (get) Token: 0x06037208 RID: 225800 RVA: 0x00779B48 File Offset: 0x00777D48
		// (set) Token: 0x06037209 RID: 225801 RVA: 0x00779B50 File Offset: 0x00777D50
		public TAlertSystemOption Type { get; set; }

		// Token: 0x1700E5BE RID: 58814
		// (get) Token: 0x0603720A RID: 225802 RVA: 0x00779B59 File Offset: 0x00777D59
		// (set) Token: 0x0603720B RID: 225803 RVA: 0x00779B61 File Offset: 0x00777D61
		public object Value { get; set; }

		// Token: 0x0603720C RID: 225804 RVA: 0x00779B6A File Offset: 0x00777D6A
		public TAlertSystemOptionUnion()
		{
			this.Type = TAlertSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603720D RID: 225805 RVA: 0x00779B80 File Offset: 0x00777D80
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603720E RID: 225806 RVA: 0x00779B92 File Offset: 0x00777D92
		public IEnableAlertAreaT AsIEnableAlertArea()
		{
			return this.As<IEnableAlertAreaT>();
		}

		// Token: 0x0603720F RID: 225807 RVA: 0x00779B9A File Offset: 0x00777D9A
		public static TAlertSystemOptionUnion FromIEnableAlertArea(IEnableAlertAreaT _ienablealertarea)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IEnableAlertArea,
				Value = _ienablealertarea
			};
		}

		// Token: 0x06037210 RID: 225808 RVA: 0x00779BAF File Offset: 0x00777DAF
		public IEnableAlertUiT AsIEnableAlertUi()
		{
			return this.As<IEnableAlertUiT>();
		}

		// Token: 0x06037211 RID: 225809 RVA: 0x00779BB7 File Offset: 0x00777DB7
		public static TAlertSystemOptionUnion FromIEnableAlertUi(IEnableAlertUiT _ienablealertui)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IEnableAlertUi,
				Value = _ienablealertui
			};
		}

		// Token: 0x06037212 RID: 225810 RVA: 0x00779BCC File Offset: 0x00777DCC
		public IModifyAlertValueT AsIModifyAlertValue()
		{
			return this.As<IModifyAlertValueT>();
		}

		// Token: 0x06037213 RID: 225811 RVA: 0x00779BD4 File Offset: 0x00777DD4
		public static TAlertSystemOptionUnion FromIModifyAlertValue(IModifyAlertValueT _imodifyalertvalue)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IModifyAlertValue,
				Value = _imodifyalertvalue
			};
		}

		// Token: 0x06037214 RID: 225812 RVA: 0x00779BE9 File Offset: 0x00777DE9
		public ISetAlertUiVisibleT AsISetAlertUiVisible()
		{
			return this.As<ISetAlertUiVisibleT>();
		}

		// Token: 0x06037215 RID: 225813 RVA: 0x00779BF1 File Offset: 0x00777DF1
		public static TAlertSystemOptionUnion FromISetAlertUiVisible(ISetAlertUiVisibleT _isetalertuivisible)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.ISetAlertUiVisible,
				Value = _isetalertuivisible
			};
		}

		// Token: 0x06037216 RID: 225814 RVA: 0x00779C08 File Offset: 0x00777E08
		public static int Pack(FlatBufferBuilder builder, TAlertSystemOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TAlertSystemOption.IEnableAlertArea:
				return IEnableAlertArea.Pack(builder, _o.AsIEnableAlertArea()).Value;
			case TAlertSystemOption.IEnableAlertUi:
				return IEnableAlertUi.Pack(builder, _o.AsIEnableAlertUi()).Value;
			case TAlertSystemOption.IModifyAlertValue:
				return IModifyAlertValue.Pack(builder, _o.AsIModifyAlertValue()).Value;
			case TAlertSystemOption.ISetAlertUiVisible:
				return ISetAlertUiVisible.Pack(builder, _o.AsISetAlertUiVisible()).Value;
			default:
				return 0;
			}
		}
	}
}
