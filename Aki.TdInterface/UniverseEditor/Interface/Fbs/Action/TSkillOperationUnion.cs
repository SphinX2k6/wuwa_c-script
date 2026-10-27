using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007793 RID: 30611
	public class TSkillOperationUnion
	{
		// Token: 0x1700E6A5 RID: 59045
		// (get) Token: 0x06037910 RID: 227600 RVA: 0x00784A1C File Offset: 0x00782C1C
		// (set) Token: 0x06037911 RID: 227601 RVA: 0x00784A24 File Offset: 0x00782C24
		public TSkillOperation Type { get; set; }

		// Token: 0x1700E6A6 RID: 59046
		// (get) Token: 0x06037912 RID: 227602 RVA: 0x00784A2D File Offset: 0x00782C2D
		// (set) Token: 0x06037913 RID: 227603 RVA: 0x00784A35 File Offset: 0x00782C35
		public object Value { get; set; }

		// Token: 0x06037914 RID: 227604 RVA: 0x00784A3E File Offset: 0x00782C3E
		public TSkillOperationUnion()
		{
			this.Type = TSkillOperation.NONE;
			this.Value = null;
		}

		// Token: 0x06037915 RID: 227605 RVA: 0x00784A54 File Offset: 0x00782C54
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037916 RID: 227606 RVA: 0x00784A66 File Offset: 0x00782C66
		public IDisableSectionalSkillOperationT AsIDisableSectionalSkillOperation()
		{
			return this.As<IDisableSectionalSkillOperationT>();
		}

		// Token: 0x06037917 RID: 227607 RVA: 0x00784A6E File Offset: 0x00782C6E
		public static TSkillOperationUnion FromIDisableSectionalSkillOperation(IDisableSectionalSkillOperationT _idisablesectionalskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IDisableSectionalSkillOperation,
				Value = _idisablesectionalskilloperation
			};
		}

		// Token: 0x06037918 RID: 227608 RVA: 0x00784A83 File Offset: 0x00782C83
		public IDisableSkillOperationT AsIDisableSkillOperation()
		{
			return this.As<IDisableSkillOperationT>();
		}

		// Token: 0x06037919 RID: 227609 RVA: 0x00784A8B File Offset: 0x00782C8B
		public static TSkillOperationUnion FromIDisableSkillOperation(IDisableSkillOperationT _idisableskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IDisableSkillOperation,
				Value = _idisableskilloperation
			};
		}

		// Token: 0x0603791A RID: 227610 RVA: 0x00784AA0 File Offset: 0x00782CA0
		public IEnableSkillOperationT AsIEnableSkillOperation()
		{
			return this.As<IEnableSkillOperationT>();
		}

		// Token: 0x0603791B RID: 227611 RVA: 0x00784AA8 File Offset: 0x00782CA8
		public static TSkillOperationUnion FromIEnableSkillOperation(IEnableSkillOperationT _ienableskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IEnableSkillOperation,
				Value = _ienableskilloperation
			};
		}

		// Token: 0x0603791C RID: 227612 RVA: 0x00784AC0 File Offset: 0x00782CC0
		public static int Pack(FlatBufferBuilder builder, TSkillOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TSkillOperation.IDisableSectionalSkillOperation:
				return IDisableSectionalSkillOperation.Pack(builder, _o.AsIDisableSectionalSkillOperation()).Value;
			case TSkillOperation.IDisableSkillOperation:
				return IDisableSkillOperation.Pack(builder, _o.AsIDisableSkillOperation()).Value;
			case TSkillOperation.IEnableSkillOperation:
				return IEnableSkillOperation.Pack(builder, _o.AsIEnableSkillOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
