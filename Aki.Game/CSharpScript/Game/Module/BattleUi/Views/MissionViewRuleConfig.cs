using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC6 RID: 23750
	public class MissionViewRuleConfig : IStaticVariableResetter
	{
		// Token: 0x0603C0D7 RID: 245975 RVA: 0x00E5CB5F File Offset: 0x00E5AD5F
		static MissionViewRuleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MissionViewRuleConfig.CreateStaticDefaultValue), new Action(MissionViewRuleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0603C0D8 RID: 245976 RVA: 0x00E5CB7E File Offset: 0x00E5AD7E
		public static void CreateStaticDefaultValue()
		{
			MissionViewRuleConfig.specialDungeonRules = new TrackingDisplayRuleBase[]
			{
				new HonamiStoryTrackingRule(),
				new SpringManorTrackingRule()
			};
		}

		// Token: 0x0603C0D9 RID: 245977 RVA: 0x00E5CB9B File Offset: 0x00E5AD9B
		public static void ResetStaticDefaultValue()
		{
			MissionViewRuleConfig.specialDungeonRules = null;
		}

		// Token: 0x0401F517 RID: 128279
		[Nullable(1)]
		public static TrackingDisplayRuleBase[] specialDungeonRules;
	}
}
