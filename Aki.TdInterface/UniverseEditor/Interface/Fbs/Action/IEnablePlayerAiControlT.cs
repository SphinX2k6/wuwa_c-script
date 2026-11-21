using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF0 RID: 27888
	public class IEnablePlayerAiControlT
	{
		// Token: 0x1700CC86 RID: 52358
		// (get) Token: 0x0603013A RID: 196922 RVA: 0x0068A4E0 File Offset: 0x006886E0
		// (set) Token: 0x0603013B RID: 196923 RVA: 0x0068A4E8 File Offset: 0x006886E8
		public EPlayerAiControlType Type { get; set; }

		// Token: 0x1700CC87 RID: 52359
		// (get) Token: 0x0603013C RID: 196924 RVA: 0x0068A4F1 File Offset: 0x006886F1
		// (set) Token: 0x0603013D RID: 196925 RVA: 0x0068A4F9 File Offset: 0x006886F9
		public int BehaviorTree { get; set; }

		// Token: 0x0603013E RID: 196926 RVA: 0x0068A502 File Offset: 0x00688702
		public IEnablePlayerAiControlT()
		{
			this.Type = EPlayerAiControlType.Enable;
			this.BehaviorTree = 0;
		}
	}
}
