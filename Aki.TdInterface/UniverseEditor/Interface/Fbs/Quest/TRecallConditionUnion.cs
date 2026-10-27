using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004303 RID: 17155
	public class TRecallConditionUnion
	{
		// Token: 0x17007964 RID: 31076
		// (get) Token: 0x0601971B RID: 104219 RVA: 0x003A5B86 File Offset: 0x003A3D86
		// (set) Token: 0x0601971C RID: 104220 RVA: 0x003A5B8E File Offset: 0x003A3D8E
		public TRecallCondition Type { get; set; }

		// Token: 0x17007965 RID: 31077
		// (get) Token: 0x0601971D RID: 104221 RVA: 0x003A5B97 File Offset: 0x003A3D97
		// (set) Token: 0x0601971E RID: 104222 RVA: 0x003A5B9F File Offset: 0x003A3D9F
		public object Value { get; set; }

		// Token: 0x0601971F RID: 104223 RVA: 0x003A5BA8 File Offset: 0x003A3DA8
		public TRecallConditionUnion()
		{
			this.Type = TRecallCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06019720 RID: 104224 RVA: 0x003A5BBE File Offset: 0x003A3DBE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019721 RID: 104225 RVA: 0x003A5BD0 File Offset: 0x003A3DD0
		public IRecallConditionByEntityTypeT AsIRecallConditionByEntityType()
		{
			return this.As<IRecallConditionByEntityTypeT>();
		}

		// Token: 0x06019722 RID: 104226 RVA: 0x003A5BD8 File Offset: 0x003A3DD8
		public static TRecallConditionUnion FromIRecallConditionByEntityType(IRecallConditionByEntityTypeT _irecallconditionbyentitytype)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByEntityType,
				Value = _irecallconditionbyentitytype
			};
		}

		// Token: 0x06019723 RID: 104227 RVA: 0x003A5BED File Offset: 0x003A3DED
		public IRecallConditionByGroupT AsIRecallConditionByGroup()
		{
			return this.As<IRecallConditionByGroupT>();
		}

		// Token: 0x06019724 RID: 104228 RVA: 0x003A5BF5 File Offset: 0x003A3DF5
		public static TRecallConditionUnion FromIRecallConditionByGroup(IRecallConditionByGroupT _irecallconditionbygroup)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByGroup,
				Value = _irecallconditionbygroup
			};
		}

		// Token: 0x06019725 RID: 104229 RVA: 0x003A5C0A File Offset: 0x003A3E0A
		public IRecallConditionByTemplateT AsIRecallConditionByTemplate()
		{
			return this.As<IRecallConditionByTemplateT>();
		}

		// Token: 0x06019726 RID: 104230 RVA: 0x003A5C12 File Offset: 0x003A3E12
		public static TRecallConditionUnion FromIRecallConditionByTemplate(IRecallConditionByTemplateT _irecallconditionbytemplate)
		{
			return new TRecallConditionUnion
			{
				Type = TRecallCondition.IRecallConditionByTemplate,
				Value = _irecallconditionbytemplate
			};
		}

		// Token: 0x06019727 RID: 104231 RVA: 0x003A5C28 File Offset: 0x003A3E28
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
