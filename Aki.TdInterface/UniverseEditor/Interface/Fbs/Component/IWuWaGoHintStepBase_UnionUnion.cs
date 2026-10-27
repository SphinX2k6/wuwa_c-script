using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB6 RID: 23478
	public class IWuWaGoHintStepBase_UnionUnion
	{
		// Token: 0x1700B166 RID: 45414
		// (get) Token: 0x06028349 RID: 164681 RVA: 0x0058650D File Offset: 0x0058470D
		// (set) Token: 0x0602834A RID: 164682 RVA: 0x00586515 File Offset: 0x00584715
		public IWuWaGoHintStepBase_Union Type { get; set; }

		// Token: 0x1700B167 RID: 45415
		// (get) Token: 0x0602834B RID: 164683 RVA: 0x0058651E File Offset: 0x0058471E
		// (set) Token: 0x0602834C RID: 164684 RVA: 0x00586526 File Offset: 0x00584726
		public object Value { get; set; }

		// Token: 0x0602834D RID: 164685 RVA: 0x0058652F File Offset: 0x0058472F
		public IWuWaGoHintStepBase_UnionUnion()
		{
			this.Type = IWuWaGoHintStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602834E RID: 164686 RVA: 0x00586545 File Offset: 0x00584745
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602834F RID: 164687 RVA: 0x00586557 File Offset: 0x00584757
		public IWuWaGoHintStepBaseT AsIWuWaGoHintStepBase()
		{
			return this.As<IWuWaGoHintStepBaseT>();
		}

		// Token: 0x06028350 RID: 164688 RVA: 0x0058655F File Offset: 0x0058475F
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepBase(IWuWaGoHintStepBaseT _iwuwagohintstepbase)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepBase,
				Value = _iwuwagohintstepbase
			};
		}

		// Token: 0x06028351 RID: 164689 RVA: 0x00586574 File Offset: 0x00584774
		public IWuWaGoHintStepMoveT AsIWuWaGoHintStepMove()
		{
			return this.As<IWuWaGoHintStepMoveT>();
		}

		// Token: 0x06028352 RID: 164690 RVA: 0x0058657C File Offset: 0x0058477C
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepMove(IWuWaGoHintStepMoveT _iwuwagohintstepmove)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepMove,
				Value = _iwuwagohintstepmove
			};
		}

		// Token: 0x06028353 RID: 164691 RVA: 0x00586591 File Offset: 0x00584791
		public IWuWaGoHintStepInteractT AsIWuWaGoHintStepInteract()
		{
			return this.As<IWuWaGoHintStepInteractT>();
		}

		// Token: 0x06028354 RID: 164692 RVA: 0x00586599 File Offset: 0x00584799
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepInteract(IWuWaGoHintStepInteractT _iwuwagohintstepinteract)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepInteract,
				Value = _iwuwagohintstepinteract
			};
		}

		// Token: 0x06028355 RID: 164693 RVA: 0x005865B0 File Offset: 0x005847B0
		public static int Pack(FlatBufferBuilder builder, IWuWaGoHintStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepBase:
				return IWuWaGoHintStepBase.Pack(builder, _o.AsIWuWaGoHintStepBase()).Value;
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepMove:
				return IWuWaGoHintStepMove.Pack(builder, _o.AsIWuWaGoHintStepMove()).Value;
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepInteract:
				return IWuWaGoHintStepInteract.Pack(builder, _o.AsIWuWaGoHintStepInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
