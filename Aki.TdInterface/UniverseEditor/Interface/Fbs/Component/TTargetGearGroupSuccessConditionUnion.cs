using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062EC RID: 25324
	public class TTargetGearGroupSuccessConditionUnion
	{
		// Token: 0x1700BBB4 RID: 48052
		// (get) Token: 0x0602B07B RID: 176251 RVA: 0x005DDFA4 File Offset: 0x005DC1A4
		// (set) Token: 0x0602B07C RID: 176252 RVA: 0x005DDFAC File Offset: 0x005DC1AC
		public TTargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700BBB5 RID: 48053
		// (get) Token: 0x0602B07D RID: 176253 RVA: 0x005DDFB5 File Offset: 0x005DC1B5
		// (set) Token: 0x0602B07E RID: 176254 RVA: 0x005DDFBD File Offset: 0x005DC1BD
		public object Value { get; set; }

		// Token: 0x0602B07F RID: 176255 RVA: 0x005DDFC6 File Offset: 0x005DC1C6
		public TTargetGearGroupSuccessConditionUnion()
		{
			this.Type = TTargetGearGroupSuccessCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602B080 RID: 176256 RVA: 0x005DDFDC File Offset: 0x005DC1DC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B081 RID: 176257 RVA: 0x005DDFEE File Offset: 0x005DC1EE
		public ISuccessConditionCountDownStateT AsISuccessConditionCountDownState()
		{
			return this.As<ISuccessConditionCountDownStateT>();
		}

		// Token: 0x0602B082 RID: 176258 RVA: 0x005DDFF6 File Offset: 0x005DC1F6
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionCountDownState(ISuccessConditionCountDownStateT _isuccessconditioncountdownstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState,
				Value = _isuccessconditioncountdownstate
			};
		}

		// Token: 0x0602B083 RID: 176259 RVA: 0x005DE00B File Offset: 0x005DC20B
		public ISuccessConditionSameArbitraryStateT AsISuccessConditionSameArbitraryState()
		{
			return this.As<ISuccessConditionSameArbitraryStateT>();
		}

		// Token: 0x0602B084 RID: 176260 RVA: 0x005DE013 File Offset: 0x005DC213
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSameArbitraryState(ISuccessConditionSameArbitraryStateT _isuccessconditionsamearbitrarystate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState,
				Value = _isuccessconditionsamearbitrarystate
			};
		}

		// Token: 0x0602B085 RID: 176261 RVA: 0x005DE028 File Offset: 0x005DC228
		public ISuccessConditionSameSpecificStateT AsISuccessConditionSameSpecificState()
		{
			return this.As<ISuccessConditionSameSpecificStateT>();
		}

		// Token: 0x0602B086 RID: 176262 RVA: 0x005DE030 File Offset: 0x005DC230
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSameSpecificState(ISuccessConditionSameSpecificStateT _isuccessconditionsamespecificstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState,
				Value = _isuccessconditionsamespecificstate
			};
		}

		// Token: 0x0602B087 RID: 176263 RVA: 0x005DE045 File Offset: 0x005DC245
		public ISuccessConditionSpecificTargetStateT AsISuccessConditionSpecificTargetState()
		{
			return this.As<ISuccessConditionSpecificTargetStateT>();
		}

		// Token: 0x0602B088 RID: 176264 RVA: 0x005DE04D File Offset: 0x005DC24D
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSpecificTargetState(ISuccessConditionSpecificTargetStateT _isuccessconditionspecifictargetstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState,
				Value = _isuccessconditionspecifictargetstate
			};
		}

		// Token: 0x0602B089 RID: 176265 RVA: 0x005DE064 File Offset: 0x005DC264
		public static int Pack(FlatBufferBuilder builder, TTargetGearGroupSuccessConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState:
				return ISuccessConditionCountDownState.Pack(builder, _o.AsISuccessConditionCountDownState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState:
				return ISuccessConditionSameArbitraryState.Pack(builder, _o.AsISuccessConditionSameArbitraryState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState:
				return ISuccessConditionSameSpecificState.Pack(builder, _o.AsISuccessConditionSameSpecificState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState:
				return ISuccessConditionSpecificTargetState.Pack(builder, _o.AsISuccessConditionSpecificTargetState()).Value;
			default:
				return 0;
			}
		}
	}
}
