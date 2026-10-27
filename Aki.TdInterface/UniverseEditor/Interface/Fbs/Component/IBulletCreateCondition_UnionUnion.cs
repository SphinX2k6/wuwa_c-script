using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3E RID: 20286
	public class IBulletCreateCondition_UnionUnion
	{
		// Token: 0x17009234 RID: 37428
		// (get) Token: 0x060201CF RID: 131535 RVA: 0x00477BDB File Offset: 0x00475DDB
		// (set) Token: 0x060201D0 RID: 131536 RVA: 0x00477BE3 File Offset: 0x00475DE3
		public IBulletCreateCondition_Union Type { get; set; }

		// Token: 0x17009235 RID: 37429
		// (get) Token: 0x060201D1 RID: 131537 RVA: 0x00477BEC File Offset: 0x00475DEC
		// (set) Token: 0x060201D2 RID: 131538 RVA: 0x00477BF4 File Offset: 0x00475DF4
		public object Value { get; set; }

		// Token: 0x060201D3 RID: 131539 RVA: 0x00477BFD File Offset: 0x00475DFD
		public IBulletCreateCondition_UnionUnion()
		{
			this.Type = IBulletCreateCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060201D4 RID: 131540 RVA: 0x00477C13 File Offset: 0x00475E13
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060201D5 RID: 131541 RVA: 0x00477C25 File Offset: 0x00475E25
		public IBulletCreateConditionT AsIBulletCreateCondition()
		{
			return this.As<IBulletCreateConditionT>();
		}

		// Token: 0x060201D6 RID: 131542 RVA: 0x00477C2D File Offset: 0x00475E2D
		public static IBulletCreateCondition_UnionUnion FromIBulletCreateCondition(IBulletCreateConditionT _ibulletcreatecondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IBulletCreateCondition,
				Value = _ibulletcreatecondition
			};
		}

		// Token: 0x060201D7 RID: 131543 RVA: 0x00477C42 File Offset: 0x00475E42
		public IOnHitConditionT AsIOnHitCondition()
		{
			return this.As<IOnHitConditionT>();
		}

		// Token: 0x060201D8 RID: 131544 RVA: 0x00477C4A File Offset: 0x00475E4A
		public static IBulletCreateCondition_UnionUnion FromIOnHitCondition(IOnHitConditionT _ionhitcondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnHitCondition,
				Value = _ionhitcondition
			};
		}

		// Token: 0x060201D9 RID: 131545 RVA: 0x00477C5F File Offset: 0x00475E5F
		public IOnCollisionConditionT AsIOnCollisionCondition()
		{
			return this.As<IOnCollisionConditionT>();
		}

		// Token: 0x060201DA RID: 131546 RVA: 0x00477C67 File Offset: 0x00475E67
		public static IBulletCreateCondition_UnionUnion FromIOnCollisionCondition(IOnCollisionConditionT _ioncollisioncondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnCollisionCondition,
				Value = _ioncollisioncondition
			};
		}

		// Token: 0x060201DB RID: 131547 RVA: 0x00477C7C File Offset: 0x00475E7C
		public IOnMatchingConditionT AsIOnMatchingCondition()
		{
			return this.As<IOnMatchingConditionT>();
		}

		// Token: 0x060201DC RID: 131548 RVA: 0x00477C84 File Offset: 0x00475E84
		public static IBulletCreateCondition_UnionUnion FromIOnMatchingCondition(IOnMatchingConditionT _ionmatchingcondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnMatchingCondition,
				Value = _ionmatchingcondition
			};
		}

		// Token: 0x060201DD RID: 131549 RVA: 0x00477C99 File Offset: 0x00475E99
		public IOnOpenGravityCollisionConditionT AsIOnOpenGravityCollisionCondition()
		{
			return this.As<IOnOpenGravityCollisionConditionT>();
		}

		// Token: 0x060201DE RID: 131550 RVA: 0x00477CA1 File Offset: 0x00475EA1
		public static IBulletCreateCondition_UnionUnion FromIOnOpenGravityCollisionCondition(IOnOpenGravityCollisionConditionT _ionopengravitycollisioncondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnOpenGravityCollisionCondition,
				Value = _ionopengravitycollisioncondition
			};
		}

		// Token: 0x060201DF RID: 131551 RVA: 0x00477CB6 File Offset: 0x00475EB6
		public IOnThrowTriggerTimeConditionT AsIOnThrowTriggerTimeCondition()
		{
			return this.As<IOnThrowTriggerTimeConditionT>();
		}

		// Token: 0x060201E0 RID: 131552 RVA: 0x00477CBE File Offset: 0x00475EBE
		public static IBulletCreateCondition_UnionUnion FromIOnThrowTriggerTimeCondition(IOnThrowTriggerTimeConditionT _ionthrowtriggertimecondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnThrowTriggerTimeCondition,
				Value = _ionthrowtriggertimecondition
			};
		}

		// Token: 0x060201E1 RID: 131553 RVA: 0x00477CD4 File Offset: 0x00475ED4
		public static int Pack(FlatBufferBuilder builder, IBulletCreateCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBulletCreateCondition_Union.IBulletCreateCondition:
				return IBulletCreateCondition.Pack(builder, _o.AsIBulletCreateCondition()).Value;
			case IBulletCreateCondition_Union.IOnHitCondition:
				return IOnHitCondition.Pack(builder, _o.AsIOnHitCondition()).Value;
			case IBulletCreateCondition_Union.IOnCollisionCondition:
				return IOnCollisionCondition.Pack(builder, _o.AsIOnCollisionCondition()).Value;
			case IBulletCreateCondition_Union.IOnMatchingCondition:
				return IOnMatchingCondition.Pack(builder, _o.AsIOnMatchingCondition()).Value;
			case IBulletCreateCondition_Union.IOnOpenGravityCollisionCondition:
				return IOnOpenGravityCollisionCondition.Pack(builder, _o.AsIOnOpenGravityCollisionCondition()).Value;
			case IBulletCreateCondition_Union.IOnThrowTriggerTimeCondition:
				return IOnThrowTriggerTimeCondition.Pack(builder, _o.AsIOnThrowTriggerTimeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
