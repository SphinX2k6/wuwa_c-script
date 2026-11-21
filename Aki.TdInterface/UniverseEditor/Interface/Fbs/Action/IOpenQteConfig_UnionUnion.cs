using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007386 RID: 29574
	public class IOpenQteConfig_UnionUnion
	{
		// Token: 0x1700D8F3 RID: 55539
		// (get) Token: 0x06033A23 RID: 211491 RVA: 0x006F5CC1 File Offset: 0x006F3EC1
		// (set) Token: 0x06033A24 RID: 211492 RVA: 0x006F5CC9 File Offset: 0x006F3EC9
		public IOpenQteConfig_Union Type { get; set; }

		// Token: 0x1700D8F4 RID: 55540
		// (get) Token: 0x06033A25 RID: 211493 RVA: 0x006F5CD2 File Offset: 0x006F3ED2
		// (set) Token: 0x06033A26 RID: 211494 RVA: 0x006F5CDA File Offset: 0x006F3EDA
		public object Value { get; set; }

		// Token: 0x06033A27 RID: 211495 RVA: 0x006F5CE3 File Offset: 0x006F3EE3
		public IOpenQteConfig_UnionUnion()
		{
			this.Type = IOpenQteConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033A28 RID: 211496 RVA: 0x006F5CF9 File Offset: 0x006F3EF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033A29 RID: 211497 RVA: 0x006F5D0B File Offset: 0x006F3F0B
		public IOpenQteConfigT AsIOpenQteConfig()
		{
			return this.As<IOpenQteConfigT>();
		}

		// Token: 0x06033A2A RID: 211498 RVA: 0x006F5D13 File Offset: 0x006F3F13
		public static IOpenQteConfig_UnionUnion FromIOpenQteConfig(IOpenQteConfigT _iopenqteconfig)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenQteConfig,
				Value = _iopenqteconfig
			};
		}

		// Token: 0x06033A2B RID: 211499 RVA: 0x006F5D28 File Offset: 0x006F3F28
		public IOpenPanelQteQteT AsIOpenPanelQteQte()
		{
			return this.As<IOpenPanelQteQteT>();
		}

		// Token: 0x06033A2C RID: 211500 RVA: 0x006F5D30 File Offset: 0x006F3F30
		public static IOpenQteConfig_UnionUnion FromIOpenPanelQteQte(IOpenPanelQteQteT _iopenpanelqteqte)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenPanelQteQte,
				Value = _iopenpanelqteqte
			};
		}

		// Token: 0x06033A2D RID: 211501 RVA: 0x006F5D45 File Offset: 0x006F3F45
		public IOpenLevelQteT AsIOpenLevelQte()
		{
			return this.As<IOpenLevelQteT>();
		}

		// Token: 0x06033A2E RID: 211502 RVA: 0x006F5D4D File Offset: 0x006F3F4D
		public static IOpenQteConfig_UnionUnion FromIOpenLevelQte(IOpenLevelQteT _iopenlevelqte)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenLevelQte,
				Value = _iopenlevelqte
			};
		}

		// Token: 0x06033A2F RID: 211503 RVA: 0x006F5D64 File Offset: 0x006F3F64
		public static int Pack(FlatBufferBuilder builder, IOpenQteConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOpenQteConfig_Union.IOpenQteConfig:
				return IOpenQteConfig.Pack(builder, _o.AsIOpenQteConfig()).Value;
			case IOpenQteConfig_Union.IOpenPanelQteQte:
				return IOpenPanelQteQte.Pack(builder, _o.AsIOpenPanelQteQte()).Value;
			case IOpenQteConfig_Union.IOpenLevelQte:
				return IOpenLevelQte.Pack(builder, _o.AsIOpenLevelQte()).Value;
			default:
				return 0;
			}
		}
	}
}
