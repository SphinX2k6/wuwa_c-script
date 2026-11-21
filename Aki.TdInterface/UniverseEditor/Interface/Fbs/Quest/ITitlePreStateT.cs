using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463E RID: 17982
	public class ITitlePreStateT
	{
		// Token: 0x17007DDA RID: 32218
		// (get) Token: 0x0601A54A RID: 107850 RVA: 0x003BF6F7 File Offset: 0x003BD8F7
		// (set) Token: 0x0601A54B RID: 107851 RVA: 0x003BF6FF File Offset: 0x003BD8FF
		public string TidPreStateTitle { get; set; }

		// Token: 0x17007DDB RID: 32219
		// (get) Token: 0x0601A54C RID: 107852 RVA: 0x003BF708 File Offset: 0x003BD908
		// (set) Token: 0x0601A54D RID: 107853 RVA: 0x003BF710 File Offset: 0x003BD910
		public IConditionGroupT SwitchConditions { get; set; }

		// Token: 0x0601A54E RID: 107854 RVA: 0x003BF719 File Offset: 0x003BD919
		public ITitlePreStateT()
		{
			this.TidPreStateTitle = null;
			this.SwitchConditions = null;
		}
	}
}
