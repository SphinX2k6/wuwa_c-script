using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E88 RID: 24200
	public class TGiantTriggerConditionUnion
	{
		// Token: 0x1700B4D7 RID: 46295
		// (get) Token: 0x06029724 RID: 169764 RVA: 0x005ADF82 File Offset: 0x005AC182
		// (set) Token: 0x06029725 RID: 169765 RVA: 0x005ADF8A File Offset: 0x005AC18A
		public TGiantTriggerCondition Type { get; set; }

		// Token: 0x1700B4D8 RID: 46296
		// (get) Token: 0x06029726 RID: 169766 RVA: 0x005ADF93 File Offset: 0x005AC193
		// (set) Token: 0x06029727 RID: 169767 RVA: 0x005ADF9B File Offset: 0x005AC19B
		public object Value { get; set; }

		// Token: 0x06029728 RID: 169768 RVA: 0x005ADFA4 File Offset: 0x005AC1A4
		public TGiantTriggerConditionUnion()
		{
			this.Type = TGiantTriggerCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06029729 RID: 169769 RVA: 0x005ADFBA File Offset: 0x005AC1BA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602972A RID: 169770 RVA: 0x005ADFCC File Offset: 0x005AC1CC
		public IGiantTriggerEnterAreaT AsIGiantTriggerEnterArea()
		{
			return this.As<IGiantTriggerEnterAreaT>();
		}

		// Token: 0x0602972B RID: 169771 RVA: 0x005ADFD4 File Offset: 0x005AC1D4
		public static TGiantTriggerConditionUnion FromIGiantTriggerEnterArea(IGiantTriggerEnterAreaT _igianttriggerenterarea)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerEnterArea,
				Value = _igianttriggerenterarea
			};
		}

		// Token: 0x0602972C RID: 169772 RVA: 0x005ADFE9 File Offset: 0x005AC1E9
		public IGiantTriggerRoleStateT AsIGiantTriggerRoleState()
		{
			return this.As<IGiantTriggerRoleStateT>();
		}

		// Token: 0x0602972D RID: 169773 RVA: 0x005ADFF1 File Offset: 0x005AC1F1
		public static TGiantTriggerConditionUnion FromIGiantTriggerRoleState(IGiantTriggerRoleStateT _igianttriggerrolestate)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerRoleState,
				Value = _igianttriggerrolestate
			};
		}

		// Token: 0x0602972E RID: 169774 RVA: 0x005AE006 File Offset: 0x005AC206
		public IGiantTriggerStableValueT AsIGiantTriggerStableValue()
		{
			return this.As<IGiantTriggerStableValueT>();
		}

		// Token: 0x0602972F RID: 169775 RVA: 0x005AE00E File Offset: 0x005AC20E
		public static TGiantTriggerConditionUnion FromIGiantTriggerStableValue(IGiantTriggerStableValueT _igianttriggerstablevalue)
		{
			return new TGiantTriggerConditionUnion
			{
				Type = TGiantTriggerCondition.IGiantTriggerStableValue,
				Value = _igianttriggerstablevalue
			};
		}

		// Token: 0x06029730 RID: 169776 RVA: 0x005AE024 File Offset: 0x005AC224
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
