using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562D RID: 22061
	public class INpcModelConfig_UnionUnion
	{
		// Token: 0x1700A344 RID: 41796
		// (get) Token: 0x06024A0B RID: 150027 RVA: 0x0050D971 File Offset: 0x0050BB71
		// (set) Token: 0x06024A0C RID: 150028 RVA: 0x0050D979 File Offset: 0x0050BB79
		public INpcModelConfig_Union Type { get; set; }

		// Token: 0x1700A345 RID: 41797
		// (get) Token: 0x06024A0D RID: 150029 RVA: 0x0050D982 File Offset: 0x0050BB82
		// (set) Token: 0x06024A0E RID: 150030 RVA: 0x0050D98A File Offset: 0x0050BB8A
		public object Value { get; set; }

		// Token: 0x06024A0F RID: 150031 RVA: 0x0050D993 File Offset: 0x0050BB93
		public INpcModelConfig_UnionUnion()
		{
			this.Type = INpcModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024A10 RID: 150032 RVA: 0x0050D9A9 File Offset: 0x0050BBA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024A11 RID: 150033 RVA: 0x0050D9BB File Offset: 0x0050BBBB
		public INpcModelConfigT AsINpcModelConfig()
		{
			return this.As<INpcModelConfigT>();
		}

		// Token: 0x06024A12 RID: 150034 RVA: 0x0050D9C3 File Offset: 0x0050BBC3
		public static INpcModelConfig_UnionUnion FromINpcModelConfig(INpcModelConfigT _inpcmodelconfig)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.INpcModelConfig,
				Value = _inpcmodelconfig
			};
		}

		// Token: 0x06024A13 RID: 150035 RVA: 0x0050D9D8 File Offset: 0x0050BBD8
		public IMeshNpcModelT AsIMeshNpcModel()
		{
			return this.As<IMeshNpcModelT>();
		}

		// Token: 0x06024A14 RID: 150036 RVA: 0x0050D9E0 File Offset: 0x0050BBE0
		public static INpcModelConfig_UnionUnion FromIMeshNpcModel(IMeshNpcModelT _imeshnpcmodel)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.IMeshNpcModel,
				Value = _imeshnpcmodel
			};
		}

		// Token: 0x06024A15 RID: 150037 RVA: 0x0050D9F5 File Offset: 0x0050BBF5
		public IDaNpcModelT AsIDaNpcModel()
		{
			return this.As<IDaNpcModelT>();
		}

		// Token: 0x06024A16 RID: 150038 RVA: 0x0050D9FD File Offset: 0x0050BBFD
		public static INpcModelConfig_UnionUnion FromIDaNpcModel(IDaNpcModelT _idanpcmodel)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.IDaNpcModel,
				Value = _idanpcmodel
			};
		}

		// Token: 0x06024A17 RID: 150039 RVA: 0x0050DA14 File Offset: 0x0050BC14
		public static int Pack(FlatBufferBuilder builder, INpcModelConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcModelConfig_Union.INpcModelConfig:
				return INpcModelConfig.Pack(builder, _o.AsINpcModelConfig()).Value;
			case INpcModelConfig_Union.IMeshNpcModel:
				return IMeshNpcModel.Pack(builder, _o.AsIMeshNpcModel()).Value;
			case INpcModelConfig_Union.IDaNpcModel:
				return IDaNpcModel.Pack(builder, _o.AsIDaNpcModel()).Value;
			default:
				return 0;
			}
		}
	}
}
