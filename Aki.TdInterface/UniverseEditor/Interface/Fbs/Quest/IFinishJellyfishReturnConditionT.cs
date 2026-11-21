using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004275 RID: 17013
	public class IFinishJellyfishReturnConditionT
	{
		// Token: 0x17007416 RID: 29718
		// (get) Token: 0x06017B9C RID: 97180 RVA: 0x0036262D File Offset: 0x0036082D
		// (set) Token: 0x06017B9D RID: 97181 RVA: 0x00362635 File Offset: 0x00360835
		public EChildQuest Type { get; set; }

		// Token: 0x17007417 RID: 29719
		// (get) Token: 0x06017B9E RID: 97182 RVA: 0x0036263E File Offset: 0x0036083E
		// (set) Token: 0x06017B9F RID: 97183 RVA: 0x00362646 File Offset: 0x00360846
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007418 RID: 29720
		// (get) Token: 0x06017BA0 RID: 97184 RVA: 0x0036264F File Offset: 0x0036084F
		// (set) Token: 0x06017BA1 RID: 97185 RVA: 0x00362657 File Offset: 0x00360857
		public int StartPosEntityId { get; set; }

		// Token: 0x17007419 RID: 29721
		// (get) Token: 0x06017BA2 RID: 97186 RVA: 0x00362660 File Offset: 0x00360860
		// (set) Token: 0x06017BA3 RID: 97187 RVA: 0x00362668 File Offset: 0x00360868
		public float StartRadius { get; set; }

		// Token: 0x1700741A RID: 29722
		// (get) Token: 0x06017BA4 RID: 97188 RVA: 0x00362671 File Offset: 0x00360871
		// (set) Token: 0x06017BA5 RID: 97189 RVA: 0x00362679 File Offset: 0x00360879
		public int EndPosEntityId { get; set; }

		// Token: 0x1700741B RID: 29723
		// (get) Token: 0x06017BA6 RID: 97190 RVA: 0x00362682 File Offset: 0x00360882
		// (set) Token: 0x06017BA7 RID: 97191 RVA: 0x0036268A File Offset: 0x0036088A
		public float EndRadius { get; set; }

		// Token: 0x1700741C RID: 29724
		// (get) Token: 0x06017BA8 RID: 97192 RVA: 0x00362693 File Offset: 0x00360893
		// (set) Token: 0x06017BA9 RID: 97193 RVA: 0x0036269B File Offset: 0x0036089B
		public string LevelConfigDa { get; set; }

		// Token: 0x06017BAA RID: 97194 RVA: 0x003626A4 File Offset: 0x003608A4
		public IFinishJellyfishReturnConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.StartPosEntityId = 0;
			this.StartRadius = 0f;
			this.EndPosEntityId = 0;
			this.EndRadius = 0f;
			this.LevelConfigDa = null;
		}
	}
}
