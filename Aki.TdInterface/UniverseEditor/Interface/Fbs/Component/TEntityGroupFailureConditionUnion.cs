using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200622F RID: 25135
	public class TEntityGroupFailureConditionUnion
	{
		// Token: 0x1700BB36 RID: 47926
		// (get) Token: 0x0602ACB9 RID: 175289 RVA: 0x005D85B8 File Offset: 0x005D67B8
		// (set) Token: 0x0602ACBA RID: 175290 RVA: 0x005D85C0 File Offset: 0x005D67C0
		public TEntityGroupFailureCondition Type { get; set; }

		// Token: 0x1700BB37 RID: 47927
		// (get) Token: 0x0602ACBB RID: 175291 RVA: 0x005D85C9 File Offset: 0x005D67C9
		// (set) Token: 0x0602ACBC RID: 175292 RVA: 0x005D85D1 File Offset: 0x005D67D1
		public object Value { get; set; }

		// Token: 0x0602ACBD RID: 175293 RVA: 0x005D85DA File Offset: 0x005D67DA
		public TEntityGroupFailureConditionUnion()
		{
			this.Type = TEntityGroupFailureCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACBE RID: 175294 RVA: 0x005D85F0 File Offset: 0x005D67F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACBF RID: 175295 RVA: 0x005D8602 File Offset: 0x005D6802
		public IEntityGroupFailureArbitraryStateT AsIEntityGroupFailureArbitraryState()
		{
			return this.As<IEntityGroupFailureArbitraryStateT>();
		}

		// Token: 0x0602ACC0 RID: 175296 RVA: 0x005D860A File Offset: 0x005D680A
		public static TEntityGroupFailureConditionUnion FromIEntityGroupFailureArbitraryState(IEntityGroupFailureArbitraryStateT _ientitygroupfailurearbitrarystate)
		{
			return new TEntityGroupFailureConditionUnion
			{
				Type = TEntityGroupFailureCondition.IEntityGroupFailureArbitraryState,
				Value = _ientitygroupfailurearbitrarystate
			};
		}

		// Token: 0x0602ACC1 RID: 175297 RVA: 0x005D861F File Offset: 0x005D681F
		public IEntityGroupFailureSequentialStateT AsIEntityGroupFailureSequentialState()
		{
			return this.As<IEntityGroupFailureSequentialStateT>();
		}

		// Token: 0x0602ACC2 RID: 175298 RVA: 0x005D8627 File Offset: 0x005D6827
		public static TEntityGroupFailureConditionUnion FromIEntityGroupFailureSequentialState(IEntityGroupFailureSequentialStateT _ientitygroupfailuresequentialstate)
		{
			return new TEntityGroupFailureConditionUnion
			{
				Type = TEntityGroupFailureCondition.IEntityGroupFailureSequentialState,
				Value = _ientitygroupfailuresequentialstate
			};
		}

		// Token: 0x0602ACC3 RID: 175299 RVA: 0x005D863C File Offset: 0x005D683C
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
