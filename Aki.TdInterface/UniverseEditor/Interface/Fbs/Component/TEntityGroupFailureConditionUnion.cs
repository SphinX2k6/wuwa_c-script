using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C10 RID: 23568
	public class TEntityGroupFailureConditionUnion
	{
		// Token: 0x1700B1E8 RID: 45544
		// (get) Token: 0x060286C9 RID: 165577 RVA: 0x00590670 File Offset: 0x0058E870
		// (set) Token: 0x060286CA RID: 165578 RVA: 0x00590678 File Offset: 0x0058E878
		public TEntityGroupFailureCondition Type { get; set; }

		// Token: 0x1700B1E9 RID: 45545
		// (get) Token: 0x060286CB RID: 165579 RVA: 0x00590681 File Offset: 0x0058E881
		// (set) Token: 0x060286CC RID: 165580 RVA: 0x00590689 File Offset: 0x0058E889
		public object Value { get; set; }

		// Token: 0x060286CD RID: 165581 RVA: 0x00590692 File Offset: 0x0058E892
		public TEntityGroupFailureConditionUnion()
		{
			this.Type = TEntityGroupFailureCondition.NONE;
			this.Value = null;
		}

		// Token: 0x060286CE RID: 165582 RVA: 0x005906A8 File Offset: 0x0058E8A8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286CF RID: 165583 RVA: 0x005906BA File Offset: 0x0058E8BA
		public IEntityGroupFailureArbitraryStateT AsIEntityGroupFailureArbitraryState()
		{
			return this.As<IEntityGroupFailureArbitraryStateT>();
		}

		// Token: 0x060286D0 RID: 165584 RVA: 0x005906C2 File Offset: 0x0058E8C2
		public static TEntityGroupFailureConditionUnion FromIEntityGroupFailureArbitraryState(IEntityGroupFailureArbitraryStateT _ientitygroupfailurearbitrarystate)
		{
			return new TEntityGroupFailureConditionUnion
			{
				Type = TEntityGroupFailureCondition.IEntityGroupFailureArbitraryState,
				Value = _ientitygroupfailurearbitrarystate
			};
		}

		// Token: 0x060286D1 RID: 165585 RVA: 0x005906D7 File Offset: 0x0058E8D7
		public IEntityGroupFailureSequentialStateT AsIEntityGroupFailureSequentialState()
		{
			return this.As<IEntityGroupFailureSequentialStateT>();
		}

		// Token: 0x060286D2 RID: 165586 RVA: 0x005906DF File Offset: 0x0058E8DF
		public static TEntityGroupFailureConditionUnion FromIEntityGroupFailureSequentialState(IEntityGroupFailureSequentialStateT _ientitygroupfailuresequentialstate)
		{
			return new TEntityGroupFailureConditionUnion
			{
				Type = TEntityGroupFailureCondition.IEntityGroupFailureSequentialState,
				Value = _ientitygroupfailuresequentialstate
			};
		}

		// Token: 0x060286D3 RID: 165587 RVA: 0x005906F4 File Offset: 0x0058E8F4
		public static int Pack(FlatBufferBuilder builder, TEntityGroupFailureConditionUnion _o)
		{
			TEntityGroupFailureCondition type = _o.Type;
			if (type == TEntityGroupFailureCondition.IEntityGroupFailureArbitraryState)
			{
				return IEntityGroupFailureArbitraryState.Pack(builder, _o.AsIEntityGroupFailureArbitraryState()).Value;
			}
			if (type != TEntityGroupFailureCondition.IEntityGroupFailureSequentialState)
			{
				return 0;
			}
			return IEntityGroupFailureSequentialState.Pack(builder, _o.AsIEntityGroupFailureSequentialState()).Value;
		}
	}
}
