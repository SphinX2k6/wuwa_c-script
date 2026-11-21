using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603F RID: 24639
	public class ITargetGearGroupFailureCondition_UnionUnion
	{
		// Token: 0x1700B6E4 RID: 46820
		// (get) Token: 0x06029978 RID: 170360 RVA: 0x005ADAC5 File Offset: 0x005ABCC5
		// (set) Token: 0x06029979 RID: 170361 RVA: 0x005ADACD File Offset: 0x005ABCCD
		public ITargetGearGroupFailureCondition_Union Type { get; set; }

		// Token: 0x1700B6E5 RID: 46821
		// (get) Token: 0x0602997A RID: 170362 RVA: 0x005ADAD6 File Offset: 0x005ABCD6
		// (set) Token: 0x0602997B RID: 170363 RVA: 0x005ADADE File Offset: 0x005ABCDE
		public object Value { get; set; }

		// Token: 0x0602997C RID: 170364 RVA: 0x005ADAE7 File Offset: 0x005ABCE7
		public ITargetGearGroupFailureCondition_UnionUnion()
		{
			this.Type = ITargetGearGroupFailureCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602997D RID: 170365 RVA: 0x005ADAFD File Offset: 0x005ABCFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602997E RID: 170366 RVA: 0x005ADB0F File Offset: 0x005ABD0F
		public ITargetGearGroupFailureConditionT AsITargetGearGroupFailureCondition()
		{
			return this.As<ITargetGearGroupFailureConditionT>();
		}

		// Token: 0x0602997F RID: 170367 RVA: 0x005ADB17 File Offset: 0x005ABD17
		public static ITargetGearGroupFailureCondition_UnionUnion FromITargetGearGroupFailureCondition(ITargetGearGroupFailureConditionT _itargetgeargroupfailurecondition)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.ITargetGearGroupFailureCondition,
				Value = _itargetgeargroupfailurecondition
			};
		}

		// Token: 0x06029980 RID: 170368 RVA: 0x005ADB2C File Offset: 0x005ABD2C
		public IFailureConditionArbitraryStateT AsIFailureConditionArbitraryState()
		{
			return this.As<IFailureConditionArbitraryStateT>();
		}

		// Token: 0x06029981 RID: 170369 RVA: 0x005ADB34 File Offset: 0x005ABD34
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionArbitraryState(IFailureConditionArbitraryStateT _ifailureconditionarbitrarystate)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionArbitraryState,
				Value = _ifailureconditionarbitrarystate
			};
		}

		// Token: 0x06029982 RID: 170370 RVA: 0x005ADB49 File Offset: 0x005ABD49
		public IFailureConditionSequentialStateT AsIFailureConditionSequentialState()
		{
			return this.As<IFailureConditionSequentialStateT>();
		}

		// Token: 0x06029983 RID: 170371 RVA: 0x005ADB51 File Offset: 0x005ABD51
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionSequentialState(IFailureConditionSequentialStateT _ifailureconditionsequentialstate)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionSequentialState,
				Value = _ifailureconditionsequentialstate
			};
		}

		// Token: 0x06029984 RID: 170372 RVA: 0x005ADB66 File Offset: 0x005ABD66
		public IFailureConditionHitTargetEntityT AsIFailureConditionHitTargetEntity()
		{
			return this.As<IFailureConditionHitTargetEntityT>();
		}

		// Token: 0x06029985 RID: 170373 RVA: 0x005ADB6E File Offset: 0x005ABD6E
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionHitTargetEntity(IFailureConditionHitTargetEntityT _ifailureconditionhittargetentity)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionHitTargetEntity,
				Value = _ifailureconditionhittargetentity
			};
		}

		// Token: 0x06029986 RID: 170374 RVA: 0x005ADB84 File Offset: 0x005ABD84
		public static int Pack(FlatBufferBuilder builder, ITargetGearGroupFailureCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetGearGroupFailureCondition_Union.ITargetGearGroupFailureCondition:
				return ITargetGearGroupFailureCondition.Pack(builder, _o.AsITargetGearGroupFailureCondition()).Value;
			case ITargetGearGroupFailureCondition_Union.IFailureConditionArbitraryState:
				return IFailureConditionArbitraryState.Pack(builder, _o.AsIFailureConditionArbitraryState()).Value;
			case ITargetGearGroupFailureCondition_Union.IFailureConditionSequentialState:
				return IFailureConditionSequentialState.Pack(builder, _o.AsIFailureConditionSequentialState()).Value;
			case ITargetGearGroupFailureCondition_Union.IFailureConditionHitTargetEntity:
				return IFailureConditionHitTargetEntity.Pack(builder, _o.AsIFailureConditionHitTargetEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
