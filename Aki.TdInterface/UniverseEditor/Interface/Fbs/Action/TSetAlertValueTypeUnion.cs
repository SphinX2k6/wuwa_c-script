using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777B RID: 30587
	public class TSetAlertValueTypeUnion
	{
		// Token: 0x1700E695 RID: 59029
		// (get) Token: 0x060378A2 RID: 227490 RVA: 0x0078403E File Offset: 0x0078223E
		// (set) Token: 0x060378A3 RID: 227491 RVA: 0x00784046 File Offset: 0x00782246
		public TSetAlertValueType Type { get; set; }

		// Token: 0x1700E696 RID: 59030
		// (get) Token: 0x060378A4 RID: 227492 RVA: 0x0078404F File Offset: 0x0078224F
		// (set) Token: 0x060378A5 RID: 227493 RVA: 0x00784057 File Offset: 0x00782257
		public object Value { get; set; }

		// Token: 0x060378A6 RID: 227494 RVA: 0x00784060 File Offset: 0x00782260
		public TSetAlertValueTypeUnion()
		{
			this.Type = TSetAlertValueType.NONE;
			this.Value = null;
		}

		// Token: 0x060378A7 RID: 227495 RVA: 0x00784076 File Offset: 0x00782276
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378A8 RID: 227496 RVA: 0x00784088 File Offset: 0x00782288
		public IAddOrSubAlertValueT AsIAddOrSubAlertValue()
		{
			return this.As<IAddOrSubAlertValueT>();
		}

		// Token: 0x060378A9 RID: 227497 RVA: 0x00784090 File Offset: 0x00782290
		public static TSetAlertValueTypeUnion FromIAddOrSubAlertValue(IAddOrSubAlertValueT _iaddorsubalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IAddOrSubAlertValue,
				Value = _iaddorsubalertvalue
			};
		}

		// Token: 0x060378AA RID: 227498 RVA: 0x007840A5 File Offset: 0x007822A5
		public ICustomAlertValueT AsICustomAlertValue()
		{
			return this.As<ICustomAlertValueT>();
		}

		// Token: 0x060378AB RID: 227499 RVA: 0x007840AD File Offset: 0x007822AD
		public static TSetAlertValueTypeUnion FromICustomAlertValue(ICustomAlertValueT _icustomalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.ICustomAlertValue,
				Value = _icustomalertvalue
			};
		}

		// Token: 0x060378AC RID: 227500 RVA: 0x007840C2 File Offset: 0x007822C2
		public IMaxAlertValueT AsIMaxAlertValue()
		{
			return this.As<IMaxAlertValueT>();
		}

		// Token: 0x060378AD RID: 227501 RVA: 0x007840CA File Offset: 0x007822CA
		public static TSetAlertValueTypeUnion FromIMaxAlertValue(IMaxAlertValueT _imaxalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IMaxAlertValue,
				Value = _imaxalertvalue
			};
		}

		// Token: 0x060378AE RID: 227502 RVA: 0x007840DF File Offset: 0x007822DF
		public IMinAlertValueT AsIMinAlertValue()
		{
			return this.As<IMinAlertValueT>();
		}

		// Token: 0x060378AF RID: 227503 RVA: 0x007840E7 File Offset: 0x007822E7
		public static TSetAlertValueTypeUnion FromIMinAlertValue(IMinAlertValueT _iminalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IMinAlertValue,
				Value = _iminalertvalue
			};
		}

		// Token: 0x060378B0 RID: 227504 RVA: 0x007840FC File Offset: 0x007822FC
		public static int Pack(FlatBufferBuilder builder, TSetAlertValueTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TSetAlertValueType.IAddOrSubAlertValue:
				return IAddOrSubAlertValue.Pack(builder, _o.AsIAddOrSubAlertValue()).Value;
			case TSetAlertValueType.ICustomAlertValue:
				return ICustomAlertValue.Pack(builder, _o.AsICustomAlertValue()).Value;
			case TSetAlertValueType.IMaxAlertValue:
				return IMaxAlertValue.Pack(builder, _o.AsIMaxAlertValue()).Value;
			case TSetAlertValueType.IMinAlertValue:
				return IMinAlertValue.Pack(builder, _o.AsIMinAlertValue()).Value;
			default:
				return 0;
			}
		}
	}
}
