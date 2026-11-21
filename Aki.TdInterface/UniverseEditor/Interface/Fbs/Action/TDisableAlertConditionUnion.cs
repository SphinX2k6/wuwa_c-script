using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB3 RID: 32435
	public class TDisableAlertConditionUnion
	{
		// Token: 0x1700F245 RID: 62021
		// (get) Token: 0x0603A8DD RID: 239837 RVA: 0x007E1552 File Offset: 0x007DF752
		// (set) Token: 0x0603A8DE RID: 239838 RVA: 0x007E155A File Offset: 0x007DF75A
		public TDisableAlertCondition Type { get; set; }

		// Token: 0x1700F246 RID: 62022
		// (get) Token: 0x0603A8DF RID: 239839 RVA: 0x007E1563 File Offset: 0x007DF763
		// (set) Token: 0x0603A8E0 RID: 239840 RVA: 0x007E156B File Offset: 0x007DF76B
		public object Value { get; set; }

		// Token: 0x0603A8E1 RID: 239841 RVA: 0x007E1574 File Offset: 0x007DF774
		public TDisableAlertConditionUnion()
		{
			this.Type = TDisableAlertCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8E2 RID: 239842 RVA: 0x007E158A File Offset: 0x007DF78A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8E3 RID: 239843 RVA: 0x007E159C File Offset: 0x007DF79C
		public IDisableAlertAreaDungeonConditionT AsIDisableAlertAreaDungeonCondition()
		{
			return this.As<IDisableAlertAreaDungeonConditionT>();
		}

		// Token: 0x0603A8E4 RID: 239844 RVA: 0x007E15A4 File Offset: 0x007DF7A4
		public static TDisableAlertConditionUnion FromIDisableAlertAreaDungeonCondition(IDisableAlertAreaDungeonConditionT _idisablealertareadungeoncondition)
		{
			return new TDisableAlertConditionUnion
			{
				Type = TDisableAlertCondition.IDisableAlertAreaDungeonCondition,
				Value = _idisablealertareadungeoncondition
			};
		}

		// Token: 0x0603A8E5 RID: 239845 RVA: 0x007E15B9 File Offset: 0x007DF7B9
		public IDisableAlertAreaQuestConditionT AsIDisableAlertAreaQuestCondition()
		{
			return this.As<IDisableAlertAreaQuestConditionT>();
		}

		// Token: 0x0603A8E6 RID: 239846 RVA: 0x007E15C1 File Offset: 0x007DF7C1
		public static TDisableAlertConditionUnion FromIDisableAlertAreaQuestCondition(IDisableAlertAreaQuestConditionT _idisablealertareaquestcondition)
		{
			return new TDisableAlertConditionUnion
			{
				Type = TDisableAlertCondition.IDisableAlertAreaQuestCondition,
				Value = _idisablealertareaquestcondition
			};
		}

		// Token: 0x0603A8E7 RID: 239847 RVA: 0x007E15D8 File Offset: 0x007DF7D8
		public static int Pack(FlatBufferBuilder builder, TDisableAlertConditionUnion _o)
		{
			TDisableAlertCondition type = _o.Type;
			if (type == TDisableAlertCondition.IDisableAlertAreaDungeonCondition)
			{
				return IDisableAlertAreaDungeonCondition.Pack(builder, _o.AsIDisableAlertAreaDungeonCondition()).Value;
			}
			if (type != TDisableAlertCondition.IDisableAlertAreaQuestCondition)
			{
				return 0;
			}
			return IDisableAlertAreaQuestCondition.Pack(builder, _o.AsIDisableAlertAreaQuestCondition()).Value;
		}
	}
}
