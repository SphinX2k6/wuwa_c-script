using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9A RID: 28570
	public class ISetAlertValueType_UnionUnion
	{
		// Token: 0x1700D42E RID: 54318
		// (get) Token: 0x060327D1 RID: 206801 RVA: 0x006D09ED File Offset: 0x006CEBED
		// (set) Token: 0x060327D2 RID: 206802 RVA: 0x006D09F5 File Offset: 0x006CEBF5
		public ISetAlertValueType_Union Type { get; set; }

		// Token: 0x1700D42F RID: 54319
		// (get) Token: 0x060327D3 RID: 206803 RVA: 0x006D09FE File Offset: 0x006CEBFE
		// (set) Token: 0x060327D4 RID: 206804 RVA: 0x006D0A06 File Offset: 0x006CEC06
		public object Value { get; set; }

		// Token: 0x060327D5 RID: 206805 RVA: 0x006D0A0F File Offset: 0x006CEC0F
		public ISetAlertValueType_UnionUnion()
		{
			this.Type = ISetAlertValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060327D6 RID: 206806 RVA: 0x006D0A25 File Offset: 0x006CEC25
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060327D7 RID: 206807 RVA: 0x006D0A37 File Offset: 0x006CEC37
		public ISetAlertValueTypeT AsISetAlertValueType()
		{
			return this.As<ISetAlertValueTypeT>();
		}

		// Token: 0x060327D8 RID: 206808 RVA: 0x006D0A3F File Offset: 0x006CEC3F
		public static ISetAlertValueType_UnionUnion FromISetAlertValueType(ISetAlertValueTypeT _isetalertvaluetype)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.ISetAlertValueType,
				Value = _isetalertvaluetype
			};
		}

		// Token: 0x060327D9 RID: 206809 RVA: 0x006D0A54 File Offset: 0x006CEC54
		public IAddOrSubAlertValueT AsIAddOrSubAlertValue()
		{
			return this.As<IAddOrSubAlertValueT>();
		}

		// Token: 0x060327DA RID: 206810 RVA: 0x006D0A5C File Offset: 0x006CEC5C
		public static ISetAlertValueType_UnionUnion FromIAddOrSubAlertValue(IAddOrSubAlertValueT _iaddorsubalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IAddOrSubAlertValue,
				Value = _iaddorsubalertvalue
			};
		}

		// Token: 0x060327DB RID: 206811 RVA: 0x006D0A71 File Offset: 0x006CEC71
		public ICustomAlertValueT AsICustomAlertValue()
		{
			return this.As<ICustomAlertValueT>();
		}

		// Token: 0x060327DC RID: 206812 RVA: 0x006D0A79 File Offset: 0x006CEC79
		public static ISetAlertValueType_UnionUnion FromICustomAlertValue(ICustomAlertValueT _icustomalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.ICustomAlertValue,
				Value = _icustomalertvalue
			};
		}

		// Token: 0x060327DD RID: 206813 RVA: 0x006D0A8E File Offset: 0x006CEC8E
		public IMinAlertValueT AsIMinAlertValue()
		{
			return this.As<IMinAlertValueT>();
		}

		// Token: 0x060327DE RID: 206814 RVA: 0x006D0A96 File Offset: 0x006CEC96
		public static ISetAlertValueType_UnionUnion FromIMinAlertValue(IMinAlertValueT _iminalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IMinAlertValue,
				Value = _iminalertvalue
			};
		}

		// Token: 0x060327DF RID: 206815 RVA: 0x006D0AAB File Offset: 0x006CECAB
		public IMaxAlertValueT AsIMaxAlertValue()
		{
			return this.As<IMaxAlertValueT>();
		}

		// Token: 0x060327E0 RID: 206816 RVA: 0x006D0AB3 File Offset: 0x006CECB3
		public static ISetAlertValueType_UnionUnion FromIMaxAlertValue(IMaxAlertValueT _imaxalertvalue)
		{
			return new ISetAlertValueType_UnionUnion
			{
				Type = ISetAlertValueType_Union.IMaxAlertValue,
				Value = _imaxalertvalue
			};
		}

		// Token: 0x060327E1 RID: 206817 RVA: 0x006D0AC8 File Offset: 0x006CECC8
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
