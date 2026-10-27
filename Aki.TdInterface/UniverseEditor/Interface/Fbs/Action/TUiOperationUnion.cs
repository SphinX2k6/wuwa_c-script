using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F3 RID: 30707
	public class TUiOperationUnion
	{
		// Token: 0x1700E6E5 RID: 59109
		// (get) Token: 0x06037B24 RID: 228132 RVA: 0x00787DC6 File Offset: 0x00785FC6
		// (set) Token: 0x06037B25 RID: 228133 RVA: 0x00787DCE File Offset: 0x00785FCE
		public TUiOperation Type { get; set; }

		// Token: 0x1700E6E6 RID: 59110
		// (get) Token: 0x06037B26 RID: 228134 RVA: 0x00787DD7 File Offset: 0x00785FD7
		// (set) Token: 0x06037B27 RID: 228135 RVA: 0x00787DDF File Offset: 0x00785FDF
		public object Value { get; set; }

		// Token: 0x06037B28 RID: 228136 RVA: 0x00787DE8 File Offset: 0x00785FE8
		public TUiOperationUnion()
		{
			this.Type = TUiOperation.NONE;
			this.Value = null;
		}

		// Token: 0x06037B29 RID: 228137 RVA: 0x00787DFE File Offset: 0x00785FFE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B2A RID: 228138 RVA: 0x00787E10 File Offset: 0x00786010
		public IDisableUiOperationT AsIDisableUiOperation()
		{
			return this.As<IDisableUiOperationT>();
		}

		// Token: 0x06037B2B RID: 228139 RVA: 0x00787E18 File Offset: 0x00786018
		public static TUiOperationUnion FromIDisableUiOperation(IDisableUiOperationT _idisableuioperation)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IDisableUiOperation,
				Value = _idisableuioperation
			};
		}

		// Token: 0x06037B2C RID: 228140 RVA: 0x00787E2D File Offset: 0x0078602D
		public IEnableSectionalUiT AsIEnableSectionalUi()
		{
			return this.As<IEnableSectionalUiT>();
		}

		// Token: 0x06037B2D RID: 228141 RVA: 0x00787E35 File Offset: 0x00786035
		public static TUiOperationUnion FromIEnableSectionalUi(IEnableSectionalUiT _ienablesectionalui)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IEnableSectionalUi,
				Value = _ienablesectionalui
			};
		}

		// Token: 0x06037B2E RID: 228142 RVA: 0x00787E4A File Offset: 0x0078604A
		public IEnableUiOperationT AsIEnableUiOperation()
		{
			return this.As<IEnableUiOperationT>();
		}

		// Token: 0x06037B2F RID: 228143 RVA: 0x00787E52 File Offset: 0x00786052
		public static TUiOperationUnion FromIEnableUiOperation(IEnableUiOperationT _ienableuioperation)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IEnableUiOperation,
				Value = _ienableuioperation
			};
		}

		// Token: 0x06037B30 RID: 228144 RVA: 0x00787E68 File Offset: 0x00786068
		public static int Pack(FlatBufferBuilder builder, TUiOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TUiOperation.IDisableUiOperation:
				return IDisableUiOperation.Pack(builder, _o.AsIDisableUiOperation()).Value;
			case TUiOperation.IEnableSectionalUi:
				return IEnableSectionalUi.Pack(builder, _o.AsIEnableSectionalUi()).Value;
			case TUiOperation.IEnableUiOperation:
				return IEnableUiOperation.Pack(builder, _o.AsIEnableUiOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
