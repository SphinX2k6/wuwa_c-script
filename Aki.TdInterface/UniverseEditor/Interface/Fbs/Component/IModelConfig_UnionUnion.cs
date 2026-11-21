using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF3 RID: 23283
	public class IModelConfig_UnionUnion
	{
		// Token: 0x1700A9EB RID: 43499
		// (get) Token: 0x06026406 RID: 156678 RVA: 0x0053DD85 File Offset: 0x0053BF85
		// (set) Token: 0x06026407 RID: 156679 RVA: 0x0053DD8D File Offset: 0x0053BF8D
		public IModelConfig_Union Type { get; set; }

		// Token: 0x1700A9EC RID: 43500
		// (get) Token: 0x06026408 RID: 156680 RVA: 0x0053DD96 File Offset: 0x0053BF96
		// (set) Token: 0x06026409 RID: 156681 RVA: 0x0053DD9E File Offset: 0x0053BF9E
		public object Value { get; set; }

		// Token: 0x0602640A RID: 156682 RVA: 0x0053DDA7 File Offset: 0x0053BFA7
		public IModelConfig_UnionUnion()
		{
			this.Type = IModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602640B RID: 156683 RVA: 0x0053DDBD File Offset: 0x0053BFBD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602640C RID: 156684 RVA: 0x0053DDCF File Offset: 0x0053BFCF
		public IModelConfigT AsIModelConfig()
		{
			return this.As<IModelConfigT>();
		}

		// Token: 0x0602640D RID: 156685 RVA: 0x0053DDD7 File Offset: 0x0053BFD7
		public static IModelConfig_UnionUnion FromIModelConfig(IModelConfigT _imodelconfig)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IModelConfig,
				Value = _imodelconfig
			};
		}

		// Token: 0x0602640E RID: 156686 RVA: 0x0053DDEC File Offset: 0x0053BFEC
		public ILevelPrefabT AsILevelPrefab()
		{
			return this.As<ILevelPrefabT>();
		}

		// Token: 0x0602640F RID: 156687 RVA: 0x0053DDF4 File Offset: 0x0053BFF4
		public static IModelConfig_UnionUnion FromILevelPrefab(ILevelPrefabT _ilevelprefab)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.ILevelPrefab,
				Value = _ilevelprefab
			};
		}

		// Token: 0x06026410 RID: 156688 RVA: 0x0053DE09 File Offset: 0x0053C009
		public IModelIdT AsIModelId()
		{
			return this.As<IModelIdT>();
		}

		// Token: 0x06026411 RID: 156689 RVA: 0x0053DE11 File Offset: 0x0053C011
		public static IModelConfig_UnionUnion FromIModelId(IModelIdT _imodelid)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IModelId,
				Value = _imodelid
			};
		}

		// Token: 0x06026412 RID: 156690 RVA: 0x0053DE26 File Offset: 0x0053C026
		public INpcModelT AsINpcModel()
		{
			return this.As<INpcModelT>();
		}

		// Token: 0x06026413 RID: 156691 RVA: 0x0053DE2E File Offset: 0x0053C02E
		public static IModelConfig_UnionUnion FromINpcModel(INpcModelT _inpcmodel)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.INpcModel,
				Value = _inpcmodel
			};
		}

		// Token: 0x06026414 RID: 156692 RVA: 0x0053DE43 File Offset: 0x0053C043
		public IAnimalModelT AsIAnimalModel()
		{
			return this.As<IAnimalModelT>();
		}

		// Token: 0x06026415 RID: 156693 RVA: 0x0053DE4B File Offset: 0x0053C04B
		public static IModelConfig_UnionUnion FromIAnimalModel(IAnimalModelT _ianimalmodel)
		{
			return new IModelConfig_UnionUnion
			{
				Type = IModelConfig_Union.IAnimalModel,
				Value = _ianimalmodel
			};
		}

		// Token: 0x06026416 RID: 156694 RVA: 0x0053DE60 File Offset: 0x0053C060
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
