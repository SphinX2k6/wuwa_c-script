using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A32 RID: 23090
	public class ITargetGearGroupFailureCondition_UnionUnion
	{
		// Token: 0x1700ADAC RID: 44460
		// (get) Token: 0x06027400 RID: 160768 RVA: 0x00566B01 File Offset: 0x00564D01
		// (set) Token: 0x06027401 RID: 160769 RVA: 0x00566B09 File Offset: 0x00564D09
		public ITargetGearGroupFailureCondition_Union Type { get; set; }

		// Token: 0x1700ADAD RID: 44461
		// (get) Token: 0x06027402 RID: 160770 RVA: 0x00566B12 File Offset: 0x00564D12
		// (set) Token: 0x06027403 RID: 160771 RVA: 0x00566B1A File Offset: 0x00564D1A
		public object Value { get; set; }

		// Token: 0x06027404 RID: 160772 RVA: 0x00566B23 File Offset: 0x00564D23
		public ITargetGearGroupFailureCondition_UnionUnion()
		{
			this.Type = ITargetGearGroupFailureCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027405 RID: 160773 RVA: 0x00566B39 File Offset: 0x00564D39
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027406 RID: 160774 RVA: 0x00566B4B File Offset: 0x00564D4B
		public ITargetGearGroupFailureConditionT AsITargetGearGroupFailureCondition()
		{
			return this.As<ITargetGearGroupFailureConditionT>();
		}

		// Token: 0x06027407 RID: 160775 RVA: 0x00566B53 File Offset: 0x00564D53
		public static ITargetGearGroupFailureCondition_UnionUnion FromITargetGearGroupFailureCondition(ITargetGearGroupFailureConditionT _itargetgeargroupfailurecondition)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.ITargetGearGroupFailureCondition,
				Value = _itargetgeargroupfailurecondition
			};
		}

		// Token: 0x06027408 RID: 160776 RVA: 0x00566B68 File Offset: 0x00564D68
		public IFailureConditionArbitraryStateT AsIFailureConditionArbitraryState()
		{
			return this.As<IFailureConditionArbitraryStateT>();
		}

		// Token: 0x06027409 RID: 160777 RVA: 0x00566B70 File Offset: 0x00564D70
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionArbitraryState(IFailureConditionArbitraryStateT _ifailureconditionarbitrarystate)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionArbitraryState,
				Value = _ifailureconditionarbitrarystate
			};
		}

		// Token: 0x0602740A RID: 160778 RVA: 0x00566B85 File Offset: 0x00564D85
		public IFailureConditionSequentialStateT AsIFailureConditionSequentialState()
		{
			return this.As<IFailureConditionSequentialStateT>();
		}

		// Token: 0x0602740B RID: 160779 RVA: 0x00566B8D File Offset: 0x00564D8D
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionSequentialState(IFailureConditionSequentialStateT _ifailureconditionsequentialstate)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionSequentialState,
				Value = _ifailureconditionsequentialstate
			};
		}

		// Token: 0x0602740C RID: 160780 RVA: 0x00566BA2 File Offset: 0x00564DA2
		public IFailureConditionHitTargetEntityT AsIFailureConditionHitTargetEntity()
		{
			return this.As<IFailureConditionHitTargetEntityT>();
		}

		// Token: 0x0602740D RID: 160781 RVA: 0x00566BAA File Offset: 0x00564DAA
		public static ITargetGearGroupFailureCondition_UnionUnion FromIFailureConditionHitTargetEntity(IFailureConditionHitTargetEntityT _ifailureconditionhittargetentity)
		{
			return new ITargetGearGroupFailureCondition_UnionUnion
			{
				Type = ITargetGearGroupFailureCondition_Union.IFailureConditionHitTargetEntity,
				Value = _ifailureconditionhittargetentity
			};
		}

		// Token: 0x0602740E RID: 160782 RVA: 0x00566BC0 File Offset: 0x00564DC0
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
