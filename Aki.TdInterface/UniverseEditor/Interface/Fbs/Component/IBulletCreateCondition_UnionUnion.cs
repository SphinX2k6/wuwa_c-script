using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005470 RID: 21616
	public class IBulletCreateCondition_UnionUnion
	{
		// Token: 0x170099B6 RID: 39350
		// (get) Token: 0x06021F3F RID: 139071 RVA: 0x004ADF6F File Offset: 0x004AC16F
		// (set) Token: 0x06021F40 RID: 139072 RVA: 0x004ADF77 File Offset: 0x004AC177
		public IBulletCreateCondition_Union Type { get; set; }

		// Token: 0x170099B7 RID: 39351
		// (get) Token: 0x06021F41 RID: 139073 RVA: 0x004ADF80 File Offset: 0x004AC180
		// (set) Token: 0x06021F42 RID: 139074 RVA: 0x004ADF88 File Offset: 0x004AC188
		public object Value { get; set; }

		// Token: 0x06021F43 RID: 139075 RVA: 0x004ADF91 File Offset: 0x004AC191
		public IBulletCreateCondition_UnionUnion()
		{
			this.Type = IBulletCreateCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021F44 RID: 139076 RVA: 0x004ADFA7 File Offset: 0x004AC1A7
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021F45 RID: 139077 RVA: 0x004ADFB9 File Offset: 0x004AC1B9
		public IBulletCreateConditionT AsIBulletCreateCondition()
		{
			return this.As<IBulletCreateConditionT>();
		}

		// Token: 0x06021F46 RID: 139078 RVA: 0x004ADFC1 File Offset: 0x004AC1C1
		public static IBulletCreateCondition_UnionUnion FromIBulletCreateCondition(IBulletCreateConditionT _ibulletcreatecondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IBulletCreateCondition,
				Value = _ibulletcreatecondition
			};
		}

		// Token: 0x06021F47 RID: 139079 RVA: 0x004ADFD6 File Offset: 0x004AC1D6
		public IOnHitConditionT AsIOnHitCondition()
		{
			return this.As<IOnHitConditionT>();
		}

		// Token: 0x06021F48 RID: 139080 RVA: 0x004ADFDE File Offset: 0x004AC1DE
		public static IBulletCreateCondition_UnionUnion FromIOnHitCondition(IOnHitConditionT _ionhitcondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnHitCondition,
				Value = _ionhitcondition
			};
		}

		// Token: 0x06021F49 RID: 139081 RVA: 0x004ADFF3 File Offset: 0x004AC1F3
		public IOnCollisionConditionT AsIOnCollisionCondition()
		{
			return this.As<IOnCollisionConditionT>();
		}

		// Token: 0x06021F4A RID: 139082 RVA: 0x004ADFFB File Offset: 0x004AC1FB
		public static IBulletCreateCondition_UnionUnion FromIOnCollisionCondition(IOnCollisionConditionT _ioncollisioncondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnCollisionCondition,
				Value = _ioncollisioncondition
			};
		}

		// Token: 0x06021F4B RID: 139083 RVA: 0x004AE010 File Offset: 0x004AC210
		public IOnMatchingConditionT AsIOnMatchingCondition()
		{
			return this.As<IOnMatchingConditionT>();
		}

		// Token: 0x06021F4C RID: 139084 RVA: 0x004AE018 File Offset: 0x004AC218
		public static IBulletCreateCondition_UnionUnion FromIOnMatchingCondition(IOnMatchingConditionT _ionmatchingcondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnMatchingCondition,
				Value = _ionmatchingcondition
			};
		}

		// Token: 0x06021F4D RID: 139085 RVA: 0x004AE02D File Offset: 0x004AC22D
		public IOnOpenGravityCollisionConditionT AsIOnOpenGravityCollisionCondition()
		{
			return this.As<IOnOpenGravityCollisionConditionT>();
		}

		// Token: 0x06021F4E RID: 139086 RVA: 0x004AE035 File Offset: 0x004AC235
		public static IBulletCreateCondition_UnionUnion FromIOnOpenGravityCollisionCondition(IOnOpenGravityCollisionConditionT _ionopengravitycollisioncondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnOpenGravityCollisionCondition,
				Value = _ionopengravitycollisioncondition
			};
		}

		// Token: 0x06021F4F RID: 139087 RVA: 0x004AE04A File Offset: 0x004AC24A
		public IOnThrowTriggerTimeConditionT AsIOnThrowTriggerTimeCondition()
		{
			return this.As<IOnThrowTriggerTimeConditionT>();
		}

		// Token: 0x06021F50 RID: 139088 RVA: 0x004AE052 File Offset: 0x004AC252
		public static IBulletCreateCondition_UnionUnion FromIOnThrowTriggerTimeCondition(IOnThrowTriggerTimeConditionT _ionthrowtriggertimecondition)
		{
			return new IBulletCreateCondition_UnionUnion
			{
				Type = IBulletCreateCondition_Union.IOnThrowTriggerTimeCondition,
				Value = _ionthrowtriggertimecondition
			};
		}

		// Token: 0x06021F51 RID: 139089 RVA: 0x004AE068 File Offset: 0x004AC268
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
