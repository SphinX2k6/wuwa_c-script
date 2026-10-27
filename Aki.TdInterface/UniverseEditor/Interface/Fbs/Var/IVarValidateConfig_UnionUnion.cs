using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B24 RID: 15140
	public class IVarValidateConfig_UnionUnion
	{
		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x06014AB7 RID: 84663 RVA: 0x00301E05 File Offset: 0x00300005
		// (set) Token: 0x06014AB8 RID: 84664 RVA: 0x00301E0D File Offset: 0x0030000D
		public IVarValidateConfig_Union Type { get; set; }

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x06014AB9 RID: 84665 RVA: 0x00301E16 File Offset: 0x00300016
		// (set) Token: 0x06014ABA RID: 84666 RVA: 0x00301E1E File Offset: 0x0030001E
		public object Value { get; set; }

		// Token: 0x06014ABB RID: 84667 RVA: 0x00301E27 File Offset: 0x00300027
		public IVarValidateConfig_UnionUnion()
		{
			this.Type = IVarValidateConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014ABC RID: 84668 RVA: 0x00301E3D File Offset: 0x0030003D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014ABD RID: 84669 RVA: 0x00301E4F File Offset: 0x0030004F
		public IVarValidateConfigT AsIVarValidateConfig()
		{
			return this.As<IVarValidateConfigT>();
		}

		// Token: 0x06014ABE RID: 84670 RVA: 0x00301E57 File Offset: 0x00300057
		public static IVarValidateConfig_UnionUnion FromIVarValidateConfig(IVarValidateConfigT _ivarvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarValidateConfig,
				Value = _ivarvalidateconfig
			};
		}

		// Token: 0x06014ABF RID: 84671 RVA: 0x00301E6C File Offset: 0x0030006C
		public IVarIntValidateConfigT AsIVarIntValidateConfig()
		{
			return this.As<IVarIntValidateConfigT>();
		}

		// Token: 0x06014AC0 RID: 84672 RVA: 0x00301E74 File Offset: 0x00300074
		public static IVarValidateConfig_UnionUnion FromIVarIntValidateConfig(IVarIntValidateConfigT _ivarintvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarIntValidateConfig,
				Value = _ivarintvalidateconfig
			};
		}

		// Token: 0x06014AC1 RID: 84673 RVA: 0x00301E89 File Offset: 0x00300089
		public IVarFloatValidateConfigT AsIVarFloatValidateConfig()
		{
			return this.As<IVarFloatValidateConfigT>();
		}

		// Token: 0x06014AC2 RID: 84674 RVA: 0x00301E91 File Offset: 0x00300091
		public static IVarValidateConfig_UnionUnion FromIVarFloatValidateConfig(IVarFloatValidateConfigT _ivarfloatvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarFloatValidateConfig,
				Value = _ivarfloatvalidateconfig
			};
		}

		// Token: 0x06014AC3 RID: 84675 RVA: 0x00301EA6 File Offset: 0x003000A6
		public IVarStringValidateConfigT AsIVarStringValidateConfig()
		{
			return this.As<IVarStringValidateConfigT>();
		}

		// Token: 0x06014AC4 RID: 84676 RVA: 0x00301EAE File Offset: 0x003000AE
		public static IVarValidateConfig_UnionUnion FromIVarStringValidateConfig(IVarStringValidateConfigT _ivarstringvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarStringValidateConfig,
				Value = _ivarstringvalidateconfig
			};
		}

		// Token: 0x06014AC5 RID: 84677 RVA: 0x00301EC3 File Offset: 0x003000C3
		public IVarBooleanValidateConfigT AsIVarBooleanValidateConfig()
		{
			return this.As<IVarBooleanValidateConfigT>();
		}

		// Token: 0x06014AC6 RID: 84678 RVA: 0x00301ECB File Offset: 0x003000CB
		public static IVarValidateConfig_UnionUnion FromIVarBooleanValidateConfig(IVarBooleanValidateConfigT _ivarbooleanvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarBooleanValidateConfig,
				Value = _ivarbooleanvalidateconfig
			};
		}

		// Token: 0x06014AC7 RID: 84679 RVA: 0x00301EE0 File Offset: 0x003000E0
		public IVarEntityValidateConfigT AsIVarEntityValidateConfig()
		{
			return this.As<IVarEntityValidateConfigT>();
		}

		// Token: 0x06014AC8 RID: 84680 RVA: 0x00301EE8 File Offset: 0x003000E8
		public static IVarValidateConfig_UnionUnion FromIVarEntityValidateConfig(IVarEntityValidateConfigT _ivarentityvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarEntityValidateConfig,
				Value = _ivarentityvalidateconfig
			};
		}

		// Token: 0x06014AC9 RID: 84681 RVA: 0x00301EFD File Offset: 0x003000FD
		public IVarQuestValidateConfigT AsIVarQuestValidateConfig()
		{
			return this.As<IVarQuestValidateConfigT>();
		}

		// Token: 0x06014ACA RID: 84682 RVA: 0x00301F05 File Offset: 0x00300105
		public static IVarValidateConfig_UnionUnion FromIVarQuestValidateConfig(IVarQuestValidateConfigT _ivarquestvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarQuestValidateConfig,
				Value = _ivarquestvalidateconfig
			};
		}

		// Token: 0x06014ACB RID: 84683 RVA: 0x00301F1A File Offset: 0x0030011A
		public IVarQuestStateValidateConfigT AsIVarQuestStateValidateConfig()
		{
			return this.As<IVarQuestStateValidateConfigT>();
		}

		// Token: 0x06014ACC RID: 84684 RVA: 0x00301F22 File Offset: 0x00300122
		public static IVarValidateConfig_UnionUnion FromIVarQuestStateValidateConfig(IVarQuestStateValidateConfigT _ivarqueststatevalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarQuestStateValidateConfig,
				Value = _ivarqueststatevalidateconfig
			};
		}

		// Token: 0x06014ACD RID: 84685 RVA: 0x00301F37 File Offset: 0x00300137
		public IVarTransformValidateConfigT AsIVarTransformValidateConfig()
		{
			return this.As<IVarTransformValidateConfigT>();
		}

		// Token: 0x06014ACE RID: 84686 RVA: 0x00301F3F File Offset: 0x0030013F
		public static IVarValidateConfig_UnionUnion FromIVarTransformValidateConfig(IVarTransformValidateConfigT _ivartransformvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarTransformValidateConfig,
				Value = _ivartransformvalidateconfig
			};
		}

		// Token: 0x06014ACF RID: 84687 RVA: 0x00301F55 File Offset: 0x00300155
		public IVarPrefabValidateConfigT AsIVarPrefabValidateConfig()
		{
			return this.As<IVarPrefabValidateConfigT>();
		}

		// Token: 0x06014AD0 RID: 84688 RVA: 0x00301F5D File Offset: 0x0030015D
		public static IVarValidateConfig_UnionUnion FromIVarPrefabValidateConfig(IVarPrefabValidateConfigT _ivarprefabvalidateconfig)
		{
			return new IVarValidateConfig_UnionUnion
			{
				Type = IVarValidateConfig_Union.IVarPrefabValidateConfig,
				Value = _ivarprefabvalidateconfig
			};
		}

		// Token: 0x06014AD1 RID: 84689 RVA: 0x00301F74 File Offset: 0x00300174
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
