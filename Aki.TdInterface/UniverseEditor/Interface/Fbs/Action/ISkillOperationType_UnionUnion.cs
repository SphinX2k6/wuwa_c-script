using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007134 RID: 28980
	public class ISkillOperationType_UnionUnion
	{
		// Token: 0x1700D75E RID: 55134
		// (get) Token: 0x06033605 RID: 210437 RVA: 0x006ECAC9 File Offset: 0x006EACC9
		// (set) Token: 0x06033606 RID: 210438 RVA: 0x006ECAD1 File Offset: 0x006EACD1
		public ISkillOperationType_Union Type { get; set; }

		// Token: 0x1700D75F RID: 55135
		// (get) Token: 0x06033607 RID: 210439 RVA: 0x006ECADA File Offset: 0x006EACDA
		// (set) Token: 0x06033608 RID: 210440 RVA: 0x006ECAE2 File Offset: 0x006EACE2
		public object Value { get; set; }

		// Token: 0x06033609 RID: 210441 RVA: 0x006ECAEB File Offset: 0x006EACEB
		public ISkillOperationType_UnionUnion()
		{
			this.Type = ISkillOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603360A RID: 210442 RVA: 0x006ECB01 File Offset: 0x006EAD01
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603360B RID: 210443 RVA: 0x006ECB13 File Offset: 0x006EAD13
		public ISkillOperationTypeT AsISkillOperationType()
		{
			return this.As<ISkillOperationTypeT>();
		}

		// Token: 0x0603360C RID: 210444 RVA: 0x006ECB1B File Offset: 0x006EAD1B
		public static ISkillOperationType_UnionUnion FromISkillOperationType(ISkillOperationTypeT _iskilloperationtype)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.ISkillOperationType,
				Value = _iskilloperationtype
			};
		}

		// Token: 0x0603360D RID: 210445 RVA: 0x006ECB30 File Offset: 0x006EAD30
		public IEnableSkillOperationT AsIEnableSkillOperation()
		{
			return this.As<IEnableSkillOperationT>();
		}

		// Token: 0x0603360E RID: 210446 RVA: 0x006ECB38 File Offset: 0x006EAD38
		public static ISkillOperationType_UnionUnion FromIEnableSkillOperation(IEnableSkillOperationT _ienableskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IEnableSkillOperation,
				Value = _ienableskilloperation
			};
		}

		// Token: 0x0603360F RID: 210447 RVA: 0x006ECB4D File Offset: 0x006EAD4D
		public IDisableSkillOperationT AsIDisableSkillOperation()
		{
			return this.As<IDisableSkillOperationT>();
		}

		// Token: 0x06033610 RID: 210448 RVA: 0x006ECB55 File Offset: 0x006EAD55
		public static ISkillOperationType_UnionUnion FromIDisableSkillOperation(IDisableSkillOperationT _idisableskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IDisableSkillOperation,
				Value = _idisableskilloperation
			};
		}

		// Token: 0x06033611 RID: 210449 RVA: 0x006ECB6A File Offset: 0x006EAD6A
		public IDisableSectionalSkillOperationT AsIDisableSectionalSkillOperation()
		{
			return this.As<IDisableSectionalSkillOperationT>();
		}

		// Token: 0x06033612 RID: 210450 RVA: 0x006ECB72 File Offset: 0x006EAD72
		public static ISkillOperationType_UnionUnion FromIDisableSectionalSkillOperation(IDisableSectionalSkillOperationT _idisablesectionalskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IDisableSectionalSkillOperation,
				Value = _idisablesectionalskilloperation
			};
		}

		// Token: 0x06033613 RID: 210451 RVA: 0x006ECB88 File Offset: 0x006EAD88
		public static int Pack(FlatBufferBuilder builder, ISkillOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISkillOperationType_Union.ISkillOperationType:
				return ISkillOperationType.Pack(builder, _o.AsISkillOperationType()).Value;
			case ISkillOperationType_Union.IEnableSkillOperation:
				return IEnableSkillOperation.Pack(builder, _o.AsIEnableSkillOperation()).Value;
			case ISkillOperationType_Union.IDisableSkillOperation:
				return IDisableSkillOperation.Pack(builder, _o.AsIDisableSkillOperation()).Value;
			case ISkillOperationType_Union.IDisableSectionalSkillOperation:
				return IDisableSectionalSkillOperation.Pack(builder, _o.AsIDisableSectionalSkillOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
