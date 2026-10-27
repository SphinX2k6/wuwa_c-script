using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB1 RID: 20145
	public class IAnimalModelConfig_UnionUnion
	{
		// Token: 0x17009086 RID: 36998
		// (get) Token: 0x0601FB8A RID: 129930 RVA: 0x0046A9B9 File Offset: 0x00468BB9
		// (set) Token: 0x0601FB8B RID: 129931 RVA: 0x0046A9C1 File Offset: 0x00468BC1
		public IAnimalModelConfig_Union Type { get; set; }

		// Token: 0x17009087 RID: 36999
		// (get) Token: 0x0601FB8C RID: 129932 RVA: 0x0046A9CA File Offset: 0x00468BCA
		// (set) Token: 0x0601FB8D RID: 129933 RVA: 0x0046A9D2 File Offset: 0x00468BD2
		public object Value { get; set; }

		// Token: 0x0601FB8E RID: 129934 RVA: 0x0046A9DB File Offset: 0x00468BDB
		public IAnimalModelConfig_UnionUnion()
		{
			this.Type = IAnimalModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FB8F RID: 129935 RVA: 0x0046A9F1 File Offset: 0x00468BF1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FB90 RID: 129936 RVA: 0x0046AA03 File Offset: 0x00468C03
		public IAnimalModelConfigT AsIAnimalModelConfig()
		{
			return this.As<IAnimalModelConfigT>();
		}

		// Token: 0x0601FB91 RID: 129937 RVA: 0x0046AA0B File Offset: 0x00468C0B
		public static IAnimalModelConfig_UnionUnion FromIAnimalModelConfig(IAnimalModelConfigT _ianimalmodelconfig)
		{
			return new IAnimalModelConfig_UnionUnion
			{
				Type = IAnimalModelConfig_Union.IAnimalModelConfig,
				Value = _ianimalmodelconfig
			};
		}

		// Token: 0x0601FB92 RID: 129938 RVA: 0x0046AA20 File Offset: 0x00468C20
		public IMeshAnimalModelT AsIMeshAnimalModel()
		{
			return this.As<IMeshAnimalModelT>();
		}

		// Token: 0x0601FB93 RID: 129939 RVA: 0x0046AA28 File Offset: 0x00468C28
		public static IAnimalModelConfig_UnionUnion FromIMeshAnimalModel(IMeshAnimalModelT _imeshanimalmodel)
		{
			return new IAnimalModelConfig_UnionUnion
			{
				Type = IAnimalModelConfig_Union.IMeshAnimalModel,
				Value = _imeshanimalmodel
			};
		}

		// Token: 0x0601FB94 RID: 129940 RVA: 0x0046AA40 File Offset: 0x00468C40
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
