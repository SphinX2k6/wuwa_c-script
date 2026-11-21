using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA3 RID: 19619
	public static class EMissionRuleIdExtensions
	{
		// Token: 0x06031013 RID: 200723 RVA: 0x00DACF58 File Offset: 0x00DAB158
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
