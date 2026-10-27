using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F1B RID: 16155
	public class ILogicProgramSpecialProcessOperation_UnionUnion
	{
		// Token: 0x17007058 RID: 28760
		// (get) Token: 0x06016EEC RID: 93932 RVA: 0x0034F3C1 File Offset: 0x0034D5C1
		// (set) Token: 0x06016EED RID: 93933 RVA: 0x0034F3C9 File Offset: 0x0034D5C9
		public ILogicProgramSpecialProcessOperation_Union Type { get; set; }

		// Token: 0x17007059 RID: 28761
		// (get) Token: 0x06016EEE RID: 93934 RVA: 0x0034F3D2 File Offset: 0x0034D5D2
		// (set) Token: 0x06016EEF RID: 93935 RVA: 0x0034F3DA File Offset: 0x0034D5DA
		public object Value { get; set; }

		// Token: 0x06016EF0 RID: 93936 RVA: 0x0034F3E3 File Offset: 0x0034D5E3
		public ILogicProgramSpecialProcessOperation_UnionUnion()
		{
			this.Type = ILogicProgramSpecialProcessOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x0034F3F9 File Offset: 0x0034D5F9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016EF2 RID: 93938 RVA: 0x0034F40B File Offset: 0x0034D60B
		public ILogicProgramSpecialProcessOperationT AsILogicProgramSpecialProcessOperation()
		{
			return this.As<ILogicProgramSpecialProcessOperationT>();
		}

		// Token: 0x06016EF3 RID: 93939 RVA: 0x0034F413 File Offset: 0x0034D613
		public static ILogicProgramSpecialProcessOperation_UnionUnion FromILogicProgramSpecialProcessOperation(ILogicProgramSpecialProcessOperationT _ilogicprogramspecialprocessoperation)
		{
			return new ILogicProgramSpecialProcessOperation_UnionUnion
			{
				Type = ILogicProgramSpecialProcessOperation_Union.ILogicProgramSpecialProcessOperation,
				Value = _ilogicprogramspecialprocessoperation
			};
		}

		// Token: 0x06016EF4 RID: 93940 RVA: 0x0034F428 File Offset: 0x0034D628
		public IDisableUroT AsIDisableUro()
		{
			return this.As<IDisableUroT>();
		}

		// Token: 0x06016EF5 RID: 93941 RVA: 0x0034F430 File Offset: 0x0034D630
		public static ILogicProgramSpecialProcessOperation_UnionUnion FromIDisableUro(IDisableUroT _idisableuro)
		{
			return new ILogicProgramSpecialProcessOperation_UnionUnion
			{
				Type = ILogicProgramSpecialProcessOperation_Union.IDisableUro,
				Value = _idisableuro
			};
		}

		// Token: 0x06016EF6 RID: 93942 RVA: 0x0034F448 File Offset: 0x0034D648
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
