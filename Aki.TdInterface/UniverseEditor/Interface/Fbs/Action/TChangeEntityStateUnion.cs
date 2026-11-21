using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E71 RID: 32369
	public class TChangeEntityStateUnion
	{
		// Token: 0x1700F213 RID: 61971
		// (get) Token: 0x0603A755 RID: 239445 RVA: 0x007DEB56 File Offset: 0x007DCD56
		// (set) Token: 0x0603A756 RID: 239446 RVA: 0x007DEB5E File Offset: 0x007DCD5E
		public TChangeEntityState Type { get; set; }

		// Token: 0x1700F214 RID: 61972
		// (get) Token: 0x0603A757 RID: 239447 RVA: 0x007DEB67 File Offset: 0x007DCD67
		// (set) Token: 0x0603A758 RID: 239448 RVA: 0x007DEB6F File Offset: 0x007DCD6F
		public object Value { get; set; }

		// Token: 0x0603A759 RID: 239449 RVA: 0x007DEB78 File Offset: 0x007DCD78
		public TChangeEntityStateUnion()
		{
			this.Type = TChangeEntityState.NONE;
			this.Value = null;
		}

		// Token: 0x0603A75A RID: 239450 RVA: 0x007DEB8E File Offset: 0x007DCD8E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A75B RID: 239451 RVA: 0x007DEBA0 File Offset: 0x007DCDA0
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x0603A75C RID: 239452 RVA: 0x007DEBA8 File Offset: 0x007DCDA8
		public static TChangeEntityStateUnion FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x0603A75D RID: 239453 RVA: 0x007DEBBD File Offset: 0x007DCDBD
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x0603A75E RID: 239454 RVA: 0x007DEBC5 File Offset: 0x007DCDC5
		public static TChangeEntityStateUnion FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x0603A75F RID: 239455 RVA: 0x007DEBDA File Offset: 0x007DCDDA
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x0603A760 RID: 239456 RVA: 0x007DEBE2 File Offset: 0x007DCDE2
		public static TChangeEntityStateUnion FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x0603A761 RID: 239457 RVA: 0x007DEBF8 File Offset: 0x007DCDF8
		public static int Pack(FlatBufferBuilder builder, TChangeEntityStateUnion _o)
		{
			switch (_o.Type)
			{
			case TChangeEntityState.IChangeEntityStateBatchDirectly:
				return IChangeEntityStateBatchDirectly.Pack(builder, _o.AsIChangeEntityStateBatchDirectly()).Value;
			case TChangeEntityState.IChangeEntityStateDirectly:
				return IChangeEntityStateDirectly.Pack(builder, _o.AsIChangeEntityStateDirectly()).Value;
			case TChangeEntityState.IChangeEntityStateLoop:
				return IChangeEntityStateLoop.Pack(builder, _o.AsIChangeEntityStateLoop()).Value;
			default:
				return 0;
			}
		}
	}
}
