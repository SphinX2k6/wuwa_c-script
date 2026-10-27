using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF2 RID: 23538
	public class TBulletCreateConditionUnion
	{
		// Token: 0x1700B1CB RID: 45515
		// (get) Token: 0x06028549 RID: 165193 RVA: 0x0058A64E File Offset: 0x0058884E
		// (set) Token: 0x0602854A RID: 165194 RVA: 0x0058A656 File Offset: 0x00588856
		public TBulletCreateCondition Type { get; set; }

		// Token: 0x1700B1CC RID: 45516
		// (get) Token: 0x0602854B RID: 165195 RVA: 0x0058A65F File Offset: 0x0058885F
		// (set) Token: 0x0602854C RID: 165196 RVA: 0x0058A667 File Offset: 0x00588867
		public object Value { get; set; }

		// Token: 0x0602854D RID: 165197 RVA: 0x0058A670 File Offset: 0x00588870
		public TBulletCreateConditionUnion()
		{
			this.Type = TBulletCreateCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602854E RID: 165198 RVA: 0x0058A686 File Offset: 0x00588886
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602854F RID: 165199 RVA: 0x0058A698 File Offset: 0x00588898
		public IOnCollisionConditionT AsIOnCollisionCondition()
		{
			return this.As<IOnCollisionConditionT>();
		}

		// Token: 0x06028550 RID: 165200 RVA: 0x0058A6A0 File Offset: 0x005888A0
		public static TBulletCreateConditionUnion FromIOnCollisionCondition(IOnCollisionConditionT _ioncollisioncondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnCollisionCondition,
				Value = _ioncollisioncondition
			};
		}

		// Token: 0x06028551 RID: 165201 RVA: 0x0058A6B5 File Offset: 0x005888B5
		public IOnHitConditionT AsIOnHitCondition()
		{
			return this.As<IOnHitConditionT>();
		}

		// Token: 0x06028552 RID: 165202 RVA: 0x0058A6BD File Offset: 0x005888BD
		public static TBulletCreateConditionUnion FromIOnHitCondition(IOnHitConditionT _ionhitcondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnHitCondition,
				Value = _ionhitcondition
			};
		}

		// Token: 0x06028553 RID: 165203 RVA: 0x0058A6D2 File Offset: 0x005888D2
		public IOnMatchingConditionT AsIOnMatchingCondition()
		{
			return this.As<IOnMatchingConditionT>();
		}

		// Token: 0x06028554 RID: 165204 RVA: 0x0058A6DA File Offset: 0x005888DA
		public static TBulletCreateConditionUnion FromIOnMatchingCondition(IOnMatchingConditionT _ionmatchingcondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnMatchingCondition,
				Value = _ionmatchingcondition
			};
		}

		// Token: 0x06028555 RID: 165205 RVA: 0x0058A6EF File Offset: 0x005888EF
		public IOnOpenGravityCollisionConditionT AsIOnOpenGravityCollisionCondition()
		{
			return this.As<IOnOpenGravityCollisionConditionT>();
		}

		// Token: 0x06028556 RID: 165206 RVA: 0x0058A6F7 File Offset: 0x005888F7
		public static TBulletCreateConditionUnion FromIOnOpenGravityCollisionCondition(IOnOpenGravityCollisionConditionT _ionopengravitycollisioncondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnOpenGravityCollisionCondition,
				Value = _ionopengravitycollisioncondition
			};
		}

		// Token: 0x06028557 RID: 165207 RVA: 0x0058A70C File Offset: 0x0058890C
		public IOnThrowTriggerTimeConditionT AsIOnThrowTriggerTimeCondition()
		{
			return this.As<IOnThrowTriggerTimeConditionT>();
		}

		// Token: 0x06028558 RID: 165208 RVA: 0x0058A714 File Offset: 0x00588914
		public static TBulletCreateConditionUnion FromIOnThrowTriggerTimeCondition(IOnThrowTriggerTimeConditionT _ionthrowtriggertimecondition)
		{
			return new TBulletCreateConditionUnion
			{
				Type = TBulletCreateCondition.IOnThrowTriggerTimeCondition,
				Value = _ionthrowtriggertimecondition
			};
		}

		// Token: 0x06028559 RID: 165209 RVA: 0x0058A72C File Offset: 0x0058892C
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
