using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064CB RID: 25803
	public class TGiantTriggerConditionUnion
	{
		// Token: 0x1700BE42 RID: 48706
		// (get) Token: 0x0602BDCC RID: 179660 RVA: 0x005F6F26 File Offset: 0x005F5126
		// (set) Token: 0x0602BDCD RID: 179661 RVA: 0x005F6F2E File Offset: 0x005F512E
		public TGiantTriggerCondition Type { get; set; }

		// Token: 0x1700BE43 RID: 48707
		// (get) Token: 0x0602BDCE RID: 179662 RVA: 0x005F6F37 File Offset: 0x005F5137
		// (set) Token: 0x0602BDCF RID: 179663 RVA: 0x005F6F3F File Offset: 0x005F513F
		public object Value { get; set; }

		// Token: 0x0602BDD0 RID: 179664 RVA: 0x005F6F48 File Offset: 0x005F5148
		public TGiantTriggerConditionUnion()
		{
			this.Type = TGiantTriggerCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDD1 RID: 179665 RVA: 0x005F6F5E File Offset: 0x005F515E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDD2 RID: 179666 RVA: 0x005F6F70 File Offset: 0x005F5170
		public IGiantTriggerEnterAreaT AsIGiantTriggerEnterArea()
		{
			return this.As<IGiantTriggerEnterAreaT>();
		}

		// Token: 0x0602BDD3 RID: 179667 RVA: 0x005F6F78 File Offset: 0x005F5178
		public static TGiantTriggerConditionUnion FromIGiantTriggerEnterArea(IGiantTriggerEnterAreaT _igianttriggerenterarea)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerEnterArea,
				Value = _igianttriggerenterarea
			};
		}

		// Token: 0x0602BDD4 RID: 179668 RVA: 0x005F6F8D File Offset: 0x005F518D
		public IGiantTriggerRoleStateT AsIGiantTriggerRoleState()
		{
			return this.As<IGiantTriggerRoleStateT>();
		}

		// Token: 0x0602BDD5 RID: 179669 RVA: 0x005F6F95 File Offset: 0x005F5195
		public static TGiantTriggerConditionUnion FromIGiantTriggerRoleState(IGiantTriggerRoleStateT _igianttriggerrolestate)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerRoleState,
				Value = _igianttriggerrolestate
			};
		}

		// Token: 0x0602BDD6 RID: 179670 RVA: 0x005F6FAA File Offset: 0x005F51AA
		public IGiantTriggerStableValueT AsIGiantTriggerStableValue()
		{
			return this.As<IGiantTriggerStableValueT>();
		}

		// Token: 0x0602BDD7 RID: 179671 RVA: 0x005F6FB2 File Offset: 0x005F51B2
		public static TGiantTriggerConditionUnion FromIGiantTriggerStableValue(IGiantTriggerStableValueT _igianttriggerstablevalue)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerStableValue,
				Value = _igianttriggerstablevalue
			};
		}

		// Token: 0x0602BDD8 RID: 179672 RVA: 0x005F6FC8 File Offset: 0x005F51C8
		public static int Pack(FlatBufferBuilder builder, TGiantTriggerConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TGiantTriggerCondition.IGiantTriggerEnterArea:
				return IGiantTriggerEnterArea.Pack(builder, _o.AsIGiantTriggerEnterArea()).Value;
			case TGiantTriggerCondition.IGiantTriggerRoleState:
				return IGiantTriggerRoleState.Pack(builder, _o.AsIGiantTriggerRoleState()).Value;
			case TGiantTriggerCondition.IGiantTriggerStableValue:
				return IGiantTriggerStableValue.Pack(builder, _o.AsIGiantTriggerStableValue()).Value;
			default:
				return 0;
			}
		}
	}
}
