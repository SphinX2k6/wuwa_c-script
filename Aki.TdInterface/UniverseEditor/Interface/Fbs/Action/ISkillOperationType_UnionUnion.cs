using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007900 RID: 30976
	public class ISkillOperationType_UnionUnion
	{
		// Token: 0x1700E341 RID: 58177
		// (get) Token: 0x060368A7 RID: 223399 RVA: 0x0074D0D5 File Offset: 0x0074B2D5
		// (set) Token: 0x060368A8 RID: 223400 RVA: 0x0074D0DD File Offset: 0x0074B2DD
		public ISkillOperationType_Union Type { get; set; }

		// Token: 0x1700E342 RID: 58178
		// (get) Token: 0x060368A9 RID: 223401 RVA: 0x0074D0E6 File Offset: 0x0074B2E6
		// (set) Token: 0x060368AA RID: 223402 RVA: 0x0074D0EE File Offset: 0x0074B2EE
		public object Value { get; set; }

		// Token: 0x060368AB RID: 223403 RVA: 0x0074D0F7 File Offset: 0x0074B2F7
		public ISkillOperationType_UnionUnion()
		{
			this.Type = ISkillOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060368AC RID: 223404 RVA: 0x0074D10D File Offset: 0x0074B30D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060368AD RID: 223405 RVA: 0x0074D11F File Offset: 0x0074B31F
		public ISkillOperationTypeT AsISkillOperationType()
		{
			return this.As<ISkillOperationTypeT>();
		}

		// Token: 0x060368AE RID: 223406 RVA: 0x0074D127 File Offset: 0x0074B327
		public static ISkillOperationType_UnionUnion FromISkillOperationType(ISkillOperationTypeT _iskilloperationtype)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.ISkillOperationType,
				Value = _iskilloperationtype
			};
		}

		// Token: 0x060368AF RID: 223407 RVA: 0x0074D13C File Offset: 0x0074B33C
		public IEnableSkillOperationT AsIEnableSkillOperation()
		{
			return this.As<IEnableSkillOperationT>();
		}

		// Token: 0x060368B0 RID: 223408 RVA: 0x0074D144 File Offset: 0x0074B344
		public static ISkillOperationType_UnionUnion FromIEnableSkillOperation(IEnableSkillOperationT _ienableskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IEnableSkillOperation,
				Value = _ienableskilloperation
			};
		}

		// Token: 0x060368B1 RID: 223409 RVA: 0x0074D159 File Offset: 0x0074B359
		public IDisableSkillOperationT AsIDisableSkillOperation()
		{
			return this.As<IDisableSkillOperationT>();
		}

		// Token: 0x060368B2 RID: 223410 RVA: 0x0074D161 File Offset: 0x0074B361
		public static ISkillOperationType_UnionUnion FromIDisableSkillOperation(IDisableSkillOperationT _idisableskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IDisableSkillOperation,
				Value = _idisableskilloperation
			};
		}

		// Token: 0x060368B3 RID: 223411 RVA: 0x0074D176 File Offset: 0x0074B376
		public IDisableSectionalSkillOperationT AsIDisableSectionalSkillOperation()
		{
			return this.As<IDisableSectionalSkillOperationT>();
		}

		// Token: 0x060368B4 RID: 223412 RVA: 0x0074D17E File Offset: 0x0074B37E
		public static ISkillOperationType_UnionUnion FromIDisableSectionalSkillOperation(IDisableSectionalSkillOperationT _idisablesectionalskilloperation)
		{
			return new ISkillOperationType_UnionUnion
			{
				Type = ISkillOperationType_Union.IDisableSectionalSkillOperation,
				Value = _idisablesectionalskilloperation
			};
		}

		// Token: 0x060368B5 RID: 223413 RVA: 0x0074D194 File Offset: 0x0074B394
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
