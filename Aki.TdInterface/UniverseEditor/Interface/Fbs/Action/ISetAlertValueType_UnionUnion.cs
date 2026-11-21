using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007760 RID: 30560
	public class ISetAlertValueType_UnionUnion
	{
		// Token: 0x1700DFFD RID: 57341
		// (get) Token: 0x06035A21 RID: 219681 RVA: 0x007303A5 File Offset: 0x0072E5A5
		// (set) Token: 0x06035A22 RID: 219682 RVA: 0x007303AD File Offset: 0x0072E5AD
		public ISetAlertValueType_Union Type { get; set; }

		// Token: 0x1700DFFE RID: 57342
		// (get) Token: 0x06035A23 RID: 219683 RVA: 0x007303B6 File Offset: 0x0072E5B6
		// (set) Token: 0x06035A24 RID: 219684 RVA: 0x007303BE File Offset: 0x0072E5BE
		public object Value { get; set; }

		// Token: 0x06035A25 RID: 219685 RVA: 0x007303C7 File Offset: 0x0072E5C7
		public ISetAlertValueType_UnionUnion()
		{
			this.Type = ISetAlertValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035A26 RID: 219686 RVA: 0x007303DD File Offset: 0x0072E5DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035A27 RID: 219687 RVA: 0x007303EF File Offset: 0x0072E5EF
		public ISetAlertValueTypeT AsISetAlertValueType()
		{
			return this.As<ISetAlertValueTypeT>();
		}

		// Token: 0x06035A28 RID: 219688 RVA: 0x007303F7 File Offset: 0x0072E5F7
		public static ISetAlertValueType_UnionUnion FromISetAlertValueType(ISetAlertValueTypeT _isetalertvaluetype)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.ISetAlertValueType,
				Value = _isetalertvaluetype
			};
		}

		// Token: 0x06035A29 RID: 219689 RVA: 0x0073040C File Offset: 0x0072E60C
		public IAddOrSubAlertValueT AsIAddOrSubAlertValue()
		{
			return this.As<IAddOrSubAlertValueT>();
		}

		// Token: 0x06035A2A RID: 219690 RVA: 0x00730414 File Offset: 0x0072E614
		public static ISetAlertValueType_UnionUnion FromIAddOrSubAlertValue(IAddOrSubAlertValueT _iaddorsubalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IAddOrSubAlertValue,
				Value = _iaddorsubalertvalue
			};
		}

		// Token: 0x06035A2B RID: 219691 RVA: 0x00730429 File Offset: 0x0072E629
		public ICustomAlertValueT AsICustomAlertValue()
		{
			return this.As<ICustomAlertValueT>();
		}

		// Token: 0x06035A2C RID: 219692 RVA: 0x00730431 File Offset: 0x0072E631
		public static ISetAlertValueType_UnionUnion FromICustomAlertValue(ICustomAlertValueT _icustomalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.ICustomAlertValue,
				Value = _icustomalertvalue
			};
		}

		// Token: 0x06035A2D RID: 219693 RVA: 0x00730446 File Offset: 0x0072E646
		public IMinAlertValueT AsIMinAlertValue()
		{
			return this.As<IMinAlertValueT>();
		}

		// Token: 0x06035A2E RID: 219694 RVA: 0x0073044E File Offset: 0x0072E64E
		public static ISetAlertValueType_UnionUnion FromIMinAlertValue(IMinAlertValueT _iminalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IMinAlertValue,
				Value = _iminalertvalue
			};
		}

		// Token: 0x06035A2F RID: 219695 RVA: 0x00730463 File Offset: 0x0072E663
		public IMaxAlertValueT AsIMaxAlertValue()
		{
			return this.As<IMaxAlertValueT>();
		}

		// Token: 0x06035A30 RID: 219696 RVA: 0x0073046B File Offset: 0x0072E66B
		public static ISetAlertValueType_UnionUnion FromIMaxAlertValue(IMaxAlertValueT _imaxalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IMaxAlertValue,
				Value = _imaxalertvalue
			};
		}

		// Token: 0x06035A31 RID: 219697 RVA: 0x00730480 File Offset: 0x0072E680
		public static int Pack(FlatBufferBuilder builder, ISetAlertValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetAlertValueType_Union.ISetAlertValueType:
				return ISetAlertValueType.Pack(builder, _o.AsISetAlertValueType()).Value;
			case ISetAlertValueType_Union.IAddOrSubAlertValue:
				return IAddOrSubAlertValue.Pack(builder, _o.AsIAddOrSubAlertValue()).Value;
			case ISetAlertValueType_Union.ICustomAlertValue:
				return ICustomAlertValue.Pack(builder, _o.AsICustomAlertValue()).Value;
			case ISetAlertValueType_Union.IMinAlertValue:
				return IMinAlertValue.Pack(builder, _o.AsIMinAlertValue()).Value;
			case ISetAlertValueType_Union.IMaxAlertValue:
				return IMaxAlertValue.Pack(builder, _o.AsIMaxAlertValue()).Value;
			default:
				return 0;
			}
		}
	}
}
