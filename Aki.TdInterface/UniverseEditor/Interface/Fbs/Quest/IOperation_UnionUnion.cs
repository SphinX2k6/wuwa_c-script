using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A4 RID: 17316
	public class IOperation_UnionUnion
	{
		// Token: 0x170076CA RID: 30410
		// (get) Token: 0x060187BC RID: 100284 RVA: 0x0037D035 File Offset: 0x0037B235
		// (set) Token: 0x060187BD RID: 100285 RVA: 0x0037D03D File Offset: 0x0037B23D
		public IOperation_Union Type { get; set; }

		// Token: 0x170076CB RID: 30411
		// (get) Token: 0x060187BE RID: 100286 RVA: 0x0037D046 File Offset: 0x0037B246
		// (set) Token: 0x060187BF RID: 100287 RVA: 0x0037D04E File Offset: 0x0037B24E
		public object Value { get; set; }

		// Token: 0x060187C0 RID: 100288 RVA: 0x0037D057 File Offset: 0x0037B257
		public IOperation_UnionUnion()
		{
			this.Type = IOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060187C1 RID: 100289 RVA: 0x0037D06D File Offset: 0x0037B26D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060187C2 RID: 100290 RVA: 0x0037D07F File Offset: 0x0037B27F
		public IOperationT AsIOperation()
		{
			return this.As<IOperationT>();
		}

		// Token: 0x060187C3 RID: 100291 RVA: 0x0037D087 File Offset: 0x0037B287
		public static IOperation_UnionUnion FromIOperation(IOperationT _ioperation)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IOperation,
				Value = _ioperation
			};
		}

		// Token: 0x060187C4 RID: 100292 RVA: 0x0037D09C File Offset: 0x0037B29C
		public IDisableHLODT AsIDisableHLOD()
		{
			return this.As<IDisableHLODT>();
		}

		// Token: 0x060187C5 RID: 100293 RVA: 0x0037D0A4 File Offset: 0x0037B2A4
		public static IOperation_UnionUnion FromIDisableHLOD(IDisableHLODT _idisablehlod)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IDisableHLOD,
				Value = _idisablehlod
			};
		}

		// Token: 0x060187C6 RID: 100294 RVA: 0x0037D0B9 File Offset: 0x0037B2B9
		public IAssignLoadingBackgroundT AsIAssignLoadingBackground()
		{
			return this.As<IAssignLoadingBackgroundT>();
		}

		// Token: 0x060187C7 RID: 100295 RVA: 0x0037D0C1 File Offset: 0x0037B2C1
		public static IOperation_UnionUnion FromIAssignLoadingBackground(IAssignLoadingBackgroundT _iassignloadingbackground)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IAssignLoadingBackground,
				Value = _iassignloadingbackground
			};
		}

		// Token: 0x060187C8 RID: 100296 RVA: 0x0037D0D8 File Offset: 0x0037B2D8
		public static int Pack(FlatBufferBuilder builder, IOperation_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOperation_Union.IOperation:
				return IOperation.Pack(builder, _o.AsIOperation()).Value;
			case IOperation_Union.IDisableHLOD:
				return IDisableHLOD.Pack(builder, _o.AsIDisableHLOD()).Value;
			case IOperation_Union.IAssignLoadingBackground:
				return IAssignLoadingBackground.Pack(builder, _o.AsIAssignLoadingBackground()).Value;
			default:
				return 0;
			}
		}
	}
}
