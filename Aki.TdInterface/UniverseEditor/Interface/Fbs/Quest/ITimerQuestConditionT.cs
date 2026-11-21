using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004635 RID: 17973
	public class ITimerQuestConditionT
	{
		// Token: 0x17007DC0 RID: 32192
		// (get) Token: 0x0601A4EE RID: 107758 RVA: 0x003BEBB6 File Offset: 0x003BCDB6
		// (set) Token: 0x0601A4EF RID: 107759 RVA: 0x003BEBBE File Offset: 0x003BCDBE
		public EChildQuest Type { get; set; }

		// Token: 0x17007DC1 RID: 32193
		// (get) Token: 0x0601A4F0 RID: 107760 RVA: 0x003BEBC7 File Offset: 0x003BCDC7
		// (set) Token: 0x0601A4F1 RID: 107761 RVA: 0x003BEBCF File Offset: 0x003BCDCF
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007DC2 RID: 32194
		// (get) Token: 0x0601A4F2 RID: 107762 RVA: 0x003BEBD8 File Offset: 0x003BCDD8
		// (set) Token: 0x0601A4F3 RID: 107763 RVA: 0x003BEBE0 File Offset: 0x003BCDE0
		public int Time { get; set; }

		// Token: 0x17007DC3 RID: 32195
		// (get) Token: 0x0601A4F4 RID: 107764 RVA: 0x003BEBE9 File Offset: 0x003BCDE9
		// (set) Token: 0x0601A4F5 RID: 107765 RVA: 0x003BEBF1 File Offset: 0x003BCDF1
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x17007DC4 RID: 32196
		// (get) Token: 0x0601A4F6 RID: 107766 RVA: 0x003BEBFA File Offset: 0x003BCDFA
		// (set) Token: 0x0601A4F7 RID: 107767 RVA: 0x003BEC02 File Offset: 0x003BCE02
		public ETimerType TimerType { get; set; }

		// Token: 0x17007DC5 RID: 32197
		// (get) Token: 0x0601A4F8 RID: 107768 RVA: 0x003BEC0B File Offset: 0x003BCE0B
		// (set) Token: 0x0601A4F9 RID: 107769 RVA: 0x003BEC13 File Offset: 0x003BCE13
		public ITimerUiConfigT UiConfig { get; set; }

		// Token: 0x17007DC6 RID: 32198
		// (get) Token: 0x0601A4FA RID: 107770 RVA: 0x003BEC1C File Offset: 0x003BCE1C
		// (set) Token: 0x0601A4FB RID: 107771 RVA: 0x003BEC24 File Offset: 0x003BCE24
		public byte NullMask { get; set; }

		// Token: 0x0601A4FC RID: 107772 RVA: 0x003BEC2D File Offset: 0x003BCE2D
		public ITimerQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Time = 0;
			this.VarForTime = null;
			this.TimerType = ETimerType.CountDownChallenge;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
