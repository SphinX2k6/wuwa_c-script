using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F6 RID: 25590
	public class IGiantAnimDataType_UnionUnion
	{
		// Token: 0x1700BD0A RID: 48394
		// (get) Token: 0x0602B78E RID: 178062 RVA: 0x005EC1A5 File Offset: 0x005EA3A5
		// (set) Token: 0x0602B78F RID: 178063 RVA: 0x005EC1AD File Offset: 0x005EA3AD
		public IGiantAnimDataType_Union Type { get; set; }

		// Token: 0x1700BD0B RID: 48395
		// (get) Token: 0x0602B790 RID: 178064 RVA: 0x005EC1B6 File Offset: 0x005EA3B6
		// (set) Token: 0x0602B791 RID: 178065 RVA: 0x005EC1BE File Offset: 0x005EA3BE
		public object Value { get; set; }

		// Token: 0x0602B792 RID: 178066 RVA: 0x005EC1C7 File Offset: 0x005EA3C7
		public IGiantAnimDataType_UnionUnion()
		{
			this.Type = IGiantAnimDataType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B793 RID: 178067 RVA: 0x005EC1DD File Offset: 0x005EA3DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B794 RID: 178068 RVA: 0x005EC1EF File Offset: 0x005EA3EF
		public IGiantAnimDataTypeT AsIGiantAnimDataType()
		{
			return this.As<IGiantAnimDataTypeT>();
		}

		// Token: 0x0602B795 RID: 178069 RVA: 0x005EC1F7 File Offset: 0x005EA3F7
		public static IGiantAnimDataType_UnionUnion FromIGiantAnimDataType(IGiantAnimDataTypeT _igiantanimdatatype)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantAnimDataType,
				Value = _igiantanimdatatype
			};
		}

		// Token: 0x0602B796 RID: 178070 RVA: 0x005EC20C File Offset: 0x005EA40C
		public IGiantIdleAnimDataT AsIGiantIdleAnimData()
		{
			return this.As<IGiantIdleAnimDataT>();
		}

		// Token: 0x0602B797 RID: 178071 RVA: 0x005EC214 File Offset: 0x005EA414
		public static IGiantAnimDataType_UnionUnion FromIGiantIdleAnimData(IGiantIdleAnimDataT _igiantidleanimdata)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantIdleAnimData,
				Value = _igiantidleanimdata
			};
		}

		// Token: 0x0602B798 RID: 178072 RVA: 0x005EC229 File Offset: 0x005EA429
		public IGiantSpecialAnimDataT AsIGiantSpecialAnimData()
		{
			return this.As<IGiantSpecialAnimDataT>();
		}

		// Token: 0x0602B799 RID: 178073 RVA: 0x005EC231 File Offset: 0x005EA431
		public static IGiantAnimDataType_UnionUnion FromIGiantSpecialAnimData(IGiantSpecialAnimDataT _igiantspecialanimdata)
		{
			return new IGiantAnimDataType_UnionUnion
			{
				Type = IGiantAnimDataType_Union.IGiantSpecialAnimData,
				Value = _igiantspecialanimdata
			};
		}

		// Token: 0x0602B79A RID: 178074 RVA: 0x005EC248 File Offset: 0x005EA448
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
