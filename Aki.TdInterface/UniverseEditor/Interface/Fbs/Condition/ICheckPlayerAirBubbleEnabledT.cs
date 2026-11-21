using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FAB RID: 20395
	public class ICheckPlayerAirBubbleEnabledT
	{
		// Token: 0x170091E1 RID: 37345
		// (get) Token: 0x0601FC97 RID: 130199 RVA: 0x0046AA20 File Offset: 0x00468C20
		// (set) Token: 0x0601FC98 RID: 130200 RVA: 0x0046AA28 File Offset: 0x00468C28
		public EExploreSkillConditionType Type { get; set; }

		// Token: 0x170091E2 RID: 37346
		// (get) Token: 0x0601FC99 RID: 130201 RVA: 0x0046AA31 File Offset: 0x00468C31
		// (set) Token: 0x0601FC9A RID: 130202 RVA: 0x0046AA39 File Offset: 0x00468C39
		public bool IsEnabled { get; set; }

		// Token: 0x0601FC9B RID: 130203 RVA: 0x0046AA42 File Offset: 0x00468C42
		public ICheckPlayerAirBubbleEnabledT()
		{
			this.Type = EExploreSkillConditionType.PlayerAirBubbleEnabled;
			this.IsEnabled = false;
		}
	}
}
