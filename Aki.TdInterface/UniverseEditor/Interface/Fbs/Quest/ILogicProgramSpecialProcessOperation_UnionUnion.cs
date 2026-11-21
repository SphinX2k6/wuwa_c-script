using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004359 RID: 17241
	public class ILogicProgramSpecialProcessOperation_UnionUnion
	{
		// Token: 0x17007647 RID: 30279
		// (get) Token: 0x06018544 RID: 99652 RVA: 0x003785E9 File Offset: 0x003767E9
		// (set) Token: 0x06018545 RID: 99653 RVA: 0x003785F1 File Offset: 0x003767F1
		public ILogicProgramSpecialProcessOperation_Union Type { get; set; }

		// Token: 0x17007648 RID: 30280
		// (get) Token: 0x06018546 RID: 99654 RVA: 0x003785FA File Offset: 0x003767FA
		// (set) Token: 0x06018547 RID: 99655 RVA: 0x00378602 File Offset: 0x00376802
		public object Value { get; set; }

		// Token: 0x06018548 RID: 99656 RVA: 0x0037860B File Offset: 0x0037680B
		public ILogicProgramSpecialProcessOperation_UnionUnion()
		{
			this.Type = ILogicProgramSpecialProcessOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018549 RID: 99657 RVA: 0x00378621 File Offset: 0x00376821
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601854A RID: 99658 RVA: 0x00378633 File Offset: 0x00376833
		public ILogicProgramSpecialProcessOperationT AsILogicProgramSpecialProcessOperation()
		{
			return this.As<ILogicProgramSpecialProcessOperationT>();
		}

		// Token: 0x0601854B RID: 99659 RVA: 0x0037863B File Offset: 0x0037683B
		public static ILogicProgramSpecialProcessOperation_UnionUnion FromILogicProgramSpecialProcessOperation(ILogicProgramSpecialProcessOperationT _ilogicprogramspecialprocessoperation)
		{
			return new ILogicProgramSpecialProcessOperation_UnionUnion
			{
				Type = ILogicProgramSpecialProcessOperation_Union.ILogicProgramSpecialProcessOperation,
				Value = _ilogicprogramspecialprocessoperation
			};
		}

		// Token: 0x0601854C RID: 99660 RVA: 0x00378650 File Offset: 0x00376850
		public IDisableUroT AsIDisableUro()
		{
			return this.As<IDisableUroT>();
		}

		// Token: 0x0601854D RID: 99661 RVA: 0x00378658 File Offset: 0x00376858
		public static ILogicProgramSpecialProcessOperation_UnionUnion FromIDisableUro(IDisableUroT _idisableuro)
		{
			return new ILogicProgramSpecialProcessOperation_UnionUnion
			{
				Type = ILogicProgramSpecialProcessOperation_Union.IDisableUro,
				Value = _idisableuro
			};
		}

		// Token: 0x0601854E RID: 99662 RVA: 0x00378670 File Offset: 0x00376870
		public static int Pack(FlatBufferBuilder builder, ILogicProgramSpecialProcessOperation_UnionUnion _o)
		{
			ILogicProgramSpecialProcessOperation_Union type = _o.Type;
			if (type == ILogicProgramSpecialProcessOperation_Union.ILogicProgramSpecialProcessOperation)
			{
				return ILogicProgramSpecialProcessOperation.Pack(builder, _o.AsILogicProgramSpecialProcessOperation()).Value;
			}
			if (type != ILogicProgramSpecialProcessOperation_Union.IDisableUro)
			{
				return 0;
			}
			return IDisableUro.Pack(builder, _o.AsIDisableUro()).Value;
		}
	}
}
