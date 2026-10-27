using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287B RID: 10363
	public class ITraceTracingMaxStepRewardRuleItem
	{
		// Token: 0x0600E596 RID: 58774 RVA: 0x0021C078 File Offset: 0x0021A278
		[NullableContext(1)]
		public static ITraceTracingMaxStepRewardRuleItem Create(ITraceTracingMaxStepRewardRuleItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITraceTracingMaxStepRewardRuleItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x0021C097 File Offset: 0x0021A297
		public virtual int RestartCount
		{
			get
			{
				return this.Instance.RestartCount;
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x0600E598 RID: 58776 RVA: 0x0021C0A4 File Offset: 0x0021A2A4
		public virtual int AddStep
		{
			get
			{
				return this.Instance.AddStep;
			}
		}

		// Token: 0x04007EF7 RID: 32503
		private ITraceTracingMaxStepRewardRuleItem Instance;
	}
}
