using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E4D RID: 32333
	public class TAlertSystemOptionUnion
	{
		// Token: 0x1700F1FB RID: 61947
		// (get) Token: 0x0603A6AD RID: 239277 RVA: 0x007DDC44 File Offset: 0x007DBE44
		// (set) Token: 0x0603A6AE RID: 239278 RVA: 0x007DDC4C File Offset: 0x007DBE4C
		public TAlertSystemOption Type { get; set; }

		// Token: 0x1700F1FC RID: 61948
		// (get) Token: 0x0603A6AF RID: 239279 RVA: 0x007DDC55 File Offset: 0x007DBE55
		// (set) Token: 0x0603A6B0 RID: 239280 RVA: 0x007DDC5D File Offset: 0x007DBE5D
		public object Value { get; set; }

		// Token: 0x0603A6B1 RID: 239281 RVA: 0x007DDC66 File Offset: 0x007DBE66
		public TAlertSystemOptionUnion()
		{
			this.Type = TAlertSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6B2 RID: 239282 RVA: 0x007DDC7C File Offset: 0x007DBE7C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6B3 RID: 239283 RVA: 0x007DDC8E File Offset: 0x007DBE8E
		public IEnableAlertAreaT AsIEnableAlertArea()
		{
			return this.As<IEnableAlertAreaT>();
		}

		// Token: 0x0603A6B4 RID: 239284 RVA: 0x007DDC96 File Offset: 0x007DBE96
		public static TAlertSystemOptionUnion FromIEnableAlertArea(IEnableAlertAreaT _ienablealertarea)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IEnableAlertArea,
				Value = _ienablealertarea
			};
		}

		// Token: 0x0603A6B5 RID: 239285 RVA: 0x007DDCAB File Offset: 0x007DBEAB
		public IEnableAlertUiT AsIEnableAlertUi()
		{
			return this.As<IEnableAlertUiT>();
		}

		// Token: 0x0603A6B6 RID: 239286 RVA: 0x007DDCB3 File Offset: 0x007DBEB3
		public static TAlertSystemOptionUnion FromIEnableAlertUi(IEnableAlertUiT _ienablealertui)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IEnableAlertUi,
				Value = _ienablealertui
			};
		}

		// Token: 0x0603A6B7 RID: 239287 RVA: 0x007DDCC8 File Offset: 0x007DBEC8
		public IModifyAlertValueT AsIModifyAlertValue()
		{
			return this.As<IModifyAlertValueT>();
		}

		// Token: 0x0603A6B8 RID: 239288 RVA: 0x007DDCD0 File Offset: 0x007DBED0
		public static TAlertSystemOptionUnion FromIModifyAlertValue(IModifyAlertValueT _imodifyalertvalue)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.IModifyAlertValue,
				Value = _imodifyalertvalue
			};
		}

		// Token: 0x0603A6B9 RID: 239289 RVA: 0x007DDCE5 File Offset: 0x007DBEE5
		public ISetAlertUiVisibleT AsISetAlertUiVisible()
		{
			return this.As<ISetAlertUiVisibleT>();
		}

		// Token: 0x0603A6BA RID: 239290 RVA: 0x007DDCED File Offset: 0x007DBEED
		public static TAlertSystemOptionUnion FromISetAlertUiVisible(ISetAlertUiVisibleT _isetalertuivisible)
		{
			return new TAlertSystemOptionUnion
			{
				Type = TAlertSystemOption.ISetAlertUiVisible,
				Value = _isetalertuivisible
			};
		}

		// Token: 0x0603A6BB RID: 239291 RVA: 0x007DDD04 File Offset: 0x007DBF04
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
