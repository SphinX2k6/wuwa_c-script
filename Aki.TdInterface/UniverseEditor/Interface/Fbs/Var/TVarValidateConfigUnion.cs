using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F6B RID: 16235
	public class TVarValidateConfigUnion
	{
		// Token: 0x17006DCB RID: 28107
		// (get) Token: 0x0601617B RID: 90491 RVA: 0x0032BA0C File Offset: 0x00329C0C
		// (set) Token: 0x0601617C RID: 90492 RVA: 0x0032BA14 File Offset: 0x00329C14
		public TVarValidateConfig Type { get; set; }

		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x0601617D RID: 90493 RVA: 0x0032BA1D File Offset: 0x00329C1D
		// (set) Token: 0x0601617E RID: 90494 RVA: 0x0032BA25 File Offset: 0x00329C25
		public object Value { get; set; }

		// Token: 0x0601617F RID: 90495 RVA: 0x0032BA2E File Offset: 0x00329C2E
		public TVarValidateConfigUnion()
		{
			this.Type = TVarValidateConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06016180 RID: 90496 RVA: 0x0032BA44 File Offset: 0x00329C44
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016181 RID: 90497 RVA: 0x0032BA56 File Offset: 0x00329C56
		public IVarBooleanValidateConfigT AsIVarBooleanValidateConfig()
		{
			return this.As<IVarBooleanValidateConfigT>();
		}

		// Token: 0x06016182 RID: 90498 RVA: 0x0032BA5E File Offset: 0x00329C5E
		public static TVarValidateConfigUnion FromIVarBooleanValidateConfig(IVarBooleanValidateConfigT _ivarbooleanvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarBooleanValidateConfig,
				Value = _ivarbooleanvalidateconfig
			};
		}

		// Token: 0x06016183 RID: 90499 RVA: 0x0032BA73 File Offset: 0x00329C73
		public IVarEntityValidateConfigT AsIVarEntityValidateConfig()
		{
			return this.As<IVarEntityValidateConfigT>();
		}

		// Token: 0x06016184 RID: 90500 RVA: 0x0032BA7B File Offset: 0x00329C7B
		public static TVarValidateConfigUnion FromIVarEntityValidateConfig(IVarEntityValidateConfigT _ivarentityvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarEntityValidateConfig,
				Value = _ivarentityvalidateconfig
			};
		}

		// Token: 0x06016185 RID: 90501 RVA: 0x0032BA90 File Offset: 0x00329C90
		public IVarFloatValidateConfigT AsIVarFloatValidateConfig()
		{
			return this.As<IVarFloatValidateConfigT>();
		}

		// Token: 0x06016186 RID: 90502 RVA: 0x0032BA98 File Offset: 0x00329C98
		public static TVarValidateConfigUnion FromIVarFloatValidateConfig(IVarFloatValidateConfigT _ivarfloatvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarFloatValidateConfig,
				Value = _ivarfloatvalidateconfig
			};
		}

		// Token: 0x06016187 RID: 90503 RVA: 0x0032BAAD File Offset: 0x00329CAD
		public IVarIntValidateConfigT AsIVarIntValidateConfig()
		{
			return this.As<IVarIntValidateConfigT>();
		}

		// Token: 0x06016188 RID: 90504 RVA: 0x0032BAB5 File Offset: 0x00329CB5
		public static TVarValidateConfigUnion FromIVarIntValidateConfig(IVarIntValidateConfigT _ivarintvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarIntValidateConfig,
				Value = _ivarintvalidateconfig
			};
		}

		// Token: 0x06016189 RID: 90505 RVA: 0x0032BACA File Offset: 0x00329CCA
		public IVarPrefabValidateConfigT AsIVarPrefabValidateConfig()
		{
			return this.As<IVarPrefabValidateConfigT>();
		}

		// Token: 0x0601618A RID: 90506 RVA: 0x0032BAD2 File Offset: 0x00329CD2
		public static TVarValidateConfigUnion FromIVarPrefabValidateConfig(IVarPrefabValidateConfigT _ivarprefabvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarPrefabValidateConfig,
				Value = _ivarprefabvalidateconfig
			};
		}

		// Token: 0x0601618B RID: 90507 RVA: 0x0032BAE7 File Offset: 0x00329CE7
		public IVarQuestStateValidateConfigT AsIVarQuestStateValidateConfig()
		{
			return this.As<IVarQuestStateValidateConfigT>();
		}

		// Token: 0x0601618C RID: 90508 RVA: 0x0032BAEF File Offset: 0x00329CEF
		public static TVarValidateConfigUnion FromIVarQuestStateValidateConfig(IVarQuestStateValidateConfigT _ivarqueststatevalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarQuestStateValidateConfig,
				Value = _ivarqueststatevalidateconfig
			};
		}

		// Token: 0x0601618D RID: 90509 RVA: 0x0032BB04 File Offset: 0x00329D04
		public IVarQuestValidateConfigT AsIVarQuestValidateConfig()
		{
			return this.As<IVarQuestValidateConfigT>();
		}

		// Token: 0x0601618E RID: 90510 RVA: 0x0032BB0C File Offset: 0x00329D0C
		public static TVarValidateConfigUnion FromIVarQuestValidateConfig(IVarQuestValidateConfigT _ivarquestvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarQuestValidateConfig,
				Value = _ivarquestvalidateconfig
			};
		}

		// Token: 0x0601618F RID: 90511 RVA: 0x0032BB21 File Offset: 0x00329D21
		public IVarStringValidateConfigT AsIVarStringValidateConfig()
		{
			return this.As<IVarStringValidateConfigT>();
		}

		// Token: 0x06016190 RID: 90512 RVA: 0x0032BB29 File Offset: 0x00329D29
		public static TVarValidateConfigUnion FromIVarStringValidateConfig(IVarStringValidateConfigT _ivarstringvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarStringValidateConfig,
				Value = _ivarstringvalidateconfig
			};
		}

		// Token: 0x06016191 RID: 90513 RVA: 0x0032BB3E File Offset: 0x00329D3E
		public IVarTransformValidateConfigT AsIVarTransformValidateConfig()
		{
			return this.As<IVarTransformValidateConfigT>();
		}

		// Token: 0x06016192 RID: 90514 RVA: 0x0032BB46 File Offset: 0x00329D46
		public static TVarValidateConfigUnion FromIVarTransformValidateConfig(IVarTransformValidateConfigT _ivartransformvalidateconfig)
		{
			return new TVarValidateConfigUnion
			{
				Type = TVarValidateConfig.IVarTransformValidateConfig,
				Value = _ivartransformvalidateconfig
			};
		}

		// Token: 0x06016193 RID: 90515 RVA: 0x0032BB5C File Offset: 0x00329D5C
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
