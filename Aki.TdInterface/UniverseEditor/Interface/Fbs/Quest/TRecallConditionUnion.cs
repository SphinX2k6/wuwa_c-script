using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004762 RID: 18274
	public class TRecallConditionUnion
	{
		// Token: 0x17007F97 RID: 32663
		// (get) Token: 0x0601AE9D RID: 110237 RVA: 0x003D14B6 File Offset: 0x003CF6B6
		// (set) Token: 0x0601AE9E RID: 110238 RVA: 0x003D14BE File Offset: 0x003CF6BE
		public TRecallCondition Type { get; set; }

		// Token: 0x17007F98 RID: 32664
		// (get) Token: 0x0601AE9F RID: 110239 RVA: 0x003D14C7 File Offset: 0x003CF6C7
		// (set) Token: 0x0601AEA0 RID: 110240 RVA: 0x003D14CF File Offset: 0x003CF6CF
		public object Value { get; set; }

		// Token: 0x0601AEA1 RID: 110241 RVA: 0x003D14D8 File Offset: 0x003CF6D8
		public TRecallConditionUnion()
		{
			this.Type = TRecallCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEA2 RID: 110242 RVA: 0x003D14EE File Offset: 0x003CF6EE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x003D1500 File Offset: 0x003CF700
		public IRecallConditionByEntityTypeT AsIRecallConditionByEntityType()
		{
			return this.As<IRecallConditionByEntityTypeT>();
		}

		// Token: 0x0601AEA4 RID: 110244 RVA: 0x003D1508 File Offset: 0x003CF708
		public static TRecallConditionUnion FromIRecallConditionByEntityType(IRecallConditionByEntityTypeT _irecallconditionbyentitytype)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByEntityType,
				Value = _irecallconditionbyentitytype
			};
		}

		// Token: 0x0601AEA5 RID: 110245 RVA: 0x003D151D File Offset: 0x003CF71D
		public IRecallConditionByGroupT AsIRecallConditionByGroup()
		{
			return this.As<IRecallConditionByGroupT>();
		}

		// Token: 0x0601AEA6 RID: 110246 RVA: 0x003D1525 File Offset: 0x003CF725
		public static TRecallConditionUnion FromIRecallConditionByGroup(IRecallConditionByGroupT _irecallconditionbygroup)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByGroup,
				Value = _irecallconditionbygroup
			};
		}

		// Token: 0x0601AEA7 RID: 110247 RVA: 0x003D153A File Offset: 0x003CF73A
		public IRecallConditionByTemplateT AsIRecallConditionByTemplate()
		{
			return this.As<IRecallConditionByTemplateT>();
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x003D1542 File Offset: 0x003CF742
		public static TRecallConditionUnion FromIRecallConditionByTemplate(IRecallConditionByTemplateT _irecallconditionbytemplate)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByTemplate,
				Value = _irecallconditionbytemplate
			};
		}

		// Token: 0x0601AEA9 RID: 110249 RVA: 0x003D1558 File Offset: 0x003CF758
		public static int Pack(FlatBufferBuilder builder, TRecallConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TRecallCondition.IRecallConditionByEntityType:
				return IRecallConditionByEntityType.Pack(builder, _o.AsIRecallConditionByEntityType()).Value;
			case TRecallCondition.IRecallConditionByGroup:
				return IRecallConditionByGroup.Pack(builder, _o.AsIRecallConditionByGroup()).Value;
			case TRecallCondition.IRecallConditionByTemplate:
				return IRecallConditionByTemplate.Pack(builder, _o.AsIRecallConditionByTemplate()).Value;
			default:
				return 0;
			}
		}
	}
}
