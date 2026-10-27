using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578E RID: 22414
	public class IProceduralMaterialType_UnionUnion
	{
		// Token: 0x1700A72C RID: 42796
		// (get) Token: 0x06025939 RID: 153913 RVA: 0x0052EDC1 File Offset: 0x0052CFC1
		// (set) Token: 0x0602593A RID: 153914 RVA: 0x0052EDC9 File Offset: 0x0052CFC9
		public IProceduralMaterialType_Union Type { get; set; }

		// Token: 0x1700A72D RID: 42797
		// (get) Token: 0x0602593B RID: 153915 RVA: 0x0052EDD2 File Offset: 0x0052CFD2
		// (set) Token: 0x0602593C RID: 153916 RVA: 0x0052EDDA File Offset: 0x0052CFDA
		public object Value { get; set; }

		// Token: 0x0602593D RID: 153917 RVA: 0x0052EDE3 File Offset: 0x0052CFE3
		public IProceduralMaterialType_UnionUnion()
		{
			this.Type = IProceduralMaterialType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602593E RID: 153918 RVA: 0x0052EDF9 File Offset: 0x0052CFF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602593F RID: 153919 RVA: 0x0052EE0B File Offset: 0x0052D00B
		public IProceduralMaterialTypeT AsIProceduralMaterialType()
		{
			return this.As<IProceduralMaterialTypeT>();
		}

		// Token: 0x06025940 RID: 153920 RVA: 0x0052EE13 File Offset: 0x0052D013
		public static IProceduralMaterialType_UnionUnion FromIProceduralMaterialType(IProceduralMaterialTypeT _iproceduralmaterialtype)
		{
			return new IProceduralMaterialType_UnionUnion
			{
				Type = IProceduralMaterialType_Union.IProceduralMaterialType,
				Value = _iproceduralmaterialtype
			};
		}

		// Token: 0x06025941 RID: 153921 RVA: 0x0052EE28 File Offset: 0x0052D028
		public ICustomPrimitiveDataConfigT AsICustomPrimitiveDataConfig()
		{
			return this.As<ICustomPrimitiveDataConfigT>();
		}

		// Token: 0x06025942 RID: 153922 RVA: 0x0052EE30 File Offset: 0x0052D030
		public static IProceduralMaterialType_UnionUnion FromICustomPrimitiveDataConfig(ICustomPrimitiveDataConfigT _icustomprimitivedataconfig)
		{
			return new IProceduralMaterialType_UnionUnion
			{
				Type = IProceduralMaterialType_Union.ICustomPrimitiveDataConfig,
				Value = _icustomprimitivedataconfig
			};
		}

		// Token: 0x06025943 RID: 153923 RVA: 0x0052EE48 File Offset: 0x0052D048
		public static int Pack(FlatBufferBuilder builder, IProceduralMaterialType_UnionUnion _o)
		{
			IProceduralMaterialType_Union type = _o.Type;
			if (type == IProceduralMaterialType_Union.IProceduralMaterialType)
			{
				return IProceduralMaterialType.Pack(builder, _o.AsIProceduralMaterialType()).Value;
			}
			if (type != IProceduralMaterialType_Union.ICustomPrimitiveDataConfig)
			{
				return 0;
			}
			return ICustomPrimitiveDataConfig.Pack(builder, _o.AsICustomPrimitiveDataConfig()).Value;
		}
	}
}
