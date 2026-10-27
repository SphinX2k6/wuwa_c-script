using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB8 RID: 23736
	public class TTargetGearGroupFailureConditionUnion
	{
		// Token: 0x1700B258 RID: 45656
		// (get) Token: 0x06028A25 RID: 166437 RVA: 0x005956E6 File Offset: 0x005938E6
		// (set) Token: 0x06028A26 RID: 166438 RVA: 0x005956EE File Offset: 0x005938EE
		public TTargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x1700B259 RID: 45657
		// (get) Token: 0x06028A27 RID: 166439 RVA: 0x005956F7 File Offset: 0x005938F7
		// (set) Token: 0x06028A28 RID: 166440 RVA: 0x005956FF File Offset: 0x005938FF
		public object Value { get; set; }

		// Token: 0x06028A29 RID: 166441 RVA: 0x00595708 File Offset: 0x00593908
		public TTargetGearGroupFailureConditionUnion()
		{
			this.Type = TTargetGearGroupFailureCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06028A2A RID: 166442 RVA: 0x0059571E File Offset: 0x0059391E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A2B RID: 166443 RVA: 0x00595730 File Offset: 0x00593930
		public IFailureConditionArbitraryStateT AsIFailureConditionArbitraryState()
		{
			return this.As<IFailureConditionArbitraryStateT>();
		}

		// Token: 0x06028A2C RID: 166444 RVA: 0x00595738 File Offset: 0x00593938
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionArbitraryState(IFailureConditionArbitraryStateT _ifailureconditionarbitrarystate)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionArbitraryState,
				Value = _ifailureconditionarbitrarystate
			};
		}

		// Token: 0x06028A2D RID: 166445 RVA: 0x0059574D File Offset: 0x0059394D
		public IFailureConditionHitTargetEntityT AsIFailureConditionHitTargetEntity()
		{
			return this.As<IFailureConditionHitTargetEntityT>();
		}

		// Token: 0x06028A2E RID: 166446 RVA: 0x00595755 File Offset: 0x00593955
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionHitTargetEntity(IFailureConditionHitTargetEntityT _ifailureconditionhittargetentity)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionHitTargetEntity,
				Value = _ifailureconditionhittargetentity
			};
		}

		// Token: 0x06028A2F RID: 166447 RVA: 0x0059576A File Offset: 0x0059396A
		public IFailureConditionSequentialStateT AsIFailureConditionSequentialState()
		{
			return this.As<IFailureConditionSequentialStateT>();
		}

		// Token: 0x06028A30 RID: 166448 RVA: 0x00595772 File Offset: 0x00593972
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionSequentialState(IFailureConditionSequentialStateT _ifailureconditionsequentialstate)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionSequentialState,
				Value = _ifailureconditionsequentialstate
			};
		}

		// Token: 0x06028A31 RID: 166449 RVA: 0x00595788 File Offset: 0x00593988
		public static int Pack(FlatBufferBuilder builder, TTargetGearGroupFailureConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetGearGroupFailureCondition.IFailureConditionArbitraryState:
				return IFailureConditionArbitraryState.Pack(builder, _o.AsIFailureConditionArbitraryState()).Value;
			case TTargetGearGroupFailureCondition.IFailureConditionHitTargetEntity:
				return IFailureConditionHitTargetEntity.Pack(builder, _o.AsIFailureConditionHitTargetEntity()).Value;
			case TTargetGearGroupFailureCondition.IFailureConditionSequentialState:
				return IFailureConditionSequentialState.Pack(builder, _o.AsIFailureConditionSequentialState()).Value;
			default:
				return 0;
			}
		}
	}
}
