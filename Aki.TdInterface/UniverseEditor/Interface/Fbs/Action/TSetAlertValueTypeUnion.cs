using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB3 RID: 32691
	public class TSetAlertValueTypeUnion
	{
		// Token: 0x1700F2EF RID: 62191
		// (get) Token: 0x0603AE1B RID: 241179 RVA: 0x007E94FE File Offset: 0x007E76FE
		// (set) Token: 0x0603AE1C RID: 241180 RVA: 0x007E9506 File Offset: 0x007E7706
		public TSetAlertValueType Type { get; set; }

		// Token: 0x1700F2F0 RID: 62192
		// (get) Token: 0x0603AE1D RID: 241181 RVA: 0x007E950F File Offset: 0x007E770F
		// (set) Token: 0x0603AE1E RID: 241182 RVA: 0x007E9517 File Offset: 0x007E7717
		public object Value { get; set; }

		// Token: 0x0603AE1F RID: 241183 RVA: 0x007E9520 File Offset: 0x007E7720
		public TSetAlertValueTypeUnion()
		{
			this.Type = TSetAlertValueType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE20 RID: 241184 RVA: 0x007E9536 File Offset: 0x007E7736
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE21 RID: 241185 RVA: 0x007E9548 File Offset: 0x007E7748
		public IAddOrSubAlertValueT AsIAddOrSubAlertValue()
		{
			return this.As<IAddOrSubAlertValueT>();
		}

		// Token: 0x0603AE22 RID: 241186 RVA: 0x007E9550 File Offset: 0x007E7750
		public static TSetAlertValueTypeUnion FromIAddOrSubAlertValue(IAddOrSubAlertValueT _iaddorsubalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IAddOrSubAlertValue,
				Value = _iaddorsubalertvalue
			};
		}

		// Token: 0x0603AE23 RID: 241187 RVA: 0x007E9565 File Offset: 0x007E7765
		public ICustomAlertValueT AsICustomAlertValue()
		{
			return this.As<ICustomAlertValueT>();
		}

		// Token: 0x0603AE24 RID: 241188 RVA: 0x007E956D File Offset: 0x007E776D
		public static TSetAlertValueTypeUnion FromICustomAlertValue(ICustomAlertValueT _icustomalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.ICustomAlertValue,
				Value = _icustomalertvalue
			};
		}

		// Token: 0x0603AE25 RID: 241189 RVA: 0x007E9582 File Offset: 0x007E7782
		public IMaxAlertValueT AsIMaxAlertValue()
		{
			return this.As<IMaxAlertValueT>();
		}

		// Token: 0x0603AE26 RID: 241190 RVA: 0x007E958A File Offset: 0x007E778A
		public static TSetAlertValueTypeUnion FromIMaxAlertValue(IMaxAlertValueT _imaxalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IMaxAlertValue,
				Value = _imaxalertvalue
			};
		}

		// Token: 0x0603AE27 RID: 241191 RVA: 0x007E959F File Offset: 0x007E779F
		public IMinAlertValueT AsIMinAlertValue()
		{
			return this.As<IMinAlertValueT>();
		}

		// Token: 0x0603AE28 RID: 241192 RVA: 0x007E95A7 File Offset: 0x007E77A7
		public static TSetAlertValueTypeUnion FromIMinAlertValue(IMinAlertValueT _iminalertvalue)
		{
			return new TSetAlertValueTypeUnion
			{
				Type = TSetAlertValueType.IMinAlertValue,
				Value = _iminalertvalue
			};
		}

		// Token: 0x0603AE29 RID: 241193 RVA: 0x007E95BC File Offset: 0x007E77BC
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
