using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C2 RID: 22722
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolSkipDaysAction : SolarSchoolActionBase
	{
		// Token: 0x06037F45 RID: 229189 RVA: 0x00FA4462 File Offset: 0x00FA2662
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.TargetDayIndex = ActivityActionBase.GetParamInt(parameters, "TargetDayIndex", 0);
		}

		// Token: 0x06037F46 RID: 229190 RVA: 0x00FA4476 File Offset: 0x00FA2676
		protected override void OnStart()
		{
			if (!SolarSchoolGamePlayModel.Instance.TrySetPendingTargetDay(this.TargetDayIndex))
			{
				base.MarkFailed();
				return;
			}
			base.MarkDone();
		}

		// Token: 0x0401D847 RID: 120903
		public const string ParamKeyTargetDayIndex = "TargetDayIndex";

		// Token: 0x0401D848 RID: 120904
		private int TargetDayIndex;
	}
}
