using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D2 RID: 18386
	public class IPerformerAiNodeBase_UnionUnion
	{
		// Token: 0x1700800D RID: 32781
		// (get) Token: 0x0601B15A RID: 110938 RVA: 0x003D600E File Offset: 0x003D420E
		// (set) Token: 0x0601B15B RID: 110939 RVA: 0x003D6016 File Offset: 0x003D4216
		public IPerformerAiNodeBase_Union Type { get; set; }

		// Token: 0x1700800E RID: 32782
		// (get) Token: 0x0601B15C RID: 110940 RVA: 0x003D601F File Offset: 0x003D421F
		// (set) Token: 0x0601B15D RID: 110941 RVA: 0x003D6027 File Offset: 0x003D4227
		public object Value { get; set; }

		// Token: 0x0601B15E RID: 110942 RVA: 0x003D6030 File Offset: 0x003D4230
		public IPerformerAiNodeBase_UnionUnion()
		{
			this.Type = IPerformerAiNodeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B15F RID: 110943 RVA: 0x003D6046 File Offset: 0x003D4246
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B160 RID: 110944 RVA: 0x003D6058 File Offset: 0x003D4258
		public IPerformerAiNodeBaseT AsIPerformerAiNodeBase()
		{
			return this.As<IPerformerAiNodeBaseT>();
		}

		// Token: 0x0601B161 RID: 110945 RVA: 0x003D6060 File Offset: 0x003D4260
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiNodeBase(IPerformerAiNodeBaseT _iperformerainodebase)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiNodeBase,
				Value = _iperformerainodebase
			};
		}

		// Token: 0x0601B162 RID: 110946 RVA: 0x003D6075 File Offset: 0x003D4275
		public IPerformerAiStartT AsIPerformerAiStart()
		{
			return this.As<IPerformerAiStartT>();
		}

		// Token: 0x0601B163 RID: 110947 RVA: 0x003D607D File Offset: 0x003D427D
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiStart(IPerformerAiStartT _iperformeraistart)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiStart,
				Value = _iperformeraistart
			};
		}

		// Token: 0x0601B164 RID: 110948 RVA: 0x003D6092 File Offset: 0x003D4292
		public IPerformerAiSequenceT AsIPerformerAiSequence()
		{
			return this.As<IPerformerAiSequenceT>();
		}

		// Token: 0x0601B165 RID: 110949 RVA: 0x003D609A File Offset: 0x003D429A
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiSequence(IPerformerAiSequenceT _iperformeraisequence)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiSequence,
				Value = _iperformeraisequence
			};
		}

		// Token: 0x0601B166 RID: 110950 RVA: 0x003D60AF File Offset: 0x003D42AF
		public IPerformerAiSelectorT AsIPerformerAiSelector()
		{
			return this.As<IPerformerAiSelectorT>();
		}

		// Token: 0x0601B167 RID: 110951 RVA: 0x003D60B7 File Offset: 0x003D42B7
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiSelector(IPerformerAiSelectorT _iperformeraiselector)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiSelector,
				Value = _iperformeraiselector
			};
		}

		// Token: 0x0601B168 RID: 110952 RVA: 0x003D60CC File Offset: 0x003D42CC
		public IPerformerAiTaskT AsIPerformerAiTask()
		{
			return this.As<IPerformerAiTaskT>();
		}

		// Token: 0x0601B169 RID: 110953 RVA: 0x003D60D4 File Offset: 0x003D42D4
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiTask(IPerformerAiTaskT _iperformeraitask)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiTask,
				Value = _iperformeraitask
			};
		}

		// Token: 0x0601B16A RID: 110954 RVA: 0x003D60E9 File Offset: 0x003D42E9
		public IPerformerAiProbabilityT AsIPerformerAiProbability()
		{
			return this.As<IPerformerAiProbabilityT>();
		}

		// Token: 0x0601B16B RID: 110955 RVA: 0x003D60F1 File Offset: 0x003D42F1
		public static IPerformerAiNodeBase_UnionUnion FromIPerformerAiProbability(IPerformerAiProbabilityT _iperformeraiprobability)
		{
			return new IPerformerAiNodeBase_UnionUnion
			{
				Type = IPerformerAiNodeBase_Union.IPerformerAiProbability,
				Value = _iperformeraiprobability
			};
		}

		// Token: 0x0601B16C RID: 110956 RVA: 0x003D6108 File Offset: 0x003D4308
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
