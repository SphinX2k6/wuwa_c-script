using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CEA RID: 31978
	public class IVarContext_UnionUnion
	{
		// Token: 0x1700EF57 RID: 61271
		// (get) Token: 0x06039B1C RID: 236316 RVA: 0x007C88E5 File Offset: 0x007C6AE5
		// (set) Token: 0x06039B1D RID: 236317 RVA: 0x007C88ED File Offset: 0x007C6AED
		public IVarContext_Union Type { get; set; }

		// Token: 0x1700EF58 RID: 61272
		// (get) Token: 0x06039B1E RID: 236318 RVA: 0x007C88F6 File Offset: 0x007C6AF6
		// (set) Token: 0x06039B1F RID: 236319 RVA: 0x007C88FE File Offset: 0x007C6AFE
		public object Value { get; set; }

		// Token: 0x06039B20 RID: 236320 RVA: 0x007C8907 File Offset: 0x007C6B07
		public IVarContext_UnionUnion()
		{
			this.Type = IVarContext_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039B21 RID: 236321 RVA: 0x007C891D File Offset: 0x007C6B1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039B22 RID: 236322 RVA: 0x007C892F File Offset: 0x007C6B2F
		public IVarContextT AsIVarContext()
		{
			return this.As<IVarContextT>();
		}

		// Token: 0x06039B23 RID: 236323 RVA: 0x007C8937 File Offset: 0x007C6B37
		public static IVarContext_UnionUnion FromIVarContext(IVarContextT _ivarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IVarContext,
				Value = _ivarcontext
			};
		}

		// Token: 0x06039B24 RID: 236324 RVA: 0x007C894C File Offset: 0x007C6B4C
		public IEntityVarContextT AsIEntityVarContext()
		{
			return this.As<IEntityVarContextT>();
		}

		// Token: 0x06039B25 RID: 236325 RVA: 0x007C8954 File Offset: 0x007C6B54
		public static IVarContext_UnionUnion FromIEntityVarContext(IEntityVarContextT _ientityvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IEntityVarContext,
				Value = _ientityvarcontext
			};
		}

		// Token: 0x06039B26 RID: 236326 RVA: 0x007C8969 File Offset: 0x007C6B69
		public IQuestVarContextT AsIQuestVarContext()
		{
			return this.As<IQuestVarContextT>();
		}

		// Token: 0x06039B27 RID: 236327 RVA: 0x007C8971 File Offset: 0x007C6B71
		public static IVarContext_UnionUnion FromIQuestVarContext(IQuestVarContextT _iquestvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IQuestVarContext,
				Value = _iquestvarcontext
			};
		}

		// Token: 0x06039B28 RID: 236328 RVA: 0x007C8986 File Offset: 0x007C6B86
		public ILevelPlayVarContextT AsILevelPlayVarContext()
		{
			return this.As<ILevelPlayVarContextT>();
		}

		// Token: 0x06039B29 RID: 236329 RVA: 0x007C898E File Offset: 0x007C6B8E
		public static IVarContext_UnionUnion FromILevelPlayVarContext(ILevelPlayVarContextT _ilevelplayvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.ILevelPlayVarContext,
				Value = _ilevelplayvarcontext
			};
		}

		// Token: 0x06039B2A RID: 236330 RVA: 0x007C89A3 File Offset: 0x007C6BA3
		public IEntityTemplateContextT AsIEntityTemplateContext()
		{
			return this.As<IEntityTemplateContextT>();
		}

		// Token: 0x06039B2B RID: 236331 RVA: 0x007C89AB File Offset: 0x007C6BAB
		public static IVarContext_UnionUnion FromIEntityTemplateContext(IEntityTemplateContextT _ientitytemplatecontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IEntityTemplateContext,
				Value = _ientitytemplatecontext
			};
		}

		// Token: 0x06039B2C RID: 236332 RVA: 0x007C89C0 File Offset: 0x007C6BC0
		public IBehaviorTreeFragmentContextT AsIBehaviorTreeFragmentContext()
		{
			return this.As<IBehaviorTreeFragmentContextT>();
		}

		// Token: 0x06039B2D RID: 236333 RVA: 0x007C89C8 File Offset: 0x007C6BC8
		public static IVarContext_UnionUnion FromIBehaviorTreeFragmentContext(IBehaviorTreeFragmentContextT _ibehaviortreefragmentcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IBehaviorTreeFragmentContext,
				Value = _ibehaviortreefragmentcontext
			};
		}

		// Token: 0x06039B2E RID: 236334 RVA: 0x007C89DD File Offset: 0x007C6BDD
		public ICommonBtContextT AsICommonBtContext()
		{
			return this.As<ICommonBtContextT>();
		}

		// Token: 0x06039B2F RID: 236335 RVA: 0x007C89E5 File Offset: 0x007C6BE5
		public static IVarContext_UnionUnion FromICommonBtContext(ICommonBtContextT _icommonbtcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.ICommonBtContext,
				Value = _icommonbtcontext
			};
		}

		// Token: 0x06039B30 RID: 236336 RVA: 0x007C89FC File Offset: 0x007C6BFC
		public static int Pack(FlatBufferBuilder builder, IVarContext_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVarContext_Union.IVarContext:
				return IVarContext.Pack(builder, _o.AsIVarContext()).Value;
			case IVarContext_Union.IEntityVarContext:
				return IEntityVarContext.Pack(builder, _o.AsIEntityVarContext()).Value;
			case IVarContext_Union.IQuestVarContext:
				return IQuestVarContext.Pack(builder, _o.AsIQuestVarContext()).Value;
			case IVarContext_Union.ILevelPlayVarContext:
				return ILevelPlayVarContext.Pack(builder, _o.AsILevelPlayVarContext()).Value;
			case IVarContext_Union.IEntityTemplateContext:
				return IEntityTemplateContext.Pack(builder, _o.AsIEntityTemplateContext()).Value;
			case IVarContext_Union.IBehaviorTreeFragmentContext:
				return IBehaviorTreeFragmentContext.Pack(builder, _o.AsIBehaviorTreeFragmentContext()).Value;
			case IVarContext_Union.ICommonBtContext:
				return ICommonBtContext.Pack(builder, _o.AsICommonBtContext()).Value;
			default:
				return 0;
			}
		}
	}
}
