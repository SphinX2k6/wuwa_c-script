using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005561 RID: 21857
	public class IModelConfig_UnionUnion
	{
		// Token: 0x1700A175 RID: 41333
		// (get) Token: 0x06024261 RID: 148065 RVA: 0x004FE4C1 File Offset: 0x004FC6C1
		// (set) Token: 0x06024262 RID: 148066 RVA: 0x004FE4C9 File Offset: 0x004FC6C9
		public IModelConfig_Union Type { get; set; }

		// Token: 0x1700A176 RID: 41334
		// (get) Token: 0x06024263 RID: 148067 RVA: 0x004FE4D2 File Offset: 0x004FC6D2
		// (set) Token: 0x06024264 RID: 148068 RVA: 0x004FE4DA File Offset: 0x004FC6DA
		public object Value { get; set; }

		// Token: 0x06024265 RID: 148069 RVA: 0x004FE4E3 File Offset: 0x004FC6E3
		public IModelConfig_UnionUnion()
		{
			this.Type = IModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024266 RID: 148070 RVA: 0x004FE4F9 File Offset: 0x004FC6F9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024267 RID: 148071 RVA: 0x004FE50B File Offset: 0x004FC70B
		public IModelConfigT AsIModelConfig()
		{
			return this.As<IModelConfigT>();
		}

		// Token: 0x06024268 RID: 148072 RVA: 0x004FE513 File Offset: 0x004FC713
		public static IModelConfig_UnionUnion FromIModelConfig(IModelConfigT _imodelconfig)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IModelConfig,
				Value = _imodelconfig
			};
		}

		// Token: 0x06024269 RID: 148073 RVA: 0x004FE528 File Offset: 0x004FC728
		public ILevelPrefabT AsILevelPrefab()
		{
			return this.As<ILevelPrefabT>();
		}

		// Token: 0x0602426A RID: 148074 RVA: 0x004FE530 File Offset: 0x004FC730
		public static IModelConfig_UnionUnion FromILevelPrefab(ILevelPrefabT _ilevelprefab)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.ILevelPrefab,
				Value = _ilevelprefab
			};
		}

		// Token: 0x0602426B RID: 148075 RVA: 0x004FE545 File Offset: 0x004FC745
		public IModelIdT AsIModelId()
		{
			return this.As<IModelIdT>();
		}

		// Token: 0x0602426C RID: 148076 RVA: 0x004FE54D File Offset: 0x004FC74D
		public static IModelConfig_UnionUnion FromIModelId(IModelIdT _imodelid)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IModelId,
				Value = _imodelid
			};
		}

		// Token: 0x0602426D RID: 148077 RVA: 0x004FE562 File Offset: 0x004FC762
		public INpcModelT AsINpcModel()
		{
			return this.As<INpcModelT>();
		}

		// Token: 0x0602426E RID: 148078 RVA: 0x004FE56A File Offset: 0x004FC76A
		public static IModelConfig_UnionUnion FromINpcModel(INpcModelT _inpcmodel)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.INpcModel,
				Value = _inpcmodel
			};
		}

		// Token: 0x0602426F RID: 148079 RVA: 0x004FE57F File Offset: 0x004FC77F
		public IAnimalModelT AsIAnimalModel()
		{
			return this.As<IAnimalModelT>();
		}

		// Token: 0x06024270 RID: 148080 RVA: 0x004FE587 File Offset: 0x004FC787
		public static IModelConfig_UnionUnion FromIAnimalModel(IAnimalModelT _ianimalmodel)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IAnimalModel,
				Value = _ianimalmodel
			};
		}

		// Token: 0x06024271 RID: 148081 RVA: 0x004FE59C File Offset: 0x004FC79C
		public static int Pack(FlatBufferBuilder builder, IModelConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IModelConfig_Union.IModelConfig:
				return IModelConfig.Pack(builder, _o.AsIModelConfig()).Value;
			case IModelConfig_Union.ILevelPrefab:
				return ILevelPrefab.Pack(builder, _o.AsILevelPrefab()).Value;
			case IModelConfig_Union.IModelId:
				return IModelId.Pack(builder, _o.AsIModelId()).Value;
			case IModelConfig_Union.INpcModel:
				return INpcModel.Pack(builder, _o.AsINpcModel()).Value;
			case IModelConfig_Union.IAnimalModel:
				return IAnimalModel.Pack(builder, _o.AsIAnimalModel()).Value;
			default:
				return 0;
			}
		}
	}
}
