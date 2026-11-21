using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006286 RID: 25222
	public class TModelTypeUnion
	{
		// Token: 0x1700BB70 RID: 47984
		// (get) Token: 0x0602AE85 RID: 175749 RVA: 0x005DB154 File Offset: 0x005D9354
		// (set) Token: 0x0602AE86 RID: 175750 RVA: 0x005DB15C File Offset: 0x005D935C
		public TModelType Type { get; set; }

		// Token: 0x1700BB71 RID: 47985
		// (get) Token: 0x0602AE87 RID: 175751 RVA: 0x005DB165 File Offset: 0x005D9365
		// (set) Token: 0x0602AE88 RID: 175752 RVA: 0x005DB16D File Offset: 0x005D936D
		public object Value { get; set; }

		// Token: 0x0602AE89 RID: 175753 RVA: 0x005DB176 File Offset: 0x005D9376
		public TModelTypeUnion()
		{
			this.Type = TModelType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE8A RID: 175754 RVA: 0x005DB18C File Offset: 0x005D938C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE8B RID: 175755 RVA: 0x005DB19E File Offset: 0x005D939E
		public IAnimalModelT AsIAnimalModel()
		{
			return this.As<IAnimalModelT>();
		}

		// Token: 0x0602AE8C RID: 175756 RVA: 0x005DB1A6 File Offset: 0x005D93A6
		public static TModelTypeUnion FromIAnimalModel(IAnimalModelT _ianimalmodel)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.IAnimalModel,
				Value = _ianimalmodel
			};
		}

		// Token: 0x0602AE8D RID: 175757 RVA: 0x005DB1BB File Offset: 0x005D93BB
		public ILevelPrefabT AsILevelPrefab()
		{
			return this.As<ILevelPrefabT>();
		}

		// Token: 0x0602AE8E RID: 175758 RVA: 0x005DB1C3 File Offset: 0x005D93C3
		public static TModelTypeUnion FromILevelPrefab(ILevelPrefabT _ilevelprefab)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.ILevelPrefab,
				Value = _ilevelprefab
			};
		}

		// Token: 0x0602AE8F RID: 175759 RVA: 0x005DB1D8 File Offset: 0x005D93D8
		public IModelIdT AsIModelId()
		{
			return this.As<IModelIdT>();
		}

		// Token: 0x0602AE90 RID: 175760 RVA: 0x005DB1E0 File Offset: 0x005D93E0
		public static TModelTypeUnion FromIModelId(IModelIdT _imodelid)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.IModelId,
				Value = _imodelid
			};
		}

		// Token: 0x0602AE91 RID: 175761 RVA: 0x005DB1F5 File Offset: 0x005D93F5
		public INpcModelT AsINpcModel()
		{
			return this.As<INpcModelT>();
		}

		// Token: 0x0602AE92 RID: 175762 RVA: 0x005DB1FD File Offset: 0x005D93FD
		public static TModelTypeUnion FromINpcModel(INpcModelT _inpcmodel)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.INpcModel,
				Value = _inpcmodel
			};
		}

		// Token: 0x0602AE93 RID: 175763 RVA: 0x005DB214 File Offset: 0x005D9414
		public static int Pack(FlatBufferBuilder builder, TModelTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TModelType.IAnimalModel:
				return IAnimalModel.Pack(builder, _o.AsIAnimalModel()).Value;
			case TModelType.ILevelPrefab:
				return ILevelPrefab.Pack(builder, _o.AsILevelPrefab()).Value;
			case TModelType.IModelId:
				return IModelId.Pack(builder, _o.AsIModelId()).Value;
			case TModelType.INpcModel:
				return INpcModel.Pack(builder, _o.AsINpcModel()).Value;
			default:
				return 0;
			}
		}
	}
}
