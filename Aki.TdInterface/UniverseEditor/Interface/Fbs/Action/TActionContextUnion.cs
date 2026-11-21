using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E37 RID: 32311
	public class TActionContextUnion
	{
		// Token: 0x1700F1ED RID: 61933
		// (get) Token: 0x0603A62F RID: 239151 RVA: 0x007DCFD6 File Offset: 0x007DB1D6
		// (set) Token: 0x0603A630 RID: 239152 RVA: 0x007DCFDE File Offset: 0x007DB1DE
		public TActionContext Type { get; set; }

		// Token: 0x1700F1EE RID: 61934
		// (get) Token: 0x0603A631 RID: 239153 RVA: 0x007DCFE7 File Offset: 0x007DB1E7
		// (set) Token: 0x0603A632 RID: 239154 RVA: 0x007DCFEF File Offset: 0x007DB1EF
		public object Value { get; set; }

		// Token: 0x0603A633 RID: 239155 RVA: 0x007DCFF8 File Offset: 0x007DB1F8
		public TActionContextUnion()
		{
			this.Type = TActionContext.NONE;
			this.Value = null;
		}

		// Token: 0x0603A634 RID: 239156 RVA: 0x007DD00E File Offset: 0x007DB20E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A635 RID: 239157 RVA: 0x007DD020 File Offset: 0x007DB220
		public ICommonBtActionContextT AsICommonBtActionContext()
		{
			return this.As<ICommonBtActionContextT>();
		}

		// Token: 0x0603A636 RID: 239158 RVA: 0x007DD028 File Offset: 0x007DB228
		public static TActionContextUnion FromICommonBtActionContext(ICommonBtActionContextT _icommonbtactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ICommonBtActionContext,
				Value = _icommonbtactioncontext
			};
		}

		// Token: 0x0603A637 RID: 239159 RVA: 0x007DD03D File Offset: 0x007DB23D
		public ICsvActionContextT AsICsvActionContext()
		{
			return this.As<ICsvActionContextT>();
		}

		// Token: 0x0603A638 RID: 239160 RVA: 0x007DD045 File Offset: 0x007DB245
		public static TActionContextUnion FromICsvActionContext(ICsvActionContextT _icsvactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ICsvActionContext,
				Value = _icsvactioncontext
			};
		}

		// Token: 0x0603A639 RID: 239161 RVA: 0x007DD05A File Offset: 0x007DB25A
		public IEntityActionContextT AsIEntityActionContext()
		{
			return this.As<IEntityActionContextT>();
		}

		// Token: 0x0603A63A RID: 239162 RVA: 0x007DD062 File Offset: 0x007DB262
		public static TActionContextUnion FromIEntityActionContext(IEntityActionContextT _ientityactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IEntityActionContext,
				Value = _ientityactioncontext
			};
		}

		// Token: 0x0603A63B RID: 239163 RVA: 0x007DD077 File Offset: 0x007DB277
		public IFlowActionContextT AsIFlowActionContext()
		{
			return this.As<IFlowActionContextT>();
		}

		// Token: 0x0603A63C RID: 239164 RVA: 0x007DD07F File Offset: 0x007DB27F
		public static TActionContextUnion FromIFlowActionContext(IFlowActionContextT _iflowactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IFlowActionContext,
				Value = _iflowactioncontext
			};
		}

		// Token: 0x0603A63D RID: 239165 RVA: 0x007DD094 File Offset: 0x007DB294
		public IGmActionContextT AsIGmActionContext()
		{
			return this.As<IGmActionContextT>();
		}

		// Token: 0x0603A63E RID: 239166 RVA: 0x007DD09C File Offset: 0x007DB29C
		public static TActionContextUnion FromIGmActionContext(IGmActionContextT _igmactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IGmActionContext,
				Value = _igmactioncontext
			};
		}

		// Token: 0x0603A63F RID: 239167 RVA: 0x007DD0B1 File Offset: 0x007DB2B1
		public ILevelPlayActionContextT AsILevelPlayActionContext()
		{
			return this.As<ILevelPlayActionContextT>();
		}

		// Token: 0x0603A640 RID: 239168 RVA: 0x007DD0B9 File Offset: 0x007DB2B9
		public static TActionContextUnion FromILevelPlayActionContext(ILevelPlayActionContextT _ilevelplayactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ILevelPlayActionContext,
				Value = _ilevelplayactioncontext
			};
		}

		// Token: 0x0603A641 RID: 239169 RVA: 0x007DD0CE File Offset: 0x007DB2CE
		public IQuestActionContextT AsIQuestActionContext()
		{
			return this.As<IQuestActionContextT>();
		}

		// Token: 0x0603A642 RID: 239170 RVA: 0x007DD0D6 File Offset: 0x007DB2D6
		public static TActionContextUnion FromIQuestActionContext(IQuestActionContextT _iquestactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IQuestActionContext,
				Value = _iquestactioncontext
			};
		}

		// Token: 0x0603A643 RID: 239171 RVA: 0x007DD0EB File Offset: 0x007DB2EB
		public IToolEditorActionContextT AsIToolEditorActionContext()
		{
			return this.As<IToolEditorActionContextT>();
		}

		// Token: 0x0603A644 RID: 239172 RVA: 0x007DD0F3 File Offset: 0x007DB2F3
		public static TActionContextUnion FromIToolEditorActionContext(IToolEditorActionContextT _itooleditoractioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IToolEditorActionContext,
				Value = _itooleditoractioncontext
			};
		}

		// Token: 0x0603A645 RID: 239173 RVA: 0x007DD108 File Offset: 0x007DB308
		public static int Pack(FlatBufferBuilder builder, TActionContextUnion _o)
		{
			switch (_o.Type)
			{
			case TActionContext.ICommonBtActionContext:
				return ICommonBtActionContext.Pack(builder, _o.AsICommonBtActionContext()).Value;
			case TActionContext.ICsvActionContext:
				return ICsvActionContext.Pack(builder, _o.AsICsvActionContext()).Value;
			case TActionContext.IEntityActionContext:
				return IEntityActionContext.Pack(builder, _o.AsIEntityActionContext()).Value;
			case TActionContext.IFlowActionContext:
				return IFlowActionContext.Pack(builder, _o.AsIFlowActionContext()).Value;
			case TActionContext.IGmActionContext:
				return IGmActionContext.Pack(builder, _o.AsIGmActionContext()).Value;
			case TActionContext.ILevelPlayActionContext:
				return ILevelPlayActionContext.Pack(builder, _o.AsILevelPlayActionContext()).Value;
			case TActionContext.IQuestActionContext:
				return IQuestActionContext.Pack(builder, _o.AsIQuestActionContext()).Value;
			case TActionContext.IToolEditorActionContext:
				return IToolEditorActionContext.Pack(builder, _o.AsIToolEditorActionContext()).Value;
			default:
				return 0;
			}
		}
	}
}
