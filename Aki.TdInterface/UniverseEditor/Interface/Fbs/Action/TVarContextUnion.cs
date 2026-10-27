using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FC RID: 30716
	public class TVarContextUnion
	{
		// Token: 0x1700E6EB RID: 59115
		// (get) Token: 0x06037B50 RID: 228176 RVA: 0x007881D8 File Offset: 0x007863D8
		// (set) Token: 0x06037B51 RID: 228177 RVA: 0x007881E0 File Offset: 0x007863E0
		public TVarContext Type { get; set; }

		// Token: 0x1700E6EC RID: 59116
		// (get) Token: 0x06037B52 RID: 228178 RVA: 0x007881E9 File Offset: 0x007863E9
		// (set) Token: 0x06037B53 RID: 228179 RVA: 0x007881F1 File Offset: 0x007863F1
		public object Value { get; set; }

		// Token: 0x06037B54 RID: 228180 RVA: 0x007881FA File Offset: 0x007863FA
		public TVarContextUnion()
		{
			this.Type = TVarContext.NONE;
			this.Value = null;
		}

		// Token: 0x06037B55 RID: 228181 RVA: 0x00788210 File Offset: 0x00786410
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B56 RID: 228182 RVA: 0x00788222 File Offset: 0x00786422
		public IBehaviorTreeFragmentContextT AsIBehaviorTreeFragmentContext()
		{
			return this.As<IBehaviorTreeFragmentContextT>();
		}

		// Token: 0x06037B57 RID: 228183 RVA: 0x0078822A File Offset: 0x0078642A
		public static TVarContextUnion FromIBehaviorTreeFragmentContext(IBehaviorTreeFragmentContextT _ibehaviortreefragmentcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IBehaviorTreeFragmentContext,
				Value = _ibehaviortreefragmentcontext
			};
		}

		// Token: 0x06037B58 RID: 228184 RVA: 0x0078823F File Offset: 0x0078643F
		public ICommonBtContextT AsICommonBtContext()
		{
			return this.As<ICommonBtContextT>();
		}

		// Token: 0x06037B59 RID: 228185 RVA: 0x00788247 File Offset: 0x00786447
		public static TVarContextUnion FromICommonBtContext(ICommonBtContextT _icommonbtcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.ICommonBtContext,
				Value = _icommonbtcontext
			};
		}

		// Token: 0x06037B5A RID: 228186 RVA: 0x0078825C File Offset: 0x0078645C
		public IEntityTemplateContextT AsIEntityTemplateContext()
		{
			return this.As<IEntityTemplateContextT>();
		}

		// Token: 0x06037B5B RID: 228187 RVA: 0x00788264 File Offset: 0x00786464
		public static TVarContextUnion FromIEntityTemplateContext(IEntityTemplateContextT _ientitytemplatecontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IEntityTemplateContext,
				Value = _ientitytemplatecontext
			};
		}

		// Token: 0x06037B5C RID: 228188 RVA: 0x00788279 File Offset: 0x00786479
		public IEntityVarContextT AsIEntityVarContext()
		{
			return this.As<IEntityVarContextT>();
		}

		// Token: 0x06037B5D RID: 228189 RVA: 0x00788281 File Offset: 0x00786481
		public static TVarContextUnion FromIEntityVarContext(IEntityVarContextT _ientityvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IEntityVarContext,
				Value = _ientityvarcontext
			};
		}

		// Token: 0x06037B5E RID: 228190 RVA: 0x00788296 File Offset: 0x00786496
		public ILevelPlayVarContextT AsILevelPlayVarContext()
		{
			return this.As<ILevelPlayVarContextT>();
		}

		// Token: 0x06037B5F RID: 228191 RVA: 0x0078829E File Offset: 0x0078649E
		public static TVarContextUnion FromILevelPlayVarContext(ILevelPlayVarContextT _ilevelplayvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.ILevelPlayVarContext,
				Value = _ilevelplayvarcontext
			};
		}

		// Token: 0x06037B60 RID: 228192 RVA: 0x007882B3 File Offset: 0x007864B3
		public IQuestVarContextT AsIQuestVarContext()
		{
			return this.As<IQuestVarContextT>();
		}

		// Token: 0x06037B61 RID: 228193 RVA: 0x007882BB File Offset: 0x007864BB
		public static TVarContextUnion FromIQuestVarContext(IQuestVarContextT _iquestvarcontext)
		{
			return new TVarContextUnion
			{
				Type = TVarContext.IQuestVarContext,
				Value = _iquestvarcontext
			};
		}

		// Token: 0x06037B62 RID: 228194 RVA: 0x007882D0 File Offset: 0x007864D0
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
