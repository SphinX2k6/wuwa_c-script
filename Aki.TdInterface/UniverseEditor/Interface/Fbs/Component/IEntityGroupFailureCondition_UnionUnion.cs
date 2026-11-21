using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E9 RID: 22249
	public class IEntityGroupFailureCondition_UnionUnion
	{
		// Token: 0x1700A063 RID: 41059
		// (get) Token: 0x06023B2F RID: 146223 RVA: 0x004E884D File Offset: 0x004E6A4D
		// (set) Token: 0x06023B30 RID: 146224 RVA: 0x004E8855 File Offset: 0x004E6A55
		public IEntityGroupFailureCondition_Union Type { get; set; }

		// Token: 0x1700A064 RID: 41060
		// (get) Token: 0x06023B31 RID: 146225 RVA: 0x004E885E File Offset: 0x004E6A5E
		// (set) Token: 0x06023B32 RID: 146226 RVA: 0x004E8866 File Offset: 0x004E6A66
		public object Value { get; set; }

		// Token: 0x06023B33 RID: 146227 RVA: 0x004E886F File Offset: 0x004E6A6F
		public IEntityGroupFailureCondition_UnionUnion()
		{
			this.Type = IEntityGroupFailureCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023B34 RID: 146228 RVA: 0x004E8885 File Offset: 0x004E6A85
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023B35 RID: 146229 RVA: 0x004E8897 File Offset: 0x004E6A97
		public IEntityGroupFailureConditionT AsIEntityGroupFailureCondition()
		{
			return this.As<IEntityGroupFailureConditionT>();
		}

		// Token: 0x06023B36 RID: 146230 RVA: 0x004E889F File Offset: 0x004E6A9F
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureCondition(IEntityGroupFailureConditionT _ientitygroupfailurecondition)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureCondition,
				Value = _ientitygroupfailurecondition
			};
		}

		// Token: 0x06023B37 RID: 146231 RVA: 0x004E88B4 File Offset: 0x004E6AB4
		public IEntityGroupFailureSequentialStateT AsIEntityGroupFailureSequentialState()
		{
			return this.As<IEntityGroupFailureSequentialStateT>();
		}

		// Token: 0x06023B38 RID: 146232 RVA: 0x004E88BC File Offset: 0x004E6ABC
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureSequentialState(IEntityGroupFailureSequentialStateT _ientitygroupfailuresequentialstate)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureSequentialState,
				Value = _ientitygroupfailuresequentialstate
			};
		}

		// Token: 0x06023B39 RID: 146233 RVA: 0x004E88D1 File Offset: 0x004E6AD1
		public IEntityGroupFailureArbitraryStateT AsIEntityGroupFailureArbitraryState()
		{
			return this.As<IEntityGroupFailureArbitraryStateT>();
		}

		// Token: 0x06023B3A RID: 146234 RVA: 0x004E88D9 File Offset: 0x004E6AD9
		public static IEntityGroupFailureCondition_UnionUnion FromIEntityGroupFailureArbitraryState(IEntityGroupFailureArbitraryStateT _ientitygroupfailurearbitrarystate)
		{
			return new IEntityGroupFailureCondition_UnionUnion
			{
				Type = IEntityGroupFailureCondition_Union.IEntityGroupFailureArbitraryState,
				Value = _ientitygroupfailurearbitrarystate
			};
		}

		// Token: 0x06023B3B RID: 146235 RVA: 0x004E88F0 File Offset: 0x004E6AF0
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
