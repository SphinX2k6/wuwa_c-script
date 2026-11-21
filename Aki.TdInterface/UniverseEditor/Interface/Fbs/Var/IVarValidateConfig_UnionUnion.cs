using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F26 RID: 16166
	public class IVarValidateConfig_UnionUnion
	{
		// Token: 0x17006D73 RID: 28019
		// (get) Token: 0x06015F61 RID: 89953 RVA: 0x00328095 File Offset: 0x00326295
		// (set) Token: 0x06015F62 RID: 89954 RVA: 0x0032809D File Offset: 0x0032629D
		public IVarValidateConfig_Union Type { get; set; }

		// Token: 0x17006D74 RID: 28020
		// (get) Token: 0x06015F63 RID: 89955 RVA: 0x003280A6 File Offset: 0x003262A6
		// (set) Token: 0x06015F64 RID: 89956 RVA: 0x003280AE File Offset: 0x003262AE
		public object Value { get; set; }

		// Token: 0x06015F65 RID: 89957 RVA: 0x003280B7 File Offset: 0x003262B7
		public IVarValidateConfig_UnionUnion()
		{
			this.Type = IVarValidateConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015F66 RID: 89958 RVA: 0x003280CD File Offset: 0x003262CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015F67 RID: 89959 RVA: 0x003280DF File Offset: 0x003262DF
		public IVarValidateConfigT AsIVarValidateConfig()
		{
			return this.As<IVarValidateConfigT>();
		}

		// Token: 0x06015F68 RID: 89960 RVA: 0x003280E7 File Offset: 0x003262E7
		public static IVarValidateConfig_UnionUnion FromIVarValidateConfig(IVarValidateConfigT _ivarvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarValidateConfig,
				Value = _ivarvalidateconfig
			};
		}

		// Token: 0x06015F69 RID: 89961 RVA: 0x003280FC File Offset: 0x003262FC
		public IVarIntValidateConfigT AsIVarIntValidateConfig()
		{
			return this.As<IVarIntValidateConfigT>();
		}

		// Token: 0x06015F6A RID: 89962 RVA: 0x00328104 File Offset: 0x00326304
		public static IVarValidateConfig_UnionUnion FromIVarIntValidateConfig(IVarIntValidateConfigT _ivarintvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarIntValidateConfig,
				Value = _ivarintvalidateconfig
			};
		}

		// Token: 0x06015F6B RID: 89963 RVA: 0x00328119 File Offset: 0x00326319
		public IVarFloatValidateConfigT AsIVarFloatValidateConfig()
		{
			return this.As<IVarFloatValidateConfigT>();
		}

		// Token: 0x06015F6C RID: 89964 RVA: 0x00328121 File Offset: 0x00326321
		public static IVarValidateConfig_UnionUnion FromIVarFloatValidateConfig(IVarFloatValidateConfigT _ivarfloatvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarFloatValidateConfig,
				Value = _ivarfloatvalidateconfig
			};
		}

		// Token: 0x06015F6D RID: 89965 RVA: 0x00328136 File Offset: 0x00326336
		public IVarStringValidateConfigT AsIVarStringValidateConfig()
		{
			return this.As<IVarStringValidateConfigT>();
		}

		// Token: 0x06015F6E RID: 89966 RVA: 0x0032813E File Offset: 0x0032633E
		public static IVarValidateConfig_UnionUnion FromIVarStringValidateConfig(IVarStringValidateConfigT _ivarstringvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarStringValidateConfig,
				Value = _ivarstringvalidateconfig
			};
		}

		// Token: 0x06015F6F RID: 89967 RVA: 0x00328153 File Offset: 0x00326353
		public IVarBooleanValidateConfigT AsIVarBooleanValidateConfig()
		{
			return this.As<IVarBooleanValidateConfigT>();
		}

		// Token: 0x06015F70 RID: 89968 RVA: 0x0032815B File Offset: 0x0032635B
		public static IVarValidateConfig_UnionUnion FromIVarBooleanValidateConfig(IVarBooleanValidateConfigT _ivarbooleanvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarBooleanValidateConfig,
				Value = _ivarbooleanvalidateconfig
			};
		}

		// Token: 0x06015F71 RID: 89969 RVA: 0x00328170 File Offset: 0x00326370
		public IVarEntityValidateConfigT AsIVarEntityValidateConfig()
		{
			return this.As<IVarEntityValidateConfigT>();
		}

		// Token: 0x06015F72 RID: 89970 RVA: 0x00328178 File Offset: 0x00326378
		public static IVarValidateConfig_UnionUnion FromIVarEntityValidateConfig(IVarEntityValidateConfigT _ivarentityvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarEntityValidateConfig,
				Value = _ivarentityvalidateconfig
			};
		}

		// Token: 0x06015F73 RID: 89971 RVA: 0x0032818D File Offset: 0x0032638D
		public IVarQuestValidateConfigT AsIVarQuestValidateConfig()
		{
			return this.As<IVarQuestValidateConfigT>();
		}

		// Token: 0x06015F74 RID: 89972 RVA: 0x00328195 File Offset: 0x00326395
		public static IVarValidateConfig_UnionUnion FromIVarQuestValidateConfig(IVarQuestValidateConfigT _ivarquestvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarQuestValidateConfig,
				Value = _ivarquestvalidateconfig
			};
		}

		// Token: 0x06015F75 RID: 89973 RVA: 0x003281AA File Offset: 0x003263AA
		public IVarQuestStateValidateConfigT AsIVarQuestStateValidateConfig()
		{
			return this.As<IVarQuestStateValidateConfigT>();
		}

		// Token: 0x06015F76 RID: 89974 RVA: 0x003281B2 File Offset: 0x003263B2
		public static IVarValidateConfig_UnionUnion FromIVarQuestStateValidateConfig(IVarQuestStateValidateConfigT _ivarqueststatevalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarQuestStateValidateConfig,
				Value = _ivarqueststatevalidateconfig
			};
		}

		// Token: 0x06015F77 RID: 89975 RVA: 0x003281C7 File Offset: 0x003263C7
		public IVarTransformValidateConfigT AsIVarTransformValidateConfig()
		{
			return this.As<IVarTransformValidateConfigT>();
		}

		// Token: 0x06015F78 RID: 89976 RVA: 0x003281CF File Offset: 0x003263CF
		public static IVarValidateConfig_UnionUnion FromIVarTransformValidateConfig(IVarTransformValidateConfigT _ivartransformvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarTransformValidateConfig,
				Value = _ivartransformvalidateconfig
			};
		}

		// Token: 0x06015F79 RID: 89977 RVA: 0x003281E5 File Offset: 0x003263E5
		public IVarPrefabValidateConfigT AsIVarPrefabValidateConfig()
		{
			return this.As<IVarPrefabValidateConfigT>();
		}

		// Token: 0x06015F7A RID: 89978 RVA: 0x003281ED File Offset: 0x003263ED
		public static IVarValidateConfig_UnionUnion FromIVarPrefabValidateConfig(IVarPrefabValidateConfigT _ivarprefabvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarPrefabValidateConfig,
				Value = _ivarprefabvalidateconfig
			};
		}

		// Token: 0x06015F7B RID: 89979 RVA: 0x00328204 File Offset: 0x00326404
		public static int Pack(FlatBufferBuilder builder, IVarValidateConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVarValidateConfig_Union.IVarValidateConfig:
				return IVarValidateConfig.Pack(builder, _o.AsIVarValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarIntValidateConfig:
				return IVarIntValidateConfig.Pack(builder, _o.AsIVarIntValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarFloatValidateConfig:
				return IVarFloatValidateConfig.Pack(builder, _o.AsIVarFloatValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarStringValidateConfig:
				return IVarStringValidateConfig.Pack(builder, _o.AsIVarStringValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarBooleanValidateConfig:
				return IVarBooleanValidateConfig.Pack(builder, _o.AsIVarBooleanValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarEntityValidateConfig:
				return IVarEntityValidateConfig.Pack(builder, _o.AsIVarEntityValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarQuestValidateConfig:
				return IVarQuestValidateConfig.Pack(builder, _o.AsIVarQuestValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarQuestStateValidateConfig:
				return IVarQuestStateValidateConfig.Pack(builder, _o.AsIVarQuestStateValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarTransformValidateConfig:
				return IVarTransformValidateConfig.Pack(builder, _o.AsIVarTransformValidateConfig()).Value;
			case IVarValidateConfig_Union.IVarPrefabValidateConfig:
				return IVarPrefabValidateConfig.Pack(builder, _o.AsIVarPrefabValidateConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
