using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F8 RID: 17400
	public class IProgramSpecialProcessT
	{
		// Token: 0x170077E9 RID: 30697
		// (get) Token: 0x06018BB9 RID: 101305 RVA: 0x0038674D File Offset: 0x0038494D
		// (set) Token: 0x06018BBA RID: 101306 RVA: 0x00386755 File Offset: 0x00384955
		public EChildQuest Type { get; set; }

		// Token: 0x170077EA RID: 30698
		// (get) Token: 0x06018BBB RID: 101307 RVA: 0x0038675E File Offset: 0x0038495E
		// (set) Token: 0x06018BBC RID: 101308 RVA: 0x00386766 File Offset: 0x00384966
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170077EB RID: 30699
		// (get) Token: 0x06018BBD RID: 101309 RVA: 0x0038676F File Offset: 0x0038496F
		// (set) Token: 0x06018BBE RID: 101310 RVA: 0x00386777 File Offset: 0x00384977
		public ILowMemorySceneSwitchT SpecialProcess { get; set; }

		// Token: 0x06018BBF RID: 101311 RVA: 0x00386780 File Offset: 0x00384980
		public IProgramSpecialProcessT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SpecialProcess = null;
		}
	}
}
