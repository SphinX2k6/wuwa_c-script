using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC1 RID: 23745
	public static class EMissionRuleIdExtensions
	{
		// Token: 0x0603C0BE RID: 245950 RVA: 0x00E5C844 File Offset: 0x00E5AA44
		[NullableContext(1)]
		public static string ToString(this EMissionRuleId ruleId)
		{
			string result;
			switch (ruleId)
			{
			case EMissionRuleId.Default:
				result = "default";
				break;
			case EMissionRuleId.HonamiStory:
				result = "honamiStory";
				break;
			case EMissionRuleId.SpringManor:
				result = "springManor";
				break;
			default:
				result = ruleId.ToString();
				break;
			}
			return result;
		}
	}
}
