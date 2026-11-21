using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E7 RID: 18407
	public class TPerformerAiNodeUnion
	{
		// Token: 0x17008066 RID: 32870
		// (get) Token: 0x0601B2EF RID: 111343 RVA: 0x003DA61C File Offset: 0x003D881C
		// (set) Token: 0x0601B2F0 RID: 111344 RVA: 0x003DA624 File Offset: 0x003D8824
		public TPerformerAiNode Type { get; set; }

		// Token: 0x17008067 RID: 32871
		// (get) Token: 0x0601B2F1 RID: 111345 RVA: 0x003DA62D File Offset: 0x003D882D
		// (set) Token: 0x0601B2F2 RID: 111346 RVA: 0x003DA635 File Offset: 0x003D8835
		public object Value { get; set; }

		// Token: 0x0601B2F3 RID: 111347 RVA: 0x003DA63E File Offset: 0x003D883E
		public TPerformerAiNodeUnion()
		{
			this.Type = TPerformerAiNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2F4 RID: 111348 RVA: 0x003DA654 File Offset: 0x003D8854
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2F5 RID: 111349 RVA: 0x003DA666 File Offset: 0x003D8866
		public IPerformerAiProbabilityT AsIPerformerAiProbability()
		{
			return this.As<IPerformerAiProbabilityT>();
		}

		// Token: 0x0601B2F6 RID: 111350 RVA: 0x003DA66E File Offset: 0x003D886E
		public static TPerformerAiNodeUnion FromIPerformerAiProbability(IPerformerAiProbabilityT _iperformeraiprobability)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiProbability,
				Value = _iperformeraiprobability
			};
		}

		// Token: 0x0601B2F7 RID: 111351 RVA: 0x003DA683 File Offset: 0x003D8883
		public IPerformerAiSelectorT AsIPerformerAiSelector()
		{
			return this.As<IPerformerAiSelectorT>();
		}

		// Token: 0x0601B2F8 RID: 111352 RVA: 0x003DA68B File Offset: 0x003D888B
		public static TPerformerAiNodeUnion FromIPerformerAiSelector(IPerformerAiSelectorT _iperformeraiselector)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiSelector,
				Value = _iperformeraiselector
			};
		}

		// Token: 0x0601B2F9 RID: 111353 RVA: 0x003DA6A0 File Offset: 0x003D88A0
		public IPerformerAiSequenceT AsIPerformerAiSequence()
		{
			return this.As<IPerformerAiSequenceT>();
		}

		// Token: 0x0601B2FA RID: 111354 RVA: 0x003DA6A8 File Offset: 0x003D88A8
		public static TPerformerAiNodeUnion FromIPerformerAiSequence(IPerformerAiSequenceT _iperformeraisequence)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiSequence,
				Value = _iperformeraisequence
			};
		}

		// Token: 0x0601B2FB RID: 111355 RVA: 0x003DA6BD File Offset: 0x003D88BD
		public IPerformerAiStartT AsIPerformerAiStart()
		{
			return this.As<IPerformerAiStartT>();
		}

		// Token: 0x0601B2FC RID: 111356 RVA: 0x003DA6C5 File Offset: 0x003D88C5
		public static TPerformerAiNodeUnion FromIPerformerAiStart(IPerformerAiStartT _iperformeraistart)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiStart,
				Value = _iperformeraistart
			};
		}

		// Token: 0x0601B2FD RID: 111357 RVA: 0x003DA6DA File Offset: 0x003D88DA
		public IPerformerAiTaskT AsIPerformerAiTask()
		{
			return this.As<IPerformerAiTaskT>();
		}

		// Token: 0x0601B2FE RID: 111358 RVA: 0x003DA6E2 File Offset: 0x003D88E2
		public static TPerformerAiNodeUnion FromIPerformerAiTask(IPerformerAiTaskT _iperformeraitask)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiTask,
				Value = _iperformeraitask
			};
		}

		// Token: 0x0601B2FF RID: 111359 RVA: 0x003DA6F8 File Offset: 0x003D88F8
		public static int Pack(FlatBufferBuilder builder, TPerformerAiNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TPerformerAiNode.IPerformerAiProbability:
				return IPerformerAiProbability.Pack(builder, _o.AsIPerformerAiProbability()).Value;
			case TPerformerAiNode.IPerformerAiSelector:
				return IPerformerAiSelector.Pack(builder, _o.AsIPerformerAiSelector()).Value;
			case TPerformerAiNode.IPerformerAiSequence:
				return IPerformerAiSequence.Pack(builder, _o.AsIPerformerAiSequence()).Value;
			case TPerformerAiNode.IPerformerAiStart:
				return IPerformerAiStart.Pack(builder, _o.AsIPerformerAiStart()).Value;
			case TPerformerAiNode.IPerformerAiTask:
				return IPerformerAiTask.Pack(builder, _o.AsIPerformerAiTask()).Value;
			default:
				return 0;
			}
		}
	}
}
