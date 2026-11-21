using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200803A RID: 32826
	public class TVarContextUnion
	{
		// Token: 0x1700F349 RID: 62281
		// (get) Token: 0x0603B0F5 RID: 241909 RVA: 0x007EDB50 File Offset: 0x007EBD50
		// (set) Token: 0x0603B0F6 RID: 241910 RVA: 0x007EDB58 File Offset: 0x007EBD58
		public TVarContext Type { get; set; }

		// Token: 0x1700F34A RID: 62282
		// (get) Token: 0x0603B0F7 RID: 241911 RVA: 0x007EDB61 File Offset: 0x007EBD61
		// (set) Token: 0x0603B0F8 RID: 241912 RVA: 0x007EDB69 File Offset: 0x007EBD69
		public object Value { get; set; }

		// Token: 0x0603B0F9 RID: 241913 RVA: 0x007EDB72 File Offset: 0x007EBD72
		public TVarContextUnion()
		{
			this.Type = TVarContext.NONE;
			this.Value = null;
		}

		// Token: 0x0603B0FA RID: 241914 RVA: 0x007EDB88 File Offset: 0x007EBD88
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B0FB RID: 241915 RVA: 0x007EDB9A File Offset: 0x007EBD9A
		public IBehaviorTreeFragmentContextT AsIBehaviorTreeFragmentContext()
		{
			return this.As<IBehaviorTreeFragmentContextT>();
		}

		// Token: 0x0603B0FC RID: 241916 RVA: 0x007EDBA2 File Offset: 0x007EBDA2
		public static TVarContextUnion FromIBehaviorTreeFragmentContext(IBehaviorTreeFragmentContextT _ibehaviortreefragmentcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IBehaviorTreeFragmentContext,
				Value = _ibehaviortreefragmentcontext
			};
		}

		// Token: 0x0603B0FD RID: 241917 RVA: 0x007EDBB7 File Offset: 0x007EBDB7
		public ICommonBtContextT AsICommonBtContext()
		{
			return this.As<ICommonBtContextT>();
		}

		// Token: 0x0603B0FE RID: 241918 RVA: 0x007EDBBF File Offset: 0x007EBDBF
		public static TVarContextUnion FromICommonBtContext(ICommonBtContextT _icommonbtcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.ICommonBtContext,
				Value = _icommonbtcontext
			};
		}

		// Token: 0x0603B0FF RID: 241919 RVA: 0x007EDBD4 File Offset: 0x007EBDD4
		public IEntityTemplateContextT AsIEntityTemplateContext()
		{
			return this.As<IEntityTemplateContextT>();
		}

		// Token: 0x0603B100 RID: 241920 RVA: 0x007EDBDC File Offset: 0x007EBDDC
		public static TVarContextUnion FromIEntityTemplateContext(IEntityTemplateContextT _ientitytemplatecontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IEntityTemplateContext,
				Value = _ientitytemplatecontext
			};
		}

		// Token: 0x0603B101 RID: 241921 RVA: 0x007EDBF1 File Offset: 0x007EBDF1
		public IEntityVarContextT AsIEntityVarContext()
		{
			return this.As<IEntityVarContextT>();
		}

		// Token: 0x0603B102 RID: 241922 RVA: 0x007EDBF9 File Offset: 0x007EBDF9
		public static TVarContextUnion FromIEntityVarContext(IEntityVarContextT _ientityvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IEntityVarContext,
				Value = _ientityvarcontext
			};
		}

		// Token: 0x0603B103 RID: 241923 RVA: 0x007EDC0E File Offset: 0x007EBE0E
		public ILevelPlayVarContextT AsILevelPlayVarContext()
		{
			return this.As<ILevelPlayVarContextT>();
		}

		// Token: 0x0603B104 RID: 241924 RVA: 0x007EDC16 File Offset: 0x007EBE16
		public static TVarContextUnion FromILevelPlayVarContext(ILevelPlayVarContextT _ilevelplayvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.ILevelPlayVarContext,
				Value = _ilevelplayvarcontext
			};
		}

		// Token: 0x0603B105 RID: 241925 RVA: 0x007EDC2B File Offset: 0x007EBE2B
		public IQuestVarContextT AsIQuestVarContext()
		{
			return this.As<IQuestVarContextT>();
		}

		// Token: 0x0603B106 RID: 241926 RVA: 0x007EDC33 File Offset: 0x007EBE33
		public static TVarContextUnion FromIQuestVarContext(IQuestVarContextT _iquestvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IQuestVarContext,
				Value = _iquestvarcontext
			};
		}

		// Token: 0x0603B107 RID: 241927 RVA: 0x007EDC48 File Offset: 0x007EBE48
		public static int Pack(FlatBufferBuilder builder, TVarContextUnion _o)
		{
			switch (_o.Type)
			{
			case TVarContext.IBehaviorTreeFragmentContext:
				return IBehaviorTreeFragmentContext.Pack(builder, _o.AsIBehaviorTreeFragmentContext()).Value;
			case TVarContext.ICommonBtContext:
				return ICommonBtContext.Pack(builder, _o.AsICommonBtContext()).Value;
			case TVarContext.IEntityTemplateContext:
				return IEntityTemplateContext.Pack(builder, _o.AsIEntityTemplateContext()).Value;
			case TVarContext.IEntityVarContext:
				return IEntityVarContext.Pack(builder, _o.AsIEntityVarContext()).Value;
			case TVarContext.ILevelPlayVarContext:
				return ILevelPlayVarContext.Pack(builder, _o.AsILevelPlayVarContext()).Value;
			case TVarContext.IQuestVarContext:
				return IQuestVarContext.Pack(builder, _o.AsIQuestVarContext()).Value;
			default:
				return 0;
			}
		}
	}
}
