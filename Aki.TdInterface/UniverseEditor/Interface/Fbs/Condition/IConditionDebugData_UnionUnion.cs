using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE4 RID: 19428
	public class IConditionDebugData_UnionUnion
	{
		// Token: 0x17008D1D RID: 36125
		// (get) Token: 0x0601EBE9 RID: 125929 RVA: 0x0044C739 File Offset: 0x0044A939
		// (set) Token: 0x0601EBEA RID: 125930 RVA: 0x0044C741 File Offset: 0x0044A941
		public IConditionDebugData_Union Type { get; set; }

		// Token: 0x17008D1E RID: 36126
		// (get) Token: 0x0601EBEB RID: 125931 RVA: 0x0044C74A File Offset: 0x0044A94A
		// (set) Token: 0x0601EBEC RID: 125932 RVA: 0x0044C752 File Offset: 0x0044A952
		public object Value { get; set; }

		// Token: 0x0601EBED RID: 125933 RVA: 0x0044C75B File Offset: 0x0044A95B
		public IConditionDebugData_UnionUnion()
		{
			this.Type = IConditionDebugData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EBEE RID: 125934 RVA: 0x0044C771 File Offset: 0x0044A971
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EBEF RID: 125935 RVA: 0x0044C783 File Offset: 0x0044A983
		public IConditionDebugDataT AsIConditionDebugData()
		{
			return this.As<IConditionDebugDataT>();
		}

		// Token: 0x0601EBF0 RID: 125936 RVA: 0x0044C78B File Offset: 0x0044A98B
		public static IConditionDebugData_UnionUnion FromIConditionDebugData(IConditionDebugDataT _iconditiondebugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.IConditionDebugData,
				Value = _iconditiondebugdata
			};
		}

		// Token: 0x0601EBF1 RID: 125937 RVA: 0x0044C7A0 File Offset: 0x0044A9A0
		public IBaseAccessQuestDebugDataT AsIBaseAccessQuestDebugData()
		{
			return this.As<IBaseAccessQuestDebugDataT>();
		}

		// Token: 0x0601EBF2 RID: 125938 RVA: 0x0044C7A8 File Offset: 0x0044A9A8
		public static IConditionDebugData_UnionUnion FromIBaseAccessQuestDebugData(IBaseAccessQuestDebugDataT _ibaseaccessquestdebugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.IBaseAccessQuestDebugData,
				Value = _ibaseaccessquestdebugdata
			};
		}

		// Token: 0x0601EBF3 RID: 125939 RVA: 0x0044C7BD File Offset: 0x0044A9BD
		public ICondition2DebugDataT AsICondition2DebugData()
		{
			return this.As<ICondition2DebugDataT>();
		}

		// Token: 0x0601EBF4 RID: 125940 RVA: 0x0044C7C5 File Offset: 0x0044A9C5
		public static IConditionDebugData_UnionUnion FromICondition2DebugData(ICondition2DebugDataT _icondition2debugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.ICondition2DebugData,
				Value = _icondition2debugdata
			};
		}

		// Token: 0x0601EBF5 RID: 125941 RVA: 0x0044C7DC File Offset: 0x0044A9DC
		public static int Pack(FlatBufferBuilder builder, IConditionDebugData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IConditionDebugData_Union.IConditionDebugData:
				return IConditionDebugData.Pack(builder, _o.AsIConditionDebugData()).Value;
			case IConditionDebugData_Union.IBaseAccessQuestDebugData:
				return IBaseAccessQuestDebugData.Pack(builder, _o.AsIBaseAccessQuestDebugData()).Value;
			case IConditionDebugData_Union.ICondition2DebugData:
				return ICondition2DebugData.Pack(builder, _o.AsICondition2DebugData()).Value;
			default:
				return 0;
			}
		}
	}
}
