using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200523F RID: 21055
	public class TConditionDebugDataUnion
	{
		// Token: 0x17009680 RID: 38528
		// (get) Token: 0x0602128F RID: 135823 RVA: 0x00493F8C File Offset: 0x0049218C
		// (set) Token: 0x06021290 RID: 135824 RVA: 0x00493F94 File Offset: 0x00492194
		public TConditionDebugData Type { get; set; }

		// Token: 0x17009681 RID: 38529
		// (get) Token: 0x06021291 RID: 135825 RVA: 0x00493F9D File Offset: 0x0049219D
		// (set) Token: 0x06021292 RID: 135826 RVA: 0x00493FA5 File Offset: 0x004921A5
		public object Value { get; set; }

		// Token: 0x06021293 RID: 135827 RVA: 0x00493FAE File Offset: 0x004921AE
		public TConditionDebugDataUnion()
		{
			this.Type = TConditionDebugData.NONE;
			this.Value = null;
		}

		// Token: 0x06021294 RID: 135828 RVA: 0x00493FC4 File Offset: 0x004921C4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021295 RID: 135829 RVA: 0x00493FD6 File Offset: 0x004921D6
		public IBaseAccessQuestDebugDataT AsIBaseAccessQuestDebugData()
		{
			return this.As<IBaseAccessQuestDebugDataT>();
		}

		// Token: 0x06021296 RID: 135830 RVA: 0x00493FDE File Offset: 0x004921DE
		public static TConditionDebugDataUnion FromIBaseAccessQuestDebugData(IBaseAccessQuestDebugDataT _ibaseaccessquestdebugdata)
		{
			return new TConditionDebugDataUnion
			{
				Type = TConditionDebugData.IBaseAccessQuestDebugData,
				Value = _ibaseaccessquestdebugdata
			};
		}

		// Token: 0x06021297 RID: 135831 RVA: 0x00493FF3 File Offset: 0x004921F3
		public ICondition2DebugDataT AsICondition2DebugData()
		{
			return this.As<ICondition2DebugDataT>();
		}

		// Token: 0x06021298 RID: 135832 RVA: 0x00493FFB File Offset: 0x004921FB
		public static TConditionDebugDataUnion FromICondition2DebugData(ICondition2DebugDataT _icondition2debugdata)
		{
			return new TConditionDebugDataUnion
			{
				Type = TConditionDebugData.ICondition2DebugData,
				Value = _icondition2debugdata
			};
		}

		// Token: 0x06021299 RID: 135833 RVA: 0x00494010 File Offset: 0x00492210
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
