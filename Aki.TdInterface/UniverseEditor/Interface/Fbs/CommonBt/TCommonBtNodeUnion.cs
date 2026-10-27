using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EDC RID: 24284
	public class TCommonBtNodeUnion
	{
		// Token: 0x1700B5A2 RID: 46498
		// (get) Token: 0x06029B60 RID: 170848 RVA: 0x005B9920 File Offset: 0x005B7B20
		// (set) Token: 0x06029B61 RID: 170849 RVA: 0x005B9928 File Offset: 0x005B7B28
		public TCommonBtNode Type { get; set; }

		// Token: 0x1700B5A3 RID: 46499
		// (get) Token: 0x06029B62 RID: 170850 RVA: 0x005B9931 File Offset: 0x005B7B31
		// (set) Token: 0x06029B63 RID: 170851 RVA: 0x005B9939 File Offset: 0x005B7B39
		public object Value { get; set; }

		// Token: 0x06029B64 RID: 170852 RVA: 0x005B9942 File Offset: 0x005B7B42
		public TCommonBtNodeUnion()
		{
			this.Type = TCommonBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x06029B65 RID: 170853 RVA: 0x005B9958 File Offset: 0x005B7B58
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029B66 RID: 170854 RVA: 0x005B996A File Offset: 0x005B7B6A
		public ICommonBtProbabilityT AsICommonBtProbability()
		{
			return this.As<ICommonBtProbabilityT>();
		}

		// Token: 0x06029B67 RID: 170855 RVA: 0x005B9972 File Offset: 0x005B7B72
		public static TCommonBtNodeUnion FromICommonBtProbability(ICommonBtProbabilityT _icommonbtprobability)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtProbability,
				Value = _icommonbtprobability
			};
		}

		// Token: 0x06029B68 RID: 170856 RVA: 0x005B9987 File Offset: 0x005B7B87
		public ICommonBtSelectorT AsICommonBtSelector()
		{
			return this.As<ICommonBtSelectorT>();
		}

		// Token: 0x06029B69 RID: 170857 RVA: 0x005B998F File Offset: 0x005B7B8F
		public static TCommonBtNodeUnion FromICommonBtSelector(ICommonBtSelectorT _icommonbtselector)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtSelector,
				Value = _icommonbtselector
			};
		}

		// Token: 0x06029B6A RID: 170858 RVA: 0x005B99A4 File Offset: 0x005B7BA4
		public ICommonBtSequenceT AsICommonBtSequence()
		{
			return this.As<ICommonBtSequenceT>();
		}

		// Token: 0x06029B6B RID: 170859 RVA: 0x005B99AC File Offset: 0x005B7BAC
		public static TCommonBtNodeUnion FromICommonBtSequence(ICommonBtSequenceT _icommonbtsequence)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtSequence,
				Value = _icommonbtsequence
			};
		}

		// Token: 0x06029B6C RID: 170860 RVA: 0x005B99C1 File Offset: 0x005B7BC1
		public ICommonBtStartT AsICommonBtStart()
		{
			return this.As<ICommonBtStartT>();
		}

		// Token: 0x06029B6D RID: 170861 RVA: 0x005B99C9 File Offset: 0x005B7BC9
		public static TCommonBtNodeUnion FromICommonBtStart(ICommonBtStartT _icommonbtstart)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtStart,
				Value = _icommonbtstart
			};
		}

		// Token: 0x06029B6E RID: 170862 RVA: 0x005B99DE File Offset: 0x005B7BDE
		public ICommonBtTaskT AsICommonBtTask()
		{
			return this.As<ICommonBtTaskT>();
		}

		// Token: 0x06029B6F RID: 170863 RVA: 0x005B99E6 File Offset: 0x005B7BE6
		public static TCommonBtNodeUnion FromICommonBtTask(ICommonBtTaskT _icommonbttask)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtTask,
				Value = _icommonbttask
			};
		}

		// Token: 0x06029B70 RID: 170864 RVA: 0x005B99FC File Offset: 0x005B7BFC
		public static int Pack(FlatBufferBuilder builder, TCommonBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TCommonBtNode.ICommonBtProbability:
				return ICommonBtProbability.Pack(builder, _o.AsICommonBtProbability()).Value;
			case TCommonBtNode.ICommonBtSelector:
				return ICommonBtSelector.Pack(builder, _o.AsICommonBtSelector()).Value;
			case TCommonBtNode.ICommonBtSequence:
				return ICommonBtSequence.Pack(builder, _o.AsICommonBtSequence()).Value;
			case TCommonBtNode.ICommonBtStart:
				return ICommonBtStart.Pack(builder, _o.AsICommonBtStart()).Value;
			case TCommonBtNode.ICommonBtTask:
				return ICommonBtTask.Pack(builder, _o.AsICommonBtTask()).Value;
			default:
				return 0;
			}
		}
	}
}
