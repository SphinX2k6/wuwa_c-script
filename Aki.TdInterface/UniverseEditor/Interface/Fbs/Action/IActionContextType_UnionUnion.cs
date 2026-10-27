using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006078 RID: 24696
	public class IActionContextType_UnionUnion
	{
		// Token: 0x1700B5FE RID: 46590
		// (get) Token: 0x06029D20 RID: 171296 RVA: 0x005BCCB1 File Offset: 0x005BAEB1
		// (set) Token: 0x06029D21 RID: 171297 RVA: 0x005BCCB9 File Offset: 0x005BAEB9
		public IActionContextType_Union Type { get; set; }

		// Token: 0x1700B5FF RID: 46591
		// (get) Token: 0x06029D22 RID: 171298 RVA: 0x005BCCC2 File Offset: 0x005BAEC2
		// (set) Token: 0x06029D23 RID: 171299 RVA: 0x005BCCCA File Offset: 0x005BAECA
		public object Value { get; set; }

		// Token: 0x06029D24 RID: 171300 RVA: 0x005BCCD3 File Offset: 0x005BAED3
		public IActionContextType_UnionUnion()
		{
			this.Type = IActionContextType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029D25 RID: 171301 RVA: 0x005BCCE9 File Offset: 0x005BAEE9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029D26 RID: 171302 RVA: 0x005BCCFB File Offset: 0x005BAEFB
		public IActionContextTypeT AsIActionContextType()
		{
			return this.As<IActionContextTypeT>();
		}

		// Token: 0x06029D27 RID: 171303 RVA: 0x005BCD03 File Offset: 0x005BAF03
		public static IActionContextType_UnionUnion FromIActionContextType(IActionContextTypeT _iactioncontexttype)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IActionContextType,
				Value = _iactioncontexttype
			};
		}

		// Token: 0x06029D28 RID: 171304 RVA: 0x005BCD18 File Offset: 0x005BAF18
		public IEntityActionContextT AsIEntityActionContext()
		{
			return this.As<IEntityActionContextT>();
		}

		// Token: 0x06029D29 RID: 171305 RVA: 0x005BCD20 File Offset: 0x005BAF20
		public static IActionContextType_UnionUnion FromIEntityActionContext(IEntityActionContextT _ientityactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IEntityActionContext,
				Value = _ientityactioncontext
			};
		}

		// Token: 0x06029D2A RID: 171306 RVA: 0x005BCD35 File Offset: 0x005BAF35
		public IFlowActionContextT AsIFlowActionContext()
		{
			return this.As<IFlowActionContextT>();
		}

		// Token: 0x06029D2B RID: 171307 RVA: 0x005BCD3D File Offset: 0x005BAF3D
		public static IActionContextType_UnionUnion FromIFlowActionContext(IFlowActionContextT _iflowactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IFlowActionContext,
				Value = _iflowactioncontext
			};
		}

		// Token: 0x06029D2C RID: 171308 RVA: 0x005BCD52 File Offset: 0x005BAF52
		public ILevelPlayActionContextT AsILevelPlayActionContext()
		{
			return this.As<ILevelPlayActionContextT>();
		}

		// Token: 0x06029D2D RID: 171309 RVA: 0x005BCD5A File Offset: 0x005BAF5A
		public static IActionContextType_UnionUnion FromILevelPlayActionContext(ILevelPlayActionContextT _ilevelplayactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ILevelPlayActionContext,
				Value = _ilevelplayactioncontext
			};
		}

		// Token: 0x06029D2E RID: 171310 RVA: 0x005BCD6F File Offset: 0x005BAF6F
		public ICommonBtActionContextT AsICommonBtActionContext()
		{
			return this.As<ICommonBtActionContextT>();
		}

		// Token: 0x06029D2F RID: 171311 RVA: 0x005BCD77 File Offset: 0x005BAF77
		public static IActionContextType_UnionUnion FromICommonBtActionContext(ICommonBtActionContextT _icommonbtactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ICommonBtActionContext,
				Value = _icommonbtactioncontext
			};
		}

		// Token: 0x06029D30 RID: 171312 RVA: 0x005BCD8C File Offset: 0x005BAF8C
		public IQuestActionContextT AsIQuestActionContext()
		{
			return this.As<IQuestActionContextT>();
		}

		// Token: 0x06029D31 RID: 171313 RVA: 0x005BCD94 File Offset: 0x005BAF94
		public static IActionContextType_UnionUnion FromIQuestActionContext(IQuestActionContextT _iquestactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IQuestActionContext,
				Value = _iquestactioncontext
			};
		}

		// Token: 0x06029D32 RID: 171314 RVA: 0x005BCDA9 File Offset: 0x005BAFA9
		public IGmActionContextT AsIGmActionContext()
		{
			return this.As<IGmActionContextT>();
		}

		// Token: 0x06029D33 RID: 171315 RVA: 0x005BCDB1 File Offset: 0x005BAFB1
		public static IActionContextType_UnionUnion FromIGmActionContext(IGmActionContextT _igmactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IGmActionContext,
				Value = _igmactioncontext
			};
		}

		// Token: 0x06029D34 RID: 171316 RVA: 0x005BCDC6 File Offset: 0x005BAFC6
		public IToolEditorActionContextT AsIToolEditorActionContext()
		{
			return this.As<IToolEditorActionContextT>();
		}

		// Token: 0x06029D35 RID: 171317 RVA: 0x005BCDCE File Offset: 0x005BAFCE
		public static IActionContextType_UnionUnion FromIToolEditorActionContext(IToolEditorActionContextT _itooleditoractioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IToolEditorActionContext,
				Value = _itooleditoractioncontext
			};
		}

		// Token: 0x06029D36 RID: 171318 RVA: 0x005BCDE3 File Offset: 0x005BAFE3
		public ICsvActionContextT AsICsvActionContext()
		{
			return this.As<ICsvActionContextT>();
		}

		// Token: 0x06029D37 RID: 171319 RVA: 0x005BCDEB File Offset: 0x005BAFEB
		public static IActionContextType_UnionUnion FromICsvActionContext(ICsvActionContextT _icsvactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ICsvActionContext,
				Value = _icsvactioncontext
			};
		}

		// Token: 0x06029D38 RID: 171320 RVA: 0x005BCE04 File Offset: 0x005BB004
		public static int Pack(FlatBufferBuilder builder, IActionContextType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActionContextType_Union.IActionContextType:
				return IActionContextType.Pack(builder, _o.AsIActionContextType()).Value;
			case IActionContextType_Union.IEntityActionContext:
				return IEntityActionContext.Pack(builder, _o.AsIEntityActionContext()).Value;
			case IActionContextType_Union.IFlowActionContext:
				return IFlowActionContext.Pack(builder, _o.AsIFlowActionContext()).Value;
			case IActionContextType_Union.ILevelPlayActionContext:
				return ILevelPlayActionContext.Pack(builder, _o.AsILevelPlayActionContext()).Value;
			case IActionContextType_Union.ICommonBtActionContext:
				return ICommonBtActionContext.Pack(builder, _o.AsICommonBtActionContext()).Value;
			case IActionContextType_Union.IQuestActionContext:
				return IQuestActionContext.Pack(builder, _o.AsIQuestActionContext()).Value;
			case IActionContextType_Union.IGmActionContext:
				return IGmActionContext.Pack(builder, _o.AsIGmActionContext()).Value;
			case IActionContextType_Union.IToolEditorActionContext:
				return IToolEditorActionContext.Pack(builder, _o.AsIToolEditorActionContext()).Value;
			case IActionContextType_Union.ICsvActionContext:
				return ICsvActionContext.Pack(builder, _o.AsICsvActionContext()).Value;
			default:
				return 0;
			}
		}
	}
}
