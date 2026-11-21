using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DA RID: 26330
	public class IActionContextType_UnionUnion
	{
		// Token: 0x1700BF69 RID: 49001
		// (get) Token: 0x0602C3D4 RID: 181204 RVA: 0x00606195 File Offset: 0x00604395
		// (set) Token: 0x0602C3D5 RID: 181205 RVA: 0x0060619D File Offset: 0x0060439D
		public IActionContextType_Union Type { get; set; }

		// Token: 0x1700BF6A RID: 49002
		// (get) Token: 0x0602C3D6 RID: 181206 RVA: 0x006061A6 File Offset: 0x006043A6
		// (set) Token: 0x0602C3D7 RID: 181207 RVA: 0x006061AE File Offset: 0x006043AE
		public object Value { get; set; }

		// Token: 0x0602C3D8 RID: 181208 RVA: 0x006061B7 File Offset: 0x006043B7
		public IActionContextType_UnionUnion()
		{
			this.Type = IActionContextType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C3D9 RID: 181209 RVA: 0x006061CD File Offset: 0x006043CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C3DA RID: 181210 RVA: 0x006061DF File Offset: 0x006043DF
		public IActionContextTypeT AsIActionContextType()
		{
			return this.As<IActionContextTypeT>();
		}

		// Token: 0x0602C3DB RID: 181211 RVA: 0x006061E7 File Offset: 0x006043E7
		public static IActionContextType_UnionUnion FromIActionContextType(IActionContextTypeT _iactioncontexttype)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IActionContextType,
				Value = _iactioncontexttype
			};
		}

		// Token: 0x0602C3DC RID: 181212 RVA: 0x006061FC File Offset: 0x006043FC
		public IEntityActionContextT AsIEntityActionContext()
		{
			return this.As<IEntityActionContextT>();
		}

		// Token: 0x0602C3DD RID: 181213 RVA: 0x00606204 File Offset: 0x00604404
		public static IActionContextType_UnionUnion FromIEntityActionContext(IEntityActionContextT _ientityactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IEntityActionContext,
				Value = _ientityactioncontext
			};
		}

		// Token: 0x0602C3DE RID: 181214 RVA: 0x00606219 File Offset: 0x00604419
		public IFlowActionContextT AsIFlowActionContext()
		{
			return this.As<IFlowActionContextT>();
		}

		// Token: 0x0602C3DF RID: 181215 RVA: 0x00606221 File Offset: 0x00604421
		public static IActionContextType_UnionUnion FromIFlowActionContext(IFlowActionContextT _iflowactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IFlowActionContext,
				Value = _iflowactioncontext
			};
		}

		// Token: 0x0602C3E0 RID: 181216 RVA: 0x00606236 File Offset: 0x00604436
		public ILevelPlayActionContextT AsILevelPlayActionContext()
		{
			return this.As<ILevelPlayActionContextT>();
		}

		// Token: 0x0602C3E1 RID: 181217 RVA: 0x0060623E File Offset: 0x0060443E
		public static IActionContextType_UnionUnion FromILevelPlayActionContext(ILevelPlayActionContextT _ilevelplayactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ILevelPlayActionContext,
				Value = _ilevelplayactioncontext
			};
		}

		// Token: 0x0602C3E2 RID: 181218 RVA: 0x00606253 File Offset: 0x00604453
		public ICommonBtActionContextT AsICommonBtActionContext()
		{
			return this.As<ICommonBtActionContextT>();
		}

		// Token: 0x0602C3E3 RID: 181219 RVA: 0x0060625B File Offset: 0x0060445B
		public static IActionContextType_UnionUnion FromICommonBtActionContext(ICommonBtActionContextT _icommonbtactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ICommonBtActionContext,
				Value = _icommonbtactioncontext
			};
		}

		// Token: 0x0602C3E4 RID: 181220 RVA: 0x00606270 File Offset: 0x00604470
		public IQuestActionContextT AsIQuestActionContext()
		{
			return this.As<IQuestActionContextT>();
		}

		// Token: 0x0602C3E5 RID: 181221 RVA: 0x00606278 File Offset: 0x00604478
		public static IActionContextType_UnionUnion FromIQuestActionContext(IQuestActionContextT _iquestactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IQuestActionContext,
				Value = _iquestactioncontext
			};
		}

		// Token: 0x0602C3E6 RID: 181222 RVA: 0x0060628D File Offset: 0x0060448D
		public IGmActionContextT AsIGmActionContext()
		{
			return this.As<IGmActionContextT>();
		}

		// Token: 0x0602C3E7 RID: 181223 RVA: 0x00606295 File Offset: 0x00604495
		public static IActionContextType_UnionUnion FromIGmActionContext(IGmActionContextT _igmactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IGmActionContext,
				Value = _igmactioncontext
			};
		}

		// Token: 0x0602C3E8 RID: 181224 RVA: 0x006062AA File Offset: 0x006044AA
		public IToolEditorActionContextT AsIToolEditorActionContext()
		{
			return this.As<IToolEditorActionContextT>();
		}

		// Token: 0x0602C3E9 RID: 181225 RVA: 0x006062B2 File Offset: 0x006044B2
		public static IActionContextType_UnionUnion FromIToolEditorActionContext(IToolEditorActionContextT _itooleditoractioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.IToolEditorActionContext,
				Value = _itooleditoractioncontext
			};
		}

		// Token: 0x0602C3EA RID: 181226 RVA: 0x006062C7 File Offset: 0x006044C7
		public ICsvActionContextT AsICsvActionContext()
		{
			return this.As<ICsvActionContextT>();
		}

		// Token: 0x0602C3EB RID: 181227 RVA: 0x006062CF File Offset: 0x006044CF
		public static IActionContextType_UnionUnion FromICsvActionContext(ICsvActionContextT _icsvactioncontext)
		{
			return new IActionContextType_UnionUnion
			{
				Type = IActionContextType_Union.ICsvActionContext,
				Value = _icsvactioncontext
			};
		}

		// Token: 0x0602C3EC RID: 181228 RVA: 0x006062E8 File Offset: 0x006044E8
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
