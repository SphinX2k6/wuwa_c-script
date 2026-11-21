using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BA RID: 22714
	public class SolarSchoolInfluenceLevelAction : SolarSchoolActionBase
	{
		// Token: 0x06037F0D RID: 229133 RVA: 0x00FA2D7F File Offset: 0x00FA0F7F
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.Influence = (ESolarSchoolInfluence)ActivityActionBase.GetParamInt(parameters, "InfluenceId", 0);
			this.Level = ActivityActionBase.GetParamInt(parameters, "Level", 0);
		}

		// Token: 0x06037F0E RID: 229134 RVA: 0x00FA2DA5 File Offset: 0x00FA0FA5
		protected override void OnStart()
		{
			if (!SolarSchoolGamePlayModel.Instance.PlayerData.SetInfluenceLevel(this.Influence, this.Level))
			{
				base.MarkFailed();
				return;
			}
			base.MarkDone();
		}

		// Token: 0x0401D81C RID: 120860
		private ESolarSchoolInfluence Influence;

		// Token: 0x0401D81D RID: 120861
		private int Level;
	}
}
