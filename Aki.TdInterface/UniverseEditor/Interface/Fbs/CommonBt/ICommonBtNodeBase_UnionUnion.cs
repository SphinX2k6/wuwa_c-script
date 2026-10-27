using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC1 RID: 24257
	public class ICommonBtNodeBase_UnionUnion
	{
		// Token: 0x1700B53F RID: 46399
		// (get) Token: 0x06029997 RID: 170391 RVA: 0x005B4D5A File Offset: 0x005B2F5A
		// (set) Token: 0x06029998 RID: 170392 RVA: 0x005B4D62 File Offset: 0x005B2F62
		public ICommonBtNodeBase_Union Type { get; set; }

		// Token: 0x1700B540 RID: 46400
		// (get) Token: 0x06029999 RID: 170393 RVA: 0x005B4D6B File Offset: 0x005B2F6B
		// (set) Token: 0x0602999A RID: 170394 RVA: 0x005B4D73 File Offset: 0x005B2F73
		public object Value { get; set; }

		// Token: 0x0602999B RID: 170395 RVA: 0x005B4D7C File Offset: 0x005B2F7C
		public ICommonBtNodeBase_UnionUnion()
		{
			this.Type = ICommonBtNodeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602999C RID: 170396 RVA: 0x005B4D92 File Offset: 0x005B2F92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602999D RID: 170397 RVA: 0x005B4DA4 File Offset: 0x005B2FA4
		public ICommonBtNodeBaseT AsICommonBtNodeBase()
		{
			return this.As<ICommonBtNodeBaseT>();
		}

		// Token: 0x0602999E RID: 170398 RVA: 0x005B4DAC File Offset: 0x005B2FAC
		public static ICommonBtNodeBase_UnionUnion FromICommonBtNodeBase(ICommonBtNodeBaseT _icommonbtnodebase)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtNodeBase,
				Value = _icommonbtnodebase
			};
		}

		// Token: 0x0602999F RID: 170399 RVA: 0x005B4DC1 File Offset: 0x005B2FC1
		public ICommonBtStartT AsICommonBtStart()
		{
			return this.As<ICommonBtStartT>();
		}

		// Token: 0x060299A0 RID: 170400 RVA: 0x005B4DC9 File Offset: 0x005B2FC9
		public static ICommonBtNodeBase_UnionUnion FromICommonBtStart(ICommonBtStartT _icommonbtstart)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtStart,
				Value = _icommonbtstart
			};
		}

		// Token: 0x060299A1 RID: 170401 RVA: 0x005B4DDE File Offset: 0x005B2FDE
		public ICommonBtSequenceT AsICommonBtSequence()
		{
			return this.As<ICommonBtSequenceT>();
		}

		// Token: 0x060299A2 RID: 170402 RVA: 0x005B4DE6 File Offset: 0x005B2FE6
		public static ICommonBtNodeBase_UnionUnion FromICommonBtSequence(ICommonBtSequenceT _icommonbtsequence)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtSequence,
				Value = _icommonbtsequence
			};
		}

		// Token: 0x060299A3 RID: 170403 RVA: 0x005B4DFB File Offset: 0x005B2FFB
		public ICommonBtSelectorT AsICommonBtSelector()
		{
			return this.As<ICommonBtSelectorT>();
		}

		// Token: 0x060299A4 RID: 170404 RVA: 0x005B4E03 File Offset: 0x005B3003
		public static ICommonBtNodeBase_UnionUnion FromICommonBtSelector(ICommonBtSelectorT _icommonbtselector)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtSelector,
				Value = _icommonbtselector
			};
		}

		// Token: 0x060299A5 RID: 170405 RVA: 0x005B4E18 File Offset: 0x005B3018
		public ICommonBtTaskT AsICommonBtTask()
		{
			return this.As<ICommonBtTaskT>();
		}

		// Token: 0x060299A6 RID: 170406 RVA: 0x005B4E20 File Offset: 0x005B3020
		public static ICommonBtNodeBase_UnionUnion FromICommonBtTask(ICommonBtTaskT _icommonbttask)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtTask,
				Value = _icommonbttask
			};
		}

		// Token: 0x060299A7 RID: 170407 RVA: 0x005B4E35 File Offset: 0x005B3035
		public ICommonBtProbabilityT AsICommonBtProbability()
		{
			return this.As<ICommonBtProbabilityT>();
		}

		// Token: 0x060299A8 RID: 170408 RVA: 0x005B4E3D File Offset: 0x005B303D
		public static ICommonBtNodeBase_UnionUnion FromICommonBtProbability(ICommonBtProbabilityT _icommonbtprobability)
		{
			return new ICommonBtNodeBase_UnionUnion
			{
				Type = ICommonBtNodeBase_Union.ICommonBtProbability,
				Value = _icommonbtprobability
			};
		}

		// Token: 0x060299A9 RID: 170409 RVA: 0x005B4E54 File Offset: 0x005B3054
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
