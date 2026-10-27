using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB9 RID: 23993
	public class IGiantAnimDataType_UnionUnion
	{
		// Token: 0x1700B3A4 RID: 45988
		// (get) Token: 0x06029104 RID: 168196 RVA: 0x005A3475 File Offset: 0x005A1675
		// (set) Token: 0x06029105 RID: 168197 RVA: 0x005A347D File Offset: 0x005A167D
		public IGiantAnimDataType_Union Type { get; set; }

		// Token: 0x1700B3A5 RID: 45989
		// (get) Token: 0x06029106 RID: 168198 RVA: 0x005A3486 File Offset: 0x005A1686
		// (set) Token: 0x06029107 RID: 168199 RVA: 0x005A348E File Offset: 0x005A168E
		public object Value { get; set; }

		// Token: 0x06029108 RID: 168200 RVA: 0x005A3497 File Offset: 0x005A1697
		public IGiantAnimDataType_UnionUnion()
		{
			this.Type = IGiantAnimDataType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029109 RID: 168201 RVA: 0x005A34AD File Offset: 0x005A16AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602910A RID: 168202 RVA: 0x005A34BF File Offset: 0x005A16BF
		public IGiantAnimDataTypeT AsIGiantAnimDataType()
		{
			return this.As<IGiantAnimDataTypeT>();
		}

		// Token: 0x0602910B RID: 168203 RVA: 0x005A34C7 File Offset: 0x005A16C7
		public static IGiantAnimDataType_UnionUnion FromIGiantAnimDataType(IGiantAnimDataTypeT _igiantanimdatatype)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantAnimDataType,
				Value = _igiantanimdatatype
			};
		}

		// Token: 0x0602910C RID: 168204 RVA: 0x005A34DC File Offset: 0x005A16DC
		public IGiantIdleAnimDataT AsIGiantIdleAnimData()
		{
			return this.As<IGiantIdleAnimDataT>();
		}

		// Token: 0x0602910D RID: 168205 RVA: 0x005A34E4 File Offset: 0x005A16E4
		public static IGiantAnimDataType_UnionUnion FromIGiantIdleAnimData(IGiantIdleAnimDataT _igiantidleanimdata)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantIdleAnimData,
				Value = _igiantidleanimdata
			};
		}

		// Token: 0x0602910E RID: 168206 RVA: 0x005A34F9 File Offset: 0x005A16F9
		public IGiantSpecialAnimDataT AsIGiantSpecialAnimData()
		{
			return this.As<IGiantSpecialAnimDataT>();
		}

		// Token: 0x0602910F RID: 168207 RVA: 0x005A3501 File Offset: 0x005A1701
		public static IGiantAnimDataType_UnionUnion FromIGiantSpecialAnimData(IGiantSpecialAnimDataT _igiantspecialanimdata)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantSpecialAnimData,
				Value = _igiantspecialanimdata
			};
		}

		// Token: 0x06029110 RID: 168208 RVA: 0x005A3518 File Offset: 0x005A1718
		public static int Pack(FlatBufferBuilder builder, IGiantAnimDataType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGiantAnimDataType_Union.IGiantAnimDataType:
				return IGiantAnimDataType.Pack(builder, _o.AsIGiantAnimDataType()).Value;
			case IGiantAnimDataType_Union.IGiantIdleAnimData:
				return IGiantIdleAnimData.Pack(builder, _o.AsIGiantIdleAnimData()).Value;
			case IGiantAnimDataType_Union.IGiantSpecialAnimData:
				return IGiantSpecialAnimData.Pack(builder, _o.AsIGiantSpecialAnimData()).Value;
			default:
				return 0;
			}
		}
	}
}
