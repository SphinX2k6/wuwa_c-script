using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200642F RID: 25647
	public class IGiantTriggerType_UnionUnion
	{
		// Token: 0x1700BD63 RID: 48483
		// (get) Token: 0x0602B934 RID: 178484 RVA: 0x005EEEA5 File Offset: 0x005ED0A5
		// (set) Token: 0x0602B935 RID: 178485 RVA: 0x005EEEAD File Offset: 0x005ED0AD
		public IGiantTriggerType_Union Type { get; set; }

		// Token: 0x1700BD64 RID: 48484
		// (get) Token: 0x0602B936 RID: 178486 RVA: 0x005EEEB6 File Offset: 0x005ED0B6
		// (set) Token: 0x0602B937 RID: 178487 RVA: 0x005EEEBE File Offset: 0x005ED0BE
		public object Value { get; set; }

		// Token: 0x0602B938 RID: 178488 RVA: 0x005EEEC7 File Offset: 0x005ED0C7
		public IGiantTriggerType_UnionUnion()
		{
			this.Type = IGiantTriggerType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B939 RID: 178489 RVA: 0x005EEEDD File Offset: 0x005ED0DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B93A RID: 178490 RVA: 0x005EEEEF File Offset: 0x005ED0EF
		public IGiantTriggerTypeT AsIGiantTriggerType()
		{
			return this.As<IGiantTriggerTypeT>();
		}

		// Token: 0x0602B93B RID: 178491 RVA: 0x005EEEF7 File Offset: 0x005ED0F7
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerType(IGiantTriggerTypeT _igianttriggertype)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerType,
				Value = _igianttriggertype
			};
		}

		// Token: 0x0602B93C RID: 178492 RVA: 0x005EEF0C File Offset: 0x005ED10C
		public IGiantTriggerRoleStateT AsIGiantTriggerRoleState()
		{
			return this.As<IGiantTriggerRoleStateT>();
		}

		// Token: 0x0602B93D RID: 178493 RVA: 0x005EEF14 File Offset: 0x005ED114
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerRoleState(IGiantTriggerRoleStateT _igianttriggerrolestate)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerRoleState,
				Value = _igianttriggerrolestate
			};
		}

		// Token: 0x0602B93E RID: 178494 RVA: 0x005EEF29 File Offset: 0x005ED129
		public IGiantTriggerStableValueT AsIGiantTriggerStableValue()
		{
			return this.As<IGiantTriggerStableValueT>();
		}

		// Token: 0x0602B93F RID: 178495 RVA: 0x005EEF31 File Offset: 0x005ED131
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerStableValue(IGiantTriggerStableValueT _igianttriggerstablevalue)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerStableValue,
				Value = _igianttriggerstablevalue
			};
		}

		// Token: 0x0602B940 RID: 178496 RVA: 0x005EEF46 File Offset: 0x005ED146
		public IGiantTriggerEnterAreaT AsIGiantTriggerEnterArea()
		{
			return this.As<IGiantTriggerEnterAreaT>();
		}

		// Token: 0x0602B941 RID: 178497 RVA: 0x005EEF4E File Offset: 0x005ED14E
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerEnterArea(IGiantTriggerEnterAreaT _igianttriggerenterarea)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerEnterArea,
				Value = _igianttriggerenterarea
			};
		}

		// Token: 0x0602B942 RID: 178498 RVA: 0x005EEF64 File Offset: 0x005ED164
		public static int Pack(FlatBufferBuilder builder, IGiantTriggerType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGiantTriggerType_Union.IGiantTriggerType:
				return IGiantTriggerType.Pack(builder, _o.AsIGiantTriggerType()).Value;
			case IGiantTriggerType_Union.IGiantTriggerRoleState:
				return IGiantTriggerRoleState.Pack(builder, _o.AsIGiantTriggerRoleState()).Value;
			case IGiantTriggerType_Union.IGiantTriggerStableValue:
				return IGiantTriggerStableValue.Pack(builder, _o.AsIGiantTriggerStableValue()).Value;
			case IGiantTriggerType_Union.IGiantTriggerEnterArea:
				return IGiantTriggerEnterArea.Pack(builder, _o.AsIGiantTriggerEnterArea()).Value;
			default:
				return 0;
			}
		}
	}
}
