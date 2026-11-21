using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D1 RID: 20689
	public class IConditionDebugData_UnionUnion
	{
		// Token: 0x17009441 RID: 37953
		// (get) Token: 0x060207CF RID: 133071 RVA: 0x0047F9A5 File Offset: 0x0047DBA5
		// (set) Token: 0x060207D0 RID: 133072 RVA: 0x0047F9AD File Offset: 0x0047DBAD
		public IConditionDebugData_Union Type { get; set; }

		// Token: 0x17009442 RID: 37954
		// (get) Token: 0x060207D1 RID: 133073 RVA: 0x0047F9B6 File Offset: 0x0047DBB6
		// (set) Token: 0x060207D2 RID: 133074 RVA: 0x0047F9BE File Offset: 0x0047DBBE
		public object Value { get; set; }

		// Token: 0x060207D3 RID: 133075 RVA: 0x0047F9C7 File Offset: 0x0047DBC7
		public IConditionDebugData_UnionUnion()
		{
			this.Type = IConditionDebugData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060207D4 RID: 133076 RVA: 0x0047F9DD File Offset: 0x0047DBDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060207D5 RID: 133077 RVA: 0x0047F9EF File Offset: 0x0047DBEF
		public IConditionDebugDataT AsIConditionDebugData()
		{
			return this.As<IConditionDebugDataT>();
		}

		// Token: 0x060207D6 RID: 133078 RVA: 0x0047F9F7 File Offset: 0x0047DBF7
		public static IConditionDebugData_UnionUnion FromIConditionDebugData(IConditionDebugDataT _iconditiondebugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.IConditionDebugData,
				Value = _iconditiondebugdata
			};
		}

		// Token: 0x060207D7 RID: 133079 RVA: 0x0047FA0C File Offset: 0x0047DC0C
		public IBaseAccessQuestDebugDataT AsIBaseAccessQuestDebugData()
		{
			return this.As<IBaseAccessQuestDebugDataT>();
		}

		// Token: 0x060207D8 RID: 133080 RVA: 0x0047FA14 File Offset: 0x0047DC14
		public static IConditionDebugData_UnionUnion FromIBaseAccessQuestDebugData(IBaseAccessQuestDebugDataT _ibaseaccessquestdebugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.IBaseAccessQuestDebugData,
				Value = _ibaseaccessquestdebugdata
			};
		}

		// Token: 0x060207D9 RID: 133081 RVA: 0x0047FA29 File Offset: 0x0047DC29
		public ICondition2DebugDataT AsICondition2DebugData()
		{
			return this.As<ICondition2DebugDataT>();
		}

		// Token: 0x060207DA RID: 133082 RVA: 0x0047FA31 File Offset: 0x0047DC31
		public static IConditionDebugData_UnionUnion FromICondition2DebugData(ICondition2DebugDataT _icondition2debugdata)
		{
			return new IConditionDebugData_UnionUnion
			{
				Type = IConditionDebugData_Union.ICondition2DebugData,
				Value = _icondition2debugdata
			};
		}

		// Token: 0x060207DB RID: 133083 RVA: 0x0047FA48 File Offset: 0x0047DC48
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
