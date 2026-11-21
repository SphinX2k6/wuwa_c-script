using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DA RID: 21466
	public class IAnimalModelConfig_UnionUnion
	{
		// Token: 0x170097E7 RID: 38887
		// (get) Token: 0x0602188B RID: 137355 RVA: 0x0049FE35 File Offset: 0x0049E035
		// (set) Token: 0x0602188C RID: 137356 RVA: 0x0049FE3D File Offset: 0x0049E03D
		public IAnimalModelConfig_Union Type { get; set; }

		// Token: 0x170097E8 RID: 38888
		// (get) Token: 0x0602188D RID: 137357 RVA: 0x0049FE46 File Offset: 0x0049E046
		// (set) Token: 0x0602188E RID: 137358 RVA: 0x0049FE4E File Offset: 0x0049E04E
		public object Value { get; set; }

		// Token: 0x0602188F RID: 137359 RVA: 0x0049FE57 File Offset: 0x0049E057
		public IAnimalModelConfig_UnionUnion()
		{
			this.Type = IAnimalModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021890 RID: 137360 RVA: 0x0049FE6D File Offset: 0x0049E06D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021891 RID: 137361 RVA: 0x0049FE7F File Offset: 0x0049E07F
		public IAnimalModelConfigT AsIAnimalModelConfig()
		{
			return this.As<IAnimalModelConfigT>();
		}

		// Token: 0x06021892 RID: 137362 RVA: 0x0049FE87 File Offset: 0x0049E087
		public static IAnimalModelConfig_UnionUnion FromIAnimalModelConfig(IAnimalModelConfigT _ianimalmodelconfig)
		{
			return new IAnimalModelConfig_UnionUnion
			{
				Type = IAnimalModelConfig_Union.IAnimalModelConfig,
				Value = _ianimalmodelconfig
			};
		}

		// Token: 0x06021893 RID: 137363 RVA: 0x0049FE9C File Offset: 0x0049E09C
		public IMeshAnimalModelT AsIMeshAnimalModel()
		{
			return this.As<IMeshAnimalModelT>();
		}

		// Token: 0x06021894 RID: 137364 RVA: 0x0049FEA4 File Offset: 0x0049E0A4
		public static IAnimalModelConfig_UnionUnion FromIMeshAnimalModel(IMeshAnimalModelT _imeshanimalmodel)
		{
			return new IAnimalModelConfig_UnionUnion
			{
				Type = IAnimalModelConfig_Union.IMeshAnimalModel,
				Value = _imeshanimalmodel
			};
		}

		// Token: 0x06021895 RID: 137365 RVA: 0x0049FEBC File Offset: 0x0049E0BC
		public static int Pack(FlatBufferBuilder builder, IAnimalModelConfig_UnionUnion _o)
		{
			IAnimalModelConfig_Union type = _o.Type;
			if (type == IAnimalModelConfig_Union.IAnimalModelConfig)
			{
				return IAnimalModelConfig.Pack(builder, _o.AsIAnimalModelConfig()).Value;
			}
			if (type != IAnimalModelConfig_Union.IMeshAnimalModel)
			{
				return 0;
			}
			return IMeshAnimalModel.Pack(builder, _o.AsIMeshAnimalModel()).Value;
		}
	}
}
