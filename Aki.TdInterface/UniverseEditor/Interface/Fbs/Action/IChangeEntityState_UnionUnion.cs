using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F7 RID: 25335
	public class IChangeEntityState_UnionUnion
	{
		// Token: 0x1700BD18 RID: 48408
		// (get) Token: 0x0602BCC1 RID: 179393 RVA: 0x00606248 File Offset: 0x00604448
		// (set) Token: 0x0602BCC2 RID: 179394 RVA: 0x00606250 File Offset: 0x00604450
		public IChangeEntityState_Union Type { get; set; }

		// Token: 0x1700BD19 RID: 48409
		// (get) Token: 0x0602BCC3 RID: 179395 RVA: 0x00606259 File Offset: 0x00604459
		// (set) Token: 0x0602BCC4 RID: 179396 RVA: 0x00606261 File Offset: 0x00604461
		public object Value { get; set; }

		// Token: 0x0602BCC5 RID: 179397 RVA: 0x0060626A File Offset: 0x0060446A
		public IChangeEntityState_UnionUnion()
		{
			this.Type = IChangeEntityState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BCC6 RID: 179398 RVA: 0x00606280 File Offset: 0x00604480
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BCC7 RID: 179399 RVA: 0x00606292 File Offset: 0x00604492
		public IChangeEntityStateT AsIChangeEntityState()
		{
			return this.As<IChangeEntityStateT>();
		}

		// Token: 0x0602BCC8 RID: 179400 RVA: 0x0060629A File Offset: 0x0060449A
		public static IChangeEntityState_UnionUnion FromIChangeEntityState(IChangeEntityStateT _ichangeentitystate)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityState,
				Value = _ichangeentitystate
			};
		}

		// Token: 0x0602BCC9 RID: 179401 RVA: 0x006062AF File Offset: 0x006044AF
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x0602BCCA RID: 179402 RVA: 0x006062B7 File Offset: 0x006044B7
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x0602BCCB RID: 179403 RVA: 0x006062CC File Offset: 0x006044CC
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x0602BCCC RID: 179404 RVA: 0x006062D4 File Offset: 0x006044D4
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x0602BCCD RID: 179405 RVA: 0x006062E9 File Offset: 0x006044E9
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x0602BCCE RID: 179406 RVA: 0x006062F1 File Offset: 0x006044F1
		public static IChangeEntityState_UnionUnion FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new IChangeEntityState_UnionUnion
			{
				Type = IChangeEntityState_Union.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x0602BCCF RID: 179407 RVA: 0x00606308 File Offset: 0x00604508
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
