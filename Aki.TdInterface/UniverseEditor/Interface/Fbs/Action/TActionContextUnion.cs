using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007629 RID: 30249
	public class TActionContextUnion
	{
		// Token: 0x1700E5AF RID: 58799
		// (get) Token: 0x0603718A RID: 225674 RVA: 0x00778EDA File Offset: 0x007770DA
		// (set) Token: 0x0603718B RID: 225675 RVA: 0x00778EE2 File Offset: 0x007770E2
		public TActionContext Type { get; set; }

		// Token: 0x1700E5B0 RID: 58800
		// (get) Token: 0x0603718C RID: 225676 RVA: 0x00778EEB File Offset: 0x007770EB
		// (set) Token: 0x0603718D RID: 225677 RVA: 0x00778EF3 File Offset: 0x007770F3
		public object Value { get; set; }

		// Token: 0x0603718E RID: 225678 RVA: 0x00778EFC File Offset: 0x007770FC
		public TActionContextUnion()
		{
			this.Type = TActionContext.NONE;
			this.Value = null;
		}

		// Token: 0x0603718F RID: 225679 RVA: 0x00778F12 File Offset: 0x00777112
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037190 RID: 225680 RVA: 0x00778F24 File Offset: 0x00777124
		public ICommonBtActionContextT AsICommonBtActionContext()
		{
			return this.As<ICommonBtActionContextT>();
		}

		// Token: 0x06037191 RID: 225681 RVA: 0x00778F2C File Offset: 0x0077712C
		public static TActionContextUnion FromICommonBtActionContext(ICommonBtActionContextT _icommonbtactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ICommonBtActionContext,
				Value = _icommonbtactioncontext
			};
		}

		// Token: 0x06037192 RID: 225682 RVA: 0x00778F41 File Offset: 0x00777141
		public ICsvActionContextT AsICsvActionContext()
		{
			return this.As<ICsvActionContextT>();
		}

		// Token: 0x06037193 RID: 225683 RVA: 0x00778F49 File Offset: 0x00777149
		public static TActionContextUnion FromICsvActionContext(ICsvActionContextT _icsvactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ICsvActionContext,
				Value = _icsvactioncontext
			};
		}

		// Token: 0x06037194 RID: 225684 RVA: 0x00778F5E File Offset: 0x0077715E
		public IEntityActionContextT AsIEntityActionContext()
		{
			return this.As<IEntityActionContextT>();
		}

		// Token: 0x06037195 RID: 225685 RVA: 0x00778F66 File Offset: 0x00777166
		public static TActionContextUnion FromIEntityActionContext(IEntityActionContextT _ientityactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IEntityActionContext,
				Value = _ientityactioncontext
			};
		}

		// Token: 0x06037196 RID: 225686 RVA: 0x00778F7B File Offset: 0x0077717B
		public IFlowActionContextT AsIFlowActionContext()
		{
			return this.As<IFlowActionContextT>();
		}

		// Token: 0x06037197 RID: 225687 RVA: 0x00778F83 File Offset: 0x00777183
		public static TActionContextUnion FromIFlowActionContext(IFlowActionContextT _iflowactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IFlowActionContext,
				Value = _iflowactioncontext
			};
		}

		// Token: 0x06037198 RID: 225688 RVA: 0x00778F98 File Offset: 0x00777198
		public IGmActionContextT AsIGmActionContext()
		{
			return this.As<IGmActionContextT>();
		}

		// Token: 0x06037199 RID: 225689 RVA: 0x00778FA0 File Offset: 0x007771A0
		public static TActionContextUnion FromIGmActionContext(IGmActionContextT _igmactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IGmActionContext,
				Value = _igmactioncontext
			};
		}

		// Token: 0x0603719A RID: 225690 RVA: 0x00778FB5 File Offset: 0x007771B5
		public ILevelPlayActionContextT AsILevelPlayActionContext()
		{
			return this.As<ILevelPlayActionContextT>();
		}

		// Token: 0x0603719B RID: 225691 RVA: 0x00778FBD File Offset: 0x007771BD
		public static TActionContextUnion FromILevelPlayActionContext(ILevelPlayActionContextT _ilevelplayactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.ILevelPlayActionContext,
				Value = _ilevelplayactioncontext
			};
		}

		// Token: 0x0603719C RID: 225692 RVA: 0x00778FD2 File Offset: 0x007771D2
		public IQuestActionContextT AsIQuestActionContext()
		{
			return this.As<IQuestActionContextT>();
		}

		// Token: 0x0603719D RID: 225693 RVA: 0x00778FDA File Offset: 0x007771DA
		public static TActionContextUnion FromIQuestActionContext(IQuestActionContextT _iquestactioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IQuestActionContext,
				Value = _iquestactioncontext
			};
		}

		// Token: 0x0603719E RID: 225694 RVA: 0x00778FEF File Offset: 0x007771EF
		public IToolEditorActionContextT AsIToolEditorActionContext()
		{
			return this.As<IToolEditorActionContextT>();
		}

		// Token: 0x0603719F RID: 225695 RVA: 0x00778FF7 File Offset: 0x007771F7
		public static TActionContextUnion FromIToolEditorActionContext(IToolEditorActionContextT _itooleditoractioncontext)
		{
			return new TActionContextUnion
			{
				Type = TActionContext.IToolEditorActionContext,
				Value = _itooleditoractioncontext
			};
		}

		// Token: 0x060371A0 RID: 225696 RVA: 0x0077900C File Offset: 0x0077720C
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
