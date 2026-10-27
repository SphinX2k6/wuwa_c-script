using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E9 RID: 25577
	public class IClientSetPlayerOperationRestriction_UnionUnion
	{
		// Token: 0x1700BE84 RID: 48772
		// (get) Token: 0x0602C3F5 RID: 181237 RVA: 0x00612D25 File Offset: 0x00610F25
		// (set) Token: 0x0602C3F6 RID: 181238 RVA: 0x00612D2D File Offset: 0x00610F2D
		public IClientSetPlayerOperationRestriction_Union Type { get; set; }

		// Token: 0x1700BE85 RID: 48773
		// (get) Token: 0x0602C3F7 RID: 181239 RVA: 0x00612D36 File Offset: 0x00610F36
		// (set) Token: 0x0602C3F8 RID: 181240 RVA: 0x00612D3E File Offset: 0x00610F3E
		public object Value { get; set; }

		// Token: 0x0602C3F9 RID: 181241 RVA: 0x00612D47 File Offset: 0x00610F47
		public IClientSetPlayerOperationRestriction_UnionUnion()
		{
			this.Type = IClientSetPlayerOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C3FA RID: 181242 RVA: 0x00612D5D File Offset: 0x00610F5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C3FB RID: 181243 RVA: 0x00612D6F File Offset: 0x00610F6F
		public IClientSetPlayerOperationRestrictionT AsIClientSetPlayerOperationRestriction()
		{
			return this.As<IClientSetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602C3FC RID: 181244 RVA: 0x00612D77 File Offset: 0x00610F77
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientSetPlayerOperationRestriction(IClientSetPlayerOperationRestrictionT _iclientsetplayeroperationrestriction)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientSetPlayerOperationRestriction,
				Value = _iclientsetplayeroperationrestriction
			};
		}

		// Token: 0x0602C3FD RID: 181245 RVA: 0x00612D8C File Offset: 0x00610F8C
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x0602C3FE RID: 181246 RVA: 0x00612D94 File Offset: 0x00610F94
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x0602C3FF RID: 181247 RVA: 0x00612DA9 File Offset: 0x00610FA9
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0602C400 RID: 181248 RVA: 0x00612DB1 File Offset: 0x00610FB1
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0602C401 RID: 181249 RVA: 0x00612DC6 File Offset: 0x00610FC6
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0602C402 RID: 181250 RVA: 0x00612DCE File Offset: 0x00610FCE
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x0602C403 RID: 181251 RVA: 0x00612DE4 File Offset: 0x00610FE4
		public static int Pack(FlatBufferBuilder builder, IClientSetPlayerOperationRestriction_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientSetPlayerOperationRestriction_Union.IClientSetPlayerOperationRestriction:
				return IClientSetPlayerOperationRestriction.Pack(builder, _o.AsIClientSetPlayerOperationRestriction()).Value;
			case IClientSetPlayerOperationRestriction_Union.IClientEnableAllPlayerOperation:
				return IClientEnableAllPlayerOperation.Pack(builder, _o.AsIClientEnableAllPlayerOperation()).Value;
			case IClientSetPlayerOperationRestriction_Union.IClientDisableAllPlayerOperation:
				return IClientDisableAllPlayerOperation.Pack(builder, _o.AsIClientDisableAllPlayerOperation()).Value;
			case IClientSetPlayerOperationRestriction_Union.IClientDisableModulePlayerOperation:
				return IClientDisableModulePlayerOperation.Pack(builder, _o.AsIClientDisableModulePlayerOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
