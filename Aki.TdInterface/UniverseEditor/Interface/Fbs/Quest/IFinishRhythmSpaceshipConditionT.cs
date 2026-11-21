using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427E RID: 17022
	public class IFinishRhythmSpaceshipConditionT
	{
		// Token: 0x17007433 RID: 29747
		// (get) Token: 0x06017C0B RID: 97291 RVA: 0x003637D9 File Offset: 0x003619D9
		// (set) Token: 0x06017C0C RID: 97292 RVA: 0x003637E1 File Offset: 0x003619E1
		public EChildQuest Type { get; set; }

		// Token: 0x17007434 RID: 29748
		// (get) Token: 0x06017C0D RID: 97293 RVA: 0x003637EA File Offset: 0x003619EA
		// (set) Token: 0x06017C0E RID: 97294 RVA: 0x003637F2 File Offset: 0x003619F2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007435 RID: 29749
		// (get) Token: 0x06017C0F RID: 97295 RVA: 0x003637FB File Offset: 0x003619FB
		// (set) Token: 0x06017C10 RID: 97296 RVA: 0x00363803 File Offset: 0x00361A03
		public IRhythmSpaceshipConditionStepInteractT Step { get; set; }

		// Token: 0x06017C11 RID: 97297 RVA: 0x0036380C File Offset: 0x00361A0C
		public IFinishRhythmSpaceshipConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
		}
	}
}
