using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006313 RID: 25363
	public class TWuWaGoHintStepUnion
	{
		// Token: 0x1700BBCE RID: 48078
		// (get) Token: 0x0602B13B RID: 176443 RVA: 0x005DF14A File Offset: 0x005DD34A
		// (set) Token: 0x0602B13C RID: 176444 RVA: 0x005DF152 File Offset: 0x005DD352
		public TWuWaGoHintStep Type { get; set; }

		// Token: 0x1700BBCF RID: 48079
		// (get) Token: 0x0602B13D RID: 176445 RVA: 0x005DF15B File Offset: 0x005DD35B
		// (set) Token: 0x0602B13E RID: 176446 RVA: 0x005DF163 File Offset: 0x005DD363
		public object Value { get; set; }

		// Token: 0x0602B13F RID: 176447 RVA: 0x005DF16C File Offset: 0x005DD36C
		public TWuWaGoHintStepUnion()
		{
			this.Type = TWuWaGoHintStep.NONE;
			this.Value = null;
		}

		// Token: 0x0602B140 RID: 176448 RVA: 0x005DF182 File Offset: 0x005DD382
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B141 RID: 176449 RVA: 0x005DF194 File Offset: 0x005DD394
		public IWuWaGoHintStepInteractT AsIWuWaGoHintStepInteract()
		{
			return this.As<IWuWaGoHintStepInteractT>();
		}

		// Token: 0x0602B142 RID: 176450 RVA: 0x005DF19C File Offset: 0x005DD39C
		public static TWuWaGoHintStepUnion FromIWuWaGoHintStepInteract(IWuWaGoHintStepInteractT _iwuwagohintstepinteract)
		{
			return new TWuWaGoHintStepUnion
			{
				Type = TWuWaGoHintStep.IWuWaGoHintStepInteract,
				Value = _iwuwagohintstepinteract
			};
		}

		// Token: 0x0602B143 RID: 176451 RVA: 0x005DF1B1 File Offset: 0x005DD3B1
		public IWuWaGoHintStepMoveT AsIWuWaGoHintStepMove()
		{
			return this.As<IWuWaGoHintStepMoveT>();
		}

		// Token: 0x0602B144 RID: 176452 RVA: 0x005DF1B9 File Offset: 0x005DD3B9
		public static TWuWaGoHintStepUnion FromIWuWaGoHintStepMove(IWuWaGoHintStepMoveT _iwuwagohintstepmove)
		{
			return new TWuWaGoHintStepUnion
			{
				Type = TWuWaGoHintStep.IWuWaGoHintStepMove,
				Value = _iwuwagohintstepmove
			};
		}

		// Token: 0x0602B145 RID: 176453 RVA: 0x005DF1D0 File Offset: 0x005DD3D0
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
