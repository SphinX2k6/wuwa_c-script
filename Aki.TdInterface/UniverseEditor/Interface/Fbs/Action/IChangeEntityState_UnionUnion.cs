using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006968 RID: 26984
	public class IChangeEntityState_UnionUnion
	{
		// Token: 0x1700C6A2 RID: 50850
		// (get) Token: 0x0602E42A RID: 189482 RVA: 0x00651254 File Offset: 0x0064F454
		// (set) Token: 0x0602E42B RID: 189483 RVA: 0x0065125C File Offset: 0x0064F45C
		public IChangeEntityState_Union Type { get; set; }

		// Token: 0x1700C6A3 RID: 50851
		// (get) Token: 0x0602E42C RID: 189484 RVA: 0x00651265 File Offset: 0x0064F465
		// (set) Token: 0x0602E42D RID: 189485 RVA: 0x0065126D File Offset: 0x0064F46D
		public object Value { get; set; }

		// Token: 0x0602E42E RID: 189486 RVA: 0x00651276 File Offset: 0x0064F476
		public IChangeEntityState_UnionUnion()
		{
			this.Type = IChangeEntityState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E42F RID: 189487 RVA: 0x0065128C File Offset: 0x0064F48C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E430 RID: 189488 RVA: 0x0065129E File Offset: 0x0064F49E
		public IChangeEntityStateT AsIChangeEntityState()
		{
			return this.As<IChangeEntityStateT>();
		}

		// Token: 0x0602E431 RID: 189489 RVA: 0x006512A6 File Offset: 0x0064F4A6
		public static IChangeEntityState_UnionUnion FromIChangeEntityState(IChangeEntityStateT _ichangeentitystate)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityState,
				Value = _ichangeentitystate
			};
		}

		// Token: 0x0602E432 RID: 189490 RVA: 0x006512BB File Offset: 0x0064F4BB
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x0602E433 RID: 189491 RVA: 0x006512C3 File Offset: 0x0064F4C3
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x0602E434 RID: 189492 RVA: 0x006512D8 File Offset: 0x0064F4D8
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x0602E435 RID: 189493 RVA: 0x006512E0 File Offset: 0x0064F4E0
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x0602E436 RID: 189494 RVA: 0x006512F5 File Offset: 0x0064F4F5
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x0602E437 RID: 189495 RVA: 0x006512FD File Offset: 0x0064F4FD
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x0602E438 RID: 189496 RVA: 0x00651314 File Offset: 0x0064F514
		public static int Pack(FlatBufferBuilder builder, IChangeEntityState_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IChangeEntityState_Union.IChangeEntityState:
				return IChangeEntityState.Pack(builder, _o.AsIChangeEntityState()).Value;
			case IChangeEntityState_Union.IChangeEntityStateDirectly:
				return IChangeEntityStateDirectly.Pack(builder, _o.AsIChangeEntityStateDirectly()).Value;
			case IChangeEntityState_Union.IChangeEntityStateBatchDirectly:
				return IChangeEntityStateBatchDirectly.Pack(builder, _o.AsIChangeEntityStateBatchDirectly()).Value;
			case IChangeEntityState_Union.IChangeEntityStateLoop:
				return IChangeEntityStateLoop.Pack(builder, _o.AsIChangeEntityStateLoop()).Value;
			default:
				return 0;
			}
		}
	}
}
