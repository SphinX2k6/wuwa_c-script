using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004370 RID: 17264
	public class IPerformerAiNodeBase_UnionUnion
	{
		// Token: 0x170079D8 RID: 31192
		// (get) Token: 0x060199CC RID: 104908 RVA: 0x003AA5E6 File Offset: 0x003A87E6
		// (set) Token: 0x060199CD RID: 104909 RVA: 0x003AA5EE File Offset: 0x003A87EE
		public IPerformerAiNodeBase_Union Type { get; set; }

		// Token: 0x170079D9 RID: 31193
		// (get) Token: 0x060199CE RID: 104910 RVA: 0x003AA5F7 File Offset: 0x003A87F7
		// (set) Token: 0x060199CF RID: 104911 RVA: 0x003AA5FF File Offset: 0x003A87FF
		public object Value { get; set; }

		// Token: 0x060199D0 RID: 104912 RVA: 0x003AA608 File Offset: 0x003A8808
		public IPerformerAiNodeBase_UnionUnion()
		{
			this.Type = IPerformerAiNodeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060199D1 RID: 104913 RVA: 0x003AA61E File Offset: 0x003A881E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060199D2 RID: 104914 RVA: 0x003AA630 File Offset: 0x003A8830
		public IPerformerAiNodeBaseT AsIPerformerAiNodeBase()
		{
			return this.As<IPerformerAiNodeBaseT>();
		}

		// Token: 0x060199D3 RID: 104915 RVA: 0x003AA638 File Offset: 0x003A8838
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiNodeBase(IPerformerAiNodeBaseT _iperformerainodebase)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiNodeBase,
				Value = _iperformerainodebase
			};
		}

		// Token: 0x060199D4 RID: 104916 RVA: 0x003AA64D File Offset: 0x003A884D
		public IPerformerAiStartT AsIPerformerAiStart()
		{
			return this.As<IPerformerAiStartT>();
		}

		// Token: 0x060199D5 RID: 104917 RVA: 0x003AA655 File Offset: 0x003A8855
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiStart(IPerformerAiStartT _iperformeraistart)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiStart,
				Value = _iperformeraistart
			};
		}

		// Token: 0x060199D6 RID: 104918 RVA: 0x003AA66A File Offset: 0x003A886A
		public IPerformerAiSequenceT AsIPerformerAiSequence()
		{
			return this.As<IPerformerAiSequenceT>();
		}

		// Token: 0x060199D7 RID: 104919 RVA: 0x003AA672 File Offset: 0x003A8872
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiSequence(IPerformerAiSequenceT _iperformeraisequence)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiSequence,
				Value = _iperformeraisequence
			};
		}

		// Token: 0x060199D8 RID: 104920 RVA: 0x003AA687 File Offset: 0x003A8887
		public IPerformerAiSelectorT AsIPerformerAiSelector()
		{
			return this.As<IPerformerAiSelectorT>();
		}

		// Token: 0x060199D9 RID: 104921 RVA: 0x003AA68F File Offset: 0x003A888F
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiSelector(IPerformerAiSelectorT _iperformeraiselector)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiSelector,
				Value = _iperformeraiselector
			};
		}

		// Token: 0x060199DA RID: 104922 RVA: 0x003AA6A4 File Offset: 0x003A88A4
		public IPerformerAiTaskT AsIPerformerAiTask()
		{
			return this.As<IPerformerAiTaskT>();
		}

		// Token: 0x060199DB RID: 104923 RVA: 0x003AA6AC File Offset: 0x003A88AC
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiTask(IPerformerAiTaskT _iperformeraitask)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiTask,
				Value = _iperformeraitask
			};
		}

		// Token: 0x060199DC RID: 104924 RVA: 0x003AA6C1 File Offset: 0x003A88C1
		public IPerformerAiProbabilityT AsIPerformerAiProbability()
		{
			return this.As<IPerformerAiProbabilityT>();
		}

		// Token: 0x060199DD RID: 104925 RVA: 0x003AA6C9 File Offset: 0x003A88C9
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiProbability(IPerformerAiProbabilityT _iperformeraiprobability)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiProbability,
				Value = _iperformeraiprobability
			};
		}

		// Token: 0x060199DE RID: 104926 RVA: 0x003AA6E0 File Offset: 0x003A88E0
		public static int Pack(FlatBufferBuilder builder, IPerformerAiNodeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPerformerAiNodeBase_Union.IPerformerAiNodeBase:
				return IPerformerAiNodeBase.Pack(builder, _o.AsIPerformerAiNodeBase()).Value;
			case IPerformerAiNodeBase_Union.IPerformerAiStart:
				return IPerformerAiStart.Pack(builder, _o.AsIPerformerAiStart()).Value;
			case IPerformerAiNodeBase_Union.IPerformerAiSequence:
				return IPerformerAiSequence.Pack(builder, _o.AsIPerformerAiSequence()).Value;
			case IPerformerAiNodeBase_Union.IPerformerAiSelector:
				return IPerformerAiSelector.Pack(builder, _o.AsIPerformerAiSelector()).Value;
			case IPerformerAiNodeBase_Union.IPerformerAiTask:
				return IPerformerAiTask.Pack(builder, _o.AsIPerformerAiTask()).Value;
			case IPerformerAiNodeBase_Union.IPerformerAiProbability:
				return IPerformerAiProbability.Pack(builder, _o.AsIPerformerAiProbability()).Value;
			default:
				return 0;
			}
		}
	}
}
