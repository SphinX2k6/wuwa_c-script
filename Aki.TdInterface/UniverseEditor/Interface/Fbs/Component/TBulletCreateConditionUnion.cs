using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200620B RID: 25099
	public class TBulletCreateConditionUnion
	{
		// Token: 0x1700BB15 RID: 47893
		// (get) Token: 0x0602AB1B RID: 174875 RVA: 0x005D222A File Offset: 0x005D042A
		// (set) Token: 0x0602AB1C RID: 174876 RVA: 0x005D2232 File Offset: 0x005D0432
		public TBulletCreateCondition Type { get; set; }

		// Token: 0x1700BB16 RID: 47894
		// (get) Token: 0x0602AB1D RID: 174877 RVA: 0x005D223B File Offset: 0x005D043B
		// (set) Token: 0x0602AB1E RID: 174878 RVA: 0x005D2243 File Offset: 0x005D0443
		public object Value { get; set; }

		// Token: 0x0602AB1F RID: 174879 RVA: 0x005D224C File Offset: 0x005D044C
		public TBulletCreateConditionUnion()
		{
			this.Type = TBulletCreateCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602AB20 RID: 174880 RVA: 0x005D2262 File Offset: 0x005D0462
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AB21 RID: 174881 RVA: 0x005D2274 File Offset: 0x005D0474
		public IOnCollisionConditionT AsIOnCollisionCondition()
		{
			return this.As<IOnCollisionConditionT>();
		}

		// Token: 0x0602AB22 RID: 174882 RVA: 0x005D227C File Offset: 0x005D047C
		public static TBulletCreateConditionUnion FromIOnCollisionCondition(IOnCollisionConditionT _ioncollisioncondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnCollisionCondition,
				Value = _ioncollisioncondition
			};
		}

		// Token: 0x0602AB23 RID: 174883 RVA: 0x005D2291 File Offset: 0x005D0491
		public IOnHitConditionT AsIOnHitCondition()
		{
			return this.As<IOnHitConditionT>();
		}

		// Token: 0x0602AB24 RID: 174884 RVA: 0x005D2299 File Offset: 0x005D0499
		public static TBulletCreateConditionUnion FromIOnHitCondition(IOnHitConditionT _ionhitcondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnHitCondition,
				Value = _ionhitcondition
			};
		}

		// Token: 0x0602AB25 RID: 174885 RVA: 0x005D22AE File Offset: 0x005D04AE
		public IOnMatchingConditionT AsIOnMatchingCondition()
		{
			return this.As<IOnMatchingConditionT>();
		}

		// Token: 0x0602AB26 RID: 174886 RVA: 0x005D22B6 File Offset: 0x005D04B6
		public static TBulletCreateConditionUnion FromIOnMatchingCondition(IOnMatchingConditionT _ionmatchingcondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnMatchingCondition,
				Value = _ionmatchingcondition
			};
		}

		// Token: 0x0602AB27 RID: 174887 RVA: 0x005D22CB File Offset: 0x005D04CB
		public IOnOpenGravityCollisionConditionT AsIOnOpenGravityCollisionCondition()
		{
			return this.As<IOnOpenGravityCollisionConditionT>();
		}

		// Token: 0x0602AB28 RID: 174888 RVA: 0x005D22D3 File Offset: 0x005D04D3
		public static TBulletCreateConditionUnion FromIOnOpenGravityCollisionCondition(IOnOpenGravityCollisionConditionT _ionopengravitycollisioncondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnOpenGravityCollisionCondition,
				Value = _ionopengravitycollisioncondition
			};
		}

		// Token: 0x0602AB29 RID: 174889 RVA: 0x005D22E8 File Offset: 0x005D04E8
		public IOnThrowTriggerTimeConditionT AsIOnThrowTriggerTimeCondition()
		{
			return this.As<IOnThrowTriggerTimeConditionT>();
		}

		// Token: 0x0602AB2A RID: 174890 RVA: 0x005D22F0 File Offset: 0x005D04F0
		public static TBulletCreateConditionUnion FromIOnThrowTriggerTimeCondition(IOnThrowTriggerTimeConditionT _ionthrowtriggertimecondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnThrowTriggerTimeCondition,
				Value = _ionthrowtriggertimecondition
			};
		}

		// Token: 0x0602AB2B RID: 174891 RVA: 0x005D2308 File Offset: 0x005D0508
		public static int Pack(FlatBufferBuilder builder, TBulletCreateConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TBulletCreateCondition.IOnCollisionCondition:
				return IOnCollisionCondition.Pack(builder, _o.AsIOnCollisionCondition()).Value;
			case TBulletCreateCondition.IOnHitCondition:
				return IOnHitCondition.Pack(builder, _o.AsIOnHitCondition()).Value;
			case TBulletCreateCondition.IOnMatchingCondition:
				return IOnMatchingCondition.Pack(builder, _o.AsIOnMatchingCondition()).Value;
			case TBulletCreateCondition.IOnOpenGravityCollisionCondition:
				return IOnOpenGravityCollisionCondition.Pack(builder, _o.AsIOnOpenGravityCollisionCondition()).Value;
			case TBulletCreateCondition.IOnThrowTriggerTimeCondition:
				return IOnThrowTriggerTimeCondition.Pack(builder, _o.AsIOnThrowTriggerTimeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
