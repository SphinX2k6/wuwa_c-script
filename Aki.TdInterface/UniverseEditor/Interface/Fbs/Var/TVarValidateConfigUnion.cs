using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B63 RID: 15203
	public class TVarValidateConfigUnion
	{
		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x06014CB1 RID: 85169 RVA: 0x00305474 File Offset: 0x00303674
		// (set) Token: 0x06014CB2 RID: 85170 RVA: 0x0030547C File Offset: 0x0030367C
		public TVarValidateConfig Type { get; set; }

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x06014CB3 RID: 85171 RVA: 0x00305485 File Offset: 0x00303685
		// (set) Token: 0x06014CB4 RID: 85172 RVA: 0x0030548D File Offset: 0x0030368D
		public object Value { get; set; }

		// Token: 0x06014CB5 RID: 85173 RVA: 0x00305496 File Offset: 0x00303696
		public TVarValidateConfigUnion()
		{
			this.Type = TVarValidateConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06014CB6 RID: 85174 RVA: 0x003054AC File Offset: 0x003036AC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014CB7 RID: 85175 RVA: 0x003054BE File Offset: 0x003036BE
		public IVarBooleanValidateConfigT AsIVarBooleanValidateConfig()
		{
			return this.As<IVarBooleanValidateConfigT>();
		}

		// Token: 0x06014CB8 RID: 85176 RVA: 0x003054C6 File Offset: 0x003036C6
		public static TVarValidateConfigUnion FromIVarBooleanValidateConfig(IVarBooleanValidateConfigT _ivarbooleanvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarBooleanValidateConfig,
				Value = _ivarbooleanvalidateconfig
			};
		}

		// Token: 0x06014CB9 RID: 85177 RVA: 0x003054DB File Offset: 0x003036DB
		public IVarEntityValidateConfigT AsIVarEntityValidateConfig()
		{
			return this.As<IVarEntityValidateConfigT>();
		}

		// Token: 0x06014CBA RID: 85178 RVA: 0x003054E3 File Offset: 0x003036E3
		public static TVarValidateConfigUnion FromIVarEntityValidateConfig(IVarEntityValidateConfigT _ivarentityvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarEntityValidateConfig,
				Value = _ivarentityvalidateconfig
			};
		}

		// Token: 0x06014CBB RID: 85179 RVA: 0x003054F8 File Offset: 0x003036F8
		public IVarFloatValidateConfigT AsIVarFloatValidateConfig()
		{
			return this.As<IVarFloatValidateConfigT>();
		}

		// Token: 0x06014CBC RID: 85180 RVA: 0x00305500 File Offset: 0x00303700
		public static TVarValidateConfigUnion FromIVarFloatValidateConfig(IVarFloatValidateConfigT _ivarfloatvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarFloatValidateConfig,
				Value = _ivarfloatvalidateconfig
			};
		}

		// Token: 0x06014CBD RID: 85181 RVA: 0x00305515 File Offset: 0x00303715
		public IVarIntValidateConfigT AsIVarIntValidateConfig()
		{
			return this.As<IVarIntValidateConfigT>();
		}

		// Token: 0x06014CBE RID: 85182 RVA: 0x0030551D File Offset: 0x0030371D
		public static TVarValidateConfigUnion FromIVarIntValidateConfig(IVarIntValidateConfigT _ivarintvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarIntValidateConfig,
				Value = _ivarintvalidateconfig
			};
		}

		// Token: 0x06014CBF RID: 85183 RVA: 0x00305532 File Offset: 0x00303732
		public IVarPrefabValidateConfigT AsIVarPrefabValidateConfig()
		{
			return this.As<IVarPrefabValidateConfigT>();
		}

		// Token: 0x06014CC0 RID: 85184 RVA: 0x0030553A File Offset: 0x0030373A
		public static TVarValidateConfigUnion FromIVarPrefabValidateConfig(IVarPrefabValidateConfigT _ivarprefabvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarPrefabValidateConfig,
				Value = _ivarprefabvalidateconfig
			};
		}

		// Token: 0x06014CC1 RID: 85185 RVA: 0x0030554F File Offset: 0x0030374F
		public IVarQuestStateValidateConfigT AsIVarQuestStateValidateConfig()
		{
			return this.As<IVarQuestStateValidateConfigT>();
		}

		// Token: 0x06014CC2 RID: 85186 RVA: 0x00305557 File Offset: 0x00303757
		public static TVarValidateConfigUnion FromIVarQuestStateValidateConfig(IVarQuestStateValidateConfigT _ivarqueststatevalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarQuestStateValidateConfig,
				Value = _ivarqueststatevalidateconfig
			};
		}

		// Token: 0x06014CC3 RID: 85187 RVA: 0x0030556C File Offset: 0x0030376C
		public IVarQuestValidateConfigT AsIVarQuestValidateConfig()
		{
			return this.As<IVarQuestValidateConfigT>();
		}

		// Token: 0x06014CC4 RID: 85188 RVA: 0x00305574 File Offset: 0x00303774
		public static TVarValidateConfigUnion FromIVarQuestValidateConfig(IVarQuestValidateConfigT _ivarquestvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarQuestValidateConfig,
				Value = _ivarquestvalidateconfig
			};
		}

		// Token: 0x06014CC5 RID: 85189 RVA: 0x00305589 File Offset: 0x00303789
		public IVarStringValidateConfigT AsIVarStringValidateConfig()
		{
			return this.As<IVarStringValidateConfigT>();
		}

		// Token: 0x06014CC6 RID: 85190 RVA: 0x00305591 File Offset: 0x00303791
		public static TVarValidateConfigUnion FromIVarStringValidateConfig(IVarStringValidateConfigT _ivarstringvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarStringValidateConfig,
				Value = _ivarstringvalidateconfig
			};
		}

		// Token: 0x06014CC7 RID: 85191 RVA: 0x003055A6 File Offset: 0x003037A6
		public IVarTransformValidateConfigT AsIVarTransformValidateConfig()
		{
			return this.As<IVarTransformValidateConfigT>();
		}

		// Token: 0x06014CC8 RID: 85192 RVA: 0x003055AE File Offset: 0x003037AE
		public static TVarValidateConfigUnion FromIVarTransformValidateConfig(IVarTransformValidateConfigT _ivartransformvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarTransformValidateConfig,
				Value = _ivartransformvalidateconfig
			};
		}

		// Token: 0x06014CC9 RID: 85193 RVA: 0x003055C4 File Offset: 0x003037C4
		public static int Pack(FlatBufferBuilder builder, TVarValidateConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TVarValidateConfig.IVarBooleanValidateConfig:
				return IVarBooleanValidateConfig.Pack(builder, _o.AsIVarBooleanValidateConfig()).Value;
			case TVarValidateConfig.IVarEntityValidateConfig:
				return IVarEntityValidateConfig.Pack(builder, _o.AsIVarEntityValidateConfig()).Value;
			case TVarValidateConfig.IVarFloatValidateConfig:
				return IVarFloatValidateConfig.Pack(builder, _o.AsIVarFloatValidateConfig()).Value;
			case TVarValidateConfig.IVarIntValidateConfig:
				return IVarIntValidateConfig.Pack(builder, _o.AsIVarIntValidateConfig()).Value;
			case TVarValidateConfig.IVarPrefabValidateConfig:
				return IVarPrefabValidateConfig.Pack(builder, _o.AsIVarPrefabValidateConfig()).Value;
			case TVarValidateConfig.IVarQuestStateValidateConfig:
				return IVarQuestStateValidateConfig.Pack(builder, _o.AsIVarQuestStateValidateConfig()).Value;
			case TVarValidateConfig.IVarQuestValidateConfig:
				return IVarQuestValidateConfig.Pack(builder, _o.AsIVarQuestValidateConfig()).Value;
			case TVarValidateConfig.IVarStringValidateConfig:
				return IVarStringValidateConfig.Pack(builder, _o.AsIVarStringValidateConfig()).Value;
			case TVarValidateConfig.IVarTransformValidateConfig:
				return IVarTransformValidateConfig.Pack(builder, _o.AsIVarTransformValidateConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
