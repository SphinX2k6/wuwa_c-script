using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200618C RID: 24972
	public class IAlertSystemOption_UnionUnion
	{
		// Token: 0x1700BA2E RID: 47662
		// (get) Token: 0x0602B032 RID: 176178 RVA: 0x005EEFAA File Offset: 0x005ED1AA
		// (set) Token: 0x0602B033 RID: 176179 RVA: 0x005EEFB2 File Offset: 0x005ED1B2
		public IAlertSystemOption_Union Type { get; set; }

		// Token: 0x1700BA2F RID: 47663
		// (get) Token: 0x0602B034 RID: 176180 RVA: 0x005EEFBB File Offset: 0x005ED1BB
		// (set) Token: 0x0602B035 RID: 176181 RVA: 0x005EEFC3 File Offset: 0x005ED1C3
		public object Value { get; set; }

		// Token: 0x0602B036 RID: 176182 RVA: 0x005EEFCC File Offset: 0x005ED1CC
		public IAlertSystemOption_UnionUnion()
		{
			this.Type = IAlertSystemOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B037 RID: 176183 RVA: 0x005EEFE2 File Offset: 0x005ED1E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B038 RID: 176184 RVA: 0x005EEFF4 File Offset: 0x005ED1F4
		public IAlertSystemOptionT AsIAlertSystemOption()
		{
			return this.As<IAlertSystemOptionT>();
		}

		// Token: 0x0602B039 RID: 176185 RVA: 0x005EEFFC File Offset: 0x005ED1FC
		public static IAlertSystemOption_UnionUnion FromIAlertSystemOption(IAlertSystemOptionT _ialertsystemoption)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IAlertSystemOption,
				Value = _ialertsystemoption
			};
		}

		// Token: 0x0602B03A RID: 176186 RVA: 0x005EF011 File Offset: 0x005ED211
		public IEnableAlertAreaT AsIEnableAlertArea()
		{
			return this.As<IEnableAlertAreaT>();
		}

		// Token: 0x0602B03B RID: 176187 RVA: 0x005EF019 File Offset: 0x005ED219
		public static IAlertSystemOption_UnionUnion FromIEnableAlertArea(IEnableAlertAreaT _ienablealertarea)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IEnableAlertArea,
				Value = _ienablealertarea
			};
		}

		// Token: 0x0602B03C RID: 176188 RVA: 0x005EF02E File Offset: 0x005ED22E
		public IModifyAlertValueT AsIModifyAlertValue()
		{
			return this.As<IModifyAlertValueT>();
		}

		// Token: 0x0602B03D RID: 176189 RVA: 0x005EF036 File Offset: 0x005ED236
		public static IAlertSystemOption_UnionUnion FromIModifyAlertValue(IModifyAlertValueT _imodifyalertvalue)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IModifyAlertValue,
				Value = _imodifyalertvalue
			};
		}

		// Token: 0x0602B03E RID: 176190 RVA: 0x005EF04B File Offset: 0x005ED24B
		public IEnableAlertUiT AsIEnableAlertUi()
		{
			return this.As<IEnableAlertUiT>();
		}

		// Token: 0x0602B03F RID: 176191 RVA: 0x005EF053 File Offset: 0x005ED253
		public static IAlertSystemOption_UnionUnion FromIEnableAlertUi(IEnableAlertUiT _ienablealertui)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.IEnableAlertUi,
				Value = _ienablealertui
			};
		}

		// Token: 0x0602B040 RID: 176192 RVA: 0x005EF068 File Offset: 0x005ED268
		public ISetAlertUiVisibleT AsISetAlertUiVisible()
		{
			return this.As<ISetAlertUiVisibleT>();
		}

		// Token: 0x0602B041 RID: 176193 RVA: 0x005EF070 File Offset: 0x005ED270
		public static IAlertSystemOption_UnionUnion FromISetAlertUiVisible(ISetAlertUiVisibleT _isetalertuivisible)
		{
			return new IAlertSystemOption_UnionUnion
			{
				Type = IAlertSystemOption_Union.ISetAlertUiVisible,
				Value = _isetalertuivisible
			};
		}

		// Token: 0x0602B042 RID: 176194 RVA: 0x005EF088 File Offset: 0x005ED288
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
