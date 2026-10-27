using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005184 RID: 20868
	public class IEntityGroupFailureCondition_UnionUnion
	{
		// Token: 0x17009874 RID: 39028
		// (get) Token: 0x06021BD7 RID: 138199 RVA: 0x004AE82D File Offset: 0x004ACA2D
		// (set) Token: 0x06021BD8 RID: 138200 RVA: 0x004AE835 File Offset: 0x004ACA35
		public IEntityGroupFailureCondition_Union Type { get; set; }

		// Token: 0x17009875 RID: 39029
		// (get) Token: 0x06021BD9 RID: 138201 RVA: 0x004AE83E File Offset: 0x004ACA3E
		// (set) Token: 0x06021BDA RID: 138202 RVA: 0x004AE846 File Offset: 0x004ACA46
		public object Value { get; set; }

		// Token: 0x06021BDB RID: 138203 RVA: 0x004AE84F File Offset: 0x004ACA4F
		public IEntityGroupFailureCondition_UnionUnion()
		{
			this.Type = IEntityGroupFailureCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021BDC RID: 138204 RVA: 0x004AE865 File Offset: 0x004ACA65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021BDD RID: 138205 RVA: 0x004AE877 File Offset: 0x004ACA77
		public IEntityGroupFailureConditionT AsIEntityGroupFailureCondition()
		{
			return this.As<IEntityGroupFailureConditionT>();
		}

		// Token: 0x06021BDE RID: 138206 RVA: 0x004AE87F File Offset: 0x004ACA7F
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureCondition(IEntityGroupFailureConditionT _ientitygroupfailurecondition)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureCondition,
				Value = _ientitygroupfailurecondition
			};
		}

		// Token: 0x06021BDF RID: 138207 RVA: 0x004AE894 File Offset: 0x004ACA94
		public IEntityGroupFailureSequentialStateT AsIEntityGroupFailureSequentialState()
		{
			return this.As<IEntityGroupFailureSequentialStateT>();
		}

		// Token: 0x06021BE0 RID: 138208 RVA: 0x004AE89C File Offset: 0x004ACA9C
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureSequentialState(IEntityGroupFailureSequentialStateT _ientitygroupfailuresequentialstate)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureSequentialState,
				Value = _ientitygroupfailuresequentialstate
			};
		}

		// Token: 0x06021BE1 RID: 138209 RVA: 0x004AE8B1 File Offset: 0x004ACAB1
		public IEntityGroupFailureArbitraryStateT AsIEntityGroupFailureArbitraryState()
		{
			return this.As<IEntityGroupFailureArbitraryStateT>();
		}

		// Token: 0x06021BE2 RID: 138210 RVA: 0x004AE8B9 File Offset: 0x004ACAB9
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureArbitraryState(IEntityGroupFailureArbitraryStateT _ientitygroupfailurearbitrarystate)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureArbitraryState,
				Value = _ientitygroupfailurearbitrarystate
			};
		}

		// Token: 0x06021BE3 RID: 138211 RVA: 0x004AE8D0 File Offset: 0x004ACAD0
		public static int Pack(FlatBufferBuilder builder, IEntityGroupFailureCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEntityGroupFailureCondition_Union.IEntityGroupFailureCondition:
				return IEntityGroupFailureCondition.Pack(builder, _o.AsIEntityGroupFailureCondition()).Value;
			case IEntityGroupFailureCondition_Union.IEntityGroupFailureSequentialState:
				return IEntityGroupFailureSequentialState.Pack(builder, _o.AsIEntityGroupFailureSequentialState()).Value;
			case IEntityGroupFailureCondition_Union.IEntityGroupFailureArbitraryState:
				return IEntityGroupFailureArbitraryState.Pack(builder, _o.AsIEntityGroupFailureArbitraryState()).Value;
			default:
				return 0;
			}
		}
	}
}
