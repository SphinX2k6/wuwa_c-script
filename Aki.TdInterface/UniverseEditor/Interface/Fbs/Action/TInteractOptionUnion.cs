using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FC RID: 30460
	public class TInteractOptionUnion
	{
		// Token: 0x1700E641 RID: 58945
		// (get) Token: 0x060375D4 RID: 226772 RVA: 0x0077F9CA File Offset: 0x0077DBCA
		// (set) Token: 0x060375D5 RID: 226773 RVA: 0x0077F9D2 File Offset: 0x0077DBD2
		public TInteractOption Type { get; set; }

		// Token: 0x1700E642 RID: 58946
		// (get) Token: 0x060375D6 RID: 226774 RVA: 0x0077F9DB File Offset: 0x0077DBDB
		// (set) Token: 0x060375D7 RID: 226775 RVA: 0x0077F9E3 File Offset: 0x0077DBE3
		public object Value { get; set; }

		// Token: 0x060375D8 RID: 226776 RVA: 0x0077F9EC File Offset: 0x0077DBEC
		public TInteractOptionUnion()
		{
			this.Type = TInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x060375D9 RID: 226777 RVA: 0x0077FA02 File Offset: 0x0077DC02
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375DA RID: 226778 RVA: 0x0077FA14 File Offset: 0x0077DC14
		public IInteractActionsT AsIInteractActions()
		{
			return this.As<IInteractActionsT>();
		}

		// Token: 0x060375DB RID: 226779 RVA: 0x0077FA1C File Offset: 0x0077DC1C
		public static TInteractOptionUnion FromIInteractActions(IInteractActionsT _iinteractactions)
		{
			return new TInteractOptionUnion
			{
				Type = TInteractOption.IInteractActions,
				Value = _iinteractactions
			};
		}

		// Token: 0x060375DC RID: 226780 RVA: 0x0077FA31 File Offset: 0x0077DC31
		public IInteractFlowT AsIInteractFlow()
		{
			return this.As<IInteractFlowT>();
		}

		// Token: 0x060375DD RID: 226781 RVA: 0x0077FA39 File Offset: 0x0077DC39
		public static TInteractOptionUnion FromIInteractFlow(IInteractFlowT _iinteractflow)
		{
			return new TInteractOptionUnion
			{
				Type = TInteractOption.IInteractFlow,
				Value = _iinteractflow
			};
		}

		// Token: 0x060375DE RID: 226782 RVA: 0x0077FA50 File Offset: 0x0077DC50
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
