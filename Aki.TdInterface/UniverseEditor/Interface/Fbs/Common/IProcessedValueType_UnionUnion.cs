using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E49 RID: 24137
	public class IProcessedValueType_UnionUnion
	{
		// Token: 0x1700B474 RID: 46196
		// (get) Token: 0x06029513 RID: 169235 RVA: 0x005AA2DD File Offset: 0x005A84DD
		// (set) Token: 0x06029514 RID: 169236 RVA: 0x005AA2E5 File Offset: 0x005A84E5
		public IProcessedValueType_Union Type { get; set; }

		// Token: 0x1700B475 RID: 46197
		// (get) Token: 0x06029515 RID: 169237 RVA: 0x005AA2EE File Offset: 0x005A84EE
		// (set) Token: 0x06029516 RID: 169238 RVA: 0x005AA2F6 File Offset: 0x005A84F6
		public object Value { get; set; }

		// Token: 0x06029517 RID: 169239 RVA: 0x005AA2FF File Offset: 0x005A84FF
		public IProcessedValueType_UnionUnion()
		{
			this.Type = IProcessedValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029518 RID: 169240 RVA: 0x005AA315 File Offset: 0x005A8515
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029519 RID: 169241 RVA: 0x005AA327 File Offset: 0x005A8527
		public IProcessedValueTypeT AsIProcessedValueType()
		{
			return this.As<IProcessedValueTypeT>();
		}

		// Token: 0x0602951A RID: 169242 RVA: 0x005AA32F File Offset: 0x005A852F
		public static IProcessedValueType_UnionUnion FromIProcessedValueType(IProcessedValueTypeT _iprocessedvaluetype)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueType,
				Value = _iprocessedvaluetype
			};
		}

		// Token: 0x0602951B RID: 169243 RVA: 0x005AA344 File Offset: 0x005A8544
		public IProcessedValueConstantT AsIProcessedValueConstant()
		{
			return this.As<IProcessedValueConstantT>();
		}

		// Token: 0x0602951C RID: 169244 RVA: 0x005AA34C File Offset: 0x005A854C
		public static IProcessedValueType_UnionUnion FromIProcessedValueConstant(IProcessedValueConstantT _iprocessedvalueconstant)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueConstant,
				Value = _iprocessedvalueconstant
			};
		}

		// Token: 0x0602951D RID: 169245 RVA: 0x005AA361 File Offset: 0x005A8561
		public IProcessedValueConstraintT AsIProcessedValueConstraint()
		{
			return this.As<IProcessedValueConstraintT>();
		}

		// Token: 0x0602951E RID: 169246 RVA: 0x005AA369 File Offset: 0x005A8569
		public static IProcessedValueType_UnionUnion FromIProcessedValueConstraint(IProcessedValueConstraintT _iprocessedvalueconstraint)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueConstraint,
				Value = _iprocessedvalueconstraint
			};
		}

		// Token: 0x0602951F RID: 169247 RVA: 0x005AA380 File Offset: 0x005A8580
		public static int Pack(FlatBufferBuilder builder, IProcessedValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IProcessedValueType_Union.IProcessedValueType:
				return IProcessedValueType.Pack(builder, _o.AsIProcessedValueType()).Value;
			case IProcessedValueType_Union.IProcessedValueConstant:
				return IProcessedValueConstant.Pack(builder, _o.AsIProcessedValueConstant()).Value;
			case IProcessedValueType_Union.IProcessedValueConstraint:
				return IProcessedValueConstraint.Pack(builder, _o.AsIProcessedValueConstraint()).Value;
			default:
				return 0;
			}
		}
	}
}
