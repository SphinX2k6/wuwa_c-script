using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A69 RID: 27241
	public class IClientSetPlayerOperationRestriction_UnionUnion
	{
		// Token: 0x1700C81E RID: 51230
		// (get) Token: 0x0602EBCB RID: 191435 RVA: 0x0065EBB1 File Offset: 0x0065CDB1
		// (set) Token: 0x0602EBCC RID: 191436 RVA: 0x0065EBB9 File Offset: 0x0065CDB9
		public IClientSetPlayerOperationRestriction_Union Type { get; set; }

		// Token: 0x1700C81F RID: 51231
		// (get) Token: 0x0602EBCD RID: 191437 RVA: 0x0065EBC2 File Offset: 0x0065CDC2
		// (set) Token: 0x0602EBCE RID: 191438 RVA: 0x0065EBCA File Offset: 0x0065CDCA
		public object Value { get; set; }

		// Token: 0x0602EBCF RID: 191439 RVA: 0x0065EBD3 File Offset: 0x0065CDD3
		public IClientSetPlayerOperationRestriction_UnionUnion()
		{
			this.Type = IClientSetPlayerOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EBD0 RID: 191440 RVA: 0x0065EBE9 File Offset: 0x0065CDE9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EBD1 RID: 191441 RVA: 0x0065EBFB File Offset: 0x0065CDFB
		public IClientSetPlayerOperationRestrictionT AsIClientSetPlayerOperationRestriction()
		{
			return this.As<IClientSetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602EBD2 RID: 191442 RVA: 0x0065EC03 File Offset: 0x0065CE03
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientSetPlayerOperationRestriction(IClientSetPlayerOperationRestrictionT _iclientsetplayeroperationrestriction)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientSetPlayerOperationRestriction,
				Value = _iclientsetplayeroperationrestriction
			};
		}

		// Token: 0x0602EBD3 RID: 191443 RVA: 0x0065EC18 File Offset: 0x0065CE18
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x0602EBD4 RID: 191444 RVA: 0x0065EC20 File Offset: 0x0065CE20
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x0602EBD5 RID: 191445 RVA: 0x0065EC35 File Offset: 0x0065CE35
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0602EBD6 RID: 191446 RVA: 0x0065EC3D File Offset: 0x0065CE3D
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0602EBD7 RID: 191447 RVA: 0x0065EC52 File Offset: 0x0065CE52
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0602EBD8 RID: 191448 RVA: 0x0065EC5A File Offset: 0x0065CE5A
		public static IClientSetPlayerOperationRestriction_UnionUnion FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new IClientSetPlayerOperationRestriction_UnionUnion
			{
				Type = IClientSetPlayerOperationRestriction_Union.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x0602EBD9 RID: 191449 RVA: 0x0065EC70 File Offset: 0x0065CE70
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
