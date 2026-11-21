using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705F RID: 28767
	public class IInteractType_UnionUnion
	{
		// Token: 0x1700D2AD RID: 53933
		// (get) Token: 0x06031E07 RID: 204295 RVA: 0x006C0605 File Offset: 0x006BE805
		// (set) Token: 0x06031E08 RID: 204296 RVA: 0x006C060D File Offset: 0x006BE80D
		public IInteractType_Union Type { get; set; }

		// Token: 0x1700D2AE RID: 53934
		// (get) Token: 0x06031E09 RID: 204297 RVA: 0x006C0616 File Offset: 0x006BE816
		// (set) Token: 0x06031E0A RID: 204298 RVA: 0x006C061E File Offset: 0x006BE81E
		public object Value { get; set; }

		// Token: 0x06031E0B RID: 204299 RVA: 0x006C0627 File Offset: 0x006BE827
		public IInteractType_UnionUnion()
		{
			this.Type = IInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031E0C RID: 204300 RVA: 0x006C063D File Offset: 0x006BE83D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031E0D RID: 204301 RVA: 0x006C064F File Offset: 0x006BE84F
		public IInteractTypeT AsIInteractType()
		{
			return this.As<IInteractTypeT>();
		}

		// Token: 0x06031E0E RID: 204302 RVA: 0x006C0657 File Offset: 0x006BE857
		public static IInteractType_UnionUnion FromIInteractType(IInteractTypeT _iinteracttype)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractType,
				Value = _iinteracttype
			};
		}

		// Token: 0x06031E0F RID: 204303 RVA: 0x006C066C File Offset: 0x006BE86C
		public IInteractFlowT AsIInteractFlow()
		{
			return this.As<IInteractFlowT>();
		}

		// Token: 0x06031E10 RID: 204304 RVA: 0x006C0674 File Offset: 0x006BE874
		public static IInteractType_UnionUnion FromIInteractFlow(IInteractFlowT _iinteractflow)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractFlow,
				Value = _iinteractflow
			};
		}

		// Token: 0x06031E11 RID: 204305 RVA: 0x006C0689 File Offset: 0x006BE889
		public IInteractActionsT AsIInteractActions()
		{
			return this.As<IInteractActionsT>();
		}

		// Token: 0x06031E12 RID: 204306 RVA: 0x006C0691 File Offset: 0x006BE891
		public static IInteractType_UnionUnion FromIInteractActions(IInteractActionsT _iinteractactions)
		{
			return new IInteractType_UnionUnion
			{
				Type = IInteractType_Union.IInteractActions,
				Value = _iinteractactions
			};
		}

		// Token: 0x06031E13 RID: 204307 RVA: 0x006C06A8 File Offset: 0x006BE8A8
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
