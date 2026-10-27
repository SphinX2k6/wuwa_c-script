using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F4 RID: 29940
	public class IVarContext_UnionUnion
	{
		// Token: 0x1700E32D RID: 58157
		// (get) Token: 0x06036707 RID: 222983 RVA: 0x00765695 File Offset: 0x00763895
		// (set) Token: 0x06036708 RID: 222984 RVA: 0x0076569D File Offset: 0x0076389D
		public IVarContext_Union Type { get; set; }

		// Token: 0x1700E32E RID: 58158
		// (get) Token: 0x06036709 RID: 222985 RVA: 0x007656A6 File Offset: 0x007638A6
		// (set) Token: 0x0603670A RID: 222986 RVA: 0x007656AE File Offset: 0x007638AE
		public object Value { get; set; }

		// Token: 0x0603670B RID: 222987 RVA: 0x007656B7 File Offset: 0x007638B7
		public IVarContext_UnionUnion()
		{
			this.Type = IVarContext_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603670C RID: 222988 RVA: 0x007656CD File Offset: 0x007638CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603670D RID: 222989 RVA: 0x007656DF File Offset: 0x007638DF
		public IVarContextT AsIVarContext()
		{
			return this.As<IVarContextT>();
		}

		// Token: 0x0603670E RID: 222990 RVA: 0x007656E7 File Offset: 0x007638E7
		public static IVarContext_UnionUnion FromIVarContext(IVarContextT _ivarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IVarContext,
				Value = _ivarcontext
			};
		}

		// Token: 0x0603670F RID: 222991 RVA: 0x007656FC File Offset: 0x007638FC
		public IEntityVarContextT AsIEntityVarContext()
		{
			return this.As<IEntityVarContextT>();
		}

		// Token: 0x06036710 RID: 222992 RVA: 0x00765704 File Offset: 0x00763904
		public static IVarContext_UnionUnion FromIEntityVarContext(IEntityVarContextT _ientityvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IEntityVarContext,
				Value = _ientityvarcontext
			};
		}

		// Token: 0x06036711 RID: 222993 RVA: 0x00765719 File Offset: 0x00763919
		public IQuestVarContextT AsIQuestVarContext()
		{
			return this.As<IQuestVarContextT>();
		}

		// Token: 0x06036712 RID: 222994 RVA: 0x00765721 File Offset: 0x00763921
		public static IVarContext_UnionUnion FromIQuestVarContext(IQuestVarContextT _iquestvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IQuestVarContext,
				Value = _iquestvarcontext
			};
		}

		// Token: 0x06036713 RID: 222995 RVA: 0x00765736 File Offset: 0x00763936
		public ILevelPlayVarContextT AsILevelPlayVarContext()
		{
			return this.As<ILevelPlayVarContextT>();
		}

		// Token: 0x06036714 RID: 222996 RVA: 0x0076573E File Offset: 0x0076393E
		public static IVarContext_UnionUnion FromILevelPlayVarContext(ILevelPlayVarContextT _ilevelplayvarcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.ILevelPlayVarContext,
				Value = _ilevelplayvarcontext
			};
		}

		// Token: 0x06036715 RID: 222997 RVA: 0x00765753 File Offset: 0x00763953
		public IEntityTemplateContextT AsIEntityTemplateContext()
		{
			return this.As<IEntityTemplateContextT>();
		}

		// Token: 0x06036716 RID: 222998 RVA: 0x0076575B File Offset: 0x0076395B
		public static IVarContext_UnionUnion FromIEntityTemplateContext(IEntityTemplateContextT _ientitytemplatecontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IEntityTemplateContext,
				Value = _ientitytemplatecontext
			};
		}

		// Token: 0x06036717 RID: 222999 RVA: 0x00765770 File Offset: 0x00763970
		public IBehaviorTreeFragmentContextT AsIBehaviorTreeFragmentContext()
		{
			return this.As<IBehaviorTreeFragmentContextT>();
		}

		// Token: 0x06036718 RID: 223000 RVA: 0x00765778 File Offset: 0x00763978
		public static IVarContext_UnionUnion FromIBehaviorTreeFragmentContext(IBehaviorTreeFragmentContextT _ibehaviortreefragmentcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.IBehaviorTreeFragmentContext,
				Value = _ibehaviortreefragmentcontext
			};
		}

		// Token: 0x06036719 RID: 223001 RVA: 0x0076578D File Offset: 0x0076398D
		public ICommonBtContextT AsICommonBtContext()
		{
			return this.As<ICommonBtContextT>();
		}

		// Token: 0x0603671A RID: 223002 RVA: 0x00765795 File Offset: 0x00763995
		public static IVarContext_UnionUnion FromICommonBtContext(ICommonBtContextT _icommonbtcontext)
		{
			return new IVarContext_UnionUnion
			{
				Type = IVarContext_Union.ICommonBtContext,
				Value = _icommonbtcontext
			};
		}

		// Token: 0x0603671B RID: 223003 RVA: 0x007657AC File Offset: 0x007639AC
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
