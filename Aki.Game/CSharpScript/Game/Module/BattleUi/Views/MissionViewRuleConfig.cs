using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA8 RID: 19624
	public class MissionViewRuleConfig : IStaticVariableResetter
	{
		// Token: 0x0603102C RID: 200748 RVA: 0x00DAD273 File Offset: 0x00DAB473
		static MissionViewRuleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MissionViewRuleConfig.CreateStaticDefaultValue), new Action(MissionViewRuleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0603102D RID: 200749 RVA: 0x00DAD292 File Offset: 0x00DAB492
		public static void CreateStaticDefaultValue()
		{
			MissionViewRuleConfig.specialDungeonRules = new TrackingDisplayRuleBase[]
			{
				new HonamiStoryTrackingRule(),
				new SpringManorTrackingRule()
			};
		}

		// Token: 0x0603102E RID: 200750 RVA: 0x00DAD2AF File Offset: 0x00DAB4AF
		public static void ResetStaticDefaultValue()
		{
			MissionViewRuleConfig.specialDungeonRules = null;
		}

		// Token: 0x04019FD0 RID: 106448
		[Nullable(1)]
		public static TrackingDisplayRuleBase[] specialDungeonRules;
	}
}
