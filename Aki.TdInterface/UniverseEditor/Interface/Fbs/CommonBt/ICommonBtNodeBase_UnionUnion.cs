using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006504 RID: 25860
	public class ICommonBtNodeBase_UnionUnion
	{
		// Token: 0x1700BEAA RID: 48810
		// (get) Token: 0x0602C04B RID: 180299 RVA: 0x005FE23E File Offset: 0x005FC43E
		// (set) Token: 0x0602C04C RID: 180300 RVA: 0x005FE246 File Offset: 0x005FC446
		public ICommonBtNodeBase_Union Type { get; set; }

		// Token: 0x1700BEAB RID: 48811
		// (get) Token: 0x0602C04D RID: 180301 RVA: 0x005FE24F File Offset: 0x005FC44F
		// (set) Token: 0x0602C04E RID: 180302 RVA: 0x005FE257 File Offset: 0x005FC457
		public object Value { get; set; }

		// Token: 0x0602C04F RID: 180303 RVA: 0x005FE260 File Offset: 0x005FC460
		public ICommonBtNodeBase_UnionUnion()
		{
			this.Type = ICommonBtNodeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C050 RID: 180304 RVA: 0x005FE276 File Offset: 0x005FC476
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C051 RID: 180305 RVA: 0x005FE288 File Offset: 0x005FC488
		public ICommonBtNodeBaseT AsICommonBtNodeBase()
		{
			return this.As<ICommonBtNodeBaseT>();
		}

		// Token: 0x0602C052 RID: 180306 RVA: 0x005FE290 File Offset: 0x005FC490
		public static ICommonBtNodeBase_UnionUnion FromICommonBtNodeBase(ICommonBtNodeBaseT _icommonbtnodebase)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtNodeBase,
				Value = _icommonbtnodebase
			};
		}

		// Token: 0x0602C053 RID: 180307 RVA: 0x005FE2A5 File Offset: 0x005FC4A5
		public ICommonBtStartT AsICommonBtStart()
		{
			return this.As<ICommonBtStartT>();
		}

		// Token: 0x0602C054 RID: 180308 RVA: 0x005FE2AD File Offset: 0x005FC4AD
		public static ICommonBtNodeBase_UnionUnion FromICommonBtStart(ICommonBtStartT _icommonbtstart)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtStart,
				Value = _icommonbtstart
			};
		}

		// Token: 0x0602C055 RID: 180309 RVA: 0x005FE2C2 File Offset: 0x005FC4C2
		public ICommonBtSequenceT AsICommonBtSequence()
		{
			return this.As<ICommonBtSequenceT>();
		}

		// Token: 0x0602C056 RID: 180310 RVA: 0x005FE2CA File Offset: 0x005FC4CA
		public static ICommonBtNodeBase_UnionUnion FromICommonBtSequence(ICommonBtSequenceT _icommonbtsequence)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtSequence,
				Value = _icommonbtsequence
			};
		}

		// Token: 0x0602C057 RID: 180311 RVA: 0x005FE2DF File Offset: 0x005FC4DF
		public ICommonBtSelectorT AsICommonBtSelector()
		{
			return this.As<ICommonBtSelectorT>();
		}

		// Token: 0x0602C058 RID: 180312 RVA: 0x005FE2E7 File Offset: 0x005FC4E7
		public static ICommonBtNodeBase_UnionUnion FromICommonBtSelector(ICommonBtSelectorT _icommonbtselector)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtSelector,
				Value = _icommonbtselector
			};
		}

		// Token: 0x0602C059 RID: 180313 RVA: 0x005FE2FC File Offset: 0x005FC4FC
		public ICommonBtTaskT AsICommonBtTask()
		{
			return this.As<ICommonBtTaskT>();
		}

		// Token: 0x0602C05A RID: 180314 RVA: 0x005FE304 File Offset: 0x005FC504
		public static ICommonBtNodeBase_UnionUnion FromICommonBtTask(ICommonBtTaskT _icommonbttask)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtTask,
				Value = _icommonbttask
			};
		}

		// Token: 0x0602C05B RID: 180315 RVA: 0x005FE319 File Offset: 0x005FC519
		public ICommonBtProbabilityT AsICommonBtProbability()
		{
			return this.As<ICommonBtProbabilityT>();
		}

		// Token: 0x0602C05C RID: 180316 RVA: 0x005FE321 File Offset: 0x005FC521
		public static ICommonBtNodeBase_UnionUnion FromICommonBtProbability(ICommonBtProbabilityT _icommonbtprobability)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtProbability,
				Value = _icommonbtprobability
			};
		}

		// Token: 0x0602C05D RID: 180317 RVA: 0x005FE338 File Offset: 0x005FC538
		public static int Pack(FlatBufferBuilder builder, ICommonBtNodeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonBtNodeBase_Union.ICommonBtNodeBase:
				return ICommonBtNodeBase.Pack(builder, _o.AsICommonBtNodeBase()).Value;
			case ICommonBtNodeBase_Union.ICommonBtStart:
				return ICommonBtStart.Pack(builder, _o.AsICommonBtStart()).Value;
			case ICommonBtNodeBase_Union.ICommonBtSequence:
				return ICommonBtSequence.Pack(builder, _o.AsICommonBtSequence()).Value;
			case ICommonBtNodeBase_Union.ICommonBtSelector:
				return ICommonBtSelector.Pack(builder, _o.AsICommonBtSelector()).Value;
			case ICommonBtNodeBase_Union.ICommonBtTask:
				return ICommonBtTask.Pack(builder, _o.AsICommonBtTask()).Value;
			case ICommonBtNodeBase_Union.ICommonBtProbability:
				return ICommonBtProbability.Pack(builder, _o.AsICommonBtProbability()).Value;
			default:
				return 0;
			}
		}
	}
}
