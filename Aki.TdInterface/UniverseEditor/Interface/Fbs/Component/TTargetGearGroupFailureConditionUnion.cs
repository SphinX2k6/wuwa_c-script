using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E9 RID: 25321
	public class TTargetGearGroupFailureConditionUnion
	{
		// Token: 0x1700BBB2 RID: 48050
		// (get) Token: 0x0602B06D RID: 176237 RVA: 0x005DDE5A File Offset: 0x005DC05A
		// (set) Token: 0x0602B06E RID: 176238 RVA: 0x005DDE62 File Offset: 0x005DC062
		public TTargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x1700BBB3 RID: 48051
		// (get) Token: 0x0602B06F RID: 176239 RVA: 0x005DDE6B File Offset: 0x005DC06B
		// (set) Token: 0x0602B070 RID: 176240 RVA: 0x005DDE73 File Offset: 0x005DC073
		public object Value { get; set; }

		// Token: 0x0602B071 RID: 176241 RVA: 0x005DDE7C File Offset: 0x005DC07C
		public TTargetGearGroupFailureConditionUnion()
		{
			this.Type = TTargetGearGroupFailureCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602B072 RID: 176242 RVA: 0x005DDE92 File Offset: 0x005DC092
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B073 RID: 176243 RVA: 0x005DDEA4 File Offset: 0x005DC0A4
		public IFailureConditionArbitraryStateT AsIFailureConditionArbitraryState()
		{
			return this.As<IFailureConditionArbitraryStateT>();
		}

		// Token: 0x0602B074 RID: 176244 RVA: 0x005DDEAC File Offset: 0x005DC0AC
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionArbitraryState(IFailureConditionArbitraryStateT _ifailureconditionarbitrarystate)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionArbitraryState,
				Value = _ifailureconditionarbitrarystate
			};
		}

		// Token: 0x0602B075 RID: 176245 RVA: 0x005DDEC1 File Offset: 0x005DC0C1
		public IFailureConditionHitTargetEntityT AsIFailureConditionHitTargetEntity()
		{
			return this.As<IFailureConditionHitTargetEntityT>();
		}

		// Token: 0x0602B076 RID: 176246 RVA: 0x005DDEC9 File Offset: 0x005DC0C9
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionHitTargetEntity(IFailureConditionHitTargetEntityT _ifailureconditionhittargetentity)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionHitTargetEntity,
				Value = _ifailureconditionhittargetentity
			};
		}

		// Token: 0x0602B077 RID: 176247 RVA: 0x005DDEDE File Offset: 0x005DC0DE
		public IFailureConditionSequentialStateT AsIFailureConditionSequentialState()
		{
			return this.As<IFailureConditionSequentialStateT>();
		}

		// Token: 0x0602B078 RID: 176248 RVA: 0x005DDEE6 File Offset: 0x005DC0E6
		public static TTargetGearGroupFailureConditionUnion FromIFailureConditionSequentialState(IFailureConditionSequentialStateT _ifailureconditionsequentialstate)
		{
			return new TTargetGearGroupFailureConditionUnion
			{
				Type = TTargetGearGroupFailureCondition.IFailureConditionSequentialState,
				Value = _ifailureconditionsequentialstate
			};
		}

		// Token: 0x0602B079 RID: 176249 RVA: 0x005DDEFC File Offset: 0x005DC0FC
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
