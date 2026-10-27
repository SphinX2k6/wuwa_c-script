using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AE RID: 10670
	public class ExecRiskHarvestEffect : ActionParams
	{
		// Token: 0x0600EC11 RID: 60433 RVA: 0x00227E33 File Offset: 0x00226033
		[NullableContext(1)]
		public static ExecRiskHarvestEffect Create(IExecRiskHarvestEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecRiskHarvestEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x0600EC12 RID: 60434 RVA: 0x00227E52 File Offset: 0x00226052
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008200 RID: 33280
		private IExecRiskHarvestEffect Instance;
	}
}
