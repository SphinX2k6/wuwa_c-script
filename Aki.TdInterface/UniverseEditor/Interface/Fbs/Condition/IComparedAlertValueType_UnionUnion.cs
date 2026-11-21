using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005077 RID: 20599
	public class IComparedAlertValueType_UnionUnion
	{
		// Token: 0x1700936F RID: 37743
		// (get) Token: 0x06020360 RID: 131936 RVA: 0x0047712D File Offset: 0x0047532D
		// (set) Token: 0x06020361 RID: 131937 RVA: 0x00477135 File Offset: 0x00475335
		public IComparedAlertValueType_Union Type { get; set; }

		// Token: 0x17009370 RID: 37744
		// (get) Token: 0x06020362 RID: 131938 RVA: 0x0047713E File Offset: 0x0047533E
		// (set) Token: 0x06020363 RID: 131939 RVA: 0x00477146 File Offset: 0x00475346
		public object Value { get; set; }

		// Token: 0x06020364 RID: 131940 RVA: 0x0047714F File Offset: 0x0047534F
		public IComparedAlertValueType_UnionUnion()
		{
			this.Type = IComparedAlertValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020365 RID: 131941 RVA: 0x00477165 File Offset: 0x00475365
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020366 RID: 131942 RVA: 0x00477177 File Offset: 0x00475377
		public IComparedAlertValueTypeT AsIComparedAlertValueType()
		{
			return this.As<IComparedAlertValueTypeT>();
		}

		// Token: 0x06020367 RID: 131943 RVA: 0x0047717F File Offset: 0x0047537F
		public static IComparedAlertValueType_UnionUnion FromIComparedAlertValueType(IComparedAlertValueTypeT _icomparedalertvaluetype)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.IComparedAlertValueType,
				Value = _icomparedalertvaluetype
			};
		}

		// Token: 0x06020368 RID: 131944 RVA: 0x00477194 File Offset: 0x00475394
		public ICompareMinAlertValueT AsICompareMinAlertValue()
		{
			return this.As<ICompareMinAlertValueT>();
		}

		// Token: 0x06020369 RID: 131945 RVA: 0x0047719C File Offset: 0x0047539C
		public static IComparedAlertValueType_UnionUnion FromICompareMinAlertValue(ICompareMinAlertValueT _icompareminalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareMinAlertValue,
				Value = _icompareminalertvalue
			};
		}

		// Token: 0x0602036A RID: 131946 RVA: 0x004771B1 File Offset: 0x004753B1
		public ICompareMaxAlertValueT AsICompareMaxAlertValue()
		{
			return this.As<ICompareMaxAlertValueT>();
		}

		// Token: 0x0602036B RID: 131947 RVA: 0x004771B9 File Offset: 0x004753B9
		public static IComparedAlertValueType_UnionUnion FromICompareMaxAlertValue(ICompareMaxAlertValueT _icomparemaxalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareMaxAlertValue,
				Value = _icomparemaxalertvalue
			};
		}

		// Token: 0x0602036C RID: 131948 RVA: 0x004771CE File Offset: 0x004753CE
		public ICompareCustomAlertValueT AsICompareCustomAlertValue()
		{
			return this.As<ICompareCustomAlertValueT>();
		}

		// Token: 0x0602036D RID: 131949 RVA: 0x004771D6 File Offset: 0x004753D6
		public static IComparedAlertValueType_UnionUnion FromICompareCustomAlertValue(ICompareCustomAlertValueT _icomparecustomalertvalue)
		{
			return new IComparedAlertValueType_UnionUnion
			{
				Type = IComparedAlertValueType_Union.ICompareCustomAlertValue,
				Value = _icomparecustomalertvalue
			};
		}

		// Token: 0x0602036E RID: 131950 RVA: 0x004771EC File Offset: 0x004753EC
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
