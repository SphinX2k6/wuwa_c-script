using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDF RID: 23775
	public class TWuWaGoHintStepUnion
	{
		// Token: 0x1700B272 RID: 45682
		// (get) Token: 0x06028AE7 RID: 166631 RVA: 0x005968DA File Offset: 0x00594ADA
		// (set) Token: 0x06028AE8 RID: 166632 RVA: 0x005968E2 File Offset: 0x00594AE2
		public TWuWaGoHintStep Type { get; set; }

		// Token: 0x1700B273 RID: 45683
		// (get) Token: 0x06028AE9 RID: 166633 RVA: 0x005968EB File Offset: 0x00594AEB
		// (set) Token: 0x06028AEA RID: 166634 RVA: 0x005968F3 File Offset: 0x00594AF3
		public object Value { get; set; }

		// Token: 0x06028AEB RID: 166635 RVA: 0x005968FC File Offset: 0x00594AFC
		public TWuWaGoHintStepUnion()
		{
			this.Type = TWuWaGoHintStep.NONE;
			this.Value = null;
		}

		// Token: 0x06028AEC RID: 166636 RVA: 0x00596912 File Offset: 0x00594B12
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028AED RID: 166637 RVA: 0x00596924 File Offset: 0x00594B24
		public IWuWaGoHintStepInteractT AsIWuWaGoHintStepInteract()
		{
			return this.As<IWuWaGoHintStepInteractT>();
		}

		// Token: 0x06028AEE RID: 166638 RVA: 0x0059692C File Offset: 0x00594B2C
		public static TWuWaGoHintStepUnion FromIWuWaGoHintStepInteract(IWuWaGoHintStepInteractT _iwuwagohintstepinteract)
		{
			return new TWuWaGoHintStepUnion
			{
				Type = TWuWaGoHintStep.IWuWaGoHintStepInteract,
				Value = _iwuwagohintstepinteract
			};
		}

		// Token: 0x06028AEF RID: 166639 RVA: 0x00596941 File Offset: 0x00594B41
		public IWuWaGoHintStepMoveT AsIWuWaGoHintStepMove()
		{
			return this.As<IWuWaGoHintStepMoveT>();
		}

		// Token: 0x06028AF0 RID: 166640 RVA: 0x00596949 File Offset: 0x00594B49
		public static TWuWaGoHintStepUnion FromIWuWaGoHintStepMove(IWuWaGoHintStepMoveT _iwuwagohintstepmove)
		{
			return new TWuWaGoHintStepUnion
			{
				Type = TWuWaGoHintStep.IWuWaGoHintStepMove,
				Value = _iwuwagohintstepmove
			};
		}

		// Token: 0x06028AF1 RID: 166641 RVA: 0x00596960 File Offset: 0x00594B60
		public static int Pack(FlatBufferBuilder builder, TWuWaGoHintStepUnion _o)
		{
			TWuWaGoHintStep type = _o.Type;
			if (type == TWuWaGoHintStep.IWuWaGoHintStepInteract)
			{
				return IWuWaGoHintStepInteract.Pack(builder, _o.AsIWuWaGoHintStepInteract()).Value;
			}
			if (type != TWuWaGoHintStep.IWuWaGoHintStepMove)
			{
				return 0;
			}
			return IWuWaGoHintStepMove.Pack(builder, _o.AsIWuWaGoHintStepMove()).Value;
		}
	}
}
