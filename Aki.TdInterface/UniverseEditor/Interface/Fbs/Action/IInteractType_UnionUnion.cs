using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AC RID: 27052
	public class IInteractType_UnionUnion
	{
		// Token: 0x1700C8A8 RID: 51368
		// (get) Token: 0x0602F42B RID: 193579 RVA: 0x0066FF01 File Offset: 0x0066E101
		// (set) Token: 0x0602F42C RID: 193580 RVA: 0x0066FF09 File Offset: 0x0066E109
		public IInteractType_Union Type { get; set; }

		// Token: 0x1700C8A9 RID: 51369
		// (get) Token: 0x0602F42D RID: 193581 RVA: 0x0066FF12 File Offset: 0x0066E112
		// (set) Token: 0x0602F42E RID: 193582 RVA: 0x0066FF1A File Offset: 0x0066E11A
		public object Value { get; set; }

		// Token: 0x0602F42F RID: 193583 RVA: 0x0066FF23 File Offset: 0x0066E123
		public IInteractType_UnionUnion()
		{
			this.Type = IInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F430 RID: 193584 RVA: 0x0066FF39 File Offset: 0x0066E139
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F431 RID: 193585 RVA: 0x0066FF4B File Offset: 0x0066E14B
		public IInteractTypeT AsIInteractType()
		{
			return this.As<IInteractTypeT>();
		}

		// Token: 0x0602F432 RID: 193586 RVA: 0x0066FF53 File Offset: 0x0066E153
		public static IInteractType_UnionUnion FromIInteractType(IInteractTypeT _iinteracttype)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractType,
				Value = _iinteracttype
			};
		}

		// Token: 0x0602F433 RID: 193587 RVA: 0x0066FF68 File Offset: 0x0066E168
		public IInteractFlowT AsIInteractFlow()
		{
			return this.As<IInteractFlowT>();
		}

		// Token: 0x0602F434 RID: 193588 RVA: 0x0066FF70 File Offset: 0x0066E170
		public static IInteractType_UnionUnion FromIInteractFlow(IInteractFlowT _iinteractflow)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractFlow,
				Value = _iinteractflow
			};
		}

		// Token: 0x0602F435 RID: 193589 RVA: 0x0066FF85 File Offset: 0x0066E185
		public IInteractActionsT AsIInteractActions()
		{
			return this.As<IInteractActionsT>();
		}

		// Token: 0x0602F436 RID: 193590 RVA: 0x0066FF8D File Offset: 0x0066E18D
		public static IInteractType_UnionUnion FromIInteractActions(IInteractActionsT _iinteractactions)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractActions,
				Value = _iinteractactions
			};
		}

		// Token: 0x0602F437 RID: 193591 RVA: 0x0066FFA4 File Offset: 0x0066E1A4
		public static int Pack(FlatBufferBuilder builder, IInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractType_Union.IInteractType:
				return IInteractType.Pack(builder, _o.AsIInteractType()).Value;
			case IInteractType_Union.IInteractFlow:
				return IInteractFlow.Pack(builder, _o.AsIInteractFlow()).Value;
			case IInteractType_Union.IInteractActions:
				return IInteractActions.Pack(builder, _o.AsIInteractActions()).Value;
			default:
				return 0;
			}
		}
	}
}
