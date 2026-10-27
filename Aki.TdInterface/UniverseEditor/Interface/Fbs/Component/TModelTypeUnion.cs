using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C61 RID: 23649
	public class TModelTypeUnion
	{
		// Token: 0x1700B21E RID: 45598
		// (get) Token: 0x06028875 RID: 166005 RVA: 0x00592EEE File Offset: 0x005910EE
		// (set) Token: 0x06028876 RID: 166006 RVA: 0x00592EF6 File Offset: 0x005910F6
		public TModelType Type { get; set; }

		// Token: 0x1700B21F RID: 45599
		// (get) Token: 0x06028877 RID: 166007 RVA: 0x00592EFF File Offset: 0x005910FF
		// (set) Token: 0x06028878 RID: 166008 RVA: 0x00592F07 File Offset: 0x00591107
		public object Value { get; set; }

		// Token: 0x06028879 RID: 166009 RVA: 0x00592F10 File Offset: 0x00591110
		public TModelTypeUnion()
		{
			this.Type = TModelType.NONE;
			this.Value = null;
		}

		// Token: 0x0602887A RID: 166010 RVA: 0x00592F26 File Offset: 0x00591126
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602887B RID: 166011 RVA: 0x00592F38 File Offset: 0x00591138
		public IAnimalModelT AsIAnimalModel()
		{
			return this.As<IAnimalModelT>();
		}

		// Token: 0x0602887C RID: 166012 RVA: 0x00592F40 File Offset: 0x00591140
		public static TModelTypeUnion FromIAnimalModel(IAnimalModelT _ianimalmodel)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.IAnimalModel,
				Value = _ianimalmodel
			};
		}

		// Token: 0x0602887D RID: 166013 RVA: 0x00592F55 File Offset: 0x00591155
		public ILevelPrefabT AsILevelPrefab()
		{
			return this.As<ILevelPrefabT>();
		}

		// Token: 0x0602887E RID: 166014 RVA: 0x00592F5D File Offset: 0x0059115D
		public static TModelTypeUnion FromILevelPrefab(ILevelPrefabT _ilevelprefab)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.ILevelPrefab,
				Value = _ilevelprefab
			};
		}

		// Token: 0x0602887F RID: 166015 RVA: 0x00592F72 File Offset: 0x00591172
		public IModelIdT AsIModelId()
		{
			return this.As<IModelIdT>();
		}

		// Token: 0x06028880 RID: 166016 RVA: 0x00592F7A File Offset: 0x0059117A
		public static TModelTypeUnion FromIModelId(IModelIdT _imodelid)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.IModelId,
				Value = _imodelid
			};
		}

		// Token: 0x06028881 RID: 166017 RVA: 0x00592F8F File Offset: 0x0059118F
		public INpcModelT AsINpcModel()
		{
			return this.As<INpcModelT>();
		}

		// Token: 0x06028882 RID: 166018 RVA: 0x00592F97 File Offset: 0x00591197
		public static TModelTypeUnion FromINpcModel(INpcModelT _inpcmodel)
		{
			return new TModelTypeUnion
			{
				Type = TModelType.INpcModel,
				Value = _inpcmodel
			};
		}

		// Token: 0x06028883 RID: 166019 RVA: 0x00592FAC File Offset: 0x005911AC
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
