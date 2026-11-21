using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D95 RID: 23957
	public class IProceduralMaterialType_UnionUnion
	{
		// Token: 0x1700B050 RID: 45136
		// (get) Token: 0x06027E59 RID: 163417 RVA: 0x00574F4D File Offset: 0x0057314D
		// (set) Token: 0x06027E5A RID: 163418 RVA: 0x00574F55 File Offset: 0x00573155
		public IProceduralMaterialType_Union Type { get; set; }

		// Token: 0x1700B051 RID: 45137
		// (get) Token: 0x06027E5B RID: 163419 RVA: 0x00574F5E File Offset: 0x0057315E
		// (set) Token: 0x06027E5C RID: 163420 RVA: 0x00574F66 File Offset: 0x00573166
		public object Value { get; set; }

		// Token: 0x06027E5D RID: 163421 RVA: 0x00574F6F File Offset: 0x0057316F
		public IProceduralMaterialType_UnionUnion()
		{
			this.Type = IProceduralMaterialType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027E5E RID: 163422 RVA: 0x00574F85 File Offset: 0x00573185
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027E5F RID: 163423 RVA: 0x00574F97 File Offset: 0x00573197
		public IProceduralMaterialTypeT AsIProceduralMaterialType()
		{
			return this.As<IProceduralMaterialTypeT>();
		}

		// Token: 0x06027E60 RID: 163424 RVA: 0x00574F9F File Offset: 0x0057319F
		public static IProceduralMaterialType_UnionUnion FromIProceduralMaterialType(IProceduralMaterialTypeT _iproceduralmaterialtype)
		{
			return new IProceduralMaterialType_UnionUnion
			{
				Type = IProceduralMaterialType_Union.IProceduralMaterialType,
				Value = _iproceduralmaterialtype
			};
		}

		// Token: 0x06027E61 RID: 163425 RVA: 0x00574FB4 File Offset: 0x005731B4
		public ICustomPrimitiveDataConfigT AsICustomPrimitiveDataConfig()
		{
			return this.As<ICustomPrimitiveDataConfigT>();
		}

		// Token: 0x06027E62 RID: 163426 RVA: 0x00574FBC File Offset: 0x005731BC
		public static IProceduralMaterialType_UnionUnion FromICustomPrimitiveDataConfig(ICustomPrimitiveDataConfigT _icustomprimitivedataconfig)
		{
			return new IProceduralMaterialType_UnionUnion
			{
				Type = IProceduralMaterialType_Union.ICustomPrimitiveDataConfig,
				Value = _icustomprimitivedataconfig
			};
		}

		// Token: 0x06027E63 RID: 163427 RVA: 0x00574FD4 File Offset: 0x005731D4
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
