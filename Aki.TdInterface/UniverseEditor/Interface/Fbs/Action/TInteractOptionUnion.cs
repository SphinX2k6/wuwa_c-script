using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F10 RID: 32528
	public class TInteractOptionUnion
	{
		// Token: 0x1700F283 RID: 62083
		// (get) Token: 0x0603AAA1 RID: 240289 RVA: 0x007E3ED6 File Offset: 0x007E20D6
		// (set) Token: 0x0603AAA2 RID: 240290 RVA: 0x007E3EDE File Offset: 0x007E20DE
		public TInteractOption Type { get; set; }

		// Token: 0x1700F284 RID: 62084
		// (get) Token: 0x0603AAA3 RID: 240291 RVA: 0x007E3EE7 File Offset: 0x007E20E7
		// (set) Token: 0x0603AAA4 RID: 240292 RVA: 0x007E3EEF File Offset: 0x007E20EF
		public object Value { get; set; }

		// Token: 0x0603AAA5 RID: 240293 RVA: 0x007E3EF8 File Offset: 0x007E20F8
		public TInteractOptionUnion()
		{
			this.Type = TInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AAA6 RID: 240294 RVA: 0x007E3F0E File Offset: 0x007E210E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AAA7 RID: 240295 RVA: 0x007E3F20 File Offset: 0x007E2120
		public IInteractActionsT AsIInteractActions()
		{
			return this.As<IInteractActionsT>();
		}

		// Token: 0x0603AAA8 RID: 240296 RVA: 0x007E3F28 File Offset: 0x007E2128
		public static TInteractOptionUnion FromIInteractActions(IInteractActionsT _iinteractactions)
		{
			return new TInteractOptionUnion
			{
				Type = TInteractOption.IInteractActions,
				Value = _iinteractactions
			};
		}

		// Token: 0x0603AAA9 RID: 240297 RVA: 0x007E3F3D File Offset: 0x007E213D
		public IInteractFlowT AsIInteractFlow()
		{
			return this.As<IInteractFlowT>();
		}

		// Token: 0x0603AAAA RID: 240298 RVA: 0x007E3F45 File Offset: 0x007E2145
		public static TInteractOptionUnion FromIInteractFlow(IInteractFlowT _iinteractflow)
		{
			return new TInteractOptionUnion
			{
				Type = TInteractOption.IInteractFlow,
				Value = _iinteractflow
			};
		}

		// Token: 0x0603AAAB RID: 240299 RVA: 0x007E3F5C File Offset: 0x007E215C
		public static int Pack(FlatBufferBuilder builder, TInteractOptionUnion _o)
		{
			TInteractOption type = _o.Type;
			if (type == TInteractOption.IInteractActions)
			{
				return IInteractActions.Pack(builder, _o.AsIInteractActions()).Value;
			}
			if (type != TInteractOption.IInteractFlow)
			{
				return 0;
			}
			return IInteractFlow.Pack(builder, _o.AsIInteractFlow()).Value;
		}
	}
}
