using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426C RID: 17004
	public class IFinishBvbChallengeT
	{
		// Token: 0x170073FD RID: 29693
		// (get) Token: 0x06017B40 RID: 97088 RVA: 0x003618FD File Offset: 0x0035FAFD
		// (set) Token: 0x06017B41 RID: 97089 RVA: 0x00361905 File Offset: 0x0035FB05
		public EChildQuest Type { get; set; }

		// Token: 0x170073FE RID: 29694
		// (get) Token: 0x06017B42 RID: 97090 RVA: 0x0036190E File Offset: 0x0035FB0E
		// (set) Token: 0x06017B43 RID: 97091 RVA: 0x00361916 File Offset: 0x0035FB16
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170073FF RID: 29695
		// (get) Token: 0x06017B44 RID: 97092 RVA: 0x0036191F File Offset: 0x0035FB1F
		// (set) Token: 0x06017B45 RID: 97093 RVA: 0x00361927 File Offset: 0x0035FB27
		public int BvbChallengeId { get; set; }

		// Token: 0x06017B46 RID: 97094 RVA: 0x00361930 File Offset: 0x0035FB30
		public IFinishBvbChallengeT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.BvbChallengeId = 0;
		}
	}
}
