using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DC RID: 27100
	public class ICheckFlowLookAtTarget_UnionUnion
	{
		// Token: 0x1700C764 RID: 51044
		// (get) Token: 0x0602E7DB RID: 190427 RVA: 0x00657C29 File Offset: 0x00655E29
		// (set) Token: 0x0602E7DC RID: 190428 RVA: 0x00657C31 File Offset: 0x00655E31
		public ICheckFlowLookAtTarget_Union Type { get; set; }

		// Token: 0x1700C765 RID: 51045
		// (get) Token: 0x0602E7DD RID: 190429 RVA: 0x00657C3A File Offset: 0x00655E3A
		// (set) Token: 0x0602E7DE RID: 190430 RVA: 0x00657C42 File Offset: 0x00655E42
		public object Value { get; set; }

		// Token: 0x0602E7DF RID: 190431 RVA: 0x00657C4B File Offset: 0x00655E4B
		public ICheckFlowLookAtTarget_UnionUnion()
		{
			this.Type = ICheckFlowLookAtTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E7E0 RID: 190432 RVA: 0x00657C61 File Offset: 0x00655E61
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E7E1 RID: 190433 RVA: 0x00657C73 File Offset: 0x00655E73
		public ICheckFlowLookAtTargetT AsICheckFlowLookAtTarget()
		{
			return this.As<ICheckFlowLookAtTargetT>();
		}

		// Token: 0x0602E7E2 RID: 190434 RVA: 0x00657C7B File Offset: 0x00655E7B
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtTarget(ICheckFlowLookAtTargetT _icheckflowlookattarget)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtTarget,
				Value = _icheckflowlookattarget
			};
		}

		// Token: 0x0602E7E3 RID: 190435 RVA: 0x00657C90 File Offset: 0x00655E90
		public ICheckFlowLookAtEntityT AsICheckFlowLookAtEntity()
		{
			return this.As<ICheckFlowLookAtEntityT>();
		}

		// Token: 0x0602E7E4 RID: 190436 RVA: 0x00657C98 File Offset: 0x00655E98
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtEntity(ICheckFlowLookAtEntityT _icheckflowlookatentity)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtEntity,
				Value = _icheckflowlookatentity
			};
		}

		// Token: 0x0602E7E5 RID: 190437 RVA: 0x00657CAD File Offset: 0x00655EAD
		public ICheckFlowLookAtPlayerT AsICheckFlowLookAtPlayer()
		{
			return this.As<ICheckFlowLookAtPlayerT>();
		}

		// Token: 0x0602E7E6 RID: 190438 RVA: 0x00657CB5 File Offset: 0x00655EB5
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtPlayer(ICheckFlowLookAtPlayerT _icheckflowlookatplayer)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtPlayer,
				Value = _icheckflowlookatplayer
			};
		}

		// Token: 0x0602E7E7 RID: 190439 RVA: 0x00657CCC File Offset: 0x00655ECC
		public static int Pack(FlatBufferBuilder builder, ICheckFlowLookAtTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtTarget:
				return ICheckFlowLookAtTarget.Pack(builder, _o.AsICheckFlowLookAtTarget()).Value;
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtEntity:
				return ICheckFlowLookAtEntity.Pack(builder, _o.AsICheckFlowLookAtEntity()).Value;
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtPlayer:
				return ICheckFlowLookAtPlayer.Pack(builder, _o.AsICheckFlowLookAtPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
