using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D43 RID: 19779
	public class TConditionDebugDataUnion
	{
		// Token: 0x17008F47 RID: 36679
		// (get) Token: 0x0601F646 RID: 128582 RVA: 0x0045FFB8 File Offset: 0x0045E1B8
		// (set) Token: 0x0601F647 RID: 128583 RVA: 0x0045FFC0 File Offset: 0x0045E1C0
		public TConditionDebugData Type { get; set; }

		// Token: 0x17008F48 RID: 36680
		// (get) Token: 0x0601F648 RID: 128584 RVA: 0x0045FFC9 File Offset: 0x0045E1C9
		// (set) Token: 0x0601F649 RID: 128585 RVA: 0x0045FFD1 File Offset: 0x0045E1D1
		public object Value { get; set; }

		// Token: 0x0601F64A RID: 128586 RVA: 0x0045FFDA File Offset: 0x0045E1DA
		public TConditionDebugDataUnion()
		{
			this.Type = TConditionDebugData.NONE;
			this.Value = null;
		}

		// Token: 0x0601F64B RID: 128587 RVA: 0x0045FFF0 File Offset: 0x0045E1F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F64C RID: 128588 RVA: 0x00460002 File Offset: 0x0045E202
		public IBaseAccessQuestDebugDataT AsIBaseAccessQuestDebugData()
		{
			return this.As<IBaseAccessQuestDebugDataT>();
		}

		// Token: 0x0601F64D RID: 128589 RVA: 0x0046000A File Offset: 0x0045E20A
		public static TConditionDebugDataUnion FromIBaseAccessQuestDebugData(IBaseAccessQuestDebugDataT _ibaseaccessquestdebugdata)
		{
			return new TConditionDebugDataUnion
			{
				Type = TConditionDebugData.IBaseAccessQuestDebugData,
				Value = _ibaseaccessquestdebugdata
			};
		}

		// Token: 0x0601F64E RID: 128590 RVA: 0x0046001F File Offset: 0x0045E21F
		public ICondition2DebugDataT AsICondition2DebugData()
		{
			return this.As<ICondition2DebugDataT>();
		}

		// Token: 0x0601F64F RID: 128591 RVA: 0x00460027 File Offset: 0x0045E227
		public static TConditionDebugDataUnion FromICondition2DebugData(ICondition2DebugDataT _icondition2debugdata)
		{
			return new TConditionDebugDataUnion
			{
				Type = TConditionDebugData.ICondition2DebugData,
				Value = _icondition2debugdata
			};
		}

		// Token: 0x0601F650 RID: 128592 RVA: 0x0046003C File Offset: 0x0045E23C
		public static int Pack(FlatBufferBuilder builder, TConditionDebugDataUnion _o)
		{
			TConditionDebugData type = _o.Type;
			if (type == TConditionDebugData.IBaseAccessQuestDebugData)
			{
				return IBaseAccessQuestDebugData.Pack(builder, _o.AsIBaseAccessQuestDebugData()).Value;
			}
			if (type != TConditionDebugData.ICondition2DebugData)
			{
				return 0;
			}
			return ICondition2DebugData.Pack(builder, _o.AsICondition2DebugData()).Value;
		}
	}
}
