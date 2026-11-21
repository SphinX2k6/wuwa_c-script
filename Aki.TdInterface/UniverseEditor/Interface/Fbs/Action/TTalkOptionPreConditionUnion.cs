using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008004 RID: 32772
	public class TTalkOptionPreConditionUnion
	{
		// Token: 0x1700F325 RID: 62245
		// (get) Token: 0x0603AFA1 RID: 241569 RVA: 0x007EB8D0 File Offset: 0x007E9AD0
		// (set) Token: 0x0603AFA2 RID: 241570 RVA: 0x007EB8D8 File Offset: 0x007E9AD8
		public TTalkOptionPreCondition Type { get; set; }

		// Token: 0x1700F326 RID: 62246
		// (get) Token: 0x0603AFA3 RID: 241571 RVA: 0x007EB8E1 File Offset: 0x007E9AE1
		// (set) Token: 0x0603AFA4 RID: 241572 RVA: 0x007EB8E9 File Offset: 0x007E9AE9
		public object Value { get; set; }

		// Token: 0x0603AFA5 RID: 241573 RVA: 0x007EB8F2 File Offset: 0x007E9AF2
		public TTalkOptionPreConditionUnion()
		{
			this.Type = TTalkOptionPreCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFA6 RID: 241574 RVA: 0x007EB908 File Offset: 0x007E9B08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFA7 RID: 241575 RVA: 0x007EB91A File Offset: 0x007E9B1A
		public ITalkOptionConditionT AsITalkOptionCondition()
		{
			return this.As<ITalkOptionConditionT>();
		}

		// Token: 0x0603AFA8 RID: 241576 RVA: 0x007EB922 File Offset: 0x007E9B22
		public static TTalkOptionPreConditionUnion FromITalkOptionCondition(ITalkOptionConditionT _italkoptioncondition)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionCondition,
				Value = _italkoptioncondition
			};
		}

		// Token: 0x0603AFA9 RID: 241577 RVA: 0x007EB937 File Offset: 0x007E9B37
		public ITalkOptionFirstSelectT AsITalkOptionFirstSelect()
		{
			return this.As<ITalkOptionFirstSelectT>();
		}

		// Token: 0x0603AFAA RID: 241578 RVA: 0x007EB93F File Offset: 0x007E9B3F
		public static TTalkOptionPreConditionUnion FromITalkOptionFirstSelect(ITalkOptionFirstSelectT _italkoptionfirstselect)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionFirstSelect,
				Value = _italkoptionfirstselect
			};
		}

		// Token: 0x0603AFAB RID: 241579 RVA: 0x007EB954 File Offset: 0x007E9B54
		public ITalkOptionPreOptionT AsITalkOptionPreOption()
		{
			return this.As<ITalkOptionPreOptionT>();
		}

		// Token: 0x0603AFAC RID: 241580 RVA: 0x007EB95C File Offset: 0x007E9B5C
		public static TTalkOptionPreConditionUnion FromITalkOptionPreOption(ITalkOptionPreOptionT _italkoptionpreoption)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionPreOption,
				Value = _italkoptionpreoption
			};
		}

		// Token: 0x0603AFAD RID: 241581 RVA: 0x007EB971 File Offset: 0x007E9B71
		public ITalkOptionSystemConditionT AsITalkOptionSystemCondition()
		{
			return this.As<ITalkOptionSystemConditionT>();
		}

		// Token: 0x0603AFAE RID: 241582 RVA: 0x007EB979 File Offset: 0x007E9B79
		public static TTalkOptionPreConditionUnion FromITalkOptionSystemCondition(ITalkOptionSystemConditionT _italkoptionsystemcondition)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionSystemCondition,
				Value = _italkoptionsystemcondition
			};
		}

		// Token: 0x0603AFAF RID: 241583 RVA: 0x007EB990 File Offset: 0x007E9B90
		public static int Pack(FlatBufferBuilder builder, TTalkOptionPreConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTalkOptionPreCondition.ITalkOptionCondition:
				return ITalkOptionCondition.Pack(builder, _o.AsITalkOptionCondition()).Value;
			case TTalkOptionPreCondition.ITalkOptionFirstSelect:
				return ITalkOptionFirstSelect.Pack(builder, _o.AsITalkOptionFirstSelect()).Value;
			case TTalkOptionPreCondition.ITalkOptionPreOption:
				return ITalkOptionPreOption.Pack(builder, _o.AsITalkOptionPreOption()).Value;
			case TTalkOptionPreCondition.ITalkOptionSystemCondition:
				return ITalkOptionSystemCondition.Pack(builder, _o.AsITalkOptionSystemCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
