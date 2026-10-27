using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004385 RID: 17285
	public class TPerformerAiNodeUnion
	{
		// Token: 0x17007A31 RID: 31281
		// (get) Token: 0x06019B61 RID: 105313 RVA: 0x003AEBF4 File Offset: 0x003ACDF4
		// (set) Token: 0x06019B62 RID: 105314 RVA: 0x003AEBFC File Offset: 0x003ACDFC
		public TPerformerAiNode Type { get; set; }

		// Token: 0x17007A32 RID: 31282
		// (get) Token: 0x06019B63 RID: 105315 RVA: 0x003AEC05 File Offset: 0x003ACE05
		// (set) Token: 0x06019B64 RID: 105316 RVA: 0x003AEC0D File Offset: 0x003ACE0D
		public object Value { get; set; }

		// Token: 0x06019B65 RID: 105317 RVA: 0x003AEC16 File Offset: 0x003ACE16
		public TPerformerAiNodeUnion()
		{
			this.Type = TPerformerAiNode.NONE;
			this.Value = null;
		}

		// Token: 0x06019B66 RID: 105318 RVA: 0x003AEC2C File Offset: 0x003ACE2C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019B67 RID: 105319 RVA: 0x003AEC3E File Offset: 0x003ACE3E
		public IPerformerAiProbabilityT AsIPerformerAiProbability()
		{
			return this.As<IPerformerAiProbabilityT>();
		}

		// Token: 0x06019B68 RID: 105320 RVA: 0x003AEC46 File Offset: 0x003ACE46
		public static TPerformerAiNodeUnion FromIPerformerAiProbability(IPerformerAiProbabilityT _iperformeraiprobability)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiProbability,
				Value = _iperformeraiprobability
			};
		}

		// Token: 0x06019B69 RID: 105321 RVA: 0x003AEC5B File Offset: 0x003ACE5B
		public IPerformerAiSelectorT AsIPerformerAiSelector()
		{
			return this.As<IPerformerAiSelectorT>();
		}

		// Token: 0x06019B6A RID: 105322 RVA: 0x003AEC63 File Offset: 0x003ACE63
		public static TPerformerAiNodeUnion FromIPerformerAiSelector(IPerformerAiSelectorT _iperformeraiselector)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiSelector,
				Value = _iperformeraiselector
			};
		}

		// Token: 0x06019B6B RID: 105323 RVA: 0x003AEC78 File Offset: 0x003ACE78
		public IPerformerAiSequenceT AsIPerformerAiSequence()
		{
			return this.As<IPerformerAiSequenceT>();
		}

		// Token: 0x06019B6C RID: 105324 RVA: 0x003AEC80 File Offset: 0x003ACE80
		public static TPerformerAiNodeUnion FromIPerformerAiSequence(IPerformerAiSequenceT _iperformeraisequence)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiSequence,
				Value = _iperformeraisequence
			};
		}

		// Token: 0x06019B6D RID: 105325 RVA: 0x003AEC95 File Offset: 0x003ACE95
		public IPerformerAiStartT AsIPerformerAiStart()
		{
			return this.As<IPerformerAiStartT>();
		}

		// Token: 0x06019B6E RID: 105326 RVA: 0x003AEC9D File Offset: 0x003ACE9D
		public static TPerformerAiNodeUnion FromIPerformerAiStart(IPerformerAiStartT _iperformeraistart)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiStart,
				Value = _iperformeraistart
			};
		}

		// Token: 0x06019B6F RID: 105327 RVA: 0x003AECB2 File Offset: 0x003ACEB2
		public IPerformerAiTaskT AsIPerformerAiTask()
		{
			return this.As<IPerformerAiTaskT>();
		}

		// Token: 0x06019B70 RID: 105328 RVA: 0x003AECBA File Offset: 0x003ACEBA
		public static TPerformerAiNodeUnion FromIPerformerAiTask(IPerformerAiTaskT _iperformeraitask)
		{
			return new TPerformerAiNodeUnion
			{
				Type = TPerformerAiNode.IPerformerAiTask,
				Value = _iperformeraitask
			};
		}

		// Token: 0x06019B71 RID: 105329 RVA: 0x003AECD0 File Offset: 0x003ACED0
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
