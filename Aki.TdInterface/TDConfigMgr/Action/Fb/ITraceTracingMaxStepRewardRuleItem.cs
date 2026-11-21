using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B51 RID: 11089
	public class ITraceTracingMaxStepRewardRuleItem
	{
		// Token: 0x0600F3C7 RID: 62407 RVA: 0x00238FCC File Offset: 0x002371CC
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

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x00238FEB File Offset: 0x002371EB
		public virtual int RestartCount
		{
			get
			{
				return this.Instance.RestartCount;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0600F3C9 RID: 62409 RVA: 0x00238FF8 File Offset: 0x002371F8
		public virtual int AddStep
		{
			get
			{
				return this.Instance.AddStep;
			}
		}

		// Token: 0x040085B7 RID: 34231
		private ITraceTracingMaxStepRewardRuleItem Instance;
	}
}
