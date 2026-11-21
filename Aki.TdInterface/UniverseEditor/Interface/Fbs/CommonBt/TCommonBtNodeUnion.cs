using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200651F RID: 25887
	public class TCommonBtNodeUnion
	{
		// Token: 0x1700BF0D RID: 48909
		// (get) Token: 0x0602C214 RID: 180756 RVA: 0x00602E04 File Offset: 0x00601004
		// (set) Token: 0x0602C215 RID: 180757 RVA: 0x00602E0C File Offset: 0x0060100C
		public TCommonBtNode Type { get; set; }

		// Token: 0x1700BF0E RID: 48910
		// (get) Token: 0x0602C216 RID: 180758 RVA: 0x00602E15 File Offset: 0x00601015
		// (set) Token: 0x0602C217 RID: 180759 RVA: 0x00602E1D File Offset: 0x0060101D
		public object Value { get; set; }

		// Token: 0x0602C218 RID: 180760 RVA: 0x00602E26 File Offset: 0x00601026
		public TCommonBtNodeUnion()
		{
			this.Type = TCommonBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0602C219 RID: 180761 RVA: 0x00602E3C File Offset: 0x0060103C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C21A RID: 180762 RVA: 0x00602E4E File Offset: 0x0060104E
		public ICommonBtProbabilityT AsICommonBtProbability()
		{
			return this.As<ICommonBtProbabilityT>();
		}

		// Token: 0x0602C21B RID: 180763 RVA: 0x00602E56 File Offset: 0x00601056
		public static TCommonBtNodeUnion FromICommonBtProbability(ICommonBtProbabilityT _icommonbtprobability)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtProbability,
				Value = _icommonbtprobability
			};
		}

		// Token: 0x0602C21C RID: 180764 RVA: 0x00602E6B File Offset: 0x0060106B
		public ICommonBtSelectorT AsICommonBtSelector()
		{
			return this.As<ICommonBtSelectorT>();
		}

		// Token: 0x0602C21D RID: 180765 RVA: 0x00602E73 File Offset: 0x00601073
		public static TCommonBtNodeUnion FromICommonBtSelector(ICommonBtSelectorT _icommonbtselector)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtSelector,
				Value = _icommonbtselector
			};
		}

		// Token: 0x0602C21E RID: 180766 RVA: 0x00602E88 File Offset: 0x00601088
		public ICommonBtSequenceT AsICommonBtSequence()
		{
			return this.As<ICommonBtSequenceT>();
		}

		// Token: 0x0602C21F RID: 180767 RVA: 0x00602E90 File Offset: 0x00601090
		public static TCommonBtNodeUnion FromICommonBtSequence(ICommonBtSequenceT _icommonbtsequence)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtSequence,
				Value = _icommonbtsequence
			};
		}

		// Token: 0x0602C220 RID: 180768 RVA: 0x00602EA5 File Offset: 0x006010A5
		public ICommonBtStartT AsICommonBtStart()
		{
			return this.As<ICommonBtStartT>();
		}

		// Token: 0x0602C221 RID: 180769 RVA: 0x00602EAD File Offset: 0x006010AD
		public static TCommonBtNodeUnion FromICommonBtStart(ICommonBtStartT _icommonbtstart)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtStart,
				Value = _icommonbtstart
			};
		}

		// Token: 0x0602C222 RID: 180770 RVA: 0x00602EC2 File Offset: 0x006010C2
		public ICommonBtTaskT AsICommonBtTask()
		{
			return this.As<ICommonBtTaskT>();
		}

		// Token: 0x0602C223 RID: 180771 RVA: 0x00602ECA File Offset: 0x006010CA
		public static TCommonBtNodeUnion FromICommonBtTask(ICommonBtTaskT _icommonbttask)
		{
			return new TCommonBtNodeUnion
			{
				Type = TCommonBtNode.ICommonBtTask,
				Value = _icommonbttask
			};
		}

		// Token: 0x0602C224 RID: 180772 RVA: 0x00602EE0 File Offset: 0x006010E0
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
