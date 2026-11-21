using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BF RID: 22719
	public class SolarSchoolRewardAction : SolarSchoolActionBase
	{
		// Token: 0x06037F39 RID: 229177 RVA: 0x00FA41F2 File Offset: 0x00FA23F2
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.RewardId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolRewardId", this.RewardId);
		}

		// Token: 0x06037F3A RID: 229178 RVA: 0x00FA420B File Offset: 0x00FA240B
		protected override void OnStart()
		{
			if (!SolarSchoolRewardCenter.Instance.TryGiveReward(this.RewardId))
			{
				base.MarkFailed();
				return;
			}
			base.MarkDone();
		}

		// Token: 0x0401D842 RID: 120898
		private int RewardId;
	}
}
